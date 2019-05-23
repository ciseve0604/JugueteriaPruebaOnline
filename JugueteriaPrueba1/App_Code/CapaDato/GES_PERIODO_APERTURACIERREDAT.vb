Imports System.Data


public class GES_PERIODO_APERTURACIERREDAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GES_PERIODO_APERTURACIERRE as GES_PERIODO_APERTURACIERREENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_PERIODO_APERTURACIERRE_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",GES_PERIODO_APERTURACIERRE.ID_ENCUESTA)
           sp.AgregarParametro("ANO",GES_PERIODO_APERTURACIERRE.ANO)
           sp.AgregarParametro("MES",GES_PERIODO_APERTURACIERRE.MES)
           sp.AgregarParametro("ABIERTO",GES_PERIODO_APERTURACIERRE.ABIERTO)
           sp.AgregarParametro("CERRADO",GES_PERIODO_APERTURACIERRE.CERRADO)
           sp.AgregarParametro("FECHA_APERTURA",GES_PERIODO_APERTURACIERRE.FECHA_APERTURA)
           sp.AgregarParametro("FECHA_CIERRE",GES_PERIODO_APERTURACIERRE.FECHA_CIERRE)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GES_PERIODO_APERTURACIERRE as GES_PERIODO_APERTURACIERREENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_PERIODO_APERTURACIERRE_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",GES_PERIODO_APERTURACIERRE.ID_ENCUESTA)
           sp.AgregarParametro("ANO",GES_PERIODO_APERTURACIERRE.ANO)
           sp.AgregarParametro("MES",GES_PERIODO_APERTURACIERRE.MES)
           sp.AgregarParametro("ABIERTO",GES_PERIODO_APERTURACIERRE.ABIERTO)
           sp.AgregarParametro("CERRADO",GES_PERIODO_APERTURACIERRE.CERRADO)
           sp.AgregarParametro("FECHA_APERTURA",GES_PERIODO_APERTURACIERRE.FECHA_APERTURA)
           sp.AgregarParametro("FECHA_CIERRE",GES_PERIODO_APERTURACIERRE.FECHA_CIERRE)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_PERIODO_APERTURACIERRE_Eliminar")
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

   Public Function Listar() as GES_PERIODO_APERTURACIERREENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GES_PERIODO_APERTURACIERRE_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GES_PERIODO_APERTURACIERRE(dt.Rows.count() - 1) as GES_PERIODO_APERTURACIERREENT
           i = 0
           for each dr in dt.rows
                GES_PERIODO_APERTURACIERRE(i) = New GES_PERIODO_APERTURACIERREENT()
                GES_PERIODO_APERTURACIERRE(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                GES_PERIODO_APERTURACIERRE(i).ANO = dr("ANO")
                GES_PERIODO_APERTURACIERRE(i).MES = dr("MES")
                GES_PERIODO_APERTURACIERRE(i).ABIERTO = dr("ABIERTO")
                GES_PERIODO_APERTURACIERRE(i).CERRADO = dr("CERRADO")
                GES_PERIODO_APERTURACIERRE(i).FECHA_APERTURA = dr("FECHA_APERTURA")
                GES_PERIODO_APERTURACIERRE(i).FECHA_CIERRE = dr("FECHA_CIERRE")
                i = i + 1
           next
           return GES_PERIODO_APERTURACIERRE
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION

#Region "OBTENER ÚLTIMO PERIODO ABIERTO"
    Public Function ObtenerUltimo(ByVal encuesta As Integer) As Data.DataRow
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_GES_PERIODO_APERTURACIERRE_ObtenerUltimo")
            sp.AgregarParametro("encuesta", encuesta)
            dt = sp.EjecutarProcedimiento().Tables(0)

            dr = dt.Rows(0)

            Return dr
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region


#Region "ABRIR PERIODO"
    Public Sub AbrirPeriodo(ByVal GES_PERIODO_APERTURACIERRE As GES_PERIODO_APERTURACIERREENT)
        Try
            Dim sp As New StoredProcedure_class("SP_GES_PERIODO_APERTURACIERRE_AbrirPeriodo")
            sp.AgregarParametro("ID_ENCUESTA", GES_PERIODO_APERTURACIERRE.ID_ENCUESTA)
            sp.AgregarParametro("ANO", GES_PERIODO_APERTURACIERRE.ANO)
            sp.AgregarParametro("MES", GES_PERIODO_APERTURACIERRE.MES)
            sp.AgregarParametro("ABIERTO", GES_PERIODO_APERTURACIERRE.ABIERTO)
            sp.AgregarParametro("CERRADO", GES_PERIODO_APERTURACIERRE.CERRADO)
            sp.AgregarParametro("FECHA_APERTURA", GES_PERIODO_APERTURACIERRE.FECHA_APERTURA)
            ''sp.AgregarParametro("FECHA_CIERRE", GES_PERIODO_APERTURACIERRE.FECHA_CIERRE)
            sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
#Region "CERRAR PERIODO"
    Public Sub CerrarPeriodo(ByVal mes As Integer, ByVal ano As Integer)
        Try
            Dim sp As New StoredProcedure_class("SP_GES_PERIODO_APERTURACIERRE_CerrarPeriodo")
            sp.AgregarParametro("MES", mes)
            sp.AgregarParametro("ANO", ano)
            sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
#Region "REABRIR PERIODO"
    Public Sub ReabrirPeriodo(ByVal GES_PERIODO_APERTURACIERRE As GES_PERIODO_APERTURACIERREENT)
        Try
            Dim sp As New StoredProcedure_class("SP_GES_PERIODO_APERTURACIERRE_ReabrirPeriodo")
            sp.AgregarParametro("ID_ENCUESTA", GES_PERIODO_APERTURACIERRE.ID_ENCUESTA)
            sp.AgregarParametro("ANO", GES_PERIODO_APERTURACIERRE.ANO)
            sp.AgregarParametro("MES", GES_PERIODO_APERTURACIERRE.MES)
            sp.AgregarParametro("ABIERTO", GES_PERIODO_APERTURACIERRE.ABIERTO)
            sp.AgregarParametro("CERRADO", GES_PERIODO_APERTURACIERRE.CERRADO)
            'sp.AgregarParametro("FECHA_APERTURA", GES_PERIODO_APERTURACIERRE.FECHA_APERTURA)
            sp.AgregarParametro("FECHA_CIERRE", GES_PERIODO_APERTURACIERRE.FECHA_CIERRE)
            sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "LISTAR ESTADO PERIODOS"
    Public Function ListarEstadosPeriodo(ByVal ano As Integer) As Data.DataTable
        Try
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_GES_PERIODO_APERTURACIERRE_ListarEstadosPeriodo")
            sp.AgregarParametro("ANO", ano)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "VALIDAR LA APERTURA DE UN PERIODO"
    Public Function ValidarAperturaPeriodo(ByVal mes As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_GES_PERIODO_APERTURACIERRE_ComprobarAperturaPeriodo")
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("MES", mes)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region
#Region "VALIDAR EL CIERRE DE UN PERIODO DE UN PERIODO"
    Public Function ValidarCierrePeriodo(ByVal mes As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_GES_PERIODO_APERTURACIERRE_ComprobarCierrePeriodo")
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("MES", mes)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region
#Region "VALIDAR LA REAPERTURA DE UN PERIDO"
    Public Function ValidarReaperturaPeriodo(ByVal mes As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_GES_PERIODO_APERTURACIERRE_ComprobarReaperturaPeriodo")
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("MES", mes)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
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
