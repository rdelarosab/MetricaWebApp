USE [master]
GO
/****** Object:  Database [MetricaBank]    Script Date: 18/08/2017 17:23:45 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'MetricaBank')
BEGIN
CREATE DATABASE [MetricaBank]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MetricaBank', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MetricaBank.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MetricaBank_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MetricaBank_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MetricaBank].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MetricaBank] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MetricaBank] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MetricaBank] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MetricaBank] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MetricaBank] SET ARITHABORT OFF 
GO
ALTER DATABASE [MetricaBank] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MetricaBank] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MetricaBank] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MetricaBank] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MetricaBank] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MetricaBank] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MetricaBank] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MetricaBank] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MetricaBank] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MetricaBank] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MetricaBank] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MetricaBank] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MetricaBank] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MetricaBank] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MetricaBank] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MetricaBank] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MetricaBank] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MetricaBank] SET RECOVERY FULL 
GO
ALTER DATABASE [MetricaBank] SET  MULTI_USER 
GO
ALTER DATABASE [MetricaBank] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MetricaBank] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MetricaBank] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MetricaBank] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MetricaBank', N'ON'
GO
USE [MetricaBank]
GO
/****** Object:  Table [dbo].[Banco]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Banco]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Banco](
	[IdBanco] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](250) NOT NULL,
	[Direccion] [varchar](500) NOT NULL,
	[FechaRegistro] [datetime] NOT NULL CONSTRAINT [DF_Banco_FechaRegistro]  DEFAULT (getutcdate()),
	[IsDeleted] [bit] NOT NULL CONSTRAINT [DF_Banco_IsDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_Banco] PRIMARY KEY CLUSTERED 
(
	[IdBanco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Orden]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Orden]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Orden](
	[IdOrden] [int] IDENTITY(1,1) NOT NULL,
	[Monto] [decimal](18, 2) NOT NULL,
	[Moneda] [int] NOT NULL,
	[Estado] [int] NOT NULL,
	[FechaPago] [datetime] NOT NULL CONSTRAINT [DF_Orden_FechaPago]  DEFAULT (getutcdate()),
	[IdSucursal] [int] NOT NULL,
 CONSTRAINT [PK_Orden_1] PRIMARY KEY CLUSTERED 
(
	[IdOrden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sucursal]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Sucursal](
	[IdSucursal] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](250) NOT NULL,
	[Direccion] [varchar](500) NOT NULL,
	[FechaRegistro] [datetime] NOT NULL CONSTRAINT [DF_Sucursal_FechaRegistro]  DEFAULT (getutcdate()),
	[IdBanco] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL CONSTRAINT [DF_Sucursal_IsDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[IdSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Banco] ON 

INSERT [dbo].[Banco] ([IdBanco], [Nombre], [Direccion], [FechaRegistro], [IsDeleted]) VALUES (1, N'Interbank', N'Perú', CAST(N'2017-08-18 03:13:26.900' AS DateTime), 0)
INSERT [dbo].[Banco] ([IdBanco], [Nombre], [Direccion], [FechaRegistro], [IsDeleted]) VALUES (2, N'BBVA', N'Perú', CAST(N'2017-08-18 18:15:01.287' AS DateTime), 0)
INSERT [dbo].[Banco] ([IdBanco], [Nombre], [Direccion], [FechaRegistro], [IsDeleted]) VALUES (4, N'BCP', N'Perú', CAST(N'2017-08-18 18:15:15.970' AS DateTime), 0)
INSERT [dbo].[Banco] ([IdBanco], [Nombre], [Direccion], [FechaRegistro], [IsDeleted]) VALUES (5, N'Scotiabank', N'Perú', CAST(N'2017-08-18 18:16:30.703' AS DateTime), 0)
INSERT [dbo].[Banco] ([IdBanco], [Nombre], [Direccion], [FechaRegistro], [IsDeleted]) VALUES (6, N'MiBanco', N'Perú', CAST(N'2017-08-18 19:01:52.987' AS DateTime), 0)
INSERT [dbo].[Banco] ([IdBanco], [Nombre], [Direccion], [FechaRegistro], [IsDeleted]) VALUES (7, N'Citibank', N'Perú', CAST(N'2017-08-18 19:10:54.610' AS DateTime), 0)
INSERT [dbo].[Banco] ([IdBanco], [Nombre], [Direccion], [FechaRegistro], [IsDeleted]) VALUES (8, N'Banbif Editado', N'Perú', CAST(N'2017-08-18 19:38:07.207' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Banco] OFF
SET IDENTITY_INSERT [dbo].[Orden] ON 

INSERT [dbo].[Orden] ([IdOrden], [Monto], [Moneda], [Estado], [FechaPago], [IdSucursal]) VALUES (1, CAST(50.00 AS Decimal(18, 2)), 1, 1, CAST(N'2017-08-18 03:34:31.683' AS DateTime), 3)
INSERT [dbo].[Orden] ([IdOrden], [Monto], [Moneda], [Estado], [FechaPago], [IdSucursal]) VALUES (2, CAST(500.00 AS Decimal(18, 2)), 2, 2, CAST(N'2017-08-18 21:38:17.633' AS DateTime), 5)
SET IDENTITY_INSERT [dbo].[Orden] OFF
SET IDENTITY_INSERT [dbo].[Sucursal] ON 

INSERT [dbo].[Sucursal] ([IdSucursal], [Nombre], [Direccion], [FechaRegistro], [IdBanco], [IsDeleted]) VALUES (3, N'SAN ISIDRO', N'LAS BEGONIAS 456', CAST(N'2017-08-18 03:30:11.930' AS DateTime), 1, 1)
INSERT [dbo].[Sucursal] ([IdSucursal], [Nombre], [Direccion], [FechaRegistro], [IdBanco], [IsDeleted]) VALUES (4, N'SURQUILLO', N'DOMINGO ORUE 456', CAST(N'2017-08-18 03:33:11.543' AS DateTime), 1, 0)
INSERT [dbo].[Sucursal] ([IdSucursal], [Nombre], [Direccion], [FechaRegistro], [IdBanco], [IsDeleted]) VALUES (5, N'TRUJILLO', N'ORTEGA Y GASSET 124', CAST(N'2017-08-18 03:34:04.623' AS DateTime), 1, 0)
INSERT [dbo].[Sucursal] ([IdSucursal], [Nombre], [Direccion], [FechaRegistro], [IdBanco], [IsDeleted]) VALUES (6, N'MOCHE', N'INCLAN 234', CAST(N'2017-08-18 21:10:08.003' AS DateTime), 1, 0)
INSERT [dbo].[Sucursal] ([IdSucursal], [Nombre], [Direccion], [FechaRegistro], [IdBanco], [IsDeleted]) VALUES (7, N'SAN ISIDRO', N'DOMINGO ORUE 786', CAST(N'2017-08-18 21:12:24.217' AS DateTime), 7, 1)
INSERT [dbo].[Sucursal] ([IdSucursal], [Nombre], [Direccion], [FechaRegistro], [IdBanco], [IsDeleted]) VALUES (8, N'SURCO', N'EL TRIGAL', CAST(N'2017-08-18 21:14:23.363' AS DateTime), 7, 1)
SET IDENTITY_INSERT [dbo].[Sucursal] OFF
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Orden_Sucursal]') AND parent_object_id = OBJECT_ID(N'[dbo].[Orden]'))
ALTER TABLE [dbo].[Orden]  WITH CHECK ADD  CONSTRAINT [FK_Orden_Sucursal] FOREIGN KEY([IdSucursal])
REFERENCES [dbo].[Sucursal] ([IdSucursal])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Orden_Sucursal]') AND parent_object_id = OBJECT_ID(N'[dbo].[Orden]'))
ALTER TABLE [dbo].[Orden] CHECK CONSTRAINT [FK_Orden_Sucursal]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sucursal_Banco]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sucursal]'))
ALTER TABLE [dbo].[Sucursal]  WITH CHECK ADD  CONSTRAINT [FK_Sucursal_Banco] FOREIGN KEY([IdBanco])
REFERENCES [dbo].[Banco] ([IdBanco])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sucursal_Banco]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sucursal]'))
ALTER TABLE [dbo].[Sucursal] CHECK CONSTRAINT [FK_Sucursal_Banco]
GO
/****** Object:  StoredProcedure [dbo].[DeleteBank]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteBank]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteBank] AS' 
END
GO

ALTER PROCEDURE [dbo].[DeleteBank]
@IdBanco INT
AS
BEGIN
	UPDATE Banco
	SET IsDeleted = 1
	WHERE IdBanco = @IdBanco
END

GO
/****** Object:  StoredProcedure [dbo].[DeleteBranch]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteBranch]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteBranch] AS' 
END
GO

ALTER PROCEDURE [dbo].[DeleteBranch]
@IdSucursal INT
AS
BEGIN
	UPDATE Sucursal
	SET IsDeleted = 1
	WHERE IdSucursal = @IdSucursal
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllBanks]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllBanks]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetAllBanks] AS' 
END
GO
ALTER PROCEDURE [dbo].[GetAllBanks]
AS
BEGIN
	SELECT 
	IdBanco,
	Nombre,
	Direccion
	FROM Banco
	WHERE IsDeleted = 0
	ORDER BY FechaRegistro DESC
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllBranch]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllBranch]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetAllBranch] AS' 
END
GO
ALTER PROCEDURE [dbo].[GetAllBranch]
@IdBanco INT
AS
BEGIN
	SELECT 
	IdSucursal,
	Nombre,
	Direccion,
	IdBanco
	FROM Sucursal
	WHERE IdBanco = @IdBanco AND IsDeleted = 0
	ORDER BY FechaRegistro DESC
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllOrders]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllOrders]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetAllOrders] AS' 
END
GO
------------------------------------------------------

ALTER PROCEDURE [dbo].[GetAllOrders]
@IdBanco INT
AS
BEGIN
	SELECT
	O.IdOrden,
	O.Monto,
	O.Moneda,
	O.Estado, 
	S.IdSucursal,
	S.Nombre AS TxtSucursal,
	S.IdBanco,
	O.FechaPago
	FROM Orden O
	JOIN Sucursal S ON
	O.IdSucursal = S.IdSucursal
	WHERE S.IdBanco =@IdBanco
	ORDER BY FechaPago DESC
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllOrdersFilter]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllOrdersFilter]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetAllOrdersFilter] AS' 
END
GO
ALTER PROCEDURE [dbo].[GetAllOrdersFilter]
@IdSucursal INT,
@Moneda INT
AS
BEGIN
	SELECT
	IdOrden,
	Monto,
	Moneda,
	Estado, 
	IdSucursal,
	FechaPago
	FROM Orden
	WHERE IdSucursal = @IdSucursal AND (Moneda = @Moneda)
	ORDER BY FechaPago DESC
END

GO
/****** Object:  StoredProcedure [dbo].[GetBank]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetBank]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetBank] AS' 
END
GO
ALTER PROCEDURE [dbo].[GetBank]
@IdBanco INT
AS
BEGIN
	SELECT
	IdBanco,
	Nombre,
	Direccion
	FROM
	Banco
	WHERE IdBanco = @IdBanco
END
GO
/****** Object:  StoredProcedure [dbo].[GetBranch]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetBranch]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetBranch] AS' 
END
GO
ALTER PROCEDURE [dbo].[GetBranch]
@IdSucursal INT
AS
BEGIN
	SELECT
	IdSucursal,
	Nombre,
	Direccion,
	IdBanco
	FROM
	Sucursal
	WHERE IdSucursal = @IdSucursal
END
GO
/****** Object:  StoredProcedure [dbo].[GetOrder]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetOrder]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetOrder] AS' 
END
GO
ALTER PROCEDURE [dbo].[GetOrder]
@OrderId INT
AS
BEGIN
	SELECT
	IdOrden,
	Monto,
	Moneda,
	Estado,
	IdSucursal
	FROM
	Orden
	WHERE IdOrden = @OrderId
END
GO
/****** Object:  StoredProcedure [dbo].[InsertBank]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertBank]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertBank] AS' 
END
GO
ALTER PROCEDURE [dbo].[InsertBank]
@Nombre VARCHAR(250),
@Direccion VARCHAR(500)
AS
BEGIN
	INSERT INTO Banco(Nombre, Direccion)
	VALUES(@Nombre, @Direccion)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertBranch]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertBranch]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertBranch] AS' 
END
GO

ALTER PROCEDURE [dbo].[InsertBranch]
@Nombre VARCHAR(250),
@Direccion VARCHAR(500),
@IdBanco INT
AS
BEGIN
	INSERT INTO Sucursal(Nombre, Direccion, IdBanco)
	VALUES(@Nombre, @Direccion, @IdBanco)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertOrder]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertOrder]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertOrder] AS' 
END
GO

ALTER PROCEDURE [dbo].[InsertOrder]
@Monto DECIMAL(18,2),
@Moneda INT,
@Estado INT,
@FechaPago DATETIME,
@IdSucursal INT
AS
BEGIN
	INSERT INTO Orden(Monto, Moneda, Estado, FechaPago, IdSucursal)
	VALUES(@Monto, @Moneda, @Estado, @FechaPago, @IdSucursal)
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateBank]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateBank]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateBank] AS' 
END
GO

ALTER PROCEDURE [dbo].[UpdateBank]
@IdBanco INT,
@Nombre VARCHAR(250),
@Direccion VARCHAR(500)
AS
BEGIN
	UPDATE Banco
	SET Nombre = @Nombre,
	Direccion = @Direccion
	WHERE IdBanco = @IdBanco
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateBranch]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateBranch]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateBranch] AS' 
END
GO

ALTER PROCEDURE [dbo].[UpdateBranch]
@IdSucursal INT,
@IdBanco INT,
@Nombre VARCHAR(250),
@Direccion VARCHAR(500)
AS
BEGIN
	UPDATE Sucursal
	SET Nombre = @Nombre,
	Direccion = @Direccion,
	IdBanco = @IdBanco
	WHERE IdSucursal = @IdSucursal
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateOrder]    Script Date: 18/08/2017 17:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateOrder]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateOrder] AS' 
END
GO

ALTER PROCEDURE [dbo].[UpdateOrder]
@IdOrden INT,
@Estado INT
AS
BEGIN
	UPDATE Orden
	SET Estado = @Estado
	WHERE IdOrden = @IdOrden
END

GO
USE [master]
GO
ALTER DATABASE [MetricaBank] SET  READ_WRITE 
GO
