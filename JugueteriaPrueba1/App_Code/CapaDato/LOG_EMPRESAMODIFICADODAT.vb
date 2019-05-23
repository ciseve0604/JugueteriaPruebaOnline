Imports System.Data


public class LOG_EMPRESAMODIFICADODAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval LOG_EMPRESAMODIFICADO as LOG_EMPRESAMODIFICADOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_LOG_EMPRESAMODIFICADO_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",LOG_EMPRESAMODIFICADO.ID_ENCUESTA)
           sp.AgregarParametro("ANO",LOG_EMPRESAMODIFICADO.ANO)
           sp.AgregarParametro("ID_PERIODO",LOG_EMPRESAMODIFICADO.ID_PERIODO)
           sp.AgregarParametro("RUT",LOG_EMPRESAMODIFICADO.RUT)
           sp.AgregarParametro("DVRUT",LOG_EMPRESAMODIFICADO.DVRUT)
           sp.AgregarParametro("RAZONSOCIAL",LOG_EMPRESAMODIFICADO.RAZONSOCIAL)
           sp.AgregarParametro("REPRESENTANTELEGAL",LOG_EMPRESAMODIFICADO.REPRESENTANTELEGAL)
           sp.AgregarParametro("RUTREPRESENTANTELEGAL",LOG_EMPRESAMODIFICADO.RUTREPRESENTANTELEGAL)
           sp.AgregarParametro("DVRUTREPRESENTANTELEGAL",LOG_EMPRESAMODIFICADO.DVRUTREPRESENTANTELEGAL)
           sp.AgregarParametro("REGION_G",LOG_EMPRESAMODIFICADO.REGION_G)
           sp.AgregarParametro("PROVINCIA_G",LOG_EMPRESAMODIFICADO.PROVINCIA_G)
           sp.AgregarParametro("COMUNA_G",LOG_EMPRESAMODIFICADO.COMUNA_G)
            sp.AgregarParametro("GLOSA_COMUNA_G", LOG_EMPRESAMODIFICADO.GLOSA_COMUNA_G)
            sp.AgregarParametro("DIRECCION_G", LOG_EMPRESAMODIFICADO.DIRECCION_G)
           sp.AgregarParametro("CODA_FONO_G",LOG_EMPRESAMODIFICADO.CODA_FONO_G)
           sp.AgregarParametro("FONO_G",LOG_EMPRESAMODIFICADO.FONO_G)
           sp.AgregarParametro("CODA_FAX_G",LOG_EMPRESAMODIFICADO.CODA_FAX_G)
           sp.AgregarParametro("FAX_G",LOG_EMPRESAMODIFICADO.FAX_G)
           sp.AgregarParametro("CELULAR_G",LOG_EMPRESAMODIFICADO.CELULAR_G)
           sp.AgregarParametro("CASILLA",LOG_EMPRESAMODIFICADO.CASILLA)
           sp.AgregarParametro("EMAIL_G",LOG_EMPRESAMODIFICADO.EMAIL_G)
           sp.AgregarParametro("WEB_G",LOG_EMPRESAMODIFICADO.WEB_G)
           sp.AgregarParametro("NRO_ESTABLECIMIENTOS",LOG_EMPRESAMODIFICADO.NRO_ESTABLECIMIENTOS)
           sp.AgregarParametro("ACTIVIDADECONOMICA1",LOG_EMPRESAMODIFICADO.ACTIVIDADECONOMICA1)
           sp.AgregarParametro("FECHA_LEVANTAMIENTO",LOG_EMPRESAMODIFICADO.FECHA_LEVANTAMIENTO)
           sp.AgregarParametro("USUARIO_ACTUALIZACION",LOG_EMPRESAMODIFICADO.USUARIO_ACTUALIZACION)
           sp.AgregarParametro("FECHA_ACTUALIZACION",LOG_EMPRESAMODIFICADO.FECHA_ACTUALIZACION)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval LOG_EMPRESAMODIFICADO as LOG_EMPRESAMODIFICADOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_LOG_EMPRESAMODIFICADO_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",LOG_EMPRESAMODIFICADO.ID_ENCUESTA)
           sp.AgregarParametro("ANO",LOG_EMPRESAMODIFICADO.ANO)
           sp.AgregarParametro("ID_PERIODO",LOG_EMPRESAMODIFICADO.ID_PERIODO)
           sp.AgregarParametro("RUT",LOG_EMPRESAMODIFICADO.RUT)
           sp.AgregarParametro("DVRUT",LOG_EMPRESAMODIFICADO.DVRUT)
           sp.AgregarParametro("RAZONSOCIAL",LOG_EMPRESAMODIFICADO.RAZONSOCIAL)
           sp.AgregarParametro("REPRESENTANTELEGAL",LOG_EMPRESAMODIFICADO.REPRESENTANTELEGAL)
           sp.AgregarParametro("RUTREPRESENTANTELEGAL",LOG_EMPRESAMODIFICADO.RUTREPRESENTANTELEGAL)
           sp.AgregarParametro("DVRUTREPRESENTANTELEGAL",LOG_EMPRESAMODIFICADO.DVRUTREPRESENTANTELEGAL)
           sp.AgregarParametro("REGION_G",LOG_EMPRESAMODIFICADO.REGION_G)
           sp.AgregarParametro("PROVINCIA_G",LOG_EMPRESAMODIFICADO.PROVINCIA_G)
           sp.AgregarParametro("COMUNA_G",LOG_EMPRESAMODIFICADO.COMUNA_G)
            sp.AgregarParametro("GLOSA_COMUNA_G", LOG_EMPRESAMODIFICADO.GLOSA_COMUNA_G)
            sp.AgregarParametro("DIRECCION_G", LOG_EMPRESAMODIFICADO.DIRECCION_G)
           sp.AgregarParametro("CODA_FONO_G",LOG_EMPRESAMODIFICADO.CODA_FONO_G)
           sp.AgregarParametro("FONO_G",LOG_EMPRESAMODIFICADO.FONO_G)
           sp.AgregarParametro("CODA_FAX_G",LOG_EMPRESAMODIFICADO.CODA_FAX_G)
           sp.AgregarParametro("FAX_G",LOG_EMPRESAMODIFICADO.FAX_G)
           sp.AgregarParametro("CELULAR_G",LOG_EMPRESAMODIFICADO.CELULAR_G)
           sp.AgregarParametro("CASILLA",LOG_EMPRESAMODIFICADO.CASILLA)
           sp.AgregarParametro("EMAIL_G",LOG_EMPRESAMODIFICADO.EMAIL_G)
           sp.AgregarParametro("WEB_G",LOG_EMPRESAMODIFICADO.WEB_G)
           sp.AgregarParametro("NRO_ESTABLECIMIENTOS",LOG_EMPRESAMODIFICADO.NRO_ESTABLECIMIENTOS)
           sp.AgregarParametro("ACTIVIDADECONOMICA1",LOG_EMPRESAMODIFICADO.ACTIVIDADECONOMICA1)
           sp.AgregarParametro("FECHA_LEVANTAMIENTO",LOG_EMPRESAMODIFICADO.FECHA_LEVANTAMIENTO)
           sp.AgregarParametro("USUARIO_ACTUALIZACION",LOG_EMPRESAMODIFICADO.USUARIO_ACTUALIZACION)
           sp.AgregarParametro("FECHA_ACTUALIZACION",LOG_EMPRESAMODIFICADO.FECHA_ACTUALIZACION)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_LOG_EMPRESAMODIFICADO_Eliminar")
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

   Public Function Listar() as LOG_EMPRESAMODIFICADOENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_LOG_EMPRESAMODIFICADO_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim LOG_EMPRESAMODIFICADO(dt.Rows.count() - 1) as LOG_EMPRESAMODIFICADOENT
           i = 0
           for each dr in dt.rows
                LOG_EMPRESAMODIFICADO(i) = New LOG_EMPRESAMODIFICADOENT()
                LOG_EMPRESAMODIFICADO(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                LOG_EMPRESAMODIFICADO(i).ANO = dr("ANO")
                LOG_EMPRESAMODIFICADO(i).ID_PERIODO = dr("ID_PERIODO")
                LOG_EMPRESAMODIFICADO(i).RUT = dr("RUT")
                LOG_EMPRESAMODIFICADO(i).DVRUT = dr("DVRUT")
                LOG_EMPRESAMODIFICADO(i).RAZONSOCIAL = dr("RAZONSOCIAL")
                LOG_EMPRESAMODIFICADO(i).REPRESENTANTELEGAL = dr("REPRESENTANTELEGAL")
                LOG_EMPRESAMODIFICADO(i).RUTREPRESENTANTELEGAL = dr("RUTREPRESENTANTELEGAL")
                LOG_EMPRESAMODIFICADO(i).DVRUTREPRESENTANTELEGAL = dr("DVRUTREPRESENTANTELEGAL")
                LOG_EMPRESAMODIFICADO(i).REGION_G = dr("REGION_G")
                LOG_EMPRESAMODIFICADO(i).PROVINCIA_G = dr("PROVINCIA_G")
                LOG_EMPRESAMODIFICADO(i).COMUNA_G = dr("COMUNA_G")
                LOG_EMPRESAMODIFICADO(i).GLOSA_COMUNA_G = dr("GLOSA_COMUNA_G")
                LOG_EMPRESAMODIFICADO(i).DIRECCION_G = dr("DIRECCION_G")
                LOG_EMPRESAMODIFICADO(i).CODA_FONO_G = dr("CODA_FONO_G")
                LOG_EMPRESAMODIFICADO(i).FONO_G = dr("FONO_G")
                LOG_EMPRESAMODIFICADO(i).CODA_FAX_G = dr("CODA_FAX_G")
                LOG_EMPRESAMODIFICADO(i).FAX_G = dr("FAX_G")
                LOG_EMPRESAMODIFICADO(i).CELULAR_G = dr("CELULAR_G")
                LOG_EMPRESAMODIFICADO(i).CASILLA = dr("CASILLA")
                LOG_EMPRESAMODIFICADO(i).EMAIL_G = dr("EMAIL_G")
                LOG_EMPRESAMODIFICADO(i).WEB_G = dr("WEB_G")
                LOG_EMPRESAMODIFICADO(i).NRO_ESTABLECIMIENTOS = dr("NRO_ESTABLECIMIENTOS")
                LOG_EMPRESAMODIFICADO(i).ACTIVIDADECONOMICA1 = dr("ACTIVIDADECONOMICA1")
                LOG_EMPRESAMODIFICADO(i).FECHA_LEVANTAMIENTO = dr("FECHA_LEVANTAMIENTO")
                LOG_EMPRESAMODIFICADO(i).USUARIO_ACTUALIZACION = dr("USUARIO_ACTUALIZACION")
                LOG_EMPRESAMODIFICADO(i).FECHA_ACTUALIZACION = dr("FECHA_ACTUALIZACION")
                i = i + 1
           next
           return LOG_EMPRESAMODIFICADO
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION


#Region "OBTENER PARAMETROS"
    Public Function obtenerparametros(ByVal rut, ByVal encuesta) As DataTable
        Try
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_LOG_EMPRESAMODIFICADO_obtenerparametros")
            sp.AgregarParametro("rut", rut)
            sp.AgregarParametro("id_encuesta", encuesta)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

#End Region




#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
