USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[ChungThucTra]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChungThucTra](
	[ID] [int] NOT NULL,
	[IDPhieuMuon] [varchar](255) NOT NULL,
	[SoCaBiet] [int] NOT NULL,
	[NgayTra] [date] NULL,
	[DaTra] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DauSach]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DauSach](
	[MaSach] [varchar](255) NOT NULL,
	[TenSach] [nvarchar](255) NOT NULL,
	[NamXuatBan] [int] NOT NULL,
	[MaTacGia] [varchar](255) NULL,
	[MaTheLoai] [varchar](255) NULL,
	[MaNXB] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DocGia](
	[IDDocGia] [varchar](255) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[TenDocGia] [nvarchar](255) NOT NULL,
	[SDT] [varchar](255) NOT NULL,
	[SoThe] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[IDNhanVien] [varchar](255) NOT NULL,
	[TenNhanVien] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NXB](
	[MaNXB] [varchar](255) NOT NULL,
	[TenNXB] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[IDPhieuMuon] [varchar](255) NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[IDNhanVien] [varchar](255) NOT NULL,
	[SoThe] [varchar](255) NOT NULL,
	[NgayHenTra] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sach](
	[SoCaBiet] [int] NOT NULL,
	[MaSach] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[SoCaBiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TacGia](
	[TenTacGia] [nvarchar](255) NOT NULL,
	[MaTacGia] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [varchar](255) NOT NULL,
	[TenTheLoai] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheThuVien]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TheThuVien](
	[SoThe] [varchar](255) NOT NULL,
	[NgayTaoThe] [date] NOT NULL,
	[NgayHetHan] [date] NOT NULL,
	[IDNhanVien] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SoThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[username] [varchar](255) NOT NULL,
	[password] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChungThucTra] ([ID], [IDPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (1, N'PM01', 1, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IDPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (2, N'PM01', 4, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IDPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (3, N'PM01', 13, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IDPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (4, N'PM02', 2, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IDPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (5, N'PM02', 5, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IDPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (6, N'PM03', 3, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IDPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (7, N'PM04', 6, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IDPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (8, N'PM05', 18, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IDPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (9, N'PM05', 20, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IDPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (10, N'PM05', 24, NULL, 0)
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS01', N'Sự kết thúc của thời đại giả kim', 2010, N'TG01', N'TL12', N'NXB06')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS02', N'Nhà giả kim', 2012, N'TG04', N'TL07', N'NXB03')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS03', N'Đắc nhân tâm', 2011, N'TG02', N'TL10', N'NXB07')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS04', N'Tội ác và trừng phạt', 2006, N'TG06', N'TL10', N'NXB06')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS05', N'Bắt trẻ đồng xanh', 2000, N'TG03', N'TL04', N'NXB04')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS06', N'7 thói quen để thành đạt', 2007, N'TG07', N'TL02', N'NXB01')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS07', N'Thép đã tôi thế đấy', 1995, N'TG05', N'TL05', N'NXB05')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS08', N'Đọc vị bất kì ai', 2004, N'TG04', N'TL04', N'NXB04')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS09', N'Cuộc đời của Pi', 1999, N'TG06', N'TL11', N'NXB09')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS10', N'Giết Con Chim Nhại', 2003, N'TG02', N'TL10', N'NXB10')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS11', N'Ông Trăm Tuổi Trèo Qua Cửa Sổ Và Biến Mất', 2007, N'TG06', N'TL10', N'NXB07')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS12', N'Ông Già Và Biển Cả', 2005, N'TG05', N'TL10', N'NXB08')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS13', N'Điều Kỳ Diệu Của Tiệm Tạp Hóa Namiya', 2007, N'TG01', N'TL10', N'NXB07')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS14', N'Hai Vạn Dặm Dưới Đáy Biển', 2006, N'TG05', N'TL10', N'NXB04')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS15', N'Chiến Binh Cầu Vồng', 1998, N'TG07', N'TL10', N'NXB10')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS16', N'Khi Lỗi Thuộc Về Những Vì Sao', 1996, N'TG06', N'TL10', N'NXB04')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS17', N'Suối Nguồn', 1999, N'TG04', N'TL12', N'NXB01')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS18', N'Số Đỏ', 2014, N'TG01', N'TL11', N'NXB02')
INSERT [dbo].[DocGia] ([IDDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (N'DG01', N'Hà Nội', N'Nguyễn Nam Long', N'0375860699', N'17150204')
INSERT [dbo].[DocGia] ([IDDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (N'DG02', N'Hải Phòng', N'Nguyễn Tư Tỉnh', N'0885123456', N'17150205')
INSERT [dbo].[DocGia] ([IDDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (N'DG03', N'Hải Dương', N'TTT', N'0902012345', N'17150208')
INSERT [dbo].[DocGia] ([IDDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (N'DG04', N'Hà Nam', N'QQQ', N'0988686123', N'17150206')
INSERT [dbo].[DocGia] ([IDDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (N'DG05', N'Phú Thọ', N'ANA', N'0909888999', N'17150207')
INSERT [dbo].[DocGia] ([IDDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (N'DG06', N'Cao Bằng', N'Omo', N'0909888666', N'17150209')
INSERT [dbo].[NhanVien] ([IDNhanVien], [TenNhanVien]) VALUES (N'NV01', N'Nguyễn Nam Long')
INSERT [dbo].[NhanVien] ([IDNhanVien], [TenNhanVien]) VALUES (N'NV02', N'Bùi Văn Nguyện')
INSERT [dbo].[NhanVien] ([IDNhanVien], [TenNhanVien]) VALUES (N'NV03', N'Huỳnh Phước Sang')
INSERT [dbo].[NhanVien] ([IDNhanVien], [TenNhanVien]) VALUES (N'NV04', N'Nguyễn Thành Nam')
INSERT [dbo].[NhanVien] ([IDNhanVien], [TenNhanVien]) VALUES (N'NV05', N'Dương Trung Quốc')
INSERT [dbo].[NhanVien] ([IDNhanVien], [TenNhanVien]) VALUES (N'NV06', N'Trần An')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB01', N'Nhà xuất bản Chính trị Quốc gia')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB02', N'Nhà xuất bản Tư pháp')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB03', N'Nhà xuất bản Hồng Đức')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB04', N'Nhà xuất bản Quân đội')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB05', N'Nhà xuất bản Công an nhân dân')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB06', N'Nhà xuất bản Kim Đồng')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB07', N'Nhà xuất bản Thanh niên')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB08', N'Nhà xuất bản Lao động')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB09', N'Nhà xuất bản Phụ nữ')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB10', N' Nhà xuất bản Thông tấn')
INSERT [dbo].[PhieuMuon] ([IDPhieuMuon], [NgayMuon], [IDNhanVien], [SoThe], [NgayHenTra]) VALUES (N'PM01', CAST(N'2020-03-18' AS Date), N'NV01', N'17150204', CAST(N'2020-03-30' AS Date))
INSERT [dbo].[PhieuMuon] ([IDPhieuMuon], [NgayMuon], [IDNhanVien], [SoThe], [NgayHenTra]) VALUES (N'PM02', CAST(N'2020-03-26' AS Date), N'NV02', N'17150205', CAST(N'2020-04-01' AS Date))
INSERT [dbo].[PhieuMuon] ([IDPhieuMuon], [NgayMuon], [IDNhanVien], [SoThe], [NgayHenTra]) VALUES (N'PM03', CAST(N'2020-03-20' AS Date), N'NV03', N'17150206', CAST(N'2020-03-30' AS Date))
INSERT [dbo].[PhieuMuon] ([IDPhieuMuon], [NgayMuon], [IDNhanVien], [SoThe], [NgayHenTra]) VALUES (N'PM04', CAST(N'2020-03-25' AS Date), N'NV04', N'17150207', CAST(N'2020-04-15' AS Date))
INSERT [dbo].[PhieuMuon] ([IDPhieuMuon], [NgayMuon], [IDNhanVien], [SoThe], [NgayHenTra]) VALUES (N'PM05', CAST(N'2020-03-27' AS Date), N'NV05', N'17150208', CAST(N'2020-04-07' AS Date))
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (1, N'MS01')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (2, N'MS01')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (3, N'MS01')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (4, N'MS02')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (5, N'MS02')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (6, N'MS03')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (7, N'MS04')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (8, N'MS05')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (9, N'MS05')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (10, N'MS05')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (11, N'MS06')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (12, N'MS07')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (13, N'MS08')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (14, N'MS07')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (15, N'MS08')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (16, N'MS09')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (17, N'MS10')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (18, N'MS10')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (19, N'MS10')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (20, N'MS11')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (21, N'MS12')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (22, N'MS13')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (23, N'MS14')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (24, N'MS15')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (25, N'MS16')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (27, N'MS17')
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach]) VALUES (28, N'MS18')
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Nguyễn Nam Long', N'TG01')
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Nguyễn Hải Đăng', N'TG02')
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Nguyễn Bùi Chung Quân', N'TG03')
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Hoàng Công Chất', N'TG04')
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Bùi Văn Nguyện', N'TG05')
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Đặng Hương Tràm', N'TG06')
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Nguyễn Tư Tỉnh', N'TG07')
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Trần Đức Anh', N'TG08')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL01', N'Kinh dị')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL02', N'Hài hước')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL03', N'Hành động')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL04', N'Giật gân')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL05', N'Tình cảm')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL06', N'Ngôn tình')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL07', N'Trinh thám')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL08', N'Siêu nhiên')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL09', N'Khoa học')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL10', N'Triết học')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL11', N'Pháp luật')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL12', N'Văn học')
INSERT [dbo].[TheThuVien] ([SoThe], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150204', CAST(N'2020-03-24' AS Date), CAST(N'2020-08-14' AS Date), N'NV01')
INSERT [dbo].[TheThuVien] ([SoThe], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150205', CAST(N'2020-03-24' AS Date), CAST(N'2020-07-09' AS Date), N'NV02')
INSERT [dbo].[TheThuVien] ([SoThe], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150206', CAST(N'2020-03-24' AS Date), CAST(N'2020-10-29' AS Date), N'NV03')
INSERT [dbo].[TheThuVien] ([SoThe], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150207', CAST(N'2020-03-24' AS Date), CAST(N'2020-07-09' AS Date), N'NV04')
INSERT [dbo].[TheThuVien] ([SoThe], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150208', CAST(N'2020-03-24' AS Date), CAST(N'2020-08-01' AS Date), N'NV05')
INSERT [dbo].[TheThuVien] ([SoThe], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150209', CAST(N'2020-06-11' AS Date), CAST(N'2020-06-30' AS Date), N'NV03')
INSERT [dbo].[User] ([username], [password]) VALUES (N'123', N'123')
INSERT [dbo].[User] ([username], [password]) VALUES (N'12345', N'12345')
ALTER TABLE [dbo].[ChungThucTra]  WITH CHECK ADD  CONSTRAINT [FK_IDPhieuMuon] FOREIGN KEY([IDPhieuMuon])
REFERENCES [dbo].[PhieuMuon] ([IDPhieuMuon])
GO
ALTER TABLE [dbo].[ChungThucTra] CHECK CONSTRAINT [FK_IDPhieuMuon]
GO
ALTER TABLE [dbo].[ChungThucTra]  WITH CHECK ADD  CONSTRAINT [FK_SoCaBiet] FOREIGN KEY([SoCaBiet])
REFERENCES [dbo].[Sach] ([SoCaBiet])
GO
ALTER TABLE [dbo].[ChungThucTra] CHECK CONSTRAINT [FK_SoCaBiet]
GO
ALTER TABLE [dbo].[DauSach]  WITH CHECK ADD  CONSTRAINT [FK__DauSach__MaNXB__25869641] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NXB] ([MaNXB])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[DauSach] CHECK CONSTRAINT [FK__DauSach__MaNXB__25869641]
GO
ALTER TABLE [dbo].[DauSach]  WITH CHECK ADD  CONSTRAINT [FK__DauSach__MaTacGi__267ABA7A] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[DauSach] CHECK CONSTRAINT [FK__DauSach__MaTacGi__267ABA7A]
GO
ALTER TABLE [dbo].[DauSach]  WITH CHECK ADD  CONSTRAINT [FK__DauSach__MaTheLo__276EDEB3] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[DauSach] CHECK CONSTRAINT [FK__DauSach__MaTheLo__276EDEB3]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [FK_SoThe] FOREIGN KEY([SoThe])
REFERENCES [dbo].[TheThuVien] ([SoThe])
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [FK_SoThe]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_IdNhanVien_PhieuMuon] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanVien] ([IDNhanVien])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_IdNhanVien_PhieuMuon]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_SoThe_PhieuMuon] FOREIGN KEY([SoThe])
REFERENCES [dbo].[TheThuVien] ([SoThe])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_SoThe_PhieuMuon]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[DauSach] ([MaSach])
GO
ALTER TABLE [dbo].[TheThuVien]  WITH CHECK ADD  CONSTRAINT [FK_IDNhanVien] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanVien] ([IDNhanVien])
GO
ALTER TABLE [dbo].[TheThuVien] CHECK CONSTRAINT [FK_IDNhanVien]
GO
/****** Object:  StoredProcedure [dbo].[AddNewDocGia]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddNewDocGia](
	@SoThe varchar(30),
	@NgayTao DateTime,
	@NgayHetHan DateTime,
	@IdNhanVienTao varchar(30),
	@TenDocGia nvarchar(30),
	@DiaChi varchar(30),
	@SDT varchar(30)
)
as
BEGIN
	BEGIN TRY
	BEGIN TRANSACTION 
		IF EXISTS (SELECT * FROM TheThuVien where SoThe = @SoThe)
		ROLLBACK TRANSACTION
		Insert into TheThuVien values (@SoThe, @NgayTao, @NgayHetHan, @IdNhanVienTao)
		Insert into DocGia (DiaChi, TenDocGia, SDT , SoThe)
		values (@DiaChi, @TenDocGia, @SDT, @SoThe)
	COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK TRANSACTION
		DECLARE @ErrorMessage nvarchar(4000) = ERROR_MESSAGE();
		declare @ErrorSeverity int = ERROR_SEVERITY();
	    declare @ErrorState int = ERROR_STATE();
		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[AddNewNhanVien]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddNewNhanVien](
	@IDNhanVien varchar(30),
	@TenNhanVien nvarchar(100)
)
AS
BEGIN
	Insert into NhanVien 
	select @IDNhanVien, @TenNhanVien
	where not exists (Select * from NhanVien where IDNhanVien = @IDNhanVien)
END

GO
/****** Object:  StoredProcedure [dbo].[AddNewTacGia]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AddNewTacGia] (
	@TenTacGia nvarchar(100),
	@MaTacGia varchar(30)
)
AS
BEGIN
	Insert into TacGia
	select @TenTacGia, @MaTacGia
	where not exists (Select * from TacGia where MaTacGia = N'@MaTacGia')
END
GO
/****** Object:  StoredProcedure [dbo].[ChangeDocGia]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ChangeDocGia](
	@SoThe varchar(30),
	@NgayHetHan DateTime,
	@TenDocGia nvarchar(30),
	@DiaChi varchar(30),
	@SDT varchar(30)
)
as
BEGIN
	BEGIN TRY
	BEGIN TRANSACTION 
		IF NOT EXISTS (SELECT * FROM TheThuVien where SoThe = N'@SoThe')
		ROLLBACK TRANSACTION
		Update TheThuVien set NgayHetHan = @NgayHetHan where SoThe = @SoThe
		Update DocGia set TenDocGia = @TenDocGia, DiaChi = @DiaChi, SDT = @SDT
		Where SoThe = @SoThe
	COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK TRANSACTION
		DECLARE @ErrorMessage nvarchar(4000) = ERROR_MESSAGE();
		declare @ErrorSeverity int = ERROR_SEVERITY();
	    declare @ErrorState int = ERROR_STATE();
		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteDocGia]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteDocGia](
	@SoThe varchar(30)
)
as
BEGIN
	BEGIN TRY
	BEGIN TRANSACTION 
		IF NOT EXISTS (SELECT * FROM TheThuVien where SoThe = @SoThe)
		ROLLBACK TRANSACTION
		DELETE TheThuVien Where SoThe = @SoThe
		DELETE DocGia where SoThe = @SoThe
	COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
		ROLLBACK TRANSACTION
		DECLARE @ErrorMessage nvarchar(4000) = ERROR_MESSAGE();
		declare @ErrorSeverity int = ERROR_SEVERITY();
	    declare @ErrorState int = ERROR_STATE();
		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteTacGia]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteTacGia] (
    @MaTacGia varchar(30)
)
AS
BEGIN
BEGIN TRY
	BEGIN TRANSACTION;
		Delete from TacGia where MaTacGia = @MaTacGia
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	IF @@TRANCOUNT > 0
	ROLLBACK TRANSACTION; 
	DECLARE @ErrorMessage nvarchar(4000) = ERROR_MESSAGE();
	declare @ErrorSeverity int = ERROR_SEVERITY();
	declare @ErrorState int = ERROR_STATE();
	RAISERROR(@ErrorMessage,@ErrorSeverity,@ErrorState);
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateTacGia]    Script Date: 9/19/2020 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateTacGia] (
	@MaTacGia varchar(30),
	@TenTacGia nvarchar(100)
)
AS
BEGIN
Update TacGia set TenTacGia = N'@TenTacGia' where MaTacGia = N'@MaTacGia'
END
GO
