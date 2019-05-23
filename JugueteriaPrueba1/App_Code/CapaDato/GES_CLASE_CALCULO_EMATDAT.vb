Imports Microsoft.VisualBasic

Public Class GES_CLASE_CALCULO_EMATDAT

#Region "METODO INGRESO"

    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            sp.AgregarParametro("NUI", dr("NUI").ToString)
            sp.AgregarParametro("ROL", dr("ROL").ToString)
            sp.AgregarParametro("DVROL", dr("DV_ROL").ToString)
            sp.AgregarParametro("USUARIO", usuario_actualizacion)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)

            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#End Region

End Class
