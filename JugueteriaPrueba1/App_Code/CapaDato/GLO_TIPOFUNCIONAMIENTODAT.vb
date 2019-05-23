Imports System.Data


public class GLO_TIPOFUNCIONAMIENTODAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GLO_TIPOFUNCIONAMIENTO as GLO_TIPOFUNCIONAMIENTOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_TIPOFUNCIONAMIENTO_Insertar")
           sp.AgregarParametro("ID_TIPOFUNCIONAMIENTO",GLO_TIPOFUNCIONAMIENTO.ID_TIPOFUNCIONAMIENTO)
           sp.AgregarParametro("GLOSA_TIPOFUNCIONAMIENTO",GLO_TIPOFUNCIONAMIENTO.GLOSA_TIPOFUNCIONAMIENTO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GLO_TIPOFUNCIONAMIENTO as GLO_TIPOFUNCIONAMIENTOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_TIPOFUNCIONAMIENTO_Actualizar")
           sp.AgregarParametro("ID_TIPOFUNCIONAMIENTO",GLO_TIPOFUNCIONAMIENTO.ID_TIPOFUNCIONAMIENTO)
           sp.AgregarParametro("GLOSA_TIPOFUNCIONAMIENTO",GLO_TIPOFUNCIONAMIENTO.GLOSA_TIPOFUNCIONAMIENTO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_TIPOFUNCIONAMIENTO_Eliminar")
'Aqui deben definir los parametros necesarios
           sp.AgregarParametro("","")
'Fin de parametros necesarios
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

#END REGION
#REGION "METODO LISTAR"

   Public Function Listar() as GLO_TIPOFUNCIONAMIENTOENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GLO_TIPOFUNCIONAMIENTO_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GLO_TIPOFUNCIONAMIENTO(dt.Rows.count() - 1) as GLO_TIPOFUNCIONAMIENTOENT
           i = 0
           for each dr in dt.rows
                GLO_TIPOFUNCIONAMIENTO(i) = New GLO_TIPOFUNCIONAMIENTOENT()
                GLO_TIPOFUNCIONAMIENTO(i).ID_TIPOFUNCIONAMIENTO = dr("ID_TIPOFUNCIONAMIENTO")
                GLO_TIPOFUNCIONAMIENTO(i).GLOSA_TIPOFUNCIONAMIENTO = dr("GLOSA_TIPOFUNCIONAMIENTO")
                i = i + 1
           next
           return GLO_TIPOFUNCIONAMIENTO
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
