Imports Microsoft.VisualBasic

Public Class OBJ_SETJUSTIFICACIONNEG

    Public Function ActualizarJustificacionNEG(ByVal ROL As Integer, ByVal PERIODO As Integer, ByVal ANO As Integer, ByVal ID As Integer, ByVal USUARIO As String, ByVal JUSTIFICACION As String, ByVal CJA As Integer) As Boolean
        Dim OBJ As New OBJ_SETJUSTIFICACIONDAT
        Dim OB2 As New OBJ_SETJUSTIFICACIONENT

        OB2.ROL = ROL
        OB2.PERIODO = PERIODO
        OB2.ANO = ANO
        OB2.ID = ID
        OB2.USUARIO = USUARIO
        OB2.JUSTIFICACION = JUSTIFICACION
        OB2.CJ = CJA

        Return OBJ.ActualizarJustificacion(OB2)



    End Function
End Class
