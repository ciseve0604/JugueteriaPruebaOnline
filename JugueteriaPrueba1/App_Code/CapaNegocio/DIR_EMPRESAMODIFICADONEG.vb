Imports System.Data


public class DIR_EMPRESAMODIFICADONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval DIR_EMPRESAMODIFICADO as DIR_EMPRESAMODIFICADOENT)
       Try
           Dim DIR_EMPRESAMODIFICADODatos as new DIR_EMPRESAMODIFICADODAT
           DIR_EMPRESAMODIFICADODatos.insertar(DIR_EMPRESAMODIFICADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Sub

    Public Sub Insertar(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer)
        Try
            Dim DIR_EMPRESAMODIFICADODatos As New DIR_EMPRESAMODIFICADODAT
            DIR_EMPRESAMODIFICADODatos.Insertar(sp, sqlCmd, dr, ano, periodo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

   Public Sub Actualizar(byval DIR_EMPRESAMODIFICADO as DIR_EMPRESAMODIFICADOENT)
       Try
           Dim DIR_EMPRESAMODIFICADODatos as new DIR_EMPRESAMODIFICADODAT
           DIR_EMPRESAMODIFICADODatos.actualizar(DIR_EMPRESAMODIFICADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval DIR_EMPRESAMODIFICADO as DIR_EMPRESAMODIFICADOENT)
       Try
           Dim DIR_EMPRESAMODIFICADODatos as new DIR_EMPRESAMODIFICADODAT
           DIR_EMPRESAMODIFICADODatos.eliminar(DIR_EMPRESAMODIFICADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as DIR_EMPRESAMODIFICADOENT()
       Try
           Dim DIR_EMPRESAMODIFICADODatos as new DIR_EMPRESAMODIFICADODAT
           return DIR_EMPRESAMODIFICADODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Function

    Public Function ListarPorPeriodo(ByVal ano As Integer, ByVal periodo As Integer) As Data.DataTable
        Try
            Dim DIR_EMPRESAMODIFICADODatos As New DIR_EMPRESAMODIFICADODAT
            Return DIR_EMPRESAMODIFICADODatos.ListarPorPeriodo(ano, periodo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region



#Region "ArchivoExcel, OBTENER DATOS DE DIR_EMPRESAMODIFICADO POSTERIOR INSERCION"
    Public Function ObtenerDatosParaInsercion(ByVal spObtenerDatos As StoredProcedure_class, ByVal sqlCmdObtenerDatos As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal ano As Integer, ByVal periodo As Integer) As Data.DataRow
        Try
            Dim DIR_EMPRESAMODIFICADODatos As New DIR_EMPRESAMODIFICADODAT
            Return DIR_EMPRESAMODIFICADODatos.ObtenerDatosParaInsercion(spObtenerDatos, sqlCmdObtenerDatos, dr, ano, periodo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "OBTENER DATO DE UNA EMPRESA POR PERIODO"
    Public Function ObtenerDatoEmpresaRutPeriodo(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal rut As Integer, ByVal periodo As Integer, ByVal ano As Integer) As Data.DataRow
        Try
            Dim DIR_EMPRESAMODIFICADODatos As New DIR_EMPRESAMODIFICADODAT
            Return DIR_EMPRESAMODIFICADODatos.ObtenerDatoEmpresaRutPeriodo(sp, sqlCmd, rut, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region
End Class
