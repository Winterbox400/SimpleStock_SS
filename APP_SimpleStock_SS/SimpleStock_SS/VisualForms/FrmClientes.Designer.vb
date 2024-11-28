<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.LbTituloForm = New System.Windows.Forms.Label()
        Me.PnConteinerCliente = New System.Windows.Forms.Panel()
        Me.LbSubTituloPanel = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PnCelularCliente = New System.Windows.Forms.Panel()
        Me.TbCelularCliente = New System.Windows.Forms.TextBox()
        Me.PnCorreoCliente = New System.Windows.Forms.Panel()
        Me.TbCorreoCliente = New System.Windows.Forms.TextBox()
        Me.PnNombreCliente = New System.Windows.Forms.Panel()
        Me.TbNombreCliente = New System.Windows.Forms.TextBox()
        Me.BtnEliminarCliente = New System.Windows.Forms.Button()
        Me.BtnCambiarCliente = New System.Windows.Forms.Button()
        Me.BtnCrearNuevoCliente = New System.Windows.Forms.Button()
        Me.DgvVW_Cliente = New System.Windows.Forms.DataGridView()
        Me.PnConteinerCliente.SuspendLayout()
        Me.PnCelularCliente.SuspendLayout()
        Me.PnCorreoCliente.SuspendLayout()
        Me.PnNombreCliente.SuspendLayout()
        CType(Me.DgvVW_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbTituloForm
        '
        Me.LbTituloForm.AutoSize = True
        Me.LbTituloForm.Font = New System.Drawing.Font("Baloo", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTituloForm.Location = New System.Drawing.Point(12, 9)
        Me.LbTituloForm.Name = "LbTituloForm"
        Me.LbTituloForm.Size = New System.Drawing.Size(570, 75)
        Me.LbTituloForm.TabIndex = 4
        Me.LbTituloForm.Text = "CATALOGO DE CLIENTES"
        '
        'PnConteinerCliente
        '
        Me.PnConteinerCliente.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PnConteinerCliente.Controls.Add(Me.LbSubTituloPanel)
        Me.PnConteinerCliente.Controls.Add(Me.BtnGuardar)
        Me.PnConteinerCliente.Controls.Add(Me.PnCelularCliente)
        Me.PnConteinerCliente.Controls.Add(Me.PnCorreoCliente)
        Me.PnConteinerCliente.Controls.Add(Me.PnNombreCliente)
        Me.PnConteinerCliente.Location = New System.Drawing.Point(331, 87)
        Me.PnConteinerCliente.Name = "PnConteinerCliente"
        Me.PnConteinerCliente.Size = New System.Drawing.Size(526, 271)
        Me.PnConteinerCliente.TabIndex = 8
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
        'PnCelularCliente
        '
        Me.PnCelularCliente.BackColor = System.Drawing.Color.White
        Me.PnCelularCliente.Controls.Add(Me.TbCelularCliente)
        Me.PnCelularCliente.Location = New System.Drawing.Point(13, 167)
        Me.PnCelularCliente.Name = "PnCelularCliente"
        Me.PnCelularCliente.Size = New System.Drawing.Size(347, 50)
        Me.PnCelularCliente.TabIndex = 2
        '
        'TbCelularCliente
        '
        Me.TbCelularCliente.BackColor = System.Drawing.Color.White
        Me.TbCelularCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbCelularCliente.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCelularCliente.Location = New System.Drawing.Point(19, 11)
        Me.TbCelularCliente.Name = "TbCelularCliente"
        Me.TbCelularCliente.Size = New System.Drawing.Size(313, 31)
        Me.TbCelularCliente.TabIndex = 0
        Me.TbCelularCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnCorreoCliente
        '
        Me.PnCorreoCliente.BackColor = System.Drawing.Color.White
        Me.PnCorreoCliente.Controls.Add(Me.TbCorreoCliente)
        Me.PnCorreoCliente.Location = New System.Drawing.Point(13, 97)
        Me.PnCorreoCliente.Name = "PnCorreoCliente"
        Me.PnCorreoCliente.Size = New System.Drawing.Size(492, 50)
        Me.PnCorreoCliente.TabIndex = 2
        '
        'TbCorreoCliente
        '
        Me.TbCorreoCliente.BackColor = System.Drawing.Color.White
        Me.TbCorreoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbCorreoCliente.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCorreoCliente.Location = New System.Drawing.Point(19, 11)
        Me.TbCorreoCliente.Name = "TbCorreoCliente"
        Me.TbCorreoCliente.Size = New System.Drawing.Size(458, 31)
        Me.TbCorreoCliente.TabIndex = 0
        Me.TbCorreoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnNombreCliente
        '
        Me.PnNombreCliente.BackColor = System.Drawing.Color.White
        Me.PnNombreCliente.Controls.Add(Me.TbNombreCliente)
        Me.PnNombreCliente.Location = New System.Drawing.Point(13, 34)
        Me.PnNombreCliente.Name = "PnNombreCliente"
        Me.PnNombreCliente.Size = New System.Drawing.Size(492, 50)
        Me.PnNombreCliente.TabIndex = 2
        '
        'TbNombreCliente
        '
        Me.TbNombreCliente.BackColor = System.Drawing.Color.White
        Me.TbNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbNombreCliente.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNombreCliente.Location = New System.Drawing.Point(19, 11)
        Me.TbNombreCliente.Name = "TbNombreCliente"
        Me.TbNombreCliente.Size = New System.Drawing.Size(458, 31)
        Me.TbNombreCliente.TabIndex = 0
        Me.TbNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnEliminarCliente
        '
        Me.BtnEliminarCliente.FlatAppearance.BorderSize = 0
        Me.BtnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarCliente.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarCliente.Location = New System.Drawing.Point(58, 294)
        Me.BtnEliminarCliente.Name = "BtnEliminarCliente"
        Me.BtnEliminarCliente.Size = New System.Drawing.Size(239, 64)
        Me.BtnEliminarCliente.TabIndex = 5
        Me.BtnEliminarCliente.Text = "ELIMINAR NUEVO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CLIENTE"
        Me.BtnEliminarCliente.UseVisualStyleBackColor = True
        '
        'BtnCambiarCliente
        '
        Me.BtnCambiarCliente.FlatAppearance.BorderSize = 0
        Me.BtnCambiarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCambiarCliente.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambiarCliente.Location = New System.Drawing.Point(58, 198)
        Me.BtnCambiarCliente.Name = "BtnCambiarCliente"
        Me.BtnCambiarCliente.Size = New System.Drawing.Size(239, 64)
        Me.BtnCambiarCliente.TabIndex = 6
        Me.BtnCambiarCliente.Text = "CAMBIAR NUEVO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CLIENTE"
        Me.BtnCambiarCliente.UseVisualStyleBackColor = True
        '
        'BtnCrearNuevoCliente
        '
        Me.BtnCrearNuevoCliente.FlatAppearance.BorderSize = 0
        Me.BtnCrearNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearNuevoCliente.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearNuevoCliente.Location = New System.Drawing.Point(58, 107)
        Me.BtnCrearNuevoCliente.Name = "BtnCrearNuevoCliente"
        Me.BtnCrearNuevoCliente.Size = New System.Drawing.Size(239, 64)
        Me.BtnCrearNuevoCliente.TabIndex = 7
        Me.BtnCrearNuevoCliente.Text = "CREAR NUEVO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CLIENTE"
        Me.BtnCrearNuevoCliente.UseVisualStyleBackColor = True
        '
        'DgvVW_Cliente
        '
        Me.DgvVW_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVW_Cliente.Location = New System.Drawing.Point(79, 397)
        Me.DgvVW_Cliente.Name = "DgvVW_Cliente"
        Me.DgvVW_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVW_Cliente.Size = New System.Drawing.Size(757, 206)
        Me.DgvVW_Cliente.TabIndex = 9
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 640)
        Me.Controls.Add(Me.DgvVW_Cliente)
        Me.Controls.Add(Me.PnConteinerCliente)
        Me.Controls.Add(Me.BtnEliminarCliente)
        Me.Controls.Add(Me.BtnCambiarCliente)
        Me.Controls.Add(Me.BtnCrearNuevoCliente)
        Me.Controls.Add(Me.LbTituloForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(420, 80)
        Me.Name = "FrmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmClientes"
        Me.PnConteinerCliente.ResumeLayout(False)
        Me.PnConteinerCliente.PerformLayout()
        Me.PnCelularCliente.ResumeLayout(False)
        Me.PnCelularCliente.PerformLayout()
        Me.PnCorreoCliente.ResumeLayout(False)
        Me.PnCorreoCliente.PerformLayout()
        Me.PnNombreCliente.ResumeLayout(False)
        Me.PnNombreCliente.PerformLayout()
        CType(Me.DgvVW_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbTituloForm As Label
    Friend WithEvents PnConteinerCliente As Panel
    Friend WithEvents LbSubTituloPanel As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents PnCelularCliente As Panel
    Friend WithEvents TbCelularCliente As TextBox
    Friend WithEvents PnCorreoCliente As Panel
    Friend WithEvents TbCorreoCliente As TextBox
    Friend WithEvents PnNombreCliente As Panel
    Friend WithEvents TbNombreCliente As TextBox
    Friend WithEvents BtnEliminarCliente As Button
    Friend WithEvents BtnCambiarCliente As Button
    Friend WithEvents BtnCrearNuevoCliente As Button
    Friend WithEvents DgvVW_Cliente As DataGridView
End Class
