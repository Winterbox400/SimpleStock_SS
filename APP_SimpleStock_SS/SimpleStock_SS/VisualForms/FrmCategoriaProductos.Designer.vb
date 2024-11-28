<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategoriaProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCategoriaProductos))
        Me.LbTituloForm = New System.Windows.Forms.Label()
        Me.BtnCrearNuevaCategoria = New System.Windows.Forms.Button()
        Me.BtnEliminarCategoria = New System.Windows.Forms.Button()
        Me.BtnCambiarCategoria = New System.Windows.Forms.Button()
        Me.DgvVW_Categoria = New System.Windows.Forms.DataGridView()
        Me.PnConteinerCategoria = New System.Windows.Forms.Panel()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PnDescripcionCategoria = New System.Windows.Forms.Panel()
        Me.TbDescripcionCategoria = New System.Windows.Forms.TextBox()
        Me.PnNombreCategoria = New System.Windows.Forms.Panel()
        Me.TbNombreCategoria = New System.Windows.Forms.TextBox()
        Me.LbSubTituloPanel = New System.Windows.Forms.Label()
        CType(Me.DgvVW_Categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnConteinerCategoria.SuspendLayout()
        Me.PnDescripcionCategoria.SuspendLayout()
        Me.PnNombreCategoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbTituloForm
        '
        Me.LbTituloForm.AutoSize = True
        Me.LbTituloForm.Font = New System.Drawing.Font("Baloo", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTituloForm.Location = New System.Drawing.Point(12, 9)
        Me.LbTituloForm.Name = "LbTituloForm"
        Me.LbTituloForm.Size = New System.Drawing.Size(650, 75)
        Me.LbTituloForm.TabIndex = 1
        Me.LbTituloForm.Text = "CATEGORIA DE PRODUCTOS"
        '
        'BtnCrearNuevaCategoria
        '
        Me.BtnCrearNuevaCategoria.FlatAppearance.BorderSize = 0
        Me.BtnCrearNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearNuevaCategoria.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearNuevaCategoria.Location = New System.Drawing.Point(25, 98)
        Me.BtnCrearNuevaCategoria.Name = "BtnCrearNuevaCategoria"
        Me.BtnCrearNuevaCategoria.Size = New System.Drawing.Size(332, 50)
        Me.BtnCrearNuevaCategoria.TabIndex = 2
        Me.BtnCrearNuevaCategoria.Text = "CREAR NUEVA CATEGORIA"
        Me.BtnCrearNuevaCategoria.UseVisualStyleBackColor = True
        '
        'BtnEliminarCategoria
        '
        Me.BtnEliminarCategoria.FlatAppearance.BorderSize = 0
        Me.BtnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarCategoria.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarCategoria.Location = New System.Drawing.Point(25, 295)
        Me.BtnEliminarCategoria.Name = "BtnEliminarCategoria"
        Me.BtnEliminarCategoria.Size = New System.Drawing.Size(332, 50)
        Me.BtnEliminarCategoria.TabIndex = 3
        Me.BtnEliminarCategoria.Text = "ELIMINAR CATEGORIA"
        Me.BtnEliminarCategoria.UseVisualStyleBackColor = True
        '
        'BtnCambiarCategoria
        '
        Me.BtnCambiarCategoria.FlatAppearance.BorderSize = 0
        Me.BtnCambiarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCambiarCategoria.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambiarCategoria.Location = New System.Drawing.Point(25, 197)
        Me.BtnCambiarCategoria.Name = "BtnCambiarCategoria"
        Me.BtnCambiarCategoria.Size = New System.Drawing.Size(332, 50)
        Me.BtnCambiarCategoria.TabIndex = 4
        Me.BtnCambiarCategoria.Text = "CAMBIAR UNA CATEGORIA"
        Me.BtnCambiarCategoria.UseVisualStyleBackColor = True
        '
        'DgvVW_Categoria
        '
        Me.DgvVW_Categoria.AllowUserToAddRows = False
        Me.DgvVW_Categoria.AllowUserToResizeRows = False
        Me.DgvVW_Categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvVW_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVW_Categoria.Location = New System.Drawing.Point(456, 98)
        Me.DgvVW_Categoria.Name = "DgvVW_Categoria"
        Me.DgvVW_Categoria.ReadOnly = True
        Me.DgvVW_Categoria.RowHeadersVisible = False
        Me.DgvVW_Categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVW_Categoria.Size = New System.Drawing.Size(425, 247)
        Me.DgvVW_Categoria.TabIndex = 5
        '
        'PnConteinerCategoria
        '
        Me.PnConteinerCategoria.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PnConteinerCategoria.Controls.Add(Me.LbSubTituloPanel)
        Me.PnConteinerCategoria.Controls.Add(Me.BtnGuardar)
        Me.PnConteinerCategoria.Controls.Add(Me.PnDescripcionCategoria)
        Me.PnConteinerCategoria.Controls.Add(Me.PnNombreCategoria)
        Me.PnConteinerCategoria.Location = New System.Drawing.Point(25, 399)
        Me.PnConteinerCategoria.Name = "PnConteinerCategoria"
        Me.PnConteinerCategoria.Size = New System.Drawing.Size(856, 217)
        Me.PnConteinerCategoria.TabIndex = 6
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
        'PnDescripcionCategoria
        '
        Me.PnDescripcionCategoria.BackColor = System.Drawing.Color.White
        Me.PnDescripcionCategoria.Controls.Add(Me.TbDescripcionCategoria)
        Me.PnDescripcionCategoria.Location = New System.Drawing.Point(37, 102)
        Me.PnDescripcionCategoria.Name = "PnDescripcionCategoria"
        Me.PnDescripcionCategoria.Size = New System.Drawing.Size(563, 97)
        Me.PnDescripcionCategoria.TabIndex = 2
        '
        'TbDescripcionCategoria
        '
        Me.TbDescripcionCategoria.BackColor = System.Drawing.Color.White
        Me.TbDescripcionCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbDescripcionCategoria.Font = New System.Drawing.Font("HP Simplified Hans", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDescripcionCategoria.Location = New System.Drawing.Point(19, 29)
        Me.TbDescripcionCategoria.Name = "TbDescripcionCategoria"
        Me.TbDescripcionCategoria.Size = New System.Drawing.Size(529, 33)
        Me.TbDescripcionCategoria.TabIndex = 0
        '
        'PnNombreCategoria
        '
        Me.PnNombreCategoria.BackColor = System.Drawing.Color.White
        Me.PnNombreCategoria.Controls.Add(Me.TbNombreCategoria)
        Me.PnNombreCategoria.Location = New System.Drawing.Point(37, 34)
        Me.PnNombreCategoria.Name = "PnNombreCategoria"
        Me.PnNombreCategoria.Size = New System.Drawing.Size(504, 50)
        Me.PnNombreCategoria.TabIndex = 2
        '
        'TbNombreCategoria
        '
        Me.TbNombreCategoria.BackColor = System.Drawing.Color.White
        Me.TbNombreCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbNombreCategoria.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNombreCategoria.Location = New System.Drawing.Point(19, 10)
        Me.TbNombreCategoria.Name = "TbNombreCategoria"
        Me.TbNombreCategoria.Size = New System.Drawing.Size(462, 31)
        Me.TbNombreCategoria.TabIndex = 0
        Me.TbNombreCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LbSubTituloPanel
        '
        Me.LbSubTituloPanel.AutoSize = True
        Me.LbSubTituloPanel.Font = New System.Drawing.Font("HP Simplified Hans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSubTituloPanel.Location = New System.Drawing.Point(39, 7)
        Me.LbSubTituloPanel.Name = "LbSubTituloPanel"
        Me.LbSubTituloPanel.Size = New System.Drawing.Size(71, 22)
        Me.LbSubTituloPanel.TabIndex = 7
        Me.LbSubTituloPanel.Text = "Label1"
        '
        'FrmCategoriaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(915, 640)
        Me.Controls.Add(Me.PnConteinerCategoria)
        Me.Controls.Add(Me.DgvVW_Categoria)
        Me.Controls.Add(Me.BtnEliminarCategoria)
        Me.Controls.Add(Me.BtnCambiarCategoria)
        Me.Controls.Add(Me.BtnCrearNuevaCategoria)
        Me.Controls.Add(Me.LbTituloForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(420, 80)
        Me.Name = "FrmCategoriaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmCategoriaProductos"
        CType(Me.DgvVW_Categoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnConteinerCategoria.ResumeLayout(False)
        Me.PnConteinerCategoria.PerformLayout()
        Me.PnDescripcionCategoria.ResumeLayout(False)
        Me.PnDescripcionCategoria.PerformLayout()
        Me.PnNombreCategoria.ResumeLayout(False)
        Me.PnNombreCategoria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbTituloForm As Label
    Friend WithEvents BtnCrearNuevaCategoria As Button
    Friend WithEvents BtnEliminarCategoria As Button
    Friend WithEvents BtnCambiarCategoria As Button
    Friend WithEvents DgvVW_Categoria As DataGridView
    Friend WithEvents PnConteinerCategoria As Panel
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents PnDescripcionCategoria As Panel
    Friend WithEvents TbDescripcionCategoria As TextBox
    Friend WithEvents PnNombreCategoria As Panel
    Friend WithEvents TbNombreCategoria As TextBox
    Friend WithEvents LbSubTituloPanel As Label
End Class
