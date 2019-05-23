Imports System.Data


public class DIR_EMPRESAORIGINALNEG

#REGION "METODOS DE LOGICA"

    Public Sub Insertar(ByVal DIR_EMPRESAORIGINAL As DIR_EMPRESAORIGINALENT)
        Try
            Dim DIR_EMPRESAORIGINALDatos As New DIR_EMPRESAORIGINALDAT
            DIR_EMPRESAORIGINALDatos.Insertar(DIR_EMPRESAORIGINAL)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal spInsertar As StoredProcedure_class, ByVal sqlCmdInsertar As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            Dim DIR_EMPRESAORIGINALDatos As New DIR_EMPRESAORIGINALDAT
            DIR_EMPRESAORIGINALDatos.Insertar(dr, spInsertar, sqlCmdInsertar, usuario_actualizacion, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

   Public Sub Actualizar(byval DIR_EMPRESAORIGINAL as DIR_EMPRESAORIGINALENT)
       Try
           Dim DIR_EMPRESAORIGINALDatos as new DIR_EMPRESAORIGINALDAT
           DIR_EMPRESAORIGINALDatos.actualizar(DIR_EMPRESAORIGINAL)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval DIR_EMPRESAORIGINAL as DIR_EMPRESAORIGINALENT)
       Try
           Dim DIR_EMPRESAORIGINALDatos as new DIR_EMPRESAORIGINALDAT
           DIR_EMPRESAORIGINALDatos.eliminar(DIR_EMPRESAORIGINAL)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as DIR_EMPRESAORIGINALENT()
       Try
           Dim DIR_EMPRESAORIGINALDatos as new DIR_EMPRESAORIGINALDAT
           return DIR_EMPRESAORIGINALDatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function


    Public Function ListarUsuariobuscadorRut(ByVal rut As String, ByVal encuesta As Integer) As DIR_EMPRESAORIGINALENT()
        Try
            Dim DIR_EMPRESAORIGINALdat As New DIR_EMPRESAORIGINALDAT
            Return DIR_EMPRESAORIGINALdat.ListarUsuarioBuscadorRut(rut, encuesta)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


#End Region

#Region "VERIFICAR RUT"
    Public Function Verificar(ByVal rut As Integer, ByVal encuesta As Integer) As Boolean
        Try
            Dim DIR_EMPRESA As New DIR_EMPRESAORIGINALDAT
            Return DIR_EMPRESA.Verificar(rut, encuesta)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "METODOS LLENAR PANEL"
    Public Function ListarPanelEmpresa(ByVal rut As Integer, ByVal encuesta As Integer) As DataTable
        Try
            Dim DIR_EMPRESA As New DIR_EMPRESAORIGINALDAT

            Return DIR_EMPRESA.ListarPanelEmpresa(rut, encuesta)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

#End Region

#Region "ArchivoExcel, OBTENER DATOS DE LA MUESTRA PARA POSTERIOR INSERCION"
    Public Function ObtenerDatosMuestraParaInsercion(ByVal dr As Data.DataRow, ByVal spObtenerDatos As StoredProcedure_class, ByVal sqlCmdObtemerDatos As Data.SqlClient.SqlCommand, ByVal periodo As Integer, ByVal ano As Integer) As Data.DataRow
        Try
            Dim DIR_EMPRESAORIGINALDatos As New DIR_EMPRESAORIGINALDAT
            Return DIR_EMPRESAORIGINALDatos.ObtenerDatosMuestraParaInsercion(dr, spObtenerDatos, sqlCmdObtemerDatos, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "LISTAR POR PERIODO"
    Public Function ListarPorPeriodo(ByVal ano As Integer, ByVal periodo As Integer) As Data.DataTable
        Try
            Dim DIR_EMPRESAORIGINALDatos As New DIR_EMPRESAORIGINALDAT
            Return DIR_EMPRESAORIGINALDatos.ListarPorPeriodo(ano, periodo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region



End Class
