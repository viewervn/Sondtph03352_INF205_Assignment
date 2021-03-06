USE [QuanLyBanHang]
GO
/****** Object:  Table [dbo].[Loai_San_Pham]    Script Date: 10/12/2015 22:05:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai_San_Pham](
	[Ma_LSP] [nvarchar](10) NOT NULL,
	[Ten_LSP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Loai_San_Pham] PRIMARY KEY CLUSTERED 
(
	[Ma_LSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Loai_San_Pham] ([Ma_LSP], [Ten_LSP]) VALUES (N'LSP01', N'Đồ Gia Dụng')
INSERT [dbo].[Loai_San_Pham] ([Ma_LSP], [Ten_LSP]) VALUES (N'LSP02', N'Đồ Điện Tử')
INSERT [dbo].[Loai_San_Pham] ([Ma_LSP], [Ten_LSP]) VALUES (N'LSP03', N'Đồ Y Dược')
INSERT [dbo].[Loai_San_Pham] ([Ma_LSP], [Ten_LSP]) VALUES (N'LSP04', N'Thực Phẩm')
INSERT [dbo].[Loai_San_Pham] ([Ma_LSP], [Ten_LSP]) VALUES (N'LSP05', N'Văn Hóa Phẩm')
/****** Object:  Table [dbo].[Khach_Hang]    Script Date: 10/12/2015 22:05:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach_Hang](
	[Ma_KH] [nvarchar](10) NOT NULL,
	[Ten_KH] [nvarchar](50) NOT NULL,
	[SDT] [text] NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Khach_Hang] PRIMARY KEY CLUSTERED 
(
	[Ma_KH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Khach_Hang] ([Ma_KH], [Ten_KH], [SDT], [DiaChi]) VALUES (N'KH01', N'Nguyễn Thị Thùy', N'0168448989', N'Thành Phố Bắc Giang')
INSERT [dbo].[Khach_Hang] ([Ma_KH], [Ten_KH], [SDT], [DiaChi]) VALUES (N'KH02', N'Nguyễn Hồng Anh', N'0949668789', N'Thành Phố Hà Nội')
INSERT [dbo].[Khach_Hang] ([Ma_KH], [Ten_KH], [SDT], [DiaChi]) VALUES (N'KH03', N'Phạm Ngọc Phượng', N'0987424699', N'Thành Phố Hòa Bình')
INSERT [dbo].[Khach_Hang] ([Ma_KH], [Ten_KH], [SDT], [DiaChi]) VALUES (N'KH04', N'Lê Gia Thắng', N'0163776677', N'Thành Phố Hưng Yên')
INSERT [dbo].[Khach_Hang] ([Ma_KH], [Ten_KH], [SDT], [DiaChi]) VALUES (N'KH05', N'Ngô Gia Bảo', N'0123455456', N'Thành Phố Hải Phòng')
INSERT [dbo].[Khach_Hang] ([Ma_KH], [Ten_KH], [SDT], [DiaChi]) VALUES (N'KH06', N'Lò Vi Sóng', N'09555342433', N'Thành Phố Nam Định')
/****** Object:  Table [dbo].[San_Pham]    Script Date: 10/12/2015 22:05:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[San_Pham](
	[Ma_SP] [nvarchar](10) NOT NULL,
	[Ten_SP] [nvarchar](50) NOT NULL,
	[SoLuong] [text] NOT NULL,
	[Mota] [nvarchar](200) NOT NULL,
	[Ma_LSP] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_San_Pham] PRIMARY KEY CLUSTERED 
(
	[Ma_SP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[San_Pham] ([Ma_SP], [Ten_SP], [SoLuong], [Mota], [Ma_LSP]) VALUES (N'SP01', N'Nồi Cơm Điện', N'101', N'System.Windows.Forms.TextBox, Text: System.Windows.Forms.TextBox, Text: Nồi...', N'LSP01')
INSERT [dbo].[San_Pham] ([Ma_SP], [Ten_SP], [SoLuong], [Mota], [Ma_LSP]) VALUES (N'SP02', N'LapTop', N'4', N'Sản phẩm mới của hãng Dell Ram 8Gb Vi sử Lý HHD 1000', N'LSP02')
INSERT [dbo].[San_Pham] ([Ma_SP], [Ten_SP], [SoLuong], [Mota], [Ma_LSP]) VALUES (N'SP03', N'Vigra', N'20', N'Một người khỏe, hai người vui', N'LSP03')
INSERT [dbo].[San_Pham] ([Ma_SP], [Ten_SP], [SoLuong], [Mota], [Ma_LSP]) VALUES (N'Sp04', N'Ramen', N'50', N'Xuất xứ từ Nhật hương vị thơm ngon ', N'LSP04')
INSERT [dbo].[San_Pham] ([Ma_SP], [Ten_SP], [SoLuong], [Mota], [Ma_LSP]) VALUES (N'SP05', N'Truyện: Cho tôi xin một vé về tuổi thơ', N'9', N'Truyện của nhà văn Nguyễn Nhật Ánh Với ngòi bút trào phúng sẽ đưa người đọc trở lại cách nhìn nhận thế giới của đứa bé tám tuổi', N'LSP05')
INSERT [dbo].[San_Pham] ([Ma_SP], [Ten_SP], [SoLuong], [Mota], [Ma_LSP]) VALUES (N'SP06', N'Bếp Ga Grantz', N'6', N'Bếp này là bếp ga :v', N'LSP01')
/****** Object:  Table [dbo].[Hoa_Don]    Script Date: 10/12/2015 22:05:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoa_Don](
	[Ma_HD] [nvarchar](10) NOT NULL,
	[Ma_KH] [nvarchar](10) NOT NULL,
	[NgayLap] [date] NULL,
 CONSTRAINT [PK_Hoa_Don] PRIMARY KEY CLUSTERED 
(
	[Ma_HD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Hoa_Don] ([Ma_HD], [Ma_KH], [NgayLap]) VALUES (N'HD01', N'KH01', CAST(0x833A0B00 AS Date))
INSERT [dbo].[Hoa_Don] ([Ma_HD], [Ma_KH], [NgayLap]) VALUES (N'HD02', N'KH02', CAST(0x843A0B00 AS Date))
INSERT [dbo].[Hoa_Don] ([Ma_HD], [Ma_KH], [NgayLap]) VALUES (N'HD03', N'KH03', CAST(0x853A0B00 AS Date))
INSERT [dbo].[Hoa_Don] ([Ma_HD], [Ma_KH], [NgayLap]) VALUES (N'HD04', N'KH04', CAST(0x863A0B00 AS Date))
INSERT [dbo].[Hoa_Don] ([Ma_HD], [Ma_KH], [NgayLap]) VALUES (N'HD05', N'KH05', CAST(0x873A0B00 AS Date))
/****** Object:  Table [dbo].[Chi_Tiet_Hoa_Don]    Script Date: 10/12/2015 22:05:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chi_Tiet_Hoa_Don](
	[Ma_HD] [nvarchar](10) NOT NULL,
	[Ma_SP] [nvarchar](10) NOT NULL,
	[DonGia] [money] NOT NULL,
	[SoLuong] [text] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Chi_Tiet_Hoa_Don] ([Ma_HD], [Ma_SP], [DonGia], [SoLuong]) VALUES (N'HD01', N'SP01', 8000000.0000, N'1')
INSERT [dbo].[Chi_Tiet_Hoa_Don] ([Ma_HD], [Ma_SP], [DonGia], [SoLuong]) VALUES (N'HD02', N'SP02', 17500000.0000, N'1')
INSERT [dbo].[Chi_Tiet_Hoa_Don] ([Ma_HD], [Ma_SP], [DonGia], [SoLuong]) VALUES (N'HD03', N'SP03', 230000.0000, N'2')
INSERT [dbo].[Chi_Tiet_Hoa_Don] ([Ma_HD], [Ma_SP], [DonGia], [SoLuong]) VALUES (N'HD04', N'SP04', 11000.0000, N'15')
INSERT [dbo].[Chi_Tiet_Hoa_Don] ([Ma_HD], [Ma_SP], [DonGia], [SoLuong]) VALUES (N'HD05', N'SP05', 37000.0000, N'2')
/****** Object:  ForeignKey [FK_Chi_Tiet_Hoa_Don_Hoa_Don]    Script Date: 10/12/2015 22:05:11 ******/
ALTER TABLE [dbo].[Chi_Tiet_Hoa_Don]  WITH CHECK ADD  CONSTRAINT [FK_Chi_Tiet_Hoa_Don_Hoa_Don] FOREIGN KEY([Ma_HD])
REFERENCES [dbo].[Hoa_Don] ([Ma_HD])
GO
ALTER TABLE [dbo].[Chi_Tiet_Hoa_Don] CHECK CONSTRAINT [FK_Chi_Tiet_Hoa_Don_Hoa_Don]
GO
/****** Object:  ForeignKey [FK_Chi_Tiet_Hoa_Don_San_Pham]    Script Date: 10/12/2015 22:05:11 ******/
ALTER TABLE [dbo].[Chi_Tiet_Hoa_Don]  WITH CHECK ADD  CONSTRAINT [FK_Chi_Tiet_Hoa_Don_San_Pham] FOREIGN KEY([Ma_SP])
REFERENCES [dbo].[San_Pham] ([Ma_SP])
GO
ALTER TABLE [dbo].[Chi_Tiet_Hoa_Don] CHECK CONSTRAINT [FK_Chi_Tiet_Hoa_Don_San_Pham]
GO
/****** Object:  ForeignKey [FK_Hoa_Don_Khach_Hang]    Script Date: 10/12/2015 22:05:11 ******/
ALTER TABLE [dbo].[Hoa_Don]  WITH CHECK ADD  CONSTRAINT [FK_Hoa_Don_Khach_Hang] FOREIGN KEY([Ma_KH])
REFERENCES [dbo].[Khach_Hang] ([Ma_KH])
GO
ALTER TABLE [dbo].[Hoa_Don] CHECK CONSTRAINT [FK_Hoa_Don_Khach_Hang]
GO
/****** Object:  ForeignKey [FK_San_Pham_Loai_San_Pham]    Script Date: 10/12/2015 22:05:11 ******/
ALTER TABLE [dbo].[San_Pham]  WITH CHECK ADD  CONSTRAINT [FK_San_Pham_Loai_San_Pham] FOREIGN KEY([Ma_LSP])
REFERENCES [dbo].[Loai_San_Pham] ([Ma_LSP])
GO
ALTER TABLE [dbo].[San_Pham] CHECK CONSTRAINT [FK_San_Pham_Loai_San_Pham]
GO
