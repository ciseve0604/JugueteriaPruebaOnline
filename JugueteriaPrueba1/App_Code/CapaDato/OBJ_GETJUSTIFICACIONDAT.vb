Imports Microsoft.VisualBasic

Public Class OBJ_GETJUSTIFICACIONDAT

#Region "METODO INGRESO"
    Public Function GrillaCargarDAT(ByVal Campo As String, ByVal RolCap As String, ByVal periodo As String, ByVal ano As String, ByVal usuario As String) As OBJ_GETJUSTIFICACIONENT()

        Dim TablaJustificacion As Data.DataSet
        Dim sp2 As New StoredProcedure_class("SP_TABLA_JUSTIFICACION")

        sp2.AgregarParametro("ROL", RolCap)
        sp2.AgregarParametro("ano", ano)
        sp2.AgregarParametro("periodo", periodo)
        sp2.AgregarParametro("usuario", usuario)
        TablaJustificacion = sp2.EjecutarProcedimiento()

        Dim Seleccion() As Data.DataRow = TablaJustificacion.Tables(0).Select("campo  LIKE '%" & Campo & "%' ")

        Dim size As Integer = Seleccion.Length

        Dim ArregloObjetos(size) As OBJ_GETJUSTIFICACIONENT

        For q As Integer = 0 To size - 1
            ArregloObjetos(q) = New OBJ_GETJUSTIFICACIONENT
        Next q

        Dim i As Integer = 0

        For Each elemento As Data.DataRow In Seleccion
            Dim OBJ As New OBJ_GETJUSTIFICACIONENT
            OBJ.id = elemento("id")
            OBJ.usuario = elemento("usuario").ToString
            OBJ.campo = elemento("campo").ToString
            OBJ.T = elemento("T").ToString
            OBJ.T1 = elemento("T1").ToString
            OBJ.T12 = elemento("T12").ToString
            OBJ.rol = elemento("rol").ToString
            OBJ.dvrol = elemento("dvrol").ToString
            OBJ.respuesta = elemento("respuesta").ToString
            OBJ.justificacion = elemento("justificacion").ToString
            OBJ.periodo = elemento("periodo").ToString
            OBJ.ano = elemento("ano").ToString
            OBJ.justificadaCorregida = elemento("justificada_corregida").ToString
            ArregloObjetos(i) = OBJ
            i = i + 1
        Next

        Return ArregloObjetos
    End Function
#End Region
End Class
