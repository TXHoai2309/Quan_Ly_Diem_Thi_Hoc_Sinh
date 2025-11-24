# Student Examination Management System

## 1. Giới thiệu

Student Examination Management System là ứng dụng desktop được xây dựng bằng C# WinForms và SQL Server.  
Mục đích của hệ thống là hỗ trợ các trường học trong việc quản lý ngân hàng câu hỏi, tạo đề thi, thi trắc nghiệm và chấm điểm tự động.

Ứng dụng hỗ trợ 3 nhóm người dùng:
- Admin
- Giáo viên
- Học sinh

---

## 2. Chức năng chính

### 2.1. Dành cho giáo viên
- Quản lý học sinh (thêm, sửa, vô hiệu)
- Thêm và chỉnh sửa câu hỏi trắc nghiệm
- Tạo đề thi từ ngân hàng câu hỏi
- Phân đề cho lớp / nhóm học sinh
- Xem điểm và lịch sử thi
- Xuất báo cáo (Crystal Reports)

### 2.2. Dành cho học sinh
- Đăng nhập bằng tài khoản
- Làm bài thi theo thời gian
- Hệ thống tự chấm điểm sau khi nộp
- Xem điểm các bài đã thi

### 2.3. Dành cho Admin
- Quản lý tài khoản giáo viên
- Quản lý cấu hình hệ thống
- Quản lý dữ liệu cơ bản

---

## 3. Kiến trúc hệ thống

Hệ thống áp dụng mô hình 3 lớp (3-layer architecture):

UI (WinForms)
↓
BLL (Business Logic Layer)
↓
DAL (Data Access Layer)
↓
SQL Server Database

- UI: Form giao diện người dùng, nhập dữ liệu
- BLL: xử lý nghiệp vụ, logic đề thi và chấm điểm
- DAL: truy vấn cơ sở dữ liệu bằng ADO.NET

---

## 4. Thiết kế Database (ERD)

Hệ thống gồm các bảng chính:

- Students — thông tin học sinh
- Teachers — thông tin giáo viên
- Subjects — môn học
- Questions — câu hỏi trắc nghiệm
- AnswerOptions — các đáp án của câu hỏi (A/B/C/D)
- Exams — thông tin đề thi
- ExamQuestions — mapping câu hỏi vào đề thi
- StudentExams — lượt thi của học sinh
- StudentAnswers — câu trả lời của học sinh

### Quan hệ dữ liệu

- Một giáo viên → nhiều đề thi
- Một môn học → nhiều đề thi
- Một đề thi → nhiều câu hỏi (qua ExamQuestions)
- Một câu hỏi → nhiều đáp án
- Một học sinh → nhiều lần thi
- Một lần thi → nhiều câu trả lời

---

## 5. Công nghệ sử dụng
- C# WinForms (.NET Framework)
- SQL Server / LocalDB
- ADO.NET
- Crystal Reports
- Visual Studio 2019 / 2022

---

## 6. Cấu trúc dự án (đề xuất)

StudentExaminationManagementSystem
│
├─ Presentation          (UI – WinForms)
├─ Business              (BLL – xử lý nghiệp vụ)
├─ Data                  (DAL – repository / ADO.NET)
├─ Reports               (file Crystal .rpt)
├─ Database              (script SQL, seed)
├─ Installer             (project setup MSI)
└─ App.config

---

## 7. Hướng dẫn cài đặt

### 7.1. Yêu cầu
- Windows 10/11
- Visual Studio 2019 hoặc 2022
- SQL Server Express / SQL Server / LocalDB
- Crystal Reports Runtime (đúng kiến trúc x86/x64)

---

## 7.2. Khởi tạo Database

Mở SQL Server Management Studio (SSMS) và chạy file:

Database/database.sql

Script sẽ:
- Tạo database
- Tạo các bảng
- Thêm khóa ngoại, index
- Trigger chấm điểm tự động

---

## 8. Cấu hình Connection String

Trong App.config:

<connectionStrings>
  <add name="StudentExamDb"
       connectionString="Data Source=.\\SQLEXPRESS;Initial Catalog=StudentExaminationDB;Integrated Security=True;"
       providerName="System.Data.SqlClient" />
</connectionStrings>

Nếu tên instance SQL khác → đổi Data Source.

---

## 9. Chạy ứng dụng

1. Mở project trong Visual Studio
2. Restore package NuGet nếu cần
3. Set project WinForms làm Startup Project
4. Chạy bằng F5 hoặc Ctrl+F5

---

## 10. Xuất file cài đặt

### Phương án A: Publish Folder (.exe nhanh)
Project → Publish → Folder

Sau khi build, copy folder sang máy người dùng.

⚠️ Cần cài Crystal Reports Runtime trước.

---

### Phương án B: File cài đặt .msi
1. Cài Visual Studio Installer Projects
2. Add Project → Setup Project
3. Thêm:
   - Primary Output (WinForms)
   - File .rpt
4. Build

---

## 11. Crystal Reports

- File .rpt đặt trong thư mục /Reports
- Chọn: Copy to Output = Copy if newer
- Runtime phải cùng kiến trúc build:
  - build x86 → runtime x86
  - build x64 → runtime x64

---

## 12. .gitignore khuyến nghị

.vs/
bin/
obj/
packages/
*.mdf
*.ldf
*.pdb
*.cache
*.nupkg
*.log
Thumbs.db
.DS_Store

---

## 13. License
Dự án dùng cho mục đích học tập, không sử dụng thương mại.
