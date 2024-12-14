Module VariablesGlobales

    'Se usa para mandar valores de FrmCatalogoProducto a FrmCatalogoProducto_Actualizar
    Public ProductoGlobal As New Productos()

    ' Es usada para evitar que abran 2 veces un form al tocar catalogo productos
    Public OpenDoor As Byte = 0
End Module
