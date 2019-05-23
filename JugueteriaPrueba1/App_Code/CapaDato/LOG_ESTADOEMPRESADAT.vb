Imports System.Data


public class LOG_ESTADOEMPRESADAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval LOG_ESTADOEMPRESA as LOG_ESTADOEMPRESAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_LOG_ESTADOEMPRESA_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",LOG_ESTADOEMPRESA.ID_ENCUESTA)
           sp.AgregarParametro("RUT",LOG_ESTADOEMPRESA.RUT)
           sp.AgregarParametro("ID_ESTADOEMPRESA",LOG_ESTADOEMPRESA.ID_ESTADOEMPRESA)
            'sp.AgregarParametro("FECHA_ACTUALIZACION",LOG_ESTADOEMPRESA.FECHA_ACTUALIZACION)
           sp.AgregarParametro("USUARIO_ACTUALIZACION",LOG_ESTADOEMPRESA.USUARIO_ACTUALIZACION)
            'sp.AgregarParametro("COMENTARIO",LOG_ESTADOEMPRESA.COMENTARIO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval LOG_ESTADOEMPRESA as LOG_ESTADOEMPRESAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_LOG_ESTADOEMPRESA_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",LOG_ESTADOEMPRESA.ID_ENCUESTA)
           sp.AgregarParametro("RUT",LOG_ESTADOEMPRESA.RUT)
           sp.AgregarParametro("ID_ESTADOEMPRESA",LOG_ESTADOEMPRESA.ID_ESTADOEMPRESA)
           sp.AgregarParametro("FECHA_ACTUALIZACION",LOG_ESTADOEMPRESA.FECHA_ACTUALIZACION)
           sp.AgregarParametro("USUARIO_ACTUALIZACION",LOG_ESTADOEMPRESA.USUARIO_ACTUALIZACION)
           sp.AgregarParametro("COMENTARIO",LOG_ESTADOEMPRESA.COMENTARIO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_LOG_ESTADOEMPRESA_Eliminar")
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

   Public Function Listar() as LOG_ESTADOEMPRESAENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_LOG_ESTADOEMPRESA_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim LOG_ESTADOEMPRESA(dt.Rows.count() - 1) as LOG_ESTADOEMPRESAENT
           i = 0
           for each dr in dt.rows
                LOG_ESTADOEMPRESA(i) = New LOG_ESTADOEMPRESAENT()
                LOG_ESTADOEMPRESA(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                LOG_ESTADOEMPRESA(i).RUT = dr("RUT")
                LOG_ESTADOEMPRESA(i).ID_ESTADOEMPRESA = dr("ID_ESTADOEMPRESA")
                LOG_ESTADOEMPRESA(i).FECHA_ACTUALIZACION = dr("FECHA_ACTUALIZACION")
                LOG_ESTADOEMPRESA(i).USUARIO_ACTUALIZACION = dr("USUARIO_ACTUALIZACION")
                LOG_ESTADOEMPRESA(i).COMENTARIO = dr("COMENTARIO")
                i = i + 1
           next
           return LOG_ESTADOEMPRESA
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
