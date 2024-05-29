CREATE DATABASE ExamDB
use ExamDB
create table Sinhvien(
	Masv nvarchar(60) not null,
	Passsv nvarchar(70) not null,
	Image varbinary(max),
	HoTen Nvarchar(100) not null,
	Gioitinh nvarchar(10) not null,
	Ngaysinh date not null,
	Lop nvarchar(20) not null,
	Khoa nvarchar(100) not null,
	salt nvarchar(24) not null
	constraint sinhvien_id primary key (Masv)
)
	use ExamDB
insert into Sinhvien(Masv,da7b628aa72d4dc9b8349bafbf9b4b7ed8df0bd4432e35392c70f27a08254d7b,image,HoTen,Gioitinh,Ngaysinh,Lop,Khoa,salt) values 
('2823220212',2823220212,(SELECT * FROM OPENROWSET(BULK 'C:\Users\ntv\Downloads\Compressed\VbExam\imagesv\2823220212.jpg', SINGLE_BLOB) AS image),N'Ngô Tuấn Việt',N'Nam','2005-12-12',N'TH28.27',N'Công Nghệ Thông Tin',434282283)

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
	Passgv nvarchar(70) not null,
	Image varbinary(max),
	Hotengv nvarchar(100) not null,
	Gioitinh nvarchar(10) not null,
	Ngaysinh date not null,
	Chucvu nvarchar(50) not null,
	Khoa nvarchar(50) not null,
	salt nvarchar not null,
	Administrator BIT not null
)
use ExamDB
insert into Giangvien(Magv,Passgv,image,Hotengv,Gioitinh,Ngaysinh,Chucvu,Khoa,salt,Administrator) values ('GV012@','12345',(SELECT * FROM OPENROWSET(BULK 'C:\Users\ntv\Downloads\Compressed\VbExam\imagegv\GV012@.jpg', SINGLE_BLOB) AS image),N'Mai Quang Hải',N'Nam','07/16/2005',N'Trưởng Khoa',N'Công Nghệ Thông Tin',3456467, 1)
select * from Loginfo
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
	MaLichThi NVARCHAR(40) NOT NULL PRIMARY KEY,
	MaDeThi nvarchar(40) not null, 
	Masv nvarchar(60) not null,
	Tenmonhoc nvarchar(60) not null,
	Lop nvarchar(10) not null,
	Ngaythi datetime not null,
	Phongthi nvarchar(10) not null
)
use ExamDB
insert into Lichthi(MaDeThi, Masv, Tenmonhoc, Lop, Ngaythi, Phongthi) 
values ('DHMT',2823220212,N'Đồ Hoạ Máy Tính','TH28.27','2023-04-05 09:30:00','D509')
		
CREATE TABLE Khoa (
	MaKhoa NVARCHAR(40) NOT NULL PRIMARY KEY,
	TenKhoa NVARCHAR(30) NOT NULL
)
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('CNTT', N'Công nghệ thông tin')
use ExamDB
CREATE TABLE DeThi (
	MaDeThi NVARCHAR(40) NOT NULL PRIMARY KEY,
	MaKhoa NVARCHAR(40) NOT NULL,
	TenDeThi NVARCHAR(40) NOT NULL,
	SoCau int,
	ThoiGian int
)
INSERT INTO DeThi (MaDeThi, MaKhoa, TenDeThi, SoCau,ThoiGian) VALUES ('TIN01', 'CNTT', N'Tin 1', 15, 5)
CREATE TABLE CauHoi (
	MaCauHoi NVARCHAR(40) NOT NULL PRIMARY KEY,
	MaDeThi NVARCHAR(20) NOT NULL,
	Maanh nvarchar(40),
	NoiDung NVARCHAR(MAX) NOT NULL,
	DapAnA NVARCHAR(MAX),
	DapAnB NVARCHAR(MAX),
	DapAnC NVARCHAR(MAX),
	DapAnD NVARCHAR(MAX),
	DapAnDung int,
	ThuTuCau int NOT NULL
)

INSERT INTO CauHoi (MaCauHoi, MaDeThi, NoiDung, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, ThuTuCau) 
VALUES  ('TIN1', 'TIN01', N'Câu hỏi thứ nhất', N'Đáp án A', N'Đáp án B', N'Đáp án C', N'Đáp án D', 1, (SELECT (SELECT COUNT(*) FROM CauHoi WHERE MaDeThi = 'TIN01') + 1)),
		('TIN2', 'TIN01', N'Câu hỏi thứ hai', N'Đáp án A', N'Đáp án B', N'Đáp án C', N'Đáp án D', 2, (SELECT (SELECT COUNT(*) FROM CauHoi WHERE MaDeThi = 'TIN01') + 1))

create table ImageData(
	Maanh nvarchar(40) not null,
	image varbinary (max)
)
insert into Imagecauhoi(MaCauHoi,imagech) values ('TIN1',(SELECT * FROM OPENROWSET(BULK 'D:\TaiLieuHocTap\TaiLieuHUBT\Modules\LTTQ\VbExam\imagesv\2823220212.jpg', SINGLE_BLOB) AS image))

--CREATE TABLE DapAn (
--	MaDapAn NVARCHAR(10) NOT NULL PRIMARY KEY,
--	MaCauHoi NVARCHAR(10) NOT NULL,
--	NoiDung NVARCHAR(MAX) NOT NULL
--)
--INSERT INTO DapAn (MaDapAn, MaCauHoi, NoiDung)
--VALUES	('DATIN1', 'TIN1', N'Đáp án câu 1'),
--		('DATIN2', 'TIN2', N'Đáp án câu 2')

insert into Loginfo(Tennguoidung,Hoatdong,Trangthai,thoigian,chitiet) values (N'Admin',N'Đăng Nhập',N'thành công','2024-05-30',null);

CREATE TRIGGER trg_UpdateSoCauHoiOnInsert
ON CauHoi
AFTER INSERT
AS
BEGIN
    UPDATE DeThi
    SET SoCau = (
        SELECT COUNT(*)
        FROM CauHoi
        WHERE CauHoi.MaDeThi = DeThi.MaDeThi
    )
    WHERE MaDeThi IN (
        SELECT MaDeThi
        FROM INSERTED
    );
END;

select * from Loginfo
use ExamDB

CREATE TRIGGER check_account_delete
ON Giangvien
INSTEAD OF DELETE
AS
BEGIN
    -- Đếm số lượng bản ghi trong bảng Users
    DECLARE @user_count INT;
    SELECT @user_count = COUNT(*) FROM Giangvien;

    -- Kiểm tra nếu chỉ còn một bản ghi, thì ngăn không cho xóa
    IF @user_count <= 1
    BEGIN
        RAISERROR (N'Không thể xoá tài khoản cuối cùng trong bảng', 16, 1);
        RETURN;
    END

    -- Thực hiện lệnh xóa nếu số lượng bản ghi > 1
    DELETE FROM Giangvien
    WHERE Magv IN (SELECT Magv FROM deleted);
END;

-- kiểm tra số lượng tài khoản

CREATE TRIGGER trg_UpdateSoCauHoiOnDelete
ON CauHoi
AFTER DELETE
AS
BEGIN
    UPDATE DeThi
    SET SoCau = (
        SELECT COUNT(*)
        FROM CauHoi
        WHERE CauHoi.MaDeThi = DeThi.MaDeThi
    )
    WHERE MaDeThi IN (
        SELECT MaDeThi
        FROM DELETED
    );
END;

-- Xoá bảng ghi log
	CREATE PROCEDURE DeleteOldData
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Loginfo WHERE thoigian < DATEADD(WEEK, -1, GETDATE());
END
EXEC DeleteOldData;
