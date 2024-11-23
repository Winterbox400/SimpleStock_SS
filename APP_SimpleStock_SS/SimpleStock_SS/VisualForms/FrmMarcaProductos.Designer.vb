<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarcaProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMarcaProductos))
        Me.LbTituloForm = New System.Windows.Forms.Label()
        Me.BtnCrearNuevaMarca = New System.Windows.Forms.Button()
        Me.BtnCambiarMarca = New System.Windows.Forms.Button()
        Me.BtnEliminarMarca = New System.Windows.Forms.Button()
        Me.PnConteinerMarca = New System.Windows.Forms.Panel()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PnDescripcionMarca = New System.Windows.Forms.Panel()
        Me.TbDescripcionMarca = New System.Windows.Forms.TextBox()
        Me.PnNombreMarca = New System.Windows.Forms.Panel()
        Me.TbNombreMarca = New System.Windows.Forms.TextBox()
        Me.DgvVW_Marcas = New System.Windows.Forms.DataGridView()
        Me.PnConteinerMarca.SuspendLayout()
        Me.PnDescripcionMarca.SuspendLayout()
        Me.PnNombreMarca.SuspendLayout()
        CType(Me.DgvVW_Marcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbTituloForm
        '
        Me.LbTituloForm.AutoSize = True
        Me.LbTituloForm.Font = New System.Drawing.Font("Baloo", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTituloForm.Location = New System.Drawing.Point(12, 9)
        Me.LbTituloForm.Name = "LbTituloForm"
        Me.LbTituloForm.Size = New System.Drawing.Size(579, 75)
        Me.LbTituloForm.TabIndex = 0
        Me.LbTituloForm.Text = "MARCAS DE PRODUCTOS"
        '
        'BtnCrearNuevaMarca
        '
        Me.BtnCrearNuevaMarca.FlatAppearance.BorderSize = 0
        Me.BtnCrearNuevaMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearNuevaMarca.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearNuevaMarca.Location = New System.Drawing.Point(25, 98)
        Me.BtnCrearNuevaMarca.Name = "BtnCrearNuevaMarca"
        Me.BtnCrearNuevaMarca.Size = New System.Drawing.Size(332, 50)
        Me.BtnCrearNuevaMarca.TabIndex = 1
        Me.BtnCrearNuevaMarca.Text = "CREAR NUEVA MARCA"
        Me.BtnCrearNuevaMarca.UseVisualStyleBackColor = True
        '
        'BtnCambiarMarca
        '
        Me.BtnCambiarMarca.FlatAppearance.BorderSize = 0
        Me.BtnCambiarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCambiarMarca.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambiarMarca.Location = New System.Drawing.Point(25, 197)
        Me.BtnCambiarMarca.Name = "BtnCambiarMarca"
        Me.BtnCambiarMarca.Size = New System.Drawing.Size(332, 50)
        Me.BtnCambiarMarca.TabIndex = 1
        Me.BtnCambiarMarca.Text = "CAMBIAR UNA MARCA"
        Me.BtnCambiarMarca.UseVisualStyleBackColor = True
        '
        'BtnEliminarMarca
        '
        Me.BtnEliminarMarca.FlatAppearance.BorderSize = 0
        Me.BtnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarMarca.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarMarca.Location = New System.Drawing.Point(25, 295)
        Me.BtnEliminarMarca.Name = "BtnEliminarMarca"
        Me.BtnEliminarMarca.Size = New System.Drawing.Size(332, 50)
        Me.BtnEliminarMarca.TabIndex = 1
        Me.BtnEliminarMarca.Text = "ELIMINAR MARCA"
        Me.BtnEliminarMarca.UseVisualStyleBackColor = True
        '
        'PnConteinerMarca
        '
        Me.PnConteinerMarca.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PnConteinerMarca.Controls.Add(Me.BtnGuardar)
        Me.PnConteinerMarca.Controls.Add(Me.PnDescripcionMarca)
        Me.PnConteinerMarca.Controls.Add(Me.PnNombreMarca)
        Me.PnConteinerMarca.Location = New System.Drawing.Point(25, 399)
        Me.PnConteinerMarca.Name = "PnConteinerMarca"
        Me.PnConteinerMarca.Size = New System.Drawing.Size(856, 217)
        Me.PnConteinerMarca.TabIndex = 2
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(641, 34)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(176, 158)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'PnDescripcionMarca
        '
        Me.PnDescripcionMarca.BackColor = System.Drawing.Color.White
        Me.PnDescripcionMarca.Controls.Add(Me.TbDescripcionMarca)
        Me.PnDescripcionMarca.Location = New System.Drawing.Point(37, 102)
        Me.PnDescripcionMarca.Name = "PnDescripcionMarca"
        Me.PnDescripcionMarca.Size = New System.Drawing.Size(563, 97)
        Me.PnDescripcionMarca.TabIndex = 2
        '
        'TbDescripcionMarca
        '
        Me.TbDescripcionMarca.BackColor = System.Drawing.Color.White
        Me.TbDescripcionMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbDescripcionMarca.Font = New System.Drawing.Font("HP Simplified Hans", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDescripcionMarca.Location = New System.Drawing.Point(19, 29)
        Me.TbDescripcionMarca.Name = "TbDescripcionMarca"
        Me.TbDescripcionMarca.Size = New System.Drawing.Size(529, 33)
        Me.TbDescripcionMarca.TabIndex = 0
        '
        'PnNombreMarca
        '
        Me.PnNombreMarca.BackColor = System.Drawing.Color.White
        Me.PnNombreMarca.Controls.Add(Me.TbNombreMarca)
        Me.PnNombreMarca.Location = New System.Drawing.Point(37, 34)
        Me.PnNombreMarca.Name = "PnNombreMarca"
        Me.PnNombreMarca.Size = New System.Drawing.Size(504, 50)
        Me.PnNombreMarca.TabIndex = 2
        '
        'TbNombreMarca
        '
        Me.TbNombreMarca.BackColor = System.Drawing.Color.White
        Me.TbNombreMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbNombreMarca.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNombreMarca.Location = New System.Drawing.Point(19, 10)
        Me.TbNombreMarca.Name = "TbNombreMarca"
        Me.TbNombreMarca.Size = New System.Drawing.Size(462, 31)
        Me.TbNombreMarca.TabIndex = 0
        Me.TbNombreMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DgvVW_Marcas
        '
        Me.DgvVW_Marcas.AllowUserToAddRows = False
        Me.DgvVW_Marcas.AllowUserToResizeRows = False
        Me.DgvVW_Marcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvVW_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVW_Marcas.Location = New System.Drawing.Point(456, 98)
        Me.DgvVW_Marcas.Name = "DgvVW_Marcas"
        Me.DgvVW_Marcas.ReadOnly = True
        Me.DgvVW_Marcas.RowHeadersVisible = False
        Me.DgvVW_Marcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVW_Marcas.Size = New System.Drawing.Size(425, 247)
        Me.DgvVW_Marcas.TabIndex = 3
        '
        'FrmMarcaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(915, 640)
        Me.Controls.Add(Me.DgvVW_Marcas)
        Me.Controls.Add(Me.PnConteinerMarca)
        Me.Controls.Add(Me.BtnEliminarMarca)
        Me.Controls.Add(Me.BtnCambiarMarca)
        Me.Controls.Add(Me.BtnCrearNuevaMarca)
        Me.Controls.Add(Me.LbTituloForm)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(420, 80)
        Me.Name = "FrmMarcaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmMarcaProductos"
        Me.PnConteinerMarca.ResumeLayout(False)
        Me.PnDescripcionMarca.ResumeLayout(False)
        Me.PnDescripcionMarca.PerformLayout()
        Me.PnNombreMarca.ResumeLayout(False)
        Me.PnNombreMarca.PerformLayout()
        CType(Me.DgvVW_Marcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbTituloForm As Label
    Friend WithEvents BtnCrearNuevaMarca As Button
    Friend WithEvents BtnCambiarMarca As Button
    Friend WithEvents BtnEliminarMarca As Button
    Friend WithEvents PnConteinerMarca As Panel
    Friend WithEvents DgvVW_Marcas As DataGridView
    Friend WithEvents PnNombreMarca As Panel
    Friend WithEvents TbNombreMarca As TextBox
    Friend WithEvents PnDescripcionMarca As Panel
    Friend WithEvents TbDescripcionMarca As TextBox
    Friend WithEvents BtnGuardar As Button
End Class
