Imports System.Data


public class GLO_TIPOACCESONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GLO_TIPOACCESO as GLO_TIPOACCESOENT)
       Try
           Dim GLO_TIPOACCESODatos as new GLO_TIPOACCESODAT
           GLO_TIPOACCESODatos.insertar(GLO_TIPOACCESO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GLO_TIPOACCESO as GLO_TIPOACCESOENT)
       Try
           Dim GLO_TIPOACCESODatos as new GLO_TIPOACCESODAT
           GLO_TIPOACCESODatos.actualizar(GLO_TIPOACCESO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GLO_TIPOACCESO as GLO_TIPOACCESOENT)
       Try
           Dim GLO_TIPOACCESODatos as new GLO_TIPOACCESODAT
           GLO_TIPOACCESODatos.eliminar(GLO_TIPOACCESO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GLO_TIPOACCESOENT()
       Try
           Dim GLO_TIPOACCESODatos as new GLO_TIPOACCESODAT
           return GLO_TIPOACCESODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION
end class
