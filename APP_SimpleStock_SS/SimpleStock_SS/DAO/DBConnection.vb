'Importacion de Clases del Sistema
Imports System.Data.SqlClient 'Clase SQL

Public Class DBConnection

    Private connectionString As String 'Añadiremos la informacion de conexion con SqlServert
    Private Servidor As String = "WINTERBOX400\SQL2022"
    Private NombreDB As String = "BD_SimpleStock_SS"
    Private UserDB As String = "sa"
    Private PasswordDB As String = "1234"
    Private connection As SqlConnection 'Creamos la variable de tipo SqlConnetion para pasarle el string anterior

    ' Metodo Constructor que establece la cadena de conexión
    Public Sub New()
        connectionString ='Le pasamos los datos para la conexión
            "Data Source=" + Servidor +
            ";Initial Catalog=" + NombreDB +
            ";User ID=" + UserDB +
            ";Password=" + PasswordDB
        connection = New SqlConnection(connectionString)
    End Sub



    ' Método para abrir la conexión
    Public Function OpenConnection() As Boolean
        Try
            If connection.State = ConnectionState.Closed Then 'Evalua si el estado de la conexión esta cerrado
                connection.Open() 'Abre la conexión
            End If
            Return True
        Catch ex As Exception 'En caso de fallar ejecuta un mensaje de error
            MessageBox.Show("Error al abrir la conexión: " & ex.Message)
            Return False
        End Try
    End Function



    ' Método para cerrar la conexión
    Public Sub CloseConnection()
        If connection.State = ConnectionState.Open Then 'Evalua si el estado de la conexión esta abierto
            connection.Close() 'Cierra la conexión
        End If
    End Sub

    ' Método para ejecutar consultas de tipo SELECT
    Public Function ExecuteQuery(query As String) As DataTable
        Dim dataTable As New DataTable()
        Try
            If OpenConnection() Then
                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using
                End Using
                CloseConnection()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al ejecutar consulta: " & ex.Message)
        End Try
        Return dataTable
    End Function

    ' Método para ejecutar consultas de tipo INSERT, UPDATE, DELETE
    Public Function ExecuteNonQuery(query As String) As Integer
        Dim rowsAffected As Integer = 0
        Try
            If OpenConnection() Then
                Using command As New SqlCommand(query, connection)
                    rowsAffected = command.ExecuteNonQuery()
                End Using
                CloseConnection()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al ejecutar comando: " & ex.Message)
        End Try
        Return rowsAffected
    End Function

End Class
