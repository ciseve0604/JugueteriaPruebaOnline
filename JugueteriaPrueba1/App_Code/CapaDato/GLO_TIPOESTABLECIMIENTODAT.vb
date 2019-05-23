Imports System.Data


public class GLO_TIPOESTABLECIMIENTODAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GLO_TIPOESTABLECIMIENTO as GLO_TIPOESTABLECIMIENTOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_TIPOESTABLECIMIENTO_Insertar")
           sp.AgregarParametro("ID_TIPOESTABLECIMIENTO",GLO_TIPOESTABLECIMIENTO.ID_TIPOESTABLECIMIENTO)
           sp.AgregarParametro("GLOSA_TIPOESTABLECIMIENTO",GLO_TIPOESTABLECIMIENTO.GLOSA_TIPOESTABLECIMIENTO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GLO_TIPOESTABLECIMIENTO as GLO_TIPOESTABLECIMIENTOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_TIPOESTABLECIMIENTO_Actualizar")
           sp.AgregarParametro("ID_TIPOESTABLECIMIENTO",GLO_TIPOESTABLECIMIENTO.ID_TIPOESTABLECIMIENTO)
           sp.AgregarParametro("GLOSA_TIPOESTABLECIMIENTO",GLO_TIPOESTABLECIMIENTO.GLOSA_TIPOESTABLECIMIENTO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_TIPOESTABLECIMIENTO_Eliminar")
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

   Public Function Listar() as GLO_TIPOESTABLECIMIENTOENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GLO_TIPOESTABLECIMIENTO_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GLO_TIPOESTABLECIMIENTO(dt.Rows.count() - 1) as GLO_TIPOESTABLECIMIENTOENT
           i = 0
           for each dr in dt.rows
                GLO_TIPOESTABLECIMIENTO(i) = New GLO_TIPOESTABLECIMIENTOENT()
                GLO_TIPOESTABLECIMIENTO(i).ID_TIPOESTABLECIMIENTO = dr("ID_TIPOESTABLECIMIENTO")
                GLO_TIPOESTABLECIMIENTO(i).GLOSA_TIPOESTABLECIMIENTO = dr("GLOSA_TIPOESTABLECIMIENTO")
                i = i + 1
           next
           return GLO_TIPOESTABLECIMIENTO
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
