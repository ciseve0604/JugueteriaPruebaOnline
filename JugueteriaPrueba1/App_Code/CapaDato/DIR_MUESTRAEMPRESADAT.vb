Imports System.Data


public class DIR_MUESTRAEMPRESADAT

#REGION "METODO INGRESO"

    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodoInicio As Integer, ByVal periodoFin As Integer, ByVal anoInicio As Integer, ByVal anoFin As Integer)
        Try
            'Dim sp As New StoredProcedure_class("SP_DIR_MUESTRAEMPRESA_Insertar")
            sp.AgregarParametro("ID_ENCUESTA", 1)
            'sp.AgregarParametro("PEIRODO_INICIO", dr("PERIODO_INICIO"))
            'sp.AgregarParametro("PERIODO_FIN", dr("PERIODO_FIN"))
            'sp.AgregarParametro("ANO_INICIO", dr("ANIO_INICIO"))
            'sp.AgregarParametro("ANO_FIN", dr("ANIO_FIN"))
            sp.AgregarParametro("PERIODO_INICIO", periodoInicio)
            sp.AgregarParametro("PERIODO_FIN", periodoFin)
            sp.AgregarParametro("ANO_INICIO", anoInicio)
            sp.AgregarParametro("ANO_FIN", anoFin)
            sp.AgregarParametro("RUT", dr("RUT"))
            sp.AgregarParametro("DVRUT", dr("DVRUT"))
            sp.AgregarParametro("RAZONSOCIAL", dr("RazonSocial"))
            sp.AgregarParametro("REPRESENTANTELEGAL", dr("RepresentanteLegal"))
            sp.AgregarParametro("RUTREPRESENTANTELEGAL", dr("RutRepresentanteLegal"))
            sp.AgregarParametro("DVRUTREPRESENTANTELEGAL", dr("DvRutRepresentanteLegal"))
            sp.AgregarParametro("REGION_G", CInt(dr("Region_G")))
            sp.AgregarParametro("PROVINCIA_G", CInt(dr("Provincia_G")))
            sp.AgregarParametro("COMUNA_G", CInt(dr("Comuna_G")))
            sp.AgregarParametro("GLOSA_COMUNA_G", dr("Glosa_Comuna_G"))
            sp.AgregarParametro("DIRECCION_G", dr("Direccion_G"))
            sp.AgregarParametro("CODA_FONO_G", IIf(dr("Coda_fono_G") Is DBNull.Value, "00", dr("Coda_fono_G")))
            sp.AgregarParametro("FONO_G", IIf(dr("Fono_G") Is DBNull.Value, "", dr("Fono_G")))
            sp.AgregarParametro("CODA_FAX_G", IIf(dr("Coda_fax_G") Is DBNull.Value, "00", dr("Coda_fax_G")))
            sp.AgregarParametro("FAX_G", IIf(dr("Fax_G") Is DBNull.Value, "", dr("Fax_G")))
            sp.AgregarParametro("CELULAR_G", IIf(dr("Celular_G") Is DBNull.Value, "", dr("Celular_G")))
            sp.AgregarParametro("CASILLA", IIf(dr("Casilla") Is DBNull.Value, "", dr("Casilla")))
            sp.AgregarParametro("EMAIL_G", IIf(dr("Email_G") Is DBNull.Value, "", dr("Email_G")))
            sp.AgregarParametro("WEB_G", IIf(dr("Web_G") Is DBNull.Value, "", dr("Web_G")))
            sp.AgregarParametro("NRO_ESTABLECIMIENTOS", CInt(dr("Nro_Establecimientos")))
            sp.AgregarParametro("ACTIVIDADECONOMICA1", dr("ActividadEconomica1"))
            'sp.AgregarParametro("FECHA_CREACION_MUESTRA_G", DIR_MUESTRAEMPRESA.FECHA_CREACION_MUESTRA_G)

            ''Parametros nuevos 
            'sp.AgregarParametro("ESTADOEMPRESA", dr("EstadoEmpresa"))
            sp.AgregarParametro("USUARIO_ACTUALIZACION", usuario_actualizacion)
            'sp.EjecutarProcedimiento()
            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval DIR_MUESTRAEMPRESA as DIR_MUESTRAEMPRESAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_MUESTRAEMPRESA_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",DIR_MUESTRAEMPRESA.ID_ENCUESTA)
           sp.AgregarParametro("PERIODO_INICIO",DIR_MUESTRAEMPRESA.PERIODO_INICIO)
           sp.AgregarParametro("PERIODO_FIN",DIR_MUESTRAEMPRESA.PERIODO_FIN)
           sp.AgregarParametro("ANO_INICIO",DIR_MUESTRAEMPRESA.ANO_INICIO)
           sp.AgregarParametro("ANO_FIN",DIR_MUESTRAEMPRESA.ANO_FIN)
           sp.AgregarParametro("RUT",DIR_MUESTRAEMPRESA.RUT)
           sp.AgregarParametro("DVRUT",DIR_MUESTRAEMPRESA.DVRUT)
           sp.AgregarParametro("RAZONSOCIAL",DIR_MUESTRAEMPRESA.RAZONSOCIAL)
           sp.AgregarParametro("REPRESENTANTELEGAL",DIR_MUESTRAEMPRESA.REPRESENTANTELEGAL)
           sp.AgregarParametro("RUTREPRESENTANTELEGAL",DIR_MUESTRAEMPRESA.RUTREPRESENTANTELEGAL)
           sp.AgregarParametro("DVRUTREPRESENTANTELEGAL",DIR_MUESTRAEMPRESA.DVRUTREPRESENTANTELEGAL)
           sp.AgregarParametro("REGION_G",DIR_MUESTRAEMPRESA.REGION_G)
           sp.AgregarParametro("PROVINCIA_G",DIR_MUESTRAEMPRESA.PROVINCIA_G)
           sp.AgregarParametro("COMUNA_G",DIR_MUESTRAEMPRESA.COMUNA_G)
           sp.AgregarParametro("GLOSA_COMUNA_G",DIR_MUESTRAEMPRESA.GLOSA_COMUNA_G)
           sp.AgregarParametro("DIRECCION_G",DIR_MUESTRAEMPRESA.DIRECCION_G)
           sp.AgregarParametro("CODA_FONO_G",DIR_MUESTRAEMPRESA.CODA_FONO_G)
           sp.AgregarParametro("FONO_G",DIR_MUESTRAEMPRESA.FONO_G)
           sp.AgregarParametro("CODA_FAX_G",DIR_MUESTRAEMPRESA.CODA_FAX_G)
           sp.AgregarParametro("FAX_G",DIR_MUESTRAEMPRESA.FAX_G)
           sp.AgregarParametro("CELULAR_G",DIR_MUESTRAEMPRESA.CELULAR_G)
           sp.AgregarParametro("CASILLA",DIR_MUESTRAEMPRESA.CASILLA)
           sp.AgregarParametro("EMAIL_G",DIR_MUESTRAEMPRESA.EMAIL_G)
           sp.AgregarParametro("WEB_G",DIR_MUESTRAEMPRESA.WEB_G)
           sp.AgregarParametro("NRO_ESTABLECIMIENTOS",DIR_MUESTRAEMPRESA.NRO_ESTABLECIMIENTOS)
           sp.AgregarParametro("ACTIVIDADECONOMICA1",DIR_MUESTRAEMPRESA.ACTIVIDADECONOMICA1)
           sp.AgregarParametro("FECHA_CREACION_MUESTRA_G",DIR_MUESTRAEMPRESA.FECHA_CREACION_MUESTRA_G)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_DIR_MUESTRAEMPRESA_Eliminar")
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

   Public Function Listar() as DIR_MUESTRAEMPRESAENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_DIR_MUESTRAEMPRESA_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim DIR_MUESTRAEMPRESA(dt.Rows.count() - 1) as DIR_MUESTRAEMPRESAENT
           i = 0
           for each dr in dt.rows
                DIR_MUESTRAEMPRESA(i) = New DIR_MUESTRAEMPRESAENT()
                DIR_MUESTRAEMPRESA(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                DIR_MUESTRAEMPRESA(i).PERIODO_INICIO = dr("PERIODO_INICIO")
                DIR_MUESTRAEMPRESA(i).PERIODO_FIN = dr("PERIODO_FIN")
                DIR_MUESTRAEMPRESA(i).ANO_INICIO = dr("ANO_INICIO")
                DIR_MUESTRAEMPRESA(i).ANO_FIN = dr("ANO_FIN")
                DIR_MUESTRAEMPRESA(i).RUT = dr("RUT")
                DIR_MUESTRAEMPRESA(i).DVRUT = dr("DVRUT")
                DIR_MUESTRAEMPRESA(i).RAZONSOCIAL = dr("RAZONSOCIAL")
                DIR_MUESTRAEMPRESA(i).REPRESENTANTELEGAL = dr("REPRESENTANTELEGAL")
                DIR_MUESTRAEMPRESA(i).RUTREPRESENTANTELEGAL = dr("RUTREPRESENTANTELEGAL")
                DIR_MUESTRAEMPRESA(i).DVRUTREPRESENTANTELEGAL = dr("DVRUTREPRESENTANTELEGAL")
                DIR_MUESTRAEMPRESA(i).REGION_G = dr("REGION_G")
                DIR_MUESTRAEMPRESA(i).PROVINCIA_G = dr("PROVINCIA_G")
                DIR_MUESTRAEMPRESA(i).COMUNA_G = dr("COMUNA_G")
                DIR_MUESTRAEMPRESA(i).GLOSA_COMUNA_G = dr("GLOSA_COMUNA_G")
                DIR_MUESTRAEMPRESA(i).DIRECCION_G = dr("DIRECCION_G")
                DIR_MUESTRAEMPRESA(i).CODA_FONO_G = dr("CODA_FONO_G")
                DIR_MUESTRAEMPRESA(i).FONO_G = dr("FONO_G")
                DIR_MUESTRAEMPRESA(i).CODA_FAX_G = dr("CODA_FAX_G")
                DIR_MUESTRAEMPRESA(i).FAX_G = dr("FAX_G")
                DIR_MUESTRAEMPRESA(i).CELULAR_G = dr("CELULAR_G")
                DIR_MUESTRAEMPRESA(i).CASILLA = dr("CASILLA")
                DIR_MUESTRAEMPRESA(i).EMAIL_G = dr("EMAIL_G")
                DIR_MUESTRAEMPRESA(i).WEB_G = dr("WEB_G")
                DIR_MUESTRAEMPRESA(i).NRO_ESTABLECIMIENTOS = dr("NRO_ESTABLECIMIENTOS")
                DIR_MUESTRAEMPRESA(i).ACTIVIDADECONOMICA1 = dr("ACTIVIDADECONOMICA1")
                DIR_MUESTRAEMPRESA(i).FECHA_CREACION_MUESTRA_G = dr("FECHA_CREACION_MUESTRA_G")
                i = i + 1
           next
           return DIR_MUESTRAEMPRESA
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#End Region


#Region "OBTENER LOS DATOS LA MUESTRA DE UNA EMPRESA EN PARTICULAR"
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
