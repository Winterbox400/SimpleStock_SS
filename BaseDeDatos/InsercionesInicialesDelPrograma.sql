/*INSERCIONES DE VALORES INICIALES PARA EL PROGRAMA*/
USE BD_SimpleStock_SS
GO

/*INSERSION DE ROLES*/
INSERT INTO Roles(Rol)
	VALUES	('Administrador'),
			('Jefe de Bodega'),
			('Auxiliar de Bodega')
GO

/*INSERSION DE USUARIOS*/
INSERT INTO Usuarios(Nombre, Contraseña, IdRol)
	VALUES	('WinterBox400','Spinosaurio', 1),
			('Signore Daltanias', 'Unete', 2),
			('Khaous Lios', 'Requiem', 3)
GO





--/*EL SIGUIENTE CONTENIDO DE ABAJO SERA ELIMINADO EN EL PROXIMO COMMIT*/
--/*SOLO ERAN VALORES DE PRUEBA PARA LA INSERCION DE DATOS DESDE LA APP*/

--SELECT * FROM Roles
--GO
--SELECT * FROM Usuarios
--GO
--SELECT * FROM Proveedores
--GO

--INSERT INTO Proveedores(Nombre, Telefono, Correo, Activo, IdUsuarioRegistro, FechaRegistro)
--	VALUES	(@nombre, @telefono, @correo, @activo, @idUsuarioRegsitro, GETDATE())
--GO

--UPDATE Proveedores SET Nombre = @nombre, Telefono = @telefono, Correo = @correo,
--		IdUsuarioActualiza = @idUsuarioActualiza, FechaActualizacion = GETDATE()
--		WHERE IdProveedor = @idProveedor

--UPDATE Proveedores SET Activo = @activo WHERE IdProveedor = @idProveedor
--GO

--SELECT * FROM vw_Proveedores
--GO
--SELECT * FROM Proveedores
--GO


--INSERT INTO Marcas(Nombre, Descripcion, Activo, IdUsuarioRegistro, FechaRegistro)
--	VALUES ()
--GO

--UPDATE Marcas
--SET Nombre = @Nombre, Descripcion = @Descripcion,
--	IdUsuarioActualiza = 1, FechaActualizacion = GETDATE()
--	WHERE IdMarca = @IdMarca
----GO

--UPDATE Marcas
--SET Activo = @activo
--	WHERE IdMarca = @idMarca

--SELECT * FROM vw_Marcas
--GO


/*CATEGORIAS*/
--SELECT * FROM Categorias
--GO

--INSERT INTO Categorias(Nombre, Descripcion, Activo, IdUsuarioRegistro, FechaRegistro)
--	VALUES	(@nombre, @descripcion, @activo, @idUsuarioRegistro, GETDATE())
--GO


--UPDATE Categorias SET Nombre = @nombre, Descripcion = @descripcion,
--		IdUsuarioActualiza = @idUsuarioActualiza, FechaActualizacion = GETDATE()
--		WHERE IdCategoria = @idCategoria
--GO

--UPDATE Categorias
--SET Activo = @activo
--	WHERE IdCategoria = @idCategoria
--GO

--SELECT * FROM vw_Categorias
--GO

/*CLIENTES*/
--SELECT * FROM Clientes
--GO
--SELECT * FROM vw_Clientes
--GO

--INSERT INTO Clientes(Nombre, Telefono, Correo, Activo, IdUsuarioRegistro, FechaRegistro)
--	VALUES (@nombre, @telefono, @correo, @activo, @idUsuarioRegistro, GETDATE())
--GO

--UPDATE Clientes SET Nombre = @nombre, Telefono = @telefono, Correo = @correo,
--		IdUsuarioActualiza = @idUsuarioActualiza, FechaActualizacion = GETDATE()
--		WHERE IdCliente = @idCliente
--GO

--UPDATE Clientes SET Activo = 1 WHERE IdCliente = 1
--GO


/*INSERSION DE CATALOGO PRODUCTOS*/
USE BD_SimpleStock_SS
GO
SELECT * FROM Productos
GO

----Insersion Nuevo Producto
--INSERT INTO Productos(Nombre, Descripcion, Almacen, Ubicacion, IdCategoria, IdMarca, IdProveedore, Activo, IdUsuarioRegistro, FechaRegistro)
--	VALUES (@nombre, @descripcion, @almacen, @ubicacion, @idCategoria, @idMarca, @idProveedor, 1, @idUsuarioRegistro, GETDATE())
--GO

--UPDATE Productos SET Nombre = @nombre, Descripcion = @descripcion, Almacen = @almacen, Ubicacion = @ubicacion, IdCategoria = @idCategoria, IdMarca = @idMarca, IdProveedore = @idProveedor, Activo = 0, IdUsuarioActualiza = @idUsuarioActualiza, FechaActualizacion = GETDATE()
--WHERE IdProducto = @idProducto
--GO

--UPDATE Productos SET Activo = @activo WHERE IdProducto = @idProducto
--GO