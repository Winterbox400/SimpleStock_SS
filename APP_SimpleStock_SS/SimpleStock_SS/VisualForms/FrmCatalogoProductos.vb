Public Class FrmCatalogoProductos

    ' Instancia Statica para garantizar una sola Instancia de la clase
    Private Shared _Singleton As FrmCatalogoProductos

    ' Propiedad para obtener la instancia única
    Public Shared ReadOnly Property InstanciaCatalogoProductos As FrmCatalogoProductos
        Get
            ' Si la instancia estatica es nula o fue eliminada entonces
            If _Singleton Is Nothing OrElse _Singleton.IsDisposed Then
                ' Se crea una nueva instancia
                _Singleton = New FrmCatalogoProductos()
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


    Private Sub FrmCatalogoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '/*==================COLOR INICIAL DE PANELES PRINCIPALES DE FONDO=========================*/
        Me.BackColor = Color.FromArgb(247, 253, 232) ' #f7fde8 - Color de fondo
        LbTituloForm.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Titulo Superior
        BtnCrearNuevoProducto.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Crear
        BtnCambiarProducto.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Cambiar
        BtnEliminarProducto.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Eliminar
        PnConteinerProductos.BackColor = Color.FromArgb(207, 211, 218) '#cfd3da - Panel Superior Derecho
        PnNombreProductos.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox NombreProductos
        PnDescripcionProductos.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox DescripcionProductos
        TbNombreProductos.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox NombreProductos
        TbDescripcionProductos.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox DescripcionProductos
        TbNombreProductos.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        TbDescripcionProductos.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        DgvVW_Productos.BackgroundColor = Color.FromArgb(247, 253, 232) ' #f7fde8 - Color de fondo de DataGridView
        ModObjectForm.PersonalizarDataGridView(DgvVW_Productos)

        '/*==================Modificadores de Objetos======================================*/
        ModObjectForm.CrearBotonEsquinasSemiCirculares(BtnCrearNuevoProducto, 15)
        ModObjectForm.CrearBotonEsquinasSemiCirculares(BtnCambiarProducto, 15)
        ModObjectForm.CrearBotonEsquinasSemiCirculares(BtnEliminarProducto, 15)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnConteinerProductos, 30)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnNombreProductos, 10)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnDescripcionProductos, 10)

    End Sub

    Private Sub BtnCrearNuevoProducto_Click(sender As Object, e As EventArgs) Handles BtnCrearNuevoProducto.Click

        Dim formCatalogoProductos_Nuevo As FrmCatalogoProductos_Nuevo = FrmCatalogoProductos_Nuevo.InstanciaCatalogoProductos_Nuevo 'Crea una variable de la instancia singleton
        formCatalogoProductos_Nuevo.Owner = Me 'Hace a la instancia del Formulario Proveedor Productos hija de Home
        formCatalogoProductos_Nuevo.Show() ' Muestra el formulario en la pantalla
        formCatalogoProductos_Nuevo.BringToFront() ' Manda el formulario enfrente del padre (Home)

        formCatalogoProductos_Nuevo.Show()
        Me.Hide()
    End Sub
End Class