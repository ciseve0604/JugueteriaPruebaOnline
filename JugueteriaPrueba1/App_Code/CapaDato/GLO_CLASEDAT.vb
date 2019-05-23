Imports System.Data


public class GLO_CLASEDAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GLO_CLASE as GLO_CLASEENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_CLASE_Insertar")
           sp.AgregarParametro("ID_CLASE",GLO_CLASE.ID_CLASE)
           sp.AgregarParametro("GLOSA_CLASE",GLO_CLASE.GLOSA_CLASE)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GLO_CLASE as GLO_CLASEENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_CLASE_Actualizar")
           sp.AgregarParametro("ID_CLASE",GLO_CLASE.ID_CLASE)
           sp.AgregarParametro("GLOSA_CLASE",GLO_CLASE.GLOSA_CLASE)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_CLASE_Eliminar")
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

   Public Function Listar() as GLO_CLASEENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GLO_CLASE_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GLO_CLASE(dt.Rows.count() - 1) as GLO_CLASEENT
           i = 0
           for each dr in dt.rows
                GLO_CLASE(i) = New GLO_CLASEENT()
                GLO_CLASE(i).ID_CLASE = dr("ID_CLASE")
                GLO_CLASE(i).GLOSA_CLASE = dr("GLOSA_CLASE")
                i = i + 1
           next
           return GLO_CLASE
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
