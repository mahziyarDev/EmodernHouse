USE [master]
GO
/****** Object:  Database [EModernHouse_DB]    Script Date: 6/11/2022 11:07:23 PM ******/
CREATE DATABASE [EModernHouse_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EModernHouse_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EModernHouse_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EModernHouse_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EModernHouse_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EModernHouse_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EModernHouse_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EModernHouse_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EModernHouse_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EModernHouse_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EModernHouse_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EModernHouse_DB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [EModernHouse_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [EModernHouse_DB] SET  MULTI_USER 
GO
ALTER DATABASE [EModernHouse_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EModernHouse_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EModernHouse_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EModernHouse_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EModernHouse_DB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EModernHouse_DB', N'ON'
GO
ALTER DATABASE [EModernHouse_DB] SET QUERY_STORE = OFF
GO
USE [EModernHouse_DB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactUses]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactUses](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NULL,
	[UserIp] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](200) NOT NULL,
	[FullName] [nvarchar](200) NOT NULL,
	[Mobile] [nvarchar](200) NOT NULL,
	[Subject] [nvarchar](200) NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ContactUses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Count] [int] NOT NULL,
	[ProductColorId] [bigint] NULL,
	[ProductPrice] [int] NOT NULL,
	[ProductColorPrice] [int] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[PaymentDate] [datetime2](7) NULL,
	[IsPaid] [bit] NOT NULL,
	[TracingCode] [nvarchar](300) NULL,
	[Description] [nvarchar](max) NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategories]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategories](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ParentId] [bigint] NULL,
	[Title] [nvarchar](200) NOT NULL,
	[CategoryImage] [nvarchar](max) NULL,
	[UrlName] [nvarchar](200) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProductCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductColors]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductColors](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[ColorName] [nvarchar](200) NOT NULL,
	[ColorCode] [nvarchar](max) NOT NULL,
	[Price] [int] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
	[Count] [int] NOT NULL,
 CONSTRAINT [PK_ProductColors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductComment]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductComment](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ParentId] [bigint] NULL,
	[ProductId] [bigint] NOT NULL,
	[UserId] [bigint] NOT NULL,
	[TitleComment] [nvarchar](200) NOT NULL,
	[EmailUser] [nvarchar](200) NOT NULL,
	[TextComment] [nvarchar](max) NOT NULL,
	[ProductCommentState] [int] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProductComment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDisCount]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDisCount](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Percentage] [int] NOT NULL,
	[ExpireDate] [datetime2](7) NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProductDisCount] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDiscountUse]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDiscountUse](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductDisCountId] [bigint] NOT NULL,
	[UserId] [bigint] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProductDiscountUse] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductFeatures]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductFeatures](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[FeatureTitle] [nvarchar](200) NOT NULL,
	[FeatureValue] [nvarchar](200) NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProductFeatures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductForShowIndex]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductForShowIndex](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Priority] [int] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProductForShowIndex] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductGalleries]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductGalleries](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[DisplayPriority] [int] NOT NULL,
	[ImageName] [nvarchar](200) NOT NULL,
	[Alt] [nvarchar](100) NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProductGalleries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductInterests]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductInterests](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[UserId] [bigint] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProductInterests] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](300) NOT NULL,
	[ImageName] [nvarchar](300) NOT NULL,
	[Price] [int] NOT NULL,
	[ShortDescription] [nvarchar](450) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[ShortLink] [nvarchar](max) NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductSelectedCategories]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductSelectedCategories](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[ProductCategoryId] [bigint] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProductSelectedCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SellerWallets]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SellerWallets](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Price] [int] NOT NULL,
	[TransactionType] [int] NOT NULL,
	[Description] [nvarchar](300) NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_SellerWallets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiteBanners]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteBanners](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ImageName] [nvarchar](200) NOT NULL,
	[Url] [nvarchar](200) NOT NULL,
	[ColSize] [nvarchar](500) NOT NULL,
	[Alt] [nvarchar](200) NOT NULL,
	[BannerPlacement] [int] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_SiteBanners] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiteSettings]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteSettings](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Phone] [nvarchar](25) NULL,
	[Mobile] [nvarchar](25) NULL,
	[Email] [nvarchar](200) NULL,
	[Logo] [nvarchar](200) NULL,
	[CopyRight] [nvarchar](350) NULL,
	[IsDefault] [bit] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_SiteSettings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sliders]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sliders](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ImageName] [nvarchar](200) NOT NULL,
	[MainHeader] [nvarchar](200) NOT NULL,
	[Alt] [nvarchar](200) NOT NULL,
	[Link] [nvarchar](200) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Sliders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TicketMessages]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketMessages](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TicketId] [bigint] NOT NULL,
	[SenderId] [bigint] NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TicketMessages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[OwnerId] [bigint] NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[TicketState] [int] NOT NULL,
	[TicketSection] [int] NOT NULL,
	[TicketPriority] [int] NOT NULL,
	[IsReadByOwner] [bit] NOT NULL,
	[IsReadByAdmin] [bit] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAddresses]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAddresses](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[Address] [nvarchar](450) NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
	[Cities] [int] NOT NULL,
 CONSTRAINT [PK_UserAddresses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](200) NULL,
	[EmailActiveCode] [nvarchar](100) NOT NULL,
	[IsEmailActive] [bit] NOT NULL,
	[Mobile] [nvarchar](200) NOT NULL,
	[MobileActiveCode] [nvarchar](20) NOT NULL,
	[IsMobileActive] [bit] NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[FirstName] [nvarchar](200) NOT NULL,
	[LastName] [nvarchar](200) NOT NULL,
	[Avatar] [nvarchar](200) NULL,
	[IsBlocked] [bit] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserSelectedRole]    Script Date: 6/11/2022 11:07:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserSelectedRole](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[RolesId] [bigint] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[LastUpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_UserSelectedRole] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210715111501_InitialDataBase', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210721084121_EditUserModel', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210730071727_AddSiteSetting', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210815093807_add_TBl_ContactUS', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210819083723_AddTblSlider', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210820054635_addSiteBanner', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210830173014_AddTicket', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210913181040_AddProductsModels', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210914062052_EditProductModels', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210920023315_addProductColor', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210920072610_EditMigrationForProductCategory', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210925131943_AddproductGalleryModel', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211002081049_editProductCategory', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211009075530_AddProducFeature', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211011082327_AddProductOrder', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211011095710_EditOrder', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211011095929_EditOrderTwo', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211012110015_EditModelOrder', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211014114402_addProductInterstModel', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211017093108_addWalletSeller', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211021181554_addUserAddress', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211101101456_EditProductModels_color', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211101161838_addProductDiscount', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211103093555_editDiscountModel', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211113082100_CreateModelComment', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211113093213_EditModelComment', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211122221335_AddModelRole_UserRole_ProductForeShoIndex', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220106164955_EditUserAddress', N'5.0.11')
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([Id], [OrderId], [ProductId], [Count], [ProductColorId], [ProductPrice], [ProductColorPrice], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (6, 1, 1, 2, 1, 0, 0, 0, CAST(N'2022-06-05T00:17:08.9937979' AS DateTime2), CAST(N'2022-06-05T00:17:31.8307055' AS DateTime2))
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [UserId], [PaymentDate], [IsPaid], [TracingCode], [Description], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (1, 1, NULL, 0, NULL, NULL, 0, CAST(N'2021-11-26T15:14:49.6768112' AS DateTime2), CAST(N'2021-11-26T15:14:49.6768150' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductCategories] ON 

INSERT [dbo].[ProductCategories] ([Id], [ParentId], [Title], [CategoryImage], [UrlName], [IsActive], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (1, NULL, N'اشپزخانه', N'3cdf331457004d72b74f021700993f25.jpg', NULL, 1, 0, CAST(N'2021-11-26T15:07:41.5658854' AS DateTime2), CAST(N'2021-11-26T15:07:41.5658945' AS DateTime2))
INSERT [dbo].[ProductCategories] ([Id], [ParentId], [Title], [CategoryImage], [UrlName], [IsActive], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (2, 1, N'گاز', NULL, NULL, 1, 0, CAST(N'2021-11-26T15:08:05.2728819' AS DateTime2), CAST(N'2021-11-26T15:08:05.2728959' AS DateTime2))
INSERT [dbo].[ProductCategories] ([Id], [ParentId], [Title], [CategoryImage], [UrlName], [IsActive], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (3, 2, N'گاز فر دار', NULL, NULL, 1, 0, CAST(N'2021-11-26T15:08:14.9655273' AS DateTime2), CAST(N'2021-11-26T15:08:14.9655366' AS DateTime2))
INSERT [dbo].[ProductCategories] ([Id], [ParentId], [Title], [CategoryImage], [UrlName], [IsActive], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (4, 2, N'گاز طرح فر', NULL, NULL, 1, 0, CAST(N'2021-11-26T15:08:23.4048969' AS DateTime2), CAST(N'2021-11-26T15:08:23.4049104' AS DateTime2))
INSERT [dbo].[ProductCategories] ([Id], [ParentId], [Title], [CategoryImage], [UrlName], [IsActive], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (6, 1, N'مایشن لباس شویی', NULL, NULL, 1, 0, CAST(N'2021-11-26T15:08:42.4910613' AS DateTime2), CAST(N'2021-11-26T15:08:42.4910687' AS DateTime2))
INSERT [dbo].[ProductCategories] ([Id], [ParentId], [Title], [CategoryImage], [UrlName], [IsActive], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (7, 6, N'ماشین لباس شویی سامسونگ', NULL, NULL, 1, 0, CAST(N'2021-11-26T15:09:06.3232168' AS DateTime2), CAST(N'2021-11-26T15:09:06.3232232' AS DateTime2))
INSERT [dbo].[ProductCategories] ([Id], [ParentId], [Title], [CategoryImage], [UrlName], [IsActive], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (8, 6, N'ماشین لباسشویی ال جی', NULL, NULL, 1, 0, CAST(N'2021-11-26T15:09:16.9182194' AS DateTime2), CAST(N'2021-11-26T15:09:16.9182243' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProductCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductColors] ON 

INSERT [dbo].[ProductColors] ([Id], [ProductId], [ColorName], [ColorCode], [Price], [IsDelete], [CreateDate], [LastUpdateDate], [Count]) VALUES (1, 1, N'نقره ای', N'#efefef', 23000, 0, CAST(N'2021-11-28T06:31:02.3755711' AS DateTime2), CAST(N'2021-12-08T11:15:08.6687277' AS DateTime2), 4)
INSERT [dbo].[ProductColors] ([Id], [ProductId], [ColorName], [ColorCode], [Price], [IsDelete], [CreateDate], [LastUpdateDate], [Count]) VALUES (2, 1, N'بنفش', N'#45d', 5000, 0, CAST(N'2021-11-28T07:54:53.4974921' AS DateTime2), CAST(N'2022-05-27T13:24:07.7548850' AS DateTime2), 2)
INSERT [dbo].[ProductColors] ([Id], [ProductId], [ColorName], [ColorCode], [Price], [IsDelete], [CreateDate], [LastUpdateDate], [Count]) VALUES (3, 1, N'سیاه', N'#000', 12345, 0, CAST(N'2021-11-30T08:47:03.5920314' AS DateTime2), CAST(N'2021-12-01T13:55:01.8778606' AS DateTime2), 2)
SET IDENTITY_INSERT [dbo].[ProductColors] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductComment] ON 

INSERT [dbo].[ProductComment] ([Id], [ParentId], [ProductId], [UserId], [TitleComment], [EmailUser], [TextComment], [ProductCommentState], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (1, NULL, 1, 1, N'cascascas', N'mahziyar130@gmail.com', N'dasdvgfbghnhjm', 2, 0, CAST(N'2021-11-29T03:34:15.8127062' AS DateTime2), CAST(N'2021-11-30T08:47:43.1494998' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProductComment] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductDisCount] ON 

INSERT [dbo].[ProductDisCount] ([Id], [ProductId], [Percentage], [ExpireDate], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (1, 1, 10, CAST(N'2022-06-14T00:00:00.0000000' AS DateTime2), 0, CAST(N'2022-06-05T16:57:37.4211406' AS DateTime2), CAST(N'2022-06-05T16:57:37.4212865' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProductDisCount] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductForShowIndex] ON 

INSERT [dbo].[ProductForShowIndex] ([Id], [ProductId], [Priority], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (2, 1, 2, 0, CAST(N'2021-12-03T06:29:27.5105011' AS DateTime2), CAST(N'2021-12-03T06:29:27.5105165' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProductForShowIndex] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductGalleries] ON 

INSERT [dbo].[ProductGalleries] ([Id], [ProductId], [DisplayPriority], [ImageName], [Alt], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (1, 1, 1, N'a9a295c08a484ba18b001b2dfec78b95.jpg', N'ماشین لباسشویی سامسونگ', 0, CAST(N'2021-11-26T15:14:26.1789286' AS DateTime2), CAST(N'2021-11-26T15:14:26.1789383' AS DateTime2))
INSERT [dbo].[ProductGalleries] ([Id], [ProductId], [DisplayPriority], [ImageName], [Alt], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (2, 1, 2, N'd0c6d58770f44fe2849ec92b2b5c4995.jpg', N'ماشین لباسشویی سامسونگ', 0, CAST(N'2021-11-26T15:14:37.1255381' AS DateTime2), CAST(N'2021-11-26T15:14:37.1255486' AS DateTime2))
INSERT [dbo].[ProductGalleries] ([Id], [ProductId], [DisplayPriority], [ImageName], [Alt], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (3, 1, 3, N'0799d401839f4c358728f3ddff356925.jpg', N'ماشین لباسشویی سامسونگ', 0, CAST(N'2021-11-26T15:14:45.9949171' AS DateTime2), CAST(N'2021-11-26T15:14:45.9949238' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProductGalleries] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductInterests] ON 

INSERT [dbo].[ProductInterests] ([Id], [ProductId], [UserId], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (1, 1, 1, 0, CAST(N'2022-06-04T13:06:50.2853684' AS DateTime2), CAST(N'2022-06-04T13:06:50.2854705' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProductInterests] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Title], [ImageName], [Price], [ShortDescription], [Description], [IsActive], [ShortLink], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (1, N'ماشین لباسشویی12 کیلویی سامسونگ', N'83a675779c9f4c60909fa0aed7808c59.jpg', 25650000, N'ماشین لباسشویی سامسونگ از سری لباسشویی های اتوماتیک تولید شده این کمپانی است که در ظرفیت 8 کیلوگرم تولید و به بازار عرضه شده است.این لباسشویی با ظرفیت بالایی که دارد ،برای خانواده های با جمعیت متوسط رو به بالا مناسب است.ظرفیت در لباسشویی بیانگر میزان وزن البسه ای است که کاربر در داخل دیگ لباسشویی قرار میدهد.در هنگام "خرید ماشین لباسشویی" چیزی که برای خانم های خانه دار مهم اسنت،میزان صدا و لرزش دستگاه میباشد.در واقع همه ما طبیعتا به دنبال لباسشویی', N'<p style="text-align:justify;"><a href="https://yeknam.com/92-Washing-Machine#/%D8%B3%D8%A7%D8%B2%D9%86%D8%AF%D9%87-%D8%B3%D8%A7%D9%85%D8%B3%D9%88%D9%86%DA%AF_samsung"><span style="color:rgb(44,159,253);">ماشین لباسشویی سامسونگ</span></a> از سری لباسشویی های اتوماتیک تولید شده این کمپانی است که در ظرفیت <span style="color:rgb(240,13,13);"><strong>8 کیلوگرم</strong></span> تولید و به بازار عرضه شده است.این لباسشویی با ظرفیت بالایی که دارد ،برای خانواده های با جمعیت متوسط رو به بالا مناسب است.ظرفیت در لباسشویی بیانگر میزان وزن البسه ای است که کاربر در داخل دیگ لباسشویی قرار میدهد.در هنگام "<a href="https://yeknam.com/92-Washing-Machine"><span style="color:rgb(44,159,253);">خرید ماشین لباسشویی</span></a>" چیزی که برای خانم های خانه دار مهم اسنت،میزان صدا و لرزش دستگاه میباشد.در واقع همه ما طبیعتا به دنبال لباسشویی میگردیم که در هنگام شب و استراحت ،صدای آزار دهنده ای نداشته باشد..</p><p style="text-align:justify;">در این جا یکی از مدل های به روز و با کیفیت شرکت سامسونگ را معرفی خواهیم کرد.و این لباسشویی با <span style="color:rgb(244,8,8);"><strong>قیمت مناسبی</strong></span> که دارد میتواند یک انتخاب ایده ال برای خانواده ها باشد.دیگ مدل Q1492 در حالت خشک کن ،1400 دور در هر دقیقه میچرخد.به این عمل سرعت دور خشک کن ماشین لباسشوبی میگویند.برای اطلاعات بیشتر شما مشتریان عزیز در زمینه استفاده از ماشین لباسشویی <a href="https://yeknam.com/articles/10-%D8%A7%D9%85%D9%88%D8%B2%D8%B4-%D9%88-%D8%B1%D8%A7%D9%87%D9%86%D9%85%D8%A7%DB%8C-%D8%AE%D8%B1%DB%8C%D8%AF-%D9%85%D8%A7%D8%B4%DB%8C%D9%86-%D9%84%D8%A8%D8%A7%D8%B3%D8%B4%D9%88%DB%8C%DB%8C-%D9%88-%D9%86%D8%AD%D9%88%D9%87-%D8%A7%D8%B3%D8%AA%D9%81%D8%A7%D8%AF%D9%87-%D8%A7%D8%B2-%D8%A7%D9%86.html"><span style="color:rgb(44,159,253);">راهنمای خرید ماشین لباسشویی</span></a> به همراه نحوه استفاده از این دستگاه ارزشمند را گرداوری کرده ایم.</p><p style="text-align:justify;">لباسشویی سامسونگ مدل Q1492 دارای دو ورودی آب سرد و گرم میباشد.همینطور صفحه نمایش این دستگاه ارزشمند و خوش خرید ،نوع برنامه انتخابی دستگاه و همینطور زمان شروع و اتمام کار را برای شما نمایش میدهد.برنامه هایی که برای این مدل خوش خرید سامسونگ در نظر گرفته شده است،کار شستشو را راحت کرده است.اینکه چه نوع شستشویی را برای لباسی که در داخل دیگ الباسسویی قرار میدهید با انتخاب برنامه مورد نظر،مشخص میشود.<a href="https://yeknam.com/articles/107-%D8%A7%D8%B5%D8%B7%D9%84%D8%A7%D8%AD%D8%A7%D8%AA-%D8%B1%D8%A7%D9%87%D9%86%D9%85%D8%A7%DB%8C-%D8%A7%D8%B3%D8%AA%D9%81%D8%A7%D8%AF%D9%87-%D9%85%D8%A7%D8%B4%DB%8C%D9%86-%D9%84%D8%A8%D8%A7%D8%B3%D8%B4%D9%88%DB%8C%DB%8C-%D8%B3%D8%A7%D9%85%D8%B3%D9%88%D9%86%DA%AF.html"><span style="color:rgb(44,159,253);">ترجمه اصطلاحات و مفاهیم</span></a> مهم لباسشویی را در این لینک به صورت کامل بخوانید.</p><p style="text-align:justify;">یکی از برنامه های کاربردی ماشین لباسشویی های سامسونگ ،سیستم <span style="color:rgb(251,15,15);"><strong>Air Wash</strong></span> میباشد.این تکنولوژی یک قابلیت بوزدایی در لباسشویی میباشد.بوزدایی و استرلیزه کردن البسه بدون استفاده از آب در ماشین لباسشویی 8 کیلویی سامسونگ مدل Q1492 با استفاده از هیتری که در بالای لباسشویی قرار دارد ، با گردش هوای داغ، عمل بوزدایی و ضد عفونی کردن لباس‌ها را انجام خواهد داد.</p>', 1, NULL, 0, CAST(N'2021-11-26T15:13:53.8332402' AS DateTime2), CAST(N'2021-11-26T15:13:53.8332475' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductSelectedCategories] ON 

INSERT [dbo].[ProductSelectedCategories] ([Id], [ProductId], [ProductCategoryId], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (1, 1, 1, 0, CAST(N'2021-11-26T15:13:53.9287354' AS DateTime2), CAST(N'2021-11-26T15:13:53.9287465' AS DateTime2))
INSERT [dbo].[ProductSelectedCategories] ([Id], [ProductId], [ProductCategoryId], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (2, 1, 6, 0, CAST(N'2021-11-26T15:13:53.9484232' AS DateTime2), CAST(N'2021-11-26T15:13:53.9484284' AS DateTime2))
INSERT [dbo].[ProductSelectedCategories] ([Id], [ProductId], [ProductCategoryId], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (3, 1, 7, 0, CAST(N'2021-11-26T15:13:53.9485510' AS DateTime2), CAST(N'2021-11-26T15:13:53.9485529' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProductSelectedCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Title], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (2, N'Admin', 0, CAST(N'2021-11-26T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-26T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Roles] ([Id], [Title], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (3, N'User', 0, CAST(N'2021-11-26T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-26T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[SiteBanners] ON 

INSERT [dbo].[SiteBanners] ([Id], [ImageName], [Url], [ColSize], [Alt], [BannerPlacement], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (1, N'af5c681cd53a46728b6cc25f9f773afb.gif', N'http://www.yazdstar.com', N' col-12', N'بنر تخفیفات ستاره یزد', 4, 0, CAST(N'2021-12-10T20:15:26.3929971' AS DateTime2), CAST(N'2021-12-10T20:15:26.3933038' AS DateTime2))
INSERT [dbo].[SiteBanners] ([Id], [ImageName], [Url], [ColSize], [Alt], [BannerPlacement], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (2, N'f14107162d5b4e4f9c43a02559bf6e71.gif', N'http://www.yazdstar.com', N'col-lg-12 col-sm-6 col-12', N'استایل های جدید ستاره یزد', 0, 0, CAST(N'2021-12-10T20:19:54.5814751' AS DateTime2), CAST(N'2021-12-10T20:19:54.5814838' AS DateTime2))
INSERT [dbo].[SiteBanners] ([Id], [ImageName], [Url], [ColSize], [Alt], [BannerPlacement], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (3, N'd9a6bb2329fc4a1f95c5d1c50fb20214.jpg', N'http://www.yazdstar.com', N'col-lg-12 col-sm-6 col-12', N'تخفیف 60 درصدی محصولات بهداشتی', 0, 0, CAST(N'2021-12-10T20:33:16.8502440' AS DateTime2), CAST(N'2021-12-10T20:33:16.8502552' AS DateTime2))
INSERT [dbo].[SiteBanners] ([Id], [ImageName], [Url], [ColSize], [Alt], [BannerPlacement], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (4, N'5db55836ef734bcea07a81e264f1f4b5.jpg', N'http://www.yazdstar.com', N'col-lg-6 col-sm-6 col-6', N'استایل های جدید ستاره یزد', 1, 0, CAST(N'2021-12-10T21:25:08.8866522' AS DateTime2), CAST(N'2021-12-10T21:27:12.7703550' AS DateTime2))
INSERT [dbo].[SiteBanners] ([Id], [ImageName], [Url], [ColSize], [Alt], [BannerPlacement], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (5, N'68abd3f56e9e4b849b83c4f6a94b4173.jpg', N'http://www.yazdstar.com', N'col-lg-6 col-sm-6 col-6', N'بنر تخفیفات ستاره یزد', 1, 0, CAST(N'2021-12-10T21:25:44.6729744' AS DateTime2), CAST(N'2021-12-10T21:27:24.2434548' AS DateTime2))
SET IDENTITY_INSERT [dbo].[SiteBanners] OFF
GO
SET IDENTITY_INSERT [dbo].[SiteSettings] ON 

INSERT [dbo].[SiteSettings] ([Id], [Phone], [Mobile], [Email], [Logo], [CopyRight], [IsDefault], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (1, N'09913439792 _ 09913439792', N'03538365793', N'mahziyar138006@gmail.com', N'9d4da3bc3a3840f6a3f4e48d89c5f78d.png', N'تمامی حقوق این سایت برای یزد استار محفوظ است', 1, 0, CAST(N'2021-11-26T15:07:03.0608423' AS DateTime2), CAST(N'2021-11-26T15:07:03.0613588' AS DateTime2))
SET IDENTITY_INSERT [dbo].[SiteSettings] OFF
GO
SET IDENTITY_INSERT [dbo].[Sliders] ON 

INSERT [dbo].[Sliders] ([Id], [ImageName], [MainHeader], [Alt], [Link], [IsActive], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (1, N'a82910b3cd9a48cc9e8524241e804774.jpg', N'اسلایدر یکم', N'تخفیفات اسلایدی20 درصدی', N'http://www.yazdstar.com', 1, 0, CAST(N'2021-12-10T20:17:11.3157961' AS DateTime2), CAST(N'2021-12-10T20:17:11.3158069' AS DateTime2))
INSERT [dbo].[Sliders] ([Id], [ImageName], [MainHeader], [Alt], [Link], [IsActive], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (2, N'e546e57da6574aee9df51b4cc1cc6170.jpg', N'چرخ خیاطی و زود پز', N'چرخ خیاطی و زود پز ستاره یزد', N'http://www.yazdstar.com', 1, 0, CAST(N'2021-12-10T20:17:46.4082188' AS DateTime2), CAST(N'2021-12-10T20:17:46.4082287' AS DateTime2))
INSERT [dbo].[Sliders] ([Id], [ImageName], [MainHeader], [Alt], [Link], [IsActive], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (3, N'1ce70a47c3384df6be916e06a018fd9a.jpg', N'جسنواره هوآوی', N'جشنواره هوآوی ستاره یزد', N'http://www.yazdstar.com', 1, 0, CAST(N'2021-12-10T20:18:34.5062504' AS DateTime2), CAST(N'2021-12-10T20:18:34.5062590' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Sliders] OFF
GO
SET IDENTITY_INSERT [dbo].[UserAddresses] ON 

INSERT [dbo].[UserAddresses] ([Id], [UserId], [Address], [IsDelete], [CreateDate], [LastUpdateDate], [Cities]) VALUES (1, 1, N'یزد رحمت اباد کوچه 73 پلاک 123 زنگ دوم اقای مریدی', 0, CAST(N'2022-01-06T23:04:00.1476013' AS DateTime2), CAST(N'2022-06-04T13:02:48.3958965' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[UserAddresses] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Email], [EmailActiveCode], [IsEmailActive], [Mobile], [MobileActiveCode], [IsMobileActive], [Password], [FirstName], [LastName], [Avatar], [IsBlocked], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (1, NULL, N'3f7d00d7a80b4fea9220deee48d019ab', 0, N'09913439792', N'80232', 1, N'F4-8C-04-FF-AB-49-FF-0E-5D-11-76-24-4F-DF-B6-5C', N'مهزیار', N'دهقان', N'969230b49d7f4bb3ba175154863bdfa4.jpg', 0, 0, CAST(N'2021-11-26T14:40:36.6986801' AS DateTime2), CAST(N'2022-01-07T18:20:47.3388739' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[UserSelectedRole] ON 

INSERT [dbo].[UserSelectedRole] ([Id], [UserId], [RolesId], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (1, 1, 3, 0, CAST(N'2021-11-26T14:40:37.0569049' AS DateTime2), CAST(N'2021-11-26T14:40:37.0569119' AS DateTime2))
INSERT [dbo].[UserSelectedRole] ([Id], [UserId], [RolesId], [IsDelete], [CreateDate], [LastUpdateDate]) VALUES (3, 1, 2, 0, CAST(N'2021-11-26T14:40:37.0569049' AS DateTime2), CAST(N'2021-11-26T14:40:37.0569119' AS DateTime2))
SET IDENTITY_INSERT [dbo].[UserSelectedRole] OFF
GO
/****** Object:  Index [IX_ContactUses_UserId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ContactUses_UserId] ON [dbo].[ContactUses]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetails_OrderId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetails_OrderId] ON [dbo].[OrderDetails]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetails_ProductColorId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetails_ProductColorId] ON [dbo].[OrderDetails]
(
	[ProductColorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetails_ProductId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetails_ProductId] ON [dbo].[OrderDetails]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_UserId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_UserId] ON [dbo].[Orders]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductCategories_ParentId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductCategories_ParentId] ON [dbo].[ProductCategories]
(
	[ParentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductColors_ProductId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductColors_ProductId] ON [dbo].[ProductColors]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductComment_ParentId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductComment_ParentId] ON [dbo].[ProductComment]
(
	[ParentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductComment_ProductId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductComment_ProductId] ON [dbo].[ProductComment]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductComment_UserId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductComment_UserId] ON [dbo].[ProductComment]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductDisCount_ProductId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductDisCount_ProductId] ON [dbo].[ProductDisCount]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductDiscountUse_ProductDisCountId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductDiscountUse_ProductDisCountId] ON [dbo].[ProductDiscountUse]
(
	[ProductDisCountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductDiscountUse_UserId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductDiscountUse_UserId] ON [dbo].[ProductDiscountUse]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductFeatures_ProductId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductFeatures_ProductId] ON [dbo].[ProductFeatures]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductForShowIndex_ProductId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductForShowIndex_ProductId] ON [dbo].[ProductForShowIndex]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductGalleries_ProductId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductGalleries_ProductId] ON [dbo].[ProductGalleries]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductInterests_ProductId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductInterests_ProductId] ON [dbo].[ProductInterests]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductInterests_UserId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductInterests_UserId] ON [dbo].[ProductInterests]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductSelectedCategories_ProductCategoryId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductSelectedCategories_ProductCategoryId] ON [dbo].[ProductSelectedCategories]
(
	[ProductCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductSelectedCategories_ProductId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_ProductSelectedCategories_ProductId] ON [dbo].[ProductSelectedCategories]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TicketMessages_SenderId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_TicketMessages_SenderId] ON [dbo].[TicketMessages]
(
	[SenderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TicketMessages_TicketId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_TicketMessages_TicketId] ON [dbo].[TicketMessages]
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Tickets_OwnerId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_Tickets_OwnerId] ON [dbo].[Tickets]
(
	[OwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserAddresses_UserId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_UserAddresses_UserId] ON [dbo].[UserAddresses]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserSelectedRole_RolesId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserSelectedRole_RolesId] ON [dbo].[UserSelectedRole]
(
	[RolesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserSelectedRole_UserId]    Script Date: 6/11/2022 11:07:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserSelectedRole_UserId] ON [dbo].[UserSelectedRole]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProductColors] ADD  DEFAULT (N'') FOR [ColorCode]
GO
ALTER TABLE [dbo].[ProductColors] ADD  DEFAULT ((0)) FOR [Count]
GO
ALTER TABLE [dbo].[ProductComment] ADD  DEFAULT (N'') FOR [TitleComment]
GO
ALTER TABLE [dbo].[ProductComment] ADD  DEFAULT (N'') FOR [EmailUser]
GO
ALTER TABLE [dbo].[ProductComment] ADD  DEFAULT (N'') FOR [TextComment]
GO
ALTER TABLE [dbo].[UserAddresses] ADD  DEFAULT ((0)) FOR [Cities]
GO
ALTER TABLE [dbo].[ContactUses]  WITH CHECK ADD  CONSTRAINT [FK_ContactUses_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ContactUses] CHECK CONSTRAINT [FK_ContactUses_Users_UserId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders_OrderId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_ProductColors_ProductColorId] FOREIGN KEY([ProductColorId])
REFERENCES [dbo].[ProductColors] ([Id])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_ProductColors_ProductColorId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products_ProductId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users_UserId]
GO
ALTER TABLE [dbo].[ProductCategories]  WITH CHECK ADD  CONSTRAINT [FK_ProductCategories_ProductCategories_ParentId] FOREIGN KEY([ParentId])
REFERENCES [dbo].[ProductCategories] ([Id])
GO
ALTER TABLE [dbo].[ProductCategories] CHECK CONSTRAINT [FK_ProductCategories_ProductCategories_ParentId]
GO
ALTER TABLE [dbo].[ProductColors]  WITH CHECK ADD  CONSTRAINT [FK_ProductColors_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ProductColors] CHECK CONSTRAINT [FK_ProductColors_Products_ProductId]
GO
ALTER TABLE [dbo].[ProductComment]  WITH CHECK ADD  CONSTRAINT [FK_ProductComment_ProductComment_ParentId] FOREIGN KEY([ParentId])
REFERENCES [dbo].[ProductComment] ([Id])
GO
ALTER TABLE [dbo].[ProductComment] CHECK CONSTRAINT [FK_ProductComment_ProductComment_ParentId]
GO
ALTER TABLE [dbo].[ProductComment]  WITH CHECK ADD  CONSTRAINT [FK_ProductComment_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ProductComment] CHECK CONSTRAINT [FK_ProductComment_Products_ProductId]
GO
ALTER TABLE [dbo].[ProductComment]  WITH CHECK ADD  CONSTRAINT [FK_ProductComment_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ProductComment] CHECK CONSTRAINT [FK_ProductComment_Users_UserId]
GO
ALTER TABLE [dbo].[ProductDisCount]  WITH CHECK ADD  CONSTRAINT [FK_ProductDisCount_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ProductDisCount] CHECK CONSTRAINT [FK_ProductDisCount_Products_ProductId]
GO
ALTER TABLE [dbo].[ProductDiscountUse]  WITH CHECK ADD  CONSTRAINT [FK_ProductDiscountUse_ProductDisCount_ProductDisCountId] FOREIGN KEY([ProductDisCountId])
REFERENCES [dbo].[ProductDisCount] ([Id])
GO
ALTER TABLE [dbo].[ProductDiscountUse] CHECK CONSTRAINT [FK_ProductDiscountUse_ProductDisCount_ProductDisCountId]
GO
ALTER TABLE [dbo].[ProductDiscountUse]  WITH CHECK ADD  CONSTRAINT [FK_ProductDiscountUse_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ProductDiscountUse] CHECK CONSTRAINT [FK_ProductDiscountUse_Users_UserId]
GO
ALTER TABLE [dbo].[ProductFeatures]  WITH CHECK ADD  CONSTRAINT [FK_ProductFeatures_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ProductFeatures] CHECK CONSTRAINT [FK_ProductFeatures_Products_ProductId]
GO
ALTER TABLE [dbo].[ProductForShowIndex]  WITH CHECK ADD  CONSTRAINT [FK_ProductForShowIndex_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ProductForShowIndex] CHECK CONSTRAINT [FK_ProductForShowIndex_Products_ProductId]
GO
ALTER TABLE [dbo].[ProductGalleries]  WITH CHECK ADD  CONSTRAINT [FK_ProductGalleries_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ProductGalleries] CHECK CONSTRAINT [FK_ProductGalleries_Products_ProductId]
GO
ALTER TABLE [dbo].[ProductInterests]  WITH CHECK ADD  CONSTRAINT [FK_ProductInterests_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ProductInterests] CHECK CONSTRAINT [FK_ProductInterests_Products_ProductId]
GO
ALTER TABLE [dbo].[ProductInterests]  WITH CHECK ADD  CONSTRAINT [FK_ProductInterests_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ProductInterests] CHECK CONSTRAINT [FK_ProductInterests_Users_UserId]
GO
ALTER TABLE [dbo].[ProductSelectedCategories]  WITH CHECK ADD  CONSTRAINT [FK_ProductSelectedCategories_ProductCategories_ProductCategoryId] FOREIGN KEY([ProductCategoryId])
REFERENCES [dbo].[ProductCategories] ([Id])
GO
ALTER TABLE [dbo].[ProductSelectedCategories] CHECK CONSTRAINT [FK_ProductSelectedCategories_ProductCategories_ProductCategoryId]
GO
ALTER TABLE [dbo].[ProductSelectedCategories]  WITH CHECK ADD  CONSTRAINT [FK_ProductSelectedCategories_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ProductSelectedCategories] CHECK CONSTRAINT [FK_ProductSelectedCategories_Products_ProductId]
GO
ALTER TABLE [dbo].[TicketMessages]  WITH CHECK ADD  CONSTRAINT [FK_TicketMessages_Tickets_TicketId] FOREIGN KEY([TicketId])
REFERENCES [dbo].[Tickets] ([Id])
GO
ALTER TABLE [dbo].[TicketMessages] CHECK CONSTRAINT [FK_TicketMessages_Tickets_TicketId]
GO
ALTER TABLE [dbo].[TicketMessages]  WITH CHECK ADD  CONSTRAINT [FK_TicketMessages_Users_SenderId] FOREIGN KEY([SenderId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[TicketMessages] CHECK CONSTRAINT [FK_TicketMessages_Users_SenderId]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Users_OwnerId] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Users_OwnerId]
GO
ALTER TABLE [dbo].[UserAddresses]  WITH CHECK ADD  CONSTRAINT [FK_UserAddresses_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserAddresses] CHECK CONSTRAINT [FK_UserAddresses_Users_UserId]
GO
ALTER TABLE [dbo].[UserSelectedRole]  WITH CHECK ADD  CONSTRAINT [FK_UserSelectedRole_Roles_RolesId] FOREIGN KEY([RolesId])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[UserSelectedRole] CHECK CONSTRAINT [FK_UserSelectedRole_Roles_RolesId]
GO
ALTER TABLE [dbo].[UserSelectedRole]  WITH CHECK ADD  CONSTRAINT [FK_UserSelectedRole_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserSelectedRole] CHECK CONSTRAINT [FK_UserSelectedRole_Users_UserId]
GO
USE [master]
GO
ALTER DATABASE [EModernHouse_DB] SET  READ_WRITE 
GO
