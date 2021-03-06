USE [master]
GO
/****** Object:  Database [BanhKem]    Script Date: 12/28/2021 6:15:31 PM ******/
CREATE DATABASE [BanhKem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BanhKem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BanhKem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BanhKem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BanhKem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BanhKem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BanhKem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BanhKem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BanhKem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BanhKem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BanhKem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BanhKem] SET ARITHABORT OFF 
GO
ALTER DATABASE [BanhKem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BanhKem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BanhKem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BanhKem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BanhKem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BanhKem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BanhKem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BanhKem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BanhKem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BanhKem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BanhKem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BanhKem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BanhKem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BanhKem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BanhKem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BanhKem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BanhKem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BanhKem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BanhKem] SET  MULTI_USER 
GO
ALTER DATABASE [BanhKem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BanhKem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BanhKem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BanhKem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BanhKem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BanhKem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BanhKem] SET QUERY_STORE = OFF
GO
USE [BanhKem]
GO
/****** Object:  Table [dbo].[ĐN]    Script Date: 12/28/2021 6:15:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ĐN](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
 CONSTRAINT [PK_ĐN] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/28/2021 6:15:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHĐ] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[MaSP] [nvarchar](50) NULL,
	[MaKH] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHĐ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/28/2021 6:15:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[GT] [nvarchar](50) NULL,
	[NS] [date] NULL,
	[SĐT] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/28/2021 6:15:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[GT] [nvarchar](50) NULL,
	[NS] [date] NULL,
	[SĐT] [nvarchar](50) NULL,
	[ĐiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/28/2021 6:15:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](50) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[DonVi] [nvarchar](50) NULL,
	[Gia] [float] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ĐN] ([TaiKhoan], [MatKhau]) VALUES (N'duytruong', N'sa123')
GO
INSERT [dbo].[HoaDon] ([MaHĐ], [MaNV], [MaSP], [MaKH], [SoLuong], [GhiChu], [ThanhTien]) VALUES (N'HD01', N'NV02', N'SP03', N'KH04', 3, N'......', 500000)
INSERT [dbo].[HoaDon] ([MaHĐ], [MaNV], [MaSP], [MaKH], [SoLuong], [GhiChu], [ThanhTien]) VALUES (N'HD02', N'NV01', N'SP02', N'KH02', 5, N'.......', 300000)
INSERT [dbo].[HoaDon] ([MaHĐ], [MaNV], [MaSP], [MaKH], [SoLuong], [GhiChu], [ThanhTien]) VALUES (N'HD03', N'NV04', N'SP01', N'KH01', 7, N'.......', 200000)
INSERT [dbo].[HoaDon] ([MaHĐ], [MaNV], [MaSP], [MaKH], [SoLuong], [GhiChu], [ThanhTien]) VALUES (N'HD04', N'NV03', N'SP04', N'KH03', 2, N'.......', 230000)
INSERT [dbo].[HoaDon] ([MaHĐ], [MaNV], [MaSP], [MaKH], [SoLuong], [GhiChu], [ThanhTien]) VALUES (N'HD05', N'NV02', N'SP01', N'KH05', 3, N'.....', 340000)
INSERT [dbo].[HoaDon] ([MaHĐ], [MaNV], [MaSP], [MaKH], [SoLuong], [GhiChu], [ThanhTien]) VALUES (N'HD06', N'NV02', N'SP02', N'KH02', 1, N'.......', 125000)
INSERT [dbo].[HoaDon] ([MaHĐ], [MaNV], [MaSP], [MaKH], [SoLuong], [GhiChu], [ThanhTien]) VALUES (N'HD07', N'NV02', N'SP01', N'KH02', 3, N'.......', 190000)
INSERT [dbo].[HoaDon] ([MaHĐ], [MaNV], [MaSP], [MaKH], [SoLuong], [GhiChu], [ThanhTien]) VALUES (N'HD08', N'NV03', N'SP03', N'KH02', 3, N'.....', 201000)
INSERT [dbo].[HoaDon] ([MaHĐ], [MaNV], [MaSP], [MaKH], [SoLuong], [GhiChu], [ThanhTien]) VALUES (N'HD09', N'NV04', N'SP04', N'KH04', 2, N'........', 123000)
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GT], [NS], [SĐT]) VALUES (N'KH01', N'Nguyễn Hồng Duyên', N'Nữ ', CAST(N'2000-02-05' AS Date), N'0457893158')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GT], [NS], [SĐT]) VALUES (N'KH02', N'Trịnh Anh Quân', N'Nam', CAST(N'2001-06-08' AS Date), N'0487922622')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GT], [NS], [SĐT]) VALUES (N'KH03', N'Vũ Quang Đông', N'Nam', CAST(N'2003-03-04' AS Date), N'0154616515')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GT], [NS], [SĐT]) VALUES (N'KH04', N'Nguyễn Văn Thanh', N'Nam', CAST(N'1999-09-06' AS Date), NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GT], [NS], [SĐT]) VALUES (N'KH05', N'Nguyễn Thị Hân', N'Nữ', CAST(N'2008-06-20' AS Date), N'0356748962')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GT], [NS], [SĐT]) VALUES (N'KH06', N'Lê Thị Diễm', N'Nữ', CAST(N'2001-04-06' AS Date), N'0123456789')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GT], [NS], [SĐT], [ĐiaChi]) VALUES (N'NV01', N'Đỗ Hà My', N'Nữ', CAST(N'2001-10-01' AS Date), N'0123548965', N'Ninh Bình')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GT], [NS], [SĐT], [ĐiaChi]) VALUES (N'NV02', N'Nguyễn Duy Mạnh', N'Nam', CAST(N'2001-06-04' AS Date), N'0489653158', N'Thái Nguyên')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GT], [NS], [SĐT], [ĐiaChi]) VALUES (N'NV03', N'Lương Xuân Trường', N'Nam', CAST(N'1999-03-06' AS Date), N'0489652317', N'Thái Bình')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GT], [NS], [SĐT], [ĐiaChi]) VALUES (N'NV04', N'Nguyễn Văn Toàn', N'Nam', CAST(N'2002-03-07' AS Date), N'0598765234', N'Hải Dương')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GT], [NS], [SĐT], [ĐiaChi]) VALUES (N'NV05', N'Nguyễn Thị Liên', N'Nữ', CAST(N'2002-05-10' AS Date), N'0754896258', N'Hà Nam')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GT], [NS], [SĐT], [ĐiaChi]) VALUES (N'NV06', N'Hoàng Thị Loan', N'Nữ', CAST(N'1999-06-24' AS Date), N'0254678964', N'Hải Phòng')
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [Gia]) VALUES (N'SP01', N'Tiramisu', N'50', 350000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [Gia]) VALUES (N'SP02', N'Angel', N'40', 350000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [Gia]) VALUES (N'SP03', N'Socola Sữa', N'30', 55000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [Gia]) VALUES (N'SP04', N'Socola Việt Quất', N'20', NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [Gia]) VALUES (N'SP05', N'Socola Dâu', N'10', 30000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonVi], [Gia]) VALUES (N'SP06', N'Socola Sữa Chua', N'4', 23000)
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_SanPham]
GO
USE [master]
GO
ALTER DATABASE [BanhKem] SET  READ_WRITE 
GO
