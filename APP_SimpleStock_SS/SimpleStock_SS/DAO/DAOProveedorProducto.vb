﻿Imports System.Data.SqlClient

Public Class DAOProveedorProducto

    Private Conn As New DBConnection()

    Public Sub InsertarProveedor(nombre As String, telefono As String, correo As String, activo As Byte, idUsuarioRegistro As Integer)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; INSERT INTO Proveedores(Nombre, Telefono, Correo, Activo, IdUsuarioRegistro, FechaRegistro)
	                                               VALUES	(@nombre, @telefono, @correo, @activo, @idUsuarioRegistro, GETDATE())"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlCommand(query, Conn.Conexion)
                ' Agregamos los parámetros
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@telefono", telefono)
                command.Parameters.AddWithValue("@correo", correo)
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

    Public Sub ActualizarProveedor(nombre As String, telefono As String, correo As String, idUsuarioActualiza As Integer, idProveedor As Integer)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; UPDATE Proveedores SET Nombre = @nombre, Telefono = @telefono, Correo = @correo,
		                           IdUsuarioActualiza = @idUsuarioActualiza, FechaActualizacion = GETDATE() WHERE IdProveedor = @idProveedor"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlCommand(query, Conn.Conexion)
                ' Agregamos los parámetros
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@telefono", telefono)
                command.Parameters.AddWithValue("@correo", correo)
                command.Parameters.AddWithValue("@idUsuarioActualiza", idUsuarioActualiza)
                command.Parameters.AddWithValue("@idProveedor", idProveedor)

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

    Public Sub EliminarProveedor(activo As Byte, idProveedor As Integer)
        Try
            ' Abrimos la conexión
            Conn.OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; UPDATE Proveedores SET Activo = @activo WHERE IdProveedor = @idProveedor"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlCommand(query, Conn.Conexion)
                ' Agregamos los parámetros
                command.Parameters.AddWithValue("@activo", activo)
                command.Parameters.AddWithValue("@idProveedor", idProveedor)

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

            Dim query As String = "SELECT * FROM vw_Proveedores"

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
