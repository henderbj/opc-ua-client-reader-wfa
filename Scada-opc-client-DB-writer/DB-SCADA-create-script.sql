USE [master]
GO
/****** Object:  Database [SCADA]    Script Date: 18.05.2026 14:21:55 ******/
CREATE DATABASE [SCADA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SCADA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SCADA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SCADA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SCADA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SCADA] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SCADA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SCADA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SCADA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SCADA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SCADA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SCADA] SET ARITHABORT OFF 
GO
ALTER DATABASE [SCADA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SCADA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SCADA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SCADA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SCADA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SCADA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SCADA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SCADA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SCADA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SCADA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SCADA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SCADA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SCADA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SCADA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SCADA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SCADA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SCADA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SCADA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SCADA] SET  MULTI_USER 
GO
ALTER DATABASE [SCADA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SCADA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SCADA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SCADA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SCADA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SCADA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SCADA] SET QUERY_STORE = ON
GO
ALTER DATABASE [SCADA] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SCADA]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 18.05.2026 14:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[LocationID] [int] IDENTITY(1,1) NOT NULL,
	[LocationName] [varchar](50) NOT NULL,
	[Building] [varchar](50) NOT NULL,
	[Floor] [int] NOT NULL,
	[Room] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Location_Building_Floor_Room] UNIQUE NONCLUSTERED 
(
	[Building] ASC,
	[Floor] ASC,
	[Room] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Location_LocationName] UNIQUE NONCLUSTERED 
(
	[LocationName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProcessUnit]    Script Date: 18.05.2026 14:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProcessUnit](
	[ProcessID] [int] IDENTITY(1,1) NOT NULL,
	[ProcessName] [varchar](100) NOT NULL,
	[ProcessType] [varchar](50) NOT NULL,
	[ProcessDescription] [varchar](255) NULL,
	[LocationID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProcessID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProcessVariable]    Script Date: 18.05.2026 14:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProcessVariable](
	[VariableID] [int] IDENTITY(1,1) NOT NULL,
	[ProcessID] [int] NOT NULL,
	[VariableName] [varchar](100) NOT NULL,
	[EngineeringUnit] [varchar](20) NOT NULL,
	[VariableDescription] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[VariableID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_ProcessVariable_VariableName] UNIQUE NONCLUSTERED 
(
	[VariableName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sensor]    Script Date: 18.05.2026 14:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sensor](
	[SensorID] [int] IDENTITY(1,1) NOT NULL,
	[VariableID] [int] NOT NULL,
	[SensorTypeID] [int] NOT NULL,
	[SensorName] [varchar](50) NULL,
	[Manufacturer] [varchar](100) NULL,
	[Model] [varchar](50) NULL,
	[SerialNumber] [varchar](100) NOT NULL,
	[InstallationDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[SensorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SensorData]    Script Date: 18.05.2026 14:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SensorData](
	[DataID] [bigint] IDENTITY(1,1) NOT NULL,
	[SensorID] [int] NOT NULL,
	[MeasuredValue] [float] NOT NULL,
	[TimeStamp] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DataID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SensorType]    Script Date: 18.05.2026 14:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SensorType](
	[SensorTypeID] [int] IDENTITY(1,1) NOT NULL,
	[SensorTypeName] [varchar](50) NOT NULL,
	[SensorTypeDescription] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[SensorTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProcessUnit]  WITH CHECK ADD  CONSTRAINT [FK_ProcessUnit_Location] FOREIGN KEY([LocationID])
REFERENCES [dbo].[Location] ([LocationID])
GO
ALTER TABLE [dbo].[ProcessUnit] CHECK CONSTRAINT [FK_ProcessUnit_Location]
GO
ALTER TABLE [dbo].[ProcessVariable]  WITH CHECK ADD  CONSTRAINT [FK_ProcessVariable_ProcessUnit] FOREIGN KEY([ProcessID])
REFERENCES [dbo].[ProcessUnit] ([ProcessID])
GO
ALTER TABLE [dbo].[ProcessVariable] CHECK CONSTRAINT [FK_ProcessVariable_ProcessUnit]
GO
/****** Object:  StoredProcedure [dbo].[usp_FindOrCreateLocation]    Script Date: 18.05.2026 14:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_FindOrCreateLocation]
    @LocationName VARCHAR(50),
    @Building VARCHAR(50),
    @Floor    INT,
    @Room     VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    MERGE INTO LOCATION AS target
    USING (VALUES (@LocationName, @Building, @Floor, @Room))
           AS source(LocationName, Building, Floor, Room)
    ON target.LocationName = source.LocationName
       AND target.Building = source.Building
       AND target.Floor = source.Floor
       AND target.Room = source.Room

    WHEN MATCHED THEN
        -- No-op update to force OUTPUT to return the existing row
        UPDATE SET LocationName = target.LocationName

    WHEN NOT MATCHED THEN
        INSERT (LocationName, Building, Floor, Room)
        VALUES (source.LocationName, source.Building, source.Floor, source.Room)
    OUTPUT inserted.*;
END
GO
/****** Object:  StoredProcedure [dbo].[usp_FindOrCreateProcessUnit]    Script Date: 18.05.2026 14:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_FindOrCreateProcessUnit]
    @ProcessName VARCHAR(100),
    @ProcessType VARCHAR(50),
    @ProcessDescription VARCHAR(255),
    @LocationID   INT
AS
BEGIN
    SET NOCOUNT ON;

    MERGE INTO ProcessUnit AS target
    USING (VALUES (@ProcessName, @ProcessType, @ProcessDescription, @LocationID))
           AS source(ProcessName, ProcessType, ProcessDescription, LocationID)
    ON target.ProcessName = source.ProcessName
       AND target.ProcessType = source.ProcessType
       AND target.ProcessDescription = source.ProcessDescription
       AND target.LocationID = source.LocationID

    WHEN MATCHED THEN
        -- No-op update to force OUTPUT to return the existing row
        UPDATE SET ProcessName = target.ProcessName

    WHEN NOT MATCHED THEN
        INSERT (ProcessName, ProcessType, ProcessDescription, LocationID)
        VALUES (source.ProcessName, source.ProcessType, source.ProcessDescription, source.LocationID)
    OUTPUT inserted.*;
END
GO
/****** Object:  StoredProcedure [dbo].[usp_FindOrCreateProcessVariable]    Script Date: 18.05.2026 14:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[usp_FindOrCreateProcessVariable]
    @ProcessID   INT,
    @VariableName VARCHAR(100),
    @EngineeringUnit VARCHAR(20),
    @VariableDescription VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    MERGE INTO ProcessVariable AS target
    USING (VALUES (@ProcessID, @VariableName, @EngineeringUnit, @VariableDescription))
           AS source(ProcessID, VariableName, EngineeringUnit, VariableDescription)
    ON target.ProcessID = source.ProcessID
       AND target.VariableName = source.VariableName
       AND target.EngineeringUnit = source.EngineeringUnit
       AND target.VariableDescription = source.VariableDescription

    WHEN MATCHED THEN
        -- No-op update to force OUTPUT to return the existing row
        UPDATE SET VariableName = target.VariableName

    WHEN NOT MATCHED THEN
        INSERT (VariableName, EngineeringUnit, VariableDescription, ProcessID)
        VALUES (source.VariableName, source.EngineeringUnit, source.VariableDescription, source.ProcessID)
    OUTPUT inserted.*;
END
GO
/****** Object:  StoredProcedure [dbo].[usp_FindOrCreateSensorType]    Script Date: 18.05.2026 14:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[usp_FindOrCreateSensorType]
    @SensorTypeName VARCHAR(50),
    @SensorTypeDescription VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    MERGE INTO SensorType AS target
    USING (VALUES (@SensorTypeName, @SensorTypeDescription))
           AS source(SensorTypeName, SensorTypeDescription)
    ON target.SensorTypeName = source.SensorTypeName
       AND target.SensorTypeDescription = source.SensorTypeDescription

    WHEN MATCHED THEN
        -- No-op update to force OUTPUT to return the existing row
        UPDATE SET SensorTypeName = target.SensorTypeName
    WHEN NOT MATCHED THEN
        INSERT (SensorTypeName, SensorTypeDescription)
        VALUES (source.SensorTypeName, source.SensorTypeDescription)
    OUTPUT inserted.*;
END
GO
USE [master]
GO
ALTER DATABASE [SCADA] SET  READ_WRITE 
GO
