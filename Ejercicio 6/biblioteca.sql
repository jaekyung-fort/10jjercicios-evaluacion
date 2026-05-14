
CREATE DATABASE BibliotecaDB;
GO

-
USE BibliotecaDB;
GO

-- Crear la tabla principal de libros
CREATE TABLE Libros (
    Id INT IDENTITY(1,1) PRIMARY KEY,   
    Titulo NVARCHAR(200) NOT NULL,      
    Autor NVARCHAR(150) NOT NULL,       
    AÑo INT NOT NULL,                  
    Disponible BIT NOT NULL             
);
GO
