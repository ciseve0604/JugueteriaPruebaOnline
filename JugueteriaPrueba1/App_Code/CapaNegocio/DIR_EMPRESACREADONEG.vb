Imports System.Data


public class DIR_EMPRESACREADONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval DIR_EMPRESACREADO as DIR_EMPRESACREADOENT)
       Try
           Dim DIR_EMPRESACREADODatos as new DIR_EMPRESACREADODAT
           DIR_EMPRESACREADODatos.insertar(DIR_EMPRESACREADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval DIR_EMPRESACREADO as DIR_EMPRESACREADOENT)
       Try
           Dim DIR_EMPRESACREADODatos as new DIR_EMPRESACREADODAT
           DIR_EMPRESACREADODatos.actualizar(DIR_EMPRESACREADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval DIR_EMPRESACREADO as DIR_EMPRESACREADOENT)
       Try
           Dim DIR_EMPRESACREADODatos as new DIR_EMPRESACREADODAT
           DIR_EMPRESACREADODatos.eliminar(DIR_EMPRESACREADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as DIR_EMPRESACREADOENT()
       Try
           Dim DIR_EMPRESACREADODatos as new DIR_EMPRESACREADODAT
           return DIR_EMPRESACREADODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Function

    Public Function ListarATabla() As Data.DataTable
        Try
            Dim DIR_EMPRESACREADODatos As New DIR_EMPRESACREADODAT
            Return DIR_EMPRESACREADODatos.ListarATabla()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region

#Region "ArchivoExcel, OBTENER DATOS DE DIR_EMPRESACREADO"
    Public Function ObtenerDatosParaInsercion(ByVal spObtenerDatos As StoredProcedure_class, ByVal sqlCmdObtenerDatos As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow) As Data.DataRow
        Try
            Dim DIR_EMPRESACREADODatos As New DIR_EMPRESACREADODAT
            Return DIR_EMPRESACREADODatos.ObtenerDatosParaInsercion(spObtenerDatos, sqlCmdObtenerDatos, dr)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region
end class
