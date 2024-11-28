'Esta clase se creo para almacenar metodos que modifiquen las propiedades de objetos creados con Window Form
Imports System.Drawing.Drawing2D

Public Class ModObjectForm

    ' Metodo para hacer que los extremos de un Button sean Semicirculares
    Public Shared Sub CrearBotonSemiCircular(boton As Button)
        Dim path As New GraphicsPath()
        ' Definir el tamaño y la forma (rectángulo con bordes semicirculares)
        Dim rect As New Rectangle(0, 0, boton.Width, boton.Height)
        Dim radius As Integer = boton.Height / 2 ' Radio para extremos semicirculares
        path.StartFigure()
        ' Extremo izquierdo semicircular
        path.AddArc(rect.X, rect.Y, radius * 2, rect.Height, 90, 180)
        ' Línea superior recta
        path.AddLine(rect.X + radius, rect.Y, rect.X + rect.Width - radius, rect.Y)
        ' Extremo derecho semicircular
        path.AddArc(rect.X + rect.Width - (radius * 2), rect.Y, radius * 2, rect.Height, 270, 180)
        ' Línea inferior recta
        path.AddLine(rect.X + rect.Width - radius, rect.Y + rect.Height, rect.X + radius, rect.Y + rect.Height)
        path.CloseFigure()

        ' Aplicar la forma al botón
        boton.Region = New Region(path)

    End Sub

    Public Shared Sub CrearBotonEsquinasSemiCirculares(boton As Button, cornerRadius As Integer)
        ' Crear un GraphicsPath para definir la forma
        Dim path As New GraphicsPath()

        ' Dimensiones del botón
        Dim rect As New Rectangle(0, 0, boton.Width, boton.Height)

        ' Construir la figura del botón con esquinas redondeadas
        path.StartFigure()
        ' Esquina superior izquierda
        path.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90)
        ' Línea superior recta
        path.AddLine(rect.X + cornerRadius, rect.Y, rect.X + rect.Width - cornerRadius, rect.Y)
        ' Esquina superior derecha
        path.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90)
        ' Línea derecha
        path.AddLine(rect.X + rect.Width, rect.Y + cornerRadius, rect.X + rect.Width, rect.Y + rect.Height - cornerRadius)
        ' Esquina inferior derecha
        path.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90)
        ' Línea inferior
        path.AddLine(rect.X + rect.Width - cornerRadius, rect.Y + rect.Height, rect.X + cornerRadius, rect.Y + rect.Height)
        ' Esquina inferior izquierda
        path.AddArc(rect.X, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90)
        ' Línea izquierda
        path.AddLine(rect.X, rect.Y + rect.Height - cornerRadius, rect.X, rect.Y + cornerRadius)
        path.CloseFigure()

        ' Aplicar la forma al botón
        boton.Region = New Region(path)
    End Sub


    ' Método para redondear las esquinas de un Panel
    Public Shared Sub CrearPanelEsquinasSemiCirculares(panel As Panel, cornerRadius As Integer)
        ' Crear un GraphicsPath para definir la forma
        Dim path As New GraphicsPath()

        ' Dimensiones del panel
        Dim rect As New Rectangle(0, 0, panel.Width, panel.Height)

        ' Construir la figura del panel con esquinas redondeadas
        path.StartFigure()
        ' Esquina superior izquierda
        path.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90)
        ' Línea superior recta
        path.AddLine(rect.X + cornerRadius, rect.Y, rect.X + rect.Width - cornerRadius, rect.Y)
        ' Esquina superior derecha
        path.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90)
        ' Línea derecha
        path.AddLine(rect.X + rect.Width, rect.Y + cornerRadius, rect.X + rect.Width, rect.Y + rect.Height - cornerRadius)
        ' Esquina inferior derecha
        path.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90)
        ' Línea inferior
        path.AddLine(rect.X + rect.Width - cornerRadius, rect.Y + rect.Height, rect.X + cornerRadius, rect.Y + rect.Height)
        ' Esquina inferior izquierda
        path.AddArc(rect.X, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90)
        ' Línea izquierda
        path.AddLine(rect.X, rect.Y + rect.Height - cornerRadius, rect.X, rect.Y + cornerRadius)
        path.CloseFigure()

        ' Aplicar la forma al panel
        panel.Region = New Region(path)
    End Sub

    Public Shared Sub PersonalizarDataGridView(dataGridView As DataGridView)
        'Evita que los usuarios puedan editar datos directamente
        dataGridView.ReadOnly = True
        'Hace que las columnas se ajusten automaticamente
        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'Oculta la columna vacia que aparece a la izquierda
        dataGridView.RowHeadersVisible = False
        'Elimina la Fila vacia que aparece abajo
        dataGridView.AllowUserToAddRows = False
        'Bloque poder agrandar las celdas verticalmente
        dataGridView.AllowUserToResizeRows = False

        ' Personalizar los encabezados de las columnas
        With dataGridView.ColumnHeadersDefaultCellStyle
            .BackColor = Color.FromArgb(12, 92, 168) '#0c5ca8 Color de fondo de los encabezados
            .ForeColor = Color.FromArgb(253, 249, 180) '#fdf9b4 Color del texto de los encabezados
            .Font = New Font(dataGridView.Font, FontStyle.Bold) ' Fuente de los encabezados
        End With

        ' Personalizar las celdas de los datos
        With dataGridView.DefaultCellStyle
            .BackColor = Color.FromArgb(247, 253, 232) ' Color de fondo de las celdas de datos
            .ForeColor = Color.Black ' Color del texto de las celdas de datos
            .SelectionBackColor = Color.FromArgb(255, 105, 135) ' Color de fondo de las celdas seleccionadas
            .SelectionForeColor = Color.White ' Color del texto de las celdas seleccionadas
        End With

        ' Aplicar bordes o cualquier otro estilo general
        dataGridView.GridColor = Color.Black ' Color de los bordes de la cuadrícula
        dataGridView.EnableHeadersVisualStyles = False ' Para que los estilos personalizados funcionen
    End Sub


    ' Modificar ComboBox
    ' Método para personalizar el diseño del ComboBox
    Public Shared Sub ConfigurarComboBox(comboBox As ComboBox)
        comboBox.DrawMode = DrawMode.OwnerDrawFixed ' Configurar el modo de dibujo personalizado
        AddHandler comboBox.DrawItem, AddressOf ComboBox_DrawItem
    End Sub

    ' Evento para dibujar los elementos personalizados del ComboBox
    Private Shared Sub ComboBox_DrawItem(sender As Object, e As DrawItemEventArgs)
        Dim combo As ComboBox = CType(sender, ComboBox)

        ' Verificar si hay elementos para dibujar
        If e.Index < 0 Then Return

        ' Dibujar el fondo personalizado
        e.Graphics.FillRectangle(New SolidBrush(Color.LightBlue), e.Bounds)

        ' Dibujar el texto del elemento
        Dim textColor As Color = If((e.State And DrawItemState.Selected) = DrawItemState.Selected, Color.White, Color.Black)
        TextRenderer.DrawText(e.Graphics, combo.Items(e.Index).ToString(), combo.Font, e.Bounds, textColor, TextFormatFlags.Left)

        ' Dibujar el rectángulo de enfoque
        e.DrawFocusRectangle()
    End Sub

End Class
