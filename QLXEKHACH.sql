CREATE DATABASE QLXEKHACH

GO
USE QLXEKHACH
CREATE TABLE BENXE
(
	IDBenXe char(6) NOT NULL PRIMARY KEY,
	TenBenXe nvarchar(40)  NOT NULL,
	DiaChi nvarchar(50),
	SoDienThoaiBen char(10),
)

CREATE TABLE TAIXE
(
	CCCDTX char(12) NOT NULL PRIMARY KEY,
	TenTaiXe nvarchar(40) NOT NULL,
	NgaySinh smalldatetime,
	SoDienThoai char(10),
	DiaChi nvarchar(50),
	BangLai nvarchar(10),
	Luong money
)

CREATE TABLE NHANVIEN
(
	CCCDNV char (12) NOT NULL PRIMARY KEY,
	HoTenNhanVien nvarchar(40),
	NgaySinh smalldatetime,
	SoDienThoai char(10),
	DiaChi nvarchar(50),
	GioiTinh nvarchar(10),
	Luong money
)

CREATE TABLE THUNGAN
(
	CCCDTN char (12) NOT NULL PRIMARY KEY,
	HoTen nvarchar(40),
	NgaySinh smalldatetime,
	SoDienThoai char(10),
	DiaChi nvarchar(50),
	GioiTinh nvarchar(10),
	Luong money
)

CREATE TABLE TUYENXE
(
	IDTuyenXe char(6) NOT NULL PRIMARY KEY,
	IDBenXeXuatPhat char(6) FOREIGN KEY  REFERENCES BENXE(IDBenXe),
	IDBenKetThuc char(6) FOREIGN KEY REFERENCES BENXE(IDBenXe),
	GioXuatPhat time,
	ThoiGianDuKien time,
)

CREATE TABLE XEKHACH
(
	BienSoXe varchar(9) NOT NULL PRIMARY KEY,
	CCCDTX char(12) FOREIGN KEY  REFERENCES TAIXE(CCCDTX),
	CCCDNV char(12) FOREIGN KEY  REFERENCES NHANVIEN(CCCDNV),
	LoaiXe nvarchar(40),
	TinhTrang nvarchar(40),
	SoGhe tinyint
)

CREATE TABLE LICHTRINH
(
	IDLICHTRINH char(6),
	IDTuyenXe char(6) foreign key References TUYENXE(IDTuyenXe),
	BienSoXe varchar(9) foreign key References XEKHACH(BienSoXe),
	NgayXuatPhat date,
	GiaVe money,
	constraint pk_lt primary key (IDLICHTRINH)
)

CREATE TABLE GHE
(
	IDGhe char(6) NOT NULL PRIMARY KEY,
	IDLICHTRINH char(6) FOREIGN KEY REFERENCES LICHTRINH(IDLICHTRINH),
	TINHTRANG bit,
)

CREATE TABLE HANHKHACH
(
	IDHanhKhach char(6) NOT NULL PRIMARY KEY,
	TenHanhKhach nvarchar(40) NOT NULL,
	GioiTinh nvarchar(6),
	Tuoi char(2),
	CCCD char(12),
	SDTHK char(10),
	DiaChiHK nvarchar(50),
)

CREATE TABLE BIENLAI
(
	IDBienLai char(6) PRIMARY KEY,
	IDGhe char(6) FOREIGN KEY REFERENCES GHE(IDGhe),
	IDHanhKhach char(6) FOREIGN KEY  REFERENCES HANHKHACH(IDHanhKhach),
	NgayMua smalldatetime,
	GiamGia nvarchar(20),
	ThuNgan char(12) FOREIGN KEY  REFERENCES THUNGAN(CCCDTN),
)
Create table UserInfo
( 
	Id int identity(1,1) primary key,
	UserName nvarchar(100),
	UserPassword nvarchar(max), 
	FullName nvarchar(max),
	SDT char(10),
	Roles nvarchar(30)
)
set dateformat dmy
--UserInfo--
insert into UserInfo(UserName,UserPassword,FullName,SDT,Roles) values(N'admin',N'db69fc039dcbd2962cb4d28f5891aae1',N'Đinh Như Thông',N'0987654321',N'Quản Lý')
insert into UserInfo(UserName,UserPassword,FullName,SDT,Roles) values(N'staff',N'978aae9bb6bee8fb75de3e4830a1be46',N'Phạm Ngọc Thịnh',N'0123456789',N'Thu Ngân')
--HANHKHACH--
insert into HANHKHACH values('HK0001',N'Phan Văn Tài','Nam','23','054427684123','0986471213',N'20 Nguyễn Trường Tô, Vĩnh Ninh, Tp Huế')
insert into HANHKHACH values('HK0002',N'Phạm Xuân Cảnh','Nam','32','051231212304','0656471221',N'Chợ mai Hưng Thủy, Lệ Thủy')
insert into HANHKHACH values('HK0003',N'Mai Thế Anh','Nam','16','078331212361','0356471245',N'Xã Lan Mẫu, Huyện Lục Nam, Bắc Giang')
insert into HANHKHACH values('HK0004',N'Nguyễn Thị Thanh',N'Nữ','20','025331792312','0256401298',N'Phường Quyết Tiến, Thành phố Lai Châu, Lai Châu')
insert into HANHKHACH values('HK0005',N'Trần Thị Hồng Nhung',N'Nữ','30','091331021339','0456401252',N'Phường Xuân La, Quận Tây Hồ, Hà Nội')
--TAIXE--
insert into TAIXE values('032483248031',N'Phan Văn Nhật','30/04/1990','0834532198',N'26b D.Nguyễn Văn Linh, Cần Thơ','D',8000000)
insert into TAIXE values('085912307324',N'Đặng Thành Nam','23/07/1995','0123543256',N'26b D.Nguyễn Văn Linh, Cần Thơ','E',8500000)
insert into TAIXE values('068122307376',N'Nguyễn Nhất Trí','20/06/1991','0171543232',N'Xã Long Điền A, Huyện Chợ Mới, An Giang','D',8500000)
insert into TAIXE values('032812213731',N'Phạm Thành Công','08/03/1990','0178543224',N'Phường Thanh Khê Tây, Quận Thanh Khê, Đà Nẵng','D',8500000)
insert into TAIXE values('042381224335',N'Trần Văn Mạnh','02/12/1994','0218543563',N'Xã Gia Phương, Huyện Gia Viễn, Ninh Bình','D',8500000)
--NHANVIEN--
insert into NHANVIEN values('052434248079',N'Nguyễn Hoàng Việt','14/03/1991','0798536814',N'Đường Không Tên,TT. Sơn Tịnh, Quang Ngãi',N'Nam',7000000)
insert into NHANVIEN values('072384248431',N'Nguyễn Thế Anh','13/08/1997','0277320156',N'TT. Sơn Tinh, Quang Ngãi',N'Nam',7500000)
insert into NHANVIEN values('046384248412',N'Nguyễn Thị Mơ','15/02/1995','0177332014',N'Xã Xuân Phong, Huyện Thọ Xuân, Thanh Hóa',N'Nữ',8000000)
insert into NHANVIEN values('069638428435',N'Nguyễn Hoàng Việt','24/09/1992','0189332032',N'Xã Định An, Huyện Gò Quao, Kiên Giang',N'Nam',8000000)
insert into NHANVIEN values('054138428406',N'Trần Thế Vĩnh','02/11/1990','0129332731',N'Phường Hải Thành, Quận Dương Kinh, Hải Phòng',N'Nam',8000000)
--THUNGAN--
insert into THUNGAN values('035794688079',N'Nguyễn Thị Thúy','15/09/1995','0853368146',N'TT. Sơn Tịnh, Quang Ngãi',N'Nữ',7500000)
insert into THUNGAN values('054212886238',N'Nguyễn Thị Hồng Nhung','13/02/1996','0823414671',N'26b D.Nguyễn Văn Linh, Cần Thơ',N'Nữ',7500000)
insert into THUNGAN values('045212886853',N'Lê Thị Mỹ Anh','10/06/1997','0127414675',N'Xã Kim Sơn, Huyện Trà Cú, Trà Vinh',N'Nữ',7500000)
insert into THUNGAN values('079216786825',N'Phạm Thị Duyên','24/11/1996','0577454231',N'Phường Hoà Hải, Quận Ngũ Hành Sơn, Đà Nẵng',N'Nữ',7500000)
insert into THUNGAN values('056216234682',N'Trần Thị Hồng','01/10/1996','0127452139',N'	Xã Tả Củ Tỷ, Huyện Bắc Hà, Lào Cai',N'Nữ',7500000)
--BENXE--
insert into BENXE values('BX0001',N'Bến xe miền Đông','Tp.HCM','0133478145')
insert into BENXE values('BX0002',N'Bến xe miền Tây','Tp.HCM','0437192112')
insert into BENXE values('BX0003',N'Bến xe An Cừ',N'Huế','0437123971')
insert into BENXE values('BX0004',N'Bến xe Đồng Hới',N'Quảng Bình','0412135916')
insert into BENXE values('BX0005',N'Bến xe Phương Trang',N'Lê Trung Đình, Quảng Ngãi','1800669943')
insert into BENXE values('BX0006',N'Bến xe Thành Đô',N'Sông Băng, Tp Cao Bằng','1800669943')
--TUYENXE--
insert into TUYENXE values('TX0001','BX0001','BX0003','4:00','6:00')
insert into TUYENXE values('TX0002','BX0002','BX0004','5:00','7:00')
insert into TUYENXE values('TX0003','BX0003','BX0001','4:00','6:00')
insert into TUYENXE values('TX0004','BX0004','BX0002','15:00','5:00')
insert into TUYENXE values('TX0005','BX0005','BX0006','6:00','10:00')
--XEKHACH--
insert into XEKHACH values('36B-00718','032483248031','052434248079',N'Xe giường nằm',N'Đang hoạt động',40)
insert into XEKHACH values('72B-04313','085912307324','072384248431',N'Xe giường nằm',N'Đang hoạt động',40)
insert into XEKHACH values('12B-08453','068122307376','046384248412',N'Xe ghế ngồi',N'Đang hoạt động',40)
insert into XEKHACH values('42B-40761','032812213731','069638428435',N'Xe giường nằm',N'Đang hoạt động',45)
insert into XEKHACH values('51B-71765','042381224335','054138428406',N'Xe giường nằm',N'Đang hoạt động',40)
--LICHTRINH--
insert into LICHTRINH values('LT0001','TX0001','36B-00718','12/10/2023',800.000)
insert into LICHTRINH values('LT0002','TX0002','72B-04313','12/10/2023',1500.000)
insert into LICHTRINH values('LT0003','TX0003','12B-08453','12/10/2023',900.000)
insert into LICHTRINH values('LT0004','TX0004','42B-40761','12/10/2023',700.000)
insert into LICHTRINH values('LT0005','TX0005','51B-71765','12/10/2023',1500.000)
--GHE--
insert into GHE values('000001','LT0001',1)
insert into GHE values('000002','LT0001',1)
insert into GHE values('000003','LT0001',1)
insert into GHE values('000004','LT0001',1)
insert into GHE values('000005','LT0001',1)
insert into GHE values('000006','LT0001',0)
insert into GHE values('000007','LT0001',0)
insert into GHE values('000008','LT0001',0)
insert into GHE values('000009','LT0001',0)
insert into GHE values('000010','LT0001',0)
insert into GHE values('000011','LT0001',0)
insert into GHE values('000012','LT0001',0)
insert into GHE values('000013','LT0001',0)
insert into GHE values('000014','LT0001',0)
insert into GHE values('000015','LT0001',0)
insert into GHE values('000016','LT0001',0)
insert into GHE values('000017','LT0001',0)
insert into GHE values('000018','LT0001',0)
insert into GHE values('000019','LT0001',0)
insert into GHE values('000020','LT0001',0)
insert into GHE values('000021','LT0001',0)
insert into GHE values('000022','LT0001',0)
insert into GHE values('000023','LT0001',0)
insert into GHE values('000024','LT0001',0)
insert into GHE values('000025','LT0001',0)
insert into GHE values('000026','LT0001',0)
insert into GHE values('000027','LT0001',0)
insert into GHE values('000028','LT0001',0)
insert into GHE values('000029','LT0001',0)
insert into GHE values('000030','LT0001',0)
insert into GHE values('000031','LT0001',0)
insert into GHE values('000032','LT0001',0)
insert into GHE values('000033','LT0001',0)
insert into GHE values('000034','LT0001',0)
insert into GHE values('000035','LT0001',0)
insert into GHE values('000036','LT0001',0)
insert into GHE values('000037','LT0001',0)
insert into GHE values('000038','LT0001',0)
insert into GHE values('000039','LT0001',0)
insert into GHE values('000040','LT0001',0)
insert into GHE values('000041','LT0002',0)
insert into GHE values('000042','LT0002',0)
insert into GHE values('000043','LT0002',0)
insert into GHE values('000044','LT0002',0)
insert into GHE values('000045','LT0002',0)
insert into GHE values('000046','LT0002',0)
insert into GHE values('000047','LT0002',0)
insert into GHE values('000048','LT0002',0)
insert into GHE values('000049','LT0002',0)
insert into GHE values('000050','LT0002',0)
insert into GHE values('000051','LT0002',0)
insert into GHE values('000052','LT0002',0)
insert into GHE values('000053','LT0002',0)
insert into GHE values('000054','LT0002',0)
insert into GHE values('000055','LT0002',0)
insert into GHE values('000056','LT0002',0)
insert into GHE values('000057','LT0002',0)
insert into GHE values('000058','LT0002',0)
insert into GHE values('000059','LT0002',0)
insert into GHE values('000060','LT0002',0)
insert into GHE values('000061','LT0002',0)
insert into GHE values('000062','LT0002',0)
insert into GHE values('000063','LT0002',0)
insert into GHE values('000064','LT0002',0)
insert into GHE values('000065','LT0002',0)
insert into GHE values('000066','LT0002',0)
insert into GHE values('000067','LT0002',0)
insert into GHE values('000068','LT0002',0)
insert into GHE values('000069','LT0002',0)
insert into GHE values('000070','LT0002',0)
insert into GHE values('000071','LT0002',0)
insert into GHE values('000072','LT0002',0)
insert into GHE values('000073','LT0002',0)
insert into GHE values('000074','LT0002',0)
insert into GHE values('000075','LT0002',0)
insert into GHE values('000076','LT0002',0)
insert into GHE values('000077','LT0002',0)
insert into GHE values('000078','LT0002',0)
insert into GHE values('000079','LT0002',0)
insert into GHE values('000080','LT0002',0)
--BIENLAI--
insert into BIENLAI values('BL0001','000001','HK0001','11/12/2023','KHONG','035794688079')
insert into BIENLAI values('BL0002','000002','HK0002','10/12/2023','KHONG','035794688079')
insert into BIENLAI values('BL0003','000003','HK0003','11/12/2023','TREEM','035794688079')
insert into BIENLAI values('BL0004','000004','HK0004','10/12/2023','KHONG','035794688079')
insert into BIENLAI values('BL0005','000005','HK0005','11/12/2023','KHONG','035794688079')
