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
	--CONSTRAINT fk_MaKhoa_Khoa_sv FOREIGN KEY (MaKhoa) REFERENCES Khoa (Makhoa)'
)
insert into Sinhvien(Masv,Passsv,image,HoTen,Gioitinh,Ngaysinh,Lop,MaKhoa,salt) values 
('2823220212','da7b628aa72d4dc9b8349bafbf9b4b7ed8df0bd4432e35392c70f27a08254d7b',(SELECT * FROM OPENROWSET(BULK 'C:\Users\ntv\Downloads\Compressed\VbExam\imagesv\2823220212.jpg', SINGLE_BLOB) AS image),N'Ngô Tuấn Việt',N'Nam','2005-12-12',N'TH28.27',N'CNTT',434282283)

create table Loginfo(
	Tennguoidung nvarchar(60) not null,
	Hoatdong nvarchar(40) not null,
	Trangthai nvarchar(40) not null,
	thoigian datetime not null,
	chitiet nvarchar(40)
) 
insert into Loginfo(Tennguoidung,Hoatdong,Trangthai,thoigian,chitiet) values (N'Admin',N'Đăng Nhập',N'thành công',GETDATE(),null);
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
	--CONSTRAINT fk_MaKhoa_Khoa_gv FOREIGN KEY (MaKhoa) REFERENCES Khoa (Makhoa)
)
insert into Giangvien(Magv,Passgv,image,Hotengv,Gioitinh,Ngaysinh,Chucvu,MaKhoa,salt,Administrator) values ('GV012','da7b628aa72d4dc9b8349bafbf9b4b7ed8df0bd4432e35392c70f27a08254d7b',(SELECT * FROM OPENROWSET(BULK 'C:\Users\ntv\Downloads\Compressed\VbExam\imagegv\GV012@.jpg', SINGLE_BLOB) AS image),N'Mai Quang Hải',N'Nam','07/16/2005',N'Trưởng Khoa',N'CNTT',3456467, 1)

CREATE TABLE Monhoc(
	Mamonhoc nvarchar(40) not null primary key,
	Tenmonhoc nvarchar(60) not null,
	MaKhoa nvarchar(40) not null,
	SoTiet int not null
	--CONSTRAINT fk_MaKhoa_Khoa FOREIGN KEY (MaKhoa) REFERENCES Khoa (Makhoa)
)
		insert into Monhoc(Mamonhoc,Tenmonhoc,MaKhoa,SoTiet) values ('TIN01','Access','CNTT',40)
CREATE TABLE Khoa (
	MaKhoa NVARCHAR(40) NOT NULL PRIMARY KEY,
	TenKhoa NVARCHAR(30) NOT NULL
)
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES (N'CNTT', N'Công nghệ thông tin')

Create table Bangdiem(
	MaDiem nvarchar(40) not null primary key,
	Mamonhoc nvarchar(40) not null,
	Masv nvarchar(60) not null,
	tenmonhoc nvarchar(60) not null,
	Diemthi real not null,
	--CONSTRAINT fk_Sinhvien_Bangdiem FOREIGN KEY (Masv) REFERENCES SinhVien (Masv),
	--CONSTRAINT fk_Mamonhoc_Monhoc FOREIGN KEY (Mamonhoc) REFERENCES Monhoc (Mamonhoc)
)
insert into Bangdiem(MaDiem,Mamonhoc,Masv,tenmonhoc,Diemthi) values (123,'TIN01',2823220212,N'Lý Thuyết Cơ Bản',8)

CREATE TABLE DeThi (
	MaDeThi NVARCHAR(40) NOT NULL PRIMARY KEY,
	MaKhoa NVARCHAR(40) NOT NULL,
	Mamonhoc NVARCHAR(40) NOT NULL,
	SoCau int,
	ThoiGian int,
	HienDeThi bit
	--CONSTRAINT fk_MamonhocDT_Monhoc FOREIGN KEY (Mamonhoc) REFERENCES MonHoc (Mamonhoc),
	--CONSTRAINT fk_MaKhoaDT_Khoa FOREIGN KEY (MaKhoa) REFERENCES Khoa (Makhoa)
)
insert into DeThi(MaDeThi,MaKhoa,Mamonhoc,SoCau,ThoiGian,HienDeThi) values ('TIN01','CNTT','TIN01',0,5,1)


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
	--CONSTRAINT fk_MaDethi_Dethi FOREIGN KEY (MaDeThi) REFERENCES Dethi (MaDeThi),
	--CONSTRAINT fk_MaAnh_ImageData FOREIGN KEY (Maanh) REFERENCES ImageData (Maanh)
)

INSERT INTO CauHoi (MaCauHoi, MaDeThi, NoiDung, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung, ThuTuCau) 
VALUES  ('TIN1', 'TIN01', N'Câu hỏi thứ nhất', N'Đáp án A', N'Đáp án B', N'Đáp án C', N'Đáp án D', 1, (SELECT (SELECT COUNT(*) FROM CauHoi WHERE MaDeThi = 'TIN01') + 1)),
		('TIN2', 'TIN01', N'Câu hỏi thứ hai', N'Đáp án A', N'Đáp án B', N'Đáp án C', N'Đáp án D', 2, (SELECT (SELECT COUNT(*) FROM CauHoi WHERE MaDeThi = 'TIN01') + 1))

create table ImageData(
	Maanh nvarchar(40) not null PRIMARY KEY,
	image varbinary (max)
)
insert into ImageData(Maanh,image) values ('TIN1',(SELECT * FROM OPENROWSET(BULK 'C:\Users\ntv\Downloads\Compressed\VbExam\imagegv\GV012@.jpg', SINGLE_BLOB) AS image))

--CREATE TABLE DapAn (
--	MaDapAn NVARCHAR(10) NOT NULL PRIMARY KEY,
--	MaCauHoi NVARCHAR(10) NOT NULL,
--	NoiDung NVARCHAR(MAX) NOT NULL
--)
--INSERT INTO DapAn (MaDapAn, MaCauHoi, NoiDung)
--VALUES	('DATIN1', 'TIN1', N'Đáp án câu 1'),
--		('DATIN2', 'TIN2', N'Đáp án câu 2')

insert into Loginfo(Tennguoidung,Hoatdong,Trangthai,thoigian,chitiet) values (N'Admin',N'Đăng Nhập',N'thành công','2024-05-30',null);



ALTER TABLE [DeThi] ADD FOREIGN KEY ([MaKhoa]) REFERENCES [Khoa] ([MaKhoa])
GO

ALTER TABLE [Bangdiem] ADD FOREIGN KEY ([Mamonhoc]) REFERENCES [Monhoc] ([Mamonhoc])
GO

ALTER TABLE [Bangdiem] ADD FOREIGN KEY ([Masv]) REFERENCES [Sinhvien] ([Masv])
GO

ALTER TABLE [CauHoi] ADD FOREIGN KEY ([MaDeThi]) REFERENCES [DeThi] ([MaDeThi])
GO


ALTER TABLE [Sinhvien] ADD FOREIGN KEY ([MaKhoa]) REFERENCES [Khoa] ([MaKhoa])
GO

ALTER TABLE [Giangvien] ADD FOREIGN KEY ([MaKhoa]) REFERENCES [Khoa] ([MaKhoa])
GO

ALTER TABLE [CauHoi] ADD FOREIGN KEY ([Maanh]) REFERENCES [ImageData] ([Maanh])
GO

ALTER TABLE [DeThi] ADD FOREIGN KEY (Mamonhoc) REFERENCES [Monhoc] (Mamonhoc)
GO
ALTER TABLE [Monhoc] ADD FOREIGN KEY ([MaKhoa]) REFERENCES [Khoa] ([MaKhoa])
GO




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