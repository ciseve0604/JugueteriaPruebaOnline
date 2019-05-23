Imports Microsoft.VisualBasic

Public Class GES_CALCULO_ENCNEG


#Region "METODOS DE LOGICA"

    Public Sub Insertar_actualizacion16reg(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer, ByVal usuario_actualizacion As String, ByVal procesoCargaImputacon As Integer)
        Try
            Dim GES_CALCULO_ENCDAT_obj As New GES_CALCULO_ENCDAT
            GES_CALCULO_ENCDAT_obj.Insertar_Actualizada16reg(dr, sp, sqlCmd, usuario_actualizacion, periodo, ano, procesoCargaImputacon)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Insertar(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer, ByVal usuario_actualizacion As String, ByVal procesoCargaImputacon As Integer)
        Try
            Dim GES_CALCULO_ENCDAT_obj As New GES_CALCULO_ENCDAT
            GES_CALCULO_ENCDAT_obj.Insertar_Actualizada16reg(dr, sp, sqlCmd, usuario_actualizacion, periodo, ano, procesoCargaImputacon)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Insertar_v2(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer, ByVal usuario_actualizacion As String)
        Try
            Dim GES_CALCULO_ENCDAT_obj As New GES_CALCULO_ENCDAT
            GES_CALCULO_ENCDAT_obj.Insertar_aemat(dr, sp, sqlCmd, usuario_actualizacion, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Insertar_v3(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer, ByVal usuario_actualizacion As String)
        Try
            Dim GES_CALCULO_ENCDAT_obj As New GES_CALCULO_ENCDAT
            GES_CALCULO_ENCDAT_obj.Insertar_Rectificar_noches_ocupadas(dr, sp, sqlCmd, usuario_actualizacion, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Insertar_v4(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer, ByVal usuario_actualizacion As String)
        Try
            Dim GES_CALCULO_ENCDAT_obj As New GES_CALCULO_ENCDAT
            GES_CALCULO_ENCDAT_obj.Insertar_Rectificar_Ingresos(dr, sp, sqlCmd, usuario_actualizacion, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Insertar_Historico_Rectificadas_Recepcionadas(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer, ByVal usuario_actualizacion As String)
        Try
            Dim GES_CALCULO_ENCDAT_obj As New GES_CALCULO_ENCDAT
            GES_CALCULO_ENCDAT_obj.Insertar_Rectificar_ua_plazas(dr, sp, sqlCmd, usuario_actualizacion, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Insertar_Historico_Personal_Ocupado(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer, ByVal usuario_actualizacion As String, ByVal opcionSeleccionada As Integer)
        Try
            Dim GES_CALCULO_ENCDAT_obj As New GES_CALCULO_ENCDAT
            GES_CALCULO_ENCDAT_obj.Insertar_Rectificar_personal(dr, sp, sqlCmd, usuario_actualizacion, periodo, ano, opcionSeleccionada)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub incorporar_rect_recep(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer, ByVal usuario_actualizacion As String)
        Try
            Dim GES_CALCULO_ENCDAT_obj As New GES_CALCULO_ENCDAT
            GES_CALCULO_ENCDAT_obj.Insertar_Rectificadas_Recepcionadas(dr, sp, sqlCmd, usuario_actualizacion, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Cambiar_estados_v1(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal usuario_actualizacion As String)
        Try
            Dim GES_CALCULO_ENCDAT_obj As New GES_CALCULO_ENCDAT
            GES_CALCULO_ENCDAT_obj.Realizar_cambio_estado_masivos(dr, sp, sqlCmd, usuario_actualizacion)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub incorporar_imputacion_esp(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer, ByVal usuario_actualizacion As String)
        Try
            Dim GES_CALCULO_ENCDAT_obj As New GES_CALCULO_ENCDAT
            GES_CALCULO_ENCDAT_obj.Insertar_imputacion_esperada(dr, sp, sqlCmd, usuario_actualizacion, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub eliminar_imputacion_recepcionada(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer, ByVal usuario_actualizacion As String)
        Try
            Dim GES_CALCULO_ENCDAT_obj As New GES_CALCULO_ENCDAT
            GES_CALCULO_ENCDAT_obj.eliminar_nui_bdc(dr, sp, sqlCmd, usuario_actualizacion, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#End Region

End Class
