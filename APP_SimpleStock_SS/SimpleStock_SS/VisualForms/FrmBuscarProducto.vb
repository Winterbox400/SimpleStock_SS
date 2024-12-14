Public Class FrmBuscarProducto

    ' Instancia Statica para garantizar una sola Instancia de la clase
    Private Shared _Singleton As FrmBuscarProducto

    ' Propiedad para obtener la instancia única
    Public Shared ReadOnly Property InstanciaBuscarProducto As FrmBuscarProducto
        Get
            ' Si la instancia estatica es nula o fue eliminada entonces
            If _Singleton Is Nothing OrElse _Singleton.IsDisposed Then
                ' Se crea una nueva instancia
                _Singleton = New FrmBuscarProducto()
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


    Private Sub FrmBuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '/*==================COLOR INICIAL DE PANELES PRINCIPALES DE FONDO=========================*/
        Me.BackColor = Color.FromArgb(247, 253, 232) ' #f7fde8 - Color de fondo
        LbTituloForm.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Titulo Superior
        ModObjectForm.PersonalizarDataGridView(DgvVW_CatalogoProducto)
        DAOCatalogoProducto.LlenarGrid(DgvVW_CatalogoProducto)

    End Sub

    '/*========================================ZONA DE BOTONES======================================*/
    ' Variables y Objetos Utilies
    Dim DAOCatalogoProducto As New DAOCatalogoProducto()
    Dim DAORegistroEntrada As New DAORegistroEntrada()


    Private Sub DgvVW_CatalogoProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVW_CatalogoProducto.CellDoubleClick
        ProductoGlobal.IdProducto = DgvVW_CatalogoProducto.SelectedCells(0).Value
        ProductoGlobal.Nombre = DgvVW_CatalogoProducto.SelectedCells(1).Value

        OpenDoor = 0
        Dim formRegistroEntrada As FrmRegistroEntrada = FrmRegistroEntrada.InstanciaRegistroEntrada
        DAORegistroEntrada.LlenarGrid(formRegistroEntrada.DgvVW_Registro)
        formRegistroEntrada.TbProducto.Text = ProductoGlobal.Nombre
        Me.Dispose()
        formRegistroEntrada.Show()
    End Sub
End Class