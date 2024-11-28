<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatalogoProductos
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
        Me.BtnEliminarProducto = New System.Windows.Forms.Button()
        Me.BtnCambiarProducto = New System.Windows.Forms.Button()
        Me.BtnCrearNuevoProducto = New System.Windows.Forms.Button()
        Me.LbTituloForm = New System.Windows.Forms.Label()
        Me.PnConteinerProductos = New System.Windows.Forms.Panel()
        Me.PnDescripcionProductos = New System.Windows.Forms.Panel()
        Me.TbDescripcionProductos = New System.Windows.Forms.TextBox()
        Me.PnNombreProductos = New System.Windows.Forms.Panel()
        Me.TbNombreProductos = New System.Windows.Forms.TextBox()
        Me.DgvVW_Productos = New System.Windows.Forms.DataGridView()
        Me.PnConteinerProductos.SuspendLayout()
        Me.PnDescripcionProductos.SuspendLayout()
        Me.PnNombreProductos.SuspendLayout()
        CType(Me.DgvVW_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEliminarProducto
        '
        Me.BtnEliminarProducto.FlatAppearance.BorderSize = 0
        Me.BtnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarProducto.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarProducto.Location = New System.Drawing.Point(35, 294)
        Me.BtnEliminarProducto.Name = "BtnEliminarProducto"
        Me.BtnEliminarProducto.Size = New System.Drawing.Size(264, 64)
        Me.BtnEliminarProducto.TabIndex = 3
        Me.BtnEliminarProducto.Text = "ELIMINAR NUEVO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRODUCTO"
        Me.BtnEliminarProducto.UseVisualStyleBackColor = True
        '
        'BtnCambiarProducto
        '
        Me.BtnCambiarProducto.FlatAppearance.BorderSize = 0
        Me.BtnCambiarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCambiarProducto.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambiarProducto.Location = New System.Drawing.Point(35, 198)
        Me.BtnCambiarProducto.Name = "BtnCambiarProducto"
        Me.BtnCambiarProducto.Size = New System.Drawing.Size(264, 64)
        Me.BtnCambiarProducto.TabIndex = 4
        Me.BtnCambiarProducto.Text = "CAMBIAR NUEVO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRODUCTO"
        Me.BtnCambiarProducto.UseVisualStyleBackColor = True
        '
        'BtnCrearNuevoProducto
        '
        Me.BtnCrearNuevoProducto.FlatAppearance.BorderSize = 0
        Me.BtnCrearNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearNuevoProducto.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearNuevoProducto.Location = New System.Drawing.Point(35, 107)
        Me.BtnCrearNuevoProducto.Name = "BtnCrearNuevoProducto"
        Me.BtnCrearNuevoProducto.Size = New System.Drawing.Size(264, 64)
        Me.BtnCrearNuevoProducto.TabIndex = 5
        Me.BtnCrearNuevoProducto.Text = "CREAR NUEVO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRODUCTO"
        Me.BtnCrearNuevoProducto.UseVisualStyleBackColor = True
        '
        'LbTituloForm
        '
        Me.LbTituloForm.AutoSize = True
        Me.LbTituloForm.Font = New System.Drawing.Font("Baloo", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTituloForm.Location = New System.Drawing.Point(12, 9)
        Me.LbTituloForm.Name = "LbTituloForm"
        Me.LbTituloForm.Size = New System.Drawing.Size(635, 75)
        Me.LbTituloForm.TabIndex = 6
        Me.LbTituloForm.Text = "CATALOGO DE PRODUCTOS"
        '
        'PnConteinerProductos
        '
        Me.PnConteinerProductos.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PnConteinerProductos.Controls.Add(Me.PnDescripcionProductos)
        Me.PnConteinerProductos.Controls.Add(Me.PnNombreProductos)
        Me.PnConteinerProductos.Location = New System.Drawing.Point(352, 87)
        Me.PnConteinerProductos.Name = "PnConteinerProductos"
        Me.PnConteinerProductos.Size = New System.Drawing.Size(526, 271)
        Me.PnConteinerProductos.TabIndex = 7
        '
        'PnDescripcionProductos
        '
        Me.PnDescripcionProductos.BackColor = System.Drawing.Color.White
        Me.PnDescripcionProductos.Controls.Add(Me.TbDescripcionProductos)
        Me.PnDescripcionProductos.Location = New System.Drawing.Point(13, 105)
        Me.PnDescripcionProductos.Name = "PnDescripcionProductos"
        Me.PnDescripcionProductos.Size = New System.Drawing.Size(492, 139)
        Me.PnDescripcionProductos.TabIndex = 2
        '
        'TbDescripcionProductos
        '
        Me.TbDescripcionProductos.BackColor = System.Drawing.Color.White
        Me.TbDescripcionProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbDescripcionProductos.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDescripcionProductos.Location = New System.Drawing.Point(19, 54)
        Me.TbDescripcionProductos.Name = "TbDescripcionProductos"
        Me.TbDescripcionProductos.Size = New System.Drawing.Size(458, 31)
        Me.TbDescripcionProductos.TabIndex = 0
        Me.TbDescripcionProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnNombreProductos
        '
        Me.PnNombreProductos.BackColor = System.Drawing.Color.White
        Me.PnNombreProductos.Controls.Add(Me.TbNombreProductos)
        Me.PnNombreProductos.Location = New System.Drawing.Point(13, 32)
        Me.PnNombreProductos.Name = "PnNombreProductos"
        Me.PnNombreProductos.Size = New System.Drawing.Size(492, 50)
        Me.PnNombreProductos.TabIndex = 2
        '
        'TbNombreProductos
        '
        Me.TbNombreProductos.BackColor = System.Drawing.Color.White
        Me.TbNombreProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbNombreProductos.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNombreProductos.Location = New System.Drawing.Point(19, 11)
        Me.TbNombreProductos.Name = "TbNombreProductos"
        Me.TbNombreProductos.Size = New System.Drawing.Size(458, 31)
        Me.TbNombreProductos.TabIndex = 0
        Me.TbNombreProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DgvVW_Productos
        '
        Me.DgvVW_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVW_Productos.Location = New System.Drawing.Point(25, 386)
        Me.DgvVW_Productos.Name = "DgvVW_Productos"
        Me.DgvVW_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVW_Productos.Size = New System.Drawing.Size(870, 237)
        Me.DgvVW_Productos.TabIndex = 8
        '
        'FrmCatalogoProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 640)
        Me.Controls.Add(Me.DgvVW_Productos)
        Me.Controls.Add(Me.PnConteinerProductos)
        Me.Controls.Add(Me.LbTituloForm)
        Me.Controls.Add(Me.BtnEliminarProducto)
        Me.Controls.Add(Me.BtnCambiarProducto)
        Me.Controls.Add(Me.BtnCrearNuevoProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(420, 80)
        Me.Name = "FrmCatalogoProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmCatalogoProductos"
        Me.PnConteinerProductos.ResumeLayout(False)
        Me.PnDescripcionProductos.ResumeLayout(False)
        Me.PnDescripcionProductos.PerformLayout()
        Me.PnNombreProductos.ResumeLayout(False)
        Me.PnNombreProductos.PerformLayout()
        CType(Me.DgvVW_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEliminarProducto As Button
    Friend WithEvents BtnCambiarProducto As Button
    Friend WithEvents BtnCrearNuevoProducto As Button
    Friend WithEvents LbTituloForm As Label
    Friend WithEvents PnConteinerProductos As Panel
    Friend WithEvents PnDescripcionProductos As Panel
    Friend WithEvents TbDescripcionProductos As TextBox
    Friend WithEvents PnNombreProductos As Panel
    Friend WithEvents TbNombreProductos As TextBox
    Friend WithEvents DgvVW_Productos As DataGridView
End Class
