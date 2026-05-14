CREATE DATABASE SistemaEmpleados;

GO


USE SistemaEmpleados;

GO

    CREATE TABLE dbo.Empleados
    (
        Id INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
        Nombre NVARCHAR(200) NOT NULL,
        Cargo NVARCHAR(200) NOT NULL,
        Salario DECIMAL(18, 2) NOT NULL
    );
GO
