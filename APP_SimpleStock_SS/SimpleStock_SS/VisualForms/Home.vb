Public Class Home


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '/*==================COLOR INICIAL DE PANELES PRINCIPALES DE FONDO=========================*/
        PnLogoUsuario.BackColor = Color.FromArgb(253, 249, 180) '#fdf9b4 - Panel Pequeño
        PnBotonesIzquierdos.BackColor = Color.FromArgb(103, 95, 162) ' #675fa2 - Panel Mediano
        PnPrincipalDerecho.BackColor = Color.FromArgb(12, 92, 168) ' #0c5ca8 - Panel Grande Azul
        PnDivisor1.BackColor = Color.FromArgb(255, 49, 49) ' #ff3131 - Ralla divisora Superior
        PnDivisor2.BackColor = Color.FromArgb(255, 49, 49) ' #ff3131 - Ralla divisora Inferior
        PnBaseSubVentanas.BackColor = Color.FromArgb(247, 253, 232) ' #f7fde8 - Panel Pequeño dentro de Panel Azul


        '/*==================TEXTO INICIAL DE LABELS PnLogoUsuario=========================*/
        LbUsuario.Text = "Lelounch Vi Britania"
        LbRol.Text = "Administrador"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnRegistroSalida.Click
        MessageBox.Show("Funciona el Button")
    End Sub



    '/*=================================ZONA DE BOTONES================================*/
    Private Sub BtnMarcaProductos_Click(sender As Object, e As EventArgs) Handles BtnMarcaProductos.Click
        FrmProveedoresProductos.InstanciaProveedorProducto.Hide()
        FrmCategoriaProductos.InstanciaCategoriaProductos.Hide()
        FrmClientes.InstanciaClientes.Hide()
        FrmCatalogoProductos.InstanciaCatalogoProductos.Hide()
        FrmRegistroEntrada.InstanciaRegistroEntrada.Hide()

        If OpenDoor = 0 Then
            Dim formMarca As FrmMarcaProductos = FrmMarcaProductos.InstanciaMarcaProductos 'Crea una variable de la instancia singleton
            formMarca.Owner = Me 'Hace a la instancia del Formulario Marca Productos hija de Home
            formMarca.Show() ' Muestra el formulario en la pantalla
            formMarca.BringToFront() ' Manda el formulario enfrente del padre (Home)
        End If
    End Sub

    Private Sub BtnProveedoresProductos_Click(sender As Object, e As EventArgs) Handles BtnProveedoresProductos.Click
        FrmMarcaProductos.InstanciaMarcaProductos.Hide()
        FrmCategoriaProductos.InstanciaCategoriaProductos.Hide()
        FrmClientes.InstanciaClientes.Hide()
        FrmCatalogoProductos.InstanciaCatalogoProductos.Hide()
        FrmRegistroEntrada.InstanciaRegistroEntrada.Hide()

        If OpenDoor = 0 Then
            Dim formProveedor As FrmProveedoresProductos = FrmProveedoresProductos.InstanciaProveedorProducto 'Crea una variable de la instancia singleton
            formProveedor.Owner = Me 'Hace a la instancia del Formulario Proveedor Productos hija de Home
            formProveedor.Show() ' Muestra el formulario en la pantalla
            formProveedor.BringToFront() ' Manda el formulario enfrente del padre (Home)
        End If
    End Sub


    Private Sub BtnCategoriaProducto_Click(sender As Object, e As EventArgs) Handles BtnCategoriaProducto.Click
        FrmMarcaProductos.InstanciaMarcaProductos.Hide() 'Oculta la ventana FrmMarcaProducto
        FrmProveedoresProductos.InstanciaProveedorProducto.Hide()
        FrmClientes.InstanciaClientes.Hide()
        FrmCatalogoProductos.InstanciaCatalogoProductos.Hide()
        FrmRegistroEntrada.InstanciaRegistroEntrada.Hide()

        If OpenDoor = 0 Then
            Dim formCategoria As FrmCategoriaProductos = FrmCategoriaProductos.InstanciaCategoriaProductos 'Crea una variable de la instancia singleton
            formCategoria.Owner = Me 'Hace a la instancia del Formulario Proveedor Productos hija de Home
            formCategoria.Show() ' Muestra el formulario en la pantalla
            formCategoria.BringToFront() ' Manda el formulario enfrente del padre (Home)
        End If
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        FrmMarcaProductos.InstanciaMarcaProductos.Hide()
        FrmCategoriaProductos.InstanciaCategoriaProductos.Hide()
        FrmProveedoresProductos.InstanciaProveedorProducto.Hide()
        FrmCatalogoProductos.InstanciaCatalogoProductos.Hide()
        FrmRegistroEntrada.InstanciaRegistroEntrada.Hide()

        If OpenDoor = 0 Then

            Dim formClientes As FrmClientes = FrmClientes.InstanciaClientes 'Crea una variable de la instancia singleton
            formClientes.Owner = Me 'Hace a la instancia del Formulario Proveedor Productos hija de Home
            formClientes.Show() ' Muestra el formulario en la pantalla
            formClientes.BringToFront() ' Manda el formulario enfrente del padre (Home)
        End If

    End Sub

    Private Sub BtnCatalogoProductos_Click(sender As Object, e As EventArgs) Handles BtnCatalogoProductos.Click
        FrmMarcaProductos.InstanciaMarcaProductos.Hide()
        FrmCategoriaProductos.InstanciaCategoriaProductos.Hide()
        FrmProveedoresProductos.InstanciaProveedorProducto.Hide()
        FrmClientes.InstanciaClientes.Hide()
        FrmRegistroEntrada.InstanciaRegistroEntrada.Hide()

        If OpenDoor = 0 Then
            Dim formCatalogoProductos As FrmCatalogoProductos = FrmCatalogoProductos.InstanciaCatalogoProductos 'Crea una variable de la instancia singleton
            formCatalogoProductos.Owner = Me 'Hace a la instancia del Formulario Proveedor Productos hija de Home
            formCatalogoProductos.Show() ' Muestra el formulario en la pantalla
            formCatalogoProductos.BringToFront() ' Manda el formulario enfrente del padre (Home)
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnRegistroEntrada_Click(sender As Object, e As EventArgs) Handles BtnRegistroEntrada.Click
        FrmMarcaProductos.InstanciaMarcaProductos.Hide()
        FrmCategoriaProductos.InstanciaCategoriaProductos.Hide()
        FrmProveedoresProductos.InstanciaProveedorProducto.Hide()
        FrmClientes.InstanciaClientes.Hide()
        FrmCatalogoProductos.InstanciaCatalogoProductos.Hide()

        If OpenDoor = 0 Then
            Dim forRegistroEntrada As FrmRegistroEntrada = FrmRegistroEntrada.InstanciaRegistroEntrada 'Crea una variable de la instancia singleton
            forRegistroEntrada.Owner = Me 'Hace a la instancia del Formulario Proveedor Productos hija de Home
            forRegistroEntrada.Show() ' Muestra el formulario en la pantalla
            forRegistroEntrada.BringToFront() ' Manda el formulario enfrente del padre (Home)
        End If


    End Sub
End Class