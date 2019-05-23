Imports System.Data


public class GES_USUARIODAT

#REGION "METODO INGRESO"

    Public Sub Insertar(ByVal GES_USUARIO As GES_USUARIOENT)
        Try
            Dim sp As New StoredProcedure_class("SP_GES_USUARIO_Insertar")
            sp.AgregarParametro("NOMBRE_USUARIO", GES_USUARIO.NOMBRE_USUARIO)
            sp.AgregarParametro("DV_USUARIO", GES_USUARIO.DV_USUARIO)
            sp.AgregarParametro("PASSWORD", GES_USUARIO.PASSWORD)
            sp.AgregarParametro("NOMBRE", GES_USUARIO.NOMBRE)
            sp.AgregarParametro("APELLIDO", GES_USUARIO.APELLIDO)
            sp.AgregarParametro("ESTADO_INICIO", GES_USUARIO.ESTADO_INICIO)
            sp.AgregarParametro("EMAIL", GES_USUARIO.EMAIL)
            sp.AgregarParametro("RUT", GES_USUARIO.RUT)
            sp.AgregarParametro("DV_RUT", GES_USUARIO.DV_RUT)
            sp.AgregarParametro("TELEFONO", GES_USUARIO.TELEFONO)
            sp.AgregarParametro("CAMBIO_CLAVE", GES_USUARIO.CAMBIO_CLAVE)
            sp.AgregarParametro("ESTADO_USUARIO", GES_USUARIO.ESTADO_USUARIO)
            sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GES_USUARIO as GES_USUARIOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_USUARIO_Actualizar")
           sp.AgregarParametro("NOMBRE_USUARIO",GES_USUARIO.NOMBRE_USUARIO)
           sp.AgregarParametro("DV_USUARIO",GES_USUARIO.DV_USUARIO)
           sp.AgregarParametro("NOMBRE",GES_USUARIO.NOMBRE)
           sp.AgregarParametro("APELLIDO",GES_USUARIO.APELLIDO)
           sp.AgregarParametro("ESTADO_INICIO",GES_USUARIO.ESTADO_INICIO)
           sp.AgregarParametro("EMAIL",GES_USUARIO.EMAIL)
           sp.AgregarParametro("RUT",GES_USUARIO.RUT)
           sp.AgregarParametro("DV_RUT",GES_USUARIO.DV_RUT)
           sp.AgregarParametro("TELEFONO",GES_USUARIO.TELEFONO)
           sp.AgregarParametro("CAMBIO_CLAVE",GES_USUARIO.CAMBIO_CLAVE)
           sp.AgregarParametro("ESTADO_USUARIO",GES_USUARIO.ESTADO_USUARIO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Sub

    Public Sub ActualizarClave(ByVal GES_USUARIO As GES_USUARIOENT)
        Try
            Dim sp As New StoredProcedure_class("SP_GES_USUARIO_ActualizarClave")
            sp.AgregarParametro("NOMBRE_USUARIO", GES_USUARIO.NOMBRE_USUARIO)
            sp.AgregarParametro("DV_USUARIO", GES_USUARIO.DV_USUARIO)
            sp.AgregarParametro("NOMBRE", GES_USUARIO.NOMBRE)
            sp.AgregarParametro("APELLIDO", GES_USUARIO.APELLIDO)
            sp.AgregarParametro("ESTADO_INICIO", GES_USUARIO.ESTADO_INICIO)
            sp.AgregarParametro("EMAIL", GES_USUARIO.EMAIL)
            sp.AgregarParametro("RUT", GES_USUARIO.RUT)
            sp.AgregarParametro("DV_RUT", GES_USUARIO.DV_RUT)
            sp.AgregarParametro("TELEFONO", GES_USUARIO.TELEFONO)
            sp.AgregarParametro("CAMBIO_CLAVE", GES_USUARIO.CAMBIO_CLAVE)
            sp.AgregarParametro("PASSWORD", GES_USUARIO.PASSWORD)
            sp.AgregarParametro("ESTADO_USUARIO", GES_USUARIO.ESTADO_USUARIO)
            sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub LogActualizarUsuario(ByVal GES_USUARIO As GES_USUARIOENT, ByVal USUARIOCONECTADO As String)
        Try
            Dim sp As New StoredProcedure_class("SP_LOG_USUARIO_Actualizar")
            sp.AgregarParametro("NOMBRE_USUARIO", GES_USUARIO.NOMBRE_USUARIO)
            sp.AgregarParametro("DV_USUARIO", GES_USUARIO.DV_USUARIO)
            sp.AgregarParametro("NOMBRE", GES_USUARIO.NOMBRE)
            sp.AgregarParametro("APELLIDO", GES_USUARIO.APELLIDO)
            sp.AgregarParametro("ESTADO_INICIO", GES_USUARIO.ESTADO_INICIO)
            sp.AgregarParametro("EMAIL", GES_USUARIO.EMAIL)
            sp.AgregarParametro("RUT", GES_USUARIO.RUT)
            sp.AgregarParametro("DV_RUT", GES_USUARIO.DV_RUT)
            sp.AgregarParametro("TELEFONO", GES_USUARIO.TELEFONO)
            sp.AgregarParametro("CAMBIO_CLAVE", GES_USUARIO.CAMBIO_CLAVE)
            sp.AgregarParametro("ESTADO_USUARIO", GES_USUARIO.ESTADO_USUARIO)
            sp.AgregarParametro("USUARIO_ACTUALIZACION", USUARIOCONECTADO)
            sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_USUARIO_Eliminar")
'Aqui deben definir los parametros necesarios
           sp.AgregarParametro("","")
'Fin de parametros necesarios
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

#END REGION
#REGION "METODO LISTAR"

   Public Function Listar() as GES_USUARIOENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GES_USUARIO_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GES_USUARIO(dt.Rows.count() - 1) as GES_USUARIOENT
           i = 0
           for each dr in dt.rows
                GES_USUARIO(i) = New GES_USUARIOENT()
                GES_USUARIO(i).ID_USUARIO = dr("ID_USUARIO")
                GES_USUARIO(i).NOMBRE_USUARIO = dr("NOMBRE_USUARIO")
                GES_USUARIO(i).DV_USUARIO = dr("DV_USUARIO")
                GES_USUARIO(i).PASSWORD = dr("PASSWORD")
                GES_USUARIO(i).NOMBRE = dr("NOMBRE")
                GES_USUARIO(i).APELLIDO = dr("APELLIDO")
                GES_USUARIO(i).ESTADO_INICIO = dr("ESTADO_INICIO")
                GES_USUARIO(i).EMAIL = dr("EMAIL")
                GES_USUARIO(i).RUT = dr("RUT")
                GES_USUARIO(i).DV_RUT = dr("DV_RUT")
                GES_USUARIO(i).TELEFONO = dr("TELEFONO")
                GES_USUARIO(i).CAMBIO_CLAVE = dr("CAMBIO_CLAVE")
                GES_USUARIO(i).ESTADO_USUARIO = dr("ESTADO_USUARIO")
                i = i + 1
           next
           return GES_USUARIO
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Function

    'Obtiene un solo usuario
    Public Function ObtenerUsuario(ByVal nombreUsuario As String) As GES_USUARIOENT
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_GES_USUARIO_CargarUsuario")
            sp.AgregarParametro("usuario", nombreUsuario)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim GES_USUARIO As New GES_USUARIOENT
            For Each dr In dt.Rows
                GES_USUARIO = New GES_USUARIOENT()
                GES_USUARIO.NOMBRE_USUARIO = dr("NOMBRE_USUARIO")
                GES_USUARIO.ID_USUARIO = dr("ID_USUARIO")
                GES_USUARIO.DV_USUARIO = dr("DV_USUARIO")
                GES_USUARIO.PASSWORD = dr("PASSWORD")
                GES_USUARIO.NOMBRE = dr("NOMBRE")
                GES_USUARIO.APELLIDO = dr("APELLIDO")
                GES_USUARIO.ESTADO_INICIO = dr("ESTADO_INICIO")
                GES_USUARIO.EMAIL = dr("EMAIL")
                GES_USUARIO.RUT = dr("RUT")
                GES_USUARIO.DV_RUT = dr("DV_RUT")
                GES_USUARIO.TELEFONO = dr("TELEFONO")
                GES_USUARIO.CAMBIO_CLAVE = dr("CAMBIO_CLAVE")
                GES_USUARIO.ESTADO_USUARIO = dr("ESTADO_USUARIO")
            Next
            Return GES_USUARIO
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ''Funcion que obtiene todos los usuarios del sistema con nombre parecido al que está en la variable nombre_usuario
    Public Function ListarUsuario(ByVal Nombre_Usuario As String) As GES_USUARIOENT()
        Try
            Dim dr As DataRow
            Dim dt As DataTable

            Dim i As Integer
            Dim sp As New StoredProcedure_class("SP_GES_USUARIO_ListarUsuario")
            sp.AgregarParametro("Nombre_usuario", Nombre_Usuario)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim GES_USUARIO(dt.Rows.Count() - 1) As GES_USUARIOENT
            i = 0
            For Each dr In dt.Rows
                GES_USUARIO(i) = New GES_USUARIOENT()
                GES_USUARIO(i).NOMBRE_USUARIO = dr("NOMBRE_USUARIO")
                i = i + 1
            Next
            Return GES_USUARIO
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerUsuarioRol(ByVal nombreUsuario As String) As GES_USUARIOENT
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_GES_USUARIO_CargarUsuarioRol")
            sp.AgregarParametro("usuario", nombreUsuario)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim GES_USUARIO As New GES_USUARIOENT
            For Each dr In dt.Rows
                GES_USUARIO = New GES_USUARIOENT()
                GES_USUARIO.NOMBRE_USUARIO = dr("NOMBRE_USUARIO")
                GES_USUARIO.ID_USUARIO = dr("ID_USUARIO")
                GES_USUARIO.DV_USUARIO = dr("DV_USUARIO")
                GES_USUARIO.PASSWORD = dr("PASSWORD")
                GES_USUARIO.NOMBRE = dr("NOMBRE")
                GES_USUARIO.APELLIDO = dr("APELLIDO")
                GES_USUARIO.ESTADO_INICIO = dr("ESTADO_INICIO")
                GES_USUARIO.EMAIL = dr("EMAIL")
                GES_USUARIO.RUT = dr("RUT")
                GES_USUARIO.DV_RUT = dr("DV_RUT")
                GES_USUARIO.TELEFONO = dr("TELEFONO")
                GES_USUARIO.CAMBIO_CLAVE = dr("CAMBIO_CLAVE")
                GES_USUARIO.ESTADO_USUARIO = dr("ESTADO_USUARIO")
            Next
            Return GES_USUARIO
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "INSERTAR LOG_ACCESO"
    Public Sub InsertarLogAcceso(ByVal usuario As String, ByVal navegador As String, ByVal ip As String)
        Try
            Dim sp As New StoredProcedure_class("SP_LOG_INICIO_SESSION_Insertar")
            sp.AgregarParametro("usuario", usuario)
            sp.AgregarParametro("navegador", navegador)
            sp.AgregarParametro("ip", ip)
            sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "USUARIO INICIADO"
    Public Function usuarioIniciado(ByVal nombre_usuario As String)
        Try
            Dim sp As New StoredProcedure_class("SP_LOG_INICIOSESSION_UsuarioIniciado")
            sp.AgregarParametro("Nombre_Usuario", nombre_usuario)
            Return sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "CONSULTAR USUARIO"
    ''Verificar si un usuario existe
    Public Function ConsultaUsuario(ByVal GES_USUARIO As GES_USUARIOENT) As DataSet
        Try
            Dim sp As New StoredProcedure_class("SP_GES_USUARIO_ConsultaUsuario")
            sp.AgregarParametro("Nombre_Usuario", GES_USUARIO.NOMBRE_USUARIO)
            Return sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region


#Region "LOG CAMBIO CLAVE"
    Public Sub LOG_CambioClaveInformante(ByVal PASS_ANTERIOR As String, ByVal ID_USUARIO As String, ByVal USUARIOACTUALIZACION As String)
        Try


            Dim sp As New StoredProcedure_class("SP_LOG_CambioClaveInformante")
            sp.AgregarParametro("PASS_ANTERIOR", PASS_ANTERIOR)
            sp.AgregarParametro("ID_USUARIO", ID_USUARIO)
            sp.AgregarParametro("USUARIOACTUALIZACION", USUARIOACTUALIZACION)
            sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


    End Sub
#End Region

#Region "CONSTRUCTORES DE LA CLASE"
    Public Sub New()

    End Sub
#End Region

End Class
