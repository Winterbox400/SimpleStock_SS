Imports System.Data.SqlClient

Public Class DAOCatalogoProducto

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

    ' Metodo para actualizar un Producto del catalogo en la base de datos
    Public Sub ActualizarProducto(nombre As String, descripcion As String, almacen As String, ubicacion As String, idCategoria As Integer, idMarca As Integer, idProveedor As Integer, idUsuarioActualiza As Integer, idProducto As Integer)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; UPDATE Productos SET Nombre = @nombre, Descripcion = @descripcion, Almacen = @almacen, Ubicacion = @ubicacion,IdCategoria = @idCategoria,
            IdMarca = @idMarca, IdProveedore = @idProveedor, IdUsuarioActualiza = @idUsuarioActualiza, FechaActualizacion = GETDATE()
            WHERE IdProducto = @idProducto"

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
                command.Parameters.AddWithValue("@idUsuarioRegistro", idUsuarioActualiza)
                command.Parameters.AddWithValue("@idProducto", idProducto)


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

    ' Metodo para Eliminar Producto del catalogo en la Base de datos
    Public Sub EliminarProducto(activo As Byte, idProducto As Integer)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; UPDATE Productos SET Activo = @activo WHERE IdProducto = @idProducto"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlCommand(query, Conn.Conexion)
                ' Agregamos los parámetros
                command.Parameters.AddWithValue("@activo", activo)
                command.Parameters.AddWithValue("@idCategoria", idProducto)

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


End Class
