Imports System.Data


public class GES_ESTANDARACCESONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GES_ESTANDARACCESO as GES_ESTANDARACCESOENT)
       Try
           Dim GES_ESTANDARACCESODatos as new GES_ESTANDARACCESODAT
           GES_ESTANDARACCESODatos.insertar(GES_ESTANDARACCESO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GES_ESTANDARACCESO as GES_ESTANDARACCESOENT)
       Try
           Dim GES_ESTANDARACCESODatos as new GES_ESTANDARACCESODAT
           GES_ESTANDARACCESODatos.actualizar(GES_ESTANDARACCESO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GES_ESTANDARACCESO as GES_ESTANDARACCESOENT)
       Try
           Dim GES_ESTANDARACCESODatos as new GES_ESTANDARACCESODAT
           GES_ESTANDARACCESODatos.eliminar(GES_ESTANDARACCESO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GES_ESTANDARACCESOENT()
       Try
           Dim GES_ESTANDARACCESODatos as new GES_ESTANDARACCESODAT
           return GES_ESTANDARACCESODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Function

    Public Function ObtenerPerfilUsuario(ByVal NOMBRE_USUARIO As String) As GES_ESTANDARACCESOENT
        Try
            Dim GES_ESTANDARACCESODatos As New GES_ESTANDARACCESODAT
            Return GES_ESTANDARACCESODatos.ObtenerPerfilUsuario(NOMBRE_USUARIO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CargarListadoInformaticosEncuesta(ByVal encuesta As Integer) As String()
        Try
            Dim GES_ESTANDARACCESODATDatos As New GES_ESTANDARACCESODAT
            Return GES_ESTANDARACCESODATDatos.CargarListaInformaticosEncuesta(encuesta)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function Verificar(ByVal user As String, ByVal encuesta As Integer, ByVal tipo As Integer) As Boolean

        Try
            Dim GES_ESTANDARACCESODatos As New GES_ESTANDARACCESODAT
            Return GES_ESTANDARACCESODatos.Verificar(user, encuesta, tipo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#END REGION
end class
