ALTER DATABASE [ProjectManagerDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectManagerDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjectManagerDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectManagerDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjectManagerDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjectManagerDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjectManagerDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET RECOVERY FULL 
GO
ALTER DATABASE [ProjectManagerDB] SET  MULTI_USER 
GO
ALTER DATABASE [ProjectManagerDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjectManagerDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjectManagerDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjectManagerDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProjectManagerDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProjectManagerDB', N'ON'
GO
ALTER DATABASE [ProjectManagerDB] SET QUERY_STORE = OFF
GO
USE [ProjectManagerDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/22/2020 5:57:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[Actividad]    Script Date: 8/22/2020 5:57:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actividad](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
	[Tipo] [int] NOT NULL,
	[Nota] [float] NOT NULL,
	[ProyectoCodigo] [int] NULL,
 CONSTRAINT [PK_Actividad] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documento]    Script Date: 8/22/2020 5:57:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documento](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Ruta] [nvarchar](max) NULL,
	[Descripcion] [nvarchar](max) NULL,
	[ProyectoCodigo] [int] NULL,
 CONSTRAINT [PK_Documento] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 8/22/2020 5:57:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[Identificacion] [nvarchar](25) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](100) NULL,
	[Rol] [nvarchar](10) NULL,
	[Programa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[Identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proyecto]    Script Date: 8/22/2020 5:57:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proyecto](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](500) NULL,
	[Tipo] [nvarchar](50) NULL,
	[Estado] [nvarchar](10) NULL,
	[Tutor] [int] NOT NULL,
	[Equipo] [int] NOT NULL,
 CONSTRAINT [PK_Proyecto] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarea]    Script Date: 8/22/2020 5:57:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarea](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](500) NULL,
	[Fecha] [datetime] NOT NULL,
	[Estado] [nvarchar](10) NULL,
	[Proyecto] [int] NOT NULL,
 CONSTRAINT [PK_Tarea] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200822181324_InitialCreation', N'3.1.7')
GO
INSERT [dbo].[Persona] ([Identificacion], [Nombre], [Apellido], [Rol], [Programa]) VALUES (N'12465', N'Juan', N'Perez', N'Profesor', NULL)
INSERT [dbo].[Persona] ([Identificacion], [Nombre], [Apellido], [Rol], [Programa]) VALUES (N'4564', N'Pepito', N'Perez', N'Estudiante', N'Ingenieria Informatica')
GO
SET IDENTITY_INSERT [dbo].[Proyecto] ON 

INSERT [dbo].[Proyecto] ([Codigo], [Nombre], [Descripcion], [Tipo], [Estado], [Tutor], [Equipo]) VALUES (1, N'Despulpadora de Huevo', N'Despulpadora de Huevo', N'Investigacion', N'Inscrito', 12465, 1)
INSERT [dbo].[Proyecto] ([Codigo], [Nombre], [Descripcion], [Tipo], [Estado], [Tutor], [Equipo]) VALUES (4, N'Control de Costos', N'Control de Costos', N'Investigacion', N'Inscrito', 12465, 2)
SET IDENTITY_INSERT [dbo].[Proyecto] OFF
GO
SET IDENTITY_INSERT [dbo].[Tarea] ON 

INSERT [dbo].[Tarea] ([Codigo], [Nombre], [Descripcion], [Fecha], [Estado], [Proyecto]) VALUES (2, N'Marco Teorico', N'Marco Teorico', CAST(N'2020-08-22T00:00:00.000' AS DateTime), N'Presentada', 1)
SET IDENTITY_INSERT [dbo].[Tarea] OFF
GO
/****** Object:  Index [IX_Actividad_ProyectoCodigo]    Script Date: 8/22/2020 5:57:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Actividad_ProyectoCodigo] ON [dbo].[Actividad]
(
	[ProyectoCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Documento_ProyectoCodigo]    Script Date: 8/22/2020 5:57:44 PM ******/
CREATE NONCLUSTERED INDEX [IX_Documento_ProyectoCodigo] ON [dbo].[Documento]
(
	[ProyectoCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Actividad]  WITH CHECK ADD  CONSTRAINT [FK_Actividad_Proyecto_ProyectoCodigo] FOREIGN KEY([ProyectoCodigo])
REFERENCES [dbo].[Proyecto] ([Codigo])
GO
ALTER TABLE [dbo].[Actividad] CHECK CONSTRAINT [FK_Actividad_Proyecto_ProyectoCodigo]
GO
ALTER TABLE [dbo].[Documento]  WITH CHECK ADD  CONSTRAINT [FK_Documento_Proyecto_ProyectoCodigo] FOREIGN KEY([ProyectoCodigo])
REFERENCES [dbo].[Proyecto] ([Codigo])
GO
ALTER TABLE [dbo].[Documento] CHECK CONSTRAINT [FK_Documento_Proyecto_ProyectoCodigo]
GO
USE [master]
GO
ALTER DATABASE [ProjectManagerDB] SET  READ_WRITE 
GO
