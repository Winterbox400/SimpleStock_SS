Imports System.Data.SqlClient

Public Class DAOMarcaProductos

    Private Conn As New DBConnection()

    ' Método para insertar Marcas en la base de datos
    Public Sub InsertarMarca(nombre As String, descripcion As String, activo As Byte, idUsuarioRegistro As Integer)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; INSERT INTO Marcas(Nombre, Descripcion, Activo, IdUsuarioRegistro, FechaRegistro)
                                   VALUES (@nombre, @descripcion, @activo, @idUsuarioRegistro, GETDATE())"

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
            MessageBox.Show("Error al insertar Marca: " & ex.Message)
        Finally
            ' Cerramos la conexión
            Conn.CloseConnection()
        End Try
    End Sub

    ' Metodo para Actualizar Marcas en la Base de datos
    Public Sub ActualizarMarca(nombre As String, descripcion As String, idUsuarioActualiza As Integer, idMarca As Integer)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; UPDATE Marcas SET Nombre = @nombre, Descripcion = @descripcion,
	                               IdUsuarioActualiza = @idUsuarioActualiza, FechaActualizacion = GETDATE() WHERE IdMarca = @idMarca"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlCommand(query, Conn.Conexion)
                ' Agregamos los parámetros
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@descripcion", descripcion)
                command.Parameters.AddWithValue("@idUsuarioActualiza", idUsuarioActualiza)
                command.Parameters.AddWithValue("@idMarca", idMarca)

                ' Ejecutamos la consulta
                command.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            ' Mostramos el error en un cuadro de diálogo
            MessageBox.Show("Error al actualizar Marca: " & ex.Message)
        Finally
            ' Cerramos la conexión
            Conn.CloseConnection()
        End Try
    End Sub

    ' Metodo para Eliminar Marcas en la Base de datos
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
            MessageBox.Show("Error al eliminar Marca: " & ex.Message)
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

    'Metodo para mostrar Valores en ComboBox
    Public Sub LlenarComboBox(Marcas As ComboBox)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la Consulta TSQL
            Dim query As String = "SELECT * FROM vCBoxMarcas ORDER BY Nombre"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlDataAdapter(query, Conn.Conexion)

                ' Creamos un DataTable como contenedor de valores
                Dim data As New DataTable

                ' Rellenamos el DataTable con la consulta
                command.Fill(data)

                ' Crear un nuevo DataTable para incluir el valor personalizado
                Dim customData As New DataTable
                customData.Columns.Add("IdMarca", GetType(Integer)) ' Columna para el Id
                customData.Columns.Add("Nombre", GetType(String))       ' Columna para el Nombre

                ' Agregar el valor inicial manualmente
                customData.Rows.Add(DBNull.Value, "Marcas") ' Valor inicial (sin Id)

                ' Agregar los valores traídos desde la base de datos
                For Each row As DataRow In data.Rows
                    customData.ImportRow(row)
                Next

                ' Asignar el nuevo DataTable al ComboBox
                Marcas.DataSource = customData
                Marcas.DisplayMember = "Nombre"  ' Lo que se muestra en el ComboBox
                Marcas.ValueMember = "IdMarca" ' El valor seleccionado
            End Using

        Catch ex As SqlException
            ' Mostramos el error en un cuadro de diálogo
            MessageBox.Show("Error al cargar ComboBox: " & ex.Message)
        Finally
            ' Cerramos la conexión
            Conn.CloseConnection()
        End Try
    End Sub



End Class
