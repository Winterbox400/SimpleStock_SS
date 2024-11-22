Public Class FrmProveedoresProductos

    ' Instancia Statica para garantizar una sola Instancia de la clase
    Private Shared _Singleton As FrmProveedoresProductos

    ' Propiedad para obtener la instancia única
    Public Shared ReadOnly Property InstanciaProveedorProducto As FrmProveedoresProductos
        Get
            ' Si la instancia estatica es nula o fue eliminada entonces
            If _Singleton Is Nothing OrElse _Singleton.IsDisposed Then
                ' Se crea una nueva instancia
                _Singleton = New FrmProveedoresProductos()
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

    Private Sub FrmProveedoresProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '/*==================COLOR INICIAL DE PANELES PRINCIPALES DE FONDO=========================*/
        Me.BackColor = Color.FromArgb(247, 253, 232) ' #f7fde8 - Color de fondo
        LbTituloForm.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Titulo Superior
        BtnCrearNuevoProveedor.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Crear
        BtnCambiarProveedor.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Cambiar
        BtnEliminarProveedor.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Eliminar
        PnConteinerProveedor.BackColor = Color.FromArgb(207, 211, 218) '#cfd3da - Panel Superior Derecho
        PnNombreProveedor.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox NombreProveedor
        PnCorreoProveedor.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox CorreoProveedor
        PnCelularProveedor.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox CelularProveedor
        TbNombreProveedor.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox NombreProveedor
        TbCorreoProveedor.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox CorreoProveedor
        TbCelularProveedor.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox CelularProveedor
        TbNombreProveedor.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        TbCorreoProveedor.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        TbCelularProveedor.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        BtnGuardar.FlatAppearance.BorderColor = Color.FromArgb(207, 211, 218) '#cfd3da - Borde del Boton Guardar
        BtnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 215, 218) '#cfd3da - Al pasar el mouse arriba del Boton Guardar


        '/*==================Modificadores de Objetos======================================*/
        ModObjectForm.CrearBotonEsquinasSemiCirculares(BtnCrearNuevoProveedor, 15)
        ModObjectForm.CrearBotonEsquinasSemiCirculares(BtnCambiarProveedor, 15)
        ModObjectForm.CrearBotonEsquinasSemiCirculares(BtnEliminarProveedor, 15)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnConteinerProveedor, 30)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnNombreProveedor, 10)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnCorreoProveedor, 10)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnCelularProveedor, 10)

    End Sub
End Class