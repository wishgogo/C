USE [master]
GO
/****** Object:  Database [mydb]    Script Date: 2022/5/18 下午 01:46:16 ******/
CREATE DATABASE [mydb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mydb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\mydb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'mydb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\mydb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [mydb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mydb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mydb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mydb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mydb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mydb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mydb] SET ARITHABORT OFF 
GO
ALTER DATABASE [mydb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mydb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mydb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mydb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mydb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mydb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mydb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mydb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mydb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mydb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mydb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mydb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mydb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mydb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mydb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mydb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mydb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mydb] SET RECOVERY FULL 
GO
ALTER DATABASE [mydb] SET  MULTI_USER 
GO
ALTER DATABASE [mydb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mydb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mydb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mydb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [mydb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [mydb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'mydb', N'ON'
GO
ALTER DATABASE [mydb] SET QUERY_STORE = OFF
GO
USE [mydb]
GO
/****** Object:  Table [dbo].[persons]    Script Date: 2022/5/18 下午 01:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[姓名] [nvarchar](50) NULL,
	[電話] [nvarchar](50) NULL,
	[地址] [nvarchar](100) NULL,
	[email] [nvarchar](50) NULL,
	[生日] [date] NULL,
	[婚姻狀態] [bit] NULL,
	[點數] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 2022/5/18 下午 01:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pname] [nvarchar](200) NULL,
	[price] [int] NULL,
	[pdesc] [nvarchar](2000) NULL,
	[pimage] [nvarchar](100) NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[persons] ON 

INSERT [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (1, N'陳大貓王', N'09556663333', N'高雄市新興區南台路', N'mm@bbb.net.tw', CAST(N'1985-08-10' AS Date), 1, 3333)
INSERT [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (2, N'黃小貓', N'0966333222', N'高雄市三民區民族路', N'pp@nn.com', CAST(N'1986-06-03' AS Date), 1, 5000)
INSERT [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (3, N'張大書', N'0977000777', N'高雄市鼓山區美術路', N'zz@ddd.com.tw', CAST(N'1978-11-09' AS Date), 0, 2000)
INSERT [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (4, N'林玉霈', N'0999111666', N'台南市東區中華路', N'rr@ttt.com', CAST(N'1979-01-05' AS Date), 0, 1500)
INSERT [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (5, N'王小明', N'0955666555', N'台中市西屯區', N'www@vvv.com.tw', CAST(N'1992-08-20' AS Date), 1, 300)
INSERT [dbo].[persons] ([Id], [姓名], [電話], [地址], [email], [生日], [婚姻狀態], [點數]) VALUES (8, N'David Wang', N'0922999111', N'台北市內湖區港湖路', N'david@ttt.com.tw', CAST(N'1977-03-04' AS Date), 1, 3400)
SET IDENTITY_INSERT [dbo].[persons] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (1, N'蘋果', 50, N'好吃的蘋果, 快來買', N'1.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (2, N'橘子', 30, N'橘子好吃, 一點也不酸', N'2.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (3, N'櫻桃', 150, N'進口櫻桃, 超級好吃', N'3.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (4, N'巨峰葡萄', 90, N'聞名全國的巨峰葡萄, 大特價快來買!!', N'202205181108446617.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (5, N'西瓜', 25, N'多汁又甜的大西瓜', N'5.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (1002, N'花蓮大西瓜', 66, N'最新東部直運的新鮮西瓜!!', N'202205181143434855.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (1003, N'青森蘋果', 100, N'日本產地直送', N'202205181153013297.png')
SET IDENTITY_INSERT [dbo].[products] OFF
GO
USE [master]
GO
ALTER DATABASE [mydb] SET  READ_WRITE 
GO
