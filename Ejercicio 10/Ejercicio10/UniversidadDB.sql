CREATE DATABASE UniversidadDB;
GO

USE UniversidadDB;
GO

CREATE TABLE Carreras (
    Id INT PRIMARY KEY IDENTITY(1,1),
    NombreCarrera NVARCHAR(100) NOT NULL
);

CREATE TABLE Estudiantes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Edad INT NOT NULL,
    CarreraId INT NOT NULL,
    
    CONSTRAINT FK_Estudiantes_Carreras
    FOREIGN KEY (CarreraId)
    REFERENCES Carreras(Id)
);