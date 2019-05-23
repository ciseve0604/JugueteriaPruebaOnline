Imports Microsoft.VisualBasic

Public Class OBJ_SETJUSTIFICACIONDAT

#Region "METODO INGRESO"
    Public Function ActualizarJustificacion(ByVal OBJ As OBJ_SETJUSTIFICACIONENT) As Boolean
        Try
            Dim ROL As Integer = OBJ.ROL
            Dim PERIODO As Integer = OBJ.PERIODO
            Dim ANO As Integer = OBJ.ANO
            Dim ID As Integer = OBJ.ID
            Dim USUARIO As String = OBJ.USUARIO
            Dim JUSTIFICACION As String = OBJ.JUSTIFICACION
            Dim CJ As Integer = OBJ.CJ

            Dim sp2 As New StoredProcedure_class("SP_INSERTAR_JUSTIFICACION")

            sp2.AgregarParametro("ROL", ROL)
            sp2.AgregarParametro("PERIODO", PERIODO)
            sp2.AgregarParametro("ANO", ANO)
            sp2.AgregarParametro("ID", ID)
            sp2.AgregarParametro("USUARIO", USUARIO)
            sp2.AgregarParametro("JUSTIFICACION", JUSTIFICACION)
            sp2.AgregarParametro("CJ", CJ)
            sp2.EjecutarProcedimiento()

            Return True

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False

        End Try
    End Function
#End Region

End Class
