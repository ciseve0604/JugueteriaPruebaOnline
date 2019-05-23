Imports System.Data


public class GLO_ESTADOESTABLECIMIENTONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GLO_ESTADOESTABLECIMIENTO as GLO_ESTADOESTABLECIMIENTOENT)
       Try
           Dim GLO_ESTADOESTABLECIMIENTODatos as new GLO_ESTADOESTABLECIMIENTODAT
           GLO_ESTADOESTABLECIMIENTODatos.insertar(GLO_ESTADOESTABLECIMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GLO_ESTADOESTABLECIMIENTO as GLO_ESTADOESTABLECIMIENTOENT)
       Try
           Dim GLO_ESTADOESTABLECIMIENTODatos as new GLO_ESTADOESTABLECIMIENTODAT
           GLO_ESTADOESTABLECIMIENTODatos.actualizar(GLO_ESTADOESTABLECIMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GLO_ESTADOESTABLECIMIENTO as GLO_ESTADOESTABLECIMIENTOENT)
       Try
           Dim GLO_ESTADOESTABLECIMIENTODatos as new GLO_ESTADOESTABLECIMIENTODAT
           GLO_ESTADOESTABLECIMIENTODatos.eliminar(GLO_ESTADOESTABLECIMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GLO_ESTADOESTABLECIMIENTOENT()
       Try
           Dim GLO_ESTADOESTABLECIMIENTODatos as new GLO_ESTADOESTABLECIMIENTODAT
           return GLO_ESTADOESTABLECIMIENTODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION
end class
