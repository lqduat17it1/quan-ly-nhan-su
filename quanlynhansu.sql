USE [master]
GO
/****** Object:  Database [quanlynhansu]    Script Date: 3/26/2023 9:40:57 PM ******/
CREATE DATABASE [quanlynhansu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'quanlynhansu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\quanlynhansu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'quanlynhansu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\quanlynhansu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [quanlynhansu] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quanlynhansu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quanlynhansu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [quanlynhansu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [quanlynhansu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [quanlynhansu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [quanlynhansu] SET ARITHABORT OFF 
GO
ALTER DATABASE [quanlynhansu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [quanlynhansu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [quanlynhansu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [quanlynhansu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [quanlynhansu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [quanlynhansu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [quanlynhansu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [quanlynhansu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [quanlynhansu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [quanlynhansu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [quanlynhansu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [quanlynhansu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [quanlynhansu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [quanlynhansu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [quanlynhansu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [quanlynhansu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [quanlynhansu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [quanlynhansu] SET RECOVERY FULL 
GO
ALTER DATABASE [quanlynhansu] SET  MULTI_USER 
GO
ALTER DATABASE [quanlynhansu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [quanlynhansu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [quanlynhansu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [quanlynhansu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [quanlynhansu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [quanlynhansu] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'quanlynhansu', N'ON'
GO
ALTER DATABASE [quanlynhansu] SET QUERY_STORE = ON
GO
ALTER DATABASE [quanlynhansu] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [quanlynhansu]
GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 3/26/2023 9:40:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chucvu](
	[machucvu] [varchar](10) NOT NULL,
	[tenchucvu] [nvarchar](50) NULL,
 CONSTRAINT [PK_chucvu] PRIMARY KEY CLUSTERED 
(
	[machucvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hopdonglaodong]    Script Date: 3/26/2023 9:40:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hopdonglaodong](
	[mahopdong] [varchar](10) NOT NULL,
	[loaihopdong] [nvarchar](50) NULL,
	[tungay] [datetime] NULL,
	[denngay] [datetime] NULL,
	[manhanvien] [varchar](10) NULL,
 CONSTRAINT [PK_hopdonglaodong] PRIMARY KEY CLUSTERED 
(
	[mahopdong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[luong]    Script Date: 3/26/2023 9:40:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[luong](
	[bacluong] [int] NOT NULL,
	[luongcoban] [int] NULL,
	[hesoluong] [int] NULL,
	[hesophucap] [int] NULL,
 CONSTRAINT [PK_luong] PRIMARY KEY CLUSTERED 
(
	[bacluong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 3/26/2023 9:40:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manhanvien] [varchar](10) NOT NULL,
	[tennhanvien] [nvarchar](50) NULL,
	[ngaysinh] [datetime] NULL,
	[gioitinh] [bit] NULL,
	[quequan] [nvarchar](100) NULL,
	[sodienthoai] [varchar](15) NULL,
	[dantoc] [nvarchar](50) NULL,
	[maphongban] [varchar](10) NULL,
	[machucvu] [varchar](10) NULL,
	[matrinhdohocvan] [varchar](10) NULL,
	[bacluong] [int] NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phongban]    Script Date: 3/26/2023 9:40:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phongban](
	[maphongban] [varchar](10) NOT NULL,
	[tenphongban] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[sodienthoai] [varchar](15) NULL,
 CONSTRAINT [PK_phongban] PRIMARY KEY CLUSTERED 
(
	[maphongban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 3/26/2023 9:40:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[mataikhoan] [nchar](10) NOT NULL,
	[tendangnhap] [nchar](10) NOT NULL,
	[matkhau] [nchar](10) NOT NULL,
 CONSTRAINT [PK_taikhoan] PRIMARY KEY CLUSTERED 
(
	[mataikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trinhdohocvan]    Script Date: 3/26/2023 9:40:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trinhdohocvan](
	[matrinhdohocvan] [varchar](10) NOT NULL,
	[tentrinhdohocvan] [nvarchar](50) NULL,
	[chuyennganh] [nvarchar](50) NULL,
 CONSTRAINT [PK_trinhdohocvan] PRIMARY KEY CLUSTERED 
(
	[matrinhdohocvan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[hopdonglaodong]  WITH CHECK ADD  CONSTRAINT [FK_hopdonglaodong_nhanvien] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([manhanvien])
GO
ALTER TABLE [dbo].[hopdonglaodong] CHECK CONSTRAINT [FK_hopdonglaodong_nhanvien]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_chucvu] FOREIGN KEY([machucvu])
REFERENCES [dbo].[chucvu] ([machucvu])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_chucvu]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_luong] FOREIGN KEY([bacluong])
REFERENCES [dbo].[luong] ([bacluong])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_luong]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_phongban] FOREIGN KEY([maphongban])
REFERENCES [dbo].[phongban] ([maphongban])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_phongban]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_trinhdohocvan] FOREIGN KEY([matrinhdohocvan])
REFERENCES [dbo].[trinhdohocvan] ([matrinhdohocvan])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_trinhdohocvan]
GO
USE [master]
GO
ALTER DATABASE [quanlynhansu] SET  READ_WRITE 
GO
