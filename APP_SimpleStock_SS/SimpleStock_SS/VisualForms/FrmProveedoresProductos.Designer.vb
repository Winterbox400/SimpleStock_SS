<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedoresProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProveedoresProductos))
        Me.BtnCrearNuevoProveedor = New System.Windows.Forms.Button()
        Me.LbTituloForm = New System.Windows.Forms.Label()
        Me.BtnCambiarProveedor = New System.Windows.Forms.Button()
        Me.BtnEliminarProveedor = New System.Windows.Forms.Button()
        Me.PnConteinerProveedor = New System.Windows.Forms.Panel()
        Me.LbSubTituloPanel = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PnCelularProveedor = New System.Windows.Forms.Panel()
        Me.TbCelularProveedor = New System.Windows.Forms.TextBox()
        Me.PnCorreoProveedor = New System.Windows.Forms.Panel()
        Me.TbCorreoProveedor = New System.Windows.Forms.TextBox()
        Me.PnNombreProveedor = New System.Windows.Forms.Panel()
        Me.TbNombreProveedor = New System.Windows.Forms.TextBox()
        Me.DgvVW_Proveedor = New System.Windows.Forms.DataGridView()
        Me.PnConteinerProveedor.SuspendLayout()
        Me.PnCelularProveedor.SuspendLayout()
        Me.PnCorreoProveedor.SuspendLayout()
        Me.PnNombreProveedor.SuspendLayout()
        CType(Me.DgvVW_Proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCrearNuevoProveedor
        '
        Me.BtnCrearNuevoProveedor.FlatAppearance.BorderSize = 0
        Me.BtnCrearNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearNuevoProveedor.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearNuevoProveedor.Location = New System.Drawing.Point(58, 107)
        Me.BtnCrearNuevoProveedor.Name = "BtnCrearNuevoProveedor"
        Me.BtnCrearNuevoProveedor.Size = New System.Drawing.Size(239, 64)
        Me.BtnCrearNuevoProveedor.TabIndex = 2
        Me.BtnCrearNuevoProveedor.Text = "CREAR NUEVO PROVEEDOR"
        Me.BtnCrearNuevoProveedor.UseVisualStyleBackColor = True
        '
        'LbTituloForm
        '
        Me.LbTituloForm.AutoSize = True
        Me.LbTituloForm.Font = New System.Drawing.Font("Baloo", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTituloForm.Location = New System.Drawing.Point(12, 9)
        Me.LbTituloForm.Name = "LbTituloForm"
        Me.LbTituloForm.Size = New System.Drawing.Size(722, 75)
        Me.LbTituloForm.TabIndex = 3
        Me.LbTituloForm.Text = "PROVEEDORES DE PRODUCTOS"
        '
        'BtnCambiarProveedor
        '
        Me.BtnCambiarProveedor.FlatAppearance.BorderSize = 0
        Me.BtnCambiarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCambiarProveedor.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambiarProveedor.Location = New System.Drawing.Point(58, 198)
        Me.BtnCambiarProveedor.Name = "BtnCambiarProveedor"
        Me.BtnCambiarProveedor.Size = New System.Drawing.Size(239, 64)
        Me.BtnCambiarProveedor.TabIndex = 2
        Me.BtnCambiarProveedor.Text = "CAMBIAR NUEVO PROVEEDOR"
        Me.BtnCambiarProveedor.UseVisualStyleBackColor = True
        '
        'BtnEliminarProveedor
        '
        Me.BtnEliminarProveedor.FlatAppearance.BorderSize = 0
        Me.BtnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarProveedor.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarProveedor.Location = New System.Drawing.Point(58, 294)
        Me.BtnEliminarProveedor.Name = "BtnEliminarProveedor"
        Me.BtnEliminarProveedor.Size = New System.Drawing.Size(239, 64)
        Me.BtnEliminarProveedor.TabIndex = 2
        Me.BtnEliminarProveedor.Text = "ELIMINAR NUEVO PROVEEDOR"
        Me.BtnEliminarProveedor.UseVisualStyleBackColor = True
        '
        'PnConteinerProveedor
        '
        Me.PnConteinerProveedor.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PnConteinerProveedor.Controls.Add(Me.LbSubTituloPanel)
        Me.PnConteinerProveedor.Controls.Add(Me.BtnGuardar)
        Me.PnConteinerProveedor.Controls.Add(Me.PnCelularProveedor)
        Me.PnConteinerProveedor.Controls.Add(Me.PnCorreoProveedor)
        Me.PnConteinerProveedor.Controls.Add(Me.PnNombreProveedor)
        Me.PnConteinerProveedor.Location = New System.Drawing.Point(331, 87)
        Me.PnConteinerProveedor.Name = "PnConteinerProveedor"
        Me.PnConteinerProveedor.Size = New System.Drawing.Size(526, 271)
        Me.PnConteinerProveedor.TabIndex = 4
        '
        'LbSubTituloPanel
        '
        Me.LbSubTituloPanel.AutoSize = True
        Me.LbSubTituloPanel.Font = New System.Drawing.Font("HP Simplified Hans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSubTituloPanel.Location = New System.Drawing.Point(16, 7)
        Me.LbSubTituloPanel.Name = "LbSubTituloPanel"
        Me.LbSubTituloPanel.Size = New System.Drawing.Size(71, 22)
        Me.LbSubTituloPanel.TabIndex = 6
        Me.LbSubTituloPanel.Text = "Label1"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(403, 167)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(102, 90)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'PnCelularProveedor
        '
        Me.PnCelularProveedor.BackColor = System.Drawing.Color.White
        Me.PnCelularProveedor.Controls.Add(Me.TbCelularProveedor)
        Me.PnCelularProveedor.Location = New System.Drawing.Point(13, 167)
        Me.PnCelularProveedor.Name = "PnCelularProveedor"
        Me.PnCelularProveedor.Size = New System.Drawing.Size(347, 50)
        Me.PnCelularProveedor.TabIndex = 2
        '
        'TbCelularProveedor
        '
        Me.TbCelularProveedor.BackColor = System.Drawing.Color.White
        Me.TbCelularProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbCelularProveedor.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCelularProveedor.Location = New System.Drawing.Point(19, 11)
        Me.TbCelularProveedor.Name = "TbCelularProveedor"
        Me.TbCelularProveedor.Size = New System.Drawing.Size(313, 31)
        Me.TbCelularProveedor.TabIndex = 0
        Me.TbCelularProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnCorreoProveedor
        '
        Me.PnCorreoProveedor.BackColor = System.Drawing.Color.White
        Me.PnCorreoProveedor.Controls.Add(Me.TbCorreoProveedor)
        Me.PnCorreoProveedor.Location = New System.Drawing.Point(13, 97)
        Me.PnCorreoProveedor.Name = "PnCorreoProveedor"
        Me.PnCorreoProveedor.Size = New System.Drawing.Size(492, 50)
        Me.PnCorreoProveedor.TabIndex = 2
        '
        'TbCorreoProveedor
        '
        Me.TbCorreoProveedor.BackColor = System.Drawing.Color.White
        Me.TbCorreoProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbCorreoProveedor.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCorreoProveedor.Location = New System.Drawing.Point(19, 11)
        Me.TbCorreoProveedor.Name = "TbCorreoProveedor"
        Me.TbCorreoProveedor.Size = New System.Drawing.Size(458, 31)
        Me.TbCorreoProveedor.TabIndex = 0
        Me.TbCorreoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnNombreProveedor
        '
        Me.PnNombreProveedor.BackColor = System.Drawing.Color.White
        Me.PnNombreProveedor.Controls.Add(Me.TbNombreProveedor)
        Me.PnNombreProveedor.Location = New System.Drawing.Point(13, 34)
        Me.PnNombreProveedor.Name = "PnNombreProveedor"
        Me.PnNombreProveedor.Size = New System.Drawing.Size(492, 50)
        Me.PnNombreProveedor.TabIndex = 2
        '
        'TbNombreProveedor
        '
        Me.TbNombreProveedor.BackColor = System.Drawing.Color.White
        Me.TbNombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbNombreProveedor.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNombreProveedor.Location = New System.Drawing.Point(19, 11)
        Me.TbNombreProveedor.Name = "TbNombreProveedor"
        Me.TbNombreProveedor.Size = New System.Drawing.Size(458, 31)
        Me.TbNombreProveedor.TabIndex = 0
        Me.TbNombreProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DgvVW_Proveedor
        '
        Me.DgvVW_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVW_Proveedor.Location = New System.Drawing.Point(79, 397)
        Me.DgvVW_Proveedor.Name = "DgvVW_Proveedor"
        Me.DgvVW_Proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVW_Proveedor.Size = New System.Drawing.Size(757, 206)
        Me.DgvVW_Proveedor.TabIndex = 5
        '
        'FrmProveedoresProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 640)
        Me.Controls.Add(Me.DgvVW_Proveedor)
        Me.Controls.Add(Me.PnConteinerProveedor)
        Me.Controls.Add(Me.LbTituloForm)
        Me.Controls.Add(Me.BtnEliminarProveedor)
        Me.Controls.Add(Me.BtnCambiarProveedor)
        Me.Controls.Add(Me.BtnCrearNuevoProveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(420, 80)
        Me.Name = "FrmProveedoresProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmProveedoresProductos"
        Me.PnConteinerProveedor.ResumeLayout(False)
        Me.PnConteinerProveedor.PerformLayout()
        Me.PnCelularProveedor.ResumeLayout(False)
        Me.PnCelularProveedor.PerformLayout()
        Me.PnCorreoProveedor.ResumeLayout(False)
        Me.PnCorreoProveedor.PerformLayout()
        Me.PnNombreProveedor.ResumeLayout(False)
        Me.PnNombreProveedor.PerformLayout()
        CType(Me.DgvVW_Proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCrearNuevoProveedor As Button
    Friend WithEvents LbTituloForm As Label
    Friend WithEvents BtnCambiarProveedor As Button
    Friend WithEvents BtnEliminarProveedor As Button
    Friend WithEvents PnConteinerProveedor As Panel
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents PnNombreProveedor As Panel
    Friend WithEvents TbNombreProveedor As TextBox
    Friend WithEvents PnCorreoProveedor As Panel
    Friend WithEvents TbCorreoProveedor As TextBox
    Friend WithEvents PnCelularProveedor As Panel
    Friend WithEvents TbCelularProveedor As TextBox
    Friend WithEvents DgvVW_Proveedor As DataGridView
    Friend WithEvents LbSubTituloPanel As Label
End Class
