Imports System.Data


public class DIR_ESTABLECIMIENTOCREADONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval DIR_ESTABLECIMIENTOCREADO as DIR_ESTABLECIMIENTOCREADOENT)
       Try
           Dim DIR_ESTABLECIMIENTOCREADODatos as new DIR_ESTABLECIMIENTOCREADODAT
           DIR_ESTABLECIMIENTOCREADODatos.insertar(DIR_ESTABLECIMIENTOCREADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval DIR_ESTABLECIMIENTOCREADO as DIR_ESTABLECIMIENTOCREADOENT)
       Try
           Dim DIR_ESTABLECIMIENTOCREADODatos as new DIR_ESTABLECIMIENTOCREADODAT
           DIR_ESTABLECIMIENTOCREADODatos.actualizar(DIR_ESTABLECIMIENTOCREADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval DIR_ESTABLECIMIENTOCREADO as DIR_ESTABLECIMIENTOCREADOENT)
       Try
           Dim DIR_ESTABLECIMIENTOCREADODatos as new DIR_ESTABLECIMIENTOCREADODAT
           DIR_ESTABLECIMIENTOCREADODatos.eliminar(DIR_ESTABLECIMIENTOCREADO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as DIR_ESTABLECIMIENTOCREADOENT()
       Try
           Dim DIR_ESTABLECIMIENTOCREADODatos as new DIR_ESTABLECIMIENTOCREADODAT
           return DIR_ESTABLECIMIENTOCREADODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Function

    Public Function ListarATabla() As Data.DataTable
        Try
            Dim DIR_ESTABLECIMIENTOCREADODatos As New DIR_ESTABLECIMIENTOCREADODAT
            Return DIR_ESTABLECIMIENTOCREADODatos.ListarATabla()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region

#Region "ArchivoExcel, Obtener datos desde empresas creadas para la insercion"
    Public Function ObtenerDatosParaInsercion(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow) As Data.DataRow
        Try
            Dim DIR_ESTABLECIMIENTOCREADODatos As New DIR_ESTABLECIMIENTOCREADODAT
            Return DIR_ESTABLECIMIENTOCREADODatos.ObtenerDatosParaInsercion(sp, sqlCmd, dr)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region
end class
