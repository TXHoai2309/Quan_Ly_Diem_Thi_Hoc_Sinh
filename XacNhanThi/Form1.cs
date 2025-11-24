using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XacNhanThi
{
    public partial class FormXacNhanThi : Form
    {
        public bool DongY { get; private set; } = false;
        public FormXacNhanThi()
        {
            InitializeComponent();
            btnBatDau.Enabled = false; // Vô hiệu hóa nút ngay từ đầu
        }

        private void FormXacNhanThi_Load(object sender, EventArgs e)
        {

        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Bạn cần đồng ý với các điều khoản trước khi bắt đầu bài thi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DongY = true;
            this.Close(); // Đóng form và quay về form chính để bắt đầu thi
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DongY = false;
            this.Close(); // Đóng form và không làm bài
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnBatDau.Enabled = checkBox1.Checked; // Chỉ bật nút nếu đã đồng ý
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
