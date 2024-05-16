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

-- Insertar un nuevo producto en la BD
CREATE PROCEDURE InsertProducto
    @Nombre VARCHAR(100),
    @Codigo VARCHAR(50),
    @PrecioUnitario DECIMAL(10,2),
    @Cantidad INT,
    @idUnidadMedida INT
AS
BEGIN
    INSERT INTO Productos (Nombre, Codigo, PrecioUnitario, Cantidad, idUnidadMedida)
    VALUES (@Nombre, @Codigo, @PrecioUnitario, @Cantidad, @idUnidadMedida);
END;

-- Seleccionar los productos que tengan coincidencias con la busqueda
CREATE PROCEDURE SelectProductoCoincidencia
    @busqueda VARCHAR(100)
AS
BEGIN
    SELECT idProducto AS ID, Nombre, Codigo, CONCAT(PrecioUnitario, '/', SUBSTRING(u.UnidadMedida, 0, 4)) AS Precio, Cantidad
    FROM Productos AS p
    INNER JOIN UnidadesMedida AS u ON p.idUnidadMedida = u.idUnidadMedida
    WHERE Nombre LIKE CONCAT('%',@busqueda,'%');
END

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
END

-- Insertar un ajuste individual de producto
CREATE PROCEDURE InsertAjusteProducto
    @idProducto INT,
    @CantidadAjustada INT,
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
END

-- Seleccionar información basica/general de todos los ajustes
CREATE PROCEDURE SelectAjustes
AS
BEGIN
    SELECT idAjuste AS [ID], a.FechaAjuste AS [Fecha], a.Razon, CONCAT_WS(' ', p.Nombre, p.PrimerApellido) AS [Responsable]
    FROM Ajustes AS a
    LEFT JOIN Personal AS p ON a.idPersonal = p.idPersonal
    ORDER BY FechaAjuste DESC
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