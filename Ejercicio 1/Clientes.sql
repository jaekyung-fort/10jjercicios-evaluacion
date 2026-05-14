CREATE DATABASE ClientesDB;

GO

USE ClientesDB;
GO


    CREATE TABLE dbo.Clientes (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Nombre NVARCHAR(100) NOT NULL,
        Telefono NVARCHAR(20) NOT NULL,
        Correo NVARCHAR(100) NOT NULL
    );

GO
