<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroEntrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroEntrada))
        Me.PnConteinerSuperior = New System.Windows.Forms.Panel()
        Me.CbTipoRegistro = New System.Windows.Forms.ComboBox()
        Me.PnDescripcionProducto = New System.Windows.Forms.Panel()
        Me.TbDescripcionRegistro = New System.Windows.Forms.TextBox()
        Me.BtnCheckRegistro = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PnConteinerCentral = New System.Windows.Forms.Panel()
        Me.BtnBuscarProducto = New System.Windows.Forms.Button()
        Me.PnPrecio = New System.Windows.Forms.Panel()
        Me.TbPrecio = New System.Windows.Forms.TextBox()
        Me.PnCantidad = New System.Windows.Forms.Panel()
        Me.TbCantidad = New System.Windows.Forms.TextBox()
        Me.PnProducto = New System.Windows.Forms.Panel()
        Me.TbProducto = New System.Windows.Forms.TextBox()
        Me.BtnCheckProducto = New System.Windows.Forms.Button()
        Me.DgvVW_Registro = New System.Windows.Forms.DataGridView()
        Me.PnConteinerSuperior.SuspendLayout()
        Me.PnDescripcionProducto.SuspendLayout()
        Me.PnConteinerCentral.SuspendLayout()
        Me.PnPrecio.SuspendLayout()
        Me.PnCantidad.SuspendLayout()
        Me.PnProducto.SuspendLayout()
        CType(Me.DgvVW_Registro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnConteinerSuperior
        '
        Me.PnConteinerSuperior.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PnConteinerSuperior.Controls.Add(Me.CbTipoRegistro)
        Me.PnConteinerSuperior.Controls.Add(Me.PnDescripcionProducto)
        Me.PnConteinerSuperior.Controls.Add(Me.BtnCheckRegistro)
        Me.PnConteinerSuperior.Location = New System.Drawing.Point(12, 26)
        Me.PnConteinerSuperior.Name = "PnConteinerSuperior"
        Me.PnConteinerSuperior.Size = New System.Drawing.Size(891, 94)
        Me.PnConteinerSuperior.TabIndex = 9
        '
        'CbTipoRegistro
        '
        Me.CbTipoRegistro.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CbTipoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbTipoRegistro.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTipoRegistro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CbTipoRegistro.FormattingEnabled = True
        Me.CbTipoRegistro.Location = New System.Drawing.Point(582, 33)
        Me.CbTipoRegistro.Name = "CbTipoRegistro"
        Me.CbTipoRegistro.Size = New System.Drawing.Size(200, 32)
        Me.CbTipoRegistro.TabIndex = 3
        '
        'PnDescripcionProducto
        '
        Me.PnDescripcionProducto.BackColor = System.Drawing.Color.White
        Me.PnDescripcionProducto.Controls.Add(Me.TbDescripcionRegistro)
        Me.PnDescripcionProducto.Location = New System.Drawing.Point(13, 22)
        Me.PnDescripcionProducto.Name = "PnDescripcionProducto"
        Me.PnDescripcionProducto.Size = New System.Drawing.Size(549, 50)
        Me.PnDescripcionProducto.TabIndex = 2
        '
        'TbDescripcionRegistro
        '
        Me.TbDescripcionRegistro.BackColor = System.Drawing.Color.White
        Me.TbDescripcionRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbDescripcionRegistro.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDescripcionRegistro.Location = New System.Drawing.Point(19, 11)
        Me.TbDescripcionRegistro.Name = "TbDescripcionRegistro"
        Me.TbDescripcionRegistro.Size = New System.Drawing.Size(496, 31)
        Me.TbDescripcionRegistro.TabIndex = 0
        Me.TbDescripcionRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCheckRegistro
        '
        Me.BtnCheckRegistro.BackgroundImage = CType(resources.GetObject("BtnCheckRegistro.BackgroundImage"), System.Drawing.Image)
        Me.BtnCheckRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCheckRegistro.FlatAppearance.BorderSize = 0
        Me.BtnCheckRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCheckRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCheckRegistro.Location = New System.Drawing.Point(808, 29)
        Me.BtnCheckRegistro.Name = "BtnCheckRegistro"
        Me.BtnCheckRegistro.Size = New System.Drawing.Size(52, 43)
        Me.BtnCheckRegistro.TabIndex = 4
        Me.BtnCheckRegistro.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackgroundImage = CType(resources.GetObject("BtnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Location = New System.Drawing.Point(25, 540)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(103, 88)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(793, 547)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(79, 74)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'PnConteinerCentral
        '
        Me.PnConteinerCentral.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PnConteinerCentral.Controls.Add(Me.BtnBuscarProducto)
        Me.PnConteinerCentral.Controls.Add(Me.PnPrecio)
        Me.PnConteinerCentral.Controls.Add(Me.PnCantidad)
        Me.PnConteinerCentral.Controls.Add(Me.PnProducto)
        Me.PnConteinerCentral.Controls.Add(Me.BtnCheckProducto)
        Me.PnConteinerCentral.Location = New System.Drawing.Point(12, 139)
        Me.PnConteinerCentral.Name = "PnConteinerCentral"
        Me.PnConteinerCentral.Size = New System.Drawing.Size(891, 94)
        Me.PnConteinerCentral.TabIndex = 10
        '
        'BtnBuscarProducto
        '
        Me.BtnBuscarProducto.BackgroundImage = CType(resources.GetObject("BtnBuscarProducto.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscarProducto.FlatAppearance.BorderSize = 0
        Me.BtnBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarProducto.Location = New System.Drawing.Point(216, 22)
        Me.BtnBuscarProducto.Name = "BtnBuscarProducto"
        Me.BtnBuscarProducto.Size = New System.Drawing.Size(53, 50)
        Me.BtnBuscarProducto.TabIndex = 12
        Me.BtnBuscarProducto.UseVisualStyleBackColor = True
        '
        'PnPrecio
        '
        Me.PnPrecio.BackColor = System.Drawing.Color.White
        Me.PnPrecio.Controls.Add(Me.TbPrecio)
        Me.PnPrecio.Location = New System.Drawing.Point(563, 22)
        Me.PnPrecio.Name = "PnPrecio"
        Me.PnPrecio.Size = New System.Drawing.Size(197, 50)
        Me.PnPrecio.TabIndex = 11
        '
        'TbPrecio
        '
        Me.TbPrecio.BackColor = System.Drawing.Color.White
        Me.TbPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbPrecio.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPrecio.Location = New System.Drawing.Point(19, 11)
        Me.TbPrecio.Name = "TbPrecio"
        Me.TbPrecio.Size = New System.Drawing.Size(162, 31)
        Me.TbPrecio.TabIndex = 0
        Me.TbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnCantidad
        '
        Me.PnCantidad.BackColor = System.Drawing.Color.White
        Me.PnCantidad.Controls.Add(Me.TbCantidad)
        Me.PnCantidad.Location = New System.Drawing.Point(308, 22)
        Me.PnCantidad.Name = "PnCantidad"
        Me.PnCantidad.Size = New System.Drawing.Size(197, 50)
        Me.PnCantidad.TabIndex = 11
        '
        'TbCantidad
        '
        Me.TbCantidad.BackColor = System.Drawing.Color.White
        Me.TbCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbCantidad.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCantidad.Location = New System.Drawing.Point(19, 11)
        Me.TbCantidad.Name = "TbCantidad"
        Me.TbCantidad.Size = New System.Drawing.Size(162, 31)
        Me.TbCantidad.TabIndex = 0
        Me.TbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnProducto
        '
        Me.PnProducto.BackColor = System.Drawing.Color.White
        Me.PnProducto.Controls.Add(Me.TbProducto)
        Me.PnProducto.Location = New System.Drawing.Point(13, 22)
        Me.PnProducto.Name = "PnProducto"
        Me.PnProducto.Size = New System.Drawing.Size(197, 50)
        Me.PnProducto.TabIndex = 2
        '
        'TbProducto
        '
        Me.TbProducto.BackColor = System.Drawing.Color.White
        Me.TbProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbProducto.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbProducto.Location = New System.Drawing.Point(19, 11)
        Me.TbProducto.Name = "TbProducto"
        Me.TbProducto.Size = New System.Drawing.Size(162, 31)
        Me.TbProducto.TabIndex = 0
        Me.TbProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCheckProducto
        '
        Me.BtnCheckProducto.BackgroundImage = CType(resources.GetObject("BtnCheckProducto.BackgroundImage"), System.Drawing.Image)
        Me.BtnCheckProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCheckProducto.FlatAppearance.BorderSize = 0
        Me.BtnCheckProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCheckProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCheckProducto.Location = New System.Drawing.Point(781, 22)
        Me.BtnCheckProducto.Name = "BtnCheckProducto"
        Me.BtnCheckProducto.Size = New System.Drawing.Size(56, 50)
        Me.BtnCheckProducto.TabIndex = 4
        Me.BtnCheckProducto.UseVisualStyleBackColor = True
        '
        'DgvVW_Registro
        '
        Me.DgvVW_Registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVW_Registro.Location = New System.Drawing.Point(44, 251)
        Me.DgvVW_Registro.Name = "DgvVW_Registro"
        Me.DgvVW_Registro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVW_Registro.Size = New System.Drawing.Size(843, 283)
        Me.DgvVW_Registro.TabIndex = 11
        '
        'FrmRegistroEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 640)
        Me.Controls.Add(Me.DgvVW_Registro)
        Me.Controls.Add(Me.PnConteinerCentral)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.PnConteinerSuperior)
        Me.Controls.Add(Me.BtnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(420, 80)
        Me.Name = "FrmRegistroEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "RegistroEntrada"
        Me.PnConteinerSuperior.ResumeLayout(False)
        Me.PnDescripcionProducto.ResumeLayout(False)
        Me.PnDescripcionProducto.PerformLayout()
        Me.PnConteinerCentral.ResumeLayout(False)
        Me.PnPrecio.ResumeLayout(False)
        Me.PnPrecio.PerformLayout()
        Me.PnCantidad.ResumeLayout(False)
        Me.PnCantidad.PerformLayout()
        Me.PnProducto.ResumeLayout(False)
        Me.PnProducto.PerformLayout()
        CType(Me.DgvVW_Registro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnConteinerSuperior As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents CbTipoRegistro As ComboBox
    Friend WithEvents PnDescripcionProducto As Panel
    Friend WithEvents TbDescripcionRegistro As TextBox
    Friend WithEvents BtnCheckRegistro As Button
    Friend WithEvents PnConteinerCentral As Panel
    Friend WithEvents BtnBuscarProducto As Button
    Friend WithEvents PnPrecio As Panel
    Friend WithEvents TbPrecio As TextBox
    Friend WithEvents PnCantidad As Panel
    Friend WithEvents TbCantidad As TextBox
    Friend WithEvents PnProducto As Panel
    Friend WithEvents TbProducto As TextBox
    Friend WithEvents BtnCheckProducto As Button
    Friend WithEvents DgvVW_Registro As DataGridView
End Class
