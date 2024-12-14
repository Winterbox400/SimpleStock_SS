/*CREACIÓN DE VISTAS PARA LA APP "SIMPLESTOCK SS"	*/
/*Author	@JUSTIN STEVEN DETRINIDAD SANDIGO		*/
/*Nickname	@WINTERBOX400							*/


USE BD_SimpleStock_SS
GO

/*Insertar productos en RegistroEntrada
Procedimiento almacenado para ingresar valores en el Grid de Registro Entrada
*/
CREATE PROCEDURE InsertarDetalleProducto
    @IdDetalleRegistroEntrada INT,
    @IdRegistroEntrada INT,
    @IdProducto INT,
    @Cantidad INT,
    @PrecioCompra DECIMAL(20,2),
    @Activo BIT,
    @IdUsuarioRegistro INT

AS
BEGIN
    INSERT INTO DetalleRegistroEntrada (IdDetalleRegistroEntrada, IdRegistroEntrada, IdProducto, Cantidad, PrecioCompra, Activo, IdUsuarioRegistro, FechaRegistro)
    VALUES (@IdDetalleRegistroEntrada, @IdRegistroEntrada, @IdProducto, @Cantidad, @PrecioCompra, @Activo, @IdUsuarioRegistro, GETDATE())
END
GO

SELECT * FROM DetalleRegistroEntrada
GO