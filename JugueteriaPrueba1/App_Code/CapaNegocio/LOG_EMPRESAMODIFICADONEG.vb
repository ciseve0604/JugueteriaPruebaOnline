Imports System.Data


public class LOG_EMPRESAMODIFICADONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval LOG_EMPRESAMODIFICADO as LOG_EMPRESAMODIFICADOENT)
       Try
           Dim LOG_EMPRESAMODIFICADODatos as new LOG_EMPRESAMODIFICADODAT
           LOG_EMPRESAMODIFICADODatos.insertar(LOG_EMPRESAMODIFICADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval LOG_EMPRESAMODIFICADO as LOG_EMPRESAMODIFICADOENT)
       Try
           Dim LOG_EMPRESAMODIFICADODatos as new LOG_EMPRESAMODIFICADODAT
           LOG_EMPRESAMODIFICADODatos.actualizar(LOG_EMPRESAMODIFICADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval LOG_EMPRESAMODIFICADO as LOG_EMPRESAMODIFICADOENT)
       Try
           Dim LOG_EMPRESAMODIFICADODatos as new LOG_EMPRESAMODIFICADODAT
           LOG_EMPRESAMODIFICADODatos.eliminar(LOG_EMPRESAMODIFICADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as LOG_EMPRESAMODIFICADOENT()
       Try
           Dim LOG_EMPRESAMODIFICADODatos as new LOG_EMPRESAMODIFICADODAT
           return LOG_EMPRESAMODIFICADODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#Region "OBTENER PARAMETROS"
    Public Function obtenerparametros(ByVal rut As Integer, ByVal encuesta As Integer) As DataTable
        Try
            Dim LOG_EMPRESAMODIFICADODatos As New LOG_EMPRESAMODIFICADODAT


            Return LOG_EMPRESAMODIFICADODatos.obtenerparametros(rut, encuesta)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
#End Region



#End Region
end class
