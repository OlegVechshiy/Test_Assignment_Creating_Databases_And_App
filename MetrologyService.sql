USE [master]
GO
/****** Object:  Database [MetrologyService]    Script Date: 27.12.2024 17:15:59 ******/
CREATE DATABASE [MetrologyService]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MetrologyService', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\MetrologyService.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MetrologyService_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\MetrologyService_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MetrologyService] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MetrologyService].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MetrologyService] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MetrologyService] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MetrologyService] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MetrologyService] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MetrologyService] SET ARITHABORT OFF 
GO
ALTER DATABASE [MetrologyService] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MetrologyService] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MetrologyService] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MetrologyService] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MetrologyService] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MetrologyService] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MetrologyService] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MetrologyService] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MetrologyService] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MetrologyService] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MetrologyService] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MetrologyService] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MetrologyService] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MetrologyService] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MetrologyService] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MetrologyService] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MetrologyService] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MetrologyService] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MetrologyService] SET  MULTI_USER 
GO
ALTER DATABASE [MetrologyService] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MetrologyService] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MetrologyService] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MetrologyService] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MetrologyService] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MetrologyService] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MetrologyService] SET QUERY_STORE = ON
GO
ALTER DATABASE [MetrologyService] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MetrologyService]
GO
/****** Object:  Table [dbo].[ВЫДАЧА]    Script Date: 27.12.2024 17:15:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ВЫДАЧА](
	[ID_выдачи] [int] IDENTITY(1,1) NOT NULL,
	[ID_инструмента] [int] NOT NULL,
	[ID_подразделения] [int] NOT NULL,
	[Дата_выдачи] [date] NOT NULL,
 CONSTRAINT [PK_ВЫДАЧА] PRIMARY KEY CLUSTERED 
(
	[ID_выдачи] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ]    Script Date: 27.12.2024 17:15:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ](
	[ID_инструмента] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](100) NOT NULL,
	[Номер] [nvarchar](50) NOT NULL,
	[Вид] [nvarchar](50) NOT NULL,
	[Частота_калибровки] [int] NOT NULL,
 CONSTRAINT [PK_ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ] PRIMARY KEY CLUSTERED 
(
	[ID_инструмента] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[КАЛИБРОВКА]    Script Date: 27.12.2024 17:15:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[КАЛИБРОВКА](
	[ID_калибровки] [int] IDENTITY(1,1) NOT NULL,
	[ID_инструмента] [int] NOT NULL,
	[Дата_калибровки] [date] NOT NULL,
 CONSTRAINT [PK_КАЛИБРОВКА] PRIMARY KEY CLUSTERED 
(
	[ID_калибровки] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ПОДРАЗДЕЛЕНИЯ]    Script Date: 27.12.2024 17:15:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ПОДРАЗДЕЛЕНИЯ](
	[ID_подразделения] [int] IDENTITY(1,1) NOT NULL,
	[Название] [nvarchar](100) NOT NULL,
	[ФИОМОЛ] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_ПОДРАЗДЕЛЕНИЯ] PRIMARY KEY CLUSTERED 
(
	[ID_подразделения] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ПРИЕМКА]    Script Date: 27.12.2024 17:15:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ПРИЕМКА](
	[ID_приемки] [int] IDENTITY(1,1) NOT NULL,
	[ID_инструмента] [int] NOT NULL,
	[ID_подразделения] [int] NOT NULL,
	[Дата_приемки] [date] NOT NULL,
 CONSTRAINT [PK_ПРИЕМКА] PRIMARY KEY CLUSTERED 
(
	[ID_приемки] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[СПИСАНИЕ]    Script Date: 27.12.2024 17:15:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[СПИСАНИЕ](
	[ID_списания] [int] IDENTITY(1,1) NOT NULL,
	[ID_инструмента] [int] NOT NULL,
	[Дата_списания] [date] NOT NULL,
 CONSTRAINT [PK_СПИСАНИЕ] PRIMARY KEY CLUSTERED 
(
	[ID_списания] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ВЫДАЧА]  WITH CHECK ADD  CONSTRAINT [FK_ВЫДАЧА_ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ] FOREIGN KEY([ID_инструмента])
REFERENCES [dbo].[ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ] ([ID_инструмента])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ВЫДАЧА] CHECK CONSTRAINT [FK_ВЫДАЧА_ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ]
GO
ALTER TABLE [dbo].[ВЫДАЧА]  WITH CHECK ADD  CONSTRAINT [FK_ВЫДАЧА_ПОДРАЗДЕЛЕНИЯ] FOREIGN KEY([ID_подразделения])
REFERENCES [dbo].[ПОДРАЗДЕЛЕНИЯ] ([ID_подразделения])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ВЫДАЧА] CHECK CONSTRAINT [FK_ВЫДАЧА_ПОДРАЗДЕЛЕНИЯ]
GO
ALTER TABLE [dbo].[КАЛИБРОВКА]  WITH CHECK ADD  CONSTRAINT [FK_КАЛИБРОВКА_ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ] FOREIGN KEY([ID_инструмента])
REFERENCES [dbo].[ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ] ([ID_инструмента])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[КАЛИБРОВКА] CHECK CONSTRAINT [FK_КАЛИБРОВКА_ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ]
GO
ALTER TABLE [dbo].[ПРИЕМКА]  WITH CHECK ADD  CONSTRAINT [FK_ПРИЕМКА_ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ] FOREIGN KEY([ID_инструмента])
REFERENCES [dbo].[ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ] ([ID_инструмента])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ПРИЕМКА] CHECK CONSTRAINT [FK_ПРИЕМКА_ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ]
GO
ALTER TABLE [dbo].[ПРИЕМКА]  WITH CHECK ADD  CONSTRAINT [FK_ПРИЕМКА_ПОДРАЗДЕЛЕНИЯ] FOREIGN KEY([ID_подразделения])
REFERENCES [dbo].[ПОДРАЗДЕЛЕНИЯ] ([ID_подразделения])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ПРИЕМКА] CHECK CONSTRAINT [FK_ПРИЕМКА_ПОДРАЗДЕЛЕНИЯ]
GO
ALTER TABLE [dbo].[СПИСАНИЕ]  WITH CHECK ADD  CONSTRAINT [FK_СПИСАНИЕ_ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ] FOREIGN KEY([ID_инструмента])
REFERENCES [dbo].[ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ] ([ID_инструмента])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[СПИСАНИЕ] CHECK CONSTRAINT [FK_СПИСАНИЕ_ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Уникальный идентификатор выдачи измерительного инструмента' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ВЫДАЧА', @level2type=N'COLUMN',@level2name=N'ID_выдачи'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Идентификатор инструмента из таблицы ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ВЫДАЧА', @level2type=N'COLUMN',@level2name=N'ID_инструмента'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Идентификатор подразделения из таблицы ПОДРАЗДЕЛЕНИЯ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ВЫДАЧА', @level2type=N'COLUMN',@level2name=N'ID_подразделения'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата выдачи измерительного инструмента' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ВЫДАЧА', @level2type=N'COLUMN',@level2name=N'Дата_выдачи'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Уникальный идентификатор измерительного инструмента' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ', @level2type=N'COLUMN',@level2name=N'ID_инструмента'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Наименование измерительного инструмента' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ', @level2type=N'COLUMN',@level2name=N'Наименование'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер измерительного инструмента' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ', @level2type=N'COLUMN',@level2name=N'Номер'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Вид измерительного инструмента' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ', @level2type=N'COLUMN',@level2name=N'Вид'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Частота калибровки измерительного инструмента' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ', @level2type=N'COLUMN',@level2name=N'Частота_калибровки'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Уникальный идентификатор калибровки измерительного инструмента' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'КАЛИБРОВКА', @level2type=N'COLUMN',@level2name=N'ID_калибровки'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Идентификатор инструмента из таблицы ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'КАЛИБРОВКА', @level2type=N'COLUMN',@level2name=N'ID_инструмента'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата калибровки измерительного инструмента' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'КАЛИБРОВКА', @level2type=N'COLUMN',@level2name=N'Дата_калибровки'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Уникальный идентификатор подразделения' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ПОДРАЗДЕЛЕНИЯ', @level2type=N'COLUMN',@level2name=N'ID_подразделения'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Название подразделения' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ПОДРАЗДЕЛЕНИЯ', @level2type=N'COLUMN',@level2name=N'Название'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ФИО МОЛ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ПОДРАЗДЕЛЕНИЯ', @level2type=N'COLUMN',@level2name=N'ФИОМОЛ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Уникальный идентификатор приемки измерительного инструмента' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ПРИЕМКА', @level2type=N'COLUMN',@level2name=N'ID_приемки'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Идентификатор инструмента из таблицы ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ПРИЕМКА', @level2type=N'COLUMN',@level2name=N'ID_инструмента'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Идентификатор инструмента из таблицы ПОДРАЗДЕЛЕНИЯ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ПРИЕМКА', @level2type=N'COLUMN',@level2name=N'ID_подразделения'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата приемки измерительного инструмента' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ПРИЕМКА', @level2type=N'COLUMN',@level2name=N'Дата_приемки'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Уникальный идентификатор списания измерительного инструмента' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'СПИСАНИЕ', @level2type=N'COLUMN',@level2name=N'ID_списания'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Идентификатор инструмента из таблицы ИЗМЕРИТЕЛЬНЫЙ_ИНСТРУМЕНТ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'СПИСАНИЕ', @level2type=N'COLUMN',@level2name=N'ID_инструмента'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата списывания неподлежащего восстановлению измерительного инструмента' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'СПИСАНИЕ', @level2type=N'COLUMN',@level2name=N'Дата_списания'
GO
USE [master]
GO
ALTER DATABASE [MetrologyService] SET  READ_WRITE 
GO
