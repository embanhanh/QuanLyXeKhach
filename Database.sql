CREATE DATABASE QLBX

GO

USE QLBX
CREATE TABLE BENXE
(
	IDBenXe char(6) NOT NULL PRIMARY KEY,
	TenBenXe varchar(40)  NOT NULL,
	DiaChi varchar(40),
	SoDienThoaiBen char(8),
	TongXe char(3),
)

CREATE TABLE TAIXE
(
	CCCDTX char(12) NOT NULL PRIMARY KEY,
	FOREIGN KEY (IDBenXeXuatPhat) REFERENCES BENXE(IDBenXe),
	TenTaiXe varchar(40) NOT NULL,
	SoDienThoai char(10),
	DiaChi varchar(40),
)
GO

CREATE TABLE NHANVIEN
(
	IDNhanVien char (6) NOT NULL PRIMARY KEY,
	FOREIGN KEY (IDBenXeXuatPhat) REFERENCES BENXE(IDBenXe),
	HoTenNhanVien varchar(40),
	SoDienThoai char(10),
)
GO

CREATE TABLE XEKHACH
(
	BienSoXe varchar(8) NOT NULL PRIMARY KEY,
	FOREIGN KEY (CCCDTX) REFERENCES TAIXE(CCCDTX),
	FOREIGN KEY (IDBenXeXuatPhat) REFERENCES BENXE(IDBenXe),
	LoaiXe varchar(40),
	SoGheTrong char(2) ,
	TinhTrang varchar(40),
)
GO

CREATE TABLE GHE
(
	IDGhe char(8) NOT NULL PRIMARY KEY,
	FOREIGN KEY (BienSoXe) REFERENCES XEKHACH(BienSoXe),
	TRONG BIT,
)
GO

CREATE TABLE TUYENXE
(
	IDTuyenXe char(6) NOT NULL PRIMARY KEY,
	FOREIGN KEY (IDBenXeXuatPhat) REFERENCES BENXE(IDBenXe),
	FOREIGN KEY (IDBenKetThuc) REFERENCES BENXE(IDBenXe),
	ThoiGianXuatPhat smalldatetime,
	ThoiGianKetThuc varchar(40),
)
GO  

CREATE TABLE LICHTRINH
(
	IDLichTrinh char(6) NOT NULL PRIMARY KEY,
	FOREIGN KEY (IDTuyenXe) REFERENCES TUYENXE(IDTuyenXe),
	FOREIGN KEY (BienSoXe) REFERENCES XEKHACH(BienSoXe),
	ThoiGianXuatBen smalldatetime,
	ThoiGianKetThuc smalldatetime,
	TongKhach char(2),
	TramDungChan varchar(max),
)
GO

CREATE TABLE GIAVE
(
	IDLichSu char(6) NOT NULL PRIMARY KEY,
	FOREIGN KEY (IDBenXe) REFERENCES BENXE(IDBenXe),
	GiaVe money NOT NULL,
	BienDong varchar(20),
	NgayCapNhat smalldatetime,
	LiDoBienDong varchar(40),
)
GO

CREATE TABLE HANHKHACH
(
	IDHanhKhach char(10) NOT NULL PRIMARY KEY,
	FOREIGN KEY (SoHieuGhe) REFERENCES GHE(IDGhe),
	TenHanhKhach varchar(40) NOT NULL ,
	Tuoi char(2),
	CCCD char(12),
	SDTHK char(10),
	DiaChiHK varchar(40),
)
GO

CREATE TABLE BIENLAI
(
	IDBienLai char(6) UNIQUE NOT NULL PRIMARY KEY,
	FOREIGN KEY (IDLichTrinh) REFERENCES LICHTRINH(IDLichTrinh),
	FOREIGN KEY (IDHanhKhach) REFERENCES HANHKHACH(IDHanhKhach),
	FOREIGN KEY (IDGiaVe) REFERENCES GIAVE(IDLichSu),
	NgayMua smalldatetime,
	DATHANHTOAN bit ,
	HinhThucThanhToan varchar(20),
	ThuNgan varchar(40),
)
GO