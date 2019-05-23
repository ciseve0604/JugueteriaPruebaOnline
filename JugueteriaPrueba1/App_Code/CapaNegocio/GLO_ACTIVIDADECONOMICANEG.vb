Imports System.Data


public class GLO_ACTIVIDADECONOMICANEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GLO_ACTIVIDADECONOMICA as GLO_ACTIVIDADECONOMICAENT)
       Try
           Dim GLO_ACTIVIDADECONOMICADatos as new GLO_ACTIVIDADECONOMICADAT
           GLO_ACTIVIDADECONOMICADatos.insertar(GLO_ACTIVIDADECONOMICA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GLO_ACTIVIDADECONOMICA as GLO_ACTIVIDADECONOMICAENT)
       Try
           Dim GLO_ACTIVIDADECONOMICADatos as new GLO_ACTIVIDADECONOMICADAT
           GLO_ACTIVIDADECONOMICADatos.actualizar(GLO_ACTIVIDADECONOMICA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GLO_ACTIVIDADECONOMICA as GLO_ACTIVIDADECONOMICAENT)
       Try
           Dim GLO_ACTIVIDADECONOMICADatos as new GLO_ACTIVIDADECONOMICADAT
           GLO_ACTIVIDADECONOMICADatos.eliminar(GLO_ACTIVIDADECONOMICA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GLO_ACTIVIDADECONOMICAENT()
       Try
           Dim GLO_ACTIVIDADECONOMICADatos as new GLO_ACTIVIDADECONOMICADAT
           return GLO_ACTIVIDADECONOMICADatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION
end class
