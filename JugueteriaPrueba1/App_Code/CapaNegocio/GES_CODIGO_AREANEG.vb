Imports System.Data


public class GES_CODIGO_AREANEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GES_CODIGO_AREA as GES_CODIGO_AREAENT)
       Try
           Dim GES_CODIGO_AREADatos as new GES_CODIGO_AREADAT
           GES_CODIGO_AREADatos.insertar(GES_CODIGO_AREA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GES_CODIGO_AREA as GES_CODIGO_AREAENT)
       Try
           Dim GES_CODIGO_AREADatos as new GES_CODIGO_AREADAT
           GES_CODIGO_AREADatos.actualizar(GES_CODIGO_AREA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GES_CODIGO_AREA as GES_CODIGO_AREAENT)
       Try
           Dim GES_CODIGO_AREADatos as new GES_CODIGO_AREADAT
           GES_CODIGO_AREADatos.eliminar(GES_CODIGO_AREA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GES_CODIGO_AREAENT()
       Try
           Dim GES_CODIGO_AREADatos as new GES_CODIGO_AREADAT
           return GES_CODIGO_AREADatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

    Public Function ListarCod() As GES_CODIGO_AREAENT()
        Try
            Dim GES_CODIGO_AREADatos As New GES_CODIGO_AREADAT
            Return GES_CODIGO_AREADatos.ListarCod()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function obtenercodigo(ByVal codigo As Integer) As DataTable
        Try
            Dim GES_CODIGO_AREADATOS As New GES_CODIGO_AREADAT

            Return GES_CODIGO_AREADATOS.obtenercodigo(codigo)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
#END REGION
end class
