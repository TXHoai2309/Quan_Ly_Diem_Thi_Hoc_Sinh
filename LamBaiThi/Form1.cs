using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LamBaiThi
{
    public partial class FormLamBaiThi : Form
    {
        private Dictionary<int, string> cauTraLoiHS = new Dictionary<int, string>();

        private string maBaiThi;
        private List<CauHoi> danhSachCauHoi;
        private int cauHoiHienTai = 0;
        private string maHocSinh;
        private Timer timer;      // Timer để đếm ngược
        private int timeLeft = 300; // 5 phút = 300 giây
        public FormLamBaiThi() { 
            InitializeComponent();
          
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = sender as CheckBox;

            if (clickedCheckBox.Checked)
            {
                // Đảm bảo chỉ một CheckBox được chọn
                chkDapAn1.Checked = clickedCheckBox == chkDapAn1;
                chkDapAn2.Checked = clickedCheckBox == chkDapAn2;
                chkDapAn3.Checked = clickedCheckBox == chkDapAn3;
                chkDapAn4.Checked = clickedCheckBox == chkDapAn4;

                // Lưu câu trả lời của học sinh
                cauTraLoiHS[cauHoiHienTai] = clickedCheckBox.Tag.ToString();
            }
        }
        public FormLamBaiThi(string maHS)
        {
            InitializeComponent();
            maHocSinh = maHS;
            LoadCauHoi();
            labelMaHocSinh.Text = "Mã học sinh: " + maHocSinh; // Hiển thị mã học sinh  
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--; // Giảm thời gian
                lblThoiGian.Text = $"Thời gian còn lại: {timeLeft / 60} phút {timeLeft % 60} giây"; // Cập nhật UI
            }
            else
            {
                timer.Stop(); // Dừng Timer khi hết thời gian
                MessageBox.Show("Hết thời gian! Bài thi sẽ được nộp tự động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChamDiem(); // Chấm điểm bài thi
            }
        }

        private void FormLamBaiThi_Load(object sender, EventArgs e)
        {
                LoadCauHoi();
            timer = new Timer();
            timer.Interval = 1000; // 1 giây
            timer.Tick += Timer_Tick;
            timer.Start();

            // Gán sự kiện cho CheckBox
            chkDapAn1.CheckedChanged += CheckBox_CheckedChanged;
            chkDapAn2.CheckedChanged += CheckBox_CheckedChanged;
            chkDapAn3.CheckedChanged += CheckBox_CheckedChanged;
            chkDapAn4.CheckedChanged += CheckBox_CheckedChanged;

        }
        
        private void Shuffle<T>(List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                (list[n], list[k]) = (list[k], list[n]); // Hoán đổi vị trí
            }
        }

        private string LayBaiThiNgauNhien()
        {
            string maBaiThi = "";
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_LayBaiThiNgauNhien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    object result = cmd.ExecuteScalar();
                    if (result != null) maBaiThi = result.ToString();
                }
            }
            return maBaiThi;
        }
        private void LoadCauHoi()
        {
            maBaiThi = LayBaiThiNgauNhien();
            lblMaBaiThi.Text = $"Mã Bài Thi: {maBaiThi}"; // Hiển thị mã bài thi
            danhSachCauHoi = new List<CauHoi>();

            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_LayCauHoiBaiThi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaBaiThi", maBaiThi);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string dapAnDung = reader["DapAnDung"].ToString();
                            List<string> dapAnSai = TaoDapAnSai(dapAnDung); // Random 3 đáp án sai

                            CauHoi ch = new CauHoi()
                            {
                                MaCauHoi = reader["MaCauHoi"].ToString(),
                                NoiDung = reader["NoiDung"].ToString(),
                                DapAnDung = dapAnDung,
                                DapAnSai1 = dapAnSai[0],
                                DapAnSai2 = dapAnSai[1],
                                DapAnSai3 = dapAnSai[2],
                            };

                            danhSachCauHoi.Add(ch);
                        }
                    }
                }
            }

            if (danhSachCauHoi.Count == 10)
            {
                HienThiCauHoi();
            }
            else
            {
                MessageBox.Show("Không tìm thấy bài thi hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> TaoDapAnSai(string dapAnDung)
        {
            Random rand = new Random();
            List<string> dapAnSai = new List<string>();

            // Nếu đáp án là số -> sinh đáp án sai bằng số
            if (int.TryParse(dapAnDung, out int dapAnDungSo))
            {
                while (dapAnSai.Count < 3)
                {
                    int sai = rand.Next(1, 20);
                    string dapAnSaiMoi = (dapAnDungSo + sai).ToString();

                    if (!dapAnSai.Contains(dapAnSaiMoi) && dapAnSaiMoi != dapAnDung)
                    {
                        dapAnSai.Add(dapAnSaiMoi);
                    }
                }
            }
            else // Nếu đáp án là chữ -> sinh đáp án sai bằng cách tráo đổi ký tự
            {
                while (dapAnSai.Count < 3)
                {
                    string dapAnSaiMoi = new string(dapAnDung.OrderBy(c => rand.Next()).ToArray());

                    if (!dapAnSai.Contains(dapAnSaiMoi) && dapAnSaiMoi != dapAnDung)
                    {
                        dapAnSai.Add(dapAnSaiMoi);
                    }
                }
            }
            return dapAnSai;
        }

        private void HienThiCauHoi()
        {
            if (cauHoiHienTai >= danhSachCauHoi.Count)
            {
                toolStripStatusLabel1.Text = "Bạn đã hoàn thành bài bài";
                Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây
                ChamDiem();
                return;
            }

            // Lấy câu hỏi hiện tại
            CauHoi ch = danhSachCauHoi[cauHoiHienTai];
            lblCauHoi.Text = $"Câu {cauHoiHienTai + 1}: {ch.NoiDung}";

            // Tạo danh sách đáp án gồm cả đáp án đúng và 3 đáp án sai
            List<string> dapAn = new List<string> { ch.DapAnDung, ch.DapAnSai1, ch.DapAnSai2, ch.DapAnSai3 };

            // Trộn thứ tự ngẫu nhiên để tránh cố định vị trí
            Shuffle(dapAn);

            // Hiển thị lên các CheckBox
            chkDapAn1.Text = dapAn[0];
            chkDapAn2.Text = dapAn[1];
            chkDapAn3.Text = dapAn[2];
            chkDapAn4.Text = dapAn[3];

            // Gán Tag để lưu đáp án đúng
            chkDapAn1.Tag = dapAn[0];
            chkDapAn2.Tag = dapAn[1];
            chkDapAn3.Tag = dapAn[2];
            chkDapAn4.Tag = dapAn[3];

            // Xóa tất cả lựa chọn trước khi kiểm tra đáp án đã chọn trước đó
            chkDapAn1.Checked = false;
            chkDapAn2.Checked = false;
            chkDapAn3.Checked = false;
            chkDapAn4.Checked = false;

            // Nếu học sinh đã chọn đáp án trước đó, hiển thị lại
            if (cauTraLoiHS.ContainsKey(cauHoiHienTai))
            {
                string dapAnChon = cauTraLoiHS[cauHoiHienTai];

                if (chkDapAn1.Tag.ToString() == dapAnChon) chkDapAn1.Checked = true;
                if (chkDapAn2.Tag.ToString() == dapAnChon) chkDapAn2.Checked = true;
                if (chkDapAn3.Tag.ToString() == dapAnChon) chkDapAn3.Checked = true;
                if (chkDapAn4.Tag.ToString() == dapAnChon) chkDapAn4.Checked = true;
            }
        }
        private void LuuDapAn()
        {
            string dapAnChon = "";

            if (chkDapAn1.Checked) dapAnChon = chkDapAn1.Tag.ToString();
            if (chkDapAn2.Checked) dapAnChon = chkDapAn2.Tag.ToString();
            if (chkDapAn3.Checked) dapAnChon = chkDapAn3.Tag.ToString();
            if (chkDapAn4.Checked) dapAnChon = chkDapAn4.Tag.ToString();

            if (!string.IsNullOrEmpty(dapAnChon))
            {
                cauTraLoiHS[cauHoiHienTai] = dapAnChon;
            }
        }

        private void ChamDiem()
        {
            int diem = 0;

            for (int i = 0; i < danhSachCauHoi.Count; i++)
            {
                CauHoi ch = danhSachCauHoi[i];

                // Kiểm tra xem học sinh đã chọn câu trả lời cho câu này chưa
                if (cauTraLoiHS.ContainsKey(i))
                {
                    string dapAnChon = cauTraLoiHS[i];

                    // Nếu đáp án chọn đúng, cộng điểm
                    if (dapAnChon == ch.DapAnDung)
                    {
                        diem++;
                    }
                }
            }

            // Chuyển đổi điểm về hệ 10
            double diemSo = (diem / 10.0) * 10;

            // Lưu điểm vào CSDL
            LuuDiemThi(diemSo);
        }
        private void LuuDiemThi(double diemSo)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_LuuDiemThi", conn)) // Gọi Stored Procedure
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaBaiThi", maBaiThi);
                    cmd.Parameters.AddWithValue("@MaHS", maHocSinh);
                    cmd.Parameters.AddWithValue("@Diem", diemSo);
                    cmd.Parameters.AddWithValue("@NgayCham", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@MaLop", LayMaLop(maHocSinh)); // Lấy mã lớp của học sinh

                    cmd.ExecuteNonQuery();
                }
            }

            CapNhatNgayThi(); // Cập nhật ngày thi

            MessageBox.Show($"Bạn đã hoàn thành bài thi!\nĐiểm: {diemSo}", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Đóng form sau khi nộp bài
        }


        private void btnNopBai_Click(object sender, EventArgs e)
        {
            ChamDiem();
        }

        private void btnCauHoiTruoc_Click_1(object sender, EventArgs e)
        {
            LuuDapAn();
            if (cauHoiHienTai > 0)
            {
                cauHoiHienTai--;
                HienThiCauHoi();
            }
        }

        private void btnCauHoiSau_Click(object sender, EventArgs e)
        {
            LuuDapAn();
            cauHoiHienTai++; 
            HienThiCauHoi();
        }

        private void CapNhatNgayThi()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_CapNhatNgayThi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaBaiThi", maBaiThi);
                        cmd.Parameters.AddWithValue("@MaHS", maHocSinh);
                        cmd.Parameters.AddWithValue("@NgayThi", DateTime.Now.Date); // Chỉ lấy ngày, không lấy gi
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Lỗi khi cập nhập ngày thì" + ex.Message;
                    Task.Delay(3000).ContinueWith(_ => toolStripStatusLabel1.Text = ""); // Ẩn sau 3 giây

                }
            }
        }




        private void btnNopBai_Click_1(object sender, EventArgs e)
        {
        }
        private void lblMaBaiThi_Click(object sender, EventArgs e)
        { 
        }

       
        private string LayMaLop(string maHocSinh)
        {
            string maLop = "";
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyThiTracNghiem"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("sp_LayMaHocSinhLamBaiThi", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaHS", maHocSinh);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        maLop = result.ToString();
                    }
                }
            }
            return maLop;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
