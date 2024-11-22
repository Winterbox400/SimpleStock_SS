Public Class Home


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '/*==================COLOR INICIAL DE PANELES PRINCIPALES DE FONDO=========================*/
        PnLogoUsuario.BackColor = Color.FromArgb(253, 249, 180) '#fdf9b4
        PnBotonesIzquierdos.BackColor = Color.FromArgb(103, 95, 162) ' #675fa2
        PnPrincipalDerecho.BackColor = Color.FromArgb(12, 92, 168) ' #0c5ca8
        PnDivisor1.BackColor = Color.FromArgb(255, 49, 49) ' #ff3131
        PnDivisor2.BackColor = Color.FromArgb(255, 49, 49) ' #ff3131


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

        Dim formMarca As FrmMarcaProductos = FrmMarcaProductos.InstanciaMarcaProductos 'Crea una variable de la instancia singleton
        formMarca.Owner = Me 'Hace a la instancia del Formulario Marca Productos hija de Home
        formMarca.Show() ' Muestra el formulario en la pantalla
        formMarca.BringToFront() ' Manda el formulario enfrente del padre (Home)

    End Sub

    Private Sub BtnProveedoresProductos_Click(sender As Object, e As EventArgs) Handles BtnProveedoresProductos.Click
        FrmMarcaProductos.InstanciaMarcaProductos.Hide()

        Dim formProveedor As FrmProveedoresProductos = FrmProveedoresProductos.InstanciaProveedorProducto 'Crea una variable de la instancia singleton
        formProveedor.Owner = Me 'Hace a la instancia del Formulario Proveedor Productos hija de Home
        formProveedor.Show() ' Muestra el formulario en la pantalla
        formProveedor.BringToFront() ' Manda el formulario enfrente del padre (Home)
    End Sub


    Private Sub BtnCategoriaProducto_Click(sender As Object, e As EventArgs) Handles BtnCategoriaProducto.Click
        FrmMarcaProductos.InstanciaMarcaProductos.Hide() 'Oculta la ventana FrmMarcaProducto
    End Sub


End Class