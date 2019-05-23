Imports System.Data


public class GLO_CLASENEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GLO_CLASE as GLO_CLASEENT)
       Try
           Dim GLO_CLASEDatos as new GLO_CLASEDAT
           GLO_CLASEDatos.insertar(GLO_CLASE)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GLO_CLASE as GLO_CLASEENT)
       Try
           Dim GLO_CLASEDatos as new GLO_CLASEDAT
           GLO_CLASEDatos.actualizar(GLO_CLASE)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GLO_CLASE as GLO_CLASEENT)
       Try
           Dim GLO_CLASEDatos as new GLO_CLASEDAT
           GLO_CLASEDatos.eliminar(GLO_CLASE)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GLO_CLASEENT()
       Try
           Dim GLO_CLASEDatos as new GLO_CLASEDAT
           return GLO_CLASEDatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION
end class
