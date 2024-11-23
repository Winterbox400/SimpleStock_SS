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


    ' Propiedad pública para acceder a la conexión
    Public ReadOnly Property Conexion As SqlConnection
        Get
            Return connection
        End Get
    End Property

















    ' Método para insertar clientes en la base de datos
    Public Sub InsertarProductos(nombre As String, categoria As String, proveedor As String)
        Try
            ' Abrimos la conexión
            OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; INSERT INTO Productos (Nombre, Categoria, Proveedor) VALUES (@Nombre, @Categoria, @Proveedor)"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlCommand(query, connection)
                ' Agregamos los parámetros
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Categoria", categoria)
                command.Parameters.AddWithValue("@Proveedor", proveedor)

                ' Ejecutamos la consulta
                command.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            ' Mostramos el error en un cuadro de diálogo
            MessageBox.Show("Error al insertar cliente: " & ex.Message)
        Finally
            ' Cerramos la conexión
            CloseConnection()
        End Try
    End Sub


    'Encapsulación de codigo para ver su funcionamiento
    'Metodo para Agregar valores a un ComboBox
    Public Sub PruebaComboBox(Marcas As ComboBox)
        Try
            'Abrimos la conexión
            OpenConnection()

            'Definimos la Consulta TSQL
            Dim query As String = "SELECT * FROM Marcas"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlDataAdapter(query, connection)

                ' Creamos un DataSet como Contenedor de valores
                Dim data As New DataSet

                ' Rellenamos el DataSet con la consulta
                command.Fill(data)

                ' Mandamos a agregar los datos al ComboBox asignado
                Marcas.DataSource = data.Tables(0) 'Asigna de donde va a venir la información
                Marcas.DisplayMember = "Nombre" 'Asigna el valor que se mostrará en el ComboBox
                Marcas.ValueMember = "IdMarca" 'Guarda el Id del Valor seleccionado en el ComboBox
            End Using

        Catch ex As SqlException
            ' Mostramos el error en un cuadro de diálogo
            MessageBox.Show("Error al Cargar ComboBox: " & ex.Message)
        Finally
            ' Cerramos la conexión
            CloseConnection()
        End Try

    End Sub

    'Prueba para insertar valores con una tabla de datos Foranos con ComboBox
    Public Sub InsertarArticulos(nombre As String, IdMarca As Integer)
        Try
            ' Abrimos la conexión
            OpenConnection()

            ' Definimos la consulta TSQL con parámetros
            Dim query As String = "SET NOCOUNT ON; INSERT INTO Articulos (Nombre, IdMarca) VALUES (@Nombre, @IdMarca)"

            ' Creamos el comando con la consulta y la conexión
            Using command As New SqlCommand(query, connection)
                ' Agregamos los parámetros
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@IdMarca", IdMarca)

                ' Ejecutamos la consulta
                command.ExecuteNonQuery()
                CloseConnection()
            End Using
        Catch ex As SqlException
            ' Mostramos el error en un cuadro de diálogo
            MessageBox.Show("Error al Insertar un Articulo: " & ex.Message)

        Finally
            ' Cerramos la conexión
            CloseConnection()
        End Try

    End Sub

End Class
