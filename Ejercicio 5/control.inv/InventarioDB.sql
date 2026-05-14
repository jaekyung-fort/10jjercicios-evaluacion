CREATE DATABASE InventarioDB;

GO

USE InventarioDB;
GO

    CREATE TABLE dbo.Productos (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Nombre NVARCHAR(100) NOT NULL,
        Categoria NVARCHAR(100) NOT NULL,
        Cantidad INT NOT NULL,
        PrecioCompra DECIMAL(10,2) NOT NULL
    );
GO


delete  from dbo.Productos