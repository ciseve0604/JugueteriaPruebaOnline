Imports Microsoft.VisualBasic

Public Class OBJ_GETJUSTIFICACIONNEG

#Region "METODOS DE LOGICA"
    Public Function GrillaCargarNEG(ByVal Campo As String, ByVal RolCap As String, ByVal periodo As String, ByVal ano As String, ByVal usuario As String) As OBJ_GETJUSTIFICACIONENT()
        Try
            Dim OBJ_GETJUSTIFICACIONdato As New OBJ_GETJUSTIFICACIONDAT
            Return OBJ_GETJUSTIFICACIONdato.GrillaCargarDAT(Campo, RolCap, periodo, ano, usuario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region


End Class
