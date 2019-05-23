Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager
Public Class Conexion_class
#Region " Variables "

    Private mSqlConn As SqlConnection

#End Region
#Region " Propiedades "

    Public Property SQLConn() As SqlConnection
        Get
            Return mSqlConn
        End Get
        Set(ByVal Value As SqlConnection)
            mSqlConn = Value
        End Set
    End Property

#End Region
#Region "Constructor"

    Public Sub New()
        Try
            Dim StringConeccion As String
            StringConeccion = System.Configuration.ConfigurationManager.ConnectionStrings("soCnn_EMAT").ConnectionString
            SQLConn = New SqlConnection()
            SQLConn.ConnectionString = StringConeccion
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub New(ByVal cadenaConexion As String)
        Try
            Dim StringConeccion As String
            'StringConeccion = cadenaConexion
            StringConeccion = System.Configuration.ConfigurationManager.ConnectionStrings(cadenaConexion).ConnectionString
            SQLConn = New SqlConnection()
            SQLConn.ConnectionString = StringConeccion
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#End Region
#Region "Metodos"

    Public Function AbrirConeccion() As SqlConnection
        Try
            Me.SQLConn.Open()
        Catch ex As Exception
            Throw New Exception("Ocurrio un error al abrir una conexión: " & ex.Message)
        End Try
        Return Me.SQLConn
    End Function
    Public Sub CerrarConeccion()
        Try
            Me.SQLConn.Close()
        Catch ex As Exception
            Throw New Exception("Ocurrio un error al cerrar una conexión")
        End Try
        SqlConnection.ClearPool(Me.SQLConn)
    End Sub

#End Region
End Class
