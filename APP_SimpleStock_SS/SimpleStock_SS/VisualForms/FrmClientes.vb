Public Class FrmClientes

    ' Instancia Statica para garantizar una sola Instancia de la clase
    Private Shared _Singleton As FrmClientes

    ' Propiedad para obtener la instancia única
    Public Shared ReadOnly Property InstanciaClientes As FrmClientes
        Get
            ' Si la instancia estatica es nula o fue eliminada entonces
            If _Singleton Is Nothing OrElse _Singleton.IsDisposed Then
                ' Se crea una nueva instancia
                _Singleton = New FrmClientes()
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



    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '/*==================COLOR INICIAL DE PANELES PRINCIPALES DE FONDO=========================*/
        Me.BackColor = Color.FromArgb(247, 253, 232) ' #f7fde8 - Color de fondo
        LbTituloForm.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Titulo Superior
        BtnCrearNuevoCliente.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Crear
        BtnCambiarCliente.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Cambiar
        BtnEliminarCliente.BackColor = Color.FromArgb(199, 180, 100) ' #c7b464 - Boton Eliminar
        PnConteinerCliente.BackColor = Color.FromArgb(207, 211, 218) '#cfd3da - Panel Superior Derecho
        PnNombreCliente.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox NombreCliente
        PnCorreoCliente.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox CorreoCliente
        PnCelularCliente.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - Panel para TextBox CelularCliente
        TbNombreCliente.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox NombreCliente
        TbCorreoCliente.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox CorreoCliente
        TbCelularCliente.BackColor = Color.FromArgb(247, 253, 232) '#f7fde8 - TextBox CelularCliente
        TbNombreCliente.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        TbCorreoCliente.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        TbCelularCliente.ForeColor = Color.FromArgb(10, 73, 134) ' #0a4986 - Color de letra
        BtnGuardar.FlatAppearance.BorderColor = Color.FromArgb(207, 211, 218) '#cfd3da - Borde del Boton Guardar
        BtnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 215, 218) '#cfd3da - Al pasar el mouse arriba del Boton Guardar
        DgvVW_Cliente.BackgroundColor = Color.FromArgb(247, 253, 232) ' #f7fde8 - Color de fondo de DataGridView
        ModObjectForm.PersonalizarDataGridView(DgvVW_Cliente)

        '/*==================Modificadores de Objetos======================================*/
        ModObjectForm.CrearBotonEsquinasSemiCirculares(BtnCrearNuevoCliente, 15)
        ModObjectForm.CrearBotonEsquinasSemiCirculares(BtnCambiarCliente, 15)
        ModObjectForm.CrearBotonEsquinasSemiCirculares(BtnEliminarCliente, 15)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnConteinerCliente, 30)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnNombreCliente, 10)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnCorreoCliente, 10)
        ModObjectForm.CrearPanelEsquinasSemiCirculares(PnCelularCliente, 10)


        '/*====================Valores Iniciales de los Objetos==============================*/
        DAOCliente.LlenarGrid(DgvVW_Cliente)
        LbSubTituloPanel.Text = ""
    End Sub

    '/*========================================ZONA DE BOTONES======================================*/
    ' Variables y Objetos Utilies
    Dim DAOCliente As New DAOClientes()
    Dim OpcionButton As Integer = 0
    Dim Id As Integer = Nothing

    Private Sub LimpiarValores()
        OpcionButton = 0
        TbNombreCliente.Text = ""
        TbCorreoCliente.Text = ""
        TbCelularCliente.Text = ""
        LbSubTituloPanel.Text = ""
    End Sub

    ' Botton Crear Cliente
    Private Sub BtnCrearNuevoCliente_Click(sender As Object, e As EventArgs) Handles BtnCrearNuevoCliente.Click
        OpcionButton = 1
        TbNombreCliente.Text = "Nombre del Cliente"
        TbCorreoCliente.Text = "Correo del Cliente"
        TbCelularCliente.Text = "Numero telefonico por favor!"
        LbSubTituloPanel.Text = "Ingrese los datos del Cliente"
    End Sub
    ' Botton Cambiar Cliente
    Private Sub BtnCambiarCliente_Click(sender As Object, e As EventArgs) Handles BtnCambiarCliente.Click
        OpcionButton = 2
        TbNombreCliente.Text = "Selecciona un Cliente en la tabla"
        TbCorreoCliente.Text = "Reescribe su informacion"
        TbCelularCliente.Text = "Ten cuidado cuando actualices!"
        LbSubTituloPanel.Text = "Modifique un Cliente existente de la tabla"
    End Sub

    ' Botton Eliminar Cliente
    Private Sub BtnEliminarCliente_Click(sender As Object, e As EventArgs) Handles BtnEliminarCliente.Click
        OpcionButton = 3
        TbNombreCliente.Text = "Selecciona un Cliente en la tabla"
        TbCorreoCliente.Text = "Elimina su informacion"
        TbCelularCliente.Text = "Bye bye cliente!"
        LbSubTituloPanel.Text = "Elimine un Cliente existente de la tabla"
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        ' Estado Inicial del Boton
        If OpcionButton = 0 Then
            MessageBox.Show("No ha seleccionado una opción valida" & vbCrLf & " Pruebe tocando el boton: Crear, Cambiar o Eliminar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Insertar Nueva Cliente
        If OpcionButton = 1 Then
            Dim RegCliente As New Cliente()

            'Asignación de valores
            RegCliente.Nombre = TbNombreCliente.Text
            RegCliente.Correo = TbCorreoCliente.Text
            RegCliente.Telefono = TbCelularCliente.Text
            RegCliente.Activo = 1
            RegCliente.IdUsuarioRegistro = 1

            ' llamada al metodo para la inserción
            DAOCliente.InsertarCliente(RegCliente.Nombre, RegCliente.Telefono, RegCliente.Correo, RegCliente.Activo, RegCliente.IdUsuarioRegistro)
            MessageBox.Show("Valores guardados correctamente", "Nuevo Cliente Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' limpieza de valores
            LimpiarValores()
            DAOCliente.LlenarGrid(DgvVW_Cliente) 'Se vuelva a llenar el DataGriedView
        End If

        'Actualizar un Cliente
        If OpcionButton = 2 Then
            Dim RegCliente As New Cliente()

            'Asignación de valores
            RegCliente.IdCliente = Id
            RegCliente.Nombre = TbNombreCliente.Text
            RegCliente.Correo = TbCorreoCliente.Text
            RegCliente.Telefono = TbCelularCliente.Text
            RegCliente.IdUsuarioActualiza = 1

            DAOCliente.ActualizarCliente(RegCliente.Nombre, RegCliente.Telefono, RegCliente.Correo, RegCliente.IdUsuarioActualiza, RegCliente.IdCliente)
            MessageBox.Show("Valores Actualizados correctamente", "Cambiar Cliente Existente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' limpieza de valores
            LimpiarValores()
            DAOCliente.LlenarGrid(DgvVW_Cliente) 'Se vuelva a llenar el DataGriedView
        End If

        'Eliminar un Cliente
        If OpcionButton = 3 Then
            Dim RegCliente As New Cliente()

            ' Asignación de valores
            RegCliente.IdCliente = Id
            RegCliente.Activo = 0

            DAOCliente.EliminarCliente(RegCliente.Activo, RegCliente.IdCliente)
            MessageBox.Show("Valore Eliminado correctamente", "Elimnar Cliente Existente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' limpieza de valores
            LimpiarValores()
            DAOCliente.LlenarGrid(DgvVW_Cliente) 'Se vuelva a llenar el DataGriedView
        End If
    End Sub

    Private Sub DgvVW_Cliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVW_Cliente.CellClick
        If OpcionButton = 2 Or OpcionButton = 3 Then
            TbNombreCliente.Text = DgvVW_Cliente.SelectedCells(1).Value
            TbCorreoCliente.Text = DgvVW_Cliente.SelectedCells(2).Value
            TbCelularCliente.Text = DgvVW_Cliente.SelectedCells(3).Value

            Id = DgvVW_Cliente.SelectedCells(0).Value
        End If
    End Sub
End Class