Imports System.Data


public class DIR_EMPRESAORIGINALDAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval DIR_EMPRESAORIGINAL as DIR_EMPRESAORIGINALENT )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_EMPRESAORIGINAL_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",DIR_EMPRESAORIGINAL.ID_ENCUESTA)
           sp.AgregarParametro("ANO",DIR_EMPRESAORIGINAL.ANO)
           sp.AgregarParametro("ID_PERIODO",DIR_EMPRESAORIGINAL.ID_PERIODO)
           sp.AgregarParametro("RUT",DIR_EMPRESAORIGINAL.RUT)
           sp.AgregarParametro("DVRUT",DIR_EMPRESAORIGINAL.DVRUT)
           sp.AgregarParametro("RAZONSOCIAL",DIR_EMPRESAORIGINAL.RAZONSOCIAL)
           sp.AgregarParametro("REPRESENTANTELEGAL",DIR_EMPRESAORIGINAL.REPRESENTANTELEGAL)
           sp.AgregarParametro("RUTREPRESENTANTELEGAL",DIR_EMPRESAORIGINAL.RUTREPRESENTANTELEGAL)
           sp.AgregarParametro("DVRUTREPRESENTANTELEGAL",DIR_EMPRESAORIGINAL.DVRUTREPRESENTANTELEGAL)
           sp.AgregarParametro("REGION_G",DIR_EMPRESAORIGINAL.REGION_G)
           sp.AgregarParametro("PROVINCIA_G",DIR_EMPRESAORIGINAL.PROVINCIA_G)
            sp.AgregarParametro("COMUNA_G", DIR_EMPRESAORIGINAL.COMUNA_G)
            sp.AgregarParametro("GLOSA_COMUNA_G", DIR_EMPRESAORIGINAL.GLOSA_COMUNA_G)
            sp.AgregarParametro("DIRECCION_G", DIR_EMPRESAORIGINAL.DIRECCION_G)
           sp.AgregarParametro("CODA_FONO_G",DIR_EMPRESAORIGINAL.CODA_FONO_G)
           sp.AgregarParametro("FONO_G",DIR_EMPRESAORIGINAL.FONO_G)
           sp.AgregarParametro("CODA_FAX_G",DIR_EMPRESAORIGINAL.CODA_FAX_G)
           sp.AgregarParametro("FAX_G",DIR_EMPRESAORIGINAL.FAX_G)
           sp.AgregarParametro("CELULAR_G",DIR_EMPRESAORIGINAL.CELULAR_G)
           sp.AgregarParametro("CASILLA",DIR_EMPRESAORIGINAL.CASILLA)
           sp.AgregarParametro("EMAIL_G",DIR_EMPRESAORIGINAL.EMAIL_G)
           sp.AgregarParametro("WEB_G",DIR_EMPRESAORIGINAL.WEB_G)
           sp.AgregarParametro("NRO_ESTABLECIMIENTOS",DIR_EMPRESAORIGINAL.NRO_ESTABLECIMIENTOS)
            sp.AgregarParametro("ACTIVIDADECONOMICA1", DIR_EMPRESAORIGINAL.ACTIVIDADECONOMICA1)
            sp.AgregarParametro("FECHA_LEVANTAMIENTO", DIR_EMPRESAORIGINAL.FECHA_LEVANTAMIENTO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Sub

    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            'Dim sp As New StoredProcedure_class("SP_DIR_EMPRESAORIGINAL_Insertar")
            sp.AgregarParametro("ID_ENCUESTA", 1)
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
            sp.AgregarParametro("FECHA_LEVANTAMIENTO", "")
            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval DIR_EMPRESAORIGINAL as DIR_EMPRESAORIGINALENT )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_EMPRESAORIGINAL_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",DIR_EMPRESAORIGINAL.ID_ENCUESTA)
           sp.AgregarParametro("ANO",DIR_EMPRESAORIGINAL.ANO)
           sp.AgregarParametro("ID_PERIODO",DIR_EMPRESAORIGINAL.ID_PERIODO)
           sp.AgregarParametro("RUT",DIR_EMPRESAORIGINAL.RUT)
           sp.AgregarParametro("DVRUT",DIR_EMPRESAORIGINAL.DVRUT)
           sp.AgregarParametro("RAZONSOCIAL",DIR_EMPRESAORIGINAL.RAZONSOCIAL)
           sp.AgregarParametro("REPRESENTANTELEGAL",DIR_EMPRESAORIGINAL.REPRESENTANTELEGAL)
           sp.AgregarParametro("RUTREPRESENTANTELEGAL",DIR_EMPRESAORIGINAL.RUTREPRESENTANTELEGAL)
           sp.AgregarParametro("DVRUTREPRESENTANTELEGAL",DIR_EMPRESAORIGINAL.DVRUTREPRESENTANTELEGAL)
           sp.AgregarParametro("REGION_G",DIR_EMPRESAORIGINAL.REGION_G)
           sp.AgregarParametro("PROVINCIA_G",DIR_EMPRESAORIGINAL.PROVINCIA_G)
            sp.AgregarParametro("COMUNA_G", DIR_EMPRESAORIGINAL.COMUNA_G)
            sp.AgregarParametro("GLOSA_COMUNA_G", DIR_EMPRESAORIGINAL.GLOSA_COMUNA_G)
            sp.AgregarParametro("DIRECCION_G", DIR_EMPRESAORIGINAL.DIRECCION_G)
           sp.AgregarParametro("CODA_FONO_G",DIR_EMPRESAORIGINAL.CODA_FONO_G)
           sp.AgregarParametro("FONO_G",DIR_EMPRESAORIGINAL.FONO_G)
           sp.AgregarParametro("CODA_FAX_G",DIR_EMPRESAORIGINAL.CODA_FAX_G)
           sp.AgregarParametro("FAX_G",DIR_EMPRESAORIGINAL.FAX_G)
           sp.AgregarParametro("CELULAR_G",DIR_EMPRESAORIGINAL.CELULAR_G)
           sp.AgregarParametro("CASILLA",DIR_EMPRESAORIGINAL.CASILLA)
           sp.AgregarParametro("EMAIL_G",DIR_EMPRESAORIGINAL.EMAIL_G)
           sp.AgregarParametro("WEB_G",DIR_EMPRESAORIGINAL.WEB_G)
           sp.AgregarParametro("NRO_ESTABLECIMIENTOS",DIR_EMPRESAORIGINAL.NRO_ESTABLECIMIENTOS)
            sp.AgregarParametro("ACTIVIDADECONOMICA1", DIR_EMPRESAORIGINAL.ACTIVIDADECONOMICA1)
            sp.AgregarParametro("FECHA_LEVANTAMIENTO", DIR_EMPRESAORIGINAL.FECHA_LEVANTAMIENTO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_EMPRESAORIGINAL_Eliminar")
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

   Public Function Listar() as DIR_EMPRESAORIGINALENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_DIR_EMPRESAORIGINAL_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim DIR_EMPRESAORIGINAL(dt.Rows.count() - 1) as DIR_EMPRESAORIGINALENT
           i = 0
           for each dr in dt.rows
                DIR_EMPRESAORIGINAL(i) = New DIR_EMPRESAORIGINALENT()
                DIR_EMPRESAORIGINAL(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                DIR_EMPRESAORIGINAL(i).ANO = dr("ANO")
                DIR_EMPRESAORIGINAL(i).ID_PERIODO = dr("ID_PERIODO")
                DIR_EMPRESAORIGINAL(i).RUT = dr("RUT")
                DIR_EMPRESAORIGINAL(i).DVRUT = dr("DVRUT")
                DIR_EMPRESAORIGINAL(i).RAZONSOCIAL = dr("RAZONSOCIAL")
                DIR_EMPRESAORIGINAL(i).REPRESENTANTELEGAL = dr("REPRESENTANTELEGAL")
                DIR_EMPRESAORIGINAL(i).RUTREPRESENTANTELEGAL = dr("RUTREPRESENTANTELEGAL")
                DIR_EMPRESAORIGINAL(i).DVRUTREPRESENTANTELEGAL = dr("DVRUTREPRESENTANTELEGAL")
                DIR_EMPRESAORIGINAL(i).REGION_G = dr("REGION_G")
                DIR_EMPRESAORIGINAL(i).PROVINCIA_G = dr("PROVINCIA_G")
                DIR_EMPRESAORIGINAL(i).COMUNA_G = dr("COMUNA_G")
                DIR_EMPRESAORIGINAL(i).GLOSA_COMUNA_G = dr("GLOSA_COMUNA_G")
                DIR_EMPRESAORIGINAL(i).DIRECCION_G = dr("DIRECCION_G")
                DIR_EMPRESAORIGINAL(i).CODA_FONO_G = dr("CODA_FONO_G")
                DIR_EMPRESAORIGINAL(i).FONO_G = dr("FONO_G")
                DIR_EMPRESAORIGINAL(i).CODA_FAX_G = dr("CODA_FAX_G")
                DIR_EMPRESAORIGINAL(i).FAX_G = dr("FAX_G")
                DIR_EMPRESAORIGINAL(i).CELULAR_G = dr("CELULAR_G")
                DIR_EMPRESAORIGINAL(i).CASILLA = dr("CASILLA")
                DIR_EMPRESAORIGINAL(i).EMAIL_G = dr("EMAIL_G")
                DIR_EMPRESAORIGINAL(i).WEB_G = dr("WEB_G")
                DIR_EMPRESAORIGINAL(i).NRO_ESTABLECIMIENTOS = dr("NRO_ESTABLECIMIENTOS")
                DIR_EMPRESAORIGINAL(i).ACTIVIDADECONOMICA1 = dr("ACTIVIDADECONOMICA1")
                DIR_EMPRESAORIGINAL(i).FECHA_LEVANTAMIENTO = dr("FECHA_LEVANTAMIENTO")
                i = i + 1
           next
           return DIR_EMPRESAORIGINAL
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Function

    Public Function ListarUsuarioBuscadorRut(ByVal rut As String, ByVal encuesta As Integer) As DIR_EMPRESAORIGINALENT()
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim i As Integer
            Dim sp As New StoredProcedure_class("SP_GES_USUARIO_ListarUsuarioBuscadorRut")
            sp.AgregarParametro("rut", rut)
            sp.AgregarParametro("encuesta", encuesta)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim DIR_EMPRESAORIGINAL(dt.Rows.Count() - 1) As DIR_EMPRESAORIGINALENT
            i = 0
            For Each dr In dt.Rows
                DIR_EMPRESAORIGINAL(i) = New DIR_EMPRESAORIGINALENT()
                DIR_EMPRESAORIGINAL(i).Rutbusca = dr("Rut")
                i = i + 1
            Next
            Return DIR_EMPRESAORIGINAL
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarPorPeriodo(ByVal ano As Integer, ByVal periodo As Integer) As Data.DataTable
        Try

            Dim dt As DataTable

            Dim sp As New StoredProcedure_class("SP_DIR_EMPRESAORIGINAL_ListarPorPeriodo")
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("PERIODO", periodo)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#END REGION

#Region "VERIFICAR RUT"
    Public Function Verificar(ByVal rut As Integer, ByVal encuesta As Integer) As Boolean
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim resp As Boolean
            Dim sp As New StoredProcedure_class("SP_DIR_EMPRESAORIGINAL_VerificarRut")
            sp.AgregarParametro("rut", rut)
            sp.AgregarParametro("encuesta", encuesta)
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

#Region "Listar Panel Empresa"
    Public Function ListarPanelEmpresa(ByVal rut, ByVal encuesta) As DataTable
        Try
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_DIR_EMPRESAORIGINAL_ListarPanel")
            sp.AgregarParametro("rut", rut)
            sp.AgregarParametro("encuesta", encuesta)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

#End Region

#Region "ArchivoExcel, OBTENER DATOS DE LA MUESTRA PARA POSTERIOR INSERCION"
    Public Function ObtenerDatosMuestraParaInsercion(ByVal dr As Data.DataRow, ByVal spObtenerDatos As StoredProcedure_class, ByVal sqlCmdObtemerDatos As Data.SqlClient.SqlCommand, ByVal periodo As Integer, ByVal ano As Integer) As Data.DataRow
        Try
            Dim drResultado As Data.DataRow
            spObtenerDatos.AgregarParametro("RUT", dr("RUT"))
            spObtenerDatos.AgregarParametro("DVRUT", dr("DV_RUT"))
            spObtenerDatos.AgregarParametro("PERIODO", periodo)
            spObtenerDatos.AgregarParametro("ANO", ano)

            drResultado = spObtenerDatos.EjecutarProcedimiento(sqlCmdObtemerDatos).Tables(0).Rows(0)
            Return drResultado
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
