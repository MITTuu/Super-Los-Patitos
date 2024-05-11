CREATE DATABASE SUPERPATITOS

USE SUPERPATITOS

-- Crear la tabla TipoIdentificacion
CREATE TABLE TipoIdentificacion (
    idTipoIdentificacion INT PRIMARY KEY,
    TipoIdentificacion VARCHAR(50) NOT NULL
);

-- Crear la tabla Rol
CREATE TABLE Rol (
    idRol INT PRIMARY KEY,
    Rol VARCHAR(50) NOT NULL
);

-- Crear la tabla Personal
CREATE TABLE Personal (
    idPersonal INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    PrimerApellido VARCHAR(50) NOT NULL,
    SegundoApellido VARCHAR(50) NULL,
    Correo VARCHAR(100) NOT NULL UNIQUE,
    Contrasena VARCHAR(100) NOT NULL,
    Telefono VARCHAR(20) NULL,
    Identificacion VARCHAR(50) NOT NULL UNIQUE,
    idTipoIdentificacion INT FOREIGN KEY REFERENCES TipoIdentificacion(idTipoIdentificacion) NOT NULL,
    idRol INT FOREIGN KEY REFERENCES Rol(idRol) NOT NULL
);

-- Crear la tabla Productos
CREATE TABLE Productos (
    idProducto INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Codigo VARCHAR(50) NOT NULL UNIQUE,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    Cantidad INT NOT NULL,
    TipoMedida VARCHAR(50) NOT NULL
);

-- Crear la tabla tipoUnidad

-- Crear la tabla Cliente
CREATE TABLE Cliente (
    idCliente INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    PrimerApellido VARCHAR(50) NOT NULL,
    SegundoApellido VARCHAR(50) NULL,
    Correo VARCHAR(100) NOT NULL UNIQUE,
    Telefono VARCHAR(20) NULL,
    Identificacion VARCHAR(50) NOT NULL UNIQUE,
    idTipoIdentificacion INT FOREIGN KEY REFERENCES TipoIdentificacion(idTipoIdentificacion) NOT NULL
);

-- Crear la tabla TipoDocumento
CREATE TABLE TipoDocumento (
    idTipoDocumento INT PRIMARY KEY,
    TipoDocumento VARCHAR(50) NOT NULL
);

-- Crear la tabla Documentos
CREATE TABLE Documentos (
    idDocumento INT PRIMARY KEY IDENTITY(1,1),
    idTipoDocumento INT FOREIGN KEY REFERENCES TipoDocumento(idTipoDocumento) NOT NULL,
    FechaCreacion DATE NOT NULL,
    idCliente INT FOREIGN KEY REFERENCES Cliente(idCliente) NULL,
    Consecutivo INT NOT NULL,
    TotalImpuestos DECIMAL(10,2) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    Total DECIMAL(10,2) NOT NULL,
    idPersonal INT FOREIGN KEY REFERENCES Personal(idPersonal) NOT NULL
);

-- Crear la tabla Linea
CREATE TABLE Linea (
    idLinea INT PRIMARY KEY IDENTITY(1,1),
    idDocumento INT FOREIGN KEY REFERENCES Documentos(idDocumento) NOT NULL,
    Cantidad INT NOT NULL,
    idProducto INT FOREIGN KEY REFERENCES Productos(idProducto) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    Impuesto DECIMAL(10,2) NOT NULL,
    Total DECIMAL(10,2) NOT NULL
);

-- Crear la tabla Ajuste
CREATE TABLE Ajuste (
    AjusteId INT PRIMARY KEY IDENTITY(1,1),
    FechaAjuste DATE NOT NULL,
    idProducto INT FOREIGN KEY REFERENCES Productos(idProducto) NOT NULL,
    CantidadAjustada INT NOT NULL,
    Razon VARCHAR(200) NOT NULL,
    idPersonal INT FOREIGN KEY REFERENCES Personal(idPersonal) NOT NULL
);

-- Datos insertados por defecto

INSERT INTO Rol (idRol, Rol)
	VALUES
	(1, 'Administrador'),
	(2, 'Cajero'),
	(3, 'Administrador de inventario'),
	(4, 'Contador')

INSERT INTO TipoIdentificacion (idTipoIdentificacion, TipoIdentificacion)
	VALUES
	(1, 'física'),
	(2, 'jurídica'),
	(3, 'DIMEX'),
	(4, 'NITE')

INSERT INTO TipoDocumento (idTipoDocumento, TipoDocumento)
	VALUES
	(1, 'Factura'),
	(2, 'Tiquete'),
	(3, 'Nota de credito')
