Imports Microsoft.VisualBasic

Public Class OBJ_CALCULONEG

    Public Function ObtenerValorCalculo(ByVal Region As Integer, ByVal Clase As Integer, ByVal DTuristico As Integer, ByVal user As String, ByVal Tipo As Integer, ByVal Periodo As Integer, ByVal Ano As Integer) As OBJ_CALCULOENT
        '' Return OBJ.ObtenerValorCalculo(Region, Clase, DTuristico, Usuario, Tipo, Per, Ano)
        Dim OBJ As New OBJ_CALCULODAT
        Dim OBJ2 As New OBJ_CALCULOENT

        OBJ2.RegionDAT = Region
        OBJ2.ClaseDAT = Clase
        OBJ2.DTuristico = DTuristico
        OBJ2.user = user
        OBJ2.tipo = Tipo
        OBJ2.periodo = Periodo
        OBJ2.ano = Ano

        Return OBJ.ObtenerValor(OBJ2)

    End Function
End Class
