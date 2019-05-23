Imports System.Data


public class DIR_EMPRESACREADODAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval DIR_EMPRESACREADO as DIR_EMPRESACREADOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_EMPRESACREADO_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",DIR_EMPRESACREADO.ID_ENCUESTA)
           sp.AgregarParametro("RUT",DIR_EMPRESACREADO.RUT)
           sp.AgregarParametro("DVRUT",DIR_EMPRESACREADO.DVRUT)
           sp.AgregarParametro("RAZONSOCIAL",DIR_EMPRESACREADO.RAZONSOCIAL)
           sp.AgregarParametro("REPRESENTANTELEGAL",DIR_EMPRESACREADO.REPRESENTANTELEGAL)
           sp.AgregarParametro("RUTREPRESENTANTELEGAL",DIR_EMPRESACREADO.RUTREPRESENTANTELEGAL)
           sp.AgregarParametro("DVRUTREPRESENTANTELEGAL",DIR_EMPRESACREADO.DVRUTREPRESENTANTELEGAL)
           sp.AgregarParametro("REGION_G",DIR_EMPRESACREADO.REGION_G)
           sp.AgregarParametro("PROVINCIA_G",DIR_EMPRESACREADO.PROVINCIA_G)
           sp.AgregarParametro("COMUNA_G",DIR_EMPRESACREADO.COMUNA_G)
           sp.AgregarParametro("GLOSA_COMUNA_G",DIR_EMPRESACREADO.GLOSA_COMUNA_G)
           sp.AgregarParametro("DIRECCION_G",DIR_EMPRESACREADO.DIRECCION_G)
           sp.AgregarParametro("CODA_FONO_G",DIR_EMPRESACREADO.CODA_FONO_G)
           sp.AgregarParametro("FONO_G",DIR_EMPRESACREADO.FONO_G)
           sp.AgregarParametro("CODA_FAX_G",DIR_EMPRESACREADO.CODA_FAX_G)
           sp.AgregarParametro("FAX_G",DIR_EMPRESACREADO.FAX_G)
           sp.AgregarParametro("CELULAR_G",DIR_EMPRESACREADO.CELULAR_G)
           sp.AgregarParametro("CASILLA",DIR_EMPRESACREADO.CASILLA)
           sp.AgregarParametro("EMAIL_G",DIR_EMPRESACREADO.EMAIL_G)
           sp.AgregarParametro("WEB_G",DIR_EMPRESACREADO.WEB_G)
           sp.AgregarParametro("NRO_ESTABLECIMIENTOS",DIR_EMPRESACREADO.NRO_ESTABLECIMIENTOS)
           sp.AgregarParametro("ACTIVIDADECONOMICA1",DIR_EMPRESACREADO.ACTIVIDADECONOMICA1)
           sp.AgregarParametro("FECHA_CREACION",DIR_EMPRESACREADO.FECHA_CREACION)
           sp.AgregarParametro("USUARIO_CREACION",DIR_EMPRESACREADO.USUARIO_CREACION)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval DIR_EMPRESACREADO as DIR_EMPRESACREADOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_EMPRESACREADO_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",DIR_EMPRESACREADO.ID_ENCUESTA)
           sp.AgregarParametro("RUT",DIR_EMPRESACREADO.RUT)
           sp.AgregarParametro("DVRUT",DIR_EMPRESACREADO.DVRUT)
           sp.AgregarParametro("RAZONSOCIAL",DIR_EMPRESACREADO.RAZONSOCIAL)
           sp.AgregarParametro("REPRESENTANTELEGAL",DIR_EMPRESACREADO.REPRESENTANTELEGAL)
           sp.AgregarParametro("RUTREPRESENTANTELEGAL",DIR_EMPRESACREADO.RUTREPRESENTANTELEGAL)
           sp.AgregarParametro("DVRUTREPRESENTANTELEGAL",DIR_EMPRESACREADO.DVRUTREPRESENTANTELEGAL)
           sp.AgregarParametro("REGION_G",DIR_EMPRESACREADO.REGION_G)
           sp.AgregarParametro("PROVINCIA_G",DIR_EMPRESACREADO.PROVINCIA_G)
           sp.AgregarParametro("COMUNA_G",DIR_EMPRESACREADO.COMUNA_G)
           sp.AgregarParametro("GLOSA_COMUNA_G",DIR_EMPRESACREADO.GLOSA_COMUNA_G)
           sp.AgregarParametro("DIRECCION_G",DIR_EMPRESACREADO.DIRECCION_G)
           sp.AgregarParametro("CODA_FONO_G",DIR_EMPRESACREADO.CODA_FONO_G)
           sp.AgregarParametro("FONO_G",DIR_EMPRESACREADO.FONO_G)
           sp.AgregarParametro("CODA_FAX_G",DIR_EMPRESACREADO.CODA_FAX_G)
           sp.AgregarParametro("FAX_G",DIR_EMPRESACREADO.FAX_G)
           sp.AgregarParametro("CELULAR_G",DIR_EMPRESACREADO.CELULAR_G)
           sp.AgregarParametro("CASILLA",DIR_EMPRESACREADO.CASILLA)
           sp.AgregarParametro("EMAIL_G",DIR_EMPRESACREADO.EMAIL_G)
           sp.AgregarParametro("WEB_G",DIR_EMPRESACREADO.WEB_G)
           sp.AgregarParametro("NRO_ESTABLECIMIENTOS",DIR_EMPRESACREADO.NRO_ESTABLECIMIENTOS)
           sp.AgregarParametro("ACTIVIDADECONOMICA1",DIR_EMPRESACREADO.ACTIVIDADECONOMICA1)
           sp.AgregarParametro("FECHA_CREACION",DIR_EMPRESACREADO.FECHA_CREACION)
           sp.AgregarParametro("USUARIO_CREACION",DIR_EMPRESACREADO.USUARIO_CREACION)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_EMPRESACREADO_Eliminar")
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

   Public Function Listar() as DIR_EMPRESACREADOENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_DIR_EMPRESACREADO_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim DIR_EMPRESACREADO(dt.Rows.count() - 1) as DIR_EMPRESACREADOENT
           i = 0
           for each dr in dt.rows
                DIR_EMPRESACREADO(i) = New DIR_EMPRESACREADOENT()
                DIR_EMPRESACREADO(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                DIR_EMPRESACREADO(i).RUT = dr("RUT")
                DIR_EMPRESACREADO(i).DVRUT = dr("DVRUT")
                DIR_EMPRESACREADO(i).RAZONSOCIAL = dr("RAZONSOCIAL")
                DIR_EMPRESACREADO(i).REPRESENTANTELEGAL = dr("REPRESENTANTELEGAL")
                DIR_EMPRESACREADO(i).RUTREPRESENTANTELEGAL = dr("RUTREPRESENTANTELEGAL")
                DIR_EMPRESACREADO(i).DVRUTREPRESENTANTELEGAL = dr("DVRUTREPRESENTANTELEGAL")
                DIR_EMPRESACREADO(i).REGION_G = dr("REGION_G")
                DIR_EMPRESACREADO(i).PROVINCIA_G = dr("PROVINCIA_G")
                DIR_EMPRESACREADO(i).COMUNA_G = dr("COMUNA_G")
                DIR_EMPRESACREADO(i).GLOSA_COMUNA_G = dr("GLOSA_COMUNA_G")
                DIR_EMPRESACREADO(i).DIRECCION_G = dr("DIRECCION_G")
                DIR_EMPRESACREADO(i).CODA_FONO_G = dr("CODA_FONO_G")
                DIR_EMPRESACREADO(i).FONO_G = dr("FONO_G")
                DIR_EMPRESACREADO(i).CODA_FAX_G = dr("CODA_FAX_G")
                DIR_EMPRESACREADO(i).FAX_G = dr("FAX_G")
                DIR_EMPRESACREADO(i).CELULAR_G = dr("CELULAR_G")
                DIR_EMPRESACREADO(i).CASILLA = dr("CASILLA")
                DIR_EMPRESACREADO(i).EMAIL_G = dr("EMAIL_G")
                DIR_EMPRESACREADO(i).WEB_G = dr("WEB_G")
                DIR_EMPRESACREADO(i).NRO_ESTABLECIMIENTOS = dr("NRO_ESTABLECIMIENTOS")
                DIR_EMPRESACREADO(i).ACTIVIDADECONOMICA1 = dr("ACTIVIDADECONOMICA1")
                DIR_EMPRESACREADO(i).FECHA_CREACION = dr("FECHA_CREACION")
                DIR_EMPRESACREADO(i).USUARIO_CREACION = dr("USUARIO_CREACION")
                i = i + 1
           next
           return DIR_EMPRESACREADO
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function


    Public Function ListarATabla() As Data.DataTable
        Dim dt As DataTable
        Try
            Dim sp As New StoredProcedure_class("SP_DIR_EMPRESACREADO_Listar")
            dt = sp.EjecutarProcedimiento().Tables(0)

            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "ArchivoExcel, OBTENER DATOS DE DIR_EMPRESACREADO PARA POSTERIOR INSERCION"
    Public Function ObtenerDatosParaInsercion(ByVal spObtenerDatos As StoredProcedure_class, ByVal sqlCmdObtenerDatos As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow) As Data.DataRow
        Try
            Dim drResultado As Data.DataRow
            spObtenerDatos.AgregarParametro("RUT", dr("RUT"))
            spObtenerDatos.AgregarParametro("DVRUT", dr("DV_RUT"))

            drResultado = spObtenerDatos.EjecutarProcedimiento(sqlCmdObtenerDatos).Tables(0).Rows(0)
            Return drResultado
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region
#Region "CONSTRUCTORES DE LA CLASE"
    Public Sub New()

    End Sub
#End Region

End Class
