
    CREATE DATABASE SistemaVentas;

GO

USE SistemaVentas;
GO


    CREATE TABLE dbo.Ventas
    (
        Id        INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
        Cliente   NVARCHAR(200)      NOT NULL,
        Producto  NVARCHAR(200)      NOT NULL,
        Cantidad  INT                NOT NULL,
        Precio    DECIMAL(18, 2)     NOT NULL,
        Total     DECIMAL(18, 2)     NOT NULL
    );

GO
