CREATE DATABASE FacturacionDB;
GO

USE FacturacionDB;
GO

-- Crear primero la tabla Facturas
CREATE TABLE [dbo].[Facturas](
    [Id] INT IDENTITY(1,1) NOT NULL,
    [Cliente] NVARCHAR(1000) NOT NULL,
    [Fecha] DATETIME NOT NULL,
    CONSTRAINT PK_Facturas PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

-- Luego crear la tabla DetalleFactura
CREATE TABLE [dbo].[DetalleFactura](
    [Id] INT IDENTITY(1,1) NOT NULL,
    [FacturaId] INT NOT NULL,
    [Producto] NVARCHAR(1000) NOT NULL,
    [Cantidad] INT NOT NULL,
    [Precio] DECIMAL(10,2) NOT NULL,
    CONSTRAINT PK_DetalleFactura PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT FK_DetalleFactura_Facturas FOREIGN KEY ([FacturaId])
        REFERENCES [dbo].[Facturas]([Id])
);
GO
