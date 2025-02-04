USE [QLCH]
GO
/****** Object:  Table [dbo].[Chitiet_HDBan]    Script Date: 12/2/2023 11:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitiet_HDBan](
	[MaHDBan] [nvarchar](50) NOT NULL,
	[Mahang] [nvarchar](50) NULL,
	[Soluong] [nvarchar](50) NULL,
	[Giamgia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Chitiet_HDNhap]    Script Date: 12/2/2023 11:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitiet_HDNhap](
	[MaHDNhap] [nvarchar](50) NOT NULL,
	[Mahang] [nvarchar](50) NULL,
	[Soluong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dangnhap]    Script Date: 12/2/2023 11:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dangnhap](
	[Tendangnhap] [nvarchar](20) NULL,
	[Matkhau] [nvarchar](20) NULL,
	[Sodienthoai] [nvarchar](15) NULL,
	[Gmail] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Danhmuc]    Script Date: 12/2/2023 11:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Danhmuc](
	[Madanhmuc] [nvarchar](50) NOT NULL,
	[Tendanhmuc] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Madanhmuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hoadonban]    Script Date: 12/2/2023 11:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoadonban](
	[MaHDBan] [nvarchar](50) NOT NULL,
	[Ngayban] [datetime] NULL,
	[MaNV] [nvarchar](50) NULL,
	[MaKH] [nvarchar](50) NULL,
	[Tongtien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hoadonnhap]    Script Date: 12/2/2023 11:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoadonnhap](
	[MaHDNhap] [nvarchar](50) NOT NULL,
	[Ngaynhap] [datetime] NULL,
	[MaNCC] [nvarchar](50) NULL,
	[MaNV] [nvarchar](50) NULL,
	[Tongtien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khachhang]    Script Date: 12/2/2023 11:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khachhang](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[Diachi] [nvarchar](100) NULL,
 CONSTRAINT [PK__Khachhan__2725CF1E88A03415] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mathang]    Script Date: 12/2/2023 11:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mathang](
	[Mahang] [nvarchar](50) NOT NULL,
	[Tenhang] [nvarchar](50) NULL,
	[Gianhap] [float] NULL,
	[Giaban] [float] NULL,
	[Anh] [image] NULL,
	[Ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK__Mathang__03BBFE21F6EAE573] PRIMARY KEY CLUSTERED 
(
	[Mahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhacungcap]    Script Date: 12/2/2023 11:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhacungcap](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[Diachi] [nvarchar](100) NULL,
	[SDT] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 12/2/2023 11:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
 CONSTRAINT [PK__Nhanvien__2725D70A72BC4F9C] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Dangnhap] ([Tendangnhap], [Matkhau], [Sodienthoai], [Gmail]) VALUES (N'admin', N'12345', N'0964843945', N'hotrongtung@gmail.com')
INSERT [dbo].[Dangnhap] ([Tendangnhap], [Matkhau], [Sodienthoai], [Gmail]) VALUES (N'admin', N'admin', N'0964843945', N'hotrongtung@gmail.com')
INSERT [dbo].[Dangnhap] ([Tendangnhap], [Matkhau], [Sodienthoai], [Gmail]) VALUES (N'a', N'a', N'a', N'a')
INSERT [dbo].[Dangnhap] ([Tendangnhap], [Matkhau], [Sodienthoai], [Gmail]) VALUES (N'a', N'b', N'c', N'd')
INSERT [dbo].[Dangnhap] ([Tendangnhap], [Matkhau], [Sodienthoai], [Gmail]) VALUES (N'a', N'a', N'a', N'a')
INSERT [dbo].[Danhmuc] ([Madanhmuc], [Tendanhmuc]) VALUES (N'AN01', N'Áo Nam')
INSERT [dbo].[Danhmuc] ([Madanhmuc], [Tendanhmuc]) VALUES (N'AN02', N'Áo Nữ')
INSERT [dbo].[Danhmuc] ([Madanhmuc], [Tendanhmuc]) VALUES (N'QN01', N'Quần Nam')
INSERT [dbo].[Danhmuc] ([Madanhmuc], [Tendanhmuc]) VALUES (N'QN02', N'Quần Nữ')
INSERT [dbo].[Khachhang] ([MaKH], [TenKH], [SDT], [Diachi]) VALUES (N'1', N'Hồ Trọng Tùng', N'0964843945', N'Nghệ An')
INSERT [dbo].[Khachhang] ([MaKH], [TenKH], [SDT], [Diachi]) VALUES (N'2', N'Nguyễn Thị Ngọc Thùy', N'0987323232', N'Hải Dương')
INSERT [dbo].[Khachhang] ([MaKH], [TenKH], [SDT], [Diachi]) VALUES (N'3', N'Nguyễn Phương Văn', N'0987326666', N'Hưng Yên')
INSERT [dbo].[Khachhang] ([MaKH], [TenKH], [SDT], [Diachi]) VALUES (N'4', N'Hồ Trọng Khánh', N'0377740420', N'Nghệ An')
INSERT [dbo].[Nhanvien] ([MaNV], [TenNV], [SDT], [Diachi]) VALUES (N'1', N'Hồ Trọng Tùng', N'0964843945', N'Quỳnh Lưu')
INSERT [dbo].[Nhanvien] ([MaNV], [TenNV], [SDT], [Diachi]) VALUES (N'2', N'Nguyễn Thị Ngọc Thùy', N'0964848888', N'Hải Dương')
INSERT [dbo].[Nhanvien] ([MaNV], [TenNV], [SDT], [Diachi]) VALUES (N'3', N'Nguyễn Phương Văn', N'0964848686', N'Hưng Yên')
INSERT [dbo].[Nhanvien] ([MaNV], [TenNV], [SDT], [Diachi]) VALUES (N'4', N'Trần Minh Quân', N'0967868686', N'Hải Dương')
INSERT [dbo].[Nhanvien] ([MaNV], [TenNV], [SDT], [Diachi]) VALUES (N'5', N'Lê Anh Dũng', N'0989666777', N'Quảng Ninh')
ALTER TABLE [dbo].[Chitiet_HDBan]  WITH CHECK ADD  CONSTRAINT [FK_Chitiet_HDBan_Mathang] FOREIGN KEY([Mahang])
REFERENCES [dbo].[Mathang] ([Mahang])
GO
ALTER TABLE [dbo].[Chitiet_HDBan] CHECK CONSTRAINT [FK_Chitiet_HDBan_Mathang]
GO
ALTER TABLE [dbo].[Chitiet_HDNhap]  WITH CHECK ADD  CONSTRAINT [FK_Chitiet_HDNhap_Hoadonnhap] FOREIGN KEY([MaHDNhap])
REFERENCES [dbo].[Hoadonnhap] ([MaHDNhap])
GO
ALTER TABLE [dbo].[Chitiet_HDNhap] CHECK CONSTRAINT [FK_Chitiet_HDNhap_Hoadonnhap]
GO
ALTER TABLE [dbo].[Chitiet_HDNhap]  WITH CHECK ADD  CONSTRAINT [FK_Chitiet_HDNhap_Mathang] FOREIGN KEY([Mahang])
REFERENCES [dbo].[Mathang] ([Mahang])
GO
ALTER TABLE [dbo].[Chitiet_HDNhap] CHECK CONSTRAINT [FK_Chitiet_HDNhap_Mathang]
GO
ALTER TABLE [dbo].[Hoadonban]  WITH CHECK ADD  CONSTRAINT [FK_Hoadonban_Khachhang] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Khachhang] ([MaKH])
GO
ALTER TABLE [dbo].[Hoadonban] CHECK CONSTRAINT [FK_Hoadonban_Khachhang]
GO
ALTER TABLE [dbo].[Hoadonban]  WITH CHECK ADD  CONSTRAINT [FK_Hoadonban_Nhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Nhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[Hoadonban] CHECK CONSTRAINT [FK_Hoadonban_Nhanvien]
GO
ALTER TABLE [dbo].[Hoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_Hoadonnhap_Nhacungcap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[Nhacungcap] ([MaNCC])
GO
ALTER TABLE [dbo].[Hoadonnhap] CHECK CONSTRAINT [FK_Hoadonnhap_Nhacungcap]
GO
ALTER TABLE [dbo].[Hoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_Hoadonnhap_Nhanvien] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[Nhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[Hoadonnhap] CHECK CONSTRAINT [FK_Hoadonnhap_Nhanvien]
GO
ALTER TABLE [dbo].[Mathang]  WITH CHECK ADD  CONSTRAINT [FK_Mathang_Danhmuc] FOREIGN KEY([Tenhang])
REFERENCES [dbo].[Danhmuc] ([Madanhmuc])
GO
ALTER TABLE [dbo].[Mathang] CHECK CONSTRAINT [FK_Mathang_Danhmuc]
GO
