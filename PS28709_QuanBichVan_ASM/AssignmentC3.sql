create database AssignmentC3

use AssignmentC3

create table users
(
	username nvarchar(50) primary key not null,
	password nvarchar(50),
	roles nvarchar(50)
);

create table students
(
	MSSV nvarchar(50) primary key not null,
	HoTen nvarchar(50) not null,
	Email varchar(50),
	SoDT varchar(15),
	GioiTinh bit check(GioiTinh = 0 or GioiTinh = 1),
	DiaChi nvarchar(100),
	Hinh varchar(100)
);

create table backups
(
	MSSV nvarchar(50)not null,
	HoTen nvarchar(50) not null,
	Email varchar(50),
	SoDT varchar(15),
	GioiTinh bit check(GioiTinh = 0 or GioiTinh = 1),
	DiaChi nvarchar(100),
	Hinh varchar(50)
);

create table grades
(
	ID int identity primary key not null,
	MSSV nvarchar(50) references STUDENTS(MSSV),
	TiengAnh float,
	TinHoc float,
	GDTD float
);


insert into users
values('FPL1','hcm123',N'Giảng viên'),
('FPL2','hcm456',N'Cán bộ đào tạo'),
('FPL3', 'ps123', N'Sinh viên')


INSERT INTO students
VALUES
  ('SV01', N'Huỳnh Thái Dân', 'dan@gmail.com', '0798599701', 1, N'Bến Tre', 'E:\FPT\C#3\BT\PS28709_QuanBichVan_ASM\hinh1.jpg'),
  ('SV02', N'Nguyễn Vũ Công Hậu', 'hau@gmail.com', '0798599702', 1, N'Bình Thuận', 'E:\FPT\C#3\BT\PS28709_QuanBichVan_ASM\hinh2.jpg'),
  ('SV03', N'Quan Bích Vân', 'van@gmail.com', '0798599703', 0, N'TP.Hồ Chí Minh', 'E:\FPT\C#3\BT\PS28709_QuanBichVan_ASM\hinh3.jpg'),
  ('SV04', N'NGuyễn Thế Tân', 'tan@gmail.com', '0798599704', 1, N'Bến Tre', 'E:\FPT\C#3\BT\PS28709_QuanBichVan_ASM\hinh4.jpg'),
  ('SV05', N'Trần Phú Đạt', 'dat@gmail.com', '0798599705', 1, N'Phú Yên', 'E:\FPT\C#3\BT\PS28709_QuanBichVan_ASM\hinh5.jpg'),
  ('SV06', N'Nguyễn Thị Yên', 'y@gmail.com', '0798599706', 0, N'TP.Hồ Chí Minh', 'E:\FPT\C#3\BT\PS28709_QuanBichVan_ASM\hinh6.jpg'),
  ('SV07', N'Lâm Sâm Chấn', 'chan@gmail.com', '0798599707', 1, N'TP.Hồ Chí Minh', 'E:\FPT\C#3\BT\PS28709_QuanBichVan_ASM\hinh7.jpg'),
  ('SV08', N'Tô SamSung', 'sung@gmail.com', '0798599707', 1, N'TP.Hồ Chí Minh', 'E:\FPT\C#3\BT\PS28709_QuanBichVan_ASM\hinh8.jpg');

insert into grades
values ('SV01', 6,8,10),
	   ('SV02', 8,6,7),
	   ('SV03', 8,6,9),
	   ('SV04', 9,9,9),
	   ('SV05', 10,9,7),
	   ('SV06', 8,8,8),
	   ('SV07', 6,7,10),
	   ('SV08', 9,7,10)

select * from users
select * from students
select * from grades