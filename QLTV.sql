USE master
GO
CREATE DATABASE TTN_QLTV

USE TTN_QLTV

CREATE TABLE DOCGIA(
	MaDG nchar(10) NOT NULL,
	TenDG nchar(50) NOT NULL,
	GioiTinh nchar(10) NULL,
	DiaChi nchar(100) NULL,
	SDT_EMAIL nchar(50) NULL,
	NgaySinh smalldatetime NULL,
 CONSTRAINT PK_DOCGIA PRIMARY KEY(MaDG) 
)
GO
--BẢNG NHÂN VIÊN
CREATE TABLE NHANVIEN(
	TaiKhoan nvarchar(50) NOT NULL,
	MatKhau nchar(20) NOT NULL,
	TenNV nchar(50) NULL,
	GioiTinh nchar(10) NULL,
	DiaChi nchar(100) NULL,
	SDT_EMAIL varchar(50) NULL,
	NgaySinh smalldatetime NULL,
	Quyenhan nvarchar(50) NOT NULL,
 CONSTRAINT PK_NHANVIEN PRIMARY KEY(TaiKhoan)
)
GO
--BẢNG THỂ LOẠI
CREATE TABLE THELOAI(
	MaTL nchar(10) NOT NULL,
	TenTL nchar(100) NULL,
 CONSTRAINT PK_THELOAI PRIMARY KEY(MaTL) 
)
GO
--BẢNG NHÀ XUẤT BẢN
CREATE TABLE NXB(
	MaNXB nchar(10) NOT NULL,
	TenNXB nchar(100) NOT NULL,
	DiaChi nchar(100) NULL,
	SDT_EMAIL nchar(20) NOT NULL,
 CONSTRAINT PK_NXB PRIMARY KEY(MaNXB)
)
--BẢNG SÁCH
GO
CREATE TABLE SACH(
	MaSach nchar(10) NOT NULL,
	TenSach nchar(100) NOT NULL,
	Gia bigint NULL,
	MaNXB nchar(10) NULL,
	MaTL nchar(10) NULL,
	SoLuong int NULL,
	SoTrang int NULL,
	SoSachHong int NULL,
 CONSTRAINT PK_SACH PRIMARY KEY(MaSach)
)
GO
--BẢNG PHIÊU MƯỢN

CREATE TABLE PHIEUMUON(
	MaPM nchar(10) NOT NULL,
	MaDG nchar(10) NOT NULL,
	TaiKhoan nvarchar(50) NOT NULL,
	NgayMuon smalldatetime NULL,
 CONSTRAINT PK_PHIEUMUON PRIMARY KEY(MaPM)
)

--BẢNG QUẢN LÝ PHIẾU MƯỢN
GO
CREATE TABLE dbo.QL_PHIEUMUON(
	MaPM nchar(10) NOT NULL,
	MaSach nchar(10) NOT NULL,
	HanTra smalldatetime NOT NULL,
	SoLuongSM int NULL
)
GO
--BẢNG TRẢ SÁCH
GO
CREATE TABLE [dbo].[TRASACH](
	MaPM nchar(10) NOT NULL,
	MaSach nchar(10) NOT NULL,
	TaiKhoan nvarchar(50) NOT NULL,
	NgayTra smalldatetime NOT NULL,
	PhatQuaHan bigint NULL
) 
GO


ALTER TABLE dbo.SACH ADD CONSTRAINT FK_SACH_TK FOREIGN KEY(MaTL) REFERENCES dbo.THELOAI(MaTL)
ALTER TABLE dbo.SACH ADD CONSTRAINT FK_SACH_NXB FOREIGN KEY(MaNXB) REFERENCES dbo.NXB(MaNXB)
ALTER TABLE dbo.PHIEUMUON ADD CONSTRAINT FK_PHIEUMUON_DOCGIA FOREIGN KEY(MaDG) REFERENCES dbo.DOCGIA(MaDG)
ALTER TABLE dbo.QL_PHIEUMUON ADD CONSTRAINT FK_QLPHIEUMUON_SACH FOREIGN KEY(MaSach) REFERENCES dbo.SACH(MaSach)
ALTER TABLE dbo.QL_PHIEUMUON ADD CONSTRAINT FK_QLPHIEUMUON_PHIEUMUON FOREIGN KEY(MaPM) REFERENCES dbo.PHIEUMUON(MaPM)
ALTER TABLE dbo.TRASACH ADD CONSTRAINT FK_TRASACH_SACH FOREIGN KEY(MaSach) REFERENCES dbo.SACH(MaSach)
ALTER TABLE dbo.TRASACH ADD CONSTRAINT FK_TRASACH_PHIEUMUON FOREIGN KEY(MaPM) REFERENCES dbo.PHIEUMUON(MaPM)
ALTER TABLE dbo.TRASACH ADD CONSTRAINT FK_TRASACH_TAIKHOAN FOREIGN KEY(TaiKhoan) REFERENCES dbo.NHANVIEN(TaiKhoan)
ALTER TABLE dbo.PHIEUMUON ADD CONSTRAINT FK_PHIEUMUON_TAIKHOAN FOREIGN KEY(TaiKhoan) REFERENCES dbo.NHANVIEN(TaiKhoan)







 CREATE view DSMUON AS SELECT DISTINCT dg.TenDG,s.TenSach,pm.NgayMuon,qlpm.HanTra,ts.PhatQuaHan from PHIEUMUON pm join QL_PHIEUMUON qlpm on pm.MaPM=qlpm.MaPM join DOCGIA dg on pm.MaDG=dg.MaDG join TRASACH ts on ts.MaPM=qlpm.MaPM join SACH s on s.MaSach=qlpm.MaSach  
GO
--NHẬP DỮ LIỆU
INSERT DOCGIA (MaDG, TenDG, GioiTinh, DiaChi, SDT_EMAIL, NgaySinh) VALUES (N'DG01', N'Nguyễn Nam Anh', N'Nam', N'Hà Nội', N'0334734334', CAST(N'1998-11-19 00:00:00' AS SmallDateTime))
INSERT DOCGIA (MaDG, TenDG, GioiTinh, DiaChi, SDT_EMAIL, NgaySinh) VALUES (N'DG02', N'Nguyễn Thị Trinh', N'Nữ', N'Hà Nội', N'03847576', CAST(N'1998-11-19 00:00:00' AS SmallDateTime))
INSERT DOCGIA (MaDG, TenDG, GioiTinh, DiaChi, SDT_EMAIL, NgaySinh) VALUES (N'DG03', N'Vũ Đình Đạt', N'Nam', N'Hà Nội', N'037374634', CAST(N'1996-07-13 00:00:00' AS SmallDateTime))
INSERT DOCGIA (MaDG, TenDG, GioiTinh, DiaChi, SDT_EMAIL, NgaySinh) VALUES (N'DG04', N'Nguyễn Văn D', N'Nam', N'Hà Nội', N'0214812', CAST(N'1998-11-27 00:00:00' AS SmallDateTime))
INSERT DOCGIA (MaDG, TenDG, GioiTinh, DiaChi, SDT_EMAIL, NgaySinh) VALUES (N'DG05', N'Nguyễn E', N'Nam', N'Hà Nội', N'0245648             ', CAST(N'1998-11-27 00:00:00' AS SmallDateTime))
INSERT NHANVIEN (TaiKhoan, TenNV, GioiTinh, DiaChi, SDT_EMAIL, NgaySinh, MatKhau, Quyenhan) VALUES (N'ADMIN', N'Vũ Minh Trí', N'Nam', N'Thái Bình', N'016788584', CAST(N'1988-06-29 00:00:00' AS SmallDateTime), N'123456', N'admin')
INSERT NHANVIEN (TaiKhoan, TenNV, GioiTinh, DiaChi, SDT_EMAIL, NgaySinh, MatKhau, Quyenhan) VALUES (N'Hieu123', N'Hiếu Nguyễn', N'Nữ', N'Hưng Yên', N'08283828', CAST(N'1984-11-27 00:00:00' AS SmallDateTime), N'123456', N'user')
INSERT NHANVIEN (TaiKhoan, TenNV, GioiTinh, DiaChi, SDT_EMAIL, NgaySinh, MatKhau, Quyenhan) VALUES (N'NV01', N'Ngô Thị Hòa', N'Nữ', N'Kon Tum', N'1234667', CAST(N'2017-11-29 00:00:00' AS SmallDateTime), N'123456', N'user')
INSERT NHANVIEN (TaiKhoan, TenNV, GioiTinh, DiaChi, SDT_EMAIL, NgaySinh, MatKhau, Quyenhan) VALUES (N'NV02', N'Nguyễn Văn Chung', N'Nam', N'Kon Tum', N'012225548', CAST(N'1972-12-19 00:00:00' AS SmallDateTime), N'1234', N'user')
INSERT NHANVIEN (TaiKhoan, TenNV, GioiTinh, DiaChi, SDT_EMAIL, NgaySinh, MatKhau, Quyenhan) VALUES (N'NV03', N'Phan Phú Quốc', N'Nam', N'Nghĩa Hành', N'0111111111', CAST(N'1996-12-24 00:00:00' AS SmallDateTime), N'123', N'user')
INSERT NHANVIEN (TaiKhoan, TenNV, GioiTinh, DiaChi, SDT_EMAIL, NgaySinh, MatKhau, Quyenhan) VALUES (N'NV04', N'Vương Thị Lê', N'Nữ', N'Nghê An', N'0199438', CAST(N'1985-12-03 00:00:00' AS SmallDateTime), N'hoango', N'user')
INSERT NXB (MaNXB, TenNXB, DiaChi, SDT_EMAIL) VALUES (N'NXB001', N'Gstar', N'TP HCM', N'011111245664')
INSERT NXB (MaNXB, TenNXB, DiaChi, SDT_EMAIL) VALUES (N'NXB002', N'Tiền Phong', N'Hà Nội', N'011111245664')
INSERT NXB (MaNXB, TenNXB, DiaChi, SDT_EMAIL) VALUES (N'NXB003', N'Tuổi Trẻ', N'Hà Nội', N'02315646')
INSERT NXB (MaNXB, TenNXB, DiaChi, SDT_EMAIL) VALUES (N'NXB004', N'Nhã Nam', N'Hà Nội', N'01678265701')
INSERT NXB (MaNXB, TenNXB, DiaChi, SDT_EMAIL) VALUES (N'NXV005', N'Skybook', N'Hà Nội', N'1678265701')
INSERT THELOAI (MaTL, TenTL) VALUES (N'TL01', N'Công nghệ thông tin')
INSERT THELOAI (MaTL, TenTL) VALUES (N'TL02', N'Trinh Thám')
INSERT THELOAI (MaTL, TenTL) VALUES (N'TL03', N'Tạp chí')
INSERT THELOAI (MaTL, TenTL) VALUES (N'TL04', N'KINH TẾ')
INSERT SACH (MaSach, TenSach, Gia, MaNXB, MaTL, SoLuong, SoTrang, SoSachHong) VALUES (N'S002', N'Công nghệ phần miềm', 78000, N'NXB002', N'TL01', 76, 324, 2)
INSERT SACH (MaSach, TenSach, Gia, MaNXB, MaTL, SoLuong, SoTrang, SoSachHong) VALUES (N'S003', N'Toán đại cương', 45000, N'NXB001', N'TL02', 49, 350, 3)
INSERT SACH (MaSach, TenSach, Gia, MaNXB, MaTL, SoLuong, SoTrang, SoSachHong) VALUES (N'S004', N'Toán đại cương', 45000, N'NXB001', N'TL02', 37, 200, 0)
INSERT SACH (MaSach, TenSach, Gia, MaNXB, MaTL, SoLuong, SoTrang, SoSachHong) VALUES (N'S005', N'Vật Lý đại cương', 50000, N'NXB001', N'TL01', 30, 258, 2)
INSERT SACH (MaSach, TenSach, Gia, MaNXB, MaTL, SoLuong, SoTrang, SoSachHong) VALUES (N'S006', N'Cấu trúc dữ liệu', 680000, N'NXB001', N'TL01', 46, 234, 2)
INSERT SACH (MaSach, TenSach, Gia, MaNXB, MaTL, SoLuong, SoTrang, SoSachHong) VALUES (N'S007', N'Bạch dạ hành', 392944, N'NXV005', N'TL02', 45, 324, 2)
INSERT PHIEUMUON (MaPM, MaDG, TaiKhoan, NgayMuon) VALUES (N'PM001', N'DG04', N'NV01', CAST(N'2020-04-14 00:00:00' AS SmallDateTime))
INSERT PHIEUMUON (MaPM, MaDG, TaiKhoan, NgayMuon) VALUES (N'PM003', N'DG01', N'NV02', CAST(N'2020-04-13 00:00:00' AS SmallDateTime))
INSERT PHIEUMUON (MaPM, MaDG, TaiKhoan, NgayMuon) VALUES (N'PM009', N'DG04', N'NV03', CAST(N'2020-04-17 00:00:00' AS SmallDateTime))
INSERT QL_PHIEUMUON (MaPM, MaSach, HanTra, SoLuongSM) VALUES (N'PM001', N'S005', CAST(N'2020-12-03 00:00:00' AS SmallDateTime), 4)
INSERT QL_PHIEUMUON (MaPM, MaSach, HanTra, SoLuongSM) VALUES (N'PM001', N'S002', CAST(N'2020-12-03 00:00:00' AS SmallDateTime), 4)
INSERT QL_PHIEUMUON (MaPM, MaSach, HanTra, SoLuongSM) VALUES (N'PM003', N'S005', CAST(N'2020-12-03 00:00:00' AS SmallDateTime), 4)
INSERT QL_PHIEUMUON (MaPM, MaSach, HanTra, SoLuongSM) VALUES (N'PM003', N'S007', CAST(N'2020-12-03 00:00:00' AS SmallDateTime), 4)
INSERT TRASACH (MaPM, MaSach, TaiKhoan, NgayTra, PhatQuaHan) VALUES (N'PM003', N'S007', N'NV02', CAST(N'2020-12-03 00:00:00' AS SmallDateTime), 0)
INSERT TRASACH (MaPM, MaSach, TaiKhoan, NgayTra, PhatQuaHan) VALUES (N'PM001', N'S006', N'NV01', CAST(N'2020-12-03 00:00:00' AS SmallDateTime), 0)
INSERT TRASACH (MaPM, MaSach, TaiKhoan, NgayTra, PhatQuaHan) VALUES (N'PM001', N'S002', N'NV01', CAST(N'2020-12-03 00:00:00' AS SmallDateTime), 0)
INSERT TRASACH (MaPM, MaSach, TaiKhoan, NgayTra, PhatQuaHan) VALUES (N'PM003', N'S005', N'NV02', CAST(N'2020-12-03 00:00:00' AS SmallDateTime), 0)


CREATE PROC TONGSACHMUON @MASACH CHAR(10)
AS
SELECT MASACH, COUNT(SOLUONGSM) SLSM
FROM QL_PHIEUMUON
WHERE MASACH= @MASACH
GROUP BY MaSach
GO

CREATE PROC TONGSOSM @MASACH CHAR(10)
AS
SELECT MASACH, COUNT(SOLUONGSM) SL
FROM QL_PHIEUMUON
WHERE MASACH= @MASACH
GROUP BY MaSach
GO


CREATE PROC TONGSSM @MASACH CHAR(10)
AS
SELECT MASACH, SUM(SOLUONGSM) SL
FROM QL_PHIEUMUON
WHERE MASACH=@MASACH
GROUP BY MaSach
GO

--CREATE FUNCTION TONGSM @MASACH CHAR(10)
--RETURNS TABLE AS
--RETURN ( SELECT MASACH, COUNT(SOLUONGSM) SLSM
--FROM QL_PHIEUMUON
--WHERE MASACH= @MASACH
--GROUP BY MaSach)
--GO 

SELECT TOP 1 WITH TIES pm.MaDG,SUM(ql.SoLuongSM)AS SoLuong
FROM dbo.QL_PHIEUMUON ql
INNER JOIN dbo.PHIEUMUON pm ON pm.MaPM = ql.MaPM
WHERE pm.NgayMuon BETWEEN '2020-04-01' AND '2020-04-30'
GROUP BY pm.MaDG
ORDER BY SoLuong DESC


SELECT TOP 1 WITH TIES ql.MaSach,SUM(ql.SoLuongSM)AS SoLuong
FROM dbo.QL_PHIEUMUON ql
INNER JOIN dbo.PHIEUMUON pm ON pm.MaPM = ql.MaPM
WHERE pm.NgayMuon BETWEEN '2020-04-01' AND '2020-04-30'
GROUP BY ql.MaSach
ORDER BY SoLuong DESC



SELECT TenNV,GioiTinh,DiaChi,SDT_EMAIL,NgaySinh FROM dbo.NHANVIEN
select TaiKhoan,TenNV,GioiTinh,DiaChi,SDT_EMAIL,NgaySinh from NHANVIEN
select*from Sach where Gia like'%78000%'