USE [master]
GO

CREATE DATABASE [TTN_QLTV]
 CONTAINMENT = NONE
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TTN_QLTV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TTN_QLTV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TTN_QLTV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TTN_QLTV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TTN_QLTV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TTN_QLTV] SET ARITHABORT OFF 
GO
ALTER DATABASE [TTN_QLTV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TTN_QLTV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TTN_QLTV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TTN_QLTV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TTN_QLTV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TTN_QLTV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TTN_QLTV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TTN_QLTV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TTN_QLTV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TTN_QLTV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TTN_QLTV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TTN_QLTV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TTN_QLTV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TTN_QLTV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TTN_QLTV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TTN_QLTV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TTN_QLTV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TTN_QLTV] SET RECOVERY FULL 
GO
ALTER DATABASE [TTN_QLTV] SET  MULTI_USER 
GO
ALTER DATABASE [TTN_QLTV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TTN_QLTV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TTN_QLTV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TTN_QLTV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TTN_QLTV] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TTN_QLTV', N'ON'
GO
USE [TTN_QLTV]
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MaDG] [nchar](10) NOT NULL,
	[TenDG] [nchar](50) NOT NULL,
	[GioiTinh] [nchar](10) NULL,
	[DiaChi] [nchar](100) NULL,
	[SDT_EMAIL] [nchar](50) NULL,
	[NgaySinh] [smalldatetime] NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nchar](20) NOT NULL,
	[TenNV] [nchar](50) NULL,
	[GioiTinh] [nchar](10) NULL,
	[DiaChi] [nchar](100) NULL,
	[SDT_EMAIL] [varchar](50) NULL,
	[NgaySinh] [smalldatetime] NULL,
	[Quyenhan] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NXB](
	[MaNXB] [nchar](10) NOT NULL,
	[TenNXB] [nchar](100) NOT NULL,
	[DiaChi] [nchar](100) NULL,
	[SDT_EMAIL] [nchar](20) NOT NULL,
 CONSTRAINT [PK_NXB] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MaPM] [nchar](10) NOT NULL,
	[MaDG] [nchar](10) NOT NULL,
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[NgayMuon] [smalldatetime] NULL,
 CONSTRAINT [PK_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QL_PHIEUMUON]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_PHIEUMUON](
	[MaPM] [nchar](10) NOT NULL,
	[MaSach] [nchar](10) NOT NULL,
	[HanTra] [smalldatetime] NOT NULL,
	[SoLuongSM] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [nchar](10) NOT NULL,
	[TenSach] [nchar](100) NOT NULL,
	[Gia] [bigint] NULL,
	[MaNXB] [nchar](10) NULL,
	[MaTL] [nchar](10) NULL,
	[SoLuong] [int] NULL,
	[SoTrang] [int] NULL,
	[SoSachHong] [int] NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTL] [nchar](10) NOT NULL,
	[TenTL] [nchar](100) NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRASACH]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRASACH](
	[MaPM] [nchar](10) NOT NULL,
	[MaSach] [nchar](10) NOT NULL,
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[NgayTra] [smalldatetime] NOT NULL,
	[PhatQuaHan] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DSMUON]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE view [dbo].[DSMUON] AS SELECT DISTINCT dg.TenDG,s.TenSach,pm.NgayMuon,qlpm.HanTra,ts.PhatQuaHan from PHIEUMUON pm join QL_PHIEUMUON qlpm on pm.MaPM=qlpm.MaPM join DOCGIA dg on pm.MaDG=dg.MaDG join TRASACH ts on ts.MaPM=qlpm.MaPM join SACH s on s.MaSach=qlpm.MaSach  
GO
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh]) VALUES (N'DG01      ', N'Nguyễn Nam Anh                                    ', N'Nam       ', N'Hà Nội                                                                                              ', N'0334734334                                        ', CAST(N'1998-11-19T00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh]) VALUES (N'DG02      ', N'Nguyễn Thị Trinh                                  ', N'Nữ        ', N'Hà Nội                                                                                              ', N'03847576                                          ', CAST(N'1998-11-19T00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh]) VALUES (N'DG03      ', N'Vũ Đình Đạt                                       ', N'Nam       ', N'Hà Nội                                                                                              ', N'037374634                                         ', CAST(N'1996-07-13T00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh]) VALUES (N'DG04      ', N'Nguyễn Văn D                                      ', N'Nam       ', N'Hà Nội                                                                                              ', N'0214812                                           ', CAST(N'1998-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh]) VALUES (N'DG05      ', N'Nguyễn E                                          ', N'Nam       ', N'Hà Nội                                                                                              ', N'0245648                                           ', CAST(N'1998-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[NHANVIEN] ([TaiKhoan], [MatKhau], [TenNV], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh], [Quyenhan]) VALUES (N'ADMIN', N'123456              ', N'Vũ Minh Trí                                       ', N'Nam       ', N'Thái Bình                                                                                           ', N'016788584', CAST(N'1988-06-29T00:00:00' AS SmallDateTime), N'admin')
INSERT [dbo].[NHANVIEN] ([TaiKhoan], [MatKhau], [TenNV], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh], [Quyenhan]) VALUES (N'Hieu123', N'123456              ', N'Hiếu Nguyễn                                       ', N'Nữ        ', N'Hưng Yên                                                                                            ', N'08283828', CAST(N'1984-11-27T00:00:00' AS SmallDateTime), N'user')
INSERT [dbo].[NHANVIEN] ([TaiKhoan], [MatKhau], [TenNV], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh], [Quyenhan]) VALUES (N'NV01', N'123456              ', N'Ngô Thị Hòa                                       ', N'Nữ        ', N'Kon Tum                                                                                             ', N'1234667', CAST(N'2017-11-29T00:00:00' AS SmallDateTime), N'user')
INSERT [dbo].[NHANVIEN] ([TaiKhoan], [MatKhau], [TenNV], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh], [Quyenhan]) VALUES (N'NV02', N'1234                ', N'Nguyễn Văn Chung                                  ', N'Nam       ', N'Kon Tum                                                                                             ', N'012225548', CAST(N'1972-12-19T00:00:00' AS SmallDateTime), N'user')
INSERT [dbo].[NHANVIEN] ([TaiKhoan], [MatKhau], [TenNV], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh], [Quyenhan]) VALUES (N'NV03', N'123                 ', N'Phan Phú Quốc                                     ', N'Nam       ', N'Nghĩa Hành                                                                                          ', N'0111111111', CAST(N'1996-12-24T00:00:00' AS SmallDateTime), N'user')
INSERT [dbo].[NHANVIEN] ([TaiKhoan], [MatKhau], [TenNV], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh], [Quyenhan]) VALUES (N'NV04', N'hoango              ', N'Vương Thị Lê                                      ', N'Nữ        ', N'Nghê An                                                                                             ', N'0199438', CAST(N'1985-12-03T00:00:00' AS SmallDateTime), N'user')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT_EMAIL]) VALUES (N'NXB001    ', N'Gstar                                                                                               ', N'TP HCM                                                                                              ', N'011111245664        ')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT_EMAIL]) VALUES (N'NXB002    ', N'Tiền Phong                                                                                          ', N'Hà Nội                                                                                              ', N'011111245664        ')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT_EMAIL]) VALUES (N'NXB004    ', N'Nhã Nam                                                                                             ', N'Hà Nội                                                                                              ', N'01678265701         ')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT_EMAIL]) VALUES (N'NXV005    ', N'Skybook                                                                                             ', N'Hà Nội                                                                                              ', N'1678265701          ')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDG], [TaiKhoan], [NgayMuon]) VALUES (N'PM001     ', N'DG04      ', N'NV01', CAST(N'2020-04-14T00:00:00' AS SmallDateTime))
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDG], [TaiKhoan], [NgayMuon]) VALUES (N'PM003     ', N'DG01      ', N'NV02', CAST(N'2020-04-13T00:00:00' AS SmallDateTime))
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDG], [TaiKhoan], [NgayMuon]) VALUES (N'PM009     ', N'DG04      ', N'NV03', CAST(N'2020-04-17T00:00:00' AS SmallDateTime))
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra], [SoLuongSM]) VALUES (N'PM001     ', N'S005      ', CAST(N'2020-12-03T00:00:00' AS SmallDateTime), 4)
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra], [SoLuongSM]) VALUES (N'PM001     ', N'S002      ', CAST(N'2020-12-03T00:00:00' AS SmallDateTime), 4)
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra], [SoLuongSM]) VALUES (N'PM003     ', N'S005      ', CAST(N'2020-12-03T00:00:00' AS SmallDateTime), 4)
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra], [SoLuongSM]) VALUES (N'PM003     ', N'S007      ', CAST(N'2020-12-03T00:00:00' AS SmallDateTime), 4)
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra], [SoLuongSM]) VALUES (N'PM003     ', N'S006      ', CAST(N'2020-12-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [SoLuong], [SoTrang], [SoSachHong]) VALUES (N'S002      ', N'Công nghệ phần miềm                                                                                 ', 78000, N'NXB002    ', N'TL01      ', 76, 324, 2)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [SoLuong], [SoTrang], [SoSachHong]) VALUES (N'S003      ', N'Toán đại cương                                                                                      ', 45000, N'NXB001    ', N'TL02      ', 49, 350, 3)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [SoLuong], [SoTrang], [SoSachHong]) VALUES (N'S004      ', N'Toán đại cương                                                                                      ', 45000, N'NXB001    ', N'TL02      ', 37, 200, 0)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [SoLuong], [SoTrang], [SoSachHong]) VALUES (N'S005      ', N'Vật Lý đại cương                                                                                    ', 50000, N'NXB001    ', N'TL01      ', 30, 258, 2)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [SoLuong], [SoTrang], [SoSachHong]) VALUES (N'S006      ', N'Cấu trúc dữ liệu                                                                                    ', 680000, N'NXB001    ', N'TL01      ', 45, 234, 2)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [SoLuong], [SoTrang], [SoSachHong]) VALUES (N'S007      ', N'Bạch dạ hành                                                                                        ', 392944, N'NXV005    ', N'TL02      ', 45, 324, 2)
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL01      ', N'Công nghệ thông tin                                                                                 ')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL02      ', N'Trinh Thám                                                                                          ')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL03      ', N'Tạp chí                                                                                             ')
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [TaiKhoan], [NgayTra], [PhatQuaHan]) VALUES (N'PM003     ', N'S007      ', N'NV02', CAST(N'2020-12-03T00:00:00' AS SmallDateTime), 0)
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [TaiKhoan], [NgayTra], [PhatQuaHan]) VALUES (N'PM001     ', N'S006      ', N'NV01', CAST(N'2020-12-03T00:00:00' AS SmallDateTime), 0)
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [TaiKhoan], [NgayTra], [PhatQuaHan]) VALUES (N'PM001     ', N'S002      ', N'NV01', CAST(N'2020-12-03T00:00:00' AS SmallDateTime), 0)
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [TaiKhoan], [NgayTra], [PhatQuaHan]) VALUES (N'PM003     ', N'S005      ', N'NV02', CAST(N'2020-12-03T00:00:00' AS SmallDateTime), 0)
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [TaiKhoan], [NgayTra], [PhatQuaHan]) VALUES (N'PM003     ', N'S006      ', N'NV02', CAST(N'2020-12-03T00:00:00' AS SmallDateTime), 0)
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_DOCGIA] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DOCGIA] ([MaDG])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_TAIKHOAN] FOREIGN KEY([TaiKhoan])
REFERENCES [dbo].[NHANVIEN] ([TaiKhoan])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_TAIKHOAN]
GO
ALTER TABLE [dbo].[QL_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_QLPHIEUMUON_PHIEUMUON] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PHIEUMUON] ([MaPM])
GO
ALTER TABLE [dbo].[QL_PHIEUMUON] CHECK CONSTRAINT [FK_QLPHIEUMUON_PHIEUMUON]
GO
ALTER TABLE [dbo].[QL_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_QLPHIEUMUON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[QL_PHIEUMUON] CHECK CONSTRAINT [FK_QLPHIEUMUON_SACH]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NXB] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NXB] ([MaNXB])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NXB]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_TK] FOREIGN KEY([MaTL])
REFERENCES [dbo].[THELOAI] ([MaTL])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_TK]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_PHIEUMUON] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PHIEUMUON] ([MaPM])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_PHIEUMUON]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_SACH]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_TAIKHOAN] FOREIGN KEY([TaiKhoan])
REFERENCES [dbo].[NHANVIEN] ([TaiKhoan])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_TAIKHOAN]
GO
/****** Object:  StoredProcedure [dbo].[DEL_NXB]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DEL_NXB] @manxb nchar(10)
AS
BEGIN
  UPDATE dbo.SACH SET MaNXB=NULL WHERE MaNXB=@manxb
  DELETE FROM dbo.NXB WHERE MaNXB=@manxb
END
GO
/****** Object:  StoredProcedure [dbo].[DEL_Theloai]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DEL_Theloai] @matl nchar(10)
AS
BEGIN
  UPDATE dbo.SACH SET MaTL=NULL WHERE MaTL=@matl
  DELETE FROM dbo.THELOAI WHERE MaTL=@matl
END 
GO
/****** Object:  StoredProcedure [dbo].[DSSachmuon]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSSachmuon] @MaDocGia CHAR(10)
AS
begin
SELECT ql.MaSach, ql.SoLuongSM AS SL
FROM QL_PHIEUMUON ql,dbo.PHIEUMUON pm
WHERE pm.MaPM=ql.MaPM AND  MaDG= @MaDocGia
GROUP BY ql.MaSach ,ql.SoLuongSM
end
GO
/****** Object:  StoredProcedure [dbo].[TONGSACHMUON]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TONGSACHMUON] @MASACH CHAR(10)
AS
SELECT MASACH, COUNT(SOLUONGSM) SLSM
FROM QL_PHIEUMUON
WHERE MASACH= @MASACH
GROUP BY MaSach
GO
/****** Object:  StoredProcedure [dbo].[TONGSOSM]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[TONGSOSM] @MASACH CHAR(10)
AS
SELECT MASACH, COUNT(SOLUONGSM) SL
FROM QL_PHIEUMUON
WHERE MASACH= @MASACH
GROUP BY MaSach
GO
/****** Object:  StoredProcedure [dbo].[TONGSSM]    Script Date: 6/24/2020 9:06:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[TONGSSM] @MASACH CHAR(10)
AS
SELECT MASACH, SUM(SOLUONGSM) SL
FROM QL_PHIEUMUON
WHERE MASACH=@MASACH
GROUP BY MaSach
GO
USE [master]
GO
ALTER DATABASE [TTN_QLTV] SET  READ_WRITE 
GO
