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
