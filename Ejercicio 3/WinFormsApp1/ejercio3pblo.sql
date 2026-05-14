
CREATE DATABASE EscuelaDB;
GO

USE EscuelaDB;
GO

--ejecutas para crear la tabla 

CREATE TABLE Estudiantes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100),
    Carrera NVARCHAR(100),
    Promedio DECIMAL(5,2)
);



SELECT * FROM Estudiantes;
