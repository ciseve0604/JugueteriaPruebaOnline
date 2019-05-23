Imports System.Data


public class GLO_ESTADOEMPRESADAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GLO_ESTADOEMPRESA as GLO_ESTADOEMPRESAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_ESTADOEMPRESA_Insertar")
           sp.AgregarParametro("ID_ESTADOEMPRESA",GLO_ESTADOEMPRESA.ID_ESTADOEMPRESA)
           sp.AgregarParametro("GLOSA_ESTADOEMPRESA",GLO_ESTADOEMPRESA.GLOSA_ESTADOEMPRESA)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GLO_ESTADOEMPRESA as GLO_ESTADOEMPRESAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_ESTADOEMPRESA_Actualizar")
           sp.AgregarParametro("ID_ESTADOEMPRESA",GLO_ESTADOEMPRESA.ID_ESTADOEMPRESA)
           sp.AgregarParametro("GLOSA_ESTADOEMPRESA",GLO_ESTADOEMPRESA.GLOSA_ESTADOEMPRESA)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_ESTADOEMPRESA_Eliminar")
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

   Public Function Listar() as GLO_ESTADOEMPRESAENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GLO_ESTADOEMPRESA_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GLO_ESTADOEMPRESA(dt.Rows.count() - 1) as GLO_ESTADOEMPRESAENT
           i = 0
           for each dr in dt.rows
                GLO_ESTADOEMPRESA(i) = New GLO_ESTADOEMPRESAENT()
                GLO_ESTADOEMPRESA(i).ID_ESTADOEMPRESA = dr("ID_ESTADOEMPRESA")
                GLO_ESTADOEMPRESA(i).GLOSA_ESTADOEMPRESA = dr("GLOSA_ESTADOEMPRESA")
                i = i + 1
           next
           return GLO_ESTADOEMPRESA
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
