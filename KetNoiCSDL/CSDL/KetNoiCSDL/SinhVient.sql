USE [master]
GO
/****** Object:  Database [SinhVien]    Script Date: 5/25/2020 10:19:56 AM ******/
CREATE DATABASE [SinhVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SinhVien', FILENAME = N'D:\SQLData\SinhVien.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SinhVien_log', FILENAME = N'D:\SQLLog\SinhVien_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SinhVien] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SinhVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SinhVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SinhVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SinhVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SinhVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SinhVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [SinhVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SinhVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SinhVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SinhVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SinhVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SinhVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SinhVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SinhVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SinhVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SinhVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SinhVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SinhVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SinhVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SinhVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SinhVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SinhVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SinhVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SinhVien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SinhVien] SET  MULTI_USER 
GO
ALTER DATABASE [SinhVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SinhVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SinhVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SinhVien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SinhVien] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SinhVien]
GO
/****** Object:  UserDefinedFunction [dbo].[SLSinhVien]    Script Date: 5/25/2020 10:19:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[SLSinhVien](@malop nvarchar(10))
returns int
as
begin
    declare @sl int
	    select @sl = count(*) from sinhvien where malop = @malop
	return (@sl)
end
GO
/****** Object:  UserDefinedFunction [dbo].[ThongKeSL]    Script Date: 5/25/2020 10:19:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[ThongKeSL](@tenlop nvarchar(50))
returns @BangThongKe table(
    tenlop nvarchar(50),
	malop nvarchar(10),
	soluongSV int
)
as 
begin
 if @tenlop = ''
     insert into @BangThongKe
	 select Tenlop, Sinhvien.malop, count(masv) as [slsv] from dmlop, sinhvien
	     where dmlop.malop = sinhvien.malop
		 group by sinhvien.malop, tenlop
 else
     insert into @BangThongKe
	 select DMlop.tenlop, sinhvien.malop , count(masv) from dmlop, sinhvien
	     where dmlop.malop = sinhvien.malop
		 and TenLop = @tenlop
		 group by SinhVien.malop, tenlop
 return
end
GO
/****** Object:  Table [dbo].[DMLop]    Script Date: 5/25/2020 10:19:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DMLop](
	[Malop] [nvarchar](10) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[MaLopTruong] [nvarchar](10) NULL,
	[Khoa] [nvarchar](10) NULL,
 CONSTRAINT [PK_DMMaLop] PRIMARY KEY CLUSTERED 
(
	[Malop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhapSinhVien]    Script Date: 5/25/2020 10:19:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapSinhVien](
	[HoTen] [nvarchar](30) NULL,
	[NgaySinh] [datetime] NULL,
	[MaSV] [nvarchar](10) NULL,
	[MaLop] [nvarchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PTB2]    Script Date: 5/25/2020 10:19:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PTB2](
	[a] [float] NULL,
	[b] [float] NULL,
	[c] [float] NULL,
	[x1] [float] NULL,
	[x2] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 5/25/2020 10:19:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](30) NULL,
	[NgaySinh] [date] NULL,
	[MaLop] [nvarchar](10) NULL,
	[PhuCap] [float] NULL,
	[DiemTB] [float] NULL,
	[DiemChu] [nvarchar](20) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  UserDefinedFunction [dbo].[Xemlop]    Script Date: 5/25/2020 10:19:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Xemlop](@malop nvarchar(10))
returns table
as return (select masv, hoten from SinhVien, dmlop
           where SinhVien.malop = dmlop.malop
		   and sinhvien.malop = @malop)
GO
/****** Object:  View [dbo].[dstuoi]    Script Date: 5/25/2020 10:19:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create view [dbo].[dstuoi] as
  select masv, hoten, tuoi, ten_lop
  from SinhVien, (select tenlop as ten_lop, malop from dmlop)lop, (select (2019 - year(ngaysinh)) as tuoi from SinhVien)age
  where SinhVien.MaLop = lop.malop
GO
/****** Object:  View [dbo].[svsai]    Script Date: 5/25/2020 10:19:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create view [dbo].[svsai] as
  select * from sinhvien
  except
  select * from sinhvien where malop in (select malop from dmlop)
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_DMLop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[DMLop] ([Malop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_DMLop]
GO
/****** Object:  StoredProcedure [dbo].[Cong]    Script Date: 5/25/2020 10:19:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Cong](@a int, @b int, @result int out)
as
begin
    set @result = @a + @b
end

GO
/****** Object:  StoredProcedure [dbo].[Cong2so]    Script Date: 5/25/2020 10:19:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Cong2so](@a int, @b int, @result int out)
as
begin
    select @result = @a+@b
end

declare @tong int
exec Cong2so 1, 2, @tong
print @tong
GO
/****** Object:  StoredProcedure [dbo].[Diem]    Script Date: 5/25/2020 10:19:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Diem]
@Diem float, @DiemChu nvarchar(20)
as
if @Diem = 0
	begin
	    set @DiemChu = N'Không'
	end
	else if @Diem = 1
	begin
	    set @DiemChu = N'Một' 
	end
	else if @Diem = 2
	begin
	    set @DiemChu = N'Hai'
	end
	if @Diem = 3
	begin
	    set @DiemChu = N'Ba'
	end
	if @Diem = 4
	begin
	    set @DiemChu = N'Bốn'
	end
	if @Diem = 5
	begin
	    set @DiemChu = N'Năm'
	end
	if @Diem = 6
	begin
	    set @DiemChu = N'Sáu'
	end
	if @Diem = 7
	begin
	    set @DiemChu = N'Bảy'
	end
	if @Diem = 8
	begin
	    set @DiemChu = N'Tám'
	end
	if @Diem = 9
	begin
	    set @DiemChu = N'Chín'
	end
	if @Diem = 10
	begin
	    set @DiemChu = N'Mười'
	end
GO
USE [master]
GO
ALTER DATABASE [SinhVien] SET  READ_WRITE 
GO
