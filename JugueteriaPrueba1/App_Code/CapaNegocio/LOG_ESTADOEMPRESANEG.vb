Imports System.Data


public class LOG_ESTADOEMPRESANEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval LOG_ESTADOEMPRESA as LOG_ESTADOEMPRESAENT)
       Try
           Dim LOG_ESTADOEMPRESADatos as new LOG_ESTADOEMPRESADAT
           LOG_ESTADOEMPRESADatos.insertar(LOG_ESTADOEMPRESA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval LOG_ESTADOEMPRESA as LOG_ESTADOEMPRESAENT)
       Try
           Dim LOG_ESTADOEMPRESADatos as new LOG_ESTADOEMPRESADAT
           LOG_ESTADOEMPRESADatos.actualizar(LOG_ESTADOEMPRESA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval LOG_ESTADOEMPRESA as LOG_ESTADOEMPRESAENT)
       Try
           Dim LOG_ESTADOEMPRESADatos as new LOG_ESTADOEMPRESADAT
           LOG_ESTADOEMPRESADatos.eliminar(LOG_ESTADOEMPRESA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as LOG_ESTADOEMPRESAENT()
       Try
           Dim LOG_ESTADOEMPRESADatos as new LOG_ESTADOEMPRESADAT
           return LOG_ESTADOEMPRESADatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION
end class
