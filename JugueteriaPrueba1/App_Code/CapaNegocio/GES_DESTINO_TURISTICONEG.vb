Imports Microsoft.VisualBasic

Public Class GES_DESTINO_TURISTICONEG

#Region "METODOS DE LOGICA"

    Public Sub Insertar(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer, ByVal usuario_actualizacion As String)
        Try
            Dim GES_DESTINO_TURISTICO_obj As New GES_DESTINO_TURISTICODAT
            GES_DESTINO_TURISTICO_obj.Insertar(dr, sp, sqlCmd, usuario_actualizacion, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#End Region

End Class