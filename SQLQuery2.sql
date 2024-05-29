USE [master]
GO
/****** Object:  Database [RepairOfRoads]    Script Date: 29.05.2024 8:27:41 ******/
CREATE DATABASE [RepairOfRoads]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RepairOfRoads', FILENAME = N'D:\Microsoft Sql Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RepairOfRoads.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RepairOfRoads_log', FILENAME = N'D:\Microsoft Sql Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RepairOfRoads_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [RepairOfRoads] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RepairOfRoads].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RepairOfRoads] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RepairOfRoads] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RepairOfRoads] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RepairOfRoads] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RepairOfRoads] SET ARITHABORT OFF 
GO
ALTER DATABASE [RepairOfRoads] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RepairOfRoads] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RepairOfRoads] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RepairOfRoads] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RepairOfRoads] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RepairOfRoads] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RepairOfRoads] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RepairOfRoads] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RepairOfRoads] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RepairOfRoads] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RepairOfRoads] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RepairOfRoads] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RepairOfRoads] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RepairOfRoads] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RepairOfRoads] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RepairOfRoads] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RepairOfRoads] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RepairOfRoads] SET RECOVERY FULL 
GO
ALTER DATABASE [RepairOfRoads] SET  MULTI_USER 
GO
ALTER DATABASE [RepairOfRoads] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RepairOfRoads] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RepairOfRoads] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RepairOfRoads] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RepairOfRoads] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RepairOfRoads] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'RepairOfRoads', N'ON'
GO
ALTER DATABASE [RepairOfRoads] SET QUERY_STORE = ON
GO
ALTER DATABASE [RepairOfRoads] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [RepairOfRoads]
GO
/****** Object:  Table [dbo].[Materials]    Script Date: 29.05.2024 8:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materials](
	[idmaterials] [int] IDENTITY(1,1) NOT NULL,
	[nameMaterials] [nvarchar](max) NOT NULL,
	[countMaterials] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idmaterials] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaterialsTask]    Script Date: 29.05.2024 8:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialsTask](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idTask] [int] NULL,
	[idmaterials] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requests]    Script Date: 29.05.2024 8:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requests](
	[idrequests] [int] IDENTITY(1,1) NOT NULL,
	[problemName] [nvarchar](max) NOT NULL,
	[idStatus] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idrequests] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 29.05.2024 8:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[idrole] [int] IDENTITY(1,1) NOT NULL,
	[namerole] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idrole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusRequest]    Script Date: 29.05.2024 8:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusRequest](
	[idstatus] [int] IDENTITY(1,1) NOT NULL,
	[namestatus] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idstatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusTask]    Script Date: 29.05.2024 8:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusTask](
	[idstatus] [int] IDENTITY(1,1) NOT NULL,
	[namestatus] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idstatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 29.05.2024 8:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[idTask] [int] IDENTITY(1,1) NOT NULL,
	[problemName] [nvarchar](max) NOT NULL,
	[dateStart] [date] NOT NULL,
	[dateEnd] [date] NOT NULL,
	[idStatus] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idTask] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 29.05.2024 8:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[iduser] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
	[idrole] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[iduser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersTask]    Script Date: 29.05.2024 8:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersTask](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idTask] [int] NULL,
	[idUser] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Materials] ON 
GO
INSERT [dbo].[Materials] ([idmaterials], [nameMaterials], [countMaterials]) VALUES (1, N'Асфальт', N'от 50 до 100 тонн на 1 км')
GO
INSERT [dbo].[Materials] ([idmaterials], [nameMaterials], [countMaterials]) VALUES (2, N'Битум', N'5-10 тонн на 1 км дороги')
GO
INSERT [dbo].[Materials] ([idmaterials], [nameMaterials], [countMaterials]) VALUES (3, N'Щебень', N'200-300 тонн на 1 км дороги')
GO
INSERT [dbo].[Materials] ([idmaterials], [nameMaterials], [countMaterials]) VALUES (4, N'Песок', N'50-100 тонн на 1 км дороги')
GO
INSERT [dbo].[Materials] ([idmaterials], [nameMaterials], [countMaterials]) VALUES (5, N'Краска для разметки', N'100-200 литров на 1 км дороги')
GO
SET IDENTITY_INSERT [dbo].[Materials] OFF
GO
SET IDENTITY_INSERT [dbo].[MaterialsTask] ON 
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (1, 1, 1)
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (2, 1, 2)
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (3, 1, 3)
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (4, 1, 4)
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (5, 1, 5)
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (6, 2, 1)
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (7, 2, 2)
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (8, 2, 3)
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (9, 2, 4)
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (10, 2, 5)
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (11, 3, 1)
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (12, 3, 2)
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (13, 3, 3)
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (14, 3, 4)
GO
INSERT [dbo].[MaterialsTask] ([id], [idTask], [idmaterials]) VALUES (15, 3, 5)
GO
SET IDENTITY_INSERT [dbo].[MaterialsTask] OFF
GO
SET IDENTITY_INSERT [dbo].[Requests] ON 
GO
INSERT [dbo].[Requests] ([idrequests], [problemName], [idStatus]) VALUES (1, N'Участок дороги по ул. Ленина от ул. Советская до ул. Парковая находится в неудовлетворительном состоянии. На протяжении всего участка имеются множественные ямы, выбоины и трещины в асфальтовом покрытии', 1)
GO
INSERT [dbo].[Requests] ([idrequests], [problemName], [idStatus]) VALUES (2, N'На пересечении ул. Мира и ул. Победы образовался значительный перепад высот между асфальтовым покрытием и бордюрами, что затрудняет проезд и представляет опасность для маломобильных групп населения. ', 2)
GO
INSERT [dbo].[Requests] ([idrequests], [problemName], [idStatus]) VALUES (3, N'Дорожное полотно на ул. Садовой, от д.7 до д.15, сильно разрушено, имеются многочисленные трещины и выбоины. ', 2)
GO
INSERT [dbo].[Requests] ([idrequests], [problemName], [idStatus]) VALUES (4, N' Во время дождя на ул. Октябрьской образуются обширные участки скопления воды, что затрудняет проезд автомобилей и создает угрозу возникновения ДТП. ', 1)
GO
INSERT [dbo].[Requests] ([idrequests], [problemName], [idStatus]) VALUES (5, N'Многочисленные трещины и ямы на ул. Комсомольской, особенно вблизи пешеходных переходов, представляют опасность для пешеходов. ', 1)
GO
SET IDENTITY_INSERT [dbo].[Requests] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
GO
INSERT [dbo].[Roles] ([idrole], [namerole]) VALUES (1, N'Пользователь')
GO
INSERT [dbo].[Roles] ([idrole], [namerole]) VALUES (2, N'Специалист')
GO
INSERT [dbo].[Roles] ([idrole], [namerole]) VALUES (3, N'Администратор')
GO
INSERT [dbo].[Roles] ([idrole], [namerole]) VALUES (4, N'Менеджер')
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[StatusRequest] ON 
GO
INSERT [dbo].[StatusRequest] ([idstatus], [namestatus]) VALUES (1, N'Принята')
GO
INSERT [dbo].[StatusRequest] ([idstatus], [namestatus]) VALUES (2, N'Отклонена')
GO
SET IDENTITY_INSERT [dbo].[StatusRequest] OFF
GO
SET IDENTITY_INSERT [dbo].[StatusTask] ON 
GO
INSERT [dbo].[StatusTask] ([idstatus], [namestatus]) VALUES (1, N'Новая задача')
GO
INSERT [dbo].[StatusTask] ([idstatus], [namestatus]) VALUES (2, N'В процессе ремонта')
GO
INSERT [dbo].[StatusTask] ([idstatus], [namestatus]) VALUES (3, N'Готова к эксплуатации')
GO
SET IDENTITY_INSERT [dbo].[StatusTask] OFF
GO
SET IDENTITY_INSERT [dbo].[Task] ON 
GO
INSERT [dbo].[Task] ([idTask], [problemName], [dateStart], [dateEnd], [idStatus]) VALUES (1, N'Участок дороги по ул. Ленина от ул. Советская до ул. Парковая находится в неудовлетворительном состоянии. На протяжении всего участка имеются множественные ямы, выбоины и трещины в асфальтовом покрытии', CAST(N'2024-05-31' AS Date), CAST(N'2024-06-21' AS Date), 1)
GO
INSERT [dbo].[Task] ([idTask], [problemName], [dateStart], [dateEnd], [idStatus]) VALUES (2, N' Во время дождя на ул. Октябрьской образуются обширные участки скопления воды, что затрудняет проезд автомобилей и создает угрозу возникновения ДТП. ', CAST(N'2024-07-05' AS Date), CAST(N'2024-08-10' AS Date), 1)
GO
INSERT [dbo].[Task] ([idTask], [problemName], [dateStart], [dateEnd], [idStatus]) VALUES (3, N'Многочисленные трещины и ямы на ул. Комсомольской, особенно вблизи пешеходных переходов, представляют опасность для пешеходов. ', CAST(N'2024-04-20' AS Date), CAST(N'2024-05-31' AS Date), 1)
GO
SET IDENTITY_INSERT [dbo].[Task] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([iduser], [login], [password], [idrole]) VALUES (1, N'login1', N'pass1', 1)
GO
INSERT [dbo].[Users] ([iduser], [login], [password], [idrole]) VALUES (2, N'login2', N'pass2', 2)
GO
INSERT [dbo].[Users] ([iduser], [login], [password], [idrole]) VALUES (3, N'login3', N'pass3', 3)
GO
INSERT [dbo].[Users] ([iduser], [login], [password], [idrole]) VALUES (4, N'login4', N'pass4', 4)
GO
INSERT [dbo].[Users] ([iduser], [login], [password], [idrole]) VALUES (5, N'login6', N'pass6', 2)
GO
INSERT [dbo].[Users] ([iduser], [login], [password], [idrole]) VALUES (6, N'login7', N'pass7', 2)
GO
INSERT [dbo].[Users] ([iduser], [login], [password], [idrole]) VALUES (7, N'login8', N'pass8', 2)
GO
INSERT [dbo].[Users] ([iduser], [login], [password], [idrole]) VALUES (8, N'login5', N'pass5', 2)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[UsersTask] ON 
GO
INSERT [dbo].[UsersTask] ([id], [idTask], [idUser]) VALUES (1, 1, 2)
GO
INSERT [dbo].[UsersTask] ([id], [idTask], [idUser]) VALUES (2, 1, 5)
GO
INSERT [dbo].[UsersTask] ([id], [idTask], [idUser]) VALUES (3, 1, 7)
GO
INSERT [dbo].[UsersTask] ([id], [idTask], [idUser]) VALUES (4, 2, 6)
GO
INSERT [dbo].[UsersTask] ([id], [idTask], [idUser]) VALUES (5, 2, 8)
GO
INSERT [dbo].[UsersTask] ([id], [idTask], [idUser]) VALUES (6, 2, 2)
GO
INSERT [dbo].[UsersTask] ([id], [idTask], [idUser]) VALUES (7, 3, 5)
GO
INSERT [dbo].[UsersTask] ([id], [idTask], [idUser]) VALUES (8, 3, 8)
GO
SET IDENTITY_INSERT [dbo].[UsersTask] OFF
GO
ALTER TABLE [dbo].[MaterialsTask]  WITH CHECK ADD FOREIGN KEY([idmaterials])
REFERENCES [dbo].[Materials] ([idmaterials])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MaterialsTask]  WITH CHECK ADD FOREIGN KEY([idTask])
REFERENCES [dbo].[Task] ([idTask])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD FOREIGN KEY([idStatus])
REFERENCES [dbo].[StatusRequest] ([idstatus])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK__Task__idStatus__4316F928] FOREIGN KEY([idStatus])
REFERENCES [dbo].[StatusTask] ([idstatus])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK__Task__idStatus__4316F928]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([idrole])
REFERENCES [dbo].[Roles] ([idrole])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UsersTask]  WITH CHECK ADD FOREIGN KEY([idTask])
REFERENCES [dbo].[Task] ([idTask])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UsersTask]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [dbo].[Users] ([iduser])
ON UPDATE CASCADE
GO
USE [master]
GO
ALTER DATABASE [RepairOfRoads] SET  READ_WRITE 
GO
