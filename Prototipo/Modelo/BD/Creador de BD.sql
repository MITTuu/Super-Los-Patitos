CREATE DATABASE SuperPatitosDB

USE SuperPatitosDB

-- Crear la tabla TipoIdentificacion
CREATE TABLE TiposIdentificacion (
    idTipoIdentificacion INT PRIMARY KEY NOT NULL,
    TipoIdentificacion VARCHAR(50) NOT NULL
);

-- Crear la tabla Roles
CREATE TABLE Roles (
    idRol INT PRIMARY KEY NOT NULL,
    Rol VARCHAR(50) NOT NULL
);

-- Crear la tabla Personal
CREATE TABLE Personal (
    idPersonal INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    PrimerApellido VARCHAR(50) NOT NULL,
    SegundoApellido VARCHAR(50) NULL,
    Correo VARCHAR(100) NOT NULL UNIQUE,
    Contrasena VARCHAR(100) NOT NULL,
    Telefono VARCHAR(20) NULL,
    Identificacion VARCHAR(50) NOT NULL UNIQUE,
    idTipoIdentificacion INT FOREIGN KEY REFERENCES TiposIdentificacion(idTipoIdentificacion) NOT NULL,
    idRol INT FOREIGN KEY REFERENCES Roles(idRol) NOT NULL
);

-- Crear la tabla UnidadesMedida
CREATE TABLE UnidadesMedida (
    idUnidadMedida INT PRIMARY KEY NOT NULL,
    UnidadMedida VARCHAR(32) NOT NULL
);

-- Crear la tabla Productos
CREATE TABLE Productos (
    idProducto INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Codigo VARCHAR(50) NOT NULL UNIQUE,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    Cantidad INT NOT NULL,
    idUnidadMedida INT FOREIGN KEY REFERENCES UnidadesMedida(idUnidadMedida) NOT NULL
);

-- Crear la tabla Cliente
CREATE TABLE Clientes (
    idCliente INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    PrimerApellido VARCHAR(50) NOT NULL,
    SegundoApellido VARCHAR(50) NULL,
    Correo VARCHAR(100) NOT NULL UNIQUE,
    Telefono VARCHAR(20) NULL,
    Identificacion VARCHAR(50) NOT NULL UNIQUE,
    idTipoIdentificacion INT FOREIGN KEY REFERENCES TiposIdentificacion(idTipoIdentificacion) NOT NULL
);

-- Crear la tabla TipoDocumento
CREATE TABLE TiposDocumento (
    idTipoDocumento INT PRIMARY KEY NOT NULL,
    TipoDocumento VARCHAR(50) NOT NULL
);

-- Crear la tabla Documentos
CREATE TABLE Documentos (
    idDocumento INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    idTipoDocumento INT FOREIGN KEY REFERENCES TiposDocumento(idTipoDocumento) NOT NULL,
    FechaCreacion DATE NOT NULL,
    Consecutivo INT NOT NULL,
    idPersonal INT FOREIGN KEY REFERENCES Personal(idPersonal) NOT NULL,
    idCliente INT FOREIGN KEY REFERENCES Clientes(idCliente) NULL,
    TotalImpuestos DECIMAL(10,2) NULL,
    Subtotal DECIMAL(10,2) NULL,
    Total DECIMAL(10,2) NULL
);

-- Crear la tabla Linea
CREATE TABLE Lineas (
    idLinea INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    idDocumento INT FOREIGN KEY REFERENCES Documentos(idDocumento) NOT NULL,
    Cantidad INT NOT NULL,
    idProducto INT FOREIGN KEY REFERENCES Productos(idProducto) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    Impuesto DECIMAL(10,2) NOT NULL,
    Total DECIMAL(10,2) NOT NULL
);

-- Crear la tabla Ajustes
CREATE TABLE Ajustes (
    AjusteId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    FechaAjuste DATE NOT NULL,
    idProducto INT FOREIGN KEY REFERENCES Productos(idProducto) NOT NULL,
    CantidadAjustada INT NOT NULL,
    Razon VARCHAR(200) NOT NULL,
    idPersonal INT FOREIGN KEY REFERENCES Personal(idPersonal) NOT NULL
);

-- Datos insertados por defecto

INSERT INTO Roles (idRol, Rol)
	VALUES
	(1, 'Administrador'),
	(2, 'Cajero'),
	(3, 'Administrador de inventario'),
	(4, 'Contador')

INSERT INTO TiposIdentificacion (idTipoIdentificacion, TipoIdentificacion)
	VALUES
	(1, 'f�sica'),
	(2, 'jur�dica'),
	(3, 'DIMEX'),
	(4, 'NITE')

INSERT INTO TiposDocumento (idTipoDocumento, TipoDocumento)
	VALUES
	(1, 'Factura'),
	(2, 'Tiquete'),
	(3, 'Nota de credito')

INSERT INTO UnidadesMedida (idUnidadMedida, UnidadMedida)
    VALUES
    (1, 'unidad'),
    (2, 'kilogramo')

-- ADMIN
INSERT INTO Personal (Nombre, PrimerApellido, SegundoApellido, Correo, Contrasena, Telefono, Identificacion, idTipoIdentificacion, idRol)
VALUES
    ('Oscar', 'Roni', 'Ordo�ez', 'oscar.gt.140.ro@gmail.com', '1212', '88888888', '119030573', 1, 1),
	('Dylan', 'Montiel', 'Z��iga', 'dylanmmz01@gmail.com', 'Dylan.1234', '62609932', '703050437', 1, 1);


SELECT * FROM Productos