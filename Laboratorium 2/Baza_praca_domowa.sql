USE [master]
GO
/****** Object:  Database [VideoRentalShop]    Script Date: 07.05.2021 10:54:21 ******/
CREATE DATABASE [VideoRentalShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoRentalShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VideoRentalShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VideoRentalShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VideoRentalShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [VideoRentalShop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoRentalShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoRentalShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoRentalShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoRentalShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoRentalShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoRentalShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoRentalShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VideoRentalShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoRentalShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoRentalShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoRentalShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoRentalShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoRentalShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoRentalShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoRentalShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoRentalShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VideoRentalShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoRentalShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoRentalShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoRentalShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoRentalShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoRentalShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoRentalShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoRentalShop] SET RECOVERY FULL 
GO
ALTER DATABASE [VideoRentalShop] SET  MULTI_USER 
GO
ALTER DATABASE [VideoRentalShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoRentalShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoRentalShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoRentalShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideoRentalShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VideoRentalShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'VideoRentalShop', N'ON'
GO
ALTER DATABASE [VideoRentalShop] SET QUERY_STORE = OFF
GO
USE [VideoRentalShop]
GO
/****** Object:  Table [dbo].[Actors]    Script Date: 07.05.2021 10:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Actors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 07.05.2021 10:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameCategory] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FilmActors]    Script Date: 07.05.2021 10:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FilmActors](
	[ActorId] [int] NOT NULL,
	[FilmId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FilmCategories]    Script Date: 07.05.2021 10:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FilmCategories](
	[CategoryId] [int] NOT NULL,
	[FilmId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Films]    Script Date: 07.05.2021 10:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Films](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[YearOfProduction] [int] NOT NULL,
	[LanguageId] [int] NOT NULL,
	[SubtitlesId] [int] NOT NULL,
	[IsRentable] [bit] NOT NULL,
 CONSTRAINT [PK_Films] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 07.05.2021 10:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameLanguage] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental]    Script Date: 07.05.2021 10:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[FilmId] [int] NOT NULL,
	[DateSince] [date] NOT NULL,
	[DateTo] [date] NOT NULL,
 CONSTRAINT [PK_Rental] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subtitles]    Script Date: 07.05.2021 10:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subtitles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameSubtitles] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Subtitles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 07.05.2021 10:54:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Actors] ON 

INSERT [dbo].[Actors] ([Id], [FirstName], [LastName]) VALUES (1, N'Chris', N'Pratt')
INSERT [dbo].[Actors] ([Id], [FirstName], [LastName]) VALUES (3, N'Jennifer', N'Lawrence')
INSERT [dbo].[Actors] ([Id], [FirstName], [LastName]) VALUES (4, N'Dwayne', N'Johnson')
INSERT [dbo].[Actors] ([Id], [FirstName], [LastName]) VALUES (5, N'Alanna', N'Ubach')
SET IDENTITY_INSERT [dbo].[Actors] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [NameCategory]) VALUES (1, N'Comedy')
INSERT [dbo].[Categories] ([Id], [NameCategory]) VALUES (2, N'Sci-fi')
INSERT [dbo].[Categories] ([Id], [NameCategory]) VALUES (3, N'Animation')
INSERT [dbo].[Categories] ([Id], [NameCategory]) VALUES (4, N'Thriller')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
INSERT [dbo].[FilmActors] ([ActorId], [FilmId]) VALUES (1, 1)
INSERT [dbo].[FilmActors] ([ActorId], [FilmId]) VALUES (1, 2)
INSERT [dbo].[FilmActors] ([ActorId], [FilmId]) VALUES (3, 3)
INSERT [dbo].[FilmActors] ([ActorId], [FilmId]) VALUES (4, 4)
INSERT [dbo].[FilmActors] ([ActorId], [FilmId]) VALUES (4, 5)
INSERT [dbo].[FilmActors] ([ActorId], [FilmId]) VALUES (5, 6)
INSERT [dbo].[FilmActors] ([ActorId], [FilmId]) VALUES (3, 2)
GO
INSERT [dbo].[FilmCategories] ([CategoryId], [FilmId]) VALUES (1, 1)
INSERT [dbo].[FilmCategories] ([CategoryId], [FilmId]) VALUES (2, 2)
INSERT [dbo].[FilmCategories] ([CategoryId], [FilmId]) VALUES (4, 3)
INSERT [dbo].[FilmCategories] ([CategoryId], [FilmId]) VALUES (3, 4)
INSERT [dbo].[FilmCategories] ([CategoryId], [FilmId]) VALUES (1, 5)
INSERT [dbo].[FilmCategories] ([CategoryId], [FilmId]) VALUES (3, 6)
GO
SET IDENTITY_INSERT [dbo].[Films] ON 

INSERT [dbo].[Films] ([Id], [Title], [YearOfProduction], [LanguageId], [SubtitlesId], [IsRentable]) VALUES (1, N'Strażnicy Galaktyki', 2014, 1, 2, 1)
INSERT [dbo].[Films] ([Id], [Title], [YearOfProduction], [LanguageId], [SubtitlesId], [IsRentable]) VALUES (2, N'Pasażerowie', 2016, 1, 2, 1)
INSERT [dbo].[Films] ([Id], [Title], [YearOfProduction], [LanguageId], [SubtitlesId], [IsRentable]) VALUES (3, N'Czerwona Jaskółka', 2018, 2, 2, 0)
INSERT [dbo].[Films] ([Id], [Title], [YearOfProduction], [LanguageId], [SubtitlesId], [IsRentable]) VALUES (4, N'Vaiana', 2016, 3, 1, 1)
INSERT [dbo].[Films] ([Id], [Title], [YearOfProduction], [LanguageId], [SubtitlesId], [IsRentable]) VALUES (5, N'Jumanji', 2017, 2, 3, 0)
INSERT [dbo].[Films] ([Id], [Title], [YearOfProduction], [LanguageId], [SubtitlesId], [IsRentable]) VALUES (6, N'Coco', 2017, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Films] OFF
GO
SET IDENTITY_INSERT [dbo].[Languages] ON 

INSERT [dbo].[Languages] ([Id], [NameLanguage]) VALUES (1, N'English')
INSERT [dbo].[Languages] ([Id], [NameLanguage]) VALUES (2, N'Polish')
INSERT [dbo].[Languages] ([Id], [NameLanguage]) VALUES (3, N'Japanese')
SET IDENTITY_INSERT [dbo].[Languages] OFF
GO
SET IDENTITY_INSERT [dbo].[Rental] ON 

INSERT [dbo].[Rental] ([Id], [UserId], [FilmId], [DateSince], [DateTo]) VALUES (1, 1, 3, CAST(N'2021-04-13' AS Date), CAST(N'2021-05-05' AS Date))
INSERT [dbo].[Rental] ([Id], [UserId], [FilmId], [DateSince], [DateTo]) VALUES (2, 2, 5, CAST(N'2021-03-15' AS Date), CAST(N'2021-05-23' AS Date))
INSERT [dbo].[Rental] ([Id], [UserId], [FilmId], [DateSince], [DateTo]) VALUES (3, 1, 6, CAST(N'2020-12-21' AS Date), CAST(N'2021-02-02' AS Date))
SET IDENTITY_INSERT [dbo].[Rental] OFF
GO
SET IDENTITY_INSERT [dbo].[Subtitles] ON 

INSERT [dbo].[Subtitles] ([Id], [NameSubtitles]) VALUES (1, N'English')
INSERT [dbo].[Subtitles] ([Id], [NameSubtitles]) VALUES (2, N'Polish')
INSERT [dbo].[Subtitles] ([Id], [NameSubtitles]) VALUES (3, N'French')
SET IDENTITY_INSERT [dbo].[Subtitles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [UserName], [Password]) VALUES (1, N'Jan', N'Kowalski', N'Kowal', N'Kowal')
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [UserName], [Password]) VALUES (2, N'Piotr', N'Wójcik', N'Wójt', N'Wójt')
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [UserName], [Password]) VALUES (3, N'Patrycja', N'Zdradzisz', N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[FilmActors]  WITH CHECK ADD  CONSTRAINT [FK_FilmActors_Actors] FOREIGN KEY([ActorId])
REFERENCES [dbo].[Actors] ([Id])
GO
ALTER TABLE [dbo].[FilmActors] CHECK CONSTRAINT [FK_FilmActors_Actors]
GO
ALTER TABLE [dbo].[FilmActors]  WITH CHECK ADD  CONSTRAINT [FK_FilmActors_Film] FOREIGN KEY([FilmId])
REFERENCES [dbo].[Films] ([Id])
GO
ALTER TABLE [dbo].[FilmActors] CHECK CONSTRAINT [FK_FilmActors_Film]
GO
ALTER TABLE [dbo].[FilmCategories]  WITH CHECK ADD  CONSTRAINT [FK_FilmCategories_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[FilmCategories] CHECK CONSTRAINT [FK_FilmCategories_Categories]
GO
ALTER TABLE [dbo].[FilmCategories]  WITH CHECK ADD  CONSTRAINT [FK_FilmCategories_Film] FOREIGN KEY([FilmId])
REFERENCES [dbo].[Films] ([Id])
GO
ALTER TABLE [dbo].[FilmCategories] CHECK CONSTRAINT [FK_FilmCategories_Film]
GO
ALTER TABLE [dbo].[Films]  WITH CHECK ADD  CONSTRAINT [FK_Films_Language] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([Id])
GO
ALTER TABLE [dbo].[Films] CHECK CONSTRAINT [FK_Films_Language]
GO
ALTER TABLE [dbo].[Films]  WITH CHECK ADD  CONSTRAINT [FK_Films_Subtitles] FOREIGN KEY([SubtitlesId])
REFERENCES [dbo].[Subtitles] ([Id])
GO
ALTER TABLE [dbo].[Films] CHECK CONSTRAINT [FK_Films_Subtitles]
GO
ALTER TABLE [dbo].[Rental]  WITH CHECK ADD  CONSTRAINT [FK_Rental_Film] FOREIGN KEY([FilmId])
REFERENCES [dbo].[Films] ([Id])
GO
ALTER TABLE [dbo].[Rental] CHECK CONSTRAINT [FK_Rental_Film]
GO
ALTER TABLE [dbo].[Rental]  WITH CHECK ADD  CONSTRAINT [FK_Rental_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Rental] CHECK CONSTRAINT [FK_Rental_User]
GO
USE [master]
GO
ALTER DATABASE [VideoRentalShop] SET  READ_WRITE 
GO
