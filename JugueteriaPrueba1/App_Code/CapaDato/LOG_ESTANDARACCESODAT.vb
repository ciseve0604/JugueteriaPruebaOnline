Imports System.Data


public class LOG_ESTANDARACCESODAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval LOG_ESTANDARACCESO as LOG_ESTANDARACCESOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_LOG_ESTANDARACCESO_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",LOG_ESTANDARACCESO.ID_ENCUESTA)
           sp.AgregarParametro("NOMBRE_USUARIO",LOG_ESTANDARACCESO.NOMBRE_USUARIO)
           sp.AgregarParametro("ID_TIPOACCESO",LOG_ESTANDARACCESO.ID_TIPOACCESO)
           sp.AgregarParametro("USUARIO_ACTUALIZACION",LOG_ESTANDARACCESO.USUARIO_ACTUALIZACION)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval LOG_ESTANDARACCESO as LOG_ESTANDARACCESOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_LOG_ESTANDARACCESO_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",LOG_ESTANDARACCESO.ID_ENCUESTA)
           sp.AgregarParametro("NOMBRE_USUARIO",LOG_ESTANDARACCESO.NOMBRE_USUARIO)
           sp.AgregarParametro("ID_TIPOACCESO",LOG_ESTANDARACCESO.ID_TIPOACCESO)
           sp.AgregarParametro("USUARIO_ACTUALIZACION",LOG_ESTANDARACCESO.USUARIO_ACTUALIZACION)
           sp.AgregarParametro("FECHA_ACTUALIZACION",LOG_ESTANDARACCESO.FECHA_ACTUALIZACION)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_LOG_ESTANDARACCESO_Eliminar")
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

   Public Function Listar() as LOG_ESTANDARACCESOENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_LOG_ESTANDARACCESO_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim LOG_ESTANDARACCESO(dt.Rows.count() - 1) as LOG_ESTANDARACCESOENT
           i = 0
           for each dr in dt.rows
                LOG_ESTANDARACCESO(i) = New LOG_ESTANDARACCESOENT()
                LOG_ESTANDARACCESO(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                LOG_ESTANDARACCESO(i).NOMBRE_USUARIO = dr("NOMBRE_USUARIO")
                LOG_ESTANDARACCESO(i).ID_TIPOACCESO = dr("ID_TIPOACCESO")
                LOG_ESTANDARACCESO(i).USUARIO_ACTUALIZACION = dr("USUARIO_ACTUALIZACION")
                LOG_ESTANDARACCESO(i).FECHA_ACTUALIZACION = dr("FECHA_ACTUALIZACION")
                i = i + 1
           next
           return LOG_ESTANDARACCESO
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
