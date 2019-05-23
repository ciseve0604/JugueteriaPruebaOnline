Imports Microsoft.VisualBasic

Public Class GES_NUIDAT

#Region "METODO INGRESO"

    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            sp.AgregarParametro("ID_ENCUESTA", 1)
            sp.AgregarParametro("NUI", dr("NUI").ToString)
            sp.AgregarParametro("DVNUI", dr("DVNUI").ToString)
            sp.AgregarParametro("ROL", dr("ROL").ToString)
            sp.AgregarParametro("DVROL", dr("DV_ROL").ToString)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("ACTIVO", 1)
            sp.AgregarParametro("COMENTARIO", "ACTIVO")
            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#End Region

End Class
