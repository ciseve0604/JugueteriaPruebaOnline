Imports System.Data


public class GLO_TIPOFUNCIONAMIENTONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GLO_TIPOFUNCIONAMIENTO as GLO_TIPOFUNCIONAMIENTOENT)
       Try
           Dim GLO_TIPOFUNCIONAMIENTODatos as new GLO_TIPOFUNCIONAMIENTODAT
           GLO_TIPOFUNCIONAMIENTODatos.insertar(GLO_TIPOFUNCIONAMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GLO_TIPOFUNCIONAMIENTO as GLO_TIPOFUNCIONAMIENTOENT)
       Try
           Dim GLO_TIPOFUNCIONAMIENTODatos as new GLO_TIPOFUNCIONAMIENTODAT
           GLO_TIPOFUNCIONAMIENTODatos.actualizar(GLO_TIPOFUNCIONAMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GLO_TIPOFUNCIONAMIENTO as GLO_TIPOFUNCIONAMIENTOENT)
       Try
           Dim GLO_TIPOFUNCIONAMIENTODatos as new GLO_TIPOFUNCIONAMIENTODAT
           GLO_TIPOFUNCIONAMIENTODatos.eliminar(GLO_TIPOFUNCIONAMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GLO_TIPOFUNCIONAMIENTOENT()
       Try
           Dim GLO_TIPOFUNCIONAMIENTODatos as new GLO_TIPOFUNCIONAMIENTODAT
           return GLO_TIPOFUNCIONAMIENTODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION
end class
