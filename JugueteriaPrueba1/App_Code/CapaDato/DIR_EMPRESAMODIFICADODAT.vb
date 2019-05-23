Imports System.Data


public class DIR_EMPRESAMODIFICADODAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval DIR_EMPRESAMODIFICADO as DIR_EMPRESAMODIFICADOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_EMPRESAMODIFICADO_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",DIR_EMPRESAMODIFICADO.ID_ENCUESTA)
           sp.AgregarParametro("ANO",DIR_EMPRESAMODIFICADO.ANO)
           sp.AgregarParametro("ID_PERIODO",DIR_EMPRESAMODIFICADO.ID_PERIODO)
           sp.AgregarParametro("RUT",DIR_EMPRESAMODIFICADO.RUT)
           sp.AgregarParametro("DVRUT",DIR_EMPRESAMODIFICADO.DVRUT)
           sp.AgregarParametro("RAZONSOCIAL",DIR_EMPRESAMODIFICADO.RAZONSOCIAL)
           sp.AgregarParametro("REPRESENTANTELEGAL",DIR_EMPRESAMODIFICADO.REPRESENTANTELEGAL)
           sp.AgregarParametro("RUTREPRESENTANTELEGAL",DIR_EMPRESAMODIFICADO.RUTREPRESENTANTELEGAL)
           sp.AgregarParametro("DVRUTREPRESENTANTELEGAL",DIR_EMPRESAMODIFICADO.DVRUTREPRESENTANTELEGAL)
           sp.AgregarParametro("REGION_G",DIR_EMPRESAMODIFICADO.REGION_G)
           sp.AgregarParametro("PROVINCIA_G",DIR_EMPRESAMODIFICADO.PROVINCIA_G)
           sp.AgregarParametro("COMUNA_G",DIR_EMPRESAMODIFICADO.COMUNA_G)
           sp.AgregarParametro("GLOSA_COMUNA_G",DIR_EMPRESAMODIFICADO.GLOSA_COMUNA_G)
           sp.AgregarParametro("DIRECCION_G",DIR_EMPRESAMODIFICADO.DIRECCION_G)
           sp.AgregarParametro("CODA_FONO_G",DIR_EMPRESAMODIFICADO.CODA_FONO_G)
           sp.AgregarParametro("FONO_G",DIR_EMPRESAMODIFICADO.FONO_G)
           sp.AgregarParametro("CODA_FAX_G",DIR_EMPRESAMODIFICADO.CODA_FAX_G)
           sp.AgregarParametro("FAX_G",DIR_EMPRESAMODIFICADO.FAX_G)
           sp.AgregarParametro("CELULAR_G",DIR_EMPRESAMODIFICADO.CELULAR_G)
           sp.AgregarParametro("CASILLA",DIR_EMPRESAMODIFICADO.CASILLA)
           sp.AgregarParametro("EMAIL_G",DIR_EMPRESAMODIFICADO.EMAIL_G)
           sp.AgregarParametro("WEB_G",DIR_EMPRESAMODIFICADO.WEB_G)
           sp.AgregarParametro("NRO_ESTABLECIMIENTOS",DIR_EMPRESAMODIFICADO.NRO_ESTABLECIMIENTOS)
           sp.AgregarParametro("ACTIVIDADECONOMICA1",DIR_EMPRESAMODIFICADO.ACTIVIDADECONOMICA1)
           sp.AgregarParametro("FECHA_LEVANTAMIENTO",DIR_EMPRESAMODIFICADO.FECHA_LEVANTAMIENTO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Sub

    
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval DIR_EMPRESAMODIFICADO as DIR_EMPRESAMODIFICADOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_EMPRESAMODIFICADO_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",DIR_EMPRESAMODIFICADO.ID_ENCUESTA)
           sp.AgregarParametro("ANO",DIR_EMPRESAMODIFICADO.ANO)
           sp.AgregarParametro("ID_PERIODO",DIR_EMPRESAMODIFICADO.ID_PERIODO)
           sp.AgregarParametro("RUT",DIR_EMPRESAMODIFICADO.RUT)
           sp.AgregarParametro("DVRUT",DIR_EMPRESAMODIFICADO.DVRUT)
           sp.AgregarParametro("RAZONSOCIAL",DIR_EMPRESAMODIFICADO.RAZONSOCIAL)
           sp.AgregarParametro("REPRESENTANTELEGAL",DIR_EMPRESAMODIFICADO.REPRESENTANTELEGAL)
           sp.AgregarParametro("RUTREPRESENTANTELEGAL",DIR_EMPRESAMODIFICADO.RUTREPRESENTANTELEGAL)
           sp.AgregarParametro("DVRUTREPRESENTANTELEGAL",DIR_EMPRESAMODIFICADO.DVRUTREPRESENTANTELEGAL)
           sp.AgregarParametro("REGION_G",DIR_EMPRESAMODIFICADO.REGION_G)
           sp.AgregarParametro("PROVINCIA_G",DIR_EMPRESAMODIFICADO.PROVINCIA_G)
           sp.AgregarParametro("COMUNA_G",DIR_EMPRESAMODIFICADO.COMUNA_G)
           sp.AgregarParametro("GLOSA_COMUNA_G",DIR_EMPRESAMODIFICADO.GLOSA_COMUNA_G)
           sp.AgregarParametro("DIRECCION_G",DIR_EMPRESAMODIFICADO.DIRECCION_G)
           sp.AgregarParametro("CODA_FONO_G",DIR_EMPRESAMODIFICADO.CODA_FONO_G)
           sp.AgregarParametro("FONO_G",DIR_EMPRESAMODIFICADO.FONO_G)
           sp.AgregarParametro("CODA_FAX_G",DIR_EMPRESAMODIFICADO.CODA_FAX_G)
           sp.AgregarParametro("FAX_G",DIR_EMPRESAMODIFICADO.FAX_G)
           sp.AgregarParametro("CELULAR_G",DIR_EMPRESAMODIFICADO.CELULAR_G)
           sp.AgregarParametro("CASILLA",DIR_EMPRESAMODIFICADO.CASILLA)
           sp.AgregarParametro("EMAIL_G",DIR_EMPRESAMODIFICADO.EMAIL_G)
           sp.AgregarParametro("WEB_G",DIR_EMPRESAMODIFICADO.WEB_G)
           sp.AgregarParametro("NRO_ESTABLECIMIENTOS",DIR_EMPRESAMODIFICADO.NRO_ESTABLECIMIENTOS)
           sp.AgregarParametro("ACTIVIDADECONOMICA1",DIR_EMPRESAMODIFICADO.ACTIVIDADECONOMICA1)
           sp.AgregarParametro("FECHA_LEVANTAMIENTO",DIR_EMPRESAMODIFICADO.FECHA_LEVANTAMIENTO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_EMPRESAMODIFICADO_Eliminar")
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

   Public Function Listar() as DIR_EMPRESAMODIFICADOENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_DIR_EMPRESAMODIFICADO_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim DIR_EMPRESAMODIFICADO(dt.Rows.count() - 1) as DIR_EMPRESAMODIFICADOENT
           i = 0
           for each dr in dt.rows
                DIR_EMPRESAMODIFICADO(i) = New DIR_EMPRESAMODIFICADOENT()
                DIR_EMPRESAMODIFICADO(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                DIR_EMPRESAMODIFICADO(i).ANO = dr("ANO")
                DIR_EMPRESAMODIFICADO(i).ID_PERIODO = dr("ID_PERIODO")
                DIR_EMPRESAMODIFICADO(i).RUT = dr("RUT")
                DIR_EMPRESAMODIFICADO(i).DVRUT = dr("DVRUT")
                DIR_EMPRESAMODIFICADO(i).RAZONSOCIAL = dr("RAZONSOCIAL")
                DIR_EMPRESAMODIFICADO(i).REPRESENTANTELEGAL = dr("REPRESENTANTELEGAL")
                DIR_EMPRESAMODIFICADO(i).RUTREPRESENTANTELEGAL = dr("RUTREPRESENTANTELEGAL")
                DIR_EMPRESAMODIFICADO(i).DVRUTREPRESENTANTELEGAL = dr("DVRUTREPRESENTANTELEGAL")
                DIR_EMPRESAMODIFICADO(i).REGION_G = dr("REGION_G")
                DIR_EMPRESAMODIFICADO(i).PROVINCIA_G = dr("PROVINCIA_G")
                DIR_EMPRESAMODIFICADO(i).COMUNA_G = dr("COMUNA_G")
                DIR_EMPRESAMODIFICADO(i).GLOSA_COMUNA_G = dr("GLOSA_COMUNA_G")
                DIR_EMPRESAMODIFICADO(i).DIRECCION_G = dr("DIRECCION_G")
                DIR_EMPRESAMODIFICADO(i).CODA_FONO_G = dr("CODA_FONO_G")
                DIR_EMPRESAMODIFICADO(i).FONO_G = dr("FONO_G")
                DIR_EMPRESAMODIFICADO(i).CODA_FAX_G = dr("CODA_FAX_G")
                DIR_EMPRESAMODIFICADO(i).FAX_G = dr("FAX_G")
                DIR_EMPRESAMODIFICADO(i).CELULAR_G = dr("CELULAR_G")
                DIR_EMPRESAMODIFICADO(i).CASILLA = dr("CASILLA")
                DIR_EMPRESAMODIFICADO(i).EMAIL_G = dr("EMAIL_G")
                DIR_EMPRESAMODIFICADO(i).WEB_G = dr("WEB_G")
                DIR_EMPRESAMODIFICADO(i).NRO_ESTABLECIMIENTOS = dr("NRO_ESTABLECIMIENTOS")
                DIR_EMPRESAMODIFICADO(i).ACTIVIDADECONOMICA1 = dr("ACTIVIDADECONOMICA1")
                DIR_EMPRESAMODIFICADO(i).FECHA_LEVANTAMIENTO = dr("FECHA_LEVANTAMIENTO")
                i = i + 1
           next
           return DIR_EMPRESAMODIFICADO
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Function

    Public Function ListarPorPeriodo(ByVal ano As Integer, ByVal periodo As Integer) As Data.DataTable
        Try

            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_DIR_EMPRESAMODIFICADO_ListarPorPeriodo")
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("PERIODO", periodo)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#END REGION

#Region "INSERTAR DESDE EMPRESA ORIGINAL O EN SU DEFECTO DESDE LOG"
    Public Sub Insertar(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer)
        Try
            'Dim sp As New StoredProcedure_class("SP_DIR_EMPRESAMODIFICADO_Insertar")
            sp.AgregarParametro("ID_ENCUESTA", dr("ID_ENCUESTA"))
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("ID_PERIODO", periodo)
            sp.AgregarParametro("RUT", dr("RUT"))
            sp.AgregarParametro("DVRUT", dr("DVRUT"))
            sp.AgregarParametro("RAZONSOCIAL", dr("RAZONSOCIAL"))
            sp.AgregarParametro("REPRESENTANTELEGAL", dr("REPRESENTANTELEGAL"))
            sp.AgregarParametro("RUTREPRESENTANTELEGAL", dr("RUTREPRESENTANTELEGAL"))
            sp.AgregarParametro("DVRUTREPRESENTANTELEGAL", dr("DVRUTREPRESENTANTELEGAL"))
            sp.AgregarParametro("REGION_G", dr("REGION_G"))
            sp.AgregarParametro("PROVINCIA_G", dr("PROVINCIA_G"))
            sp.AgregarParametro("COMUNA_G", dr("COMUNA_G"))
            sp.AgregarParametro("GLOSA_COMUNA_G", dr("GLOSA_COMUNA_G"))
            sp.AgregarParametro("DIRECCION_G", dr("DIRECCION_G"))
            sp.AgregarParametro("CODA_FONO_G", dr("CODA_FONO_G"))
            sp.AgregarParametro("FONO_G", dr("FONO_G"))
            sp.AgregarParametro("CODA_FAX_G", dr("CODA_FAX_G"))
            sp.AgregarParametro("FAX_G", dr("FAX_G"))
            sp.AgregarParametro("CELULAR_G", dr("CELULAR_G"))
            sp.AgregarParametro("CASILLA", dr("CASILLA"))
            sp.AgregarParametro("EMAIL_G", dr("EMAIL_G"))
            sp.AgregarParametro("WEB_G", dr("WEB_G"))
            sp.AgregarParametro("NRO_ESTABLECIMIENTOS", dr("NRO_ESTABLECIMIENTOS"))
            sp.AgregarParametro("ACTIVIDADECONOMICA1", dr("ACTIVIDADECONOMICA1"))
            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "ArchivoExcel, OBTENER DATOS DE DIR_EMPRESAMODIFICADO PARA POSTERIOR INSERCION"
    Public Function ObtenerDatosParaInsercion(ByVal spObtenerDatos As StoredProcedure_class, ByVal sqlCmdObtenerDatos As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer) As Data.DataRow
        Try
            Dim drResultado As Data.DataRow
            spObtenerDatos.AgregarParametro("RUT", dr("RUT"))
            spObtenerDatos.AgregarParametro("DVRUT", dr("DV_RUT"))
            spObtenerDatos.AgregarParametro("PERIODO", periodo)
            spObtenerDatos.AgregarParametro("ANO", ano)

            drResultado = spObtenerDatos.EjecutarProcedimiento(sqlCmdObtenerDatos).Tables(0).Rows(0)
            Return drResultado
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "OBTENER DATO EMPRESA POR UN PERIODO A PARTIR DEL RUT"
    Public Function ObtenerDatoEmpresaRutPeriodo(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal rut As Integer, ByVal periodo As Integer, ByVal ano As Integer) As Data.DataRow
        Try
            sp.AgregarParametro("RUT", rut)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            Return sp.EjecutarProcedimiento(sqlCmd).Tables(0).Rows(0)
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
