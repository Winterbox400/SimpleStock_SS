Public Class FrmCategoriaProductos

    ' Instancia Statica para garantizar una sola Instancia de la clase
    Private Shared _Singleton As FrmCategoriaProductos

    ' Propiedad para obtener la instancia única
    Public Shared ReadOnly Property InstanciaCategoriaProductos As FrmCategoriaProductos
        Get
            ' Si la instancia estatica es nula o fue eliminada entonces
            If _Singleton Is Nothing OrElse _Singleton.IsDisposed Then
                ' Se crea una nueva instancia
                _Singleton = New FrmCategoriaProductos()
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



    Private Sub FrmCategoriaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(247, 253, 232) ' #f7fde8 - Color de fondo
        LbTituloForm.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Titulo Superior
        BtnCrearNuevaCategoria.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Crear
        BtnCambiarCategoria.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Cambiar
        BtnEliminarCategoria.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Eliminar
        PnConteinerCategoria.BackColor = Color.FromArgb(207, 211, 218) '#cfd3da - Panel Inferior
        PnNombreCategoria.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox NombreCategoria
        PnDescripcionCategoria.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox DescripcionCategoria
        TbNombreCategoria.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox NombreCategoria
        TbDescripcionCategoria.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox DescripcionCategoria
        TbNombreCategoria.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        TbDescripcionCategoria.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        BtnGuardar.FlatAppearance.BorderColor = Color.FromArgb(207, 211, 218) '#cfd3da - Borde del Boton Guardar
        BtnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 215, 218) '#cfd3da - Al pasar el mouse arriba del Boton Guardar
        DgvVW_Categoria.BackgroundColor = Color.FromArgb(247, 253, 232) ' #f7fde8 - Color de fondo de DataGridView
        ModObjectForm.PersonalizarDataGridView(DgvVW_Categoria)

        '/*==================Modificadores de Objetos======================================*/
        ModObjectForm.CrearBotonSemiCircular(BtnCrearNuevaCategoria)
        ModObjectForm.CrearBotonSemiCircular(BtnCambiarCategoria)
        ModObjectForm.CrearBotonSemiCircular(BtnEliminarCategoria)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnConteinerCategoria, 40)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnNombreCategoria, 10)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnDescripcionCategoria, 20)


        '/*====================Valores Iniciales de los Objetos==============================*/
        DAOCategoriaProductos.LlenarGrid(DgvVW_Categoria)
        LbSubTituloPanel.Text = ""
    End Sub

    '/*========================================ZONA DE BOTONES======================================*/
    ' Variables y Objetos Utilies
    Dim DAOCategoriaProductos As New DAOCategoriaProducto()
    Dim OpcionButton As Integer = 0
    Dim Id As Integer = Nothing

    Private Sub LimpiarValores()
        OpcionButton = 0
        TbNombreCategoria.Text = ""
        TbDescripcionCategoria.Text = ""
        LbSubTituloPanel.Text = ""
    End Sub

    ' Botton Crear Categoria
    Private Sub BtnCrearNuevaCategoria_Click(sender As Object, e As EventArgs) Handles BtnCrearNuevaCategoria.Click
        OpcionButton = 1
        TbNombreCategoria.Text = "Nombre de la Categoria"
        TbDescripcionCategoria.Text = "Breve Descripcion de la Categoria"
        LbSubTituloPanel.Text = "Ingrese la nueva Categoria y su Descripcion"
    End Sub

    ' Botton Cambiar Categoria
    Private Sub BtnCambiarCategoria_Click(sender As Object, e As EventArgs) Handles BtnCambiarCategoria.Click
        OpcionButton = 2
        TbNombreCategoria.Text = "Selecciona una Categoria en la tabla"
        TbDescripcionCategoria.Text = "Reescribe la informacion"
        LbSubTituloPanel.Text = "Modifique una Categoria existente de la tabla"
    End Sub

    ' Botton Eliminar Categoria
    Private Sub BtnEliminarCategoria_Click(sender As Object, e As EventArgs) Handles BtnEliminarCategoria.Click
        OpcionButton = 3
        TbNombreCategoria.Text = "Selecciona una Categoria en la tabla"
        TbDescripcionCategoria.Text = "Guarda para borrar la informacion"
        LbSubTituloPanel.Text = "Elimine una Categoria Existente de la tabla"
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        ' Estado Inicial del Boton
        If OpcionButton = 0 Then
            MessageBox.Show("No ha seleccionado una opción valida" & vbCrLf & " Pruebe tocando el boton: Crear, Cambiar o Eliminar")
        End If

        'Insertar Nueva Marca
        If OpcionButton = 1 Then
            Dim RegCategoria As New Categoria()

            'Asignación de valores
            RegCategoria.Nombre = TbNombreCategoria.Text
            RegCategoria.Descripcion = TbDescripcionCategoria.Text
            RegCategoria.Activo = 1
            RegCategoria.IdUsuarioRegistro = 1

            ' llamada al metodo para la inserción
            DAOCategoriaProductos.InsertarCategoria(RegCategoria.Nombre, RegCategoria.Descripcion, RegCategoria.Activo, RegCategoria.IdUsuarioRegistro)
            MessageBox.Show("Valores guardados correctamente", "Nuevo Categoria Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' limpieza de valores
            LimpiarValores()
            DAOCategoriaProductos.LlenarGrid(DgvVW_Categoria) 'Se vuelva a llenar el DataGriedView
        End If

        'Actualizar una Marca
        If OpcionButton = 2 Then
            Dim RegCategoria As New Categoria()

            'Asignación de valores
            RegCategoria.IdCategoria = Id
            RegCategoria.Nombre = TbNombreCategoria.Text
            RegCategoria.Descripcion = TbDescripcionCategoria.Text
            RegCategoria.IdUsuarioActualiza = 1

            DAOCategoriaProductos.ActualizarCategoria(RegCategoria.Nombre, RegCategoria.Descripcion, RegCategoria.IdUsuarioActualiza, RegCategoria.IdCategoria)
            MessageBox.Show("Valores Actualizados correctamente", "Cambiar Categoria Existente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' limpieza de valores
            LimpiarValores()
            DAOCategoriaProductos.LlenarGrid(DgvVW_Categoria) 'Se vuelva a llenar el DataGriedView
        End If

        If OpcionButton = 3 Then
            Dim RegCategoria As New Categoria()

            ' Asignación de valores
            RegCategoria.IdCategoria = Id
            RegCategoria.Activo = 0

            DAOCategoriaProductos.EliminarCategoria(RegCategoria.Activo, RegCategoria.IdCategoria)
            MessageBox.Show("Valore Eliminado correctamente", "Elimnar Categoria Existente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' limpieza de valores
            LimpiarValores()
            DAOCategoriaProductos.LlenarGrid(DgvVW_Categoria) 'Se vuelva a llenar el DataGriedView
        End If
    End Sub

    Private Sub DgvVW_Categoria_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVW_Categoria.CellClick
        'Solo manda valores a los TextBox si se toca el boton Cambiar
        If OpcionButton = 2 Or OpcionButton = 3 Then
            TbNombreCategoria.Text = DgvVW_Categoria.SelectedCells(1).Value
            TbDescripcionCategoria.Text = DgvVW_Categoria.SelectedCells(2).Value
            Id = DgvVW_Categoria.SelectedCells(0).Value
        End If

    End Sub
End Class