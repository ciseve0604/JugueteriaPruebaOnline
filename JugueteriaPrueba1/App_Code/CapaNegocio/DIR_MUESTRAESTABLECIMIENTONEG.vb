Imports System.Data


public class DIR_MUESTRAESTABLECIMIENTONEG

#REGION "METODOS DE LOGICA"

    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodoInicio As Integer, ByVal periodoFin As Integer, ByVal anoInicio As Integer, ByVal anoFin As Integer)
        Try
            Dim DIR_MUESTRAESTABLECIMIENTODatos As New DIR_MUESTRAESTABLECIMIENTODAT
            DIR_MUESTRAESTABLECIMIENTODatos.Insertar(dr, sp, sqlCmd, usuario_actualizacion, periodoInicio, periodoFin, anoInicio, anoFin)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

   Public Sub Actualizar(byval DIR_MUESTRAESTABLECIMIENTO as DIR_MUESTRAESTABLECIMIENTOENT)
       Try
           Dim DIR_MUESTRAESTABLECIMIENTODatos as new DIR_MUESTRAESTABLECIMIENTODAT
           DIR_MUESTRAESTABLECIMIENTODatos.actualizar(DIR_MUESTRAESTABLECIMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval DIR_MUESTRAESTABLECIMIENTO as DIR_MUESTRAESTABLECIMIENTOENT)
       Try
           Dim DIR_MUESTRAESTABLECIMIENTODatos as new DIR_MUESTRAESTABLECIMIENTODAT
           DIR_MUESTRAESTABLECIMIENTODatos.eliminar(DIR_MUESTRAESTABLECIMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as DIR_MUESTRAESTABLECIMIENTOENT()
       Try
           Dim DIR_MUESTRAESTABLECIMIENTODatos as new DIR_MUESTRAESTABLECIMIENTODAT
           return DIR_MUESTRAESTABLECIMIENTODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#End Region

#Region "LISTAR PANEL DEL LEVANTAMIENTO POR SISTEMA"
    Public Function ListarPanelLevantamiento(ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim DIR_MUESTRAESTABLECIMIENTODatos As New DIR_MUESTRAESTABLECIMIENTODAT
            Return DIR_MUESTRAESTABLECIMIENTODatos.ListarPanelLevantamiento(periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "LISTAR MUESTRA ESTABLECIMIENTO POR UN PERIODO EN ESPECÍFICO"
    Public Function ListarMuestraPorPeriodo(ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim DIR_MUESTRAESTABLECIMIENTODatos As New DIR_MUESTRAESTABLECIMIENTODAT
            Return DIR_MUESTRAESTABLECIMIENTODatos.ListarMuestraPorPeriodo(periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "LISTAR MUESTRA ESTABLECIMIENTO POR UN PERIODO EN ESPECÍFICO"
    Public Function ComprobarMuestra(ByVal periodoInicio As Integer, ByVal anoInicio As Integer) As Data.DataTable
        Try
            Dim DIR_MUESTRAESTABLECIMIENTODatos As New DIR_MUESTRAESTABLECIMIENTODAT
            Return DIR_MUESTRAESTABLECIMIENTODatos.ComprobarMuestra(periodoInicio, anoInicio)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region
end class
