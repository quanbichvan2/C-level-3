CREATE DATABASE QLHOCSINH;
GO

USE QLHOCSINH;
GO

CREATE TABLE Lop (
  MaLop NVARCHAR(10) PRIMARY KEY,
  TenLop NVARCHAR(255),
  SiSo INT
);

CREATE TABLE hocSinh (
  MaHS NVARCHAR(10) PRIMARY KEY,
  TenHS NVARCHAR(255),
  NgaySinh DATETIME,
  DiaChi NVARCHAR(255),
  DTB FLOAT,
  MaLop NVARCHAR(10),
  FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
);

-- Thêm dữ liệu vào bảng "Lop"
INSERT INTO Lop (MaLop, TenLop, SiSo) VALUES
('L1', N'Lớp 1A', 30),
('L2', N'Lớp 2B', 35),
('L3', N'Lớp 3C', 28),
('L4', N'Lớp 4D', 32),
('L5', N'Lớp 5E', 31);

-- Thêm dữ liệu vào bảng "hocSinh"
INSERT INTO hocSinh (MaHS, TenHS, NgaySinh, DiaChi, DTB, MaLop) VALUES
('HS1', N'Nguyễn Văn A', '2005-01-10', N'Hà Nội', 8.5, 'L1'),
('HS2', N'Trần Thị B', '2006-02-15', N'Hồ Chí Minh', 7.9, 'L2'),
('HS3', N'Lê Văn C', '2005-06-20', N'Đà Nẵng', 8.2, 'L1'),
('HS4', N'Phạm Thị D', '2005-04-05', N'Hải Phòng', 9.1, 'L3'),
('HS5', N'Ngô Văn E', '2006-03-12', N'Cần Thơ', 7.8, 'L2'),
('HS6', N'Lý Thị F', '2005-11-18', N'Nha Trang', 8.7, 'L4'),
('HS7', N'Trần Văn G', '2006-07-25', N'Vũng Tàu', 7.5, 'L3'),
('HS8', N'Nguyễn Thị H', '2005-09-30', N'Huế', 8.9, 'L4'),
('HS9', N'Phạm Văn I', '2006-12-03', N'Bình Dương', 7.4, 'L5'),
('HS10', N'Vũ Thị K', '2005-08-08', N'Long An', 9.2, 'L5'),
('HS11', N'Quan Bích Vân', '2002-08-08', N'Hồ Chí Minh', 9.8, 'L1');