Imports System.Data


public class LOG_ESTANDARACCESONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval LOG_ESTANDARACCESO as LOG_ESTANDARACCESOENT)
       Try
           Dim LOG_ESTANDARACCESODatos as new LOG_ESTANDARACCESODAT
           LOG_ESTANDARACCESODatos.insertar(LOG_ESTANDARACCESO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval LOG_ESTANDARACCESO as LOG_ESTANDARACCESOENT)
       Try
           Dim LOG_ESTANDARACCESODatos as new LOG_ESTANDARACCESODAT
           LOG_ESTANDARACCESODatos.actualizar(LOG_ESTANDARACCESO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval LOG_ESTANDARACCESO as LOG_ESTANDARACCESOENT)
       Try
           Dim LOG_ESTANDARACCESODatos as new LOG_ESTANDARACCESODAT
           LOG_ESTANDARACCESODatos.eliminar(LOG_ESTANDARACCESO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as LOG_ESTANDARACCESOENT()
       Try
           Dim LOG_ESTANDARACCESODatos as new LOG_ESTANDARACCESODAT
           return LOG_ESTANDARACCESODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION
end class
