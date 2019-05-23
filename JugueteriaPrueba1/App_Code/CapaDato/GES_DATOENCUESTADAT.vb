Imports System.Data


public class GES_DATOENCUESTADAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GES_DATOENCUESTA as GES_DATOENCUESTAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_DATOENCUESTA_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",GES_DATOENCUESTA.ID_ENCUESTA)
           sp.AgregarParametro("COLOR_ENCUESTA",GES_DATOENCUESTA.COLOR_ENCUESTA)
           sp.AgregarParametro("TITULO_ENCUESTA",GES_DATOENCUESTA.TITULO_ENCUESTA)
           sp.AgregarParametro("BANNER_ENCUESTA",GES_DATOENCUESTA.BANNER_ENCUESTA)
           sp.AgregarParametro("INSTRUCTIVO_ENCUESTA",GES_DATOENCUESTA.INSTRUCTIVO_ENCUESTA)
           sp.AgregarParametro("FORMULARIO_ENCUESTA",GES_DATOENCUESTA.FORMULARIO_ENCUESTA)
           sp.AgregarParametro("ESTADO_DATOENCUESTA",GES_DATOENCUESTA.ESTADO_DATOENCUESTA)
           sp.AgregarParametro("FECHA_CREACION",GES_DATOENCUESTA.FECHA_CREACION)
           sp.AgregarParametro("USUARIO_CREACION",GES_DATOENCUESTA.USUARIO_CREACION)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GES_DATOENCUESTA as GES_DATOENCUESTAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_DATOENCUESTA_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",GES_DATOENCUESTA.ID_ENCUESTA)
           sp.AgregarParametro("COLOR_ENCUESTA",GES_DATOENCUESTA.COLOR_ENCUESTA)
           sp.AgregarParametro("TITULO_ENCUESTA",GES_DATOENCUESTA.TITULO_ENCUESTA)
           sp.AgregarParametro("BANNER_ENCUESTA",GES_DATOENCUESTA.BANNER_ENCUESTA)
           sp.AgregarParametro("INSTRUCTIVO_ENCUESTA",GES_DATOENCUESTA.INSTRUCTIVO_ENCUESTA)
           sp.AgregarParametro("FORMULARIO_ENCUESTA",GES_DATOENCUESTA.FORMULARIO_ENCUESTA)
           sp.AgregarParametro("ESTADO_DATOENCUESTA",GES_DATOENCUESTA.ESTADO_DATOENCUESTA)
           sp.AgregarParametro("FECHA_CREACION",GES_DATOENCUESTA.FECHA_CREACION)
           sp.AgregarParametro("USUARIO_CREACION",GES_DATOENCUESTA.USUARIO_CREACION)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_DATOENCUESTA_Eliminar")
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

   Public Function Listar() as GES_DATOENCUESTAENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GES_DATOENCUESTA_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GES_DATOENCUESTA(dt.Rows.count() - 1) as GES_DATOENCUESTAENT
           i = 0
           for each dr in dt.rows
                GES_DATOENCUESTA(i) = New GES_DATOENCUESTAENT()
                GES_DATOENCUESTA(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                GES_DATOENCUESTA(i).COLOR_ENCUESTA = dr("COLOR_ENCUESTA")
                GES_DATOENCUESTA(i).TITULO_ENCUESTA = dr("TITULO_ENCUESTA")
                GES_DATOENCUESTA(i).BANNER_ENCUESTA = dr("BANNER_ENCUESTA")
                GES_DATOENCUESTA(i).INSTRUCTIVO_ENCUESTA = dr("INSTRUCTIVO_ENCUESTA")
                GES_DATOENCUESTA(i).FORMULARIO_ENCUESTA = dr("FORMULARIO_ENCUESTA")
                GES_DATOENCUESTA(i).ESTADO_DATOENCUESTA = dr("ESTADO_DATOENCUESTA")
                GES_DATOENCUESTA(i).FECHA_CREACION = dr("FECHA_CREACION")
                GES_DATOENCUESTA(i).USUARIO_CREACION = dr("USUARIO_CREACION")
                i = i + 1
           next
           return GES_DATOENCUESTA
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
