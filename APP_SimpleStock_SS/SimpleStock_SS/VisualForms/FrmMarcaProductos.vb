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
        DgvVW_Marcas.BackgroundColor = Color.FromArgb(247, 253, 232) ' #f7fde8 - Color de fondo de DataGridView
        ModObjectForm.PersonalizarDataGridView(DgvVW_Marcas)


        '/*==================Modificadores de Objetos======================================*/
        ModObjectForm.CrearBotonSemiCircular(BtnCrearNuevaMarca)
        ModObjectForm.CrearBotonSemiCircular(BtnCambiarMarca)
        ModObjectForm.CrearBotonSemiCircular(BtnEliminarMarca)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnConteinerMarca, 40)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnNombreMarca, 10)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnDescripcionMarca, 20)

        '/*====================Valores Iniciales de los Objetos==============================*/
        DAOMarcaProductos.LlenarGrid(DgvVW_Marcas)
    End Sub

    '/*========================================ZONA DE BOTONES======================================*/
    ' Variables y Objetos Utilies
    Dim DAOMarcaProductos As New DAOMarcaProductos()
    Dim OpcionButton As Integer = 0
    Dim Id As Integer = Nothing

    Private Sub LimpiarValores()
        OpcionButton = 0
        TbNombreMarca.Text = ""
        TbDescripcionMarca.Text = ""
    End Sub

    'Botton Crear Marca
    Private Sub BtnCrearNuevaMarca_Click(sender As Object, e As EventArgs) Handles BtnCrearNuevaMarca.Click
        OpcionButton = 1
        TbNombreMarca.Text = "Nombre de la Marca"
        TbDescripcionMarca.Text = "Breve Descripcion de la Marca"

    End Sub

    'Botton Cambiar Marca
    Private Sub BtnCambiarMarca_Click(sender As Object, e As EventArgs) Handles BtnCambiarMarca.Click
        OpcionButton = 2
        TbNombreMarca.Text = "Selecciona una Marca en la tabla"
        TbDescripcionMarca.Text = "Reescribe la informacion"
    End Sub

    'Botton Eliminar Marca
    Private Sub BtnEliminarMarca_Click(sender As Object, e As EventArgs) Handles BtnEliminarMarca.Click
        OpcionButton = 3
        TbNombreMarca.Text = "Selecciona una Marca en la tabla"
        TbDescripcionMarca.Text = "Guarda para borrar la informacion"
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        ' Estado Inicial del Boton
        If OpcionButton = 0 Then
            MessageBox.Show("No ha seleccionado una opción valida" & vbCrLf & " Pruebe tocando el boton: Crear, Cambiar o Eliminar")
        End If

        'Insertar Nueva Marca
        If OpcionButton = 1 Then
            Dim RegMarcas As New Marcas()

            'Asignación de valores
            RegMarcas.Nombre = TbNombreMarca.Text
            RegMarcas.Descripcion = TbDescripcionMarca.Text
            RegMarcas.Activo = 1
            RegMarcas.IdUsuarioRegsitro = 1

            ' llamada al metodo para la inserción
            DAOMarcaProductos.InsertarMarca(RegMarcas.Nombre, RegMarcas.Descripcion, RegMarcas.Activo, RegMarcas.IdUsuarioRegsitro)
            MessageBox.Show("Valores guardados correctamente", "Nuevo Marca Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' limpieza de valores
            LimpiarValores()
            DAOMarcaProductos.LlenarGrid(DgvVW_Marcas) 'Se vuelva a llenar el DataGriedView
        End If

        'Actualizar una Marca
        If OpcionButton = 2 Then
            Dim RegMarcas As New Marcas()

            'Asignación de valores
            RegMarcas.IdMarca = Id
            RegMarcas.Nombre = TbNombreMarca.Text
            RegMarcas.Descripcion = TbDescripcionMarca.Text
            RegMarcas.IdUsuarioActualiza = 1

            DAOMarcaProductos.ActualizarMarca(RegMarcas.Nombre, RegMarcas.Descripcion, RegMarcas.IdUsuarioActualiza, RegMarcas.IdMarca)
            MessageBox.Show("Valores Actualizados correctamente", "Cambiar Marca Existente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' limpieza de valores
            LimpiarValores()
            DAOMarcaProductos.LlenarGrid(DgvVW_Marcas) 'Se vuelva a llenar el DataGriedView
        End If

        If OpcionButton = 3 Then
            Dim RegMarcas As New Marcas()

            ' Asignación de valores
            RegMarcas.IdMarca = Id
            RegMarcas.Activo = 0

            DAOMarcaProductos.EliminarMarca(RegMarcas.Activo, RegMarcas.IdMarca)
            MessageBox.Show("Valore Eliminado correctamente", "Elimnar Marca Existente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' limpieza de valores
            LimpiarValores()
            DAOMarcaProductos.LlenarGrid(DgvVW_Marcas) 'Se vuelva a llenar el DataGriedView
        End If
    End Sub

    Private Sub DgvVW_Marcas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVW_Marcas.CellClick
        'Solo manda valores a los TextBox si se toca el boton Cambiar
        If OpcionButton = 2 Or OpcionButton = 3 Then
            TbNombreMarca.Text = DgvVW_Marcas.SelectedCells(1).Value
            TbDescripcionMarca.Text = DgvVW_Marcas.SelectedCells(2).Value
            Id = DgvVW_Marcas.SelectedCells(0).Value
        End If

    End Sub


End Class