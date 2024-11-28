Public Class FrmCatalogoProductos_Nuevo

    ' Instancia Statica para garantizar una sola Instancia de la clase
    Private Shared _Singleton As FrmCatalogoProductos_Nuevo

    ' Propiedad para obtener la instancia única
    Public Shared ReadOnly Property InstanciaCatalogoProductos_Nuevo As FrmCatalogoProductos_Nuevo
        Get
            ' Si la instancia estatica es nula o fue eliminada entonces
            If _Singleton Is Nothing OrElse _Singleton.IsDisposed Then
                ' Se crea una nueva instancia
                _Singleton = New FrmCatalogoProductos_Nuevo()
            End If
            ' finalmente se retorna la instnacia activa o nueva
            Return _Singleton
        End Get
    End Property

    'Constructor Privado para evitar instancias Externas
    Private Sub New()
        ' Esta llamada es exigida por el IDE
        InitializeComponent()
    End Sub


    Private Sub PnConteinerProductos_Paint(sender As Object, e As PaintEventArgs) Handles PnConteinerProductos.Paint
        'ModObjectForm.ConfigurarComboBox(ComboBox1)
        DAOCategoriaProductos.PruebaComboBox(ComboBox1)
        DAOCategoriaProductos.PruebaComboBox(ComboBox2)

    End Sub

    Dim DAOCategoriaProductos As New DAOCategoriaProducto()

End Class