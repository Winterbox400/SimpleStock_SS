<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatalogoProductos_Nuevo
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
        Me.PnConteinerProductos = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PnDescripcionProductos = New System.Windows.Forms.Panel()
        Me.TbDescripcionProductos = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PnNombreProductos = New System.Windows.Forms.Panel()
        Me.TbNombreProductos = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PnConteinerProductos.SuspendLayout()
        Me.PnDescripcionProductos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PnNombreProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnConteinerProductos
        '
        Me.PnConteinerProductos.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PnConteinerProductos.Controls.Add(Me.ComboBox2)
        Me.PnConteinerProductos.Controls.Add(Me.ComboBox1)
        Me.PnConteinerProductos.Controls.Add(Me.Panel3)
        Me.PnConteinerProductos.Controls.Add(Me.PnDescripcionProductos)
        Me.PnConteinerProductos.Controls.Add(Me.Panel2)
        Me.PnConteinerProductos.Controls.Add(Me.Panel1)
        Me.PnConteinerProductos.Controls.Add(Me.PnNombreProductos)
        Me.PnConteinerProductos.Location = New System.Drawing.Point(12, 28)
        Me.PnConteinerProductos.Name = "PnConteinerProductos"
        Me.PnConteinerProductos.Size = New System.Drawing.Size(891, 588)
        Me.PnConteinerProductos.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ComboBox1.Font = New System.Drawing.Font("HP Simplified Hans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(644, 85)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 32)
        Me.ComboBox1.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Location = New System.Drawing.Point(644, 180)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(220, 43)
        Me.Panel3.TabIndex = 8
        '
        'PnDescripcionProductos
        '
        Me.PnDescripcionProductos.BackColor = System.Drawing.Color.White
        Me.PnDescripcionProductos.Controls.Add(Me.TbDescripcionProductos)
        Me.PnDescripcionProductos.Location = New System.Drawing.Point(13, 371)
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
        Me.TbDescripcionProductos.Size = New System.Drawing.Size(458, 31)
        Me.TbDescripcionProductos.TabIndex = 0
        Me.TbDescripcionProductos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Location = New System.Drawing.Point(13, 257)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(591, 50)
        Me.Panel2.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(19, 11)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(558, 31)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(13, 169)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(591, 50)
        Me.Panel1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("HP Simplified Hans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(19, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(558, 31)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnNombreProductos
        '
        Me.PnNombreProductos.BackColor = System.Drawing.Color.White
        Me.PnNombreProductos.Controls.Add(Me.TbNombreProductos)
        Me.PnNombreProductos.Location = New System.Drawing.Point(13, 85)
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
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(707, 268)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'FrmCatalogoProductos_Nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 640)
        Me.Controls.Add(Me.PnConteinerProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(420, 80)
        Me.Name = "FrmCatalogoProductos_Nuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmCatalogoProductos_Nuevo"
        Me.PnConteinerProductos.ResumeLayout(False)
        Me.PnDescripcionProductos.ResumeLayout(False)
        Me.PnDescripcionProductos.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PnNombreProductos.ResumeLayout(False)
        Me.PnNombreProductos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnConteinerProductos As Panel
    Friend WithEvents PnDescripcionProductos As Panel
    Friend WithEvents TbDescripcionProductos As TextBox
    Friend WithEvents PnNombreProductos As Panel
    Friend WithEvents TbNombreProductos As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ComboBox2 As ComboBox
End Class
