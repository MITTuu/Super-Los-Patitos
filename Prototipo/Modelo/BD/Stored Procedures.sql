-- Aquí se van a colocar todos los stored procedures que vayan a ocupar en el codigo
-- Pueden ejecutar los querys desde el propio Visual Studio ;)
USE SuperPatitosDB;

-- Obtener datos de un personal por correo y contraseña
CREATE PROCEDURE GetPersonalByEmailPassword
    @Correo VARCHAR(100),
    @Contrasena VARCHAR(100)
AS
BEGIN
    SELECT 
        idPersonal,
        Nombre,
        PrimerApellido,
        SegundoApellido,
        Correo,
        Telefono,
        Identificacion,
        idTipoIdentificacion,
        idRol
    FROM 
        Personal
    WHERE 
        Correo = @Correo
        AND Contrasena = @Contrasena;
END;

-- Obtener datos del personal por su id
CREATE PROCEDURE GetPersonalByID
    @idPersonal int
AS
BEGIN
    SELECT 
        idPersonal,
        Nombre,
        PrimerApellido,
        SegundoApellido,
        Correo,
        Telefono,
        Identificacion,
        idTipoIdentificacion,
        idRol
    FROM 
        Personal
    WHERE 
        idPersonal = @idPersonal
END;

-- Stored procedures Clientes
-- Obtener los datos de un cliente por su identificación
CREATE PROCEDURE GetClienteByIdentificacion
    @identificacion VARCHAR(50)
AS
BEGIN
    SELECT 
        idCliente,
        Nombre,
        PrimerApellido,
        SegundoApellido,
        Correo,
        Telefono,
        Identificacion,
        idTipoIdentificacion
    FROM 
        Clientes
    WHERE 
        Identificacion = @identificacion
END;

-- Insertar un cliente
CREATE PROCEDURE InsertCliente
    @Nombre VARCHAR(50),
    @PrimerApellido VARCHAR(50),
    @SegundoApellido VARCHAR(50),
    @Correo VARCHAR(100),
    @Telefono VARCHAR(20),
	@Identificacion VARCHAR(50),
    @idTipoIdentificacion INT 
AS
BEGIN
    -- Insertar el nuevo cliente en la tabla Clientes
    INSERT INTO Clientes (Nombre, PrimerApellido, SegundoApellido, Correo, Telefono, Identificacion, idTipoIdentificacion)
    VALUES (@Nombre, @PrimerApellido, @SegundoApellido, @Correo, @Telefono, @Identificacion, @idTipoIdentificacion);
END;

-- Stored Procedures Productos
-- Obtener los datos de los productos 
CREATE PROCEDURE GetProductos
AS
BEGIN
    SELECT 
    idProducto,
    Nombre,
    Codigo,
    PrecioUnitario,
    Cantidad,
    idUnidadMedida
    FROM 
        Productos
	WHERE Cantidad > 0;
END;

-- Obtener los datos de los productos por nombre
CREATE PROCEDURE GetProductosByNombre
	@NombreBuscar VARCHAR(50)
AS
BEGIN
    SELECT 
    idProducto,
    Nombre,
    Codigo,
    PrecioUnitario,
    Cantidad,
    idUnidadMedida
    FROM 
        Productos
   WHERE 
        Nombre LIKE '%' + @NombreBuscar + '%' AND
		Cantidad > 0;
END;

-- Obtener los datos de los productos por codigo
CREATE PROCEDURE GetProductosByCodigo
	@codigoBuscar VARCHAR(50)
AS
BEGIN
    SELECT 
    idProducto,
    Nombre,
    Codigo,
    PrecioUnitario,
    Cantidad,
    idUnidadMedida
    FROM 
        Productos
   WHERE 
        Codigo LIKE '%' + @codigoBuscar + '%' AND
		Cantidad > 0;
END;

-- Restar la cantidad de producto facturado
CREATE PROCEDURE RestaCantidadProducto
	@idProducto INT,
	@CantidadResta DECIMAL(10,3)
AS
BEGIN
	UPDATE Productos
	SET Cantidad = Cantidad - @CantidadResta
	WHERE idProducto = @idProducto
END;

-- Stored procedures Facturacion
-- Obtener el siguiente consecutivo según el idTipoDocumento
CREATE PROCEDURE GetSiguienteConsecutivo
    @idTipoDocumento INT
AS
BEGIN
    DECLARE @SiguienteConsecutivo INT;

    -- Obtener el máximo valor de Consecutivo para el idTipoDocumento dado
    SELECT @SiguienteConsecutivo = ISNULL(MAX(Consecutivo), 0) + 1
    FROM Documentos
    WHERE idTipoDocumento = @idTipoDocumento;

    -- Devolver el siguiente valor de Consecutivo
    SELECT @SiguienteConsecutivo AS SiguienteConsecutivo;
END;

-- Obtener idDocumento
CREATE PROCEDURE GetIdDoc
AS
BEGIN
    -- Obtener el máximo idDocumento
	SELECT MAX(idDocumento)
	FROM Documentos
END;

-- Stored procedure Para facturar
-- Insertar una linea
CREATE PROCEDURE InsertLinea
    @idDocumento INT,
    @Cantidad DECIMAL(10,3),
    @idProducto INT,
    @Subtotal DECIMAL(10,2),
    @Impuesto DECIMAL(10,2),
    @Total DECIMAL(10,2)
AS
BEGIN
    -- Insertar la nueva línea en la tabla Lineas
    INSERT INTO Lineas (idDocumento, Cantidad, idProducto, Subtotal, Impuesto, Total, Estado)
    VALUES (@idDocumento, @Cantidad, @idProducto, @Subtotal, @Impuesto, @Total, 1);
END;

-- Insertar un documento
CREATE PROCEDURE InsertDocumento
    @idTipoDocumento INT,
    @Consecutivo INT,
    @idPersonal INT,
    @idCliente INT,
    @TotalImpuestos DECIMAL(10,2),
    @Subtotal DECIMAL(10,2),
    @Total DECIMAL(10,2)
AS
BEGIN
    -- Insertar un nuevo registro en la tabla Documentos
    INSERT INTO Documentos (idTipoDocumento, FechaCreacion, Consecutivo, idPersonal, idCliente, TotalImpuestos, Subtotal, Total, Estado)
    VALUES (@idTipoDocumento, GETDATE(), @Consecutivo, @idPersonal, @idCliente, @TotalImpuestos, @Subtotal, @Total, 1);
END;

-- Mostrar documentos
CREATE PROCEDURE GetDocumentos
AS
BEGIN
	SELECT
		d.idDocumento,
		td.TipoDocumento AS TipoDocumento,
		d.FechaCreacion,
		d.Consecutivo,
		d.idCliente,
		CONCAT(p.Nombre, ' ', p.PrimerApellido) AS NombrePersonal,
		CONCAT(c.Nombre, ' ', c.PrimerApellido) AS NombreCliente,
		d.TotalImpuestos,
		d.Subtotal,
		d.Total,
		d.Estado
	FROM
		Documentos d
	JOIN
		TiposDocumento td ON d.idTipoDocumento = td.idTipoDocumento
	JOIN
		Personal p ON d.idPersonal = p.idPersonal
	LEFT JOIN
		Clientes c ON d.idCliente = c.idCliente;
END;

-- Stored Procedures para aplicar notas de crédito
-- Acturalizar la cantidad de un producto
CREATE PROCEDURE SumaCantidadProducto
    @idProducto INT,
    @CantidadSuma DECIMAL(10,3)
AS
BEGIN
    UPDATE Productos
    SET Cantidad = Cantidad + @CantidadSuma
    WHERE idProducto = @idProducto;
END;

-- Actualizar el estado de una linea
CREATE PROCEDURE ActualizarEstadoLineas
    @idDocumento INT
AS
BEGIN
    UPDATE Lineas
    SET Estado = 0
    WHERE idDocumento = @idDocumento;
END;

-- Actualizar el estado de un documento
CREATE PROCEDURE ActualizarEstadoDocumento
    @idDocumento INT
AS
BEGIN
    UPDATE Documentos
    SET Estado = 0
    WHERE idDocumento = @idDocumento;
END;

-- Obtener los productos de la linea con el idDocumento
CREATE PROCEDURE GetProductosByIdDocumento
    @idDocumento INT
AS
BEGIN
    SELECT idProducto, Cantidad
    FROM Lineas
    WHERE idDocumento = @idDocumento;

    EXEC ActualizarEstadoLineas @idDocumento = @idDocumento;

    EXEC ActualizarEstadoDocumento @idDocumento = @idDocumento;
END;

