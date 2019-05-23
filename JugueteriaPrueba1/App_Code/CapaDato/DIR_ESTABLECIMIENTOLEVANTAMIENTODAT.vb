Imports System.Data


public class DIR_ESTABLECIMIENTOLEVANTAMIENTODAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval DIR_ESTABLECIMIENTOLEVANTAMIENTO as DIR_ESTABLECIMIENTOLEVANTAMIENTOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_ESTABLECIMIENTOLEVANTAMIENTO_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",DIR_ESTABLECIMIENTOLEVANTAMIENTO.ID_ENCUESTA)
           sp.AgregarParametro("ROL",DIR_ESTABLECIMIENTOLEVANTAMIENTO.ROL)
           sp.AgregarParametro("DVROL",DIR_ESTABLECIMIENTOLEVANTAMIENTO.DVROL)
           sp.AgregarParametro("ANO",DIR_ESTABLECIMIENTOLEVANTAMIENTO.ANO)
           sp.AgregarParametro("PERIODO",DIR_ESTABLECIMIENTOLEVANTAMIENTO.PERIODO)
           sp.AgregarParametro("RUT",DIR_ESTABLECIMIENTOLEVANTAMIENTO.RUT)
           sp.AgregarParametro("NUI",DIR_ESTABLECIMIENTOLEVANTAMIENTO.NUI)
           sp.AgregarParametro("DVNUI",DIR_ESTABLECIMIENTOLEVANTAMIENTO.DVNUI)
           sp.AgregarParametro("CIIU",DIR_ESTABLECIMIENTOLEVANTAMIENTO.CIIU)
           sp.AgregarParametro("REGION_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.REGION_E)
           sp.AgregarParametro("PROVINCIA_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.PROVINCIA_E)
           sp.AgregarParametro("COMUNA_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.COMUNA_E)
           sp.AgregarParametro("GLOSA_COMUNA_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.GLOSA_COMUNA_E)
           sp.AgregarParametro("CALLE_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.CALLE_E)
           sp.AgregarParametro("NRO_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.NRO_E)
           sp.AgregarParametro("NRO_LOCAL_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.NRO_LOCAL_E)
           sp.AgregarParametro("CODA_FONO_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.CODA_FONO_E)
           sp.AgregarParametro("FONO_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.FONO_E)
           sp.AgregarParametro("CODA_FAX_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.CODA_FAX_E)
           sp.AgregarParametro("FAX_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.FAX_E)
           sp.AgregarParametro("EMAIL_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.EMAIL_E)
           sp.AgregarParametro("WEB_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.WEB_E)
           sp.AgregarParametro("CASILLA_COMERCIAL",DIR_ESTABLECIMIENTOLEVANTAMIENTO.CASILLA_COMERCIAL)
           sp.AgregarParametro("NOMBREESTABLECIMIENTO",DIR_ESTABLECIMIENTOLEVANTAMIENTO.NOMBREESTABLECIMIENTO)
           sp.AgregarParametro("TIPO_ESTABLECIMIENTO",DIR_ESTABLECIMIENTOLEVANTAMIENTO.TIPO_ESTABLECIMIENTO)
           sp.AgregarParametro("TIPO_FUNCIONAMIENTO",DIR_ESTABLECIMIENTOLEVANTAMIENTO.TIPO_FUNCIONAMIENTO)
            sp.AgregarParametro("CLASE", DIR_ESTABLECIMIENTOLEVANTAMIENTO.CLASE)
           sp.AgregarParametro("EXROL",DIR_ESTABLECIMIENTOLEVANTAMIENTO.EXROL)
           sp.AgregarParametro("HABITACIONES_UNIDADES_HABITACIONALES",DIR_ESTABLECIMIENTOLEVANTAMIENTO.HABITACIONES_UNIDADES_HABITACIONALES)
           sp.AgregarParametro("HABITACIONES_CAPACIDAD_MAXIMA",DIR_ESTABLECIMIENTOLEVANTAMIENTO.HABITACIONES_CAPACIDAD_MAXIMA)
           sp.AgregarParametro("CABANAS_UNIDADES_HABITACIONALES",DIR_ESTABLECIMIENTOLEVANTAMIENTO.CABANAS_UNIDADES_HABITACIONALES)
           sp.AgregarParametro("CABANAS_CAPACIDAD_MAXIMA",DIR_ESTABLECIMIENTOLEVANTAMIENTO.CABANAS_CAPACIDAD_MAXIMA)
            sp.AgregarParametro("DEPARTAMENTOS_UNIDADES_HABITACIONALES", DIR_ESTABLECIMIENTOLEVANTAMIENTO.DEPARTAMENTOS_UNIDADES_HABITACIONALES)
            sp.AgregarParametro("DEPARTAMENTOS_CAPACIDAD_MAXIMA", DIR_ESTABLECIMIENTOLEVANTAMIENTO.DEPARTAMENTOS_CAPACIDAD_MAXIMA)
            sp.AgregarParametro("SITIOSDECAMPING_UNIDADES_HABITACIONALES", DIR_ESTABLECIMIENTOLEVANTAMIENTO.SITIOSDECAMPING_UNIDADES_HABITACIONALES)
            sp.AgregarParametro("SITIOSDECAMPING_CAPACIDAD_MAXIMA", DIR_ESTABLECIMIENTOLEVANTAMIENTO.SITIOSDECAMPING_CAPACIDAD_MAXIMA)
            sp.AgregarParametro("TOTAL_UNIDADES_HABITACIONALES", DIR_ESTABLECIMIENTOLEVANTAMIENTO.TOTAL_UNIDADES_HABITACIONALES)
           sp.AgregarParametro("TOTAL_CAPACIDAD_MAXIMA",DIR_ESTABLECIMIENTOLEVANTAMIENTO.TOTAL_CAPACIDAD_MAXIMA)
           sp.AgregarParametro("PERSONAL_OCUPADO_PERMANENTE_HOMBRE",DIR_ESTABLECIMIENTOLEVANTAMIENTO.PERSONAL_OCUPADO_PERMANENTE_HOMBRE)
           sp.AgregarParametro("PERSONAL_OCUPADO_PERMANENTE_MUJER",DIR_ESTABLECIMIENTOLEVANTAMIENTO.PERSONAL_OCUPADO_PERMANENTE_MUJER)
           sp.AgregarParametro("PERSONAL_OCUPADO_EVENTUAL_HOMBRE",DIR_ESTABLECIMIENTOLEVANTAMIENTO.PERSONAL_OCUPADO_EVENTUAL_HOMBRE)
           sp.AgregarParametro("PERSONAL_OCUPADO_EVENTUAL_MUJER",DIR_ESTABLECIMIENTOLEVANTAMIENTO.PERSONAL_OCUPADO_EVENTUAL_MUJER)
           sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO_HOMBRE",DIR_ESTABLECIMIENTOLEVANTAMIENTO.TOTAL_PERSONAL_OCUPADO_HOMBRE)
           sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO_MUJER",DIR_ESTABLECIMIENTOLEVANTAMIENTO.TOTAL_PERSONAL_OCUPADO_MUJER)
            sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO", DIR_ESTABLECIMIENTOLEVANTAMIENTO.TOTAL_PERSONAL_OCUPADO)
            sp.AgregarParametro("FECHA_LEVANTAMIENTO", DIR_ESTABLECIMIENTOLEVANTAMIENTO.FECHA_LEVANTAMIENTO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Sub

    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            'Dim sp As New StoredProcedure_class("SP_DIR_ESTABLECIMIENTOLEVANTAMIENTO_Insertar")
            sp.AgregarParametro("ID_ENCUESTA", dr("ID_ENCUESTA"))
            sp.AgregarParametro("ROL", dr("ROL"))
            sp.AgregarParametro("DVROL", dr("DVROL"))
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("RUT", dr("RUT"))
            sp.AgregarParametro("NUI", dr("NUI"))
            sp.AgregarParametro("DVNUI", dr("DVNUI"))
            sp.AgregarParametro("CIIU", dr("CIIU"))
            sp.AgregarParametro("REGION_E", dr("REGION_E"))
            sp.AgregarParametro("PROVINCIA_E", dr("PROVINCIA_E"))
            sp.AgregarParametro("COMUNA_E", dr("COMUNA_E"))
            sp.AgregarParametro("GLOSA_COMUNA_E", dr("GLOSA_COMUNA_E"))
            sp.AgregarParametro("CALLE_E", dr("CALLE_E"))
            sp.AgregarParametro("NRO_E", dr("NRO_E"))
            sp.AgregarParametro("NRO_LOCAL_E", dr("NRO_LOCAL_E"))
            sp.AgregarParametro("CODA_FONO_E", dr("CODA_FONO_E"))
            sp.AgregarParametro("FONO_E", dr("FONO_E"))
            sp.AgregarParametro("CODA_FAX_E", dr("CODA_FAX_E"))
            sp.AgregarParametro("FAX_E", dr("FAX_E"))
            sp.AgregarParametro("EMAIL_E", dr("EMAIL_E"))
            sp.AgregarParametro("WEB_E", dr("WEB_E"))
            sp.AgregarParametro("CASILLA_COMERCIAL", dr("CASILLA_COMERCIAL"))
            sp.AgregarParametro("NOMBREESTABLECIMIENTO", dr("NOMBREESTABLECIMIENTO"))
            sp.AgregarParametro("TIPO_ESTABLECIMIENTO", dr("TIPO_ESTABLECIMIENTO"))
            sp.AgregarParametro("TIPO_FUNCIONAMIENTO", dr("TIPO_FUNCIONAMIENTO"))
            sp.AgregarParametro("CLASE", dr("CLASE"))
            sp.AgregarParametro("EXROL", dr("EXROL"))
            sp.AgregarParametro("HABITACIONES_UNIDADES_HABITACIONALES", dr("HABITACIONES_UNIDADES_HABITACIONALES"))
            sp.AgregarParametro("HABITACIONES_CAPACIDAD_MAXIMA", dr("HABITACIONES_CAPACIDAD_MAXIMA"))
            sp.AgregarParametro("CABANAS_UNIDADES_HABITACIONALES", dr("CABANAS_UNIDADES_HABITACIONALES"))
            sp.AgregarParametro("CABANAS_CAPACIDAD_MAXIMA", dr("CABANAS_CAPACIDAD_MAXIMA"))
            sp.AgregarParametro("DEPARTAMENTOS_UNIDADES_HABITACIONALES", dr("DEPARTAMENTOS_UNIDADES_HABITACIONALES"))
            sp.AgregarParametro("DEPARTAMENTOS_CAPACIDAD_MAXIMA", dr("DEPARTAMENTOS_CAPACIDAD_MAXIMA"))
            sp.AgregarParametro("SITIOSDECAMPING_UNIDADES_HABITACIONALES", dr("SITIOSDECAMPING_UNIDADES_HABITACIONALES"))
            sp.AgregarParametro("SITIOSDECAMPING_CAPACIDAD_MAXIMA", dr("SITIOSDECAMPING_CAPACIDAD_MAXIMA"))
            sp.AgregarParametro("TOTAL_UNIDADES_HABITACIONALES", dr("TOTAL_UNIDADES_HABITACIONALES"))
            sp.AgregarParametro("TOTAL_CAPACIDAD_MAXIMA", dr("TOTAL_CAPACIDAD_MAXIMA"))
            sp.AgregarParametro("PERSONAL_OCUPADO_PERMANENTE_HOMBRE", dr("PERSONAL_OCUPADO_PERMANENTE_HOMBRE"))
            sp.AgregarParametro("PERSONAL_OCUPADO_PERMANENTE_MUJER", dr("PERSONAL_OCUPADO_PERMANENTE_MUJER"))
            sp.AgregarParametro("PERSONAL_OCUPADO_EVENTUAL_HOMBRE", dr("PERSONAL_OCUPADO_EVENTUAL_HOMBRE"))
            sp.AgregarParametro("PERSONAL_OCUPADO_EVENTUAL_MUJER", dr("PERSONAL_OCUPADO_EVENTUAL_MUJER"))
            sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO_HOMBRE", dr("TOTAL_PERSONAL_OCUPADO_HOMBRE"))
            sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO_MUJER", dr("TOTAL_PERSONAL_OCUPADO_MUJER"))
            sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO", dr("TOTAL_PERSONAL_OCUPADO"))
            sp.AgregarParametro("FECHA_LEVANTAMIENTO", "")
            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval DIR_ESTABLECIMIENTOLEVANTAMIENTO as DIR_ESTABLECIMIENTOLEVANTAMIENTOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_ESTABLECIMIENTOLEVANTAMIENTO_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",DIR_ESTABLECIMIENTOLEVANTAMIENTO.ID_ENCUESTA)
           sp.AgregarParametro("ROL",DIR_ESTABLECIMIENTOLEVANTAMIENTO.ROL)
           sp.AgregarParametro("DVROL",DIR_ESTABLECIMIENTOLEVANTAMIENTO.DVROL)
           sp.AgregarParametro("ANO",DIR_ESTABLECIMIENTOLEVANTAMIENTO.ANO)
           sp.AgregarParametro("PERIODO",DIR_ESTABLECIMIENTOLEVANTAMIENTO.PERIODO)
           sp.AgregarParametro("RUT",DIR_ESTABLECIMIENTOLEVANTAMIENTO.RUT)
           sp.AgregarParametro("NUI",DIR_ESTABLECIMIENTOLEVANTAMIENTO.NUI)
           sp.AgregarParametro("DVNUI",DIR_ESTABLECIMIENTOLEVANTAMIENTO.DVNUI)
           sp.AgregarParametro("CIIU",DIR_ESTABLECIMIENTOLEVANTAMIENTO.CIIU)
           sp.AgregarParametro("REGION_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.REGION_E)
           sp.AgregarParametro("PROVINCIA_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.PROVINCIA_E)
           sp.AgregarParametro("COMUNA_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.COMUNA_E)
           sp.AgregarParametro("GLOSA_COMUNA_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.GLOSA_COMUNA_E)
           sp.AgregarParametro("CALLE_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.CALLE_E)
           sp.AgregarParametro("NRO_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.NRO_E)
           sp.AgregarParametro("NRO_LOCAL_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.NRO_LOCAL_E)
           sp.AgregarParametro("CODA_FONO_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.CODA_FONO_E)
           sp.AgregarParametro("FONO_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.FONO_E)
           sp.AgregarParametro("CODA_FAX_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.CODA_FAX_E)
           sp.AgregarParametro("FAX_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.FAX_E)
           sp.AgregarParametro("EMAIL_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.EMAIL_E)
           sp.AgregarParametro("WEB_E",DIR_ESTABLECIMIENTOLEVANTAMIENTO.WEB_E)
           sp.AgregarParametro("CASILLA_COMERCIAL",DIR_ESTABLECIMIENTOLEVANTAMIENTO.CASILLA_COMERCIAL)
           sp.AgregarParametro("NOMBREESTABLECIMIENTO",DIR_ESTABLECIMIENTOLEVANTAMIENTO.NOMBREESTABLECIMIENTO)
           sp.AgregarParametro("TIPO_ESTABLECIMIENTO",DIR_ESTABLECIMIENTOLEVANTAMIENTO.TIPO_ESTABLECIMIENTO)
           sp.AgregarParametro("TIPO_FUNCIONAMIENTO",DIR_ESTABLECIMIENTOLEVANTAMIENTO.TIPO_FUNCIONAMIENTO)
            sp.AgregarParametro("CLASE", DIR_ESTABLECIMIENTOLEVANTAMIENTO.CLASE)
           sp.AgregarParametro("EXROL",DIR_ESTABLECIMIENTOLEVANTAMIENTO.EXROL)
           sp.AgregarParametro("HABITACIONES_UNIDADES_HABITACIONALES",DIR_ESTABLECIMIENTOLEVANTAMIENTO.HABITACIONES_UNIDADES_HABITACIONALES)
           sp.AgregarParametro("HABITACIONES_CAPACIDAD_MAXIMA",DIR_ESTABLECIMIENTOLEVANTAMIENTO.HABITACIONES_CAPACIDAD_MAXIMA)
           sp.AgregarParametro("CABANAS_UNIDADES_HABITACIONALES",DIR_ESTABLECIMIENTOLEVANTAMIENTO.CABANAS_UNIDADES_HABITACIONALES)
           sp.AgregarParametro("CABANAS_CAPACIDAD_MAXIMA",DIR_ESTABLECIMIENTOLEVANTAMIENTO.CABANAS_CAPACIDAD_MAXIMA)
            sp.AgregarParametro("DEPARTAMENTOS_UNIDADES_HABITACIONALES", DIR_ESTABLECIMIENTOLEVANTAMIENTO.DEPARTAMENTOS_UNIDADES_HABITACIONALES)
            sp.AgregarParametro("DEPARTAMENTOS_CAPACIDAD_MAXIMA", DIR_ESTABLECIMIENTOLEVANTAMIENTO.DEPARTAMENTOS_CAPACIDAD_MAXIMA)
            sp.AgregarParametro("SITIOSDECAMPING_UNIDADES_HABITACIONALES", DIR_ESTABLECIMIENTOLEVANTAMIENTO.SITIOSDECAMPING_UNIDADES_HABITACIONALES)
            sp.AgregarParametro("SITIOSDECAMPING_CAPACIDAD_MAXIMA", DIR_ESTABLECIMIENTOLEVANTAMIENTO.SITIOSDECAMPING_CAPACIDAD_MAXIMA)
            sp.AgregarParametro("TOTAL_UNIDADES_HABITACIONALES", DIR_ESTABLECIMIENTOLEVANTAMIENTO.TOTAL_UNIDADES_HABITACIONALES)
           sp.AgregarParametro("TOTAL_CAPACIDAD_MAXIMA",DIR_ESTABLECIMIENTOLEVANTAMIENTO.TOTAL_CAPACIDAD_MAXIMA)
           sp.AgregarParametro("PERSONAL_OCUPADO_PERMANENTE_HOMBRE",DIR_ESTABLECIMIENTOLEVANTAMIENTO.PERSONAL_OCUPADO_PERMANENTE_HOMBRE)
           sp.AgregarParametro("PERSONAL_OCUPADO_PERMANENTE_MUJER",DIR_ESTABLECIMIENTOLEVANTAMIENTO.PERSONAL_OCUPADO_PERMANENTE_MUJER)
           sp.AgregarParametro("PERSONAL_OCUPADO_EVENTUAL_HOMBRE",DIR_ESTABLECIMIENTOLEVANTAMIENTO.PERSONAL_OCUPADO_EVENTUAL_HOMBRE)
           sp.AgregarParametro("PERSONAL_OCUPADO_EVENTUAL_MUJER",DIR_ESTABLECIMIENTOLEVANTAMIENTO.PERSONAL_OCUPADO_EVENTUAL_MUJER)
           sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO_HOMBRE",DIR_ESTABLECIMIENTOLEVANTAMIENTO.TOTAL_PERSONAL_OCUPADO_HOMBRE)
           sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO_MUJER",DIR_ESTABLECIMIENTOLEVANTAMIENTO.TOTAL_PERSONAL_OCUPADO_MUJER)
            sp.AgregarParametro("TOTAL_PERSONAL_OCUPADO", DIR_ESTABLECIMIENTOLEVANTAMIENTO.TOTAL_PERSONAL_OCUPADO)
            sp.AgregarParametro("FECHA_LEVANTAMIENTO", DIR_ESTABLECIMIENTOLEVANTAMIENTO.FECHA_LEVANTAMIENTO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_ESTABLECIMIENTOLEVANTAMIENTO_Eliminar")
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

   Public Function Listar() as DIR_ESTABLECIMIENTOLEVANTAMIENTOENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_DIR_ESTABLECIMIENTOLEVANTAMIENTO_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim DIR_ESTABLECIMIENTOLEVANTAMIENTO(dt.Rows.count() - 1) as DIR_ESTABLECIMIENTOLEVANTAMIENTOENT
           i = 0
           for each dr in dt.rows
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i) = New DIR_ESTABLECIMIENTOLEVANTAMIENTOENT()
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).ROL = dr("ROL")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).DVROL = dr("DVROL")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).ANO = dr("ANO")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).PERIODO = dr("PERIODO")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).RUT = dr("RUT")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).NUI = dr("NUI")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).DVNUI = dr("DVNUI")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).CIIU = dr("CIIU")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).REGION_E = dr("REGION_E")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).PROVINCIA_E = dr("PROVINCIA_E")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).COMUNA_E = dr("COMUNA_E")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).GLOSA_COMUNA_E = dr("GLOSA_COMUNA_E")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).CALLE_E = dr("CALLE_E")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).NRO_E = dr("NRO_E")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).NRO_LOCAL_E = dr("NRO_LOCAL_E")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).CODA_FONO_E = dr("CODA_FONO_E")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).FONO_E = dr("FONO_E")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).CODA_FAX_E = dr("CODA_FAX_E")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).FAX_E = dr("FAX_E")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).EMAIL_E = dr("EMAIL_E")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).WEB_E = dr("WEB_E")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).CASILLA_COMERCIAL = dr("CASILLA_COMERCIAL")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).NOMBREESTABLECIMIENTO = dr("NOMBREESTABLECIMIENTO")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).TIPO_ESTABLECIMIENTO = dr("TIPO_ESTABLECIMIENTO")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).TIPO_FUNCIONAMIENTO = dr("TIPO_FUNCIONAMIENTO")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).CLASE = dr("CLASE")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).EXROL = dr("EXROL")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).HABITACIONES_UNIDADES_HABITACIONALES = dr("HABITACIONES_UNIDADES_HABITACIONALES")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).HABITACIONES_CAPACIDAD_MAXIMA = dr("HABITACIONES_CAPACIDAD_MAXIMA")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).CABANAS_UNIDADES_HABITACIONALES = dr("CABANAS_UNIDADES_HABITACIONALES")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).CABANAS_CAPACIDAD_MAXIMA = dr("CABANAS_CAPACIDAD_MAXIMA")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).DEPARTAMENTOS_UNIDADES_HABITACIONALES = dr("DEPARTAMENTOS_UNIDADES_HABITACIONALES")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).DEPARTAMENTOS_CAPACIDAD_MAXIMA = dr("DEPARTAMENTOS_CAPACIDAD_MAXIMA")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).SITIOSDECAMPING_UNIDADES_HABITACIONALES = dr("SITIOSDECAMPING_UNIDADES_HABITACIONALES")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).SITIOSDECAMPING_CAPACIDAD_MAXIMA = dr("SITIOSDECAMPING_CAPACIDAD_MAXIMA")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).TOTAL_UNIDADES_HABITACIONALES = dr("TOTAL_UNIDADES_HABITACIONALES")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).TOTAL_CAPACIDAD_MAXIMA = dr("TOTAL_CAPACIDAD_MAXIMA")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).PERSONAL_OCUPADO_PERMANENTE_HOMBRE = dr("PERSONAL_OCUPADO_PERMANENTE_HOMBRE")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).PERSONAL_OCUPADO_PERMANENTE_MUJER = dr("PERSONAL_OCUPADO_PERMANENTE_MUJER")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).PERSONAL_OCUPADO_EVENTUAL_HOMBRE = dr("PERSONAL_OCUPADO_EVENTUAL_HOMBRE")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).PERSONAL_OCUPADO_EVENTUAL_MUJER = dr("PERSONAL_OCUPADO_EVENTUAL_MUJER")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).TOTAL_PERSONAL_OCUPADO_HOMBRE = dr("TOTAL_PERSONAL_OCUPADO_HOMBRE")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).TOTAL_PERSONAL_OCUPADO_MUJER = dr("TOTAL_PERSONAL_OCUPADO_MUJER")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).TOTAL_PERSONAL_OCUPADO = dr("TOTAL_PERSONAL_OCUPADO")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).FECHA_LEVANTAMIENTO = dr("FECHA_LEVANTAMIENTO")
                i = i + 1
           next
           return DIR_ESTABLECIMIENTOLEVANTAMIENTO
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

    Public Function ListarRol(ByVal rut As Integer, ByVal encuesta As Integer) As DIR_ESTABLECIMIENTOLEVANTAMIENTOENT()
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim i As Integer
            Dim sp As New StoredProcedure_class("SP_DIR_ESTABLECIMIENTOLEVANTAMIENTO_ListarRol")
            sp.AgregarParametro("rut", rut)
            sp.AgregarParametro("encuesta", encuesta)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim DIR_ESTABLECIMIENTOLEVANTAMIENTO(dt.Rows.Count() - 1) As DIR_ESTABLECIMIENTOLEVANTAMIENTOENT
            i = 0
            For Each dr In dt.Rows
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i) = New DIR_ESTABLECIMIENTOLEVANTAMIENTOENT()
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).ROL = dr("ROL")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).DVROL = dr("DVROL")
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).ROLSELECCION = dr("ROLSELECCION")
                i = i + 1
            Next
            Return DIR_ESTABLECIMIENTOLEVANTAMIENTO
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarUsuarioBuscador(ByVal rol As String, ByVal encuesta As Integer) As DIR_ESTABLECIMIENTOLEVANTAMIENTOENT()
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim i As Integer
            Dim sp As New StoredProcedure_class("SP_GES_USUARIO_ListarUsuarioBuscadorRol")
            sp.AgregarParametro("rol", rol)
            sp.AgregarParametro("encuesta", encuesta)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim DIR_ESTABLECIMIENTOLEVANTAMIENTO(dt.Rows.Count() - 1) As DIR_ESTABLECIMIENTOLEVANTAMIENTOENT
            i = 0
            For Each dr In dt.Rows
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i) = New DIR_ESTABLECIMIENTOLEVANTAMIENTOENT()
                DIR_ESTABLECIMIENTOLEVANTAMIENTO(i).ROLBUSCA = dr("ROLES")
                i = i + 1
            Next
            Return DIR_ESTABLECIMIENTOLEVANTAMIENTO
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarPorPeriodo(ByVal ano As Integer, ByVal periodo As Integer) As Data.DataTable
        Try
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_DIR_ESTABLECIMIENTOLEVANTAMIENTO_ListarPorPeriodo")
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("PERIODO", periodo)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region
#Region "VERIFICAR"

    Public Function Verificar(ByVal Rol As Integer, ByVal id_encuestas As Integer) As Boolean
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim resp As Boolean
            Dim sp As New StoredProcedure_class("SP_DIR_ESTABLECIMIENTOLEVANTAMIENTO_VerificarROL")
            sp.AgregarParametro("ROL", Rol)
            sp.AgregarParametro("ID_ENCUESTA", id_encuestas)
            dt = sp.EjecutarProcedimiento().Tables(0)
            For Each dr In dt.Rows
                resp = IIf(dr("resp") = 1, False, True)
            Next
            Return resp
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region
#Region "LISTAR PANEL ESTABLECIMIENTO"

    Public Function ListarPanelEstablecimiento(ByVal rol, ByVal encuesta) As DataTable
        Try
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_DIR_ESTABLECIMIENTOLEVANTAMIENTO_ListaPanel")
            sp.AgregarParametro("rol", rol)
            sp.AgregarParametro("encuesta", encuesta)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

#End Region

#Region "OBTENER ROL"
    Public Function obtenerrol(ByVal rut, ByVal encuesta) As DataTable
        Try
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_DIR_ESTABLECIMIENTOLEVANTAMIENTO_obtenerrol")
            sp.AgregarParametro("rut", rut)
            sp.AgregarParametro("id_encuesta", encuesta)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

#End Region


#Region "ArchivoExcel, OBTENER DATOS DE LA MUESTRA PARA POSTERIOR INSERCION"
    Public Function ObtenerDatosMuestraParaInsercion(ByVal dr As Data.DataRow, ByVal spObtenerDatos As StoredProcedure_class, ByVal sqlCmdObtenerDatos As Data.SqlClient.SqlCommand, ByVal periodo As Integer, ByVal ano As Integer) As Data.DataRow
        Try
            Dim drResultado As Data.DataRow
            spObtenerDatos.AgregarParametro("RUT", dr("RUT"))
            spObtenerDatos.AgregarParametro("ROL", dr("ROL"))
            spObtenerDatos.AgregarParametro("DVROL", dr("DV_ROL"))
            spObtenerDatos.AgregarParametro("PERIODO", periodo)
            spObtenerDatos.AgregarParametro("ANO", ano)

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
