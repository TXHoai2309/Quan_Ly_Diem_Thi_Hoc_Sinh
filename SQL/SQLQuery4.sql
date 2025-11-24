CREATE TABLE tblLopHoc (
    MaLop NVARCHAR(10) PRIMARY KEY, 
    TenLop NVARCHAR(50) NOT NULL
);
CREATE TABLE tblGiaoVien (
    MaGV NVARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) UNIQUE
);
CREATE TABLE tblHocSinh (
    MaHS NVARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(255) NOT NULL,
    NgaySinh DATE NOT NULL,
    Email NVARCHAR(255) UNIQUE,
    MaLop NVARCHAR(10) FOREIGN KEY REFERENCES tblLopHoc(MaLop) ON DELETE CASCADE
);
CREATE TABLE tblTaiKhoan (
    MaTaiKhoan NVARCHAR(10) PRIMARY KEY,
    TenDangNhap NVARCHAR(255) UNIQUE NOT NULL,
    MatKhau NVARCHAR(255) NOT NULL,
    LoaiTaiKhoan NVARCHAR(50) CHECK (LoaiTaiKhoan IN (N'Học sinh', N'Giáo viên')),
    MaHS NVARCHAR(10) NULL FOREIGN KEY REFERENCES tblHocSinh(MaHS) ON DELETE CASCADE,
    MaGV NVARCHAR(10) NULL FOREIGN KEY REFERENCES tblGiaoVien(MaGV) ON DELETE CASCADE
);
CREATE TABLE tblCauHoi (
    MaCauHoi NVARCHAR(10) PRIMARY KEY,
    NoiDung NVARCHAR(MAX) NOT NULL,
    DoKho INT CHECK (DoKho BETWEEN 1 AND 5),  -- 1: Dễ, 5: Khó
    DapAnDung NVARCHAR(MAX) NOT NULL -- Lưu đáp án đúng trong bảng này
);
CREATE TABLE tblBaiThi (
    MaBaiThi NVARCHAR(10) PRIMARY KEY,
    NgayThi DATETIME NULL -- Chỉ nhập khi học sinh làm bài
);
CREATE TABLE tblChiTietBaiThi (
    MaBaiThi NVARCHAR(10) NOT NULL,
    MaCauHoi NVARCHAR(10) NOT NULL,
    PRIMARY KEY (MaBaiThi, MaCauHoi),
    FOREIGN KEY (MaBaiThi) REFERENCES tblBaiThi(MaBaiThi) ON DELETE CASCADE,
    FOREIGN KEY (MaCauHoi) REFERENCES tblCauHoi(MaCauHoi) ON DELETE CASCADE
);
CREATE TABLE tblDiemThi (
    MaBaiThi NVARCHAR(10) NOT NULL,
    MaHS NVARCHAR(10) NOT NULL,
    Diem FLOAT CHECK (Diem BETWEEN 0 AND 10) NULL, -- Để NULL, hệ thống sẽ chấm điểm tự động
    NgayCham DATETIME NULL, -- Để NULL, chỉ nhập khi giáo viên xác nhận điểm
    FOREIGN KEY (MaBaiThi) REFERENCES tblBaiThi(MaBaiThi) ON DELETE CASCADE,
    FOREIGN KEY (MaHS) REFERENCES tblHocSinh(MaHS) ON DELETE CASCADE
);


INSERT INTO tblLopHoc (MaLop, TenLop) VALUES 
('LH001', N'Lớp 1'), 
('LH002', N'Lớp 2'), 
('LH003', N'Lớp 3'), 
('LH004', N'Lớp 4'), 
('LH005', N'Lớp 5');
INSERT INTO tblGiaoVien (MaGV, HoTen, Email) VALUES
('GV001', N'Giáo viên 1', 'teacher1@school.com'),
('GV002', N'Giáo viên 2', 'teacher2@school.com'),
('GV003', N'Giáo viên 3', 'teacher3@school.com'),
('GV004', N'Giáo viên 4', 'teacher4@school.com'),
('GV005', N'Giáo viên 5', 'teacher5@school.com');

INSERT INTO tblHocSinh (MaHS, HoTen, NgaySinh, Email, MaLop) VALUES
('HS001', N'Học sinh 1', '2015-02-10', 'student1@school.com', 'LH001'),
('HS002', N'Học sinh 2', '2015-03-15', 'student2@school.com', 'LH001'),
('HS003', N'Học sinh 3', '2015-05-20', 'student3@school.com', 'LH001'),
('HS004', N'Học sinh 4', '2015-07-25', 'student4@school.com', 'LH001'),
('HS005', N'Học sinh 5', '2015-09-10', 'student5@school.com', 'LH001'),
('HS006', N'Học sinh 6', '2015-11-18', 'student6@school.com', 'LH001'),
('HS007', N'Học sinh 7', '2015-01-05', 'student7@school.com', 'LH001'),
('HS008', N'Học sinh 8', '2015-04-22', 'student8@school.com', 'LH001'),
('HS009', N'Học sinh 9', '2015-06-30', 'student9@school.com', 'LH001'),
('HS010', N'Học sinh 10', '2015-08-12', 'student10@school.com', 'LH001'),

('HS011', N'Học sinh 11', '2015-02-10', 'student11@school.com', 'LH002'),
('HS012', N'Học sinh 12', '2015-03-15', 'student12@school.com', 'LH002'),
('HS013', N'Học sinh 13', '2015-05-20', 'student13@school.com', 'LH002'),
('HS014', N'Học sinh 14', '2015-07-25', 'student14@school.com', 'LH002'),
('HS015', N'Học sinh 15', '2015-09-10', 'student15@school.com', 'LH002'),
('HS016', N'Học sinh 16', '2015-11-18', 'student16@school.com', 'LH002'),
('HS017', N'Học sinh 17', '2015-01-05', 'student17@school.com', 'LH002'),
('HS018', N'Học sinh 18', '2015-04-22', 'student18@school.com', 'LH002'),
('HS019', N'Học sinh 19', '2015-06-30', 'student19@school.com', 'LH002'),
('HS020', N'Học sinh 20', '2015-08-12', 'student20@school.com', 'LH002'),

('HS021', N'Học sinh 21', '2015-02-10', 'student21@school.com', 'LH003'),
('HS022', N'Học sinh 22', '2015-03-15', 'student22@school.com', 'LH003'),
('HS023', N'Học sinh 23', '2015-05-20', 'student23@school.com', 'LH003'),
('HS024', N'Học sinh 24', '2015-07-25', 'student24@school.com', 'LH003'),
('HS025', N'Học sinh 25', '2015-09-10', 'student25@school.com', 'LH003'),
('HS026', N'Học sinh 26', '2015-11-18', 'student26@school.com', 'LH003'),
('HS027', N'Học sinh 27', '2015-01-05', 'student27@school.com', 'LH003'),
('HS028', N'Học sinh 28', '2015-04-22', 'student28@school.com', 'LH003'),
('HS029', N'Học sinh 29', '2015-06-30', 'student29@school.com', 'LH003'),
('HS030', N'Học sinh 30', '2015-08-12', 'student30@school.com', 'LH003'),

('HS031', N'Học sinh 31', '2015-02-10', 'student31@school.com', 'LH004'),
('HS032', N'Học sinh 32', '2015-03-15', 'student32@school.com', 'LH004'),
('HS033', N'Học sinh 33', '2015-05-20', 'student33@school.com', 'LH004'),
('HS034', N'Học sinh 34', '2015-07-25', 'student34@school.com', 'LH004'),
('HS035', N'Học sinh 35', '2015-09-10', 'student35@school.com', 'LH004'),
('HS036', N'Học sinh 36', '2015-11-18', 'student36@school.com', 'LH004'),
('HS037', N'Học sinh 37', '2015-01-05', 'student37@school.com', 'LH004'),
('HS038', N'Học sinh 38', '2015-04-22', 'student38@school.com', 'LH004'),
('HS039', N'Học sinh 39', '2015-06-30', 'student39@school.com', 'LH004'),
('HS040', N'Học sinh 40', '2015-08-12', 'student40@school.com', 'LH004'),

('HS041', N'Học sinh 41', '2015-02-10', 'student41@school.com', 'LH005'),
('HS042', N'Học sinh 42', '2015-03-15', 'student42@school.com', 'LH005'),
('HS043', N'Học sinh 43', '2015-05-20', 'student43@school.com', 'LH005'),
('HS044', N'Học sinh 44', '2015-07-25', 'student44@school.com', 'LH005'),
('HS045', N'Học sinh 45', '2015-09-10', 'student45@school.com', 'LH005'),
('HS046', N'Học sinh 46', '2015-11-18', 'student46@school.com', 'LH005'),
('HS047', N'Học sinh 47', '2015-01-05', 'student47@school.com', 'LH005'),
('HS048', N'Học sinh 48', '2015-04-22', 'student48@school.com', 'LH005'),
('HS049', N'Học sinh 49', '2015-06-30', 'student49@school.com', 'LH005'),
('HS050', N'Học sinh 50', '2015-08-12', 'student50@school.com', 'LH005');

INSERT INTO tblTaiKhoan (MaTaiKhoan, TenDangNhap, MatKhau, LoaiTaiKhoan, MaHS, MaGV) VALUES
('TK1', 'giaovien1', 'giaovien', N'Giáo viên', NULL, 'GV001'),
('TK2', 'giaovien2', 'giaovien', N'Giáo viên', NULL, 'GV002'),
('TK3', 'giaovien3', 'giaovien', N'Giáo viên', NULL, 'GV003'),
('TK4', 'giaovien4', 'giaovien', N'Giáo viên', NULL, 'GV004'),
('TK5', 'giaovien5', 'giaovien', N'Giáo viên', NULL, 'GV005');

INSERT INTO tblTaiKhoan (MaTaiKhoan, TenDangNhap, MatKhau, LoaiTaiKhoan, MaHS, MaGV) VALUES
('TKHS001', 'hocsinh1', 'password123', N'Học sinh', 'HS001', NULL),
('TKHS002', 'hocsinh2', 'password123', N'Học sinh', 'HS002', NULL),
('TKHS003', 'hocsinh3', 'password123', N'Học sinh', 'HS003', NULL),
('TKHS004', 'hocsinh4', 'password123', N'Học sinh', 'HS004', NULL),
('TKHS005', 'hocsinh5', 'password123', N'Học sinh', 'HS005', NULL),
('TKHS006', 'hocsinh6', 'password123', N'Học sinh', 'HS006', NULL),
('TKHS007', 'hocsinh7', 'password123', N'Học sinh', 'HS007', NULL),
('TKHS008', 'hocsinh8', 'password123', N'Học sinh', 'HS008', NULL),
('TKHS009', 'hocsinh9', 'password123', N'Học sinh', 'HS009', NULL),
('TKHS010', 'hocsinh10', 'password123', N'Học sinh', 'HS010', NULL),

('TKHS011', 'hocsinh11', 'password123', N'Học sinh', 'HS011', NULL),
('TKHS012', 'hocsinh12', 'password123', N'Học sinh', 'HS012', NULL),
('TKHS013', 'hocsinh13', 'password123', N'Học sinh', 'HS013', NULL),
('TKHS014', 'hocsinh14', 'password123', N'Học sinh', 'HS014', NULL),
('TKHS015', 'hocsinh15', 'password123', N'Học sinh', 'HS015', NULL),
('TKHS016', 'hocsinh16', 'password123', N'Học sinh', 'HS016', NULL),
('TKHS017', 'hocsinh17', 'password123', N'Học sinh', 'HS017', NULL),
('TKHS018', 'hocsinh18', 'password123', N'Học sinh', 'HS018', NULL),
('TKHS019', 'hocsinh19', 'password123', N'Học sinh', 'HS019', NULL),
('TKHS020', 'hocsinh20', 'password123', N'Học sinh', 'HS020', NULL),

('TKHS021', 'hocsinh21', 'password123', N'Học sinh', 'HS021', NULL),
('TKHS022', 'hocsinh22', 'password123', N'Học sinh', 'HS022', NULL),
('TKHS023', 'hocsinh23', 'password123', N'Học sinh', 'HS023', NULL),
('TKHS024', 'hocsinh24', 'password123', N'Học sinh', 'HS024', NULL),
('TKHS025', 'hocsinh25', 'password123', N'Học sinh', 'HS025', NULL),
('TKHS026', 'hocsinh26', 'password123', N'Học sinh', 'HS026', NULL),
('TKHS027', 'hocsinh27', 'password123', N'Học sinh', 'HS027', NULL),
('TKHS028', 'hocsinh28', 'password123', N'Học sinh', 'HS028', NULL),
('TKHS029', 'hocsinh29', 'password123', N'Học sinh', 'HS029', NULL),
('TKHS030', 'hocsinh30', 'password123', N'Học sinh', 'HS030', NULL),

('TKHS031', 'hocsinh31', 'password123', N'Học sinh', 'HS031', NULL),
('TKHS032', 'hocsinh32', 'password123', N'Học sinh', 'HS032', NULL),
('TKHS033', 'hocsinh33', 'password123', N'Học sinh', 'HS033', NULL),
('TKHS034', 'hocsinh34', 'password123', N'Học sinh', 'HS034', NULL),
('TKHS035', 'hocsinh35', 'password123', N'Học sinh', 'HS035', NULL),
('TKHS036', 'hocsinh36', 'password123', N'Học sinh', 'HS036', NULL),
('TKHS037', 'hocsinh37', 'password123', N'Học sinh', 'HS037', NULL),
('TKHS038', 'hocsinh38', 'password123', N'Học sinh', 'HS038', NULL),
('TKHS039', 'hocsinh39', 'password123', N'Học sinh', 'HS039', NULL),
('TKHS040', 'hocsinh40', 'password123', N'Học sinh', 'HS040', NULL),

('TKHS041', 'hocsinh41', 'password123', N'Học sinh', 'HS041', NULL),
('TKHS042', 'hocsinh42', 'password123', N'Học sinh', 'HS042', NULL),
('TKHS043', 'hocsinh43', 'password123', N'Học sinh', 'HS043', NULL),
('TKHS044', 'hocsinh44', 'password123', N'Học sinh', 'HS044', NULL),
('TKHS045', 'hocsinh45', 'password123', N'Học sinh', 'HS045', NULL),
('TKHS046', 'hocsinh46', 'password123', N'Học sinh', 'HS046', NULL),
('TKHS047', 'hocsinh47', 'password123', N'Học sinh', 'HS047', NULL),
('TKHS048', 'hocsinh48', 'password123', N'Học sinh', 'HS048', NULL),
('TKHS049', 'hocsinh49', 'password123', N'Học sinh', 'HS049', NULL),
('TKHS050', 'hocsinh50', 'password123', N'Học sinh', 'HS050', NULL);

INSERT INTO tblCauHoi (MaCauHoi, NoiDung, DoKho, DapAnDung) VALUES
('CH001', N'5 + 3 = ?', 1, '8'),
('CH002', N'10 - 4 = ?', 2, '6'),
('CH003', N'7 + 2 = ?', 3, '9'),
('CH004', N'6 - 2 = ?', 2, '4'),
('CH005', N'2 + 2 = ?', 1, '4'),
('CH006', N'8 - 3 = ?', 2, '5'),
('CH007', N'9 - 5 = ?', 3, '4'),
('CH008', N'4 + 4 = ?', 1, '8'),
('CH009', N'3 + 6 = ?', 2, '9'),
('CH010', N'7 - 3 = ?', 1, '4'),

('CH011', N'1 + 1 = ?', 1, '2'),
('CH012', N'5 - 2 = ?', 2, '3'),
('CH013', N'6 + 3 = ?', 3, '9'),
('CH014', N'2 + 5 = ?', 1, '7'),
('CH015', N'9 - 7 = ?', 2, '2'),
('CH016', N'10 - 6 = ?', 3, '4'),
('CH017', N'3 + 3 = ?', 1, '6'),
('CH018', N'7 + 4 = ?', 2, '11'),
('CH019', N'8 - 5 = ?', 1, '3'),
('CH020', N'2 + 7 = ?', 3, '9'),

('CH021', N'4 - 1 = ?', 1, '3'),
('CH022', N'6 + 2 = ?', 2, '8'),
('CH023', N'9 - 3 = ?', 3, '6'),
('CH024', N'5 + 5 = ?', 1, '10'),
('CH025', N'8 + 1 = ?', 2, '9'),
('CH026', N'10 - 8 = ?', 3, '2'),
('CH027', N'3 + 4 = ?', 1, '7'),
('CH028', N'7 - 5 = ?', 2, '2'),
('CH029', N'2 + 6 = ?', 1, '8'),
('CH030', N'9 - 4 = ?', 3, '5'),

('CH031', N'5 + 2 = ?', 1, '7'),
('CH032', N'10 - 9 = ?', 2, '1'),
('CH033', N'6 + 4 = ?', 3, '10'),
('CH034', N'2 + 9 = ?', 1, '11'),
('CH035', N'8 - 6 = ?', 2, '2'),
('CH036', N'3 + 8 = ?', 3, '11'),
('CH037', N'4 + 2 = ?', 1, '6'),
('CH038', N'9 - 2 = ?', 2, '7'),
('CH039', N'7 + 5 = ?', 3, '12'),
('CH040', N'10 - 3 = ?', 1, '7'),

('CH041', N'6 + 1 = ?', 1, '7'),
('CH042', N'5 + 4 = ?', 2, '9'),
('CH043', N'8 - 7 = ?', 3, '1'),
('CH044', N'2 + 8 = ?', 1, '10'),
('CH045', N'7 - 4 = ?', 2, '3'),
('CH046', N'10 - 5 = ?', 3, '5'),
('CH047', N'3 + 7 = ?', 1, '10'),
('CH048', N'6 - 3 = ?', 2, '3'),
('CH049', N'9 - 6 = ?', 1, '3'),
('CH050', N'4 + 5 = ?', 3, '9');

INSERT INTO tblCauHoi (MaCauHoi, NoiDung, DoKho, DapAnDung) VALUES
('CH051', N'1 + 2 = ?', 1, '3'),
('CH052', N'4 - 2 = ?', 1, '2'),
('CH053', N'6 + 1 = ?', 2, '7'),
('CH054', N'9 - 3 = ?', 2, '6'),
('CH055', N'2 + 8 = ?', 3, '10'),
('CH056', N'5 + 3 = ?', 1, '8'),
('CH057', N'7 - 2 = ?', 1, '5'),
('CH058', N'10 - 7 = ?', 2, '3'),
('CH059', N'3 + 6 = ?', 3, '9'),
('CH060', N'8 + 2 = ?', 2, '10'),

('CH061', N'4 + 3 = ?', 1, '7'),
('CH062', N'6 - 5 = ?', 1, '1'),
('CH063', N'9 + 1 = ?', 2, '10'),
('CH064', N'5 - 3 = ?', 2, '2'),
('CH065', N'7 + 4 = ?', 3, '11'),
('CH066', N'2 + 9 = ?', 1, '11'),
('CH067', N'8 - 4 = ?', 1, '4'),
('CH068', N'10 - 6 = ?', 2, '4'),
('CH069', N'3 + 5 = ?', 3, '8'),
('CH070', N'4 + 6 = ?', 2, '10'),

('CH071', N'7 + 1 = ?', 1, '8'),
('CH072', N'9 - 8 = ?', 1, '1'),
('CH073', N'6 + 3 = ?', 2, '9'),
('CH074', N'5 - 2 = ?', 2, '3'),
('CH075', N'8 + 1 = ?', 3, '9'),
('CH076', N'4 + 5 = ?', 1, '9'),
('CH077', N'2 + 7 = ?', 1, '9'),
('CH078', N'10 - 2 = ?', 2, '8'),
('CH079', N'3 + 4 = ?', 3, '7'),
('CH080', N'7 + 3 = ?', 2, '10'),

('CH081', N'6 + 2 = ?', 1, '8'),
('CH082', N'9 - 7 = ?', 1, '2'),
('CH083', N'5 + 4 = ?', 2, '9'),
('CH084', N'8 - 5 = ?', 2, '3'),
('CH085', N'7 + 2 = ?', 3, '9'),
('CH086', N'10 - 9 = ?', 1, '1'),
('CH087', N'3 + 6 = ?', 1, '9'),
('CH088', N'4 + 8 = ?', 2, '12'),
('CH089', N'9 - 6 = ?', 3, '3'),
('CH090', N'5 + 5 = ?', 2, '10'),

('CH091', N'7 + 5 = ?', 1, '12'),
('CH092', N'6 + 4 = ?', 1, '10'),
('CH093', N'9 + 2 = ?', 2, '11'),
('CH094', N'8 - 3 = ?', 2, '5'),
('CH095', N'2 + 4 = ?', 3, '6'),
('CH096', N'10 - 5 = ?', 1, '5'),
('CH097', N'3 + 7 = ?', 1, '10'),
('CH098', N'4 + 6 = ?', 2, '10'),
('CH099', N'8 - 2 = ?', 3, '6'),
('CH100', N'1 + 9 = ?', 2, '10');

INSERT INTO tblBaiThi (MaBaiThi) VALUES
('BT001'), ('BT002'), ('BT003'), ('BT004'), ('BT005'),
('BT006'), ('BT007'), ('BT008'), ('BT009'), ('BT010');


INSERT INTO tblChiTietBaiThi (MaBaiThi, MaCauHoi) VALUES
-- Bài thi 1 (10 câu hỏi ngẫu nhiên)
('BT001', 'CH001'), ('BT001', 'CH015'), ('BT001', 'CH022'), ('BT001', 'CH035'), ('BT001', 'CH048'),
('BT001', 'CH009'), ('BT001', 'CH014'), ('BT001', 'CH029'), ('BT001', 'CH041'), ('BT001', 'CH050'),

-- Bài thi 2
('BT002', 'CH003'), ('BT002', 'CH018'), ('BT002', 'CH024'), ('BT002', 'CH032'), ('BT002', 'CH045'),
('BT002', 'CH006'), ('BT002', 'CH027'), ('BT002', 'CH036'), ('BT002', 'CH049'), ('BT002', 'CH011'),

-- Bài thi 3
('BT003', 'CH002'), ('BT003', 'CH017'), ('BT003', 'CH021'), ('BT003', 'CH030'), ('BT003', 'CH044'),
('BT003', 'CH008'), ('BT003', 'CH025'), ('BT003', 'CH034'), ('BT003', 'CH048'), ('BT003', 'CH012'),

-- Bài thi 4
('BT004', 'CH005'), ('BT004', 'CH019'), ('BT004', 'CH023'), ('BT004', 'CH031'), ('BT004', 'CH040'),
('BT004', 'CH007'), ('BT004', 'CH028'), ('BT004', 'CH037'), ('BT004', 'CH042'), ('BT004', 'CH010'),

-- Bài thi 5
('BT005', 'CH004'), ('BT005', 'CH016'), ('BT005', 'CH020'), ('BT005', 'CH026'), ('BT005', 'CH038'),
('BT005', 'CH013'), ('BT005', 'CH029'), ('BT005', 'CH033'), ('BT005', 'CH046'), ('BT005', 'CH001'),

-- Bài thi 6
('BT006', 'CH007'), ('BT006', 'CH013'), ('BT006', 'CH025'), ('BT006', 'CH039'), ('BT006', 'CH047'),
('BT006', 'CH006'), ('BT006', 'CH012'), ('BT006', 'CH031'), ('BT006', 'CH044'), ('BT006', 'CH009'),

-- Bài thi 7
('BT007', 'CH010'), ('BT007', 'CH022'), ('BT007', 'CH026'), ('BT007', 'CH037'), ('BT007', 'CH049'),
('BT007', 'CH004'), ('BT007', 'CH019'), ('BT007', 'CH032'), ('BT007', 'CH045'), ('BT007', 'CH001'),

-- Bài thi 8
('BT008', 'CH003'), ('BT008', 'CH014'), ('BT008', 'CH023'), ('BT008', 'CH035'), ('BT008', 'CH048'),
('BT008', 'CH006'), ('BT008', 'CH017'), ('BT008', 'CH030'), ('BT008', 'CH041'), ('BT008', 'CH011'),

-- Bài thi 9
('BT009', 'CH002'), ('BT009', 'CH016'), ('BT009', 'CH028'), ('BT009', 'CH033'), ('BT009', 'CH047'),
('BT009', 'CH005'), ('BT009', 'CH018'), ('BT009', 'CH027'), ('BT009', 'CH043'), ('BT009', 'CH009'),

-- Bài thi 10
('BT010', 'CH008'), ('BT010', 'CH015'), ('BT010', 'CH024'), ('BT010', 'CH034'), ('BT010', 'CH050'),
('BT010', 'CH007'), ('BT010', 'CH021'), ('BT010', 'CH038'), ('BT010', 'CH046'), ('BT010', 'CH013');

-- Kiểm tra dữ liệu trong bảng Lớp Học
SELECT * FROM tblLopHoc;

-- Kiểm tra dữ liệu trong bảng Giáo Viên
SELECT * FROM tblGiaoVien;

-- Kiểm tra dữ liệu trong bảng Học Sinh
SELECT * FROM tblHocSinh;

-- Kiểm tra dữ liệu trong bảng Tài Khoản
SELECT * FROM tblTaiKhoan;

-- Kiểm tra dữ liệu trong bảng Câu Hỏi
SELECT * FROM tblCauHoi;

-- Kiểm tra dữ liệu trong bảng Bài Thi
SELECT * FROM tblBaiThi;

-- Kiểm tra dữ liệu trong bảng Chi Tiết Bài Thi (liên kết bài thi với câu hỏi)
SELECT * FROM tblChiTietBaiThi;

-- Kiểm tra dữ liệu trong bảng Điểm Thi
SELECT * FROM tblDiemThi;

-- form quản lý bài thi
CREATE PROCEDURE sp_ThemBaiThi
    @MaBaiThi NVARCHAR(10),
    @NgayThi DATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem bài thi đã tồn tại chưa
    IF EXISTS (SELECT 1 FROM tblBaiThi WHERE MaBaiThi = @MaBaiThi)
    BEGIN
        THROW 50001, 'Mã Bài Thi đã tồn tại!', 1;
        RETURN;
    END

    -- Thêm bài thi mới
    INSERT INTO tblBaiThi (MaBaiThi, NgayThi)
    VALUES (@MaBaiThi, @NgayThi);
END;

ALTER PROCEDURE sp_HienThiChiTietBaiThi_CauHoi
    @MaBaiThi NVARCHAR(10)
AS
BEGIN 
    SET NOCOUNT ON;
    SELECT 
        bt.MaBaiThi, 
        ch.MaCauHoi, 
        ch.NoiDung, 
        ch.DoKho, 
        ch.DapAnDung
    FROM tblBaiThi bt
    JOIN tblChiTietBaiThi ctb ON bt.MaBaiThi = ctb.MaBaiThi
    JOIN tblCauHoi ch ON ctb.MaCauHoi = ch.MaCauHoi
    WHERE bt.MaBaiThi = @MaBaiThi;
END;

-- Tìm kiếm
CREATE PROCEDURE sp_TimKiemBaiThi
    @MaBaiThi NVARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT MaBaiThi
    FROM tblBaiThi
    WHERE (@MaBaiThi IS NULL OR MaBaiThi LIKE '%' + @MaBaiThi + '%'); -- Nếu mã bài thi null nhận tất cả các giá trị, mã bài thi k null thì hiện
END;


-- form quản lý câu hỏi

CREATE PROCEDURE sp_ThemCauHoi
    @MaCauHoi NVARCHAR(50),
    @NoiDung NVARCHAR(MAX),
    @DoKho INT,
    @DapAnDung NVARCHAR(255)
AS
BEGIN
    INSERT INTO dbo.tblCauHoi (MaCauHoi, NoiDung, DoKho, DapAnDung)
    VALUES (@MaCauHoi, @NoiDung, @DoKho, @DapAnDung)
END


CREATE PROCEDURE sp_SuaCauHoi
    @MaCauHoi NVARCHAR(50),
    @NoiDung NVARCHAR(MAX),
    @DoKho INT,
    @DapAnDung NVARCHAR(255)
AS
BEGIN
    UPDATE dbo.tblCauHoi
    SET NoiDung = @NoiDung,
        DoKho = @DoKho,
        DapAnDung = @DapAnDung
    WHERE MaCauHoi = @MaCauHoi
END

CREATE PROCEDURE sp_XoaCauHoi
    @MaCauHoi NVARCHAR(50)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM tblChiTietBaiThi WHERE MaCauHoi = @MaCauHoi)
    BEGIN
        DELETE FROM dbo.tblCauHoi WHERE MaCauHoi = @MaCauHoi
    END
    ELSE
    BEGIN
        RAISERROR ('Không thể xóa câu hỏi vì nó đã có trong bài thi!', 16, 1)
    END
END

CREATE PROCEDURE sp_ThemCauHoiVaoBaiThi
    @MaBaiThi NVARCHAR(50),
    @MaCauHoi NVARCHAR(50)
AS
BEGIN
    -- Kiểm tra số câu hỏi đã có trong bài thi
    IF (SELECT COUNT(*) FROM tblChiTietBaiThi WHERE MaBaiThi = @MaBaiThi) < 10
    BEGIN
        -- Chỉ thêm nếu bài thi chưa có câu hỏi này
        IF NOT EXISTS (SELECT * FROM tblChiTietBaiThi WHERE MaBaiThi = @MaBaiThi AND MaCauHoi = @MaCauHoi)
        BEGIN
            INSERT INTO tblChiTietBaiThi (MaBaiThi, MaCauHoi)
            VALUES (@MaBaiThi, @MaCauHoi)
        END
        ELSE
        BEGIN
            RAISERROR ('Câu hỏi đã tồn tại trong bài thi!', 16, 1)
        END
    END
    ELSE
    BEGIN
        RAISERROR ('Bài thi đã đủ 10 câu hỏi!', 16, 1)
    END
END

CREATE PROCEDURE sp_XoaCauHoiKhoiBaiThi
    @MaBaiThi NVARCHAR(50),
    @MaCauHoi NVARCHAR(50)
AS
BEGIN
    -- Kiểm tra nếu câu hỏi tồn tại trong bài thi
    IF EXISTS (SELECT * FROM tblChiTietBaiThi WHERE MaBaiThi = @MaBaiThi AND MaCauHoi = @MaCauHoi)
    BEGIN
        DELETE FROM tblChiTietBaiThi 
        WHERE MaBaiThi = @MaBaiThi AND MaCauHoi = @MaCauHoi

        -- Kiểm tra nếu bài thi còn ít hơn 10 câu
        IF (SELECT COUNT(*) FROM tblChiTietBaiThi WHERE MaBaiThi = @MaBaiThi) < 10
        BEGIN
            RAISERROR ('Bài thi chưa đủ 10 câu hỏi! Vui lòng thêm câu hỏi mới.', 16, 1)
        END
    END
    ELSE
    BEGIN
        RAISERROR ('Câu hỏi không tồn tại trong bài thi!', 16, 1)
    END
END

CREATE PROCEDURE sp_HienThiDanhSach

AS
BEGIN
    SET NOCOUNT ON;
    BEGIN
        SELECT MaCauHoi, NoiDung, DoKho, DapAnDung FROM tblCauHoi;
    END
END;

create procedure sp_HienCauHoi
AS
BEGIN
	select * from tblcauHoi
end

alter PROCEDURE sp_HienThiChiTietBaiThi
    @MaBaiThi NVARCHAR(50)
AS
BEGIN
    SELECT 
        b.MaBaiThi,
       
        ctb.MaCauHoi,
        ch.NoiDung,
        ch.DoKho,
        ch.DapAnDung
    FROM tblBaiThi b
    JOIN tblChiTietBaiThi ctb ON b.MaBaiThi = ctb.MaBaiThi
    JOIN tblCauHoi ch ON ctb.MaCauHoi = ch.MaCauHoi
    WHERE b.MaBaiThi = @MaBaiThi
    ORDER BY ctb.MaCauHoi;
END


-- form quản lý điểm thi
ALTER PROCEDURE sp_TimKiemDiemThi
    @MaHS NVARCHAR(10) = NULL,
    @MaLop NVARCHAR(10) = NULL,
    @MaBaiThi NVARCHAR(10) = NULL,
    @Diem FLOAT = NULL,
    @NgayCham DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT dt.MaHS, hs.HoTen, hs.MaLop, dt.MaBaiThi, dt.Diem, dt.NgayThi,
           CONVERT(DATE, dt.NgayCham) AS NgayCham
    FROM tblDiemThi dt
    JOIN tblHocSinh hs ON dt.MaHS = hs.MaHS
    WHERE (@MaHS IS NULL OR dt.MaHS LIKE '%' + @MaHS + '%')
      AND (@MaLop IS NULL OR hs.MaLop LIKE '%' + @MaLop + '%')
      AND (@MaBaiThi IS NULL OR dt.MaBaiThi LIKE '%' + @MaBaiThi + '%')
      AND (@Diem IS NULL OR dt.Diem = @Diem)
      AND (@NgayCham IS NULL OR CONVERT(DATE, dt.NgayCham) = @NgayCham);
END;

CREATE PROCEDURE sp_XoaDiemThi
    @MaHS NVARCHAR(10),
    @MaBaiThi NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    
    DELETE FROM tblDiemThi WHERE MaHS = @MaHS AND MaBaiThi = @MaBaiThi;

    -- Trả về số dòng đã bị xóa
    SELECT @@ROWCOUNT AS RowsAffected;
END;

EXEC sp_XoaDiemThi @MaHS = 'HS001', @MaBaiThi = 'BT010';


-- form xem điểm thi học sinh
ALTER PROCEDURE sp_TimKiemDiemThiHocSinh
		@MaHS NVARCHAR(10),
		@MaBaiThi NVARCHAR(10) = NULL
	AS
	BEGIN
		SET NOCOUNT ON;

		SELECT hs.HoTen, dt.MaBaiThi, dt.Diem, dt.NgayThi,dt.NgayCham, dt.MaLop
		FROM tblDiemThi dt
		JOIN tblHocSinh hs ON dt.MaHS = hs.MaHS
		WHERE dt.MaHS = @MaHS
		  AND (@MaBaiThi IS NULL OR dt.MaBaiThi LIKE '%' + @MaBaiThi + '%');
	END;

-- form quản lý học sinh 
CREATE PROCEDURE sp_LayDanhSachHocSinh
AS
BEGIN
    SET NOCOUNT ON;

    SELECT MaHS, HoTen, NgaySinh, Email, MaLop, QueQuan, GioiTinh
    FROM tblHocSinh;
END;

CREATE PROCEDURE sp_ThemHocSinh
    @MaHS NVARCHAR(10),
    @HoTen NVARCHAR(255),
    @NgaySinh DATE,
    @Email NVARCHAR(255),
    @MaLop NVARCHAR(10),
    @QueQuan NVARCHAR(255),
    @GioiTinh NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem mã học sinh đã tồn tại chưa
    IF EXISTS (SELECT 1 FROM tblHocSinh WHERE MaHS = @MaHS)
    BEGIN
        THROW 50013, 'Mã học sinh đã tồn tại!', 1;
    END

    -- Kiểm tra xem mã lớp có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM tblLopHoc WHERE MaLop = @MaLop)
    BEGIN
        THROW 50014, 'Mã lớp không tồn tại!', 1;
    END

    -- Kiểm tra email có bị trùng không
    IF EXISTS (SELECT 1 FROM tblHocSinh WHERE Email = @Email)
    BEGIN
        THROW 50015, 'Email đã tồn tại!', 1;
    END

    -- Thêm học sinh vào bảng tblHocSinh
    INSERT INTO tblHocSinh (MaHS, HoTen, NgaySinh, Email, MaLop, QueQuan, GioiTinh)
    VALUES (@MaHS, @HoTen, @NgaySinh, @Email, @MaLop, @QueQuan, @GioiTinh);

    PRINT 'Thêm học sinh thành công!';
END;

alter procedure sp_XoaHocSinh
	@MaHS NVARCHAR(10)
AS
BEGIN
	SET NOCOUNT ON;
	delete from tblHocSinh where @MaHS = MaHS 
END

alter procedure sp_SuaThongTinHocSinh
	@MaHS NVARCHAR(10),
    @HoTen NVARCHAR(255),
    @NgaySinh DATE,
    @Email NVARCHAR(255),
    @MaLop NVARCHAR(10),
    @QueQuan NVARCHAR(255),
    @GioiTinh NVARCHAR(10)
AS
BEGIN 
	SET NOCOUNT Off ;
	UPDATE tblHocSinh SET HoTen = @HoTen, NgaySinh = @NgaySinh, Email = @Email, MaLop = @MaLop, QueQuan = @QueQuan, GioiTinh = @GioiTinh WHERE MaHS = @MaHS 
END


ALTER TABLE tblBaiThi DROP COLUMN NgayThi;

ALTER TABLE tblDiemThi ADD NgayThi DATE NULL;

CREATE PROCEDURE sp_TimKiemHocSinh
    @MaHS NVARCHAR(10) = NULL,
    @HoTen NVARCHAR(255) = NULL,
    @Email NVARCHAR(255) = NULL,
    @MaLop NVARCHAR(10) = NULL,
    @QueQuan NVARCHAR(255) = NULL,
    @GioiTinh NVARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT MaHS, HoTen, NgaySinh, Email, MaLop, QueQuan, GioiTinh
    FROM tblHocSinh
    WHERE 
        (@MaHS IS NULL OR MaHS LIKE '%' + @MaHS + '%') 
        AND (@HoTen IS NULL OR HoTen LIKE '%' + @HoTen + '%')
        AND (@Email IS NULL OR Email LIKE '%' + @Email + '%' OR Email IS NULL)
        AND (@MaLop IS NULL OR MaLop  LIKE '%' + @MaLop + '%')
        AND (@QueQuan IS NULL OR QueQuan  LIKE '%' + @QueQuan + '%')
        AND (@GioiTinh IS NULL OR @GioiTinh LIKE '%' + @GioiTinh + '%');
END;


-- form làm bài thi
ALTER PROCEDURE sp_CapNhatNgayThi
    @MaBaiThi NVARCHAR(10),
    @MaHS NVARCHAR(10),
    @NgayThi DATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem bản ghi có tồn tại không
    IF EXISTS (SELECT 1 FROM tblDiemThi WHERE MaBaiThi = @MaBaiThi AND MaHS = @MaHS)
    BEGIN
        UPDATE tblDiemThi
        SET NgayThi = @NgayThi
        WHERE MaBaiThi = @MaBaiThi AND MaHS = @MaHS;

        PRINT 'Cập nhật ngày thi thành công!';
    END
    ELSE
    BEGIN
        PRINT 'Không tìm thấy bài thi hoặc học sinh trong tblDiemThi!';
    END
END;

-- Lấy mã học sinh
CREATE PROCEDURE sp_LayMaHocSinhLamBaiThi
	@MaHS Nvarchar(10)
AS
BEGIN
	SELECT MaLop FROM tblHocSinh WHERE MaHS = @MaHS;
END

CREATE PROCEDURE sp_LayCauHoiBaiThi
    @MaBaiThi NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT ch.MaCauHoi, ch.NoiDung, ch.DapAnDung
    FROM tblChiTietBaiThi ct
    JOIN tblCauHoi ch ON ct.MaCauHoi = ch.MaCauHoi
    WHERE ct.MaBaiThi = @MaBaiThi;
END;

create procedure sp_LayBaiThiNgauNhien
AS
BEGIN
	set nocount on;

	select top 1 MaBaiThi from tblChiTietBaithi
	group by MaBaiThi
	having count(MaCauHoi) = 10 
	 ORDER BY NEWID(); -- Chọn ngẫu nhiên bài thi đủ 10 câu
END;
create PROCEDURE sp_LuuDiemThi
    @MaBaiThi NVARCHAR(10),
    @MaHS NVARCHAR(10),
    @Diem FLOAT,
    @NgayCham DATE,
    @MaLop NVARCHAR(10) -- Thêm mã lớp vào bảng tblDiemThi
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem bài thi của học sinh đã tồn tại chưa
    IF EXISTS (SELECT 1 FROM tblDiemThi WHERE MaBaiThi = @MaBaiThi AND MaHS = @MaHS)
    BEGIN
        -- Nếu đã tồn tại, cập nhật điểm thi
        UPDATE tblDiemThi
        SET Diem = @Diem, NgayCham = @NgayCham, MaLop = @MaLop
        WHERE MaBaiThi = @MaBaiThi AND MaHS = @MaHS;
    END
    ELSE
    BEGIN
        -- Nếu chưa tồn tại, chèn mới
        INSERT INTO tblDiemThi (MaBaiThi, MaHS, Diem, NgayCham, MaLop)
        VALUES (@MaBaiThi, @MaHS, @Diem, @NgayCham, @MaLop);
    END
END;


-----------------------------------------------------------------------------------------------------------
--
ALTER TABLE tblHocSinh 
ADD 
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ', N'Khác')) NOT NULL DEFAULT N'Nam',
    QueQuan NVARCHAR(255) NULL;

UPDATE tblHocSinh
SET QueQuan = N'Tỉnh Thái Bình'
WHERE QueQuan IS NOT NULL;

CREATE PROCEDURE sp_XemThongTinHocSinh
    @MaHS NVARCHAR(10)
AS
BEGIN
    SELECT MaHS, HoTen, GioiTinh, NgaySinh, QueQuan, Email, MaLop
    FROM tblHocSinh
    WHERE MaHS = @MaHS;
END;

CREATE PROCEDURE sp_XemThongTinGiangVien
	@MaGV NVARCHAR(10)
AS
BEGIN
	SELECT MaGV, HoTen, Email, NgaySinh, GioiTinh, QueQUan, SoDienThoai 
	FROM tblGiaoVien
	WHERE MaGV = @MaGV
END ; 

ALTER TABLE tblGiaoVien
ADD 
    NgaySinh DATE NULL,           -- Ngày sinh của giáo viên
    GioiTinh NVARCHAR(10) NULL,   -- Giới tính (Nam/Nữ)
    QueQuan NVARCHAR(100) NULL,   -- Quê quán
    SoDienThoai NVARCHAR(15) NULL; -- Số điện thoại


UPDATE tblGiaoVien
SET GioiTinh = 'Nam', QueQuan = N'Hà Nội', NgaySinh = '1980-05-12', SoDienThoai = '0987654321'
WHERE MaGV = 'GV001';

UPDATE tblGiaoVien
SET GioiTinh = N'Nữ', QueQuan = N'Thái Bình', NgaySinh = '1985-06-22', SoDienThoai = '0912345678'
WHERE MaGV = 'GV002';

UPDATE tblGiaoVien
SET GioiTinh = N'Nam', QueQuan = N'Nam Định', NgaySinh = '1987-03-15', SoDienThoai = '0976543210'
WHERE MaGV = 'GV003';

UPDATE tblGiaoVien
SET GioiTinh = N'Nữ', QueQuan = N'Hải Dương', NgaySinh = '1990-09-30', SoDienThoai = '0901234567'
WHERE MaGV = 'GV004';

UPDATE tblGiaoVien
SET GioiTinh = N'Nam', QueQuan = N'Bắc Ninh', NgaySinh = '1982-12-18', SoDienThoai = '0988123456'
WHERE MaGV = 'GV005';

ALTER TABLE tblDiemThi
ADD CONSTRAINT FK_DiemThi_LopHoc
FOREIGN KEY (MaLop) REFERENCES tblLopHoc(MaLop)
ON DELETE NO ACTION;


ALTER TABLE tblDiemThi
ADD MaLop NVARCHAR(10) ;

UPDATE dt
SET dt.MaLop = hs.MaLop
FROM tblDiemThi dt
JOIN tblHocSinh hs ON dt.MaHS = hs.MaHS;


ALTER PROCEDURE sp_CapNhatDiemThi
    @MaBaiThi NVARCHAR(10),
    @MaHS NVARCHAR(10),
    @Diem FLOAT,
    @NgayCham DATE,
    @MaLop NVARCHAR(10) -- Thêm mã lớp vào bảng tblDiemThi
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem bài thi của học sinh đã tồn tại chưa
    IF EXISTS (SELECT 1 FROM tblDiemThi WHERE MaBaiThi = @MaBaiThi AND MaHS = @MaHS)
    BEGIN
        -- Nếu đã tồn tại, cập nhật điểm thi
        UPDATE tblDiemThi
        SET Diem = @Diem, NgayCham = @NgayCham, MaLop = @MaLop
        WHERE MaBaiThi = @MaBaiThi AND MaHS = @MaHS;
    END
    ELSE
    BEGIN
        -- Nếu chưa tồn tại, chèn mới
        INSERT INTO tblDiemThi (MaBaiThi, MaHS, Diem, NgayCham, MaLop)
        VALUES (@MaBaiThi, @MaHS, @Diem, @NgayCham, @MaLop);
    END
END;

CREATE UNIQUE INDEX UQ_TaiKhoan_MaHS 
ON tblTaiKhoan(MaHS) 
WHERE MaHS IS NOT NULL;

CREATE UNIQUE INDEX UQ_TaiKhoan_MaGV 
ON tblTaiKhoan(MaGV) 
WHERE MaGV IS NOT NULL;

ALTER PROCEDURE sp_TaoTaiKhoan
    @TenDangNhap NVARCHAR(255),
    @MatKhau NVARCHAR(255),
    @LoaiTaiKhoan NVARCHAR(50),
    @MaLienKet NVARCHAR(10),
	@MaTaiKhoan NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra mật khẩu có ít nhất 8 ký tự, gồm chữ hoa, chữ thường, số, ký tự đặc biệt
    IF LEN(@MatKhau) < 8 OR 
       @MatKhau NOT LIKE '%[A-Z]%' OR
       @MatKhau NOT LIKE '%[a-z]%' OR
       @MatKhau NOT LIKE '%[0-9]%' OR
       @MatKhau NOT LIKE '%[^a-zA-Z0-9]%'
    BEGIN
        THROW 50006, N'Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt!', 1;
    END

    -- Kiểm tra loại tài khoản hợp lệ và ràng buộc Mã Học Sinh / Mã Giáo Viên
    IF @LoaiTaiKhoan = N'Học sinh'
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM tblHocSinh WHERE MaHS = @MaLienKet)
        BEGIN
            THROW 50001, N'Mã Học Sinh không tồn tại!', 1;
        END
        ELSE IF EXISTS (SELECT 1 FROM tblTaiKhoan WHERE MaHS = @MaLienKet)
        BEGIN
            THROW 50002, N'Học sinh này đã có tài khoản!', 1;
        END
    END
    ELSE IF @LoaiTaiKhoan = N'Giáo viên'
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM tblGiaoVien WHERE MaGV = @MaLienKet)
        BEGIN
            THROW 50003, N'Mã Giáo Viên không tồn tại!', 1;
        END
        ELSE IF EXISTS (SELECT 1 FROM tblTaiKhoan WHERE MaGV = @MaLienKet)
        BEGIN
            THROW 50004, N'Giáo viên này đã có tài khoản!', 1;
        END
    END
    ELSE
    BEGIN
        THROW 50005, N'Loại tài khoản không hợp lệ! Chỉ chấp nhận "Học sinh" hoặc "Giáo viên".', 1;
    END

    -- Nếu không có lỗi, tiến hành thêm tài khoản
    INSERT INTO tblTaiKhoan (MaTaiKhoan, TenDangNhap, MatKhau, LoaiTaiKhoan, MaHS, MaGV)
    VALUES (
		@MaTaiKhoan,
        @TenDangNhap, 
        @MatKhau, 
        @LoaiTaiKhoan, 
        CASE WHEN @LoaiTaiKhoan = N'Học sinh' THEN @MaLienKet ELSE NULL END,
        CASE WHEN @LoaiTaiKhoan = N'Giáo viên' THEN @MaLienKet ELSE NULL END
    );

    PRINT N'Tạo tài khoản thành công!';
END;

alter PROCEDURE sp_DoiMatKhau
    @TenDangNhap NVARCHAR(255),
    @MatKhauCu NVARCHAR(255),
    @MatKhauMoi NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT Off;

    -- Kiểm tra mật khẩu cũ có đúng không
    IF NOT EXISTS (SELECT 1 FROM tblTaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhauCu)
    BEGIN
        THROW 50007, 'Mật khẩu cũ không đúng!', 1;
    END
    -- Cập nhật mật khẩu mới
    UPDATE tblTaiKhoan 
    SET MatKhau = @MatKhauMoi
    WHERE TenDangNhap = @TenDangNhap;

    PRINT 'Đổi mật khẩu thành công!';
END;

-- form đăng nhập
CREATE PROCEDURE sp_DangNhap
	@TenDangNhap NVARCHAR(255),
	@MatKhau NVARCHAR(255),
	@LoaiTaiKhoan NVARCHAR(50) OUTPUT -- trả về loại tài khoản học sinh or giáo viên
AS
BEGIN
	SET NOCOUNT ON

	-- Kiểm tra xem tài khoản có tồn tại không
	SELECT @LoaiTaiKhoan = LoaiTaiKhoan FROM tblTaiKhoan WHERE @TenDangNhap = TenDangNhap
	AND MatKhau = @MatKhau ; 

	-- Nếu k có dữ liệu, trả về NULL
	IF @LoaiTaiKhoan is NULL
	BEGIN 
		THROW 50010, 'Tên đăng nhập hoặc mật khẩu k chính xác',1;
	END 
END ;

-- Lấy mã giáo viên theo tên đăng nhập
CREATE PROCEDURE sp_LayMaGiaoVien
	@TenDangNhap NVARCHAR(255),
	@MaGV NVARCHAR(100) output
AS
BEGIN
	SET NOCOUNT ON ; 
	SELECT @MaGV = MaGV FROM tblTaiKhoan where @TenDangNhap = TenDangNhap ;
	IF @MaGV is null
	BEGIN 
		THROW 50012, 'Không tìm thấy mã giáo viên', 1 ; 
	END
END ; 

CREATE PROCEDURE sp_LayMaHocSinh
    @TenDangNhap NVARCHAR(255),
    @MaHS NVARCHAR(10) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT @MaHS = MaHS FROM tblTaiKhoan WHERE TenDangNhap = @TenDangNhap;

    -- Kiểm tra nếu không có kết quả
    IF @MaHS IS NULL
    BEGIN
        THROW 50011, 'Không tìm thấy mã học sinh!', 1;
    END
END;

-- form đổi mật khẩu

-- form report bảng điểm của một lớp học
create procedure sp_GetBangDiemCuaMotLopHoc
	@MaLop nvarchar(10)
as
begin
	select * from tblDiemThi where MaLop = @MaLop ;
end

-- form report thông tin một học sinh
create procedure sp_GetThongTinHocSinh
	@MaHS nvarchar(10)
as
begin
	SELECT MaHS, HoTen, NgaySinh, Email, MaLop, GioiTinh, QueQuan 
	FROM tblHocSinh WHERE MaHS = @MaHS;
end

-- form report toàn bộ điểm thi
create procedure sp_GetToanBoDiemThi
	@MaHS nvarchar(10)	
as
begin
	SELECT MaHS, MaBaiThi, MaLop, Diem, NgayThi,  CONVERT(DATE, NgayCham) AS NgayCham 
    FROM tblDiemThi 
    WHERE MaHS = @MaHS;
end 

CREATE PROCEDURE sp_TimKiemCauHoi
    @MaCauHoi NVARCHAR(10) = NULL,
    @NoiDung NVARCHAR(MAX) = NULL,
    @DoKho INT = NULL,
    @DapAnDung NVARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT MaCauHoi, NoiDung, DoKho, DapAnDung
    FROM tblCauHoi
    WHERE 
        (@MaCauHoi IS NULL OR MaCauHoi LIKE '%' + @MaCauHoi + '%') 
        AND (@NoiDung IS NULL OR NoiDung LIKE '%' + @NoiDung + '%')
        AND (@DoKho IS NULL OR DoKho = @DoKho)
        AND (@DapAnDung IS NULL OR DapAnDung = @DapAnDung);
END;


create procedure 

as
begin
	SELECT MaBaiThi FROM tblBaiThi ;
end

alter procedure sp_LoadDiemThi
as
begin
	SELECT dt.MaHS, hs.HoTen, hs.MaLop, dt.MaBaiThi, dt.Diem, dt.NgayThi, 
      dt.NgayCham 
FROM tblDiemThi dt 
JOIN tblHocSinh hs ON dt.MaHS = hs.MaHS
end;

create procedure sp_CapNhatDiemThiHocSinh
	@MaHS nvarchar(10),
	@MaBaiThi nvarchar(10),
	@Diem float
as
begin
	UPDATE tblDiemThi SET Diem = @Diem WHERE MaHS = @MaHS AND MaBaiThi = @MaBaiThi;
end

create procedure sp_GetThongTinHocSinh1LopHoc
	@MaLop nvarchar(10)
as
begin
	select * from tblHocSinh where MaLop = @MaLop ;
end


create procedure sp_GetMaBaiThiCB
as
begin
SELECT MaBaiThi FROM tblBaiThi
end ;

create procedure sp_getMaHSCB
as
begin
SELECT MaHS FROM tblHocSinh
end;

create procedure sp_getMaLopCB
as
begin
SELECT MaLop FROM tblLopHoc
end ; 

alter PROCEDURE sp_CapNhatDiemThi
    @MaHS NVARCHAR(10),
    @MaBaiThi NVARCHAR(10),
    @DiemMoi FLOAT
AS
BEGIN
    SET NOCOUNT Off;

    -- Kiểm tra xem điểm mới có hợp lệ không
    IF @DiemMoi < 0 OR @DiemMoi > 10
    BEGIN
        RAISERROR ('Điểm phải nằm trong khoảng từ 0 đến 10!', 16, 1);
        RETURN;
    END

    -- Cập nhật điểm thi
    UPDATE tblDiemThi
    SET Diem = @DiemMoi
    WHERE MaHS = @MaHS AND MaBaiThi = @MaBaiThi;

    -- Trả về số dòng bị ảnh hưởng
    RETURN @@ROWCOUNT;
END
-------------------------------------------------------------------------------------
ALTER TABLE tblHocSinh ADD HESO float
update tblHocSinh set HESO = 10 

 create procedure sp_TimKiemHocSinhDiThi
    @MaHS nvarchar(10) = NULL,
    @HoTen nvarchar(255) = NULL,
    @HESO float
as
begin
    select MaHS, HoTen, HESO
    from tblHocSinh
    where 
        (@MaHS is null or MaHS like '%' + @MaHS + '%') 
        AND (@HoTen is null orHoTen like '%' + @HoTen + '%')
		AND (@HESO is null or HESO like '%' + @HESO + '%')
end ;

create procedure HienDanhSachDiThi
as
begin
select MaHS, HoTen, HESO from tblHocSinh
end

create procedure HienThiDanhSachDiThi
as	
begin
select MaHS, HoTen, HESO, MaLop from tblHocSinh
end

alter PROCEDURE GiamHeSo
    @MaHS NVARCHAR(10)
as
begin
    if exists (select 1 from tblHocSinh where MaHS = @MaHS)
    begin
        update tblHocSinh
        set HESO = HESO -( HESO / 10)
        where MaHS = @MaHS;
   end
end;

 alter procedure inbaocao
    @MaHS NVARCHAR(10) = NULL,
    @HoTen NVARCHAR(255) = NULL,
    @HESO float
as
begin

    select MaHS, HoTen,QueQuan ,HESO
    from tblHocSinh
    where 
        (@MaHS is null or MaHS LIKE '%' + @MaHS + '%') 
        and (@HoTen is null or HoTen LIKE '%' + @HoTen + '%')
		and (@HESO is null or HESO LIKE '%' + @HESO + '%')
end;