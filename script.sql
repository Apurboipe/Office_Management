USE [master]
GO
/****** Object:  Database [OfficeBD]    Script Date: 10/2/2018 12:01:18 PM ******/
CREATE DATABASE [OfficeBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OfficeBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\OfficeBD.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OfficeBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\OfficeBD_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OfficeBD] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OfficeBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OfficeBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OfficeBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OfficeBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OfficeBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OfficeBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [OfficeBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OfficeBD] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [OfficeBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OfficeBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OfficeBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OfficeBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OfficeBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OfficeBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OfficeBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OfficeBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OfficeBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OfficeBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OfficeBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OfficeBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OfficeBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OfficeBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OfficeBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OfficeBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OfficeBD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OfficeBD] SET  MULTI_USER 
GO
ALTER DATABASE [OfficeBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OfficeBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OfficeBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OfficeBD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [OfficeBD]
GO
/****** Object:  Table [dbo].[account_tbl]    Script Date: 10/2/2018 12:01:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[account_tbl](
	[accountType] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[administrationInfo_tbl]    Script Date: 10/2/2018 12:01:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[administrationInfo_tbl](
	[name] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[type] [varchar](50) NOT NULL,
	[gender] [varchar](50) NOT NULL,
	[note] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[administrationView_tbl]    Script Date: 10/2/2018 12:01:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[administrationView_tbl](
	[administrationUsername] [varchar](50) NOT NULL,
	[studentRoll] [varchar](50) NOT NULL,
	[session] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[assignStudentInfo_tbl]    Script Date: 10/2/2018 12:01:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[assignStudentInfo_tbl](
	[roll] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[dept] [varchar](50) NOT NULL,
	[session] [varchar](50) NOT NULL,
	[sex] [varchar](50) NOT NULL,
	[note] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[chairmanInfo_tbl]    Script Date: 10/2/2018 12:01:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chairmanInfo_tbl](
	[name] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[dept] [varchar](50) NOT NULL,
	[gender] [varchar](50) NOT NULL,
	[note] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[chairmanView_tbl]    Script Date: 10/2/2018 12:01:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chairmanView_tbl](
	[chairmanUsername] [varchar](50) NOT NULL,
	[studentRoll] [varchar](50) NOT NULL,
	[session] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[student_tbl]    Script Date: 10/2/2018 12:01:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[student_tbl](
	[roll] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[dept] [varchar](50) NOT NULL,
	[session] [varchar](50) NOT NULL,
	[sex] [varchar](50) NOT NULL,
	[note] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[teacher_tbl]    Script Date: 10/2/2018 12:01:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[teacher_tbl](
	[teacherUsername] [varchar](50) NOT NULL,
	[studentRoll] [varchar](50) NOT NULL,
	[session] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[teacherInfo_tbl]    Script Date: 10/2/2018 12:01:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[teacherInfo_tbl](
	[name] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[designation] [varchar](50) NOT NULL,
	[note] [varchar](50) NOT NULL,
	[dept] [varchar](50) NOT NULL,
	[gender] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [OfficeBD] SET  READ_WRITE 
GO
