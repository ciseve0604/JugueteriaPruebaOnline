Imports System.Data


public class LOG_ESTADOESTABLECIMIENTODAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval LOG_ESTADOESTABLECIMIENTO as LOG_ESTADOESTABLECIMIENTOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_LOG_ESTADOESTABLECIMIENTO_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",LOG_ESTADOESTABLECIMIENTO.ID_ENCUESTA)
           sp.AgregarParametro("ROL",LOG_ESTADOESTABLECIMIENTO.ROL)
           sp.AgregarParametro("ID_ESTADOESTABLECIMIENTO",LOG_ESTADOESTABLECIMIENTO.ID_ESTADOESTABLECIMIENTO)
           sp.AgregarParametro("USUARIO_ACTUALIZACION",LOG_ESTADOESTABLECIMIENTO.USUARIO_ACTUALIZACION)
            'sp.AgregarParametro("FECHA_ACTUALIZACION",LOG_ESTADOESTABLECIMIENTO.FECHA_ACTUALIZACION)
            'sp.AgregarParametro("OBSERVACION",LOG_ESTADOESTABLECIMIENTO.OBSERVACION)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval LOG_ESTADOESTABLECIMIENTO as LOG_ESTADOESTABLECIMIENTOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_LOG_ESTADOESTABLECIMIENTO_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",LOG_ESTADOESTABLECIMIENTO.ID_ENCUESTA)
           sp.AgregarParametro("ROL",LOG_ESTADOESTABLECIMIENTO.ROL)
           sp.AgregarParametro("ID_ESTADOESTABLECIMIENTO",LOG_ESTADOESTABLECIMIENTO.ID_ESTADOESTABLECIMIENTO)
           sp.AgregarParametro("USUARIO_ACTUALIZACION",LOG_ESTADOESTABLECIMIENTO.USUARIO_ACTUALIZACION)
           sp.AgregarParametro("FECHA_ACTUALIZACION",LOG_ESTADOESTABLECIMIENTO.FECHA_ACTUALIZACION)
           sp.AgregarParametro("OBSERVACION",LOG_ESTADOESTABLECIMIENTO.OBSERVACION)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_LOG_ESTADOESTABLECIMIENTO_Eliminar")
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

   Public Function Listar() as LOG_ESTADOESTABLECIMIENTOENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_LOG_ESTADOESTABLECIMIENTO_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim LOG_ESTADOESTABLECIMIENTO(dt.Rows.count() - 1) as LOG_ESTADOESTABLECIMIENTOENT
           i = 0
           for each dr in dt.rows
                LOG_ESTADOESTABLECIMIENTO(i) = New LOG_ESTADOESTABLECIMIENTOENT()
                LOG_ESTADOESTABLECIMIENTO(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                LOG_ESTADOESTABLECIMIENTO(i).ROL = dr("ROL")
                LOG_ESTADOESTABLECIMIENTO(i).ID_ESTADOESTABLECIMIENTO = dr("ID_ESTADOESTABLECIMIENTO")
                LOG_ESTADOESTABLECIMIENTO(i).USUARIO_ACTUALIZACION = dr("USUARIO_ACTUALIZACION")
                LOG_ESTADOESTABLECIMIENTO(i).FECHA_ACTUALIZACION = dr("FECHA_ACTUALIZACION")
                LOG_ESTADOESTABLECIMIENTO(i).OBSERVACION = dr("OBSERVACION")
                i = i + 1
           next
           return LOG_ESTADOESTABLECIMIENTO
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
