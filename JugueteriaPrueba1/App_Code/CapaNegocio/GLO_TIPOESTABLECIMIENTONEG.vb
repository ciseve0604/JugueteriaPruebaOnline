Imports System.Data


public class GLO_TIPOESTABLECIMIENTONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GLO_TIPOESTABLECIMIENTO as GLO_TIPOESTABLECIMIENTOENT)
       Try
           Dim GLO_TIPOESTABLECIMIENTODatos as new GLO_TIPOESTABLECIMIENTODAT
           GLO_TIPOESTABLECIMIENTODatos.insertar(GLO_TIPOESTABLECIMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GLO_TIPOESTABLECIMIENTO as GLO_TIPOESTABLECIMIENTOENT)
       Try
           Dim GLO_TIPOESTABLECIMIENTODatos as new GLO_TIPOESTABLECIMIENTODAT
           GLO_TIPOESTABLECIMIENTODatos.actualizar(GLO_TIPOESTABLECIMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GLO_TIPOESTABLECIMIENTO as GLO_TIPOESTABLECIMIENTOENT)
       Try
           Dim GLO_TIPOESTABLECIMIENTODatos as new GLO_TIPOESTABLECIMIENTODAT
           GLO_TIPOESTABLECIMIENTODatos.eliminar(GLO_TIPOESTABLECIMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GLO_TIPOESTABLECIMIENTOENT()
       Try
           Dim GLO_TIPOESTABLECIMIENTODatos as new GLO_TIPOESTABLECIMIENTODAT
           return GLO_TIPOESTABLECIMIENTODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION
end class
