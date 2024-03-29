USE [master]
GO
/****** Object:  Database [commentappdb]    Script Date: 9/16/2019 2:10:18 AM ******/
CREATE DATABASE [commentappdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'commentappdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\commentappdb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'commentappdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\commentappdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [commentappdb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [commentappdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [commentappdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [commentappdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [commentappdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [commentappdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [commentappdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [commentappdb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [commentappdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [commentappdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [commentappdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [commentappdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [commentappdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [commentappdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [commentappdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [commentappdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [commentappdb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [commentappdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [commentappdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [commentappdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [commentappdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [commentappdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [commentappdb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [commentappdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [commentappdb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [commentappdb] SET  MULTI_USER 
GO
ALTER DATABASE [commentappdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [commentappdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [commentappdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [commentappdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [commentappdb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [commentappdb] SET QUERY_STORE = OFF
GO
USE [commentappdb]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 9/16/2019 2:10:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 9/16/2019 2:10:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Body] [nvarchar](max) NULL,
	[postId] [int] NULL,
 CONSTRAINT [PK_dbo.Comments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Posts]    Script Date: 9/16/2019 2:10:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Body] [nvarchar](max) NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_dbo.Posts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/16/2019 2:10:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fullname] [nvarchar](max) NULL,
	[Username] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Website] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_postId]    Script Date: 9/16/2019 2:10:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_postId] ON [dbo].[Comments]
(
	[postId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_userId]    Script Date: 9/16/2019 2:10:20 AM ******/
CREATE NONCLUSTERED INDEX [IX_userId] ON [dbo].[Posts]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Comments_dbo.Posts_postId] FOREIGN KEY([postId])
REFERENCES [dbo].[Posts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_dbo.Comments_dbo.Posts_postId]
GO
ALTER TABLE [dbo].[Posts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Posts_dbo.Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Posts] CHECK CONSTRAINT [FK_dbo.Posts_dbo.Users_UserId]
GO
USE [master]
GO
ALTER DATABASE [commentappdb] SET  READ_WRITE 
GO
