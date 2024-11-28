<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.PnLogoUsuario = New System.Windows.Forms.Panel()
        Me.LbRol = New System.Windows.Forms.Label()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.PbMascota = New System.Windows.Forms.PictureBox()
        Me.PnBotonesIzquierdos = New System.Windows.Forms.Panel()
        Me.PnContainerBtnAccioner = New System.Windows.Forms.Panel()
        Me.BtnRegistroSalida = New System.Windows.Forms.Button()
        Me.BtnVerStock = New System.Windows.Forms.Button()
        Me.BtnRegistroEntrada = New System.Windows.Forms.Button()
        Me.PnDivisor2 = New System.Windows.Forms.Panel()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnCatalogoProductos = New System.Windows.Forms.Button()
        Me.BtnProveedoresProductos = New System.Windows.Forms.Button()
        Me.BtnMarcaProductos = New System.Windows.Forms.Button()
        Me.BtnCategoriaProducto = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.PnDivisor1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnPrincipalDerecho = New System.Windows.Forms.Panel()
        Me.PnBaseSubVentanas = New System.Windows.Forms.Panel()
        Me.PnLogoUsuario.SuspendLayout()
        CType(Me.PbMascota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnBotonesIzquierdos.SuspendLayout()
        Me.PnContainerBtnAccioner.SuspendLayout()
        Me.PnPrincipalDerecho.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnLogoUsuario
        '
        Me.PnLogoUsuario.BackColor = System.Drawing.Color.Moccasin
        Me.PnLogoUsuario.Controls.Add(Me.LbRol)
        Me.PnLogoUsuario.Controls.Add(Me.LbUsuario)
        Me.PnLogoUsuario.Controls.Add(Me.PbMascota)
        Me.PnLogoUsuario.Location = New System.Drawing.Point(0, 0)
        Me.PnLogoUsuario.Name = "PnLogoUsuario"
        Me.PnLogoUsuario.Size = New System.Drawing.Size(399, 191)
        Me.PnLogoUsuario.TabIndex = 0
        '
        'LbRol
        '
        Me.LbRol.AutoSize = True
        Me.LbRol.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRol.Location = New System.Drawing.Point(10, 162)
        Me.LbRol.Name = "LbRol"
        Me.LbRol.Size = New System.Drawing.Size(175, 24)
        Me.LbRol.TabIndex = 1
        Me.LbRol.Text = "Rol_Del_Usuario"
        '
        'LbUsuario
        '
        Me.LbUsuario.AutoSize = True
        Me.LbUsuario.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUsuario.Location = New System.Drawing.Point(11, 138)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(221, 24)
        Me.LbUsuario.TabIndex = 1
        Me.LbUsuario.Text = "Nombre_Del_Usuario"
        '
        'PbMascota
        '
        Me.PbMascota.BackColor = System.Drawing.Color.Transparent
        Me.PbMascota.Image = CType(resources.GetObject("PbMascota.Image"), System.Drawing.Image)
        Me.PbMascota.Location = New System.Drawing.Point(97, -12)
        Me.PbMascota.Name = "PbMascota"
        Me.PbMascota.Size = New System.Drawing.Size(180, 147)
        Me.PbMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbMascota.TabIndex = 0
        Me.PbMascota.TabStop = False
        '
        'PnBotonesIzquierdos
        '
        Me.PnBotonesIzquierdos.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.PnBotonesIzquierdos.Controls.Add(Me.PnContainerBtnAccioner)
        Me.PnBotonesIzquierdos.Controls.Add(Me.PnDivisor2)
        Me.PnBotonesIzquierdos.Controls.Add(Me.BtnClientes)
        Me.PnBotonesIzquierdos.Controls.Add(Me.BtnCatalogoProductos)
        Me.PnBotonesIzquierdos.Controls.Add(Me.BtnProveedoresProductos)
        Me.PnBotonesIzquierdos.Controls.Add(Me.BtnMarcaProductos)
        Me.PnBotonesIzquierdos.Controls.Add(Me.BtnCategoriaProducto)
        Me.PnBotonesIzquierdos.Controls.Add(Me.BtnHome)
        Me.PnBotonesIzquierdos.Controls.Add(Me.PnDivisor1)
        Me.PnBotonesIzquierdos.Controls.Add(Me.Label1)
        Me.PnBotonesIzquierdos.Location = New System.Drawing.Point(0, 189)
        Me.PnBotonesIzquierdos.Name = "PnBotonesIzquierdos"
        Me.PnBotonesIzquierdos.Size = New System.Drawing.Size(399, 579)
        Me.PnBotonesIzquierdos.TabIndex = 1
        '
        'PnContainerBtnAccioner
        '
        Me.PnContainerBtnAccioner.BackgroundImage = CType(resources.GetObject("PnContainerBtnAccioner.BackgroundImage"), System.Drawing.Image)
        Me.PnContainerBtnAccioner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnContainerBtnAccioner.Controls.Add(Me.BtnRegistroSalida)
        Me.PnContainerBtnAccioner.Controls.Add(Me.BtnVerStock)
        Me.PnContainerBtnAccioner.Controls.Add(Me.BtnRegistroEntrada)
        Me.PnContainerBtnAccioner.Location = New System.Drawing.Point(12, 367)
        Me.PnContainerBtnAccioner.Name = "PnContainerBtnAccioner"
        Me.PnContainerBtnAccioner.Size = New System.Drawing.Size(379, 206)
        Me.PnContainerBtnAccioner.TabIndex = 0
        '
        'BtnRegistroSalida
        '
        Me.BtnRegistroSalida.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegistroSalida.BackgroundImage = CType(resources.GetObject("BtnRegistroSalida.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegistroSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRegistroSalida.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnRegistroSalida.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip
        Me.BtnRegistroSalida.FlatAppearance.BorderSize = 0
        Me.BtnRegistroSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRegistroSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRegistroSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistroSalida.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistroSalida.ForeColor = System.Drawing.Color.White
        Me.BtnRegistroSalida.Location = New System.Drawing.Point(261, 94)
        Me.BtnRegistroSalida.Name = "BtnRegistroSalida"
        Me.BtnRegistroSalida.Size = New System.Drawing.Size(77, 75)
        Me.BtnRegistroSalida.TabIndex = 3
        Me.BtnRegistroSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistroSalida.UseVisualStyleBackColor = False
        '
        'BtnVerStock
        '
        Me.BtnVerStock.BackColor = System.Drawing.Color.Transparent
        Me.BtnVerStock.BackgroundImage = CType(resources.GetObject("BtnVerStock.BackgroundImage"), System.Drawing.Image)
        Me.BtnVerStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnVerStock.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnVerStock.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip
        Me.BtnVerStock.FlatAppearance.BorderSize = 0
        Me.BtnVerStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnVerStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnVerStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerStock.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerStock.ForeColor = System.Drawing.Color.White
        Me.BtnVerStock.Location = New System.Drawing.Point(149, 26)
        Me.BtnVerStock.Name = "BtnVerStock"
        Me.BtnVerStock.Size = New System.Drawing.Size(77, 77)
        Me.BtnVerStock.TabIndex = 3
        Me.BtnVerStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVerStock.UseVisualStyleBackColor = False
        '
        'BtnRegistroEntrada
        '
        Me.BtnRegistroEntrada.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegistroEntrada.BackgroundImage = CType(resources.GetObject("BtnRegistroEntrada.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegistroEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRegistroEntrada.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnRegistroEntrada.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip
        Me.BtnRegistroEntrada.FlatAppearance.BorderSize = 0
        Me.BtnRegistroEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRegistroEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRegistroEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistroEntrada.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistroEntrada.ForeColor = System.Drawing.Color.White
        Me.BtnRegistroEntrada.Location = New System.Drawing.Point(35, 86)
        Me.BtnRegistroEntrada.Name = "BtnRegistroEntrada"
        Me.BtnRegistroEntrada.Size = New System.Drawing.Size(86, 83)
        Me.BtnRegistroEntrada.TabIndex = 3
        Me.BtnRegistroEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistroEntrada.UseVisualStyleBackColor = False
        '
        'PnDivisor2
        '
        Me.PnDivisor2.BackColor = System.Drawing.Color.Crimson
        Me.PnDivisor2.Location = New System.Drawing.Point(12, 358)
        Me.PnDivisor2.Name = "PnDivisor2"
        Me.PnDivisor2.Size = New System.Drawing.Size(370, 3)
        Me.PnDivisor2.TabIndex = 2
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.Transparent
        Me.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.ForeColor = System.Drawing.Color.White
        Me.BtnClientes.Image = CType(resources.GetObject("BtnClientes.Image"), System.Drawing.Image)
        Me.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.Location = New System.Drawing.Point(15, 249)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(348, 48)
        Me.BtnClientes.TabIndex = 3
        Me.BtnClientes.Text = "             Catalogo de Clientes"
        Me.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'BtnCatalogoProductos
        '
        Me.BtnCatalogoProductos.BackColor = System.Drawing.Color.Transparent
        Me.BtnCatalogoProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCatalogoProductos.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnCatalogoProductos.FlatAppearance.BorderSize = 0
        Me.BtnCatalogoProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCatalogoProductos.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCatalogoProductos.ForeColor = System.Drawing.Color.White
        Me.BtnCatalogoProductos.Image = CType(resources.GetObject("BtnCatalogoProductos.Image"), System.Drawing.Image)
        Me.BtnCatalogoProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCatalogoProductos.Location = New System.Drawing.Point(15, 304)
        Me.BtnCatalogoProductos.Name = "BtnCatalogoProductos"
        Me.BtnCatalogoProductos.Size = New System.Drawing.Size(348, 48)
        Me.BtnCatalogoProductos.TabIndex = 3
        Me.BtnCatalogoProductos.Text = "             Catalogo de Productos"
        Me.BtnCatalogoProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCatalogoProductos.UseVisualStyleBackColor = False
        '
        'BtnProveedoresProductos
        '
        Me.BtnProveedoresProductos.BackColor = System.Drawing.Color.Transparent
        Me.BtnProveedoresProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnProveedoresProductos.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnProveedoresProductos.FlatAppearance.BorderSize = 0
        Me.BtnProveedoresProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProveedoresProductos.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedoresProductos.ForeColor = System.Drawing.Color.White
        Me.BtnProveedoresProductos.Image = CType(resources.GetObject("BtnProveedoresProductos.Image"), System.Drawing.Image)
        Me.BtnProveedoresProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProveedoresProductos.Location = New System.Drawing.Point(15, 194)
        Me.BtnProveedoresProductos.Name = "BtnProveedoresProductos"
        Me.BtnProveedoresProductos.Size = New System.Drawing.Size(348, 50)
        Me.BtnProveedoresProductos.TabIndex = 3
        Me.BtnProveedoresProductos.Text = "             Proveedores de Productos"
        Me.BtnProveedoresProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProveedoresProductos.UseVisualStyleBackColor = False
        '
        'BtnMarcaProductos
        '
        Me.BtnMarcaProductos.BackColor = System.Drawing.Color.Transparent
        Me.BtnMarcaProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMarcaProductos.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnMarcaProductos.FlatAppearance.BorderSize = 0
        Me.BtnMarcaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMarcaProductos.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMarcaProductos.ForeColor = System.Drawing.Color.White
        Me.BtnMarcaProductos.Image = CType(resources.GetObject("BtnMarcaProductos.Image"), System.Drawing.Image)
        Me.BtnMarcaProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMarcaProductos.Location = New System.Drawing.Point(15, 135)
        Me.BtnMarcaProductos.Name = "BtnMarcaProductos"
        Me.BtnMarcaProductos.Size = New System.Drawing.Size(348, 53)
        Me.BtnMarcaProductos.TabIndex = 3
        Me.BtnMarcaProductos.Text = "             Marcas de Productos"
        Me.BtnMarcaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMarcaProductos.UseVisualStyleBackColor = False
        '
        'BtnCategoriaProducto
        '
        Me.BtnCategoriaProducto.BackColor = System.Drawing.Color.Transparent
        Me.BtnCategoriaProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCategoriaProducto.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnCategoriaProducto.FlatAppearance.BorderSize = 0
        Me.BtnCategoriaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCategoriaProducto.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCategoriaProducto.ForeColor = System.Drawing.Color.White
        Me.BtnCategoriaProducto.Image = CType(resources.GetObject("BtnCategoriaProducto.Image"), System.Drawing.Image)
        Me.BtnCategoriaProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCategoriaProducto.Location = New System.Drawing.Point(12, 83)
        Me.BtnCategoriaProducto.Name = "BtnCategoriaProducto"
        Me.BtnCategoriaProducto.Size = New System.Drawing.Size(351, 52)
        Me.BtnCategoriaProducto.TabIndex = 3
        Me.BtnCategoriaProducto.Text = "             Categoria de Productos"
        Me.BtnCategoriaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCategoriaProducto.UseVisualStyleBackColor = False
        '
        'BtnHome
        '
        Me.BtnHome.BackColor = System.Drawing.Color.Transparent
        Me.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHome.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnHome.FlatAppearance.BorderSize = 0
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Font = New System.Drawing.Font("HP Simplified Hans", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.Color.White
        Me.BtnHome.Image = CType(resources.GetObject("BtnHome.Image"), System.Drawing.Image)
        Me.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHome.Location = New System.Drawing.Point(12, 28)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(351, 53)
        Me.BtnHome.TabIndex = 3
        Me.BtnHome.Text = "         HOME"
        Me.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHome.UseVisualStyleBackColor = False
        '
        'PnDivisor1
        '
        Me.PnDivisor1.BackColor = System.Drawing.Color.Crimson
        Me.PnDivisor1.Location = New System.Drawing.Point(12, 23)
        Me.PnDivisor1.Name = "PnDivisor1"
        Me.PnDivisor1.Size = New System.Drawing.Size(370, 3)
        Me.PnDivisor1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HP Simplified Hans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Catalogo y Propiedades"
        '
        'PnPrincipalDerecho
        '
        Me.PnPrincipalDerecho.BackColor = System.Drawing.Color.DodgerBlue
        Me.PnPrincipalDerecho.Controls.Add(Me.PnBaseSubVentanas)
        Me.PnPrincipalDerecho.Location = New System.Drawing.Point(399, 0)
        Me.PnPrincipalDerecho.Name = "PnPrincipalDerecho"
        Me.PnPrincipalDerecho.Size = New System.Drawing.Size(968, 768)
        Me.PnPrincipalDerecho.TabIndex = 2
        '
        'PnBaseSubVentanas
        '
        Me.PnBaseSubVentanas.BackColor = System.Drawing.Color.AliceBlue
        Me.PnBaseSubVentanas.Location = New System.Drawing.Point(21, 80)
        Me.PnBaseSubVentanas.Name = "PnBaseSubVentanas"
        Me.PnBaseSubVentanas.Size = New System.Drawing.Size(915, 640)
        Me.PnBaseSubVentanas.TabIndex = 0
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.PnPrincipalDerecho)
        Me.Controls.Add(Me.PnBotonesIzquierdos)
        Me.Controls.Add(Me.PnLogoUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnLogoUsuario.ResumeLayout(False)
        Me.PnLogoUsuario.PerformLayout()
        CType(Me.PbMascota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnBotonesIzquierdos.ResumeLayout(False)
        Me.PnBotonesIzquierdos.PerformLayout()
        Me.PnContainerBtnAccioner.ResumeLayout(False)
        Me.PnPrincipalDerecho.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnLogoUsuario As Panel
    Friend WithEvents PnBotonesIzquierdos As Panel
    Friend WithEvents PnPrincipalDerecho As Panel
    Friend WithEvents PbMascota As PictureBox
    Friend WithEvents LbUsuario As Label
    Friend WithEvents LbRol As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PnDivisor1 As Panel
    Friend WithEvents BtnHome As Button
    Friend WithEvents BtnCatalogoProductos As Button
    Friend WithEvents BtnProveedoresProductos As Button
    Friend WithEvents BtnMarcaProductos As Button
    Friend WithEvents BtnCategoriaProducto As Button
    Friend WithEvents PnDivisor2 As Panel
    Friend WithEvents PnContainerBtnAccioner As Panel
    Friend WithEvents BtnRegistroEntrada As Button
    Friend WithEvents BtnRegistroSalida As Button
    Friend WithEvents BtnVerStock As Button
    Friend WithEvents PnBaseSubVentanas As Panel
    Friend WithEvents BtnClientes As Button
End Class
