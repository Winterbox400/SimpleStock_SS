Imports System.Data.SqlClient

Public Class DAORegistroEntrada

    Private Conn As New DBConnection()

    'Metodo para Crear un Producto para el catalogo en la base de datos
    Public Sub InsertarProducto(nombre As String, descripcion As String, almacen As String, ubicacion As String, idCategoria As Integer, idMarca As Integer, idProveedor As Integer, activo As Byte, idUsuarioRegistro As Integer)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; INSERT INTO Productos(Nombre, Descripcion, Almacen, Ubicacion, IdCategoria, IdMarca, IdProveedore, Activo, IdUsuarioRegistro, FechaRegistro)
	        VALUES (@nombre, @descripcion, @almacen, @ubicacion, @idCategoria, @idMarca, @idProveedor, @activo, @idUsuarioRegistro, GETDATE())"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlCommand(query, Conn.Conexion)
                ' Agregamos los parámetros
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@descripcion", descripcion)
                command.Parameters.AddWithValue("@almacen", almacen)
                command.Parameters.AddWithValue("@ubicacion", ubicacion)
                command.Parameters.AddWithValue("@idCategoria", idCategoria)
                command.Parameters.AddWithValue("@idMarca", idMarca)
                command.Parameters.AddWithValue("@idProveedor", idProveedor)
                command.Parameters.AddWithValue("@activo", activo)
                command.Parameters.AddWithValue("@idUsuarioRegistro", idUsuarioRegistro)

                ' Ejecutamos la consulta
                command.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            ' Mostramos el error en un cuadro de diálogo
            MessageBox.Show("Error al insertar Proveedor: " & ex.Message)
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

            Dim query As String = "SELECT * FROM vw_RegistroEntrada"

            Dim adaptador As New SqlDataAdapter(query, Conn.Conexion) 'Adaptamos la consulta con la conexión
            Dim dataTable As New DataTable() 'Creamos un tabla de datos con la consulta

            adaptador.Fill(dataTable) 'Llenamos el dataTable con la consulta

            ' Asignar el DataTable como fuente de datos del DataGridView
            dataGridView.DataSource = dataTable

        Catch ex As Exception
            ' Manejar errores
            MessageBox.Show("Error al llenar el grid: " & ex.Message)
        Finally
            'Cerramos la conexión
            Conn.CloseConnection()
        End Try

    End Sub

    'Metodo para mostrar Valores en ComboBox
    Public Sub LlenarComboBox(Categoria As ComboBox)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la Consulta TSQL
            Dim query As String = "SELECT * FROM vCBoxTipoEntrada"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlDataAdapter(query, Conn.Conexion)

                ' Creamos un DataTable como contenedor de valores
                Dim data As New DataTable

                ' Rellenamos el DataTable con la consulta
                command.Fill(data)

                ' Crear un nuevo DataTable para incluir el valor personalizado
                Dim customData As New DataTable
                customData.Columns.Add("IdTipo", GetType(Integer)) ' Columna para el Id
                customData.Columns.Add("Tipo", GetType(String))       ' Columna para el Nombre

                ' Agregar el valor inicial manualmente
                customData.Rows.Add(DBNull.Value, "Tipo de Entrada") ' Valor inicial (sin Id)

                ' Agregar los valores traídos desde la base de datos
                For Each row As DataRow In data.Rows
                    customData.ImportRow(row)
                Next

                ' Asignar el nuevo DataTable al ComboBox
                Categoria.DataSource = customData
                Categoria.DisplayMember = "Tipo"  ' Lo que se muestra en el ComboBox
                Categoria.ValueMember = "IdTipo" ' El valor seleccionado
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
