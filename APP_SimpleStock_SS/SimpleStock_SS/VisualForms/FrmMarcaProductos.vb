'Esta clase sigue el patron de diseño singleton que permite que solo exista una instancia de esta clase dentro de todo el programa

Imports SimpleStock_SS.ModObjectForm
Public Class FrmMarcaProductos

    ' Instancia Statica para garantizar una sola Instancia de la clase
    Private Shared _Singleton As FrmMarcaProductos

    ' Propiedad para obtener la instancia única
    Public Shared ReadOnly Property InstanciaMarcaProductos As FrmMarcaProductos
        Get
            ' Si la instancia estatica es nula o fue eliminada entonces
            If _Singleton Is Nothing OrElse _Singleton.IsDisposed Then
                ' Se crea una nueva instancia
                _Singleton = New FrmMarcaProductos()
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

    Private Sub FrmMarcaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '/*==================COLOR INICIAL DE PANELES PRINCIPALES DE FONDO=========================*/
        Me.BackColor = Color.FromArgb(247, 253, 232) ' #f7fde8 - Color de fondo
        LbTituloForm.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Titulo Superior
        BtnCrearNuevaMarca.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Crear
        BtnCambiarMarca.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Cambiar
        BtnEliminarMarca.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Eliminar
        PnConteinerMarca.BackColor = Color.FromArgb(207, 211, 218) '#cfd3da - Panel Inferior
        PnNombreMarca.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox NombreMarca
        PnDescripcionMarca.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox DescripcionMarca
        TbNombreMarca.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox NombreMarca
        TbDescripcionMarca.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox DescripcionMarca
        TbNombreMarca.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        TbDescripcionMarca.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        BtnGuardar.FlatAppearance.BorderColor = Color.FromArgb(207, 211, 218) '#cfd3da - Borde del Boton Guardar
        BtnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 215, 218) '#cfd3da - Al pasar el mouse arriba del Boton Guardar


        '/*==================Modificadores de Objetos======================================*/
        ModObjectForm.CrearBotonSemiCircular(BtnCrearNuevaMarca)
        ModObjectForm.CrearBotonSemiCircular(BtnCambiarMarca)
        ModObjectForm.CrearBotonSemiCircular(BtnEliminarMarca)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnConteinerMarca, 40)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnNombreMarca, 10)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnDescripcionMarca, 20)


    End Sub

End Class