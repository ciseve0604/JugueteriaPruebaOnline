Imports System.Data


public class DIR_MUESTRAESTABLECIMIENTODAT

#REGION "METODO INGRESO"

    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodoInicio As Integer, ByVal periodoFin As Integer, ByVal anoInicio As Integer, ByVal anoFin As Integer)
        Try
            'Dim sp As New StoredProcedure_class("SP_DIR_MUESTRAESTABLECIMIENTO_Insertar")
            sp.AgregarParametro("ID_ENCUESTA", 1)
            sp.AgregarParametro("ROL", dr("ROL"))
            sp.AgregarParametro("DVROL", dr("DVROL"))
            'sp.AgregarParametro("PERIODO_INICIO", dr("PERIODO_INICIO"))
            'sp.AgregarParametro("PERIODO_FIN", dr("PERIODO_FIN"))
            'sp.AgregarParametro("ANO_INICIO", dr("ANIO_INICIO"))
            'sp.AgregarParametro("ANO_FIN", dr("ANIO_FIN"))
            sp.AgregarParametro("PERIODO_INICIO", periodoInicio)
            sp.AgregarParametro("PERIODO_FIN", periodoFin)
            sp.AgregarParametro("ANO_INICIO", anoInicio)
            sp.AgregarParametro("ANO_FIN", anoFin)
            sp.AgregarParametro("RUT", dr("RUT"))
            sp.AgregarParametro("NUI", dr("NUI"))
            sp.AgregarParametro("DVNUI", dr("DvNui"))
            sp.AgregarParametro("CIIU", dr("CIIU"))
            sp.AgregarParametro("REGION_E", CInt(dr("Region_E")))
            sp.AgregarParametro("PROVINCIA_E", CInt(dr("Provincia_E")))
            sp.AgregarParametro("COMUNA_E", CInt(dr("Comuna_E")))
            sp.AgregarParametro("GLOSA_COMUNA_E", dr("Glosa_Comuna_E"))
            sp.AgregarParametro("CALLE_E", dr("Calle_E"))
            sp.AgregarParametro("NRO_E", dr("Nro_E"))
            sp.AgregarParametro("NRO_LOCAL_E", IIf(dr("Nro_local_E") Is DBNull.Value, "", dr("Nro_local_E")))
            sp.AgregarParametro("CODA_FONO_E", IIf(dr("Coda_fono_E") Is DBNull.Value, "00", dr("Coda_fono_E")))
            sp.AgregarParametro("FONO_E", IIf(dr("Fono_E") Is DBNull.Value, "", dr("Fono_E")))
            sp.AgregarParametro("CODA_FAX_E", IIf(dr("Coda_Fax_E") Is DBNull.Value, "00", dr("Coda_Fax_E")))
            sp.AgregarParametro("FAX_E", IIf(dr("Fax_E") Is DBNull.Value, "", dr("Fax_E")))
            sp.AgregarParametro("EMAIL_E", IIf(dr("Email_E") Is DBNull.Value, "", dr("Email_E")))
            sp.AgregarParametro("WEB_E", IIf(dr("Web_E") Is DBNull.Value, "", dr("Web_E")))
            sp.AgregarParametro("CASILLA_COMERCIAL", IIf(dr("Casilla_Comercial") Is DBNull.Value, "", dr("Casilla_Comercial")))
            sp.AgregarParametro("NOMBREESTABLECIMIENTO", dr("NombreEstablecimiento"))
            sp.AgregarParametro("TIPO_ESTABLECIMIENTO", dr("Tipo_Establecimiento"))
            sp.AgregarParametro("TIPO_FUNCIONAMIENTO", dr("Tipo_Funcionamiento"))
            sp.AgregarParametro("CLASE", dr("Clase"))
            sp.AgregarParametro("EXROL", IIf(dr("ExRol") Is DBNull.Value, 0, dr("ExRol")))
            sp.AgregarParametro("HABITACIONES_UNIDADES_HABITACIONALES", dr("Habitaciones_unidades_habitacionales"))
            sp.AgregarParametro("HABITACIONES_CAPACIDAD_MAXIMA", dr("Habitaciones_capacidad_maxima"))
            sp.AgregarParametro("CABANAS_UNIDADES_HABITACIONALES", dr("Cabanas_unidades_habitacionales"))
            sp.AgregarParametro("CABANAS_CAPACIDAD_MAXIMA", dr("Cabanas_capacidad_maxima"))
            sp.AgregarParametro("DEPARTAMENTOS_UNIDADES_HABITACIONALES", dr("Departamentos_unidades_habitacionales"))
            sp.AgregarParametro("DEPARTAMENTOS_CAPACIDAD_MAXIMA", dr("Departamentos_capacidad_maxima"))
            sp.AgregarParametro("SITIOSDECAMPING_UNIDADES_HABITACIONALES", dr("SitiosDeCamping_unidades_habitacionales"))
            sp.AgregarParametro("SITIOSDECAMPING_CAPACIDAD_MAXIMA", dr("SitiosDeCamping_capacidad_maxima"))
            sp.AgregarParametro("TOTAL_UNIDADES_HABITACIONALES", dr("Total_unidades_habitacionales"))
            sp.AgregarParametro("TOTAL_CAPACIDAD_MAXIMA", dr("Total_capacidad_maxima"))
            sp.AgregarParametro("PERSONAL_OCUPADO_PERMANENTE_HOMBRE", dr("Personal_ocupado_permanente_hombre"))
            sp.AgregarParametro("PERSONAL_OCUPADO_PERMANENTE_MUJER", dr("Personal_ocupado_permanente_mujer"))
            sp.AgregarParametro("PERSONAL_OCUPADO_EVENTUAL_HOMBRE", dr("Personal_ocupado_eventual_hombre"))
            sp.AgregarParametro("PERSONAL_OCUPADO_EVENTUAL_MUJER", dr("Personal_ocupado_eventual_mujer"))
            sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO_HOMBRE", dr("Total_personal_ocupado_hombre"))
            sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO_MUJER", dr("Total_personal_ocupado_mujer"))
            sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO", dr("Total_personal_ocupado"))
            'sp.AgregarParametro("FECHA_CREACION_MUESTRA_E", DIR_MUESTRAESTABLECIMIENTO.FECHA_CREACION_MUESTRA_E)
            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval DIR_MUESTRAESTABLECIMIENTO as DIR_MUESTRAESTABLECIMIENTOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_MUESTRAESTABLECIMIENTO_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",DIR_MUESTRAESTABLECIMIENTO.ID_ENCUESTA)
           sp.AgregarParametro("ROL",DIR_MUESTRAESTABLECIMIENTO.ROL)
           sp.AgregarParametro("DVROL",DIR_MUESTRAESTABLECIMIENTO.DVROL)
           sp.AgregarParametro("PERIODO_INICIO",DIR_MUESTRAESTABLECIMIENTO.PERIODO_INICIO)
           sp.AgregarParametro("PERIODO_FIN",DIR_MUESTRAESTABLECIMIENTO.PERIODO_FIN)
           sp.AgregarParametro("ANO_INICIO",DIR_MUESTRAESTABLECIMIENTO.ANO_INICIO)
           sp.AgregarParametro("ANO_FIN",DIR_MUESTRAESTABLECIMIENTO.ANO_FIN)
           sp.AgregarParametro("RUT",DIR_MUESTRAESTABLECIMIENTO.RUT)
           sp.AgregarParametro("NUI",DIR_MUESTRAESTABLECIMIENTO.NUI)
           sp.AgregarParametro("DVNUI",DIR_MUESTRAESTABLECIMIENTO.DVNUI)
           sp.AgregarParametro("CIIU",DIR_MUESTRAESTABLECIMIENTO.CIIU)
           sp.AgregarParametro("REGION_E",DIR_MUESTRAESTABLECIMIENTO.REGION_E)
           sp.AgregarParametro("PROVINCIA_E",DIR_MUESTRAESTABLECIMIENTO.PROVINCIA_E)
           sp.AgregarParametro("COMUNA_E",DIR_MUESTRAESTABLECIMIENTO.COMUNA_E)
           sp.AgregarParametro("GLOSA_COMUNA_E",DIR_MUESTRAESTABLECIMIENTO.GLOSA_COMUNA_E)
           sp.AgregarParametro("CALLE_E",DIR_MUESTRAESTABLECIMIENTO.CALLE_E)
           sp.AgregarParametro("NRO_E",DIR_MUESTRAESTABLECIMIENTO.NRO_E)
           sp.AgregarParametro("NRO_LOCAL_E",DIR_MUESTRAESTABLECIMIENTO.NRO_LOCAL_E)
           sp.AgregarParametro("CODA_FONO_E",DIR_MUESTRAESTABLECIMIENTO.CODA_FONO_E)
           sp.AgregarParametro("FONO_E",DIR_MUESTRAESTABLECIMIENTO.FONO_E)
           sp.AgregarParametro("CODA_FAX_E",DIR_MUESTRAESTABLECIMIENTO.CODA_FAX_E)
           sp.AgregarParametro("FAX_E",DIR_MUESTRAESTABLECIMIENTO.FAX_E)
           sp.AgregarParametro("EMAIL_E",DIR_MUESTRAESTABLECIMIENTO.EMAIL_E)
           sp.AgregarParametro("WEB_E",DIR_MUESTRAESTABLECIMIENTO.WEB_E)
           sp.AgregarParametro("CASILLA_COMERCIAL",DIR_MUESTRAESTABLECIMIENTO.CASILLA_COMERCIAL)
           sp.AgregarParametro("NOMBREESTABLECIMIENTO",DIR_MUESTRAESTABLECIMIENTO.NOMBREESTABLECIMIENTO)
           sp.AgregarParametro("TIPO_ESTABLECIMIENTO",DIR_MUESTRAESTABLECIMIENTO.TIPO_ESTABLECIMIENTO)
            sp.AgregarParametro("TIPO_FUNCIONAMIENTO", DIR_MUESTRAESTABLECIMIENTO.TIPO_FUNCIONAMIENTO)
            sp.AgregarParametro("CLASE", DIR_MUESTRAESTABLECIMIENTO.CLASE)
           sp.AgregarParametro("EXROL",DIR_MUESTRAESTABLECIMIENTO.EXROL)
           sp.AgregarParametro("HABITACIONES_UNIDADES_HABITACIONALES",DIR_MUESTRAESTABLECIMIENTO.HABITACIONES_UNIDADES_HABITACIONALES)
           sp.AgregarParametro("HABITACIONES_CAPACIDAD_MAXIMA",DIR_MUESTRAESTABLECIMIENTO.HABITACIONES_CAPACIDAD_MAXIMA)
           sp.AgregarParametro("CABANAS_UNIDADES_HABITACIONALES",DIR_MUESTRAESTABLECIMIENTO.CABANAS_UNIDADES_HABITACIONALES)
           sp.AgregarParametro("CABANAS_CAPACIDAD_MAXIMA",DIR_MUESTRAESTABLECIMIENTO.CABANAS_CAPACIDAD_MAXIMA)
           sp.AgregarParametro("DEPARTAMENTOS_UNIDADES_HABITACIONALES",DIR_MUESTRAESTABLECIMIENTO.DEPARTAMENTOS_UNIDADES_HABITACIONALES)
           sp.AgregarParametro("DEPARTAMENTOS_CAPACIDAD_MAXIMA",DIR_MUESTRAESTABLECIMIENTO.DEPARTAMENTOS_CAPACIDAD_MAXIMA)
           sp.AgregarParametro("SITIOSDECAMPING_UNIDADES_HABITACIONALES",DIR_MUESTRAESTABLECIMIENTO.SITIOSDECAMPING_UNIDADES_HABITACIONALES)
           sp.AgregarParametro("SITIOSDECAMPING_CAPACIDAD_MAXIMA",DIR_MUESTRAESTABLECIMIENTO.SITIOSDECAMPING_CAPACIDAD_MAXIMA)
           sp.AgregarParametro("TOTAL_UNIDADES_HABITACIONALES",DIR_MUESTRAESTABLECIMIENTO.TOTAL_UNIDADES_HABITACIONALES)
           sp.AgregarParametro("TOTAL_CAPACIDAD_MAXIMA",DIR_MUESTRAESTABLECIMIENTO.TOTAL_CAPACIDAD_MAXIMA)
           sp.AgregarParametro("PERSONAL_OCUPADO_PERMANENTE_HOMBRE",DIR_MUESTRAESTABLECIMIENTO.PERSONAL_OCUPADO_PERMANENTE_HOMBRE)
           sp.AgregarParametro("PERSONAL_OCUPADO_PERMANENTE_MUJER",DIR_MUESTRAESTABLECIMIENTO.PERSONAL_OCUPADO_PERMANENTE_MUJER)
           sp.AgregarParametro("PERSONAL_OCUPADO_EVENTUAL_HOMBRE",DIR_MUESTRAESTABLECIMIENTO.PERSONAL_OCUPADO_EVENTUAL_HOMBRE)
           sp.AgregarParametro("PERSONAL_OCUPADO_EVENTUAL_MUJER",DIR_MUESTRAESTABLECIMIENTO.PERSONAL_OCUPADO_EVENTUAL_MUJER)
           sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO_HOMBRE",DIR_MUESTRAESTABLECIMIENTO.TOTAL_PERSONAL_OCUPADO_HOMBRE)
           sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO_MUJER",DIR_MUESTRAESTABLECIMIENTO.TOTAL_PERSONAL_OCUPADO_MUJER)
           sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO",DIR_MUESTRAESTABLECIMIENTO.TOTAL_PERSONAL_OCUPADO)
           sp.AgregarParametro("FECHA_CREACION_MUESTRA_E",DIR_MUESTRAESTABLECIMIENTO.FECHA_CREACION_MUESTRA_E)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_MUESTRAESTABLECIMIENTO_Eliminar")
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

   Public Function Listar() as DIR_MUESTRAESTABLECIMIENTOENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_DIR_MUESTRAESTABLECIMIENTO_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim DIR_MUESTRAESTABLECIMIENTO(dt.Rows.count() - 1) as DIR_MUESTRAESTABLECIMIENTOENT
           i = 0
           for each dr in dt.rows
                DIR_MUESTRAESTABLECIMIENTO(i) = New DIR_MUESTRAESTABLECIMIENTOENT()
                DIR_MUESTRAESTABLECIMIENTO(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                DIR_MUESTRAESTABLECIMIENTO(i).ROL = dr("ROL")
                DIR_MUESTRAESTABLECIMIENTO(i).DVROL = dr("DVROL")
                DIR_MUESTRAESTABLECIMIENTO(i).PERIODO_INICIO = dr("PERIODO_INICIO")
                DIR_MUESTRAESTABLECIMIENTO(i).PERIODO_FIN = dr("PERIODO_FIN")
                DIR_MUESTRAESTABLECIMIENTO(i).ANO_INICIO = dr("ANO_INICIO")
                DIR_MUESTRAESTABLECIMIENTO(i).ANO_FIN = dr("ANO_FIN")
                DIR_MUESTRAESTABLECIMIENTO(i).RUT = dr("RUT")
                DIR_MUESTRAESTABLECIMIENTO(i).NUI = dr("NUI")
                DIR_MUESTRAESTABLECIMIENTO(i).DVNUI = dr("DVNUI")
                DIR_MUESTRAESTABLECIMIENTO(i).CIIU = dr("CIIU")
                DIR_MUESTRAESTABLECIMIENTO(i).REGION_E = dr("REGION_E")
                DIR_MUESTRAESTABLECIMIENTO(i).PROVINCIA_E = dr("PROVINCIA_E")
                DIR_MUESTRAESTABLECIMIENTO(i).COMUNA_E = dr("COMUNA_E")
                DIR_MUESTRAESTABLECIMIENTO(i).GLOSA_COMUNA_E = dr("GLOSA_COMUNA_E")
                DIR_MUESTRAESTABLECIMIENTO(i).CALLE_E = dr("CALLE_E")
                DIR_MUESTRAESTABLECIMIENTO(i).NRO_E = dr("NRO_E")
                DIR_MUESTRAESTABLECIMIENTO(i).NRO_LOCAL_E = dr("NRO_LOCAL_E")
                DIR_MUESTRAESTABLECIMIENTO(i).CODA_FONO_E = dr("CODA_FONO_E")
                DIR_MUESTRAESTABLECIMIENTO(i).FONO_E = dr("FONO_E")
                DIR_MUESTRAESTABLECIMIENTO(i).CODA_FAX_E = dr("CODA_FAX_E")
                DIR_MUESTRAESTABLECIMIENTO(i).FAX_E = dr("FAX_E")
                DIR_MUESTRAESTABLECIMIENTO(i).EMAIL_E = dr("EMAIL_E")
                DIR_MUESTRAESTABLECIMIENTO(i).WEB_E = dr("WEB_E")
                DIR_MUESTRAESTABLECIMIENTO(i).CASILLA_COMERCIAL = dr("CASILLA_COMERCIAL")
                DIR_MUESTRAESTABLECIMIENTO(i).NOMBREESTABLECIMIENTO = dr("NOMBREESTABLECIMIENTO")
                DIR_MUESTRAESTABLECIMIENTO(i).TIPO_ESTABLECIMIENTO = dr("TIPO_ESTABLECIMIENTO")
                DIR_MUESTRAESTABLECIMIENTO(i).TIPO_FUNCIONAMIENTO = dr("TIPO_FUNCIONAMIENTO")
                DIR_MUESTRAESTABLECIMIENTO(i).CLASE = dr("clase")
                DIR_MUESTRAESTABLECIMIENTO(i).EXROL = dr("EXROL")
                DIR_MUESTRAESTABLECIMIENTO(i).HABITACIONES_UNIDADES_HABITACIONALES = dr("HABITACIONES_UNIDADES_HABITACIONALES")
                DIR_MUESTRAESTABLECIMIENTO(i).HABITACIONES_CAPACIDAD_MAXIMA = dr("HABITACIONES_CAPACIDAD_MAXIMA")
                DIR_MUESTRAESTABLECIMIENTO(i).CABANAS_UNIDADES_HABITACIONALES = dr("CABANAS_UNIDADES_HABITACIONALES")
                DIR_MUESTRAESTABLECIMIENTO(i).CABANAS_CAPACIDAD_MAXIMA = dr("CABANAS_CAPACIDAD_MAXIMA")
                DIR_MUESTRAESTABLECIMIENTO(i).DEPARTAMENTOS_UNIDADES_HABITACIONALES = dr("DEPARTAMENTOS_UNIDADES_HABITACIONALES")
                DIR_MUESTRAESTABLECIMIENTO(i).DEPARTAMENTOS_CAPACIDAD_MAXIMA = dr("DEPARTAMENTOS_CAPACIDAD_MAXIMA")
                DIR_MUESTRAESTABLECIMIENTO(i).SITIOSDECAMPING_UNIDADES_HABITACIONALES = dr("SITIOSDECAMPING_UNIDADES_HABITACIONALES")
                DIR_MUESTRAESTABLECIMIENTO(i).SITIOSDECAMPING_CAPACIDAD_MAXIMA = dr("SITIOSDECAMPING_CAPACIDAD_MAXIMA")
                DIR_MUESTRAESTABLECIMIENTO(i).TOTAL_UNIDADES_HABITACIONALES = dr("TOTAL_UNIDADES_HABITACIONALES")
                DIR_MUESTRAESTABLECIMIENTO(i).TOTAL_CAPACIDAD_MAXIMA = dr("TOTAL_CAPACIDAD_MAXIMA")
                DIR_MUESTRAESTABLECIMIENTO(i).PERSONAL_OCUPADO_PERMANENTE_HOMBRE = dr("PERSONAL_OCUPADO_PERMANENTE_HOMBRE")
                DIR_MUESTRAESTABLECIMIENTO(i).PERSONAL_OCUPADO_PERMANENTE_MUJER = dr("PERSONAL_OCUPADO_PERMANENTE_MUJER")
                DIR_MUESTRAESTABLECIMIENTO(i).PERSONAL_OCUPADO_EVENTUAL_HOMBRE = dr("PERSONAL_OCUPADO_EVENTUAL_HOMBRE")
                DIR_MUESTRAESTABLECIMIENTO(i).PERSONAL_OCUPADO_EVENTUAL_MUJER = dr("PERSONAL_OCUPADO_EVENTUAL_MUJER")
                DIR_MUESTRAESTABLECIMIENTO(i).TOTAL_PERSONAL_OCUPADO_HOMBRE = dr("TOTAL_PERSONAL_OCUPADO_HOMBRE")
                DIR_MUESTRAESTABLECIMIENTO(i).TOTAL_PERSONAL_OCUPADO_MUJER = dr("TOTAL_PERSONAL_OCUPADO_MUJER")
                DIR_MUESTRAESTABLECIMIENTO(i).TOTAL_PERSONAL_OCUPADO = dr("TOTAL_PERSONAL_OCUPADO")
                DIR_MUESTRAESTABLECIMIENTO(i).FECHA_CREACION_MUESTRA_E = dr("FECHA_CREACION_MUESTRA_E")
                i = i + 1
           next
           return DIR_MUESTRAESTABLECIMIENTO
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#End Region

#Region "LISTAR PANEL LEVANTAMIENTO POR SISTEMA"
    Public Function ListarPanelLevantamiento(ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim sp As New StoredProcedure_class("SP_DIR_MUESTRAESTABLECIMIENTO_RolRutEstadoPorPeriodo")
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            Return sp.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region


#Region "LISTAR MUESTRA ESTABLECIMIENTO POR PERIODO EN ESPECÍFICO"
    Public Function ListarMuestraPorPeriodo(ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim sp As New StoredProcedure_class("SP_DIR_MUESTRAESTABLECIMIENTO_ListarMuestraPorPeriodo")
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            Return sp.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "LISTAR MUESTRA ESTABLECIMIENTO POR PERIODO EN ESPECÍFICO"
    Public Function ComprobarMuestra(ByVal periodoInicio As Integer, ByVal anoInicio As Integer) As Data.DataTable
        Try
            Dim sp As New StoredProcedure_class("SP_DIR_MUESTRAESTABLECIMIENTO_ComprobarMuestra")
            sp.AgregarParametro("PERIODO_INICIO_ACTUAL", periodoInicio)
            sp.AgregarParametro("ANO_INICIO_ACTUAL", anoInicio)
            Return sp.EjecutarProcedimiento().Tables(0)
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
