Create database Qlks
go

use Qlks
go

Create table phong
(
	MaPhong int not null,
	TinhTrang Nvarchar(50) not null,
	TenKh Nvarchar(100) null,
	NamSinh int null,
	SoCm int null,
	SoNguoiDp int null,
	NgayDp Date null,
	NgayTp Date null,
	SoDT nvarchar(20) null
	primary key(MaPhong)
)

insert  into phong (MaPhong, TinhTrang) values (101,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (102,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (103,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (104,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (105,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (106,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (107,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (108,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (109,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (110,N'Trống')

insert  into phong (MaPhong, TinhTrang) values (201,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (202,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (203,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (204,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (205,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (206,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (207,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (208,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (209,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (210,N'Trống')

insert  into phong (MaPhong, TinhTrang) values (301,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (302,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (303,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (304,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (305,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (306,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (307,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (308,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (309,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (310,N'Trống')


insert  into phong (MaPhong, TinhTrang) values (401,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (402,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (403,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (404,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (405,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (406,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (407,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (408,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (409,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (410,N'Trống')

insert  into phong (MaPhong, TinhTrang) values (501,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (502,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (503,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (504,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (505,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (506,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (507,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (508,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (509,N'Trống')
insert  into phong (MaPhong, TinhTrang) values (510,N'Trống')

 --------------------------------------------------------------------------------------------------------------------------
go

create table NhanVien
(
	MaNv int not null IDENTITY( 1, 1 ),
	HoTen Nvarchar(100) null,
	Phai Nvarchar(10) null,
	DiaChi Nvarchar(100) null,
	NgaySinh Nvarchar(100) null,
	SoDt int null,
	TaiKhoan Nvarchar(50) not null,
	MatKhau Nvarchar(50) null,
	Primary key(Manv)
)

INSERT NhanVien ( HoTen, Phai, DiaChi, NgaySinh, SoDt, TaiKhoan, MatKhau) VALUES ( N'Lương Đình Khánh Vinh', N'Nam', N'Đồng Tháp', N'20/08/1999', 01229650824, N'admin', N'admin')
INSERT NhanVien ( HoTen, Phai, DiaChi, NgaySinh, SoDt, TaiKhoan, MatKhau) VALUES ( N'Nguyễn Trần Thiên Phú', N'Nam', N'Đồng Tháp', N'30/11/1999',01229650824, N'user1', N'123')
INSERT NhanVien ( HoTen, Phai, DiaChi, NgaySinh, SoDt, TaiKhoan, MatKhau) VALUES ( N'Trần Quốc Hưng', N'Nam', N'DakLak', N'1/1/1999', 0123456789, N'user2', N'123')
INSERT NhanVien ( HoTen, Phai, DiaChi, NgaySinh, SoDt, TaiKhoan, MatKhau) VALUES ( N'Tô Thanh Tuấn', N'Nam', N'Sóc Trăng', N'2/1/1999', 0123456789, N'user3', N'123')
INSERT NhanVien ( HoTen, Phai, DiaChi, NgaySinh, SoDt, TaiKhoan, MatKhau) VALUES ( N'Nguyễn Huỳnh Quý Trọng', N'Nam', N'Đồng Nai', N'3/1/1999', 0123456789, N'user4',N'123')
INSERT NhanVien ( HoTen, Phai, DiaChi, NgaySinh, SoDt, TaiKhoan, MatKhau) VALUES ( N'Dương Quốc Việt', N'Nam', N'Tiền Giang', N'4/1/1999', 0123456789, N'user5',N'123')

go
 --------------------------------------------------------------------------------------------------------------------------
create table ChiPhiPhu
(
	MaPhong int not null primary key,
	TienDc int null,
	DichVu Nvarchar(100) null,
	Gia int null,
	FOREIGN KEY (MaPhong) references Phong(MaPhong)
)


INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(101,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(102,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(103,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(104,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(105,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(106,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(107,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(108,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(109,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(110,0,N'',0)

INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(201,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(202,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(203,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(204,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(205,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(206,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(207,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(208,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(209,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(210,0,N'',0)

INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(301,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(302,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(303,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(304,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(305,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(306,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(307,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(308,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(309,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(310,0,N'',0)

INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(401,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(402,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(403,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(404,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(405,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(406,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(407,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(408,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(409,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(410,0,N'',0)

INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(501,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(502,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(503,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(504,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(505,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(506,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(507,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(508,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(509,0,N'',0)
INSERT into ChiPhiPhu(MaPhong, TienDc, DichVu, Gia) Values(510,0,N'',0)

 --------------------------------------------------------------------------------------------------------------------------
create table TongTien
(
	MaPhong int not null primary key,
	Tien int null,
	Foreign key (MaPhong) references Phong(MaPhong)
)

INSERT Into TongTien(MaPhong, Tien) Values(101,N'')
INSERT Into TongTien(MaPhong, Tien) Values(102,N'')
INSERT Into TongTien(MaPhong, Tien) Values(103,N'')
INSERT Into TongTien(MaPhong, Tien) Values(104,N'')
INSERT Into TongTien(MaPhong, Tien) Values(105,N'')
INSERT Into TongTien(MaPhong, Tien) Values(106,N'')
INSERT Into TongTien(MaPhong, Tien) Values(107,N'')
INSERT Into TongTien(MaPhong, Tien) Values(108,N'')
INSERT Into TongTien(MaPhong, Tien) Values(109,N'')
INSERT Into TongTien(MaPhong, Tien) Values(110,N'')

INSERT Into TongTien(MaPhong, Tien) Values(201,N'')
INSERT Into TongTien(MaPhong, Tien) Values(202,N'')
INSERT Into TongTien(MaPhong, Tien) Values(203,N'')
INSERT Into TongTien(MaPhong, Tien) Values(204,N'')
INSERT Into TongTien(MaPhong, Tien) Values(205,N'')
INSERT Into TongTien(MaPhong, Tien) Values(206,N'')
INSERT Into TongTien(MaPhong, Tien) Values(207,N'')
INSERT Into TongTien(MaPhong, Tien) Values(208,N'')
INSERT Into TongTien(MaPhong, Tien) Values(209,N'')
INSERT Into TongTien(MaPhong, Tien) Values(210,N'')

INSERT Into TongTien(MaPhong, Tien) Values(301,N'')
INSERT Into TongTien(MaPhong, Tien) Values(302,N'')
INSERT Into TongTien(MaPhong, Tien) Values(303,N'')
INSERT Into TongTien(MaPhong, Tien) Values(304,N'')
INSERT Into TongTien(MaPhong, Tien) Values(305,N'')
INSERT Into TongTien(MaPhong, Tien) Values(306,N'')
INSERT Into TongTien(MaPhong, Tien) Values(307,N'')
INSERT Into TongTien(MaPhong, Tien) Values(308,N'')
INSERT Into TongTien(MaPhong, Tien) Values(309,N'')
INSERT Into TongTien(MaPhong, Tien) Values(310,N'')


INSERT Into TongTien(MaPhong, Tien) Values(401,N'')
INSERT Into TongTien(MaPhong, Tien) Values(402,N'')
INSERT Into TongTien(MaPhong, Tien) Values(403,N'')
INSERT Into TongTien(MaPhong, Tien) Values(404,N'')
INSERT Into TongTien(MaPhong, Tien) Values(405,N'')
INSERT Into TongTien(MaPhong, Tien) Values(406,N'')
INSERT Into TongTien(MaPhong, Tien) Values(407,N'')
INSERT Into TongTien(MaPhong, Tien) Values(408,N'')
INSERT Into TongTien(MaPhong, Tien) Values(409,N'')
INSERT Into TongTien(MaPhong, Tien) Values(410,N'')

INSERT Into TongTien(MaPhong, Tien) Values(501,N'')
INSERT Into TongTien(MaPhong, Tien) Values(502,N'')
INSERT Into TongTien(MaPhong, Tien) Values(503,N'')
INSERT Into TongTien(MaPhong, Tien) Values(504,N'')
INSERT Into TongTien(MaPhong, Tien) Values(505,N'')
INSERT Into TongTien(MaPhong, Tien) Values(506,N'')
INSERT Into TongTien(MaPhong, Tien) Values(507,N'')
INSERT Into TongTien(MaPhong, Tien) Values(508,N'')
INSERT Into TongTien(MaPhong, Tien) Values(509,N'')
INSERT Into TongTien(MaPhong, Tien) Values(510,N'')

--------------------------------------------------------------------------------------------------------------------
Create Table luuthongtinphong
(
	MaPhong int not null,
	MaKh int not null primary key IDENTITY( 1, 1 ),
	TenKh Nvarchar(100) null,
	NamSinh int null,
	SoCm int null,
	NgayDp Nvarchar(100) null,
	NgayTp Nvarchar(100) null,
	TienPhong int null,
	ChiPhiPhu int null,
	TongTien int null,
	NvLap nvarchar (100) not null,
	Foreign key (MaPhong) references Phong(MaPhong),

)

---------------------------------------------------------------------------------------------------------------------
Create Table GiaPhong
(
	Maphong int primary key not null,
	GiaPhong int not null,
	LoaiPhong Nvarchar(10) not null
	Foreign key (MaPhong) references Phong(MaPhong)
)
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (101,500000,N'VIP')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (102,500000,N'VIP')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (103,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (104,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (105,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (106,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (107,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (108,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (109,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (110,100000,N'Loại 2')

Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (201,500000,N'VIP')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (202,500000,N'VIP')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (203,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (204,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (205,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (206,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (207,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (208,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (209,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (210,100000,N'Loại 2')

Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (301,500000,N'VIP')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (302,500000,N'VIP')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (303,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (304,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (305,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (306,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (307,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (308,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (309,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (310,100000,N'Loại 2')

Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (401,500000,N'VIP')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (402,500000,N'VIP')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (403,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (404,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (405,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (406,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (407,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (408,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (409,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (410,100000,N'Loại 2')

Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (501,500000,N'VIP')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (502,500000,N'VIP')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (503,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (504,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (505,300000,N'Loại 1')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (506,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (507,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (508,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (509,100000,N'Loại 2')
Insert Into GiaPhong(Maphong, GiaPhong, LoaiPhong) Values (510,100000,N'Loại 2')

---------------------------------------------------------------------------------------------------------------------
Create Table SuaPhong
(
	Maphong int primary key not null,
	TrangThai nvarchar(10) not null,
	Foreign key (MaPhong) references Phong(MaPhong)
)

Insert Into SuaPhong(Maphong,TrangThai) Values(101,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(102,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(103,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(104,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(105,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(106,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(107,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(108,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(109,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(110,N'Hiện')

Insert Into SuaPhong(Maphong,TrangThai) Values(201,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(202,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(203,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(204,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(205,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(206,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(207,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(208,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(209,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(210,N'Hiện')

Insert Into SuaPhong(Maphong,TrangThai) Values(301,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(302,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(303,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(304,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(305,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(306,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(307,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(308,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(309,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(310,N'Hiện')

Insert Into SuaPhong(Maphong,TrangThai) Values(401,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(402,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(403,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(404,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(405,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(406,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(407,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(408,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(409,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(410,N'Hiện')

Insert Into SuaPhong(Maphong,TrangThai) Values(501,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(502,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(503,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(504,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(505,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(506,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(507,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(508,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(509,N'Hiện')
Insert Into SuaPhong(Maphong,TrangThai) Values(510,N'Hiện')
---------------------------------------------------------------------------------------------------------------------------------
Create Table DichVu
(
	MaDv int not null primary key IDENTITY( 1, 1 ),
	TenDv nvarchar(50) not null,
	Gia int not null,
)
insert into DichVu(TenDv, Gia) values(N'CoCaCoLa', 7000)
insert into DichVu(TenDv, Gia) values(N'C2 Nhỏ', 5000)
insert into DichVu(TenDv, Gia) values(N'C2 Lớn', 8000)
insert into DichVu(TenDv, Gia) values(N'C2 Nhỏ', 5000)
insert into DichVu(TenDv, Gia) values(N'Nước Suối', 5000)
insert into DichVu(TenDv, Gia) values(N'Bánh Mì', 10000)
insert into DichVu(TenDv, Gia) values(N'Cơm Hộp', 15000)
insert into DichVu(TenDv, Gia) values(N'String', 6000)
insert into DichVu(TenDv, Gia) values(N'Numberone', 11000)
insert into DichVu(TenDv, Gia) values(N'Trái Cây Đĩa', 20000)
