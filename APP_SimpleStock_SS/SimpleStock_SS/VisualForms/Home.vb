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
        Dim form As FrmMarcaProductos = FrmMarcaProductos.InstanciaMarcaProductos 'Crea una variable de la instancia singleton
        form.Owner = Me 'Hace a la instancia del Formulario Marca Productos hija de Home
        form.Show() ' Muestra el formulario en la pantalla
        form.BringToFront() ' Manda el formulario enfrente del padre (Home)

    End Sub

    Private Sub BtnCategoriaProducto_Click(sender As Object, e As EventArgs) Handles BtnCategoriaProducto.Click
        FrmMarcaProductos.InstanciaMarcaProductos.Hide() 'Oculta la ventana FrmMarcaProducto
    End Sub
End Class