USE SuperPatitosDB;

-- Stored Procedure Personal
-- Obtener datos de un personal por correo y contrasena
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
-- Obtener los datos de un cliente por su identificaci�n
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

-- Stored Procedure Productos
-- Insertar un nuevo producto en la BD
CREATE PROCEDURE InsertProducto
    @Nombre VARCHAR(100),
    @Codigo VARCHAR(50),
    @PrecioUnitario DECIMAL(10,2),
    @Cantidad DECIMAL(10,3),
    @idUnidadMedida INT
AS
BEGIN
    INSERT INTO Productos (Nombre, Codigo, PrecioUnitario, Cantidad, idUnidadMedida)
    VALUES (@Nombre, @Codigo, @PrecioUnitario, @Cantidad, @idUnidadMedida);
END;

-- Modificar producto
CREATE PROCEDURE ModifyProducto
    @idProducto INT,
    @Nombre VARCHAR(100),
    @Codigo VARCHAR(50),
    @PrecioUnitario DECIMAL(10,2),
    @Cantidad DECIMAL(10,3),
    @idUnidadMedida INT
AS
BEGIN
    UPDATE Productos
    SET Nombre = @Nombre,
    Codigo = @Codigo,
    PrecioUnitario = @PrecioUnitario,
    Cantidad = @Cantidad,
    idUnidadMedida = @idUnidadMedida
    WHERE idProducto = @idProducto
END;

-- Seleccionar los productos que tengan coincidencias con la busqueda
CREATE PROCEDURE SelectProductoCoincidencia
    @busqueda VARCHAR(100)
AS
BEGIN
    SELECT idProducto AS ID, Nombre, Codigo, PrecioUnitario AS Precio, u.UnidadMedida AS Medida, Cantidad
    FROM Productos AS p
    INNER JOIN UnidadesMedida AS u ON p.idUnidadMedida = u.idUnidadMedida
    WHERE Nombre LIKE CONCAT('%',@busqueda,'%');
END;

-- insertar un ajuste de inventario
CREATE PROCEDURE InsertAjuste
    @Razon VARCHAR(255),
    @idPersonal INT
AS
BEGIN
    INSERT INTO Ajustes
        (FechaAjuste, Razon, idPersonal)
        VALUES
        (CURRENT_TIMESTAMP, @Razon, @idPersonal);
    SELECT SCOPE_IDENTITY();
END;

-- Insertar un ajuste individual de producto
CREATE PROCEDURE InsertAjusteProducto
    @idProducto INT,
    @CantidadAjustada Decimal(10,3),
    @idAjuste INT
AS
BEGIN
    -- insertar ajuste
    INSERT INTO AjustesProducto
        (idProducto, CantidadAjustada, idAjuste)
        VALUES
        (@idProducto, @CantidadAjustada, @idAjuste);
    
    -- modificar inventario
    UPDATE Productos
        SET Cantidad = (Cantidad + @CantidadAjustada)
        WHERE idProducto = @idProducto;
END;
END

-- Seleccionar informaci�n basica/general de todos los ajustes
CREATE PROCEDURE SelectAjustes
AS
BEGIN
    SELECT idAjuste AS [ID], a.FechaAjuste AS [Fecha], a.Razon, CONCAT_WS(' ', p.Nombre, p.PrimerApellido) AS [Responsable]
    FROM Ajustes AS a
    LEFT JOIN Personal AS p ON a.idPersonal = p.idPersonal
    ORDER BY idAjuste DESC
END

-- Selecciona la info de 1 por medio de su ID
CREATE PROCEDURE SelectAjusteById
    @idAjuste INT
AS
BEGIN
    SELECT a.FechaAjuste AS [Fecha], a.Razon, CONCAT_WS(' ', p.Nombre, p.PrimerApellido) AS [Responsable]
    FROM Ajustes AS a
    LEFT JOIN Personal AS p ON a.idPersonal = p.idPersonal 
    WHERE a.idAjuste = @idAjuste
END

-- Seleccionar ajustes de productos individuales asociados a un ajuste
CREATE PROCEDURE SelectAjustesProdutos
    @idAjuste INT
AS
BEGIN
    SELECT p.Nombre AS [Producto], a.CantidadAjustada AS [Cantidad Ajustada]
    FROM AjustesProducto AS a
    LEFT JOIN Productos AS p ON a.idProducto = p.idProducto
    WHERE a.idAjuste = @idAjuste
END

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
-- Obtener el siguiente consecutivo seg�n el idTipoDocumento
CREATE PROCEDURE GetSiguienteConsecutivo
    @idTipoDocumento INT
AS
BEGIN
    DECLARE @SiguienteConsecutivo INT;

    -- Obtener el m�ximo valor de Consecutivo para el idTipoDocumento dado
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
    -- Obtener el m�ximo idDocumento
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
    -- Insertar la nueva l�nea en la tabla Lineas
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

-- Stored Procedures para aplicar notas de cr�dito
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

-- Stored Procedure Informes
-- Mostrar Facuras activas en el rango de fecha dado
CREATE PROCEDURE GetDocumentosFI
    @FechaInicio DATE,
    @FechaFin DATE
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
        Clientes c ON d.idCliente = c.idCliente
    WHERE
        d.idTipoDocumento = 1  -- Factura
        AND d.Estado = 1       -- Activo
        AND d.FechaCreacion BETWEEN @FechaInicio AND @FechaFin;
END;

-- Obtener el producto mas vendido
CREATE PROCEDURE GetProductoMasVendido
AS
BEGIN
    SELECT TOP 1
        p.Nombre AS Producto,
        p.Codigo AS CodigoProducto,
        SUM(l.Cantidad) AS TotalVendido
    FROM
        Lineas l
    INNER JOIN
        Productos p ON l.idProducto = p.idProducto
    GROUP BY
        p.Nombre, p.Codigo
    ORDER BY
        SUM(l.Cantidad) DESC;
END;

-- Top 5 clientes que mas compran
CREATE PROCEDURE GetTop5ClientesQueMasCompran
AS
BEGIN
    SELECT TOP 5
        c.Identificacion AS Identificacion,
        CONCAT(c.Nombre, ' ', c.PrimerApellido, ' ', ISNULL(c.SegundoApellido, '')) AS NombreCompleto,
        COUNT(d.idDocumento) AS CantidadDocumentos
    FROM
        Clientes c
    LEFT JOIN
        Documentos d ON c.idCliente = d.idCliente
    WHERE
        d.idTipoDocumento IN (1, 2) -- Factura o Tiquete
        AND d.Estado = 1 -- Estado activo
    GROUP BY
        c.Identificacion, c.Nombre, c.PrimerApellido, c.SegundoApellido
    ORDER BY
        COUNT(d.idDocumento) DESC;
END;

-- Info para grafico de ventas
CREATE PROCEDURE GetVentasGrafico
AS
BEGIN
    SELECT FechaCreacion AS Fecha, SUM(l.Cantidad) AS Ventas
    FROM Lineas AS l
    INNER JOIN Documentos AS d ON l.idDocumento = d.idDocumento
    WHERE FechaCreacion >= DATEADD(DAY, -7, GETDATE())
    GROUP BY FechaCreacion
    ORDER BY FechaCreacion DESC
END