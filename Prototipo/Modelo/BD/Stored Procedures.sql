-- Aqu� se van a colocar todos los stored procedures que vayan a ocupar en el codigo
-- Pueden ejecutar los querys desde el propio Visual Studio ;)
USE SuperPatitosDB;

-- Obtener datos de un personal por correo y contrase�a
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