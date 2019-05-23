Imports System.Data


public class GES_PERIODO_APERTURACIERRENEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GES_PERIODO_APERTURACIERRE as GES_PERIODO_APERTURACIERREENT)
       Try
           Dim GES_PERIODO_APERTURACIERREDatos as new GES_PERIODO_APERTURACIERREDAT
           GES_PERIODO_APERTURACIERREDatos.insertar(GES_PERIODO_APERTURACIERRE)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GES_PERIODO_APERTURACIERRE as GES_PERIODO_APERTURACIERREENT)
       Try
           Dim GES_PERIODO_APERTURACIERREDatos as new GES_PERIODO_APERTURACIERREDAT
           GES_PERIODO_APERTURACIERREDatos.actualizar(GES_PERIODO_APERTURACIERRE)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GES_PERIODO_APERTURACIERRE as GES_PERIODO_APERTURACIERREENT)
       Try
           Dim GES_PERIODO_APERTURACIERREDatos as new GES_PERIODO_APERTURACIERREDAT
           GES_PERIODO_APERTURACIERREDatos.eliminar(GES_PERIODO_APERTURACIERRE)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GES_PERIODO_APERTURACIERREENT()
       Try
           Dim GES_PERIODO_APERTURACIERREDatos as new GES_PERIODO_APERTURACIERREDAT
           return GES_PERIODO_APERTURACIERREDatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION

#Region "OBTENER ULTIMO PERIODO EN CURSO"
    Public Function ObtenerUltimo(ByVal encuesta As Integer) As Data.DataRow
        Try
            Dim GES_PERIODO_APERTURACIERREDatos As New GES_PERIODO_APERTURACIERREDAT
            Return GES_PERIODO_APERTURACIERREDatos.ObtenerUltimo(encuesta)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "INSERTAR APERTURA DE PERIODO"
    Public Sub AbrirPeriodo(ByVal GES_PERIODO_APERTURACIERRE As GES_PERIODO_APERTURACIERREENT)
        Try
            Dim GES_PERIODO_APERTURACIERREDatos As New GES_PERIODO_APERTURACIERREDAT
            GES_PERIODO_APERTURACIERREDatos.AbrirPeriodo(GES_PERIODO_APERTURACIERRE)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
#Region "INSERTAR CIERRE DE PERIODO"
    Public Sub CerrarPeriodo(ByVal mes As Integer, ByVal ano As Integer)
        Try
            Dim GES_PERIODO_APERTURACIERREDatos As New GES_PERIODO_APERTURACIERREDAT
            GES_PERIODO_APERTURACIERREDatos.CerrarPeriodo(mes, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
#Region "INSERTAR REAPERTURA DE PERIODO"
    Public Sub ReabrirPeriodo(ByVal GES_PERIODO_APERTURACIERREENT)
        Try
            Dim GES_PERIODO_APERTURACIERREDatos As New GES_PERIODO_APERTURACIERREDAT
            GES_PERIODO_APERTURACIERREDatos.ReabrirPeriodo(GES_PERIODO_APERTURACIERREENT)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "LISTAR ESTADOS PERIODOS"
    Public Function ListarEstadosPeriodo(ByVal ano As Integer) As Data.DataTable
        Try
            Try
                Dim GES_PERIODO_APERTURACIERREDatos As New GES_PERIODO_APERTURACIERREDAT
                Return GES_PERIODO_APERTURACIERREDatos.ListarEstadosPeriodo(ano)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "VALIDAR SI SE PUEDE ABRIR UN PERIODO"
    Public Function ValidarAperturaPeriodo(ByVal mes As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim GES_PERIODO_APERTURACIERREDatos As New GES_PERIODO_APERTURACIERREDAT
            Return GES_PERIODO_APERTURACIERREDatos.ValidarAperturaPeriodo(mes, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region
#Region "VALIDAR SI SE PUEDE CERRAR UN PERIODO"
    Public Function ValidarCierrePeriodo(ByVal mes As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim GES_PERIODO_APERTURACIERREDatos As New GES_PERIODO_APERTURACIERREDAT
            Return GES_PERIODO_APERTURACIERREDatos.ValidarCierrePeriodo(mes, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region
#Region "VALIDAR SI SE PUEDE REABRIR UN PERIODO"
    Public Function ValidarReaperturaPeriodo(ByVal mes As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim GES_PERIODO_APERTURACIERREDatos As New GES_PERIODO_APERTURACIERREDAT
            Return GES_PERIODO_APERTURACIERREDatos.ValidarReaperturaPeriodo(mes, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region


End Class
