Imports System.Data


public class DIR_ESTABLECIMIENTOMODIFICADONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval DIR_ESTABLECIMIENTOMODIFICADO as DIR_ESTABLECIMIENTOMODIFICADOENT)
       Try
           Dim DIR_ESTABLECIMIENTOMODIFICADODatos as new DIR_ESTABLECIMIENTOMODIFICADODAT
           DIR_ESTABLECIMIENTOMODIFICADODatos.insertar(DIR_ESTABLECIMIENTOMODIFICADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Sub


    Public Sub Insertar(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer)
        Try
            Dim DIR_ESTABLECIMIENTOMODIFICADODatos As New DIR_ESTABLECIMIENTOMODIFICADODAT
            DIR_ESTABLECIMIENTOMODIFICADODatos.Insertar(sp, sqlCmd, dr, ano, periodo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


   Public Sub Actualizar(byval DIR_ESTABLECIMIENTOMODIFICADO as DIR_ESTABLECIMIENTOMODIFICADOENT)
       Try
           Dim DIR_ESTABLECIMIENTOMODIFICADODatos as new DIR_ESTABLECIMIENTOMODIFICADODAT
           DIR_ESTABLECIMIENTOMODIFICADODatos.actualizar(DIR_ESTABLECIMIENTOMODIFICADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval DIR_ESTABLECIMIENTOMODIFICADO as DIR_ESTABLECIMIENTOMODIFICADOENT)
       Try
           Dim DIR_ESTABLECIMIENTOMODIFICADODatos as new DIR_ESTABLECIMIENTOMODIFICADODAT
           DIR_ESTABLECIMIENTOMODIFICADODatos.eliminar(DIR_ESTABLECIMIENTOMODIFICADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as DIR_ESTABLECIMIENTOMODIFICADOENT()
       Try
           Dim DIR_ESTABLECIMIENTOMODIFICADODatos as new DIR_ESTABLECIMIENTOMODIFICADODAT
           return DIR_ESTABLECIMIENTOMODIFICADODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

    Public Function ListarPorPeriodo(ByVal ano As Integer, ByVal periodo As Integer) As Data.DataTable
        Try
            Dim DIR_ESTABLECIMIENTOMODIFICADODatos As New DIR_ESTABLECIMIENTOMODIFICADODAT
            Return DIR_ESTABLECIMIENTOMODIFICADODatos.ListarPorPeriodo(ano, periodo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region


#Region "ArchivoExcel, OBTENER LOS DATOS DEL ESTABLECIMIENTO"
    Public Function ObtenerDatosParaInsercion(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer) As Data.DataRow
        Try
            Dim DIR_ESTABLECIMIENTOMODIFICADODatos As New DIR_ESTABLECIMIENTOMODIFICADODAT
            Return DIR_ESTABLECIMIENTOMODIFICADODatos.ObtenerDatosParaInsercion(sp, sqlCmd, dr, ano, periodo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "LEVANTAMIENTO POR SISTEMA, "
    Public Function ListarPanelLevantamiento(ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim DIR_ESTABLECIMIENTOMODIFICADODatos As New DIR_ESTABLECIMIENTOMODIFICADODAT
            Return DIR_ESTABLECIMIENTOMODIFICADODatos.ListarPanelLevantamiento(periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region
end class
