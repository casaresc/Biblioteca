CREATE DATABASE Biblioteca;
GO

USE Biblioteca;
GO

CREATE TABLE Libros (
    LibroID INT IDENTITY(1,1) PRIMARY KEY,
    Titulo NVARCHAR(255) NOT NULL,
    Autor NVARCHAR(255) NOT NULL,
    ISBN NVARCHAR(13) UNIQUE NOT NULL,
    AñoPublicacion INT,
    NumeroPaginas INT
);

GO



CREATE TABLE Usuarios (
    UsuarioID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(255) NOT NULL,
    Apellido NVARCHAR(255) NOT NULL,
    NumeroSocio NVARCHAR(20) UNIQUE NOT NULL
);
GO

CREATE TABLE Prestamos (
    PrestamoID INT IDENTITY(1,1) PRIMARY KEY,
    LibroID INT,
    UsuarioID INT,
    FechaPrestamo DATE NOT NULL,
    FechaDevolucion DATE,
    FOREIGN KEY (LibroID) REFERENCES Libros(LibroID),
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
);
GO

-- Insertar datos en la tabla Libros
INSERT INTO Libros (Titulo, Autor, ISBN, AñoPublicacion, NumeroPaginas)
VALUES ('Cien Años de Soledad', 'Gabriel García Márquez', '9780307474728', 1967, 471);

INSERT INTO Libros (Titulo, Autor, ISBN, AñoPublicacion, NumeroPaginas)
VALUES ('1984', 'George Orwell', '9780451524935', 1949, 328);
GO

-- Insertar datos en la tabla Usuarios
INSERT INTO Usuarios (Nombre, Apellido, NumeroSocio)
VALUES ('Juan', 'Pérez', 'S001');

INSERT INTO Usuarios (Nombre, Apellido, NumeroSocio)
VALUES ('María', 'Gómez', 'S002');
GO

-- Insertar datos en la tabla Prestamos
INSERT INTO Prestamos (LibroID, UsuarioID, FechaPrestamo, FechaDevolucion)
VALUES (1, 1, '2024-08-01', NULL); -- El libro con ID 1 está prestado al usuario con ID 1 y aún no ha sido devuelto.

INSERT INTO Prestamos (LibroID, UsuarioID, FechaPrestamo, FechaDevolucion)
VALUES (2, 2, '2024-08-02', '2024-08-10'); -- El libro con ID 2 fue prestado al usuario con ID 2 y fue devuelto el 10 de agosto de 2024.
GO

