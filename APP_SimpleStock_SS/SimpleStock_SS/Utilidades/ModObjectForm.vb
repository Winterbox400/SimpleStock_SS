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

End Class
