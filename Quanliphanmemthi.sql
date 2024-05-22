CREATE DATABASE ExamDB
use ExamDB
create table Sinhvien(
	Masv nvarchar(60) not null,
	Passsv nvarchar(60) not null,
	imagesv varbinary(max),
	HoTen Nvarchar(100) not null,
	Gioitinh nvarchar(10) not null,
	Ngaysinh date not null,
	Lop nvarchar(20) not null,
	Khoa nvarchar(100) not null
	constraint sinhvien_id primary key (Masv)
	)
	use ExamDB
insert into Sinhvien(Masv,Passsv,imagesv,HoTen,Gioitinh,Ngaysinh,Lop,Khoa) values 
('2823220212',2823220212,(SELECT * FROM OPENROWSET(BULK 'C:\Users\ntv\Downloads\imagesv\2823220212.jpg', SINGLE_BLOB) AS image),N'Ngô Tuấn Việt',N'Nam','2005-12-12',N'TH28.27',N'Công Nghệ Thông Tin')

select * from Loginfo
delete Loginfo
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
	imagegv varbinary(max),
	Hotengv nvarchar(100) not null,
	Gioitinh nvarchar(10) not null,
	Ngaysinh date not null,
	Chucvu nvarchar(50) not null,
	Khoa nvarchar(50) not null,
	Administrator BIT not null,
)
use ExamDB
insert into Giangvien(Magv,Passgv,imagegv,Hotengv,Gioitinh,Ngaysinh,Chucvu,Khoa,Administrator) values ('GV012@','GV012@',(SELECT * FROM OPENROWSET(BULK 'C:\Users\ntv\Downloads\imagegv\GV012@.jpg', SINGLE_BLOB) AS image),N'Mai Quang Hải',N'Nam','07/16/2005',N'Trưởng Khoa',N'Cộng Nghệ Thông Tin', 1)

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
use ExamDB
insert into Lichthi(Mamonhoc,Masv,Tenmonhoc,Lop,Ngaythi,Phongthi) 
values ('DHMT',2823220212,N'Đồ Hoạ Máy Tính','TH28.27','2023-04-05 09:30:00','D509')
		
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

create table Imagecauhoi(
	MaCauHoi nvarchar(40) not null,
	imagech varbinary (max)
)
insert into Imagecauhoi(MaCauHoi,imagech) values ('TIN1',(SELECT * FROM OPENROWSET(BULK 'C:\Users\ntv\Downloads\imagesv\2823220212.jpg', SINGLE_BLOB) AS image))

CREATE TABLE DapAn (
	MaDapAn NVARCHAR(10) NOT NULL PRIMARY KEY,
	MaCauHoi NVARCHAR(10) NOT NULL,
	NoiDung NVARCHAR(MAX) NOT NULL
)
INSERT INTO DapAn (MaDapAn, MaCauHoi, NoiDung)
VALUES	('DATIN1', 'TIN1', N'Đáp án câu 1'),
		('DATIN2', 'TIN2', N'Đáp án câu 2')
		insert into Loginfo(Tennguoidung,Hoatdong,Trangthai,thoigian,chitiet) values (N'Admin',N'Đăng Nhập',N'thành công','2024-05-30',null);



	CREATE PROCEDURE DeleteOldData
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Loginfo WHERE thoigian < DATEADD(WEEK, -1, GETDATE());
END
EXEC DeleteOldData;
select * from Loginfo
use ExamDB
select * from Giangvien