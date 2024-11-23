Imports System.Data.SqlClient

Public Class DAOMarcaProductos

    Private Conn As New DBConnection()

    ' Método para insertar clientes en la base de datos

    Public Sub InsertarMarca(nombre As String, descripcion As String, activo As Byte, idUsuarioRegistro As Integer)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; INSERT INTO Marcas(Nombre, Descripcion, Activo, IdUsuarioRegistro, FechaRegistro)
                                   VALUES (@Nombre, @Descripcion, @activo, @idUsuarioRegistro, GETDATE())"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlCommand(query, Conn.Conexion)
                ' Agregamos los parámetros
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Descripcion", descripcion)
                command.Parameters.AddWithValue("@activo", activo)
                command.Parameters.AddWithValue("@idUsuarioRegistro", idUsuarioRegistro)

                ' Ejecutamos la consulta
                command.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            ' Mostramos el error en un cuadro de diálogo
            MessageBox.Show("Error al insertar cliente: " & ex.Message)
        Finally
            ' Cerramos la conexión
            Conn.CloseConnection()
        End Try
    End Sub

    Public Sub ActualizarMarca(nombre As String, descripcion As String, idUsuarioActualiza As Integer, idMarca As Integer)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; UPDATE Marcas SET Nombre = @Nombre, Descripcion = @Descripcion,
	                               IdUsuarioActualiza = @idUsuarioActualiza, FechaActualizacion = GETDATE() WHERE IdMarca = @idMarca"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlCommand(query, Conn.Conexion)
                ' Agregamos los parámetros
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Descripcion", descripcion)
                command.Parameters.AddWithValue("@idUsuarioActualiza", idUsuarioActualiza)
                command.Parameters.AddWithValue("@idMarca", idMarca)

                ' Ejecutamos la consulta
                command.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            ' Mostramos el error en un cuadro de diálogo
            MessageBox.Show("Error al insertar cliente: " & ex.Message)
        Finally
            ' Cerramos la conexión
            Conn.CloseConnection()
        End Try
    End Sub

    Public Sub EliminarMarca(activo As Byte, idMarca As Integer)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; UPDATE Marcas SET Activo = @activo WHERE IdMarca = @idMarca"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlCommand(query, Conn.Conexion)
                ' Agregamos los parámetros
                command.Parameters.AddWithValue("@activo", activo)
                command.Parameters.AddWithValue("@idMarca", idMarca)

                ' Ejecutamos la consulta
                command.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            ' Mostramos el error en un cuadro de diálogo
            MessageBox.Show("Error al insertar cliente: " & ex.Message)
        Finally
            ' Cerramos la conexión
            Conn.CloseConnection()
        End Try
    End Sub

    Public Sub LlenarGrid(dataGridView As DataGridView)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            Dim query As String = "SELECT * FROM vw_Marcas"

            Dim adaptador As New SqlDataAdapter(query, Conn.Conexion) 'Adaptamos la consulta con la conexión
            Dim dataTable As New DataTable() 'Creamos un tabla de datos con la consulta

            adaptador.Fill(dataTable) 'Llenamos el dataTable con la consulta

            ' Asignar el DataTable como fuente de datos del DataGridView
            dataGridView.DataSource = dataTable

            ' Ocultar la columna "Codigo" (IdMarca)
            If dataGridView.Columns.Contains("Codigo") Then
                dataGridView.Columns("Codigo").Visible = False
            End If
        Catch ex As Exception
            ' Manejar errores
            MessageBox.Show("Error al llenar el grid: " & ex.Message)
        Finally
            'Cerramos la conexión
            Conn.CloseConnection()
        End Try

    End Sub

End Class
