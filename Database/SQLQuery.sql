create table LOAIMATHANG(
MaLoaiMH bigint NOT NULL IDENTITY(1,1),
TenLoaiMH nvarchar(50),
NamSX nvarchar(10),
primary key(MaLoaiMH),
);

create table MATHANG(
MaMH bigint NOT NULL IDENTITY(1,1),
MaLoaiMH bigint,
TenMH nvarchar(100),
DonGia real,
Mota nvarchar(100),
KinhDoanh bit,
primary key(MaMH),
foreign key(MaLoaiMH) references LOAIMATHANG(MaLoaiMH),
);

create table NHASANXUAT(
MaNhaSX bigint NOT NULL IDENTITY(1,1),
TenNhaSX nvarchar(50),
primary key(MaNhaSX) 
);

create table HOADONBANHANG(
MaHD bigint NOT NULL IDENTITY(1,1),
TenKH nvarchar(50),
NgayLap DateTime,
TongTien real,
primary key(MaHD)
);

create table CHITIETHOADONBANHANG(
MaChiTietHD bigint NOT NULL IDENTITY(1,1),
MaHD bigint,
MaMH bigint,
SoLuong bigInt,
DonGia float,
ThanhTien float,
primary key(MaChiTietHD),
foreign key (MaMH) REFERENCES MATHANG(MaMH),
foreign key (MaHD) REFERENCES HOADONBANHANG(MaHD),
);

create table PHIEUHEN(
MaPH bigint NOT NULL IDENTITY(1,1),
NgayLap Date,
TenKH nvarchar(50),
SoDT nvarchar(15),
TinhTrangMay nvarchar(MAX),
primary key(MaPH)
);

create table QUYDINH(
MaQD bigint NOT NULL IDENTITY(1,1),
TenQD nvarchar(25),
Mota nvarchar(100),
primary key(MaQD),
);

create table HOADONSUACHUA(
MaHDSC bigint NOT NULL IDENTITY(1,1),
MaPH bigint,
TenKH nvarchar(50),
NgayTra Date,
TongTien real,
primary key(MaHDSC),
foreign key (MaPH) REFERENCES PHIEUHEN(MaPH),
);

create table BANGSUACHUA(
MaBSC bigint NOT NULL IDENTITY(1,1),
TenMHSC nvarchar(50),
DonGia float,
primary key(MaBSC),
);

create table CHITIETHOADONSUACHUA(
MaCTSC bigint NOT NULL IDENTITY(1,1),
MaHDSC bigint,
MaBSC bigint,
SoLuong bigint,
DonGia float,
ThanhTien float,
primary key(MaCTSC),
foreign key (MaHDSC) REFERENCES HOADONSUACHUA(MaHDSC),
foreign key (MaBSC) REFERENCES BANGSUACHUA(MaBSC),
);

create table DICHVU(
MaDV bigint NOT NULL IDENTITY(1,1), 
TenDV nvarchar(50), 
DonGia float,
);

create table HOADONDICHVU (
MaHDDV bigint NOT NULL IDENTITY(1,1), 
TenKH nvarchar(50), 
TongTien real,
primary key(MAHDDV)
);

create table CHITTIETHOADONDICHVU(
MaCTDV bigint NOT NULL IDENTITY(1,1),
MaHDDV bigint,
MaDV bigint, 
SoLuong int,
DonGia float,
primary key(MaCTDV),
foreign key (MaHDDV) REFERENCES HOADONDICHVU(MaHDDV),
);

create table BAOCAOTHANG(
MaBC bigint NOT NULL IDENTITY(1,1),
NgayLapBC Date,
NguoiLap nvarchar(50),
TongDoanhThu real,
primary key(MaBC),
);


