USE [master]
GO
/****** Object:  Database [Attenda]    Script Date: 2021/10/21 12:17:14 ******/
CREATE DATABASE [Attenda]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Attenda', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Attenda.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Attenda_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Attenda_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Attenda] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Attenda].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Attenda] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Attenda] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Attenda] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Attenda] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Attenda] SET ARITHABORT OFF 
GO
ALTER DATABASE [Attenda] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Attenda] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Attenda] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Attenda] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Attenda] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Attenda] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Attenda] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Attenda] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Attenda] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Attenda] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Attenda] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Attenda] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Attenda] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Attenda] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Attenda] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Attenda] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Attenda] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Attenda] SET RECOVERY FULL 
GO
ALTER DATABASE [Attenda] SET  MULTI_USER 
GO
ALTER DATABASE [Attenda] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Attenda] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Attenda] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Attenda] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Attenda] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Attenda', N'ON'
GO
ALTER DATABASE [Attenda] SET QUERY_STORE = OFF
GO
USE [Attenda]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Attenda]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 2021/10/21 12:17:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassID] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [nvarchar](50) NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Register]    Script Date: 2021/10/21 12:17:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Register](
	[RegisterID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NULL,
	[ClassID] [int] NULL,
	[AttendanceDate] [datetime] NULL,
	[Status] [nchar](10) NULL,
 CONSTRAINT [PK_Register] PRIMARY KEY CLUSTERED 
(
	[RegisterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 2021/10/21 12:17:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [int] NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[Grade] [nchar](10) NULL,
	[ClassID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2021/10/21 12:17:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Attenda] SET  READ_WRITE 
GO
