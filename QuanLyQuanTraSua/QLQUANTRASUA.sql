CREATE DATABASE QLQUANTRASUA

USE QLQUANTRASUA

--Tạo bảng Quyền
CREATE TABLE QUYEN
(
	MaQuyen char(10),
	TenQuyen nvarchar(50),
	CONSTRAINT PK_QUYEN PRIMARY KEY (MaQuyen)
)

--Tạo bảng Tài khoản
CREATE TABLE TAIKHOAN
(
	MaTaiKhoan char(10),
	Username varchar(100),
	Password varchar(100),
	MaQuyen char(10),
	MaNhanVien char(10)
	CONSTRAINT PK_TAIKHOAN PRIMARY KEY (MaTaiKhoan)
)

--Tạo bảng Nhân viên
CREATE TABLE NHANVIEN
(
	MaNhanVien char(10),
	HoTen nvarchar(100),
	NgaySinh date,
	GioiTinh nvarchar(5),
	SoDienThoai varchar(20),
	ChucVu char(10),
	CONSTRAINT PK_NHANVIEN PRIMARY KEY (MaNhanVien)
)

--Tạo bảng Chức vụ
CREATE TABLE CHUCVU
(
	MaChucVu char(10),
	TenChucVu nvarchar(100)
	CONSTRAINT PK_CHUCVU PRIMARY KEY (MaChucVu)
)

--Tạo bảng Danh mục sản phẩm
CREATE TABLE DANHMUCSANPHAM
(
	MaDanhMuc char(10),
	TenDanhMuc nvarchar(50),
	CONSTRAINT PK_DANHMUCSANPHAM PRIMARY KEY (MaDanhMuc)
)

--Tạo bảng Sản phẩm
CREATE TABLE SANPHAM
(
	MaSanPham char(10),
	TenSanPham nvarchar(100),
	Size char(10),
	DonGia decimal(18,0),
	MaDanhMuc char(10),
	HinhAnh varchar(500),
	CONSTRAINT PK_SANPHAM PRIMARY KEY (MaSanPham)
)

--Tạo bảng Hóa đơn
CREATE TABLE HOADON
(
	MaHoaDon char(10),
	NguoiLapHoaDon char(10),
	NgayLapHoaDon datetime,
	TongTien decimal(18,0),
	CONSTRAINT PK_HOADON PRIMARY KEY (MaHoaDon)
)

--Tạo bảng Chi tiết hóa đơn
CREATE TABLE CHITIETHOADON
(
	MaSanPham char(10),
	MaHoaDon char(10),
	SoLuong int,
	CONSTRAINT PK_CHITIETHOADON PRIMARY KEY (MaSanPham, MaHoaDon)
)

--Tạo khóa ngoại bảng Tài khoản
ALTER TABLE TAIKHOAN 
ADD CONSTRAINT FK_TAIKHOAN_MAQUYEN FOREIGN KEY (MaQuyen) REFERENCES QUYEN (MaQuyen),
	CONSTRAINT FK_TAIKHOAN_MANHANVIEN FOREIGN KEY (MaNhanVien) REFERENCES NHANVIEN (MaNhanVien)

--Tạo khóa ngoại bảng Nhân viên
ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NHANVIEN_CHUCVU FOREIGN KEY (ChucVu) REFERENCES CHUCVU (MaChucVu)

--Tạo khóa ngoại bảng Hóa đơn
ALTER TABLE HOADON
ADD CONSTRAINT FK_HOADON_NGUOILAPHOADON FOREIGN KEY (NguoiLapHoaDon) REFERENCES NHANVIEN (MaNhanVien)

--Tạo khóa ngoại bảng Sản phẩm
ALTER TABLE SANPHAM
ADD CONSTRAINT FK_SANPHAM_MADANHMUC FOREIGN KEY (MaDanhMuc) REFERENCES DANHMUCSANPHAM (MaDanhMuc)

--Tạo khóa ngoại bảng Chi tiết hóa đơn
ALTER TABLE CHITIETHOADON
ADD CONSTRAINT FK_CHITIETHOADON_MASANPHAM FOREIGN KEY (MaSanPham) REFERENCES SANPHAM (MaSanPham),
	CONSTRAINT FK_CHITIETHOADON_MAHOADON FOREIGN KEY (MaHoaDon) REFERENCES HOADON (MaHoaDon)
