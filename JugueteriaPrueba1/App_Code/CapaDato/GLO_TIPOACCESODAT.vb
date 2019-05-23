Imports System.Data


public class GLO_TIPOACCESODAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GLO_TIPOACCESO as GLO_TIPOACCESOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_TIPOACCESO_Insertar")
           sp.AgregarParametro("ID_TIPOACCESO",GLO_TIPOACCESO.ID_TIPOACCESO)
           sp.AgregarParametro("GLOSA_TIPOACCESO",GLO_TIPOACCESO.GLOSA_TIPOACCESO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GLO_TIPOACCESO as GLO_TIPOACCESOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_TIPOACCESO_Actualizar")
           sp.AgregarParametro("ID_TIPOACCESO",GLO_TIPOACCESO.ID_TIPOACCESO)
           sp.AgregarParametro("GLOSA_TIPOACCESO",GLO_TIPOACCESO.GLOSA_TIPOACCESO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_TIPOACCESO_Eliminar")
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

   Public Function Listar() as GLO_TIPOACCESOENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GLO_TIPOACCESO_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GLO_TIPOACCESO(dt.Rows.count() - 1) as GLO_TIPOACCESOENT
           i = 0
           for each dr in dt.rows
                GLO_TIPOACCESO(i) = New GLO_TIPOACCESOENT()
                GLO_TIPOACCESO(i).ID_TIPOACCESO = dr("ID_TIPOACCESO")
                GLO_TIPOACCESO(i).GLOSA_TIPOACCESO = dr("GLOSA_TIPOACCESO")
                i = i + 1
           next
           return GLO_TIPOACCESO
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
