Imports System.Data


public class GLO_ACTIVIDADECONOMICADAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GLO_ACTIVIDADECONOMICA as GLO_ACTIVIDADECONOMICAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_ACTIVIDADECONOMICA_Insertar")
           sp.AgregarParametro("ID_ACTIVIDADECONOMICA",GLO_ACTIVIDADECONOMICA.ID_ACTIVIDADECONOMICA)
           sp.AgregarParametro("GLOSA_ACTIVIDADECONOMICA",GLO_ACTIVIDADECONOMICA.GLOSA_ACTIVIDADECONOMICA)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GLO_ACTIVIDADECONOMICA as GLO_ACTIVIDADECONOMICAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_ACTIVIDADECONOMICA_Actualizar")
           sp.AgregarParametro("ID_ACTIVIDADECONOMICA",GLO_ACTIVIDADECONOMICA.ID_ACTIVIDADECONOMICA)
           sp.AgregarParametro("GLOSA_ACTIVIDADECONOMICA",GLO_ACTIVIDADECONOMICA.GLOSA_ACTIVIDADECONOMICA)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GLO_ACTIVIDADECONOMICA_Eliminar")
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

   Public Function Listar() as GLO_ACTIVIDADECONOMICAENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GLO_ACTIVIDADECONOMICA_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GLO_ACTIVIDADECONOMICA(dt.Rows.count() - 1) as GLO_ACTIVIDADECONOMICAENT
           i = 0
           for each dr in dt.rows
                GLO_ACTIVIDADECONOMICA(i) = New GLO_ACTIVIDADECONOMICAENT()
                GLO_ACTIVIDADECONOMICA(i).ID_ACTIVIDADECONOMICA = dr("ID_ACTIVIDADECONOMICA")
                GLO_ACTIVIDADECONOMICA(i).GLOSA_ACTIVIDADECONOMICA = dr("GLOSA_ACTIVIDADECONOMICA")
                i = i + 1
           next
           return GLO_ACTIVIDADECONOMICA
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
