Imports System.Data


public class GLO_ESTADOEMPRESANEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GLO_ESTADOEMPRESA as GLO_ESTADOEMPRESAENT)
       Try
           Dim GLO_ESTADOEMPRESADatos as new GLO_ESTADOEMPRESADAT
           GLO_ESTADOEMPRESADatos.insertar(GLO_ESTADOEMPRESA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GLO_ESTADOEMPRESA as GLO_ESTADOEMPRESAENT)
       Try
           Dim GLO_ESTADOEMPRESADatos as new GLO_ESTADOEMPRESADAT
           GLO_ESTADOEMPRESADatos.actualizar(GLO_ESTADOEMPRESA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GLO_ESTADOEMPRESA as GLO_ESTADOEMPRESAENT)
       Try
           Dim GLO_ESTADOEMPRESADatos as new GLO_ESTADOEMPRESADAT
           GLO_ESTADOEMPRESADatos.eliminar(GLO_ESTADOEMPRESA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GLO_ESTADOEMPRESAENT()
       Try
           Dim GLO_ESTADOEMPRESADatos as new GLO_ESTADOEMPRESADAT
           return GLO_ESTADOEMPRESADatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION
end class
