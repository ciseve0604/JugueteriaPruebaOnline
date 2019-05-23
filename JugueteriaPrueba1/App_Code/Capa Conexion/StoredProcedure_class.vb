Imports System.Data.SqlClient
Imports System.Data
Public Class StoredProcedure_class
#Region " Variables "
    Private mNombreProcedimiento As String
    Private mParametros As Collection
    'Private fg As FuncionesGenerales = New FuncionesGenerales()
#End Region
#Region " Propiedades "

    Public Property Nombre() As String
        Get
            Return mNombreProcedimiento
        End Get
        Set(ByVal Value As String)
            mNombreProcedimiento = Value
        End Set
    End Property

    Public Property Parametros() As Collection
        Get
            Return mParametros
        End Get
        Set(ByVal Value As Collection)
            mParametros = Value
        End Set
    End Property

#End Region
#Region "Constructor "

    'Solo recibe el nombre del procedimiento e inicializa la colección.
    Public Sub New(ByVal nNombre As String)
        Try
            Nombre = nNombre
            Parametros = New Collection
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    'Constructor Vacio.
    Public Sub New()

    End Sub

#End Region
#Region " Propiedades y Funciones "

    'Agrega los parametros del procedimiento y su respectivo valor.
    Public Sub AgregarParametro(ByVal pVariable As String, ByVal pValor As Object)
        Try
            Dim iParametro As New StoredProcedureParameter_class("@" & pVariable, pValor)
            Me.Parametros.Add(iParametro)
        Catch ex As Exception
            'fg.errorSistema(0, "Ocurrio un error al momento de agregar el parametro: @" & pVariable & "=" & pValor & "<br/>" & ex.Message, "")
            'Throw New Exception(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Ejecución de Procedimineto de almacenado especificado en el constructor.
    ''' </summary>
    ''' <returns>Retorna DataSet con los datos del procedimineto</returns>
    ''' <remarks></remarks>
    Public Function EjecutarProcedimiento() As DataSet
        Dim Conn As New Conexion_class
        Dim sqlCmd As New SqlCommand(Me.Nombre, Conn.AbrirConeccion())
        Dim mParametro As StoredProcedureParameter_class

        Try

            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandTimeout = 4000


            'Agrega las variables al procedimiento almacenado
            For Each mParametro In Me.Parametros
                Dim pParam As New SqlParameter(mParametro.Variable, mParametro.GetTypeProperty)
                pParam.Direction = ParameterDirection.Input
                pParam.Value = mParametro.Valor
                sqlCmd.Parameters.Add(pParam)
            Next

            'SqlAdapter utiliza el SqlCommand para llenar el Dataset
            Dim sda As New SqlDataAdapter(sqlCmd)

            'Se llena el dataset
            Dim ds As New DataSet
            sda.Fill(ds)
            If ds.Tables.Count >= 1 Then
                For Each columna As DataColumn In ds.Tables(0).Columns
                    If columna.ColumnName = "RESPUESTAOK" Then
                        If ds.Tables(0).Rows(0)("RESPUESTAOK") = "" Then
                            Dim err As String
                            err = "Se llamó al procedimiento: " & Nombre & " con los parametros: "
                            For Each mParametro In Me.Parametros
                                Dim pParam As New SqlParameter(mParametro.Variable, mParametro.GetTypeProperty)
                                err &= "<br/>" & mParametro.Variable & " = " & mParametro.Valor
                                'pParam.Direction = ParameterDirection.Input
                                'pParam.Value = mParametro.Valor
                                sqlCmd.Parameters.Add(pParam)
                            Next
                            err &= "<br/>Base de Datos: " & Conn.SQLConn.ConnectionString
                            'Dim fg As FuncionesGenerales = New FuncionesGenerales()
                            'fg.errorSistema(0, err & _
                            '"<br/><br/>Al momento de ejecutar el procedimiento: " & sqlCmd.CommandText & _
                            '"<Br/><br/>Ocurrio en la linea: " & ds.Tables(0).Rows(0)("LINEA") & _
                            '" del SP, el mensaje de error es: " & ds.Tables(0).Rows(0)("RESPUESTAMAL"), "Clase de consulta")
                        End If
                    End If
                Next
            End If
            Conn.CerrarConeccion()
            Return ds
        Catch ex As Exception
            Dim err As String
            err = "Se llamó al procedimiento: " & Nombre & " con los parametros: "
            For Each mParametro In Me.Parametros
                Dim pParam As New SqlParameter(mParametro.Variable, mParametro.GetTypeProperty)
                err &= "<br/>" & mParametro.Variable & " = " & mParametro.Valor
                'pParam.Direction = ParameterDirection.Input
                'pParam.Value = mParametro.Valor
                sqlCmd.Parameters.Add(pParam)
            Next
            err &= "<br/>Base de Datos: " & Conn.SQLConn.ConnectionString
            'fg.errorSistema(0, "Ocurrio un error al momento de ejecutar un procedimiento:<br/>" & err & "<br/>" & ex.Message, "")
            'Throw New Exception(ex.Message)
        Catch ex As Data.SqlClient.SqlException
            Dim err As String
            err = "Se llamó al procedimiento: " & Nombre & " con los parametros: "
            For Each mParametro In Me.Parametros
                Dim pParam As New SqlParameter(mParametro.Variable, mParametro.GetTypeProperty)
                err &= "<br/>" & mParametro.Variable & " = " & mParametro.Valor
                'pParam.Direction = ParameterDirection.Input
                'pParam.Value = mParametro.Valor
                sqlCmd.Parameters.Add(pParam)
            Next
            err &= "<br/>Base de Datos: " & Conn.SQLConn.ConnectionString
            'fg.errorSistema(0, "Ocurrio un error al momento de ejecutar un procedimiento:<br/>" & err & "<br/>" & ex.Message, "")
            'Throw New Exception(ex.Message & "<br/>" & err)
        End Try
    End Function
    ''' <summary>
    ''' Ejectua un procedimiento de almacenado, en la base de datos especificada en la conexión.
    ''' </summary>
    ''' <param name="cadenaConexion">Nombre de la cadena de conexiónn especificada en el Web.Config, luegar donde se ejecutará el SP</param>
    ''' <returns>Retorna un DataSet con los datos retornados por el SP.</returns>
    ''' <remarks></remarks>
    Public Function EjecutarProcedimiento(ByVal cadenaConexion As String) As DataSet
        Dim Conn As New Conexion_class(cadenaConexion)
        Dim sqlCmd As New SqlCommand(Me.Nombre, Conn.AbrirConeccion())
        Dim mParametro As StoredProcedureParameter_class

        Try

            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandTimeout = 4000


            'Agrega las variables al procedimiento almacenado
            For Each mParametro In Me.Parametros
                Dim pParam As New SqlParameter(mParametro.Variable, mParametro.GetTypeProperty)
                pParam.Direction = ParameterDirection.Input
                pParam.Value = mParametro.Valor
                sqlCmd.Parameters.Add(pParam)
            Next

            'SqlAdapter utiliza el SqlCommand para llenar el Dataset
            Dim sda As New SqlDataAdapter(sqlCmd)

            'Se llena el dataset
            Dim ds As New DataSet
            sda.Fill(ds)
            If ds.Tables.Count >= 1 Then
                For Each columna As DataColumn In ds.Tables(0).Columns
                    If columna.ColumnName = "RESPUESTAOK" Then
                        If ds.Tables(0).Rows(0)("RESPUESTAOK") = "" Then
                            Dim err As String
                            err = "Se llamó al procedimiento: " & Nombre & " con los parametros: "
                            For Each mParametro In Me.Parametros
                                Dim pParam As New SqlParameter(mParametro.Variable, mParametro.GetTypeProperty)
                                err &= "<br/>" & mParametro.Variable & " = " & mParametro.Valor
                                'pParam.Direction = ParameterDirection.Input
                                'pParam.Value = mParametro.Valor
                                sqlCmd.Parameters.Add(pParam)
                            Next
                            err &= "<br/>Base de Datos: " & Conn.SQLConn.ConnectionString
                            'Dim fg As FuncionesGenerales = New FuncionesGenerales()
                            'fg.errorSistema(0, err & _
                            '"<br/><br/>Al momento de ejecutar el procedimiento: " & sqlCmd.CommandText & _
                            '"<Br/><br/>Ocurrio en la linea: " & ds.Tables(0).Rows(0)("LINEA") & _
                            '" del SP, el mensaje de error es: " & ds.Tables(0).Rows(0)("RESPUESTAMAL"), "Clase de consulta")
                        End If
                    End If
                Next
            End If
            Conn.CerrarConeccion()
            Return ds
        Catch ex As Exception
            Dim err As String
            err = "Se llamó al procedimiento: " & Nombre & " con los parametros: "
            For Each mParametro In Me.Parametros
                Dim pParam As New SqlParameter(mParametro.Variable, mParametro.GetTypeProperty)
                err &= "<br/>" & mParametro.Variable & " = " & mParametro.Valor
                'pParam.Direction = ParameterDirection.Input
                'pParam.Value = mParametro.Valor
                sqlCmd.Parameters.Add(pParam)
            Next
            err &= "<br/>Base de Datos: " & Conn.SQLConn.ConnectionString
            'fg.errorSistema(0, "Ocurrio un error al momento de ejecutar un procedimiento:<br/>" & err & "<br/>" & ex.Message, "")
            'Throw New Exception(ex.Message)
        Catch ex As Data.SqlClient.SqlException
            Dim err As String
            err = "Se llamó al procedimiento: " & Nombre & " con los parametros: "
            For Each mParametro In Me.Parametros
                Dim pParam As New SqlParameter(mParametro.Variable, mParametro.GetTypeProperty)
                err &= "<br/>" & mParametro.Variable & " = " & mParametro.Valor
                'pParam.Direction = ParameterDirection.Input
                'pParam.Value = mParametro.Valor
                sqlCmd.Parameters.Add(pParam)
            Next

            err &= "<br/>Base de Datos: " & Conn.SQLConn.ConnectionString
            'fg.errorSistema(0, "Ocurrio un error al momento de ejecutar un procedimiento:<br/>" & err & "<br/>" & ex.Message, "")
            'Throw New Exception(ex.Message & "<br/>" & err)
        End Try
    End Function
    ''' <summary>
    ''' Ejecuta el procedimiento de almacenado en la base de datos SIGE
    ''' </summary>
    ''' <param name="sqlCmd">Command SQL que contiene los datos del Procedimiento de almacenado.</param>
    ''' <returns>Retorna un DataSet con los datos consultados en el SP.</returns>
    ''' <remarks></remarks>
    Public Function EjecutarProcedimiento(ByVal sqlCmd As SqlCommand) As DataSet
        Dim mParametro As StoredProcedureParameter_class

        Try
            'Dim Conn As New Conexion_class
            'Dim sqlCmd As New SqlCommand(Me.Nombre, Conn.AbrirConeccion())
            'sqlCmd.CommandType = CommandType.StoredProcedure
            'sqlCmd.CommandTimeout = 4000


            'Agrega las variables al procedimiento almacenado
            For Each mParametro In Me.Parametros
                Dim pParam As New SqlParameter(mParametro.Variable, mParametro.GetTypeProperty)
                pParam.Direction = ParameterDirection.Input
                pParam.Value = mParametro.Valor
                sqlCmd.Parameters.Add(pParam)
            Next

            'SqlAdapter utiliza el SqlCommand para llenar el Dataset
            Dim sda As New SqlDataAdapter(sqlCmd)

            'Se llena el dataset
            Dim ds As New DataSet
            sda.Fill(ds)

            'Conn.CerrarConeccion()
            Return ds
        Catch ex As Exception
            Dim err As String
            err = "Se llamó al procedimiento: " & Nombre & " con los parametros: "
            For Each mParametro In Me.Parametros
                Dim pParam As New SqlParameter(mParametro.Variable, mParametro.GetTypeProperty)
                err &= "<br/>" & mParametro.Variable & " = " & mParametro.Valor
                'pParam.Direction = ParameterDirection.Input
                'pParam.Value = mParametro.Valor
                sqlCmd.Parameters.Add(pParam)
            Next

            err &= "<br/>Base de Datos: " & sqlCmd.Connection.ConnectionString
            'fg.errorSistema(0, "Ocurrio un error al momento de ejecutar un procedimiento:<br/>" & err & "<br/>" & ex.Message, "")
            'Throw New Exception(ex.Message)
        Catch ex As Data.SqlClient.SqlException
            Dim err As String
            err = "Se llamó al procedimiento: " & Nombre & " con los parametros: "
            For Each mParametro In Me.Parametros
                Dim pParam As New SqlParameter(mParametro.Variable, mParametro.GetTypeProperty)
                err &= "<br/>" & mParametro.Variable & " = " & mParametro.Valor
                'pParam.Direction = ParameterDirection.Input
                'pParam.Value = mParametro.Valor
                sqlCmd.Parameters.Add(pParam)
            Next

            err &= "<br/>Base de Datos: " & sqlCmd.Connection.ConnectionString
            'fg.errorSistema(0, "Ocurrio un error al momento de ejecutar un procedimiento:<br/>" & err & "<br/>" & ex.Message, "")
            'Throw New Exception(ex.Message & "<br/>" & err)
        End Try
    End Function
    ''' <summary>
    ''' Ejecutar Consultas a una Base de datos, se conecta a la base de datos SIGE
    ''' </summary>
    ''' <param name="consulta">Consulta completa que se realizará</param>
    ''' <returns>Retorna un DataSet, con el conjunto de datos obtenidos</returns>
    ''' <remarks></remarks>
    Public Function EjecutarConsulta(ByVal consulta As String) As DataSet
        Dim Conn As New Conexion_class '(cadenaconexion)
        Dim sqlCmd As New SqlCommand(Me.Nombre, Conn.AbrirConeccion())
        Try
            sqlCmd.CommandType = CommandType.Text
            sqlCmd.CommandTimeout = 4000
            sqlCmd.CommandText = consulta

            'SqlAdapter utiliza el SqlCommand para llenar el Dataset
            Dim sda As New SqlDataAdapter(sqlCmd)

            'Se llena el dataset
            Dim ds As New DataSet
            sda.Fill(ds)
            Conn.CerrarConeccion()
            Return ds
        Catch ex As Exception
            Dim err As String
            err = "Se llamó quizo ejcutar la consulta: " & consulta
            err &= "<br/>Base de Datos: " & sqlCmd.Connection.ConnectionString
            'fg.errorSistema(0, "Ocurrio un error al momento de ejecutar una consulta:<br/>" & err & "<br/>" & ex.Message, "")
            'Throw New Exception(ex.Message)
        Catch ex As Data.SqlClient.SqlException
            Dim err As String
            err = "Se llamó quizo ejcutar la consulta: " & consulta
            err &= "<br/>Base de Datos: " & sqlCmd.Connection.ConnectionString
            'fg.errorSistema(0, "Ocurrio un error al momento de ejecutar una consulta:<br/>" & err & "<br/>" & ex.Message, "")
            'Throw New Exception(ex.Message & "<br/>" & err)
        End Try
    End Function
    ''' <summary>
    ''' Ejecutar Consultas a una Base de datos
    ''' </summary>
    ''' <param name="consulta">Consulta completa que se realizará</param>
    ''' <param name="cadenaConexion">Nombre de la Cadena de conexión a Realizar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EjecutarConsulta(ByVal consulta As String, ByVal cadenaConexion As String) As DataSet
        Try
            Dim Conn As New Conexion_class(cadenaConexion) '(cadenaconexion)
            Dim sqlCmd As New SqlCommand(Me.Nombre, Conn.AbrirConeccion())
            sqlCmd.CommandType = CommandType.Text
            sqlCmd.CommandTimeout = 4000
            sqlCmd.CommandText = consulta

            'SqlAdapter utiliza el SqlCommand para llenar el Dataset
            Dim sda As New SqlDataAdapter(sqlCmd)

            'Se llena el dataset
            Dim ds As New DataSet
            sda.Fill(ds)
            Conn.CerrarConeccion()
            Return ds
        Catch ex As Exception
            Dim err As String
            err = "Se llamó quizo ejcutar la consulta: " & consulta
            err &= "<br/>Base de Datos: " & cadenaConexion
            'fg.errorSistema(0, "Ocurrio un error al momento de ejecutar una consulta:<br/>" & err & "<br/>" & ex.Message, "")
            'Throw New Exception(ex.Message)
        Catch ex As Data.SqlClient.SqlException
            Dim err As String
            err = "Se llamó quizo ejcutar la consulta: " & consulta
            err &= "<br/>Base de Datos: " & cadenaConexion
            'fg.errorSistema(0, "Ocurrio un error al momento de ejecutar una consulta:<br/>" & err & "<br/>" & ex.Message, "")
            'Throw New Exception(ex.Message & "<br/>" & err)
        End Try
    End Function
#End Region
End Class
