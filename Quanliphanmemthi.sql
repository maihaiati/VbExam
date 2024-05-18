CREATE DATABASE QLDSV
use QLDSV
create table sinhvien(
	Masv nvarchar(60) not null,
	HoTen Nvarchar(100),
	Gioitinh nvarchar(10),
	Ngaysinh datetime,
	Lop nvarchar(20),
	Khoa nvarchar(100)
	constraint sinhvien_id primary key (Masv)
)
use QLDSV
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
	insert into Giangvien(magv,hotengv,chucvu,Khoa) values ('GV123',N'Mai Quang H?i',N'Gi?ng Viên',N'Công Ngh? thông tin')
	 insert into sinhvien(Masv,HoTen,Gioitinh,Ngaysinh,Lop,Khoa) values (2823220212,N'Ngô Tu?n Vi?t','Nam',2005-12-12,'TH28.27',N'Công Ngh? Thông Tin')
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
	insert into ketquathi(Mamonthi,Masv,Tenmonthi,Phongthi,diemkt,diemchuyencan,diemthi) values ('DHMT',2823220212,N'?? ho? máy tính','D604',8,0.2,9)