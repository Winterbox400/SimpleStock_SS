Public Class FrmRegistroEntrada

    ' Instancia Statica para garantizar una sola Instancia de la clase
    Private Shared _Singleton As FrmRegistroEntrada

    ' Propiedad para obtener la instancia única
    Public Shared ReadOnly Property InstanciaRegistroEntrada As FrmRegistroEntrada
        Get
            ' Si la instancia estatica es nula o fue eliminada entonces
            If _Singleton Is Nothing OrElse _Singleton.IsDisposed Then
                ' Se crea una nueva instancia
                _Singleton = New FrmRegistroEntrada()
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



    Private Sub RegistroEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '/*==================COLOR INICIAL DE PANELES PRINCIPALES DE FONDO=========================*/
        Me.BackColor = Color.FromArgb(247, 253, 232) ' #f7fde8 - Color de fondo
        PnConteinerSuperior.BackColor = Color.FromArgb(197, 235, 241) ' #c5ebf1 - Color Panel Superior
        PnConteinerCentral.BackColor = Color.FromArgb(195, 190, 237) ' #c5ebf1 - Color Panel Central
        TbDescripcionRegistro.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        TbProducto.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        TbCantidad.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        TbPrecio.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        CbTipoRegistro.BackColor = Color.FromArgb(0, 151, 178) ' #0097b2 Color de Fondo del ComboBox Proveedores
        ModObjectForm.PersonalizarDataGridView(DgvVW_Registro)

        '/*====================Valores Iniciales de los Objetos==============================*/
        DAORegistroEntrada.LlenarGrid(DgvVW_Registro)
        DAORegistroEntrada.LlenarComboBox(CbTipoRegistro)
        TbDescripcionRegistro.Text = "Descripcion del Registro"

        '/*=========================Desabilitación inicial de Controles=========================*/
        TbProducto.Enabled = False
        TbCantidad.Enabled = False
        TbPrecio.Enabled = False
        BtnBuscarProducto.Enabled = False
        BtnCheckProducto.Enabled = False
        DgvVW_Registro.Enabled = False
        BtnGuardar.Enabled = False

    End Sub

    '/*========================================ZONA DE BOTONES======================================*/
    ' Variables y Objetos Utilies
    Dim DAORegistroEntrada As New DAORegistroEntrada()

    Private Sub BtnCheckRegistro_Click(sender As Object, e As EventArgs) Handles BtnCheckRegistro.Click
        ' Desabilitamos Codigo
        TbDescripcionRegistro.Enabled = False
        CbTipoRegistro.Enabled = False
        ' Habilitamos Codigo
        TbProducto.Enabled = True
        TbCantidad.Enabled = True
        TbPrecio.Enabled = True
        BtnBuscarProducto.Enabled = True
        BtnCheckProducto.Enabled = True
        DgvVW_Registro.Enabled = True
        BtnGuardar.Enabled = True
        ' Valores
        TbProducto.Text = "Producto"
        TbCantidad.Text = "Cantidad"
        TbPrecio.Text = "Precio"
    End Sub

    Private Sub BtnBuscarProducto_Click(sender As Object, e As EventArgs) Handles BtnBuscarProducto.Click
        OpenDoor = 1
        Dim formBuscarProducto As FrmBuscarProducto = FrmBuscarProducto.InstanciaBuscarProducto 'Crea una variable de la instancia singleton
        formBuscarProducto.Owner = Me 'Hace a la instancia del Formulario CatalogoProductos_Nuevo hija de CatalogoProducto
        formBuscarProducto.Show() ' Muestra el formulario en la pantalla
        formBuscarProducto.BringToFront() ' Manda el formulario enfrente del padre (CatalgoProducto)

        Me.Hide()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        OpenDoor = 0
        Me.Dispose()
    End Sub
End Class