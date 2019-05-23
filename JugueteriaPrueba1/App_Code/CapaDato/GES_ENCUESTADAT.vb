Imports System.Data


public class GES_ENCUESTADAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GES_ENCUESTA as GES_ENCUESTAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ENCUESTA_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",GES_ENCUESTA.ID_ENCUESTA)
           sp.AgregarParametro("NOMBRE_ENCUESTA",GES_ENCUESTA.NOMBRE_ENCUESTA)
           sp.AgregarParametro("USUARIODB",GES_ENCUESTA.USUARIODB)
           sp.AgregarParametro("CLAVEDB",GES_ENCUESTA.CLAVEDB)
           sp.AgregarParametro("NOMBREDB",GES_ENCUESTA.NOMBREDB)
            'sp.AgregarParametro("PERIODO",GES_ENCUESTA.PERIODO)
           sp.AgregarParametro("PERIOCIDAD",GES_ENCUESTA.PERIOCIDAD)
           sp.AgregarParametro("ESTADO_ENCUESTA",GES_ENCUESTA.ESTADO_ENCUESTA)
           sp.AgregarParametro("FECHA_CREACION",GES_ENCUESTA.FECHA_CREACION)
           sp.AgregarParametro("USUARIO_CREACION",GES_ENCUESTA.USUARIO_CREACION)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GES_ENCUESTA as GES_ENCUESTAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ENCUESTA_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",GES_ENCUESTA.ID_ENCUESTA)
           sp.AgregarParametro("NOMBRE_ENCUESTA",GES_ENCUESTA.NOMBRE_ENCUESTA)
           sp.AgregarParametro("USUARIODB",GES_ENCUESTA.USUARIODB)
           sp.AgregarParametro("CLAVEDB",GES_ENCUESTA.CLAVEDB)
           sp.AgregarParametro("NOMBREDB",GES_ENCUESTA.NOMBREDB)
            'sp.AgregarParametro("PERIODO",GES_ENCUESTA.PERIODO)
           sp.AgregarParametro("PERIOCIDAD",GES_ENCUESTA.PERIOCIDAD)
           sp.AgregarParametro("ESTADO_ENCUESTA",GES_ENCUESTA.ESTADO_ENCUESTA)
           sp.AgregarParametro("FECHA_CREACION",GES_ENCUESTA.FECHA_CREACION)
           sp.AgregarParametro("USUARIO_CREACION",GES_ENCUESTA.USUARIO_CREACION)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ENCUESTA_Eliminar")
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

   Public Function Listar() as GES_ENCUESTAENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GES_ENCUESTA_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GES_ENCUESTA(dt.Rows.count() - 1) as GES_ENCUESTAENT
           i = 0
           for each dr in dt.rows
                GES_ENCUESTA(i) = New GES_ENCUESTAENT()
                GES_ENCUESTA(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                GES_ENCUESTA(i).NOMBRE_ENCUESTA = dr("NOMBRE_ENCUESTA")
                GES_ENCUESTA(i).USUARIODB = dr("USUARIODB")
                GES_ENCUESTA(i).CLAVEDB = dr("CLAVEDB")
                GES_ENCUESTA(i).NOMBREDB = dr("NOMBREDB")
                'GES_ENCUESTA(i).PERIODO = dr("PERIODO")
                GES_ENCUESTA(i).PERIOCIDAD = dr("PERIOCIDAD")
                GES_ENCUESTA(i).ESTADO_ENCUESTA = dr("ESTADO_ENCUESTA")
                GES_ENCUESTA(i).FECHA_CREACION = dr("FECHA_CREACION")
                GES_ENCUESTA(i).USUARIO_CREACION = dr("USUARIO_CREACION")
                i = i + 1
           next
           return GES_ENCUESTA
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
