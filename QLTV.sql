create database QLYTV
go
use QLYTV
go

create table ACOUNT
(
HoTen nvarchar(50),
SoDT varchar(50),
Email nvarchar(50),
DiaChi nvarchar(50),
UserName varchar(50),
Passwords varchar(50)
)
create table SACH(
MaSach char(10) primary key,
TenSach nvarchar(50),
TacGia nvarchar(50),
NhaXB nvarchar(50),
TheLoai nvarchar(50),
SoTrang int,
GiaTien int,
TinhTrang nvarchar(50),
)
create table DOCGIA
(
MASV char(10) primary key,
TenSV nvarchar(50),
GioiTinh nchar(10),
NgaySinh date,
MaLop char(50),
TenLop nvarchar(50),
SoDT varchar(50),
Email varchar(50),
DiaChi nvarchar(50),
)
create table TACGIA
(
MaTG char(10) primary key,
TenTG nvarchar(50),
TenSach nvarchar(50),
NgayXB date,
)
create table NGUOIQUANLY
(
MaNQL char(10) primary key,
TenNQL nvarchar(50),
GioiTinh nchar(10),
NgaySinh date,
ChucVu nvarchar(50),
SoDT varchar(50),
DiaChi nvarchar(50),
Email varchar(50),
)
create table NHAXB
(
MaNXB char(10) primary key,
TenNXB nvarchar(50),
SoDT int,
DiaChi nvarchar(50),
Email nvarchar(50),
)
create table QUANLYSACH
(
MASV char(10),
TenSV nvarchar(50),
MaSach char(10),
TenSach nvarchar(50),
NgayMuon date,
NgayCanTra date,
TrangThai nvarchar(50),
TenNQL nvarchar(50),
MaNQL char(10),
foreign key(MaNQL) references dbo.NGUOIQUANLY(MaNQL),
foreign key(MASV) references dbo.DOCGIA(MASV),
)

ALTER TABLE NHAXB DROP COLUMN SoDT

ALTER TABLE NHAXB ADD SoDT varchar(50)