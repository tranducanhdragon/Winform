USE [master]
GO
/****** Object:  Database [Net_Coffe]    Script Date: 6/4/2020 4:14:33 PM ******/
CREATE DATABASE [Net_Coffe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Net_Coffe', FILENAME = N'D:\SQLData\Net_Coffe.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Net_Coffe_log', FILENAME = N'D:\SQLLog\Net_Coffe_log.ldf' , SIZE = 2304KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Net_Coffe] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Net_Coffe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Net_Coffe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Net_Coffe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Net_Coffe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Net_Coffe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Net_Coffe] SET ARITHABORT OFF 
GO
ALTER DATABASE [Net_Coffe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Net_Coffe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Net_Coffe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Net_Coffe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Net_Coffe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Net_Coffe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Net_Coffe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Net_Coffe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Net_Coffe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Net_Coffe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Net_Coffe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Net_Coffe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Net_Coffe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Net_Coffe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Net_Coffe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Net_Coffe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Net_Coffe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Net_Coffe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Net_Coffe] SET  MULTI_USER 
GO
ALTER DATABASE [Net_Coffe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Net_Coffe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Net_Coffe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Net_Coffe] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Net_Coffe] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Net_Coffe]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 6/4/2020 4:14:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MaDV] [nchar](100) NOT NULL,
	[TenDV] [nchar](200) NULL,
	[LoaiDV] [nchar](200) NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 6/4/2020 4:14:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [nchar](100) NULL,
	[NgayLapHoaDon] [datetime] NULL CONSTRAINT [DF_HOADON_NgayLapHoaDon]  DEFAULT (getdate()),
	[TongTien] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MAYTINH]    Script Date: 6/4/2020 4:14:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAYTINH](
	[MaMay] [nvarchar](100) NOT NULL,
	[TinhTrang] [nvarchar](100) NULL,
	[TenDangNhap] [nvarchar](200) NULL,
	[SoGioOnline] [nchar](100) NULL,
 CONSTRAINT [PK_MAYTINH] PRIMARY KEY CLUSTERED 
(
	[MaMay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 6/4/2020 4:14:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nchar](100) NOT NULL,
	[TenNV] [nchar](100) NULL,
	[QueQuan] [nchar](100) NULL,
	[NgaySinh] [date] NULL,
	[NgayVaoLam] [date] NULL CONSTRAINT [DF_NHANVIEN_NgayVaoLam]  DEFAULT (getdate()),
	[HeSoLuong] [int] NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[ChucVu] [nvarchar](100) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SUDUNGDICHVU]    Script Date: 6/4/2020 4:14:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUDUNGDICHVU](
	[TenDangNhap] [nvarchar](200) NULL,
	[MaNV] [nchar](100) NULL,
	[MaDV] [nchar](100) NULL,
	[MaHD] [nchar](100) NULL,
	[SoLuong] [int] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_SUDUNGDICHVU] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 6/4/2020 4:14:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TenDangNhap] [nvarchar](200) NOT NULL,
	[MatKhau] [nchar](200) NULL,
	[NgayTao] [date] NULL CONSTRAINT [DF_TAIKHOAN_NgayTao]  DEFAULT (getdate()),
	[SoTien] [int] NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[SUDUNGDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_SUDUNGDICHVU_DICHVU] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DICHVU] ([MaDV])
GO
ALTER TABLE [dbo].[SUDUNGDICHVU] CHECK CONSTRAINT [FK_SUDUNGDICHVU_DICHVU]
GO
ALTER TABLE [dbo].[SUDUNGDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_SUDUNGDICHVU_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[SUDUNGDICHVU] CHECK CONSTRAINT [FK_SUDUNGDICHVU_NHANVIEN]
GO
ALTER TABLE [dbo].[SUDUNGDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_SUDUNGDICHVU_TAIKHOAN] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TAIKHOAN] ([TenDangNhap])
GO
ALTER TABLE [dbo].[SUDUNGDICHVU] CHECK CONSTRAINT [FK_SUDUNGDICHVU_TAIKHOAN]
GO
/****** Object:  StoredProcedure [dbo].[CheckEmptyMay]    Script Date: 6/4/2020 4:14:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CheckEmptyMay]( @maEmpty nvarchar(100) out)
as
begin
    select @MaEmpty =( select top(1) MaMay from MAYTINH where TinhTrang = 'Offline')
end
GO
/****** Object:  StoredProcedure [dbo].[SetUserInMay]    Script Date: 6/4/2020 4:14:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SetUserInMay](
    @maMay nvarchar(100),
	@tenUser nvarchar(200),
	@tinhTrang nvarchar(100),
	@sogio nchar(100)
)
as
begin
    update MAYTINH set TenDangNhap = @tenUser, TinhTrang = @tinhTrang, SoGioOnline = @sogio where MaMay = @maMay
end
GO
/****** Object:  StoredProcedure [dbo].[SuaThongTinNhanVien]    Script Date: 6/4/2020 4:14:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaThongTinNhanVien](
    @ma nchar(100),
	@ten nchar(100),
	@quequan nchar(100),
	@hesoluong int,
	@hinhanh nvarchar(MAX),
	@chucvu nvarchar(100)
)
as
begin
    update NhanVien set TenNV = @ten, QueQuan = @quequan, HeSoLuong = @hesoluong, HinhAnh = @hinhanh, ChucVu = @chucvu
	where MaNV = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[SuDungDichVu_Insert]    Script Date: 6/4/2020 4:14:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuDungDichVu_Insert](
    @TenDangNhap nvarchar(200),
	@MaNV nchar(100),
	@MaDV nchar(100),
	@MaHD nchar(100),
	@SoLuong int
)
as
begin
    insert into SUDUNGDICHVU
	values(@TenDangNhap, @MaNV, @MaDV, @MaHD, @SoLuong)
end
GO
USE [master]
GO
ALTER DATABASE [Net_Coffe] SET  READ_WRITE 
GO
