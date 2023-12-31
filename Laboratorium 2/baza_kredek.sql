USE [master]
GO
/****** Object:  Database [BookStoreKredek]    Script Date: 07.05.2021 10:53:36 ******/
CREATE DATABASE [BookStoreKredek]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookStoreKredek', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BookStoreKredek.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BookStoreKredek_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BookStoreKredek_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BookStoreKredek] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookStoreKredek].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookStoreKredek] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookStoreKredek] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookStoreKredek] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookStoreKredek] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookStoreKredek] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookStoreKredek] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BookStoreKredek] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookStoreKredek] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookStoreKredek] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookStoreKredek] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookStoreKredek] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookStoreKredek] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookStoreKredek] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookStoreKredek] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookStoreKredek] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BookStoreKredek] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookStoreKredek] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookStoreKredek] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookStoreKredek] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookStoreKredek] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookStoreKredek] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookStoreKredek] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookStoreKredek] SET RECOVERY FULL 
GO
ALTER DATABASE [BookStoreKredek] SET  MULTI_USER 
GO
ALTER DATABASE [BookStoreKredek] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookStoreKredek] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookStoreKredek] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookStoreKredek] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BookStoreKredek] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BookStoreKredek] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BookStoreKredek', N'ON'
GO
ALTER DATABASE [BookStoreKredek] SET QUERY_STORE = OFF
GO
USE [BookStoreKredek]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 07.05.2021 10:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 07.05.2021 10:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[YearOfPublish] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[AuthorId] [int] NOT NULL,
	[GenreId] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genres]    Script Date: 07.05.2021 10:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genres](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Genres] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 07.05.2021 10:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([Id], [FirstName], [LastName]) VALUES (1, N'Paweł', N'Kobryński')
INSERT [dbo].[Authors] ([Id], [FirstName], [LastName]) VALUES (2, N'Kacper', N'Antos')
INSERT [dbo].[Authors] ([Id], [FirstName], [LastName]) VALUES (3, N'Jan', N'Kowalski')
SET IDENTITY_INSERT [dbo].[Authors] OFF
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([Id], [Title], [YearOfPublish], [Price], [AuthorId], [GenreId]) VALUES (1, N'Podstawa SQL', 2021, 90.0000, 1, 1)
INSERT [dbo].[Books] ([Id], [Title], [YearOfPublish], [Price], [AuthorId], [GenreId]) VALUES (4, N'Książka 2', 1990, 150.0000, 2, 2)
INSERT [dbo].[Books] ([Id], [Title], [YearOfPublish], [Price], [AuthorId], [GenreId]) VALUES (5, N'Życie www', 1995, 50.0000, 2, 2)
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
SET IDENTITY_INSERT [dbo].[Genres] ON 

INSERT [dbo].[Genres] ([Id], [Name]) VALUES (1, N'Komedia')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (2, N'Dramat')
SET IDENTITY_INSERT [dbo].[Genres] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Login], [Password]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Authors] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([Id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Authors]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Genres] FOREIGN KEY([GenreId])
REFERENCES [dbo].[Genres] ([Id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Genres]
GO
USE [master]
GO
ALTER DATABASE [BookStoreKredek] SET  READ_WRITE 
GO
