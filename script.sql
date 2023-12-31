USE [master]
GO
/****** Object:  Database [SportShop]    Script Date: 07.11.2023 14:02:55 ******/
CREATE DATABASE [SportShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SportShop', FILENAME = N'D:\ProgramFiles\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SportShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SportShop_log', FILENAME = N'D:\ProgramFiles\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SportShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SportShop] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SportShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SportShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SportShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SportShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SportShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SportShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [SportShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SportShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SportShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SportShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SportShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SportShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SportShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SportShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SportShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SportShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SportShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SportShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SportShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SportShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SportShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SportShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SportShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SportShop] SET RECOVERY FULL 
GO
ALTER DATABASE [SportShop] SET  MULTI_USER 
GO
ALTER DATABASE [SportShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SportShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SportShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SportShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SportShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SportShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SportShop', N'ON'
GO
ALTER DATABASE [SportShop] SET QUERY_STORE = ON
GO
ALTER DATABASE [SportShop] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SportShop]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 07.11.2023 14:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 07.11.2023 14:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 07.11.2023 14:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[Phone] [nvarchar](11) NULL,
	[DateOfBirth] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Delivery]    Script Date: 07.11.2023 14:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Delivery](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Provider] [int] NOT NULL,
	[DeliveryDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeliveryComposition]    Script Date: 07.11.2023 14:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryComposition](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Delivery] [int] NOT NULL,
	[ID_Product] [int] NOT NULL,
	[Amount] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 07.11.2023 14:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[ID_Category] [int] NOT NULL,
	[Photo] [nvarchar](100) NOT NULL,
	[Price] [money] NOT NULL,
	[Amount] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 07.11.2023 14:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 07.11.2023 14:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Client] [int] NOT NULL,
	[ID_Seller] [int] NOT NULL,
	[DateOfSale] [date] NOT NULL,
 CONSTRAINT [PK__Sale__3214EC27E1747081] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleComposition]    Script Date: 07.11.2023 14:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleComposition](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Sale] [int] NOT NULL,
	[ID_Product] [int] NOT NULL,
	[Amount] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seller]    Script Date: 07.11.2023 14:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seller](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([ID], [LastName], [FirstName], [Patronymic], [Login], [Password]) VALUES (1, N'Домрачев', N'Вадим', N'Николаевич', N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([ID], [Name]) VALUES (1, N'Одежда')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (2, N'Оборудование')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (3, N'Аксессуары')
INSERT [dbo].[Category] ([ID], [Name]) VALUES (4, N'Защитное снаряжение')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([ID], [LastName], [FirstName], [Patronymic], [Phone], [DateOfBirth]) VALUES (1, N'Домрачев', N'Вадим', N'Николаевич', N'9106215286', CAST(N'2004-09-05' AS Date))
INSERT [dbo].[Client] ([ID], [LastName], [FirstName], [Patronymic], [Phone], [DateOfBirth]) VALUES (2, N'Видеев', N'Вадим', N'Владимирович', N'2312312311', CAST(N'2004-10-20' AS Date))
INSERT [dbo].[Client] ([ID], [LastName], [FirstName], [Patronymic], [Phone], [DateOfBirth]) VALUES (3, N'asd', N'asd', N'asd', N'9102343212', CAST(N'2004-09-05' AS Date))
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Delivery] ON 

INSERT [dbo].[Delivery] ([ID], [ID_Provider], [DeliveryDate]) VALUES (1, 1, CAST(N'2023-10-18' AS Date))
INSERT [dbo].[Delivery] ([ID], [ID_Provider], [DeliveryDate]) VALUES (2, 1, CAST(N'2004-09-05' AS Date))
SET IDENTITY_INSERT [dbo].[Delivery] OFF
GO
SET IDENTITY_INSERT [dbo].[DeliveryComposition] ON 

INSERT [dbo].[DeliveryComposition] ([ID], [ID_Delivery], [ID_Product], [Amount]) VALUES (1, 1, 1, 2)
INSERT [dbo].[DeliveryComposition] ([ID], [ID_Delivery], [ID_Product], [Amount]) VALUES (2, 2, 1, 23)
SET IDENTITY_INSERT [dbo].[DeliveryComposition] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ID], [Name], [ID_Category], [Photo], [Price], [Amount]) VALUES (1, N'Штанга', 2, N'../ImagesProducts/p1.jpg', 1200.0000, 2)
INSERT [dbo].[Product] ([ID], [Name], [ID_Category], [Photo], [Price], [Amount]) VALUES (2, N'Гиря 16кг.', 2, N'../ImagesProducts/p2.jpg', 1000.0000, 1)
INSERT [dbo].[Product] ([ID], [Name], [ID_Category], [Photo], [Price], [Amount]) VALUES (3, N'Гиря 24кг.', 2, N'../ImagesProducts/p3.jpg', 1300.0000, 20)
INSERT [dbo].[Product] ([ID], [Name], [ID_Category], [Photo], [Price], [Amount]) VALUES (4, N'Рашгард', 1, N'../ImagesProducts/p4.jpg', 1500.0000, 3)
INSERT [dbo].[Product] ([ID], [Name], [ID_Category], [Photo], [Price], [Amount]) VALUES (5, N'Грипсы на самокат', 3, N'../ImagesProducts/p5.jpg', 250.0000, 40)
INSERT [dbo].[Product] ([ID], [Name], [ID_Category], [Photo], [Price], [Amount]) VALUES (6, N'Наколенники', 4, N'../ImagesProducts/p6.jpg', 500.0000, 10)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Provider] ON 

INSERT [dbo].[Provider] ([ID], [Name]) VALUES (1, N'Поставщик')
SET IDENTITY_INSERT [dbo].[Provider] OFF
GO
SET IDENTITY_INSERT [dbo].[Sale] ON 

INSERT [dbo].[Sale] ([ID], [ID_Client], [ID_Seller], [DateOfSale]) VALUES (1, 3, 1, CAST(N'2023-11-02' AS Date))
INSERT [dbo].[Sale] ([ID], [ID_Client], [ID_Seller], [DateOfSale]) VALUES (2, 2, 1, CAST(N'2023-11-02' AS Date))
INSERT [dbo].[Sale] ([ID], [ID_Client], [ID_Seller], [DateOfSale]) VALUES (3, 1, 1, CAST(N'2023-11-02' AS Date))
INSERT [dbo].[Sale] ([ID], [ID_Client], [ID_Seller], [DateOfSale]) VALUES (4, 1, 1, CAST(N'2023-11-02' AS Date))
INSERT [dbo].[Sale] ([ID], [ID_Client], [ID_Seller], [DateOfSale]) VALUES (5, 2, 1, CAST(N'2023-11-02' AS Date))
INSERT [dbo].[Sale] ([ID], [ID_Client], [ID_Seller], [DateOfSale]) VALUES (6, 1, 1, CAST(N'2023-11-02' AS Date))
INSERT [dbo].[Sale] ([ID], [ID_Client], [ID_Seller], [DateOfSale]) VALUES (7, 2, 1, CAST(N'2023-11-02' AS Date))
INSERT [dbo].[Sale] ([ID], [ID_Client], [ID_Seller], [DateOfSale]) VALUES (9, 2, 1, CAST(N'2023-11-02' AS Date))
INSERT [dbo].[Sale] ([ID], [ID_Client], [ID_Seller], [DateOfSale]) VALUES (10, 3, 1, CAST(N'2023-11-02' AS Date))
INSERT [dbo].[Sale] ([ID], [ID_Client], [ID_Seller], [DateOfSale]) VALUES (11, 2, 1, CAST(N'2023-11-02' AS Date))
INSERT [dbo].[Sale] ([ID], [ID_Client], [ID_Seller], [DateOfSale]) VALUES (12, 1, 1, CAST(N'2023-11-02' AS Date))
SET IDENTITY_INSERT [dbo].[Sale] OFF
GO
SET IDENTITY_INSERT [dbo].[SaleComposition] ON 

INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (1, 1, 2, 2)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (2, 1, 3, 1)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (3, 2, 1, 1)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (4, 2, 2, 2)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (5, 3, 1, 1)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (6, 3, 2, 2)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (7, 4, 2, 1)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (8, 4, 3, 2)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (9, 4, 4, 3)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (10, 5, 2, 1)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (11, 6, 2, 1)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (12, 7, 1, 2)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (13, 9, 3, 3)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (14, 10, 6, 2)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (15, 11, 5, 3)
INSERT [dbo].[SaleComposition] ([ID], [ID_Sale], [ID_Product], [Amount]) VALUES (16, 12, 1, 1)
SET IDENTITY_INSERT [dbo].[SaleComposition] OFF
GO
SET IDENTITY_INSERT [dbo].[Seller] ON 

INSERT [dbo].[Seller] ([ID], [LastName], [FirstName], [Patronymic], [Login], [Password]) VALUES (1, N'Домрачев', N'Вадим', N'Николаевич', N'1', N'1')
SET IDENTITY_INSERT [dbo].[Seller] OFF
GO
ALTER TABLE [dbo].[Delivery]  WITH CHECK ADD  CONSTRAINT [FK_Delivery_Provider] FOREIGN KEY([ID_Provider])
REFERENCES [dbo].[Provider] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Delivery] CHECK CONSTRAINT [FK_Delivery_Provider]
GO
ALTER TABLE [dbo].[DeliveryComposition]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryComposition_Delivery] FOREIGN KEY([ID_Delivery])
REFERENCES [dbo].[Delivery] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DeliveryComposition] CHECK CONSTRAINT [FK_DeliveryComposition_Delivery]
GO
ALTER TABLE [dbo].[DeliveryComposition]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryComposition_Product] FOREIGN KEY([ID_Product])
REFERENCES [dbo].[Product] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DeliveryComposition] CHECK CONSTRAINT [FK_DeliveryComposition_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([ID_Category])
REFERENCES [dbo].[Category] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Client] FOREIGN KEY([ID_Client])
REFERENCES [dbo].[Client] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Client]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Seller] FOREIGN KEY([ID_Seller])
REFERENCES [dbo].[Seller] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Seller]
GO
ALTER TABLE [dbo].[SaleComposition]  WITH CHECK ADD  CONSTRAINT [FK_SaleComposition_Product] FOREIGN KEY([ID_Product])
REFERENCES [dbo].[Product] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SaleComposition] CHECK CONSTRAINT [FK_SaleComposition_Product]
GO
ALTER TABLE [dbo].[SaleComposition]  WITH CHECK ADD  CONSTRAINT [FK_SaleComposition_Sale] FOREIGN KEY([ID_Sale])
REFERENCES [dbo].[Sale] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SaleComposition] CHECK CONSTRAINT [FK_SaleComposition_Sale]
GO
/****** Object:  Trigger [dbo].[DeliveryUpdate]    Script Date: 07.11.2023 14:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[DeliveryUpdate] on [dbo].[DeliveryComposition]
after insert as
update Product
set Amount = Amount + (select Amount from inserted)
where Product.ID = (select ID_Product from inserted)
GO
ALTER TABLE [dbo].[DeliveryComposition] ENABLE TRIGGER [DeliveryUpdate]
GO
/****** Object:  Trigger [dbo].[SaleUpdate]    Script Date: 07.11.2023 14:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[SaleUpdate] on [dbo].[SaleComposition]
after insert as
update Product
set Amount = Amount - (select Amount from inserted)
where Product.ID = (select ID_Product from inserted)
GO
ALTER TABLE [dbo].[SaleComposition] ENABLE TRIGGER [SaleUpdate]
GO
USE [master]
GO
ALTER DATABASE [SportShop] SET  READ_WRITE 
GO
