Imports System.Data.SqlClient

Public Class DAOCategoriaProducto

    Private Conn As New DBConnection()

    ' Método para insertar Categoria en la base de datos
    Public Sub InsertarCategoria(nombre As String, descripcion As String, activo As Byte, idUsuarioRegistro As Integer)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; INSERT INTO Categorias(Nombre, Descripcion, Activo, IdUsuarioRegistro, FechaRegistro)
	                                                VALUES	(@nombre, @descripcion, @activo, @idUsuarioRegistro, GETDATE())"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlCommand(query, Conn.Conexion)
                ' Agregamos los parámetros
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@descripcion", descripcion)
                command.Parameters.AddWithValue("@activo", activo)
                command.Parameters.AddWithValue("@idUsuarioRegistro", idUsuarioRegistro)

                ' Ejecutamos la consulta
                command.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            ' Mostramos el error en un cuadro de diálogo
            MessageBox.Show("Error al insertar Categoria: " & ex.Message)
        Finally
            ' Cerramos la conexión
            Conn.CloseConnection()
        End Try
    End Sub


    ' Metodo para Actualizar Categoria en la Base de datos
    Public Sub ActualizarCategoria(nombre As String, descripcion As String, idUsuarioActualiza As Integer, idCategoria As Integer)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; UPDATE Categorias SET Nombre = @nombre, Descripcion = @descripcion,
		                           IdUsuarioActualiza = @idUsuarioActualiza, FechaActualizacion = GETDATE() WHERE IdCategoria = @idCategoria"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlCommand(query, Conn.Conexion)
                ' Agregamos los parámetros
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@descripcion", descripcion)
                command.Parameters.AddWithValue("@idUsuarioActualiza", idUsuarioActualiza)
                command.Parameters.AddWithValue("@idCategoria", idCategoria)

                ' Ejecutamos la consulta
                command.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            ' Mostramos el error en un cuadro de diálogo
            MessageBox.Show("Error al Actualizar Categoria: " & ex.Message)
        Finally
            ' Cerramos la conexión
            Conn.CloseConnection()
        End Try
    End Sub

    ' Metodo para Eliminar Categoria en la Base de datos
    Public Sub EliminarCategoria(activo As Byte, idCategoria As Integer)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; UPDATE Categorias SET Activo = @activo WHERE IdCategoria = @idCategoria"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlCommand(query, Conn.Conexion)
                ' Agregamos los parámetros
                command.Parameters.AddWithValue("@activo", activo)
                command.Parameters.AddWithValue("@idCategoria", idCategoria)

                ' Ejecutamos la consulta
                command.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            ' Mostramos el error en un cuadro de diálogo
            MessageBox.Show("Error al eliminar Categoria: " & ex.Message)
        Finally
            ' Cerramos la conexión
            Conn.CloseConnection()
        End Try
    End Sub

    ' Metodo para llenar DataGridView con una Vista de Marcas desde la Base de Datos
    Public Sub LlenarGrid(dataGridView As DataGridView)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            Dim query As String = "SELECT * FROM vw_Categorias"

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
