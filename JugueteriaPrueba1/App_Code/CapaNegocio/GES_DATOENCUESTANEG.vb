Imports System.Data


public class GES_DATOENCUESTANEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GES_DATOENCUESTA as GES_DATOENCUESTAENT)
       Try
           Dim GES_DATOENCUESTADatos as new GES_DATOENCUESTADAT
           GES_DATOENCUESTADatos.insertar(GES_DATOENCUESTA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GES_DATOENCUESTA as GES_DATOENCUESTAENT)
       Try
           Dim GES_DATOENCUESTADatos as new GES_DATOENCUESTADAT
           GES_DATOENCUESTADatos.actualizar(GES_DATOENCUESTA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GES_DATOENCUESTA as GES_DATOENCUESTAENT)
       Try
           Dim GES_DATOENCUESTADatos as new GES_DATOENCUESTADAT
           GES_DATOENCUESTADatos.eliminar(GES_DATOENCUESTA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GES_DATOENCUESTAENT()
       Try
           Dim GES_DATOENCUESTADatos as new GES_DATOENCUESTADAT
           return GES_DATOENCUESTADatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION
end class
