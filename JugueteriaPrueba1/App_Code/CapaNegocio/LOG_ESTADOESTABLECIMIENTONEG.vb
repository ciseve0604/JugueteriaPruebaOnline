Imports System.Data


public class LOG_ESTADOESTABLECIMIENTONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval LOG_ESTADOESTABLECIMIENTO as LOG_ESTADOESTABLECIMIENTOENT)
       Try
           Dim LOG_ESTADOESTABLECIMIENTODatos as new LOG_ESTADOESTABLECIMIENTODAT
           LOG_ESTADOESTABLECIMIENTODatos.insertar(LOG_ESTADOESTABLECIMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval LOG_ESTADOESTABLECIMIENTO as LOG_ESTADOESTABLECIMIENTOENT)
       Try
           Dim LOG_ESTADOESTABLECIMIENTODatos as new LOG_ESTADOESTABLECIMIENTODAT
           LOG_ESTADOESTABLECIMIENTODatos.actualizar(LOG_ESTADOESTABLECIMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval LOG_ESTADOESTABLECIMIENTO as LOG_ESTADOESTABLECIMIENTOENT)
       Try
           Dim LOG_ESTADOESTABLECIMIENTODatos as new LOG_ESTADOESTABLECIMIENTODAT
           LOG_ESTADOESTABLECIMIENTODatos.eliminar(LOG_ESTADOESTABLECIMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as LOG_ESTADOESTABLECIMIENTOENT()
       Try
           Dim LOG_ESTADOESTABLECIMIENTODatos as new LOG_ESTADOESTABLECIMIENTODAT
           return LOG_ESTADOESTABLECIMIENTODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION
end class
