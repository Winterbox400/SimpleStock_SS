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


    Private Sub FrmCatalogoProductos_Nuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '/*==================COLOR INICIAL DE PANELES PRINCIPALES DE FONDO=========================*/
        Me.BackColor = Color.FromArgb(247, 253, 232) ' #f7fde8 - Color de fondo
        LbTituloForm.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Titulo Superior
        PnConteinerPrincipal.BackColor = Color.FromArgb(207, 211, 218) '#cfd3da - Panel Principal
        PnNombreProductos.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox NombreProductos
        PnAlmacenProducto.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox AlmacenProducto
        PnUbicacionProducto.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox UbicacionProducto
        PnDescripcionProductos.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox DescripcionProducto
        TbNombreProductos.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox NombreProductos
        TbAlmacenProducto.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox AlmacenProducto
        TbUbicacionProducto.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox UbicacionProducto
        TbDescripcionProductos.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox DescripcionProducto
        TbNombreProductos.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        TbAlmacenProducto.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        TbUbicacionProducto.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        TbDescripcionProductos.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        CbCategoriaProducto.BackColor = Color.FromArgb(0, 151, 178) ' #0097b2 Color de Fondo del ComboBox Categorias
        CbCategoriaProducto.ForeColor = Color.FromArgb(255, 255, 255) ' #0097b2 Color de Letra del ComboBox Categorias
        CbMarcasProductos.BackColor = Color.FromArgb(0, 151, 178) ' #0097b2 Color de Fondo del ComboBox Marcas
        CbMarcasProductos.ForeColor = Color.FromArgb(255, 255, 255) ' #0097b2 Color de Letra del ComboBox Marcas
        CbProveedores.BackColor = Color.FromArgb(0, 151, 178) ' #0097b2 Color de Fondo del ComboBox Proveedores
        CbProveedores.ForeColor = Color.FromArgb(255, 255, 255) ' #0097b2 Color de Letra del ComboBox Proveedores
        CbProveedores.ForeColor = Color.FromArgb(255, 255, 255) ' #0097b2 Color de Letra del ComboBox Proveedores

        '/*==================Modificadores de Objetos======================================*/
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnConteinerPrincipal, 20)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnNombreProductos, 10)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnAlmacenProducto, 10)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnUbicacionProducto, 10)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnDescripcionProductos, 10)

        '/*====================Valores Iniciales de los Objetos==============================*/
        DAOCategoriaProductos.LlenarComboBox(CbCategoriaProducto) ' Agregamos Categorias al ComboBox
        DAOMarcasProductos.LlenarComboBox(CbMarcasProductos) ' Agregamos Marcas al ComboBox
        DAOProveedorProducto.LlenarComboBox(CbProveedores) ' Agregamos Proveedores al ComboBox


        '/*==================TEXTO INICIAL DE TEXTBOX=========================*/
        TbNombreProductos.Text = "Nombre del Producto"
        TbAlmacenProducto.Text = "Almacen del Producto"
        TbUbicacionProducto.Text = "Ubicacion del Producto"
        TbDescripcionProductos.Text = "Descripcion del Producto"
    End Sub

    '/*===============INSTANCIA DE CLASES PARA COMBOBOX=====================*/
    Dim DAOCategoriaProductos As New DAOCategoriaProducto()
    Dim DAOMarcasProductos As New DAOMarcaProductos()
    Dim DAOProveedorProducto As New DAOProveedorProducto()
    Dim DAOCatalogoProductos As New DAOCatalogoProducto()

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim RegProducto As New Productos()

        RegProducto.Nombre = TbNombreProductos.Text
        RegProducto.Descripcion = TbDescripcionProductos.Text
        RegProducto.Almacen = TbAlmacenProducto.Text
        RegProducto.Ubicacion = TbUbicacionProducto.Text
        RegProducto.IdCategoria = CInt(CbCategoriaProducto.SelectedValue)
        RegProducto.IdMarca = CInt(CbMarcasProductos.SelectedValue)
        RegProducto.IdProveedor = CInt(CbProveedores.SelectedValue)
        RegProducto.Activo = 1
        RegProducto.IdUsuarioRegistro = 1

        DAOCatalogoProductos.InsertarProducto(RegProducto.Nombre, RegProducto.Descripcion, RegProducto.Almacen, RegProducto.Ubicacion, RegProducto.IdCategoria, RegProducto.IdMarca, RegProducto.IdProveedor, RegProducto.Activo, RegProducto.IdUsuarioRegistro)
        MessageBox.Show("Valores guardados correctamente", "Nuevo Categoria Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information)

        OpenDoor = 0
        Dim formCatalogoProductos As FrmCatalogoProductos = FrmCatalogoProductos.InstanciaCatalogoProductos
        DAOCatalogoProductos.LlenarGrid(formCatalogoProductos.DgvVW_Productos)
        Me.Dispose()
        formCatalogoProductos.Show()
    End Sub

    ' Este boton cierra el formulario actual y nos regresa al formulario principal
    Private Sub BtnBackForm_Click(sender As Object, e As EventArgs) Handles BtnBackForm.Click
        OpenDoor = 0
        Dim formCatalogoProductos As FrmCatalogoProductos = FrmCatalogoProductos.InstanciaCatalogoProductos
        Me.Dispose()
        formCatalogoProductos.Show()
    End Sub


End Class