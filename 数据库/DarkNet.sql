USE [master]
GO
/****** Object:  Database [DarkNet]    Script Date: 2019/8/19 20:00:53 ******/
CREATE DATABASE [DarkNet]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DarkNet', FILENAME = N'D:\桌面\新建文件夹\百亿项目 - 副本\数据库\DarkNet.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DarkNet_log', FILENAME = N'D:\桌面\新建文件夹\百亿项目 - 副本\数据库\DarkNet_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DarkNet] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DarkNet].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DarkNet] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DarkNet] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DarkNet] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DarkNet] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DarkNet] SET ARITHABORT OFF 
GO
ALTER DATABASE [DarkNet] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DarkNet] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DarkNet] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DarkNet] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DarkNet] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DarkNet] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DarkNet] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DarkNet] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DarkNet] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DarkNet] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DarkNet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DarkNet] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DarkNet] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DarkNet] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DarkNet] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DarkNet] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DarkNet] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DarkNet] SET RECOVERY FULL 
GO
ALTER DATABASE [DarkNet] SET  MULTI_USER 
GO
ALTER DATABASE [DarkNet] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DarkNet] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DarkNet] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DarkNet] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DarkNet] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DarkNet', N'ON'
GO
USE [DarkNet]
GO
/****** Object:  Table [dbo].[AdmInfo]    Script Date: 2019/8/19 20:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdmInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Pwd] [nvarchar](20) NOT NULL,
	[Zhiwu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AdmInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 2019/8/19 20:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NeRong] [nvarchar](max) NOT NULL,
	[UserNiCheng] [nvarchar](50) NULL,
 CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FilmArrange]    Script Date: 2019/8/19 20:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FilmArrange](
	[PP_ID] [int] IDENTITY(1,1) NOT NULL,
	[PP_Name] [nvarchar](20) NOT NULL,
	[PP_StartTime] [datetime2](0) NOT NULL,
	[PP_EndTime] [datetime2](0) NOT NULL,
	[PP_Ting] [nvarchar](50) NOT NULL,
	[PP_Seat] [nvarchar](max) NULL,
	[PP_Price] [money] NOT NULL,
 CONSTRAINT [PK_FilmArrange] PRIMARY KEY CLUSTERED 
(
	[PP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_FilmArrange] UNIQUE NONCLUSTERED 
(
	[PP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MovieInfo]    Script Date: 2019/8/19 20:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieInfo](
	[DY_ID] [nvarchar](20) NOT NULL,
	[DY_Name] [nvarchar](20) NOT NULL,
	[DY_Director] [nvarchar](20) NOT NULL,
	[DY_Start] [nvarchar](20) NOT NULL,
	[DY_Type] [nvarchar](20) NOT NULL,
	[DY_Time] [int] NOT NULL,
	[DY_Description] [nvarchar](max) NOT NULL,
	[DY_Area] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MovieInfo] PRIMARY KEY CLUSTERED 
(
	[DY_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NewInfo]    Script Date: 2019/8/19 20:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewInfo](
	[XW_ID] [int] IDENTITY(1,1) NOT NULL,
	[XW_name] [nvarchar](50) NOT NULL,
	[XW_title] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_NewInfo] PRIMARY KEY CLUSTERED 
(
	[XW_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderInfo]    Script Date: 2019/8/19 20:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderInfo](
	[D_ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[SeatInfo] [nvarchar](max) NOT NULL,
	[FileName] [nvarchar](50) NOT NULL,
	[GeneratedTime] [datetime] NOT NULL,
	[SumPrice] [money] NOT NULL,
	[Count] [int] NOT NULL,
	[Ting] [nvarchar](max) NULL,
	[TicketingState] [nvarchar](10) NULL,
	[PlayTime] [datetime] NOT NULL,
 CONSTRAINT [PK_OrderInfo] PRIMARY KEY CLUSTERED 
(
	[D_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Shooting]    Script Date: 2019/8/19 20:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shooting](
	[ID] [nvarchar](20) NOT NULL,
	[FileName] [nvarchar](20) NOT NULL,
	[Duration] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[YingTing] [nvarchar](50) NOT NULL,
	[ReleaseDate] [date] NOT NULL,
	[ReleaseTime] [time](7) NOT NULL,
 CONSTRAINT [PK_Shooting] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 2019/8/19 20:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[YH_ID] [int] IDENTITY(1,1) NOT NULL,
	[YH_Name] [nvarchar](20) NOT NULL,
	[YH_Pwd] [nvarchar](20) NOT NULL,
	[YH_NiceName] [nvarchar](20) NOT NULL,
	[YH_Registration] [datetime] NOT NULL CONSTRAINT [DF_UserInfo_YH_Registration]  DEFAULT (getdate()),
	[YH_Sex] [nvarchar](5) NULL,
	[YH_Phone] [nvarchar](11) NOT NULL,
	[YH_VIP] [int] NOT NULL CONSTRAINT [DF_UserInfo_YH_VIP]  DEFAULT ((0)),
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[YH_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_UserInfo] UNIQUE NONCLUSTERED 
(
	[YH_Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[YingTing]    Script Date: 2019/8/19 20:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YingTing](
	[YT_ID] [nvarchar](50) NOT NULL,
	[YT_Name] [nvarchar](50) NOT NULL,
	[YT_Row] [int] NOT NULL,
	[YT_Col] [int] NOT NULL,
	[YT_Describe] [nvarchar](max) NULL,
	[YH_Seat] [nvarchar](max) NULL,
 CONSTRAINT [PK_YingTing] PRIMARY KEY CLUSTERED 
(
	[YT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Shooting]  WITH CHECK ADD  CONSTRAINT [FK_Shooting_MovieInfo] FOREIGN KEY([ID])
REFERENCES [dbo].[MovieInfo] ([DY_ID])
GO
ALTER TABLE [dbo].[Shooting] CHECK CONSTRAINT [FK_Shooting_MovieInfo]
GO
USE [master]
GO
ALTER DATABASE [DarkNet] SET  READ_WRITE 
GO
