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

-- Crear la tabla NotasCreditoDocumentos
CREATE TABLE NotasCreditoDocumentos (
    idNotaCredito INT FOREIGN KEY REFERENCES Documentos(idDocumento) NOT NULL,
    idDocumentoRelacionado INT FOREIGN KEY REFERENCES Documentos(idDocumento) NOT NULL,
    PRIMARY KEY (idNotaCredito, idDocumentoRelacionado)
);

-- Crear la tabla Linea
CREATE TABLE Lineas (
    idLinea INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    idDocumento INT FOREIGN KEY REFERENCES Documentos(idDocumento) NOT NULL,
    Cantidad DECIMAL(10,3) NOT NULL,
    idProducto INT FOREIGN KEY REFERENCES Productos(idProducto) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    Impuesto DECIMAL(10,2) NOT NULL,
    Total DECIMAL(10,2) NOT NULL
);

-- Crear la tabla Ajustes
CREATE TABLE Ajustes (
    idAjuste INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    FechaAjuste DATE NOT NULL,
    Razon VARCHAR(200) NOT NULL,
    idPersonal INT FOREIGN KEY REFERENCES Personal(idPersonal) NOT NULL
);

CREATE TABLE AjustesProducto (
    idAjusteProducto INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    idProducto INT FOREIGN KEY REFERENCES Productos(idProducto) NOT NULL,
    CantidadAjustada DECIMAL(10,3) NOT NULL,
    idAjuste INT FOREIGN KEY REFERENCES Ajustes(idAjuste) NOT NULL
);

DROP TABLE Ajustes

-- Datos insertados por defecto
INSERT INTO Roles (idRol, Rol)
	VALUES
	(1, 'Administrador'),
	(2, 'Cajero'),
	(3, 'Administrador de inventario'),
	(4, 'Contador')

INSERT INTO TiposIdentificacion (idTipoIdentificacion, TipoIdentificacion)
	VALUES
	(1, 'física'),
	(2, 'jurídica'),
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
    ('Oscar', 'Roni', 'Ordoñez', 'oscar.gt.140.ro@gmail.com', '1212', '88888888', '119030573', 1, 1),
	('Dylan', 'Montiel', 'Zúñiga', 'dylanmmz01@gmail.com', 'Dylan.1234', '62609932', '703050437', 1, 1);

-- Insertar productos
INSERT INTO Productos (Nombre, Codigo, PrecioUnitario, Cantidad, idUnidadMedida)
VALUES
    ('Atún Azul 400g', 'ATN001', 10.99, 100, 1),
    ('Costillas de cerdo BBQ', 'CDC002', 15.50, 50, 2),
    ('Aceite suli 900ml', 'ACS003', 8.75, 200, 1),
    ('Tomate rojo', 'TMR004', 12.25, 75, 2),
    ('Coca cola cero azucar 2.5L', 'CCA005', 20.00, 150, 1),
    ('Pepsi 2.5L', 'PPS006', 9.99, 120, 2);

UPDATE Productos
SET idUnidadMedida = 1
WHERE Nombre = 'Pepsi 2.5L';

-- Agregar una nueva columna temporal para la cantidad como DECIMAL
ALTER TABLE Productos
ADD CantidadTemp DECIMAL(10,3) NULL;

-- Actualizar la nueva columna temporal con los valores convertidos de la columna existente
UPDATE Productos
SET CantidadTemp = CAST(Cantidad AS DECIMAL(10,3));

-- Eliminar la columna existente Cantidad
ALTER TABLE Productos
DROP COLUMN Cantidad;

-- Renombrar la columna temporal como Cantidad
EXEC sp_rename 'Productos.CantidadTemp', 'Cantidad', 'COLUMN';

SELECT * FROM Clientes

ALTER TABLE Lineas
DROP CONSTRAINT FK__Lineas__idDocume__52593CB8;

ALTER TABLE Lineas
ALTER COLUMN idDocumento INT NOT NULL;  

ALTER TABLE Lineas
ALTER COLUMN Cantidad DECIMAL(10,3) NOT NULL;

ALTER TABLE Documentos
ADD Estado BIT NOT NULL;

ALTER TABLE Lineas
ADD Estado BIT NOT NULL;

DELETE FROM Lineas
DELETE FROM Documentos

SELECT * FROM Productos
SELECT * FROM Lineas
SELECT * FROM Documentos
SELECT * FROM NotasCreditoDocumentos

SELECT MAX(idDocumento)
FROM Documentos


UPDATE Productos
SET Cantidad = Cantidad - 10
WHERE idProducto = 1

