CREATE DATABASE ExamDB
use ExamDB
create table Sinhvien(
	Masv nvarchar(60) not null,
	Passsv nvarchar(60) not null,
	HoTen Nvarchar(100),
	Gioitinh nvarchar(10),
	Ngaysinh datetime,
	Lop nvarchar(20),
	Khoa nvarchar(100)
	constraint sinhvien_id primary key (Masv)
)
insert into Sinhvien(Masv,Passsv,HoTen,Gioitinh,Ngaysinh,Lop,Khoa) values 
(2823220212,'282322012',N'Ngô Tuấn Việt',N'Nam',2005-12-12,N'TH28.27',N'Công Nghệ Thông Tin')
create table Loginfo(
	Tennguoidung nvarchar(55),
	Hoatdong nvarchar(40),
	Trangthai nvarchar(40),
	thoigian datetime,
	chitiet nvarchar(40)
)
insert into Loginfo(Tennguoidung,Hoatdong,Trangthai,thoigian,chitiet) values (N'Admin',N'Đăng Nhập','Thành công',null,null);
create table Giangvien(
	Magv nvarchar(60) not null primary key,
	Ad nvarchar(60) not null,
	Passgv nvarchar(60) not null,
	Hotengv nvarchar(100),
	Chucvu nvarchar(50),
	Khoa nvarchar(50)
)
insert into Giangvien(Magv,Ad,Passgv,Hotengv,Chucvu,Khoa) values ('GV012@','Ad12','GV012@',N'Mai Quang Hải',N'Trưởng Khoa',N'Cộng Nghệ Thông Tin')
Create table Bangdiem(
	Mamonhoc nvarchar(60) not null,
	Masv nvarchar(60) not null,
	tenmonhoc nvarchar(60),
	Diemkt int ,
	Diemchuyencan int,
	Diemthi int ,
	constraint fk_masv foreign key (Masv) references sinhvien(Masv)
)
use ExamDB
CREATE TABLE Monhoc(
	Mamonhoc nvarchar(60) not null primary key,
	Tenmonhoc nvarchar(60) not null,
)
CREATE TABLE Lichthi(
	Mamonhoc nvarchar(60) not null, 
	Masv nvarchar(60) not null,
	Tenmonhoc nvarchar(60),
	Lop nvarchar(10) ,
	Ngaythi datetime,
	Phongthi nvarchar(10)
)
CREATE TABLE Khoa (
	MaKhoa NVARCHAR(10) NOT NULL PRIMARY KEY,
	TenKhoa NVARCHAR(30) NOT NULL
)

CREATE TABLE DeThi (
	MaDeThi NVARCHAR(10) NOT NULL PRIMARY KEY,
	MaKhoa NVARCHAR(10) NOT NULL,
	TenDeThi NVARCHAR(40) NOT NULL,
	SoCau int
)

CREATE TABLE CauHoi (
	MaCauHoi NVARCHAR(10) NOT NULL PRIMARY KEY,
	MaDeThi NVARCHAR(10) NOT NULL,
	NoiDung NVARCHAR(MAX) NOT NULL,
	ThuTuCau int NOT NULL
)

CREATE TABLE DapAn (
	MaDapAn NVARCHAR(10) NOT NULL PRIMARY KEY,
	MaCauHoi NVARCHAR(10) NOT NULL,
	NoiDung NVARCHAR(MAX) NOT NULL
)

INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('CNTT', N'Công nghệ thông tin')

INSERT INTO DeThi (MaDeThi, MaKhoa, TenDeThi, SoCau) VALUES ('TIN01', 'CNTT', N'Tin 1', 2)

INSERT INTO CauHoi (MaCauHoi, MaDeThi, NoiDung, ThuTuCau) 
VALUES  ('TIN1', 'TIN01', N'Câu hỏi thứ nhất', 1),
		('TIN2', 'TIN01', N'Câu hỏi thứ hai', 2)

INSERT INTO DapAn (MaDapAn, MaCauHoi, NoiDung)
VALUES	('DATIN1', 'TIN1', N'Đáp án câu 1'),
		('DATIN2', 'TIN2', N'Đáp án câu 2')