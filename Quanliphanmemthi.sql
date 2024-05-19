CREATE DATABASE ExamDB
use ExamDB
create table Sinhvien(
	Masv nvarchar(60) not null,
	Passsv nvarchar(60) not null,
	HoTen Nvarchar(100) not null,
	Gioitinh nvarchar(10) not null,
	Ngaysinh date not null,
	Lop nvarchar(20) not null,
	Khoa nvarchar(100) not null
	constraint sinhvien_id primary key (Masv)
)
insert into Sinhvien(Masv,Passsv,HoTen,Gioitinh,Ngaysinh,Lop,Khoa) values 
(2823220212,'282322012',N'Ngô Tuấn Việt',N'Nam','2005-12-12',N'TH28.27',N'Công Nghệ Thông Tin')

create table Loginfo(
	Tennguoidung nvarchar(55) not null,
	Hoatdong nvarchar(40) not null,
	Trangthai nvarchar(40) not null,
	thoigian datetime not null,
	chitiet nvarchar(40)
)
insert into Loginfo(Tennguoidung,Hoatdong,Trangthai,thoigian,chitiet) values (N'Admin',N'Đăng Nhập',N'thành công',GETDATE(),null);
use ExamDB
create table Giangvien(
	Magv nvarchar(60) not null primary key,
	Passgv nvarchar(60) not null,
	Hotengv nvarchar(100) not null,
	Gioitinh nvarchar(10) not null,
	Ngaysinh date not null,
	Chucvu nvarchar(50) not null,
	Khoa nvarchar(50) not null,
	Administrator BIT not null,
)
insert into Giangvien(Magv,Passgv,Hotengv,Chucvu,Khoa,Administrator) values ('GV012@','GV012@',N'Mai Quang Hải',N'Trưởng Khoa',N'Cộng Nghệ Thông Tin', 1)
Create table Bangdiem(
	Mamonhoc nvarchar(60) not null,
	Masv nvarchar(60) not null,
	tenmonhoc nvarchar(60) not null,
	Diemkt int not null,
	Diemchuyencan int not null,
	Diemthi int  not null,
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
	Tenmonhoc nvarchar(60) not null,
	Lop nvarchar(10) not null,
	Ngaythi datetime not null,
	Phongthi nvarchar(10) not null
)
insert into Lichthi(Mamonhoc,Masv,Tenmonhoc,Lop,Ngaythi,Phongthi) 
values ('DHMT',2823220212,N'Đồ Hoạ Máy Tính','TH28.27','26-06-2023 09:30:00','D509') 

CREATE TABLE Khoa (
	MaKhoa NVARCHAR(10) NOT NULL PRIMARY KEY,
	TenKhoa NVARCHAR(30) NOT NULL
)
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('CNTT', N'Công nghệ thông tin')
CREATE TABLE DeThi (
	MaDeThi NVARCHAR(10) NOT NULL PRIMARY KEY,
	MaKhoa NVARCHAR(10) NOT NULL,
	TenDeThi NVARCHAR(40) NOT NULL,
	SoCau int
)
INSERT INTO DeThi (MaDeThi, MaKhoa, TenDeThi, SoCau) VALUES ('TIN01', 'CNTT', N'Tin 1', 2)
CREATE TABLE CauHoi (
	MaCauHoi NVARCHAR(10) NOT NULL PRIMARY KEY,
	MaDeThi NVARCHAR(10) NOT NULL,
	NoiDung NVARCHAR(MAX) NOT NULL,
	ThuTuCau int NOT NULL
)
INSERT INTO CauHoi (MaCauHoi, MaDeThi, NoiDung, ThuTuCau) 
VALUES  ('TIN1', 'TIN01', N'Câu hỏi thứ nhất', 1),
		('TIN2', 'TIN01', N'Câu hỏi thứ hai', 2)

CREATE TABLE DapAn (
	MaDapAn NVARCHAR(10) NOT NULL PRIMARY KEY,
	MaCauHoi NVARCHAR(10) NOT NULL,
	NoiDung NVARCHAR(MAX) NOT NULL
)
INSERT INTO DapAn (MaDapAn, MaCauHoi, NoiDung)
VALUES	('DATIN1', 'TIN1', N'Đáp án câu 1'),
		('DATIN2', 'TIN2', N'Đáp án câu 2')