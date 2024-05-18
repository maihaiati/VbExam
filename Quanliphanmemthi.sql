CREATE DATABASE ExamDB
use ExamDB
create table sinhvien(
	Masv nvarchar(60) not null,
	HoTen Nvarchar(100),
	Gioitinh nvarchar(10),
	Ngaysinh datetime,
	Lop nvarchar(20),
	Khoa nvarchar(100)
	constraint sinhvien_id primary key (Masv)
)
create table tksv(
	usersv nvarchar(40),
	passsv nvarchar(40)
	)
	insert into tksv(usersv,passsv) values (2823220212,N'SV123@')
create table tkgv(
	usergv nvarchar(40),
	passgv nvarchar(40)

)
	insert into tkgv(usergv,passgv) values ('GV001',N'GV123@')
create table Giangvien(
	magv nvarchar(60) not null,
	hotengv nvarchar(100),
	chucvu nvarchar(50),
	Khoa nvarchar(50)
)
	insert into Giangvien(magv,hotengv,chucvu,Khoa) values ('GV123',N'Mai Quang Hải',N'Giảng Viên',N'Công Nghệ thông tin')
	 insert into sinhvien(Masv,HoTen,Gioitinh,Ngaysinh,Lop,Khoa) values (2823220212,N'Ngô Tuấn Việt','Nam',2005-12-12,'TH28.27',N'Công Nghệ Thông Tin')
Create table ketquathi(
	Mamonthi nvarchar(60) not null primary key,
	Masv nvarchar(60) not null,
	Tenmonthi nvarchar(100),
	Phongthi nvarchar(100),
	diemkt int not null,
	diemchuyencan int not null,
	diemthi int not null,
	constraint fk_masv foreign key (Masv) references sinhvien(Masv)
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

		delete ketquathi
	insert into ketquathi(Mamonthi,Masv,Tenmonthi,Phongthi,diemkt,diemchuyencan,diemthi) values ('DHMT',2823220212,N'Đồ hoạ máy tính','D604',8,0.2,9)
	select sinhvien.Masv,HoTen,Gioitinh,Ngaysinh,Lop,Khoa from tksv inner join sinhvien on tksv.usersv = sinhvien.Masv where Masv = '2823220212'