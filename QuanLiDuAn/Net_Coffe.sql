USE [QuanLyQuanNet]
GO
/****** Object:  UserDefinedFunction [dbo].[ThongKeDoanhThu]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[ThongKeDoanhThu](@thoigianbatdau datetime, @thoigianketthuc datetime)
returns @bangchitiet table(
	MaDV int,TenDV nvarchar(500),SoLuong int,DonGia int,ThanhTien int
)as begin
	insert into @bangchitiet
		select DichVu.MaDV,TenDV,SUM(SuDungDichVu.SoLuong) as [Số lượng],DonGia,SUM(SuDungDichVu.SoLuong)*DonGia
		from DichVu join SuDungDichVu on DichVu.MaDV = SuDungDichVu.MaDV
		where ThoiGian between @thoigianbatdau and @thoigianketthuc												
		group by DichVu.MaDV,TenDV,DonGia
	return
end

GO
/****** Object:  UserDefinedFunction [dbo].[ThongKeThoiGianSuDung]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[ThongKeThoiGianSuDung](@thoigianbatdau datetime, @thoigianketthuc datetime)
returns @bangchitiet table(
	MaMay int,TenMay nvarchar(500),ThoiGian int
)as begin
	insert into @bangchitiet
		SELECT        dbo.MayTinh.MaMayTinh, dbo.MayTinh.LoaiMayTinh, SUM(DATEDIFF(HOUR, dbo.SuDungMayTinh.ThoiGianBatDau, dbo.SuDungMayTinh.ThoiGianKetThuc)) AS [Thời gian sử dụng]
		FROM dbo.SuDungMayTinh INNER JOIN
                         dbo.MayTinh ON dbo.SuDungMayTinh.MaMayTinh = dbo.MayTinh.MaMayTinh
		where ThoiGianBatDau > @thoigianbatdau
			  and  ThoiGianKetThuc < @thoigianketthuc 
		GROUP BY dbo.MayTinh.MaMayTinh, dbo.MayTinh.LoaiMayTinh
	return
end

GO
/****** Object:  UserDefinedFunction [dbo].[XemHoaDon]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[XemHoaDon](@tendangnhap nchar(50),@mamay int)
returns @bangchitiet table(
	TenDV nvarchar(500),SoLuong int,DonGia int,ThanhTien int
)as begin
	
	insert into @bangchitiet
		select TenDV,sum(sddv.SoLuong) as [Số lượng],DichVu.DonGia,DonGia * sum(sddv.SoLuong)
		from SuDungMayTinh sdmt,KhachHang kh,SuDungDichVu sddv, DichVu
		where sdmt.MaKH = kh.MaKH and kh.MaKH = sddv.MaKH and sddv.MaDV = DichVu.MaDV
				and sdmt.MaKH = (select MaKH from KhachHang where TenDangNhap = @tendangnhap)
				and ThoiGian between ThoiGianBatDau and GETDATE()
				and MaMayTinh = @mamay and ThanhToan = 0
		group by TenDV,DichVu.DonGia
	return
end

GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [int] IDENTITY(1,1) NOT NULL,
	[TenDV] [nvarchar](500) NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](500) NULL,
	[NgaySinh] [date] NULL,
	[SDT] [nchar](50) NULL,
	[TenDangNhap] [nchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MayTinh]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MayTinh](
	[MaMayTinh] [int] IDENTITY(1,1) NOT NULL,
	[LoaiMayTinh] [nvarchar](100) NULL,
	[TaiKhoanSD] [nchar](50) NULL,
	[Vitri] [nvarchar](500) NULL,
 CONSTRAINT [PK_MayTinh] PRIMARY KEY CLUSTERED 
(
	[MaMayTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NapTien]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NapTien](
	[MaNV] [nchar](50) NOT NULL,
	[MaKH] [int] NOT NULL,
	[SoTien] [bigint] NULL,
	[NgayNap] [datetime] NULL CONSTRAINT [DF_NapTien_NgayNap]  DEFAULT (getdate())
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](50) NOT NULL,
	[TenNV] [nvarchar](200) NULL,
	[SDT] [nchar](50) NULL,
	[TenDangNhapNV] [nchar](50) NULL,
	[HeSoLuong] [int] NULL,
	[SoNgayLam] [int] NULL,
	[SoNgayNghi] [int] NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[ChucVu] [nvarchar](500) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuanLyMayTinh]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLyMayTinh](
	[MaNV] [nchar](50) NOT NULL,
	[MaMayTinh] [int] NOT NULL,
	[HanhDong] [nvarchar](500) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SuDungDichVu]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuDungDichVu](
	[MaKH] [int] NULL,
	[MaDV] [int] NULL,
	[ThoiGian] [datetime] NULL CONSTRAINT [DF_SuDungDichVu_ThoiGian]  DEFAULT (getdate()),
	[SoLuong] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SuDungMayTinh]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuDungMayTinh](
	[MaKH] [int] NOT NULL,
	[MaMayTinh] [int] NOT NULL,
	[ThoiGianBatDau] [datetime] NULL CONSTRAINT [DF_SuDungMayTinh_ThoiGianBatDau]  DEFAULT (getdate()),
	[ThoiGianKetThuc] [datetime] NULL,
	[ThanhToan] [int] NULL CONSTRAINT [DF_SuDungMayTinh_KetThuc]  DEFAULT ((0))
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [nchar](50) NOT NULL,
	[MatKhau] [nchar](50) NULL,
	[SoTien] [bigint] NULL,
	[LoaiTK] [int] NULL,
	[NgayTao] [datetime] NULL CONSTRAINT [DF_TaiKhoan_NgayTao]  DEFAULT (getdate()),
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TinhTien]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTien](
	[MaNV] [nchar](50) NOT NULL,
	[MaMayTinh] [int] NOT NULL,
	[SoTieng] [bigint] NULL,
	[NgayThanhToan] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[GiaoDienMayTinh]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[GiaoDienMayTinh]
as
	select MayTinh.MaMayTinh,TenDangNhap,DATEDIFF(HOUR,ThoiGianBatDau,GETDATE()) as [Thời gian sử dụng]
	from MayTinh left join SuDungMayTinh on MayTinh.MaMayTinh = SuDungMayTinh.MaMayTinh,KhachHang
	where KhachHang.MaKH = SuDungMayTinh.MaKH
	and ThoiGianKetThuc is null

GO
/****** Object:  View [dbo].[GiaoDienNhanVien]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[GiaoDienNhanVien]
as select MaNV,TenNV,ChucVu,HeSoLuong from NhanVien

GO
/****** Object:  View [dbo].[GiaoDienTaiKhoan]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[GiaoDienTaiKhoan]
as select TenDangNhap,MatKhau,NgayTao,SoTien from TaiKhoan
	where LoaiTK = 0

GO
SET IDENTITY_INSERT [dbo].[DichVu] ON 

INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [SoLuong]) VALUES (1, N'Internet', 10000, -7)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [SoLuong]) VALUES (2, N'Bánh mì xúc six', 15000, -4)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [SoLuong]) VALUES (3, N'Nước ngọt pepsi', 12000, 197)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [SoLuong]) VALUES (4, N'Nước ngọt coca', 12000, 197)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [SoLuong]) VALUES (5, N'Nước tăng lực redbull', 15000, 197)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [SoLuong]) VALUES (6, N'Nước tăng lực sting', 10000, 197)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [SoLuong]) VALUES (7, N'Cơm rang', 30000, -4)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [DonGia], [SoLuong]) VALUES (8, N'Thuốc lá thăng long', 15000, 197)
SET IDENTITY_INSERT [dbo].[DichVu] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [NgaySinh], [SDT], [TenDangNhap]) VALUES (1, NULL, NULL, NULL, N'baroibeo                                          ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [NgaySinh], [SDT], [TenDangNhap]) VALUES (2, NULL, NULL, NULL, N'chimsedinang                                      ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [NgaySinh], [SDT], [TenDangNhap]) VALUES (3, NULL, NULL, NULL, N'clearr                                            ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [NgaySinh], [SDT], [TenDangNhap]) VALUES (4, NULL, NULL, NULL, N'kidzz                                             ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [NgaySinh], [SDT], [TenDangNhap]) VALUES (5, NULL, NULL, NULL, N'mimosa                                            ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [NgaySinh], [SDT], [TenDangNhap]) VALUES (6, NULL, NULL, NULL, N'mixigaminh                                        ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [NgaySinh], [SDT], [TenDangNhap]) VALUES (7, NULL, NULL, NULL, N'phantantrung                                      ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [NgaySinh], [SDT], [TenDangNhap]) VALUES (8, NULL, NULL, NULL, N'phungthanhdo                                      ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [NgaySinh], [SDT], [TenDangNhap]) VALUES (9, NULL, NULL, NULL, N'truongtuantu                                      ')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [NgaySinh], [SDT], [TenDangNhap]) VALUES (10, NULL, NULL, NULL, N'tudefttry                                         ')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[MayTinh] ON 

INSERT [dbo].[MayTinh] ([MaMayTinh], [LoaiMayTinh], [TaiKhoanSD], [Vitri]) VALUES (1, N'Dell', NULL, NULL)
INSERT [dbo].[MayTinh] ([MaMayTinh], [LoaiMayTinh], [TaiKhoanSD], [Vitri]) VALUES (2, N'Dell', NULL, NULL)
INSERT [dbo].[MayTinh] ([MaMayTinh], [LoaiMayTinh], [TaiKhoanSD], [Vitri]) VALUES (3, N'Dell', NULL, NULL)
INSERT [dbo].[MayTinh] ([MaMayTinh], [LoaiMayTinh], [TaiKhoanSD], [Vitri]) VALUES (4, N'Dell', NULL, NULL)
INSERT [dbo].[MayTinh] ([MaMayTinh], [LoaiMayTinh], [TaiKhoanSD], [Vitri]) VALUES (5, N'Dell', N'                                                  ', NULL)
INSERT [dbo].[MayTinh] ([MaMayTinh], [LoaiMayTinh], [TaiKhoanSD], [Vitri]) VALUES (6, N'Dell', NULL, NULL)
INSERT [dbo].[MayTinh] ([MaMayTinh], [LoaiMayTinh], [TaiKhoanSD], [Vitri]) VALUES (7, N'Dell', NULL, NULL)
INSERT [dbo].[MayTinh] ([MaMayTinh], [LoaiMayTinh], [TaiKhoanSD], [Vitri]) VALUES (8, N'Dell', NULL, NULL)
INSERT [dbo].[MayTinh] ([MaMayTinh], [LoaiMayTinh], [TaiKhoanSD], [Vitri]) VALUES (9, N'Dell', NULL, NULL)
INSERT [dbo].[MayTinh] ([MaMayTinh], [LoaiMayTinh], [TaiKhoanSD], [Vitri]) VALUES (10, N'Dell', NULL, NULL)
INSERT [dbo].[MayTinh] ([MaMayTinh], [LoaiMayTinh], [TaiKhoanSD], [Vitri]) VALUES (11, N'Dell', NULL, NULL)
SET IDENTITY_INSERT [dbo].[MayTinh] OFF
INSERT [dbo].[NapTien] ([MaNV], [MaKH], [SoTien], [NgayNap]) VALUES (N'NV01                                              ', 1, 100000, CAST(N'2020-06-25 14:50:23.260' AS DateTime))
INSERT [dbo].[NapTien] ([MaNV], [MaKH], [SoTien], [NgayNap]) VALUES (N'NV01                                              ', 2, 110000, CAST(N'2020-06-25 14:50:23.260' AS DateTime))
INSERT [dbo].[NapTien] ([MaNV], [MaKH], [SoTien], [NgayNap]) VALUES (N'NV02                                              ', 3, 90000, CAST(N'2020-06-25 14:50:23.260' AS DateTime))
INSERT [dbo].[NapTien] ([MaNV], [MaKH], [SoTien], [NgayNap]) VALUES (N'NV02                                              ', 4, 120000, CAST(N'2020-06-25 14:50:23.260' AS DateTime))
INSERT [dbo].[NapTien] ([MaNV], [MaKH], [SoTien], [NgayNap]) VALUES (N'NV03                                              ', 5, 150000, CAST(N'2020-06-25 14:50:23.260' AS DateTime))
INSERT [dbo].[NapTien] ([MaNV], [MaKH], [SoTien], [NgayNap]) VALUES (N'NV03                                              ', 6, 60000, CAST(N'2020-06-25 14:50:23.260' AS DateTime))
INSERT [dbo].[NapTien] ([MaNV], [MaKH], [SoTien], [NgayNap]) VALUES (N'NV04                                              ', 7, 90000, CAST(N'2020-06-25 14:50:23.260' AS DateTime))
INSERT [dbo].[NapTien] ([MaNV], [MaKH], [SoTien], [NgayNap]) VALUES (N'NV04                                              ', 8, 50000, CAST(N'2020-06-25 14:50:23.263' AS DateTime))
INSERT [dbo].[NapTien] ([MaNV], [MaKH], [SoTien], [NgayNap]) VALUES (N'NV05                                              ', 9, 200000, CAST(N'2020-06-25 14:50:23.263' AS DateTime))
INSERT [dbo].[NapTien] ([MaNV], [MaKH], [SoTien], [NgayNap]) VALUES (N'NV05                                              ', 10, 70000, CAST(N'2020-06-25 14:50:23.263' AS DateTime))
INSERT [dbo].[NapTien] ([MaNV], [MaKH], [SoTien], [NgayNap]) VALUES (N'NV01                                              ', 1, 20000, CAST(N'2020-06-25 15:39:13.667' AS DateTime))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [TenDangNhapNV], [HeSoLuong], [SoNgayLam], [SoNgayNghi], [HinhAnh], [ChucVu]) VALUES (N'NV01                                              ', N'Bùi Trung Tú', NULL, N'buitrungtu                                        ', 7000000, NULL, NULL, NULL, N'Nhân Viên')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [TenDangNhapNV], [HeSoLuong], [SoNgayLam], [SoNgayNghi], [HinhAnh], [ChucVu]) VALUES (N'NV02                                              ', N'Nguyễn Thị Thu Hà', NULL, N'thuha7299                                         ', 7000000, NULL, NULL, NULL, N'Nhân Viên')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [TenDangNhapNV], [HeSoLuong], [SoNgayLam], [SoNgayNghi], [HinhAnh], [ChucVu]) VALUES (N'NV03                                              ', N'Trần Đức Anh', NULL, N'ducanhtran                                        ', 7000000, NULL, NULL, NULL, N'Nhân Viên')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [TenDangNhapNV], [HeSoLuong], [SoNgayLam], [SoNgayNghi], [HinhAnh], [ChucVu]) VALUES (N'NV04                                              ', N'Đinh Thị Hoài', NULL, N'hoaidinh                                          ', 7000000, NULL, NULL, NULL, N'Nhân Viên')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [TenDangNhapNV], [HeSoLuong], [SoNgayLam], [SoNgayNghi], [HinhAnh], [ChucVu]) VALUES (N'NV05                                              ', N'Nguyễn Thị Bích Ngọc', NULL, N'bichngoc                                          ', 7000000, NULL, NULL, NULL, N'Nhân Viên')
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 1, CAST(N'2020-06-25 15:08:05.523' AS DateTime), 10)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (2, 1, CAST(N'2020-06-25 15:08:05.523' AS DateTime), 11)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (3, 1, CAST(N'2020-06-25 15:08:05.527' AS DateTime), 9)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (4, 1, CAST(N'2020-06-25 15:08:05.527' AS DateTime), 12)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (5, 1, CAST(N'2020-06-25 15:08:05.527' AS DateTime), 15)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (6, 1, CAST(N'2020-06-25 15:08:05.527' AS DateTime), 6)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (7, 1, CAST(N'2020-06-25 15:08:05.527' AS DateTime), 9)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (8, 1, CAST(N'2020-06-25 15:08:05.527' AS DateTime), 5)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 1, CAST(N'2020-06-25 15:39:13.670' AS DateTime), 2)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 2, CAST(N'2020-06-25 15:40:56.017' AS DateTime), 1)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 1, CAST(N'2020-06-26 23:47:40.487' AS DateTime), 2)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 2, CAST(N'2020-06-26 23:47:40.503' AS DateTime), 2)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 3, CAST(N'2020-06-26 23:47:40.540' AS DateTime), 2)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 4, CAST(N'2020-06-26 23:47:40.550' AS DateTime), 2)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 5, CAST(N'2020-06-26 23:47:40.550' AS DateTime), 2)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 6, CAST(N'2020-06-26 23:47:40.550' AS DateTime), 2)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 7, CAST(N'2020-06-26 23:47:40.550' AS DateTime), 2)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 8, CAST(N'2020-06-26 23:47:40.590' AS DateTime), 2)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 1, CAST(N'2020-06-27 00:08:05.890' AS DateTime), 1)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 2, CAST(N'2020-06-27 00:08:05.893' AS DateTime), 1)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 3, CAST(N'2020-06-27 00:08:05.893' AS DateTime), 1)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 4, CAST(N'2020-06-27 00:08:05.893' AS DateTime), 1)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 7, CAST(N'2020-06-27 00:08:05.893' AS DateTime), 1)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (1, 8, CAST(N'2020-06-27 00:08:05.893' AS DateTime), 1)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (6, 1, CAST(N'2020-06-27 00:10:15.353' AS DateTime), 1)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (6, 2, CAST(N'2020-06-27 00:10:15.353' AS DateTime), 1)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (6, 5, CAST(N'2020-06-27 00:10:15.353' AS DateTime), 1)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (6, 6, CAST(N'2020-06-27 00:10:15.357' AS DateTime), 1)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (6, 7, CAST(N'2020-06-27 00:10:15.357' AS DateTime), 1)
INSERT [dbo].[SuDungDichVu] ([MaKH], [MaDV], [ThoiGian], [SoLuong]) VALUES (6, 1, CAST(N'2020-06-27 00:10:37.657' AS DateTime), 3)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (1, 1, CAST(N'2020-06-25 15:12:00.140' AS DateTime), CAST(N'2020-06-25 16:10:30.000' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (2, 2, CAST(N'2020-06-25 15:14:07.907' AS DateTime), CAST(N'2020-06-25 19:15:30.000' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (3, 3, CAST(N'2020-06-25 15:14:07.910' AS DateTime), CAST(N'2020-06-25 18:30:10.000' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (4, 4, CAST(N'2020-06-25 15:14:07.927' AS DateTime), CAST(N'2020-06-25 17:10:29.000' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (5, 5, CAST(N'2020-06-25 15:14:07.927' AS DateTime), CAST(N'2020-06-25 20:11:30.000' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (6, 6, CAST(N'2020-06-25 15:14:07.927' AS DateTime), CAST(N'2020-06-25 17:12:31.000' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (7, 7, CAST(N'2020-06-25 15:14:07.927' AS DateTime), CAST(N'2020-06-25 16:20:30.000' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (8, 8, CAST(N'2020-06-25 15:14:07.927' AS DateTime), CAST(N'2020-06-25 19:10:30.000' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (9, 9, CAST(N'2020-06-25 15:14:07.927' AS DateTime), CAST(N'2020-06-25 20:10:30.000' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (10, 10, CAST(N'2020-06-25 15:14:07.927' AS DateTime), CAST(N'2020-06-25 17:40:30.000' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (5, 1, CAST(N'2020-06-25 20:15:30.000' AS DateTime), CAST(N'2020-06-26 01:15:30.000' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (10, 5, CAST(N'2020-06-26 23:05:52.703' AS DateTime), CAST(N'2020-06-26 23:06:30.980' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (10, 5, CAST(N'2020-06-26 23:14:38.650' AS DateTime), CAST(N'2020-06-26 23:15:02.400' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (1, 5, CAST(N'2020-06-26 23:37:56.007' AS DateTime), CAST(N'2020-06-26 23:38:34.293' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (1, 5, CAST(N'2020-06-26 23:44:42.617' AS DateTime), CAST(N'2020-06-26 23:45:18.890' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (1, 5, CAST(N'2020-06-26 23:45:52.760' AS DateTime), CAST(N'2020-06-26 23:47:42.933' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (1, 5, CAST(N'2020-06-26 23:47:28.333' AS DateTime), CAST(N'2020-06-26 23:47:42.933' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (10, 5, CAST(N'2020-06-26 22:57:58.420' AS DateTime), CAST(N'2020-06-26 22:59:27.943' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (10, 5, CAST(N'2020-06-26 23:03:33.727' AS DateTime), CAST(N'2020-06-26 23:03:55.153' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (10, 5, CAST(N'2020-06-26 23:04:32.813' AS DateTime), CAST(N'2020-06-26 23:04:45.827' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (10, 5, CAST(N'2020-06-26 23:07:01.303' AS DateTime), CAST(N'2020-06-26 23:07:25.123' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (10, 5, CAST(N'2020-06-26 23:15:01.453' AS DateTime), CAST(N'2020-06-26 23:15:02.400' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (1, 5, CAST(N'2020-06-27 00:07:46.193' AS DateTime), CAST(N'2020-06-27 00:08:32.747' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (6, 5, CAST(N'2020-06-27 00:09:53.590' AS DateTime), CAST(N'2020-06-27 00:10:59.510' AS DateTime), 1)
INSERT [dbo].[SuDungMayTinh] ([MaKH], [MaMayTinh], [ThoiGianBatDau], [ThoiGianKetThuc], [ThanhToan]) VALUES (10, 5, CAST(N'2020-06-26 23:06:22.463' AS DateTime), CAST(N'2020-06-26 23:06:30.980' AS DateTime), 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'baroibeo                                          ', N'1                                                 ', 0, 0, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'bichngoc                                          ', N'1                                                 ', NULL, 1, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'buitrungtu                                        ', N'1                                                 ', NULL, 1, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'chimsedinang                                      ', N'1                                                 ', 0, 0, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'clearr                                            ', N'1                                                 ', 0, 0, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'ducanhtran                                        ', N'1                                                 ', NULL, 1, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'hoaidinh                                          ', N'1                                                 ', NULL, 1, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'kidzz                                             ', N'1                                                 ', 0, 0, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'mimosa                                            ', N'1                                                 ', 0, 0, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'mixigaminh                                        ', N'1                                                 ', 0, 0, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'phantantrung                                      ', N'1                                                 ', 0, 0, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'phungthanhdo                                      ', N'1                                                 ', 0, 0, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'thuha7299                                         ', N'1                                                 ', NULL, 1, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'truongtuantu                                      ', N'1                                                 ', 0, 0, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [SoTien], [LoaiTK], [NgayTao]) VALUES (N'tudefttry                                         ', N'1                                                 ', 0, 0, CAST(N'2020-06-26 00:43:10.140' AS DateTime))
ALTER TABLE [dbo].[TinhTien] ADD  CONSTRAINT [DF_TinhTien_NgayThanhToan]  DEFAULT (getdate()) FOR [NgayThanhToan]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_TaiKhoan] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_TaiKhoan]
GO
ALTER TABLE [dbo].[NapTien]  WITH CHECK ADD  CONSTRAINT [FK_NapTien_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[NapTien] CHECK CONSTRAINT [FK_NapTien_KhachHang]
GO
ALTER TABLE [dbo].[NapTien]  WITH CHECK ADD  CONSTRAINT [FK_NapTien_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NapTien] CHECK CONSTRAINT [FK_NapTien_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([TenDangNhapNV])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
ALTER TABLE [dbo].[QuanLyMayTinh]  WITH CHECK ADD  CONSTRAINT [FK_QuanLyMayTinh_MayTinh] FOREIGN KEY([MaMayTinh])
REFERENCES [dbo].[MayTinh] ([MaMayTinh])
GO
ALTER TABLE [dbo].[QuanLyMayTinh] CHECK CONSTRAINT [FK_QuanLyMayTinh_MayTinh]
GO
ALTER TABLE [dbo].[QuanLyMayTinh]  WITH CHECK ADD  CONSTRAINT [FK_QuanLyMayTinh_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[QuanLyMayTinh] CHECK CONSTRAINT [FK_QuanLyMayTinh_NhanVien]
GO
ALTER TABLE [dbo].[SuDungDichVu]  WITH CHECK ADD  CONSTRAINT [FK_SuDungDichVu_DichVu] FOREIGN KEY([MaKH])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[SuDungDichVu] CHECK CONSTRAINT [FK_SuDungDichVu_DichVu]
GO
ALTER TABLE [dbo].[SuDungDichVu]  WITH CHECK ADD  CONSTRAINT [FK_SuDungDichVu_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[SuDungDichVu] CHECK CONSTRAINT [FK_SuDungDichVu_KhachHang]
GO
ALTER TABLE [dbo].[SuDungMayTinh]  WITH CHECK ADD  CONSTRAINT [FK_SuDungMayTinh_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[SuDungMayTinh] CHECK CONSTRAINT [FK_SuDungMayTinh_KhachHang]
GO
ALTER TABLE [dbo].[SuDungMayTinh]  WITH CHECK ADD  CONSTRAINT [FK_SuDungMayTinh_MayTinh] FOREIGN KEY([MaMayTinh])
REFERENCES [dbo].[MayTinh] ([MaMayTinh])
GO
ALTER TABLE [dbo].[SuDungMayTinh] CHECK CONSTRAINT [FK_SuDungMayTinh_MayTinh]
GO
ALTER TABLE [dbo].[TinhTien]  WITH CHECK ADD  CONSTRAINT [FK_TinhTien_MayTinh] FOREIGN KEY([MaMayTinh])
REFERENCES [dbo].[MayTinh] ([MaMayTinh])
GO
ALTER TABLE [dbo].[TinhTien] CHECK CONSTRAINT [FK_TinhTien_MayTinh]
GO
ALTER TABLE [dbo].[TinhTien]  WITH CHECK ADD  CONSTRAINT [FK_TinhTien_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TinhTien] CHECK CONSTRAINT [FK_TinhTien_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[DangNhap]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DangNhap](@mamay int,@tendangnhap nchar(50))
as begin
	
	update MayTinh set TaiKhoanSD = @tendangnhap where MaMayTinh = @mamay
	insert into SuDungMayTinh(MaKH,MaMayTinh) values ((select MaKH from KhachHang where TenDangNhap = @tendangnhap),@mamay)
end

GO
/****** Object:  StoredProcedure [dbo].[DangXuat]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DangXuat](@mamaytinh int,@tendangnhap nchar(50))
as begin
	update MayTinh set TaiKhoanSD = '' where MaMayTinh = @mamaytinh
	update SuDungMayTinh set ThoiGianKetThuc = GETDATE() 
	where ThoiGianKetThuc is null and MaMayTinh = @mamaytinh and MaKH = (select MaKH from KhachHang where TenDangNhap = @tendangnhap)
end

GO
/****** Object:  StoredProcedure [dbo].[DatDichVu]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DatDichVu](@tentaikhoan nchar(50), @madv int ,@soluong int)
as begin

	insert into SuDungDichVu(MaKH,MaDV,SoLuong) values ((select MaKH from KhachHang where TenDangNhap = @tentaikhoan),@madv,@soluong)
	update DichVu set SoLuong = SoLuong - @soluong where MaDV = @madv
end

GO
/****** Object:  StoredProcedure [dbo].[DongHoaDon]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DongHoaDon](@tendangnhap nchar(50),@mamay int)
as begin
	update SuDungMayTinh set ThanhToan = 1 where MaKH = (select MaKH from KhachHang where TenDangNhap = @tendangnhap) and MaMayTinh = @mamay and ThanhToan = 0
end

GO
/****** Object:  StoredProcedure [dbo].[NapThemTien]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NapThemTien](@manv nchar(50),@tendangnhap nchar(50),@sotien bigint)
as begin
	
	insert into NapTien(MaNV,MaKH,SoTien) values (@manv,(select MaKH from KhachHang where TenDangNhap = @tendangnhap),@sotien)
	update TaiKhoan set SoTien = @sotien where TenDangNhap = @tendangnhap
	insert into SuDungDichVu(MaKH,MaDV,SoLuong) values ((select MaKH from KhachHang where TenDangNhap = @tendangnhap),1,@sotien/10000)
end

GO
/****** Object:  StoredProcedure [dbo].[SuaDichVu]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaDichVu] (@madv int,@tendv nvarchar(500),@soluong int,@dongia int)
as begin
	update DichVu set TenDV = @tendv,SoLuong= @soluong,DonGia = @dongia 
	where MaDV = @madv
end

GO
/****** Object:  StoredProcedure [dbo].[SuaThongTinNhanVien]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaThongTinNhanVien](@manv int,@tennv nvarchar(500),@sdt nchar(50),
			@hesoluong int, @hinhanh nvarchar(max),@chucvu nvarchar(500)
)
as begin
	update NhanVien set TenNV = @tennv,SDT = @sdt,HeSoLuong = @hesoluong,HinhAnh = @hinhanh,ChucVu = @chucvu
	where MaNV = @manv
end

GO
/****** Object:  StoredProcedure [dbo].[TaoTaiKhoan]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TaoTaiKhoan](@tendangnhap nchar(50),@matkhau nchar(50))
as begin
	insert into TaiKhoan(TenDangNhap,MatKhau,SoTien,LoaiTK) values (@tendangnhap,@matkhau,0,0)
	insert into KhachHang(TenDangNhap) values (@tendangnhap)
end

GO
/****** Object:  StoredProcedure [dbo].[ThemDichVu]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemDichVu] (@tendv nvarchar(500),@soluong int,@dongia int)
as begin
	insert into DichVu(TenDV,SoLuong,DonGia) values (@tendv,@soluong,@dongia)
end

GO
/****** Object:  StoredProcedure [dbo].[ThemMayTinh]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemMayTinh](@tenmaytinh nvarchar(100))
as begin
	insert into MayTinh(LoaiMayTinh) values (@tenmaytinh)
end

GO
/****** Object:  StoredProcedure [dbo].[XoaMayTinh]    Script Date: 9/19/2020 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaMayTinh](@mamay int)
as begin
	delete QuanLyMayTinh where MaMayTinh = @mamay
	delete TinhTien where MaMayTinh = @mamay
	if exists (select * from SuDungMayTinh where MaMayTinh = @mamay and ThoiGianKetThuc is null)
	return 0
	else
	delete SuDungMayTinh where MaMayTinh = @mamay
end

GO
