Imports Microsoft.VisualBasic

Public Class OBJ_CALCULODAT
    Public Function ObtenerValor(ByVal OBJ As OBJ_CALCULOENT) As OBJ_CALCULOENT
        Try

            Dim dt As Data.DataTable
            Dim RegionDAT As Integer = OBJ.RegionDAT
            Dim ClaseDAT As Integer = OBJ.ClaseDAT
            Dim DTuristico As Integer = OBJ.DTuristico
            Dim user As String = OBJ.user
            Dim tipo As String = OBJ.tipo
            Dim Periodo As Integer = OBJ.periodo
            Dim Ano As Integer = OBJ.ano

            If tipo = 11 Then
                Dim sp2 As New StoredProcedure_class("SP_CALCULO_LLEGADA_PASAJEROS_TOTAL")
                sp2.AgregarParametro("REGION", RegionDAT.ToString)
                sp2.AgregarParametro("ID_CLASE", ClaseDAT.ToString)
                sp2.AgregarParametro("ID_DESTINO", DTuristico.ToString)
                sp2.AgregarParametro("PERIODO", Periodo.ToString)
                sp2.AgregarParametro("ANO", Ano.ToString)
                sp2.AgregarParametro("USER", user)
                dt = sp2.EjecutarProcedimiento().Tables(0)

            ElseIf tipo = 12 Then
                Dim sp2 As New StoredProcedure_class("SP_CALCULO_LLEGADA_PASAJEROS_CHILE")
                sp2.AgregarParametro("REGION", RegionDAT.ToString)
                sp2.AgregarParametro("ID_CLASE", ClaseDAT.ToString)
                sp2.AgregarParametro("ID_DESTINO", DTuristico.ToString)
                sp2.AgregarParametro("PERIODO", Periodo.ToString)
                sp2.AgregarParametro("ANO", Ano.ToString)
                sp2.AgregarParametro("USER", user)
                dt = sp2.EjecutarProcedimiento().Tables(0)

            ElseIf tipo = 13 Then
                Dim sp2 As New StoredProcedure_class("SP_CALCULO_LLEGADA_PASAJEROS_EXTRANJEROS")
                sp2.AgregarParametro("REGION", RegionDAT.ToString)
                sp2.AgregarParametro("ID_CLASE", ClaseDAT.ToString)
                sp2.AgregarParametro("ID_DESTINO", DTuristico.ToString)
                sp2.AgregarParametro("PERIODO", Periodo.ToString)
                sp2.AgregarParametro("ANO", Ano.ToString)
                sp2.AgregarParametro("USER", user)
                dt = sp2.EjecutarProcedimiento().Tables(0)

            ElseIf tipo = 21 Then
                Dim sp2 As New StoredProcedure_class("SP_CALCULO_PERNOCTACION_PASAJEROS_TOTAL")
                sp2.AgregarParametro("REGION", RegionDAT.ToString)
                sp2.AgregarParametro("ID_CLASE", ClaseDAT.ToString)
                sp2.AgregarParametro("ID_DESTINO", DTuristico.ToString)
                sp2.AgregarParametro("PERIODO", Periodo.ToString)
                sp2.AgregarParametro("ANO", Ano.ToString)
                sp2.AgregarParametro("USER", user)
                dt = sp2.EjecutarProcedimiento().Tables(0)

            ElseIf tipo = 22 Then
                Dim sp2 As New StoredProcedure_class("SP_CALCULO_PERNOCTACION_PASAJEROS_CHILE")
                sp2.AgregarParametro("REGION", RegionDAT.ToString)
                sp2.AgregarParametro("ID_CLASE", ClaseDAT.ToString)
                sp2.AgregarParametro("ID_DESTINO", DTuristico.ToString)
                sp2.AgregarParametro("PERIODO", Periodo.ToString)
                sp2.AgregarParametro("ANO", Ano.ToString)
                sp2.AgregarParametro("USER", user)
                dt = sp2.EjecutarProcedimiento().Tables(0)

            ElseIf tipo = 23 Then
                Dim sp2 As New StoredProcedure_class("SP_CALCULO_PERNOCTACION_PASAJEROS_EXTRANJERO")
                sp2.AgregarParametro("REGION", RegionDAT.ToString)
                sp2.AgregarParametro("ID_CLASE", ClaseDAT.ToString)
                sp2.AgregarParametro("ID_DESTINO", DTuristico.ToString)
                sp2.AgregarParametro("PERIODO", Periodo.ToString)
                sp2.AgregarParametro("ANO", Ano.ToString)
                sp2.AgregarParametro("USER", user)
                dt = sp2.EjecutarProcedimiento().Tables(0)

            ElseIf tipo = 31 Then
                Dim sp2 As New StoredProcedure_class("SP_CALCULO_EMEDIA_PASAJEROS_TOTAL")
                sp2.AgregarParametro("REGION", RegionDAT.ToString)
                sp2.AgregarParametro("ID_CLASE", ClaseDAT.ToString)
                sp2.AgregarParametro("ID_DESTINO", DTuristico.ToString)
                sp2.AgregarParametro("PERIODO", Periodo.ToString)
                sp2.AgregarParametro("ANO", Ano.ToString)
                sp2.AgregarParametro("USER", user)
                dt = sp2.EjecutarProcedimiento().Tables(0)

            ElseIf tipo = 32 Then
                Dim sp2 As New StoredProcedure_class("SP_CALCULO_EMEDIA_PASAJEROS_CHILE")
                sp2.AgregarParametro("REGION", RegionDAT.ToString)
                sp2.AgregarParametro("ID_CLASE", ClaseDAT.ToString)
                sp2.AgregarParametro("ID_DESTINO", DTuristico.ToString)
                sp2.AgregarParametro("PERIODO", Periodo.ToString)
                sp2.AgregarParametro("ANO", Ano.ToString)
                sp2.AgregarParametro("USER", user)
                dt = sp2.EjecutarProcedimiento().Tables(0)

            ElseIf tipo = 33 Then
                Dim sp2 As New StoredProcedure_class("SP_CALCULO_EMEDIA_PASAJEROS_EXTRANJEROS")
                sp2.AgregarParametro("REGION", RegionDAT.ToString)
                sp2.AgregarParametro("ID_CLASE", ClaseDAT.ToString)
                sp2.AgregarParametro("ID_DESTINO", DTuristico.ToString)
                sp2.AgregarParametro("PERIODO", Periodo.ToString)
                sp2.AgregarParametro("ANO", Ano.ToString)
                sp2.AgregarParametro("USER", user)
                dt = sp2.EjecutarProcedimiento().Tables(0)

            ElseIf tipo = 4 Then
                Dim sp2 As New StoredProcedure_class("SP_CALCULO_TASAOCUPACIONHABITACION")
                sp2.AgregarParametro("REGION", RegionDAT.ToString)
                sp2.AgregarParametro("ID_CLASE", ClaseDAT.ToString)
                sp2.AgregarParametro("ID_DESTINO", DTuristico.ToString)
                sp2.AgregarParametro("PERIODO", Periodo.ToString)
                sp2.AgregarParametro("ANO", Ano.ToString)
                sp2.AgregarParametro("USER", user)
                dt = sp2.EjecutarProcedimiento().Tables(0)
            ElseIf tipo = 5 Then
                Dim sp2 As New StoredProcedure_class("SP_CALCULO_TASAOCUPACIONPLAZA")
                sp2.AgregarParametro("REGION", RegionDAT.ToString)
                sp2.AgregarParametro("ID_CLASE", ClaseDAT.ToString)
                sp2.AgregarParametro("ID_DESTINO", DTuristico.ToString)
                sp2.AgregarParametro("PERIODO", Periodo.ToString)
                sp2.AgregarParametro("ANO", Ano.ToString)
                sp2.AgregarParametro("USER", user)
                dt = sp2.EjecutarProcedimiento().Tables(0)
            ElseIf tipo = 6 Then
                Dim sp2 As New StoredProcedure_class("SP_CALCULO_RevPAR")
                sp2.AgregarParametro("REGION", RegionDAT.ToString)
                sp2.AgregarParametro("ID_CLASE", ClaseDAT.ToString)
                sp2.AgregarParametro("ID_DESTINO", DTuristico.ToString)
                sp2.AgregarParametro("PERIODO", Periodo.ToString)
                sp2.AgregarParametro("ANO", Ano.ToString)
                sp2.AgregarParametro("USER", user)
                dt = sp2.EjecutarProcedimiento().Tables(0)
            ElseIf tipo = 7 Then
                Dim sp2 As New StoredProcedure_class("SP_CALCULO_ADR")
                sp2.AgregarParametro("REGION", RegionDAT.ToString)
                sp2.AgregarParametro("ID_CLASE", ClaseDAT.ToString)
                sp2.AgregarParametro("ID_DESTINO", DTuristico.ToString)
                sp2.AgregarParametro("PERIODO", Periodo.ToString)
                sp2.AgregarParametro("ANO", Ano.ToString)
                sp2.AgregarParametro("USER", user)
                dt = sp2.EjecutarProcedimiento().Tables(0)
            ElseIf tipo = 8 Then
                Dim sp2 As New StoredProcedure_class("SP_CALCULO_VAR_12_MESES")
                sp2.AgregarParametro("REGION", RegionDAT.ToString)
                sp2.AgregarParametro("ID_CLASE", ClaseDAT.ToString)
                sp2.AgregarParametro("ID_DESTINO", DTuristico.ToString)
                sp2.AgregarParametro("PERIODO", Periodo.ToString)
                sp2.AgregarParametro("ANO", Ano.ToString)
                sp2.AgregarParametro("USER", user)
                dt = sp2.EjecutarProcedimiento().Tables(0)
            End If

            If dt.Rows.Count = 0 Then
                OBJ.Valor = "0"
            Else
                OBJ.Valor = dt.Rows(0)(0).ToString
            End If

            Return OBJ

        Catch ex As Exception
            Throw New Exception(ex.Message)
            OBJ.Valor = "0"
            Return OBJ

        End Try
    End Function


End Class
