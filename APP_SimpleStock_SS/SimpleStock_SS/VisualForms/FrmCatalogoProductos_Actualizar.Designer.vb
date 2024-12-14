<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatalogoProductos_Actualizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCatalogoProductos_Actualizar))
        Me.PnConteinerPrincipal = New System.Windows.Forms.Panel()
        Me.LbTituloForm = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.CbProveedores = New System.Windows.Forms.ComboBox()
        Me.CbMarcasProductos = New System.Windows.Forms.ComboBox()
        Me.CbCategoriaProducto = New System.Windows.Forms.ComboBox()
        Me.PnDescripcionProductos = New System.Windows.Forms.Panel()
        Me.TbDescripcionProductos = New System.Windows.Forms.TextBox()
        Me.PnUbicacionProducto = New System.Windows.Forms.Panel()
        Me.TbUbicacionProducto = New System.Windows.Forms.TextBox()
        Me.PnAlmacenProducto = New System.Windows.Forms.Panel()
        Me.TbAlmacenProducto = New System.Windows.Forms.TextBox()
        Me.PnNombreProductos = New System.Windows.Forms.Panel()
        Me.TbNombreProductos = New System.Windows.Forms.TextBox()
        Me.BtnBackForm = New System.Windows.Forms.Button()
        Me.PnConteinerPrincipal.SuspendLayout()
        Me.PnDescripcionProductos.SuspendLayout()
        Me.PnUbicacionProducto.SuspendLayout()
        Me.PnAlmacenProducto.SuspendLayout()
        Me.PnNombreProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnConteinerPrincipal
        '
        Me.PnConteinerPrincipal.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PnConteinerPrincipal.Controls.Add(Me.BtnBackForm)
        Me.PnConteinerPrincipal.Controls.Add(Me.LbTituloForm)
        Me.PnConteinerPrincipal.Controls.Add(Me.BtnGuardar)
        Me.PnConteinerPrincipal.Controls.Add(Me.CbProveedores)
        Me.PnConteinerPrincipal.Controls.Add(Me.CbMarcasProductos)
        Me.PnConteinerPrincipal.Controls.Add(Me.CbCategoriaProducto)
        Me.PnConteinerPrincipal.Controls.Add(Me.PnDescripcionProductos)
        Me.PnConteinerPrincipal.Controls.Add(Me.PnUbicacionProducto)
        Me.PnConteinerPrincipal.Controls.Add(Me.PnAlmacenProducto)
        Me.PnConteinerPrincipal.Controls.Add(Me.PnNombreProductos)
        Me.PnConteinerPrincipal.Location = New System.Drawing.Point(12, 28)
        Me.PnConteinerPrincipal.Name = "PnConteinerPrincipal"
        Me.PnConteinerPrincipal.Size = New System.Drawing.Size(891, 588)
        Me.PnConteinerPrincipal.TabIndex = 9
        '
        'LbTituloForm
        '
        Me.LbTituloForm.AutoSize = True
        Me.LbTituloForm.Font = New System.Drawing.Font("Baloo", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTituloForm.Location = New System.Drawing.Point(8, 6)
        Me.LbTituloForm.Name = "LbTituloForm"
        Me.LbTituloForm.Size = New System.Drawing.Size(766, 75)
        Me.LbTituloForm.TabIndex = 5
        Me.LbTituloForm.Text = "FORMULARIO NUEVO PRODUCTO"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(664, 355)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(176, 158)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'CbProveedores
        '
        Me.CbProveedores.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CbProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbProveedores.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProveedores.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CbProveedores.FormattingEnabled = True
        Me.CbProveedores.Location = New System.Drawing.Point(648, 279)
        Me.CbProveedores.Name = "CbProveedores"
        Me.CbProveedores.Size = New System.Drawing.Size(200, 32)
        Me.CbProveedores.TabIndex = 3
        '
        'CbMarcasProductos
        '
        Me.CbMarcasProductos.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CbMarcasProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbMarcasProductos.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbMarcasProductos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CbMarcasProductos.FormattingEnabled = True
        Me.CbMarcasProductos.Location = New System.Drawing.Point(648, 204)
        Me.CbMarcasProductos.Name = "CbMarcasProductos"
        Me.CbMarcasProductos.Size = New System.Drawing.Size(200, 32)
        Me.CbMarcasProductos.TabIndex = 3
        '
        'CbCategoriaProducto
        '
        Me.CbCategoriaProducto.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CbCategoriaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbCategoriaProducto.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCategoriaProducto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CbCategoriaProducto.FormattingEnabled = True
        Me.CbCategoriaProducto.Location = New System.Drawing.Point(648, 132)
        Me.CbCategoriaProducto.Name = "CbCategoriaProducto"
        Me.CbCategoriaProducto.Size = New System.Drawing.Size(200, 32)
        Me.CbCategoriaProducto.TabIndex = 3
        '
        'PnDescripcionProductos
        '
        Me.PnDescripcionProductos.BackColor = System.Drawing.Color.White
        Me.PnDescripcionProductos.Controls.Add(Me.TbDescripcionProductos)
        Me.PnDescripcionProductos.Location = New System.Drawing.Point(13, 365)
        Me.PnDescripcionProductos.Name = "PnDescripcionProductos"
        Me.PnDescripcionProductos.Size = New System.Drawing.Size(591, 139)
        Me.PnDescripcionProductos.TabIndex = 2
        '
        'TbDescripcionProductos
        '
        Me.TbDescripcionProductos.BackColor = System.Drawing.Color.White
        Me.TbDescripcionProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbDescripcionProductos.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDescripcionProductos.Location = New System.Drawing.Point(19, 54)
        Me.TbDescripcionProductos.Name = "TbDescripcionProductos"
        Me.TbDescripcionProductos.Size = New System.Drawing.Size(550, 31)
        Me.TbDescripcionProductos.TabIndex = 0
        Me.TbDescripcionProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnUbicacionProducto
        '
        Me.PnUbicacionProducto.BackColor = System.Drawing.Color.White
        Me.PnUbicacionProducto.Controls.Add(Me.TbUbicacionProducto)
        Me.PnUbicacionProducto.Location = New System.Drawing.Point(13, 276)
        Me.PnUbicacionProducto.Name = "PnUbicacionProducto"
        Me.PnUbicacionProducto.Size = New System.Drawing.Size(591, 50)
        Me.PnUbicacionProducto.TabIndex = 2
        '
        'TbUbicacionProducto
        '
        Me.TbUbicacionProducto.BackColor = System.Drawing.Color.White
        Me.TbUbicacionProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbUbicacionProducto.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUbicacionProducto.Location = New System.Drawing.Point(19, 11)
        Me.TbUbicacionProducto.Name = "TbUbicacionProducto"
        Me.TbUbicacionProducto.Size = New System.Drawing.Size(558, 31)
        Me.TbUbicacionProducto.TabIndex = 0
        Me.TbUbicacionProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnAlmacenProducto
        '
        Me.PnAlmacenProducto.BackColor = System.Drawing.Color.White
        Me.PnAlmacenProducto.Controls.Add(Me.TbAlmacenProducto)
        Me.PnAlmacenProducto.Location = New System.Drawing.Point(13, 188)
        Me.PnAlmacenProducto.Name = "PnAlmacenProducto"
        Me.PnAlmacenProducto.Size = New System.Drawing.Size(591, 50)
        Me.PnAlmacenProducto.TabIndex = 2
        '
        'TbAlmacenProducto
        '
        Me.TbAlmacenProducto.BackColor = System.Drawing.Color.White
        Me.TbAlmacenProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbAlmacenProducto.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbAlmacenProducto.Location = New System.Drawing.Point(19, 11)
        Me.TbAlmacenProducto.Name = "TbAlmacenProducto"
        Me.TbAlmacenProducto.Size = New System.Drawing.Size(558, 31)
        Me.TbAlmacenProducto.TabIndex = 0
        Me.TbAlmacenProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnNombreProductos
        '
        Me.PnNombreProductos.BackColor = System.Drawing.Color.White
        Me.PnNombreProductos.Controls.Add(Me.TbNombreProductos)
        Me.PnNombreProductos.Location = New System.Drawing.Point(13, 104)
        Me.PnNombreProductos.Name = "PnNombreProductos"
        Me.PnNombreProductos.Size = New System.Drawing.Size(591, 50)
        Me.PnNombreProductos.TabIndex = 2
        '
        'TbNombreProductos
        '
        Me.TbNombreProductos.BackColor = System.Drawing.Color.White
        Me.TbNombreProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbNombreProductos.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNombreProductos.Location = New System.Drawing.Point(19, 11)
        Me.TbNombreProductos.Name = "TbNombreProductos"
        Me.TbNombreProductos.Size = New System.Drawing.Size(558, 31)
        Me.TbNombreProductos.TabIndex = 0
        Me.TbNombreProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnBackForm
        '
        Me.BtnBackForm.BackgroundImage = CType(resources.GetObject("BtnBackForm.BackgroundImage"), System.Drawing.Image)
        Me.BtnBackForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBackForm.FlatAppearance.BorderSize = 0
        Me.BtnBackForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnBackForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBackForm.Location = New System.Drawing.Point(21, 510)
        Me.BtnBackForm.Name = "BtnBackForm"
        Me.BtnBackForm.Size = New System.Drawing.Size(103, 64)
        Me.BtnBackForm.TabIndex = 10
        Me.BtnBackForm.UseVisualStyleBackColor = True
        '
        'FrmCatalogoProductos_Actualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 640)
        Me.Controls.Add(Me.PnConteinerPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(420, 80)
        Me.Name = "FrmCatalogoProductos_Actualizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmCatalogoProductos_Actualizar"
        Me.PnConteinerPrincipal.ResumeLayout(False)
        Me.PnConteinerPrincipal.PerformLayout()
        Me.PnDescripcionProductos.ResumeLayout(False)
        Me.PnDescripcionProductos.PerformLayout()
        Me.PnUbicacionProducto.ResumeLayout(False)
        Me.PnUbicacionProducto.PerformLayout()
        Me.PnAlmacenProducto.ResumeLayout(False)
        Me.PnAlmacenProducto.PerformLayout()
        Me.PnNombreProductos.ResumeLayout(False)
        Me.PnNombreProductos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnConteinerPrincipal As Panel
    Friend WithEvents LbTituloForm As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents CbProveedores As ComboBox
    Friend WithEvents CbMarcasProductos As ComboBox
    Friend WithEvents CbCategoriaProducto As ComboBox
    Friend WithEvents PnDescripcionProductos As Panel
    Friend WithEvents TbDescripcionProductos As TextBox
    Friend WithEvents PnUbicacionProducto As Panel
    Friend WithEvents TbUbicacionProducto As TextBox
    Friend WithEvents PnAlmacenProducto As Panel
    Friend WithEvents TbAlmacenProducto As TextBox
    Friend WithEvents PnNombreProductos As Panel
    Friend WithEvents TbNombreProductos As TextBox
    Friend WithEvents BtnBackForm As Button
End Class
