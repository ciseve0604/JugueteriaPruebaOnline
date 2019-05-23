Imports System.Data


public class GLO_ESTADOESTABLECIMIENTODAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GLO_ESTADOESTABLECIMIENTO as GLO_ESTADOESTABLECIMIENTOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_ESTADOESTABLECIMIENTO_Insertar")
           sp.AgregarParametro("ID_ESTADOESTABLECIMIENTO",GLO_ESTADOESTABLECIMIENTO.ID_ESTADOESTABLECIMIENTO)
           sp.AgregarParametro("GLOSA_ESTADOESTABLECIMIENTO",GLO_ESTADOESTABLECIMIENTO.GLOSA_ESTADOESTABLECIMIENTO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GLO_ESTADOESTABLECIMIENTO as GLO_ESTADOESTABLECIMIENTOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_ESTADOESTABLECIMIENTO_Actualizar")
           sp.AgregarParametro("ID_ESTADOESTABLECIMIENTO",GLO_ESTADOESTABLECIMIENTO.ID_ESTADOESTABLECIMIENTO)
           sp.AgregarParametro("GLOSA_ESTADOESTABLECIMIENTO",GLO_ESTADOESTABLECIMIENTO.GLOSA_ESTADOESTABLECIMIENTO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_ESTADOESTABLECIMIENTO_Eliminar")
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

   Public Function Listar() as GLO_ESTADOESTABLECIMIENTOENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GLO_ESTADOESTABLECIMIENTO_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GLO_ESTADOESTABLECIMIENTO(dt.Rows.count() - 1) as GLO_ESTADOESTABLECIMIENTOENT
           i = 0
           for each dr in dt.rows
                GLO_ESTADOESTABLECIMIENTO(i) = New GLO_ESTADOESTABLECIMIENTOENT()
                GLO_ESTADOESTABLECIMIENTO(i).ID_ESTADOESTABLECIMIENTO = dr("ID_ESTADOESTABLECIMIENTO")
                GLO_ESTADOESTABLECIMIENTO(i).GLOSA_ESTADOESTABLECIMIENTO = dr("GLOSA_ESTADOESTABLECIMIENTO")
                i = i + 1
           next
           return GLO_ESTADOESTABLECIMIENTO
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
