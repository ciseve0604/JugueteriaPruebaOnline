Imports System.Data


public class LOG_ESTABLECIMIENTOMODIFICADONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval LOG_ESTABLECIMIENTOMODIFICADO as LOG_ESTABLECIMIENTOMODIFICADOENT)
       Try
           Dim LOG_ESTABLECIMIENTOMODIFICADODatos as new LOG_ESTABLECIMIENTOMODIFICADODAT
           LOG_ESTABLECIMIENTOMODIFICADODatos.insertar(LOG_ESTABLECIMIENTOMODIFICADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval LOG_ESTABLECIMIENTOMODIFICADO as LOG_ESTABLECIMIENTOMODIFICADOENT)
       Try
           Dim LOG_ESTABLECIMIENTOMODIFICADODatos as new LOG_ESTABLECIMIENTOMODIFICADODAT
           LOG_ESTABLECIMIENTOMODIFICADODatos.actualizar(LOG_ESTABLECIMIENTOMODIFICADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval LOG_ESTABLECIMIENTOMODIFICADO as LOG_ESTABLECIMIENTOMODIFICADOENT)
       Try
           Dim LOG_ESTABLECIMIENTOMODIFICADODatos as new LOG_ESTABLECIMIENTOMODIFICADODAT
           LOG_ESTABLECIMIENTOMODIFICADODatos.eliminar(LOG_ESTABLECIMIENTOMODIFICADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as LOG_ESTABLECIMIENTOMODIFICADOENT()
       Try
           Dim LOG_ESTABLECIMIENTOMODIFICADODatos as new LOG_ESTABLECIMIENTOMODIFICADODAT
           return LOG_ESTABLECIMIENTOMODIFICADODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#End Region

#Region "OBTENER PARAMETROS"
    Public Function obtenerparametros(ByVal rol As Integer, ByVal encuesta As Integer) As DataTable
        Try
            Dim LOG_ESTABLECIMIENTOMODIFICADODatos As New LOG_ESTABLECIMIENTOMODIFICADODAT


            Return LOG_ESTABLECIMIENTOMODIFICADODatos.obtenerparametros(rol, encuesta)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
#End Region

#Region "ACTUALIZAR LOS DATOS DEL DIRECTORIO SEGÚN POR LOS DATOS ENTREGADOS EN LA ENCUESTA"
    Public Sub ActualizarEmpEst_desdeEnc(ByVal EMPRESA As LOG_EMPRESAMODIFICADOENT, ByVal ESTABLECIMIENTO As LOG_ESTABLECIMIENTOMODIFICADOENT)
        Try
            Dim LOG_ESTABLECIMIENTOMODIFICADODatos As New LOG_ESTABLECIMIENTOMODIFICADODAT
            LOG_ESTABLECIMIENTOMODIFICADODatos.ActualizarEmpEst_desdeEnc(EMPRESA, ESTABLECIMIENTO)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
end class
