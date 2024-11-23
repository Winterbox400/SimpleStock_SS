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
        DgvVW_Proveedor.BackgroundColor = Color.FromArgb(247, 253, 232) ' #f7fde8 - Color de fondo de DataGridView
        ModObjectForm.PersonalizarDataGridView(DgvVW_Proveedor)

        '/*==================Modificadores de Objetos======================================*/
        ModObjectForm.CrearBotonEsquinasSemiCirculares(BtnCrearNuevoProveedor, 15)
        ModObjectForm.CrearBotonEsquinasSemiCirculares(BtnCambiarProveedor, 15)
        ModObjectForm.CrearBotonEsquinasSemiCirculares(BtnEliminarProveedor, 15)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnConteinerProveedor, 30)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnNombreProveedor, 10)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnCorreoProveedor, 10)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnCelularProveedor, 10)

        '/*====================Valores Iniciales de los Objetos==============================*/
        DAOProveedorProducto.LlenarGrid(DgvVW_Proveedor)
    End Sub

    '/*========================================ZONA DE BOTONES======================================*/
    ' Variables y Objetos Utilies
    Dim DAOProveedorProducto As New DAOProveedorProducto()
    Dim OpcionButton As Integer = 0
    Dim Id As Integer = Nothing

    Private Sub LimpiarValores()
        OpcionButton = 0
        TbNombreProveedor.Text = ""
        TbCorreoProveedor.Text = ""
        TbCelularProveedor.Text = ""
    End Sub

    'Botton Crear Proveedor
    Private Sub BtnCrearNuevoProveedor_Click(sender As Object, e As EventArgs) Handles BtnCrearNuevoProveedor.Click
        OpcionButton = 1
        TbNombreProveedor.Text = "Nombre del Proveedor"
        TbCorreoProveedor.Text = "Correo del Proveedor"
        TbCelularProveedor.Text = "Numero telefonico por favor!"
    End Sub
    'Botton Actualizar Proveedor
    Private Sub BtnCambiarProveedor_Click(sender As Object, e As EventArgs) Handles BtnCambiarProveedor.Click
        OpcionButton = 2
        TbNombreProveedor.Text = "Selecciona un Proveedor en la tabla"
        TbCorreoProveedor.Text = "Reescribe su informacion"
        TbCelularProveedor.Text = "Ten cuidado cuando actualices!"
    End Sub
    'Botton Eliminar Proveedor
    Private Sub BtnEliminarProveedor_Click(sender As Object, e As EventArgs) Handles BtnEliminarProveedor.Click
        OpcionButton = 3
        TbNombreProveedor.Text = "Selecciona un Proveedor en la tabla"
        TbCorreoProveedor.Text = "Elimina su informacion"
        TbCelularProveedor.Text = "Bye bye proveedor!"
    End Sub

    'Botton confirmar acción
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        ' Estado Inicial del Boton
        If OpcionButton = 0 Then
            MessageBox.Show("No ha seleccionado una opción valida" & vbCrLf & " Pruebe tocando el boton: Crear, Cambiar o Eliminar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Insertar Nueva Marca
        If OpcionButton = 1 Then
            Dim RegProveedor As New Proveedor()

            'Asignación de valores
            RegProveedor.Nombre = TbNombreProveedor.Text
            RegProveedor.Correo = TbCorreoProveedor.Text
            RegProveedor.Telefono = TbCelularProveedor.Text
            RegProveedor.Activo = 1
            RegProveedor.IdUsuarioRegistro = 1

            ' llamada al metodo para la inserción
            DAOProveedorProducto.InsertarProveedor(RegProveedor.Nombre, RegProveedor.Telefono, RegProveedor.Correo, RegProveedor.Activo, RegProveedor.IdUsuarioRegistro)
            MessageBox.Show("Valores guardados correctamente", "Nuevo Proveedor Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' limpieza de valores
            LimpiarValores()
            DAOProveedorProducto.LlenarGrid(DgvVW_Proveedor) 'Se vuelva a llenar el DataGriedView
        End If

        'Actualizar un Proveedor
        If OpcionButton = 2 Then
            Dim RegProveedor As New Proveedor()

            'Asignación de valores
            RegProveedor.IdProveedor = Id
            RegProveedor.Nombre = TbNombreProveedor.Text
            RegProveedor.Correo = TbCorreoProveedor.Text
            RegProveedor.Telefono = TbCelularProveedor.Text
            RegProveedor.IdUsuarioActualiza = 1

            DAOProveedorProducto.ActualizarProveedor(RegProveedor.Nombre, RegProveedor.Telefono, RegProveedor.Correo, RegProveedor.IdUsuarioActualiza, RegProveedor.IdProveedor)
            MessageBox.Show("Valores Actualizados correctamente", "Cambiar Proveedor Existente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' limpieza de valores
            LimpiarValores()
            DAOProveedorProducto.LlenarGrid(DgvVW_Proveedor) 'Se vuelva a llenar el DataGriedView
        End If

        'Eliminar un Proveedor
        If OpcionButton = 3 Then
            Dim RegProveedor As New Proveedor()

            ' Asignación de valores
            RegProveedor.IdProveedor = Id
            RegProveedor.Activo = 0

            DAOProveedorProducto.EliminarProveedor(RegProveedor.Activo, RegProveedor.IdProveedor)
            MessageBox.Show("Valore Eliminado correctamente", "Elimnar Proveedor Existente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' limpieza de valores
            LimpiarValores()
            DAOProveedorProducto.LlenarGrid(DgvVW_Proveedor) 'Se vuelva a llenar el DataGriedView
        End If
    End Sub

    Private Sub DgvVW_Proveedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVW_Proveedor.CellClick
        If OpcionButton = 2 Or OpcionButton = 3 Then
            TbNombreProveedor.Text = DgvVW_Proveedor.SelectedCells(1).Value
            TbCelularProveedor.Text = DgvVW_Proveedor.SelectedCells(2).Value
            TbCorreoProveedor.Text = DgvVW_Proveedor.SelectedCells(3).Value

            Id = DgvVW_Proveedor.SelectedCells(0).Value
        End If
    End Sub
End Class