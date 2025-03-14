USE [master]
GO
/****** Object:  Database [ProGestion]    Script Date: 10/12/2024 08:23:12 ******/
CREATE DATABASE [ProGestion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProGestion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ProGestion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProGestion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ProGestion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ProGestion] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProGestion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProGestion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProGestion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProGestion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProGestion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProGestion] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProGestion] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ProGestion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProGestion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProGestion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProGestion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProGestion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProGestion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProGestion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProGestion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProGestion] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProGestion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProGestion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProGestion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProGestion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProGestion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProGestion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProGestion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProGestion] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProGestion] SET  MULTI_USER 
GO
ALTER DATABASE [ProGestion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProGestion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProGestion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProGestion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProGestion] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProGestion] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ProGestion] SET QUERY_STORE = ON
GO
ALTER DATABASE [ProGestion] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ProGestion]
GO
/****** Object:  Table [dbo].[Actions]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[libel] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Associations]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Associations](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](40) NOT NULL,
	[responsable] [varchar](40) NOT NULL,
	[mission_id] [int] NOT NULL,
	[country_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChoosenCountryYears]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChoosenCountryYears](
	[country_id] [int] NOT NULL,
	[choosenYear] [int] NOT NULL,
	[plafond] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[country_id] ASC,
	[choosenYear] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](40) NOT NULL,
	[isoCode] [varchar](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InterventionsLogs]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InterventionsLogs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tableName] [varchar](40) NOT NULL,
	[operation] [varchar](6) NOT NULL,
	[reference] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Missions]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Missions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[libel] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partnerships]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partnerships](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [date] NOT NULL,
	[forecastBudget] [float] NULL,
	[realBudget] [float] NULL,
	[action_id] [int] NOT NULL,
	[association_id] [int] NOT NULL,
	[country_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[libel] [varchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [varchar](40) NOT NULL,
	[password] [varchar](120) NOT NULL,
	[role_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (1, N'Aruba', N'ABW')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (2, N'Afghanistan', N'AFG')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (3, N'Angola', N'AGO')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (4, N'Anguilla', N'AIA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (5, N'Îles Åland', N'ALA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (6, N'Albanie', N'ALB')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (7, N'Andorre', N'AND')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (8, N'Antilles Néerlandaises', N'ANT')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (9, N'Émirats Arabes Unis', N'ARE')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (10, N'Argentine', N'ARG')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (11, N'Arménie', N'ARM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (12, N'Samoa Américaines', N'ASM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (13, N'Antarctique', N'ATA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (14, N'Terres Australes Françaises', N'ATF')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (15, N'Antigua-et-Barbuda', N'ATG')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (16, N'Australie', N'AUS')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (17, N'Autriche', N'AUT')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (18, N'Azerbaïdjan', N'AZE')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (19, N'Burundi', N'BDI')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (20, N'Belgique', N'BEL')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (21, N'Bénin', N'BEN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (22, N'Burkina Faso', N'BFA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (23, N'Bangladesh', N'BGD')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (24, N'Bulgarie', N'BGR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (25, N'Bahreïn', N'BHR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (26, N'Bahamas', N'BHS')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (27, N'Bosnie-Herzégovine', N'BIH')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (28, N'Bélarus', N'BLR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (29, N'Belize', N'BLZ')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (30, N'Bermudes', N'BMU')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (31, N'Bolivie', N'BOL')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (32, N'Brésil', N'BRA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (33, N'Barbade', N'BRB')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (34, N'Brunéi Darussalam', N'BRN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (35, N'Bhoutan', N'BTN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (36, N'Île Bouvet', N'BVT')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (37, N'Botswana', N'BWA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (38, N'République Centrafricaine', N'CAF')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (39, N'Canada', N'CAN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (40, N'Îles Cocos (Keeling)', N'CCK')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (41, N'Suisse', N'CHE')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (42, N'Chili', N'CHL')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (43, N'Chine', N'CHN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (44, N'Côte d''Ivoire', N'CIV')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (45, N'Cameroun', N'CMR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (46, N'République Démocratique du Congo', N'COD')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (47, N'République du Congo', N'COG')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (48, N'Îles Cook', N'COK')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (49, N'Colombie', N'COL')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (50, N'Comores', N'COM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (51, N'Cap-vert', N'CPV')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (52, N'Costa Rica', N'CRI')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (53, N'Cuba', N'CUB')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (54, N'Île Christmas', N'CXR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (55, N'Îles Caïmanes', N'CYM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (56, N'Chypre', N'CYP')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (57, N'République Tchèque', N'CZE')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (58, N'Allemagne', N'DEU')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (59, N'Djibouti', N'DJI')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (60, N'Dominique', N'DMA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (61, N'Danemark', N'DNK')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (62, N'République Dominicaine', N'DOM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (63, N'Algérie', N'DZA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (64, N'Équateur', N'ECU')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (65, N'Égypte', N'EGY')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (66, N'Érythrée', N'ERI')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (67, N'Sahara Occidental', N'ESH')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (68, N'Espagne', N'ESP')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (69, N'Estonie', N'EST')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (70, N'Éthiopie', N'ETH')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (71, N'Finlande', N'FIN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (72, N'Fidji', N'FJI')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (73, N'Îles (malvinas) Falkland', N'FLK')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (74, N'France', N'FRA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (75, N'Îles Féroé', N'FRO')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (76, N'États Fédérés de Micronésie', N'FSM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (77, N'Gabon', N'GAB')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (78, N'Royaume-Uni', N'GBR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (79, N'Géorgie', N'GEO')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (80, N'Ghana', N'GHA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (81, N'Gibraltar', N'GIB')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (82, N'Guinée', N'GIN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (83, N'Guadeloupe', N'GLP')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (84, N'Gambie', N'GMB')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (85, N'Guinée-Bissau', N'GNB')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (86, N'Guinée Équatoriale', N'GNQ')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (87, N'Grèce', N'GRC')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (88, N'Grenade', N'GRD')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (89, N'Groenland', N'GRL')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (90, N'Guatemala', N'GTM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (91, N'Guyane Française', N'GUF')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (92, N'Guam', N'GUM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (93, N'Guyana', N'GUY')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (94, N'Hong-Kong', N'HKG')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (95, N'Îles Heard et Mcdonald', N'HMD')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (96, N'Honduras', N'HND')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (97, N'Croatie', N'HRV')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (98, N'Haïti', N'HTI')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (99, N'Hongrie', N'HUN')
GO
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (100, N'Indonésie', N'IDN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (101, N'Île de Man', N'IMN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (102, N'Inde', N'IND')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (103, N'Territoire Britannique de l''Océan Indien', N'IOT')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (104, N'Irlande', N'IRL')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (105, N'République Islamique d''Iran', N'IRN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (106, N'Iraq', N'IRQ')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (107, N'Islande', N'ISL')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (108, N'Israël', N'ISR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (109, N'Italie', N'ITA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (110, N'Jamaïque', N'JAM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (111, N'Jordanie', N'JOR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (112, N'Japon', N'JPN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (113, N'Kazakhstan', N'KAZ')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (114, N'Kenya', N'KEN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (115, N'Kirghizistan', N'KGZ')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (116, N'Cambodge', N'KHM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (117, N'Kiribati', N'KIR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (118, N'Saint-Kitts-et-Nevis', N'KNA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (119, N'République de Corée', N'KOR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (120, N'Koweït', N'KWT')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (121, N'République Démocratique Populaire Lao', N'LAO')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (122, N'Liban', N'LBN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (123, N'Libéria', N'LBR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (124, N'Jamahiriya Arabe Libyenne', N'LBY')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (125, N'Sainte-Lucie', N'LCA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (126, N'Liechtenstein', N'LIE')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (127, N'Sri Lanka', N'LKA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (128, N'Lesotho', N'LSO')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (129, N'Lituanie', N'LTU')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (130, N'Luxembourg', N'LUX')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (131, N'Lettonie', N'LVA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (132, N'Macao', N'MAC')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (133, N'Maroc', N'MAR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (134, N'Monaco', N'MCO')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (135, N'République de Moldova', N'MDA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (136, N'Madagascar', N'MDG')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (137, N'Maldives', N'MDV')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (138, N'Mexique', N'MEX')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (139, N'Îles Marshall', N'MHL')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (140, N'L''ex-République Yougoslave de Macédoine', N'MKD')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (141, N'Mali', N'MLI')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (142, N'Malte', N'MLT')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (143, N'Myanmar', N'MMR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (144, N'Mongolie', N'MNG')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (145, N'Îles Mariannes du Nord', N'MNP')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (146, N'Mozambique', N'MOZ')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (147, N'Mauritanie', N'MRT')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (148, N'Montserrat', N'MSR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (149, N'Martinique', N'MTQ')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (150, N'Maurice', N'MUS')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (151, N'Malawi', N'MWI')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (152, N'Malaisie', N'MYS')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (153, N'Mayotte', N'MYT')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (154, N'Namibie', N'NAM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (155, N'Nouvelle-Calédonie', N'NCL')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (156, N'Niger', N'NER')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (157, N'Île Norfolk', N'NFK')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (158, N'Nigéria', N'NGA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (159, N'Nicaragua', N'NIC')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (160, N'Niué', N'NIU')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (161, N'Country-Bas', N'NLD')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (162, N'Norvège', N'NOR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (163, N'Népal', N'NPL')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (164, N'Nauru', N'NRU')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (165, N'Nouvelle-Zélande', N'NZL')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (166, N'Oman', N'OMN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (167, N'Pakistan', N'PAK')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (168, N'Panama', N'PAN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (169, N'Pitcairn', N'PCN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (170, N'Pérou', N'PER')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (171, N'Philippines', N'PHL')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (172, N'Palaos', N'PLW')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (173, N'Papouasie-Nouvelle-Guinée', N'PNG')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (174, N'Pologne', N'POL')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (175, N'Porto Rico', N'PRI')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (177, N'Portugal', N'PRT')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (178, N'Paraguay', N'PRY')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (179, N'Territoire Palestinien Occupé', N'PSE')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (180, N'Polynésie Française', N'PYF')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (181, N'Qatar', N'QAT')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (182, N'Réunion', N'REU')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (183, N'Roumanie', N'ROU')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (184, N'Fédération de Russie', N'RUS')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (185, N'Rwanda', N'RWA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (186, N'Arabie Saoudite', N'SAU')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (187, N'Serbie-et-Monténégro', N'SCG')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (188, N'Soudan', N'SDN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (189, N'Sénégal', N'SEN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (190, N'Singapour', N'SGP')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (192, N'Sainte-Hélène', N'SHN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (193, N'Svalbard etÎle Jan Mayen', N'SJM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (194, N'Îles Salomon', N'SLB')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (195, N'Sierra Leone', N'SLE')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (196, N'El Salvador', N'SLV')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (197, N'Saint-Marin', N'SMR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (198, N'Somalie', N'SOM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (199, N'Saint-Pierre-et-Miquelon', N'SPM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (200, N'Sao Tomé-et-Principe', N'STP')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (201, N'Suriname', N'SUR')
GO
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (202, N'Slovaquie', N'SVK')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (203, N'Slovénie', N'SVN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (204, N'Suède', N'SWE')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (205, N'Swaziland', N'SWZ')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (206, N'Seychelles', N'SYC')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (207, N'République Arabe Syrienne', N'SYR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (208, N'Îles Turks et Caïques', N'TCA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (209, N'Tchad', N'TCD')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (210, N'Togo', N'TGO')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (211, N'Thaïlande', N'THA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (212, N'Tadjikistan', N'TJK')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (213, N'Tokelau', N'TKL')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (214, N'Turkménistan', N'TKM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (215, N'Timor-Leste', N'TLS')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (216, N'Tonga', N'TON')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (217, N'Trinité-et-Tobago', N'TTO')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (218, N'Tunisie', N'TUN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (219, N'Turquie', N'TUR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (220, N'Tuvalu', N'TUV')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (221, N'Taïwan', N'TWN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (222, N'République-Unie de Tanzanie', N'TZA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (223, N'Ouganda', N'UGA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (224, N'Ukraine', N'UKR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (225, N'Îles Mineures Éloignées des États-Unis', N'UMI')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (226, N'Uruguay', N'URY')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (227, N'États-Unis', N'USA')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (228, N'Ouzbékistan', N'UZB')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (229, N'Saint-Siège (état de la Cité du Vatican)', N'VAT')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (230, N'Saint-Vincent-et-les Grenadines', N'VCT')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (231, N'Venezuela', N'VEN')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (232, N'Îles Vierges Britanniques', N'VGB')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (233, N'Îles Vierges des États-Unis', N'VIR')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (234, N'Viet Nam', N'VNM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (235, N'Vanuatu', N'VUT')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (236, N'Wallis et Futuna', N'WLF')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (237, N'Samoa', N'WSM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (238, N'Yémen', N'YEM')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (239, N'Afrique du Sud', N'ZAF')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (240, N'Zambie', N'ZMB')
INSERT [dbo].[Country] ([id], [name], [isoCode]) VALUES (241, N'Zimbabwe', N'ZWE')
SET IDENTITY_INSERT [dbo].[Country] OFF
GO
SET IDENTITY_INSERT [dbo].[InterventionsLogs] ON 

INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (1, N'Role                ', N'INSERT', 1)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (2, N'Role                ', N'INSERT', 2)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (3, N'Role                ', N'INSERT', 3)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (4, N'Role                ', N'INSERT', 4)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (5, N'Users               ', N'INSERT', 1)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (6, N'Users               ', N'INSERT', 2)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (7, N'Users               ', N'INSERT', 3)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (8, N'Users               ', N'INSERT', 4)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (9, N'Country             ', N'INSERT', 1)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (10, N'Country             ', N'INSERT', 2)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (11, N'Country             ', N'INSERT', 3)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (12, N'Country             ', N'INSERT', 4)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (13, N'Country             ', N'INSERT', 5)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (14, N'Country             ', N'INSERT', 6)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (15, N'Country             ', N'INSERT', 7)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (16, N'Country             ', N'INSERT', 8)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (17, N'Country             ', N'INSERT', 9)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (18, N'Country             ', N'INSERT', 10)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (19, N'Country             ', N'INSERT', 11)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (20, N'Country             ', N'INSERT', 12)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (21, N'Country             ', N'INSERT', 13)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (22, N'Country             ', N'INSERT', 14)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (23, N'Country             ', N'INSERT', 15)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (24, N'Country             ', N'INSERT', 16)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (25, N'Country             ', N'INSERT', 17)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (26, N'Country             ', N'INSERT', 18)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (27, N'Country             ', N'INSERT', 19)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (28, N'Country             ', N'INSERT', 20)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (29, N'Country             ', N'INSERT', 21)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (30, N'Country             ', N'INSERT', 22)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (31, N'Country             ', N'INSERT', 23)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (32, N'Country             ', N'INSERT', 24)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (33, N'Country             ', N'INSERT', 25)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (34, N'Country             ', N'INSERT', 26)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (35, N'Country             ', N'INSERT', 27)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (36, N'Country             ', N'INSERT', 28)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (37, N'Country             ', N'INSERT', 29)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (38, N'Country             ', N'INSERT', 30)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (39, N'Country             ', N'INSERT', 31)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (40, N'Country             ', N'INSERT', 32)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (41, N'Country             ', N'INSERT', 33)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (42, N'Country             ', N'INSERT', 34)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (43, N'Country             ', N'INSERT', 35)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (44, N'Country             ', N'INSERT', 36)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (45, N'Country             ', N'INSERT', 37)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (46, N'Country             ', N'INSERT', 38)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (47, N'Country             ', N'INSERT', 39)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (48, N'Country             ', N'INSERT', 40)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (49, N'Country             ', N'INSERT', 41)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (50, N'Country             ', N'INSERT', 42)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (51, N'Country             ', N'INSERT', 43)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (52, N'Country             ', N'INSERT', 44)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (53, N'Country             ', N'INSERT', 45)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (54, N'Country             ', N'INSERT', 46)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (55, N'Country             ', N'INSERT', 47)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (56, N'Country             ', N'INSERT', 48)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (57, N'Country             ', N'INSERT', 49)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (58, N'Country             ', N'INSERT', 50)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (59, N'Country             ', N'INSERT', 51)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (60, N'Country             ', N'INSERT', 52)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (61, N'Country             ', N'INSERT', 53)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (62, N'Country             ', N'INSERT', 54)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (63, N'Country             ', N'INSERT', 55)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (64, N'Country             ', N'INSERT', 56)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (65, N'Country             ', N'INSERT', 57)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (66, N'Country             ', N'INSERT', 58)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (67, N'Country             ', N'INSERT', 59)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (68, N'Country             ', N'INSERT', 60)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (69, N'Country             ', N'INSERT', 61)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (70, N'Country             ', N'INSERT', 62)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (71, N'Country             ', N'INSERT', 63)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (72, N'Country             ', N'INSERT', 64)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (73, N'Country             ', N'INSERT', 65)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (74, N'Country             ', N'INSERT', 66)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (75, N'Country             ', N'INSERT', 67)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (76, N'Country             ', N'INSERT', 68)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (77, N'Country             ', N'INSERT', 69)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (78, N'Country             ', N'INSERT', 70)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (79, N'Country             ', N'INSERT', 71)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (80, N'Country             ', N'INSERT', 72)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (81, N'Country             ', N'INSERT', 73)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (82, N'Country             ', N'INSERT', 74)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (83, N'Country             ', N'INSERT', 75)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (84, N'Country             ', N'INSERT', 76)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (85, N'Country             ', N'INSERT', 77)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (86, N'Country             ', N'INSERT', 78)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (87, N'Country             ', N'INSERT', 79)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (88, N'Country             ', N'INSERT', 80)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (89, N'Country             ', N'INSERT', 81)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (90, N'Country             ', N'INSERT', 82)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (91, N'Country             ', N'INSERT', 83)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (92, N'Country             ', N'INSERT', 84)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (93, N'Country             ', N'INSERT', 85)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (94, N'Country             ', N'INSERT', 86)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (95, N'Country             ', N'INSERT', 87)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (96, N'Country             ', N'INSERT', 88)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (97, N'Country             ', N'INSERT', 89)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (98, N'Country             ', N'INSERT', 90)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (99, N'Country             ', N'INSERT', 91)
GO
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (100, N'Country             ', N'INSERT', 92)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (101, N'Country             ', N'INSERT', 93)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (102, N'Country             ', N'INSERT', 94)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (103, N'Country             ', N'INSERT', 95)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (104, N'Country             ', N'INSERT', 96)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (105, N'Country             ', N'INSERT', 97)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (106, N'Country             ', N'INSERT', 98)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (107, N'Country             ', N'INSERT', 99)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (108, N'Country             ', N'INSERT', 100)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (109, N'Country             ', N'INSERT', 101)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (110, N'Country             ', N'INSERT', 102)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (111, N'Country             ', N'INSERT', 103)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (112, N'Country             ', N'INSERT', 104)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (113, N'Country             ', N'INSERT', 105)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (114, N'Country             ', N'INSERT', 106)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (115, N'Country             ', N'INSERT', 107)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (116, N'Country             ', N'INSERT', 108)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (117, N'Country             ', N'INSERT', 109)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (118, N'Country             ', N'INSERT', 110)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (119, N'Country             ', N'INSERT', 111)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (120, N'Country             ', N'INSERT', 112)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (121, N'Country             ', N'INSERT', 113)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (122, N'Country             ', N'INSERT', 114)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (123, N'Country             ', N'INSERT', 115)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (124, N'Country             ', N'INSERT', 116)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (125, N'Country             ', N'INSERT', 117)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (126, N'Country             ', N'INSERT', 118)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (127, N'Country             ', N'INSERT', 119)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (128, N'Country             ', N'INSERT', 120)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (129, N'Country             ', N'INSERT', 121)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (130, N'Country             ', N'INSERT', 122)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (131, N'Country             ', N'INSERT', 123)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (132, N'Country             ', N'INSERT', 124)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (133, N'Country             ', N'INSERT', 125)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (134, N'Country             ', N'INSERT', 126)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (135, N'Country             ', N'INSERT', 127)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (136, N'Country             ', N'INSERT', 128)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (137, N'Country             ', N'INSERT', 129)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (138, N'Country             ', N'INSERT', 130)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (139, N'Country             ', N'INSERT', 131)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (140, N'Country             ', N'INSERT', 132)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (141, N'Country             ', N'INSERT', 133)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (142, N'Country             ', N'INSERT', 134)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (143, N'Country             ', N'INSERT', 135)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (144, N'Country             ', N'INSERT', 136)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (145, N'Country             ', N'INSERT', 137)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (146, N'Country             ', N'INSERT', 138)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (147, N'Country             ', N'INSERT', 139)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (148, N'Country             ', N'INSERT', 140)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (149, N'Country             ', N'INSERT', 141)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (150, N'Country             ', N'INSERT', 142)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (151, N'Country             ', N'INSERT', 143)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (152, N'Country             ', N'INSERT', 144)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (153, N'Country             ', N'INSERT', 145)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (154, N'Country             ', N'INSERT', 146)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (155, N'Country             ', N'INSERT', 147)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (156, N'Country             ', N'INSERT', 148)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (157, N'Country             ', N'INSERT', 149)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (158, N'Country             ', N'INSERT', 150)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (159, N'Country             ', N'INSERT', 151)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (160, N'Country             ', N'INSERT', 152)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (161, N'Country             ', N'INSERT', 153)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (162, N'Country             ', N'INSERT', 154)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (163, N'Country             ', N'INSERT', 155)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (164, N'Country             ', N'INSERT', 156)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (165, N'Country             ', N'INSERT', 157)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (166, N'Country             ', N'INSERT', 158)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (167, N'Country             ', N'INSERT', 159)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (168, N'Country             ', N'INSERT', 160)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (169, N'Country             ', N'INSERT', 161)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (170, N'Country             ', N'INSERT', 162)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (171, N'Country             ', N'INSERT', 163)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (172, N'Country             ', N'INSERT', 164)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (173, N'Country             ', N'INSERT', 165)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (174, N'Country             ', N'INSERT', 166)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (175, N'Country             ', N'INSERT', 167)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (176, N'Country             ', N'INSERT', 168)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (177, N'Country             ', N'INSERT', 169)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (178, N'Country             ', N'INSERT', 170)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (179, N'Country             ', N'INSERT', 171)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (180, N'Country             ', N'INSERT', 172)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (181, N'Country             ', N'INSERT', 173)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (182, N'Country             ', N'INSERT', 174)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (183, N'Country             ', N'INSERT', 175)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (184, N'Country             ', N'INSERT', 177)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (185, N'Country             ', N'INSERT', 178)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (186, N'Country             ', N'INSERT', 179)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (187, N'Country             ', N'INSERT', 180)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (188, N'Country             ', N'INSERT', 181)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (189, N'Country             ', N'INSERT', 182)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (190, N'Country             ', N'INSERT', 183)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (191, N'Country             ', N'INSERT', 184)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (192, N'Country             ', N'INSERT', 185)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (193, N'Country             ', N'INSERT', 186)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (194, N'Country             ', N'INSERT', 187)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (195, N'Country             ', N'INSERT', 188)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (196, N'Country             ', N'INSERT', 189)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (197, N'Country             ', N'INSERT', 190)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (198, N'Country             ', N'INSERT', 192)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (199, N'Country             ', N'INSERT', 193)
GO
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (200, N'Country             ', N'INSERT', 194)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (201, N'Country             ', N'INSERT', 195)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (202, N'Country             ', N'INSERT', 196)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (203, N'Country             ', N'INSERT', 197)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (204, N'Country             ', N'INSERT', 198)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (205, N'Country             ', N'INSERT', 199)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (206, N'Country             ', N'INSERT', 200)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (207, N'Country             ', N'INSERT', 201)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (208, N'Country             ', N'INSERT', 202)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (209, N'Country             ', N'INSERT', 203)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (210, N'Country             ', N'INSERT', 204)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (211, N'Country             ', N'INSERT', 205)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (212, N'Country             ', N'INSERT', 206)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (213, N'Country             ', N'INSERT', 207)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (214, N'Country             ', N'INSERT', 208)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (215, N'Country             ', N'INSERT', 209)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (216, N'Country             ', N'INSERT', 210)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (217, N'Country             ', N'INSERT', 211)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (218, N'Country             ', N'INSERT', 212)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (219, N'Country             ', N'INSERT', 213)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (220, N'Country             ', N'INSERT', 214)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (221, N'Country             ', N'INSERT', 215)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (222, N'Country             ', N'INSERT', 216)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (223, N'Country             ', N'INSERT', 217)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (224, N'Country             ', N'INSERT', 218)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (225, N'Country             ', N'INSERT', 219)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (226, N'Country             ', N'INSERT', 220)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (227, N'Country             ', N'INSERT', 221)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (228, N'Country             ', N'INSERT', 222)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (229, N'Country             ', N'INSERT', 223)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (230, N'Country             ', N'INSERT', 224)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (231, N'Country             ', N'INSERT', 225)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (232, N'Country             ', N'INSERT', 226)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (233, N'Country             ', N'INSERT', 227)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (234, N'Country             ', N'INSERT', 228)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (235, N'Country             ', N'INSERT', 229)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (236, N'Country             ', N'INSERT', 230)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (237, N'Country             ', N'INSERT', 231)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (238, N'Country             ', N'INSERT', 232)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (239, N'Country             ', N'INSERT', 233)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (240, N'Country             ', N'INSERT', 234)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (241, N'Country             ', N'INSERT', 235)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (242, N'Country             ', N'INSERT', 236)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (243, N'Country             ', N'INSERT', 237)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (244, N'Country             ', N'INSERT', 238)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (245, N'Country             ', N'INSERT', 239)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (246, N'Country             ', N'INSERT', 240)
INSERT [dbo].[InterventionsLogs] ([id], [tableName], [operation], [reference]) VALUES (247, N'Country             ', N'INSERT', 241)
SET IDENTITY_INSERT [dbo].[InterventionsLogs] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([id], [libel]) VALUES (1, N'Administrateur')
INSERT [dbo].[Role] ([id], [libel]) VALUES (2, N'Directeur du service Financier')
INSERT [dbo].[Role] ([id], [libel]) VALUES (3, N'Directeur du service Partenariat et Communication')
INSERT [dbo].[Role] ([id], [libel]) VALUES (4, N'Utilisateur')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [login], [password], [role_id]) VALUES (1, N'admin', N'$2a$13$2FttJborJs4im1apbOHHPOQxtsnNsS2OSzt1GhslOWiIalv98iHf.', 1)
INSERT [dbo].[Users] ([id], [login], [password], [role_id]) VALUES (2, N'directFinan', N'$2a$13$V/qJf/pAnkIN5AKYfFU2J.FNVJgnonu4PN1g5bYxWeJHvpOp4d4oO', 2)
INSERT [dbo].[Users] ([id], [login], [password], [role_id]) VALUES (3, N'directPartCom', N'$2a$13$9rNU1AmGgUIETaFrhqWmW.zEf5BLerZjQc/R7ABfJBcYoztkOCwOi', 3)
INSERT [dbo].[Users] ([id], [login], [password], [role_id]) VALUES (4, N'user', N'$2a$13$KScWqv3KmOTrPPWHuE40leubSVu4sdploPn/XkKiZphID7PGQHf.W', 4)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Associations]  WITH CHECK ADD FOREIGN KEY([country_id])
REFERENCES [dbo].[Country] ([id])
GO
ALTER TABLE [dbo].[Associations]  WITH CHECK ADD FOREIGN KEY([mission_id])
REFERENCES [dbo].[Missions] ([id])
GO
ALTER TABLE [dbo].[ChoosenCountryYears]  WITH CHECK ADD FOREIGN KEY([country_id])
REFERENCES [dbo].[Country] ([id])
GO
ALTER TABLE [dbo].[Partnerships]  WITH CHECK ADD FOREIGN KEY([action_id])
REFERENCES [dbo].[Actions] ([id])
GO
ALTER TABLE [dbo].[Partnerships]  WITH CHECK ADD FOREIGN KEY([association_id])
REFERENCES [dbo].[Associations] ([id])
GO
ALTER TABLE [dbo].[Partnerships]  WITH CHECK ADD FOREIGN KEY([country_id])
REFERENCES [dbo].[Country] ([id])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([role_id])
REFERENCES [dbo].[Role] ([id])
GO
/****** Object:  StoredProcedure [dbo].[sp_actions_add]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_actions_add]( @libel varchar(40))
as
begin
	insert into actions(libel) values(@libel)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_actions_delete]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_actions_delete](@id int)
as
begin
	delete from actions where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_actions_getAll]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Actions

create  procedure [dbo].[sp_actions_getAll] 
as
begin
	select * from actions
end
GO
/****** Object:  StoredProcedure [dbo].[sp_actions_getById]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create  procedure [dbo].[sp_actions_getById] (@id int)
as
begin
	select * from actions where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_actions_update]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_actions_update](@id int, @libel varchar(40))
as
begin
	update actions set libel=@libel where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ActionsByAssociation]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_ActionsByAssociation](@idAssociation int)
as
begin
	select distinct libel 
	from Actions 
	join Partnerships on Partnerships.action_id=Actions.id 
	where association_id=@idAssociation ;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_associations_add]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_associations_add]( @name varchar(40),@responsable varchar(40), @mission_id int, @country_id int)
as
begin
	insert into associations(name,responsable,mission_id,country_id) values(@name, @responsable, @mission_id, @country_id)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_associations_delete]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_associations_delete](@id int)
as
begin
	delete from Associations where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_associations_getAll]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Associations

create procedure [dbo].[sp_associations_getAll]
as
begin
	Select * from associations
end
GO
/****** Object:  StoredProcedure [dbo].[sp_associations_getById]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_associations_getById](@id int)
as
begin
	Select * from associations where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_associations_update]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_associations_update](@id int, @name varchar(40), @responsable varchar(40), @mission_id int, @country_id int)
as
begin
	update associations set name=@name,responsable=@responsable, mission_id=@mission_id, country_id=@country_id where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_choosenCountryYears_add]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_choosenCountryYears_add](@country_id int, @choosenYear int,@plafond float)
as
begin
	insert into ChoosenCountryYears values(@country_id,@choosenYear,@plafond)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_choosenCountryYears_delete]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_choosenCountryYears_delete](@country_id int, @choosenYear int)
as
begin
	delete from ChoosenCountryYears where country_id=@country_id and choosenYear=@choosenYear
end
GO
/****** Object:  StoredProcedure [dbo].[sp_choosenCountryYears_getAll]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ChoosenCountryYears
create procedure [dbo].[sp_choosenCountryYears_getAll]
as
begin
	Select * from ChoosenCountryYears
end
GO
/****** Object:  StoredProcedure [dbo].[sp_choosenCountryYears_getByYear]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_choosenCountryYears_getByYear] (@choosenYear int)
as
begin
	Select * from ChoosenCountryYears where choosenYear=@choosenYear
end
GO
/****** Object:  StoredProcedure [dbo].[sp_choosenCountryYears_update]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_choosenCountryYears_update](@oldcountry_id int,@newcountry_id int,  @oldChoosenYear int, @newChoosenYear int, @plafond float)
as
begin
	update ChoosenCountryYears set choosenYear=@newChoosenYear,country_id=@newcountry_id, plafond=@plafond where country_id=@oldcountry_id and choosenYear=@oldChoosenYear
end
GO
/****** Object:  StoredProcedure [dbo].[sp_country_add]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create  procedure [dbo].[sp_country_add] ( @name varchar(40), @isoCode varchar(3))
as
begin
	insert into country(name,isoCode) values(@name,@isoCode)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_country_delete]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create  procedure [dbo].[sp_country_delete] (@id int)
as
begin
	delete from country where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_country_getAll]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Country

create  procedure [dbo].[sp_country_getAll]
as
begin
	select * from country
end
GO
/****** Object:  StoredProcedure [dbo].[sp_country_getById]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create  procedure [dbo].[sp_country_getById] (@id int)
as
begin
	select * from country where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_country_getByIsoCode]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create  procedure [dbo].[sp_country_getByIsoCode] (@isoCode varchar(3))
as
begin
	select * from country where isoCode = @isoCode
end
GO
/****** Object:  StoredProcedure [dbo].[sp_country_update]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create  procedure [dbo].[sp_country_update] (@id int, @name varchar(40), @isoCode varchar(3))
as
begin
	update country set name=@name , isoCode=@isoCode where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_interventionLogs_add]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_interventionLogs_add](@tableName varchar(40), @operation varchar(6), @reference int)
as
begin
	Insert into InterventionsLogs(tableName,operation,reference) values (@tableName, @operation, @reference)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_interventionLogs_getAll]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- InterventionsLogs

create procedure [dbo].[sp_interventionLogs_getAll]
as
begin
	Select * from InterventionsLogs
end
GO
/****** Object:  StoredProcedure [dbo].[sp_interventionLogs_getById]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_interventionLogs_getById](@id int)
as
begin
	Select * from InterventionsLogs where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_interventionLogs_getByOperation]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_interventionLogs_getByOperation](@operation varchar(6))
as
begin
	Select * from InterventionsLogs where operation=@operation
end
GO
/****** Object:  StoredProcedure [dbo].[sp_interventionLogs_getByReference]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_interventionLogs_getByReference](@reference int)
as
begin
	Select * from InterventionsLogs where reference=@reference
end
GO
/****** Object:  StoredProcedure [dbo].[sp_interventionLogs_getByTableName]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_interventionLogs_getByTableName](@tableName varchar(40))
as
begin
	Select * from InterventionsLogs where tableName=@tableName
end
GO
/****** Object:  StoredProcedure [dbo].[sp_missions_add]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_missions_add](@libel varchar(40))
as
begin
	Insert into Missions(libel) values (@libel)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_missions_delete]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_missions_delete](@id int)
as
begin
	delete from Missions where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_missions_getAll]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Missions

create procedure [dbo].[sp_missions_getAll]
as
begin
	Select * from Missions
end
GO
/****** Object:  StoredProcedure [dbo].[sp_missions_getById]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_missions_getById](@id int)
as
begin
	Select * from Missions where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_missions_update]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_missions_update](@id int, @libel varchar(40))
as
begin
	update Missions set libel=@libel where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_nbAssociationByCountry]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Indicateurs

create procedure [dbo].[sp_nbAssociationByCountry]
as
begin
	select country.name,count(country_id) as Number from Country 
	join Associations on country_id = Country.id
	group by Country.name
	having count(country_id) > 0
end
GO
/****** Object:  StoredProcedure [dbo].[sp_nbPartnershipsByActionByYear]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_nbPartnershipsByActionByYear]
as
begin
	select libel,ChoosenCountryYears.choosenYear as year,count(Partnerships.id) as nbPartnerships
	from Partnerships
	join Actions on action_id=Actions.id
	join Country on Country.id = country_id
	join ChoosenCountryYears on Country.id=ChoosenCountryYears.country_id
	group by libel,ChoosenCountryYears.choosenYear
end
GO
/****** Object:  StoredProcedure [dbo].[sp_partnerships_add]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_partnerships_add](@action_id int, @association_id int, @country_id int)
as
begin
	insert into Partnerships(date, action_id, association_id, country_id) values(getdate(), @action_id, @association_id, @country_id)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_partnerships_delete]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_partnerships_delete](@id int)
as
begin
	delete from Partnerships where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_partnerships_getAll]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Partnerships

create procedure [dbo].[sp_partnerships_getAll]
as
begin
	Select * from Partnerships
end
GO
/****** Object:  StoredProcedure [dbo].[sp_partnerships_getByActionId]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_partnerships_getByActionId](@action_id int)
as
begin
	Select * from Partnerships where action_id=@action_id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_partnerships_getByAssociationId]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_partnerships_getByAssociationId](@association_id int)
as
begin
	Select * from Partnerships where association_id=@association_id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_partnerships_getByCountryId]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_partnerships_getByCountryId](@country_id int)
as
begin
	Select * from Partnerships where country_id=@country_id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_partnerships_getById]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_partnerships_getById](@id int)
as
begin
	Select * from Partnerships where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_partnerships_update]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_partnerships_update](@id int,@action_id int, @association_id int, @country_id int)
as
begin
	update Partnerships set  action_id=@action_id, association_id=@association_id, country_id=@country_id where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_partnerships_updateForecastBudget]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_partnerships_updateForecastBudget](@id int,@forecastBudget float)
as
begin
	update Partnerships set  forecastBudget=@forecastBudget where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_partnerships_updateRealBudget]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_partnerships_updateRealBudget](@id int,@realBudget float)
as
begin
	update Partnerships set  realBudget=@realBudget where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_role_add]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_role_add](@libel varchar(40))
as
begin
	insert into Role(libel) values(@libel)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_role_delete]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_role_delete](@id int)
as
begin
	delete from role where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_role_getAll]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Role
create procedure [dbo].[sp_role_getAll]
as
begin
	Select * from Role
end
GO
/****** Object:  StoredProcedure [dbo].[sp_role_getById]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_role_getById](@id int)
as
begin
	Select * from Role where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_role_update]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_role_update](@id int, @libel varchar(40))
as
begin
	update Role set libel=@libel where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_users_delete]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_users_delete](@id int)
as
begin
	delete from Users where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_users_getAll]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Users 

create procedure [dbo].[sp_users_getAll]
as
begin
	Select * from Users
end
GO
/****** Object:  StoredProcedure [dbo].[sp_users_getbyId]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_users_getbyId](@id int)
as
begin
	Select * from Users where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_users_getByLogin]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_users_getByLogin](@login varchar(40))
as
begin
	Select * from Users  where login=@login
end
GO
/****** Object:  StoredProcedure [dbo].[sp_users_resetPassword]    Script Date: 10/12/2024 08:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_users_resetPassword](@id int,@password varchar(120))
as
begin
	update Users set password = @password where id = @id
end
GO
USE [master]
GO
ALTER DATABASE [ProGestion] SET  READ_WRITE 
GO
