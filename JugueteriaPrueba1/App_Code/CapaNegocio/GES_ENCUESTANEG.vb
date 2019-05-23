Imports System.Data


public class GES_ENCUESTANEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GES_ENCUESTA as GES_ENCUESTAENT)
       Try
           Dim GES_ENCUESTADatos as new GES_ENCUESTADAT
           GES_ENCUESTADatos.insertar(GES_ENCUESTA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GES_ENCUESTA as GES_ENCUESTAENT)
       Try
           Dim GES_ENCUESTADatos as new GES_ENCUESTADAT
           GES_ENCUESTADatos.actualizar(GES_ENCUESTA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GES_ENCUESTA as GES_ENCUESTAENT)
       Try
           Dim GES_ENCUESTADatos as new GES_ENCUESTADAT
           GES_ENCUESTADatos.eliminar(GES_ENCUESTA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GES_ENCUESTAENT()
       Try
           Dim GES_ENCUESTADatos as new GES_ENCUESTADAT
           return GES_ENCUESTADatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION
end class
