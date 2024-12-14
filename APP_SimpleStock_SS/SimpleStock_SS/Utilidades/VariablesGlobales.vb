Module VariablesGlobales

    'Se usa para mandar valores de FrmCatalogoProducto a FrmCatalogoProducto_Actualizar
    Public ProductoGlobal As New Productos()

    Public Sub LimpiarProductoGlobal()
        ProductoGlobal.IdProducto = 0
        ProductoGlobal.Nombre = ""
        ProductoGlobal.Descripcion = ""
        ProductoGlobal.Almacen = ""
        ProductoGlobal.Ubicacion = ""
        ProductoGlobal.IdCategoria = 0
        ProductoGlobal.IdMarca = 0
        ProductoGlobal.IdProveedor = 0
        ProductoGlobal.IdUsuarioRegistro = 0
        ProductoGlobal.IdUsuarioActualiza = 0
    End Sub

    ' Es usada para evitar que abran 2 veces un form al tocar catalogo productos
    Public OpenDoor As Byte = 0
End Module
