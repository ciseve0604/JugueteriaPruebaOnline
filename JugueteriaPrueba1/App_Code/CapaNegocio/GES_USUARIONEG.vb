Imports System.Data


public class GES_USUARIONEG

#REGION "METODOS DE LOGICA"

    Public Sub Insertar(ByVal GES_USUARIO As GES_USUARIOENT)
        Try
            Dim GES_USUARIODatos As New GES_USUARIODAT
            GES_USUARIODatos.Insertar(GES_USUARIO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

   Public Sub Actualizar(byval GES_USUARIO as GES_USUARIOENT)
       Try
           Dim GES_USUARIODatos as new GES_USUARIODAT
           GES_USUARIODatos.actualizar(GES_USUARIO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GES_USUARIO as GES_USUARIOENT)
       Try
           Dim GES_USUARIODatos as new GES_USUARIODAT
           GES_USUARIODatos.eliminar(GES_USUARIO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GES_USUARIOENT()
       Try
           Dim GES_USUARIODatos as new GES_USUARIODAT
           return GES_USUARIODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Function

    ''##########
    Public Function ListarUsuario(ByVal nombre_usuario As String) As GES_USUARIOENT()
        Try
            Dim GES_USUARIODatos As New GES_USUARIODAT
            Return GES_USUARIODatos.ListarUsuario(nombre_usuario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function obtenerUsuario(ByVal nombre_usuario As String) As GES_USUARIOENT
        Try
            Dim GES_USUARIODatos As New GES_USUARIODAT
            Return GES_USUARIODatos.ObtenerUsuario(nombre_usuario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub InsertarLogAcceso(ByVal usuario As String, ByVal navegador As String, ByVal ip As String)
        Try
            Dim GES_USUARIODatos As New GES_USUARIODAT
            GES_USUARIODatos.InsertarLogAcceso(usuario, navegador, ip)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function usuarioIniciado(ByVal nombre_usuario As String) As DataSet
        Try
            Dim GES_USUARIODatos As New GES_USUARIODAT
            Return GES_USUARIODatos.usuarioIniciado(nombre_usuario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub ActualizarClave(ByVal ges_usuario As GES_USUARIOENT)
        Try
            Dim ges_UsuarioDatos As New GES_USUARIODAT
            ges_UsuarioDatos.ActualizarClave(ges_usuario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function ConsultaUsuario(ByVal GES_USUARIO As GES_USUARIOENT) As DataSet
        Try
            Dim GES_USUARIODatos As New GES_USUARIODAT
            Return GES_USUARIODatos.ConsultaUsuario(GES_USUARIO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub ActualizaLogActualizarUsuario(ByVal GES_USUARIO As GES_USUARIOENT, ByVal USUARIOCONECTADO As String)
        Try
            Dim GES_USUARIODatos As New GES_USUARIODAT
            GES_USUARIODatos.LogActualizarUsuario(GES_USUARIO, USUARIOCONECTADO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function obtenerUsuarioRol(ByVal nombre_usuario As String) As GES_USUARIOENT
        Try
            Dim GES_USUARIODatos As New GES_USUARIODAT
            Return GES_USUARIODatos.ObtenerUsuarioRol(nombre_usuario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub LOG_CambioClaveInformante(ByVal PASS_ANTERIOR As String, ByVal ID_USUARIO As String, ByVal USUARIOACTUALIZACION As String)
        Try
            Dim GES_USUARIODatos As New GES_USUARIODAT
            GES_USUARIODatos.LOG_CambioClaveInformante(PASS_ANTERIOR, ID_USUARIO, USUARIOACTUALIZACION)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#END REGION
end class
