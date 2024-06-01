CREATE DATABASE ExamDB
use ExamDB
create table Sinhvien(
	Masv nvarchar(60) not null primary key,
	Passsv nvarchar(70) not null,
	Image varbinary(max),
	HoTen Nvarchar(100) not null,
	Gioitinh nvarchar(10) not null,
	Ngaysinh date not null,
	Lop nvarchar(20) not null,
	MaKhoa nvarchar(40) not null,
	salt nvarchar(40) not null
)
	use ExamDB
insert into Sinhvien(Masv,Passsv,image,HoTen,Gioitinh,Ngaysinh,Lop,MaKhoa,salt) values 
('2823220212','da7b628aa72d4dc9b8349bafbf9b4b7ed8df0bd4432e35392c70f27a08254d7b',(SELECT * FROM OPENROWSET(BULK 'D:\TaiLieuHocTap\TaiLieuHUBT\Modules\LTTQ\VbExam\imagesv\2823220212.jpg', SINGLE_BLOB) AS image),N'Ngô Tuấn Việt',N'Nam','2005-12-12',N'TH28.27',N'Công Nghệ Thông Tin',434282283)

select * from Loginfo
delete Loginfo
create table Loginfo(
	Tennguoidung nvarchar(60) not null,
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
	MaKhoa nvarchar(40) not null,
	salt nvarchar(40) not null,
	Administrator BIT not null
)
use ExamDB
insert into Giangvien(Magv,Passgv,image,Hotengv,Gioitinh,Ngaysinh,Chucvu,MaKhoa,salt,Administrator) values ('GV012','da7b628aa72d4dc9b8349bafbf9b4b7ed8df0bd4432e35392c70f27a08254d7b',(SELECT * FROM OPENROWSET(BULK 'D:\TaiLieuHocTap\TaiLieuHUBT\Modules\LTTQ\VbExam\imagegv\GV012@.jpg', SINGLE_BLOB) AS image),N'Mai Quang Hải',N'Nam','07/16/2005',N'Trưởng Khoa',N'Công Nghệ Thông Tin',3456467, 1)
select * from Loginfo
Create table Bangdiem(
	MaDiem nvarchar(40) not null primary key,
	Mamonhoc nvarchar(40) not null,
	Masv nvarchar(60) not null,
	tenmonhoc nvarchar(60) not null,
	Diemthi real not null,
)
use ExamDB
CREATE TABLE Monhoc(
	Mamonhoc nvarchar(40) not null primary key,
	Tenmonhoc nvarchar(60) not null,
	MaKhoa nvarchar(40) not null,
	SoTiet int not null
)
		
CREATE TABLE Khoa (
	MaKhoa NVARCHAR(40) NOT NULL PRIMARY KEY,
	TenKhoa NVARCHAR(30) NOT NULL
)
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('CNTT', N'Công nghệ thông tin')
use ExamDB
CREATE TABLE DeThi (
	MaDeThi NVARCHAR(40) NOT NULL PRIMARY KEY,
	MaKhoa NVARCHAR(40) NOT NULL,
	Mamonhoc NVARCHAR(40) NOT NULL,
	SoCau int,
	ThoiGian int,
	HienDeThi BIT
)
insert into DeThi(MaDeThi,MaKhoa,Mamonhoc,SoCau,ThoiGian,HienDeThi) values ('TIN01','CNTT','TIN01',0,5,1)

use ExamDB
CREATE TABLE CauHoi (
	MaCauHoi NVARCHAR(40) NOT NULL PRIMARY KEY,
	MaDeThi NVARCHAR(40) NOT NULL,
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
	Maanh nvarchar(40) not null PRIMARY KEY,
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


CREATE TABLE [Sinhvien] (
  [Masv] nvarchar(60) PRIMARY KEY,
  [Passsv] nvarchar(70),
  [Image] varbinary(max),
  [HoTen] Nvarchar(100),
  [Gioitinh] nvarchar(10),
  [Ngaysinh] date,
  [Lop] nvarchar(20),
  [MaKhoa] nvarchar(40),
  [salt] nvarchar(40)
)
GO

CREATE TABLE [Loginfo] (
  [Tennguoidung] nvarchar(60),
  [Hoatdong] nvarchar(40),
  [Trangthai] nvarchar(40),
  [thoigian] datetime,
  [chitiet] nvarchar(40)
)
GO

CREATE TABLE [Giangvien] (
  [Magv] nvarchar(60) PRIMARY KEY,
  [Passgv] nvarchar(70),
  [Image] varbinary(max),
  [Hotengv] nvarchar(100),
  [Gioitinh] nvarchar(10),
  [Ngaysinh] date,
  [Chucvu] nvarchar(50),
  [MaKhoa] nvarchar(40),
  [salt] nvarchar(40),
  [Administrator] BIT
)
GO

CREATE TABLE [Monhoc] (
  [Mamonhoc] nvarchar(40) PRIMARY KEY,
  [Tenmonhoc] nvarchar(60),
  [MaKhoa] nvarchar(40),
  [SoTiet] int
)
GO

CREATE TABLE [Khoa] (
  [MaKhoa] NVARCHAR(40) PRIMARY KEY,
  [TenKhoa] NVARCHAR(30)
)
GO

CREATE TABLE [DeThi] (
  [MaDeThi] NVARCHAR(40) PRIMARY KEY,
  [MaKhoa] NVARCHAR(40),
  [Mamonhoc] NVARCHAR(40),
  [SoCau] int,
  [ThoiGian] int,
  [HienDeThi] BIT
)
GO

CREATE TABLE [CauHoi] (
  [MaCauHoi] NVARCHAR(40) PRIMARY KEY,
  [MaDeThi] NVARCHAR(40),
  [Maanh] nvarchar(40),
  [NoiDung] NVARCHAR(MAX),
  [DapAnA] NVARCHAR(MAX),
  [DapAnB] NVARCHAR(MAX),
  [DapAnC] NVARCHAR(MAX),
  [DapAnD] NVARCHAR(MAX),
  [DapAnDung] int,
  [ThuTuCau] int
)
GO

CREATE TABLE [Bangdiem] (
  [MaDiem] nvarchar(40) PRIMARY KEY,
  [Mamonhoc] nvarchar(40),
  [Masv] nvarchar(60),
  [tenmonhoc] nvarchar(60),
  [Diemthi] real
)
GO

CREATE TABLE [ImageData] (
  [Maanh] nvarchar(40) PRIMARY KEY,
  [image] varbinary(max)
)
GO

ALTER TABLE [DeThi] ADD FOREIGN KEY ([MaKhoa]) REFERENCES [Khoa] ([MaKhoa])
GO

ALTER TABLE [Bangdiem] ADD FOREIGN KEY ([Mamonhoc]) REFERENCES [Monhoc] ([Mamonhoc])
GO

ALTER TABLE [Bangdiem] ADD FOREIGN KEY ([Masv]) REFERENCES [Sinhvien] ([Masv])
GO

ALTER TABLE [CauHoi] ADD FOREIGN KEY ([MaDeThi]) REFERENCES [DeThi] ([MaDeThi])
GO

ALTER TABLE [DeThi] ADD FOREIGN KEY ([Mamonhoc]) REFERENCES [Monhoc] ([Mamonhoc])
GO

ALTER TABLE [Sinhvien] ADD FOREIGN KEY ([MaKhoa]) REFERENCES [Khoa] ([MaKhoa])
GO

ALTER TABLE [Giangvien] ADD FOREIGN KEY ([MaKhoa]) REFERENCES [Khoa] ([MaKhoa])
GO

ALTER TABLE [CauHoi] ADD FOREIGN KEY ([Maanh]) REFERENCES [ImageData] ([Maanh])
GO

ALTER TABLE [Monhoc] ADD FOREIGN KEY ([MaKhoa]) REFERENCES [Khoa] ([MaKhoa])
GO
