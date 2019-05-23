Imports System.Data


public class GES_ESTADOEMPRESANEG

#REGION "METODOS DE LOGICA"

    Public Sub Insertar(ByVal GES_ESTADOEMPRESA As GES_ESTADOEMPRESAENT)
        Try
            Dim GES_ESTADOEMPRESADatos As New GES_ESTADOEMPRESADAT
            GES_ESTADOEMPRESADatos.Insertar(GES_ESTADOEMPRESA)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Public Sub Insertar_conexion(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal Ano As Integer, ByVal id_estadoempresa As String)
        Try
            Dim GES_ESTADOEMPRESADatos As New GES_ESTADOEMPRESADAT
            GES_ESTADOEMPRESADatos.Insertar_conexion(dr, sp, sqlCmd, usuario_actualizacion, periodo, Ano, id_estadoempresa)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String)
        Try
            Dim GES_ESTADOEMPRESADatos As New GES_ESTADOEMPRESADAT
            GES_ESTADOEMPRESADatos.Insertar(dr, sp, sqlCmd, usuario_actualizacion)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

   Public Sub Actualizar(byval GES_ESTADOEMPRESA as GES_ESTADOEMPRESAENT)
       Try
           Dim GES_ESTADOEMPRESADatos as new GES_ESTADOEMPRESADAT
           GES_ESTADOEMPRESADatos.actualizar(GES_ESTADOEMPRESA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GES_ESTADOEMPRESA as GES_ESTADOEMPRESAENT)
       Try
           Dim GES_ESTADOEMPRESADatos as new GES_ESTADOEMPRESADAT
           GES_ESTADOEMPRESADatos.eliminar(GES_ESTADOEMPRESA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GES_ESTADOEMPRESAENT()
       Try
           Dim GES_ESTADOEMPRESADatos as new GES_ESTADOEMPRESADAT
           return GES_ESTADOEMPRESADatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Function


#Region "OBTENER ESTADO DE LA EMPRESA"
    Public Function estadoempresa(ByVal rut As Integer, ByVal encuesta As Integer) As DataTable
        Try
            Dim GES_ESTADOEMPRESADatos As New GES_ESTADOEMPRESADAT

            Return GES_ESTADOEMPRESADatos.obtenerestadoempresa(rut, encuesta)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
#End Region

#Region "ACTUALIZAR EL ESTADO DE LA EMPRESA"
    Public Sub ActualizarEstado(ByVal rut As Integer, ByVal encuesta As Integer, ByVal estado As Integer, ByVal usuario As String)
        Try
            Dim GES_ESTADOEMPRESADatos As New GES_ESTADOEMPRESADAT
            GES_ESTADOEMPRESADatos.ActualizarEstado(rut, encuesta, estado, usuario)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "INSERTAR EL ESTADO DE LA EMPRESA CUANDO SE CARGA LA MUESTRA"
    Public Sub MuestraInsertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String)
        Try
            Dim GES_ESTADOEMPRESADatos As New GES_ESTADOEMPRESADAT
            GES_ESTADOEMPRESADatos.MuestraInsertar(dr, sp, sqlCmd, usuario_actualizacion)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "INSERTAR EL ESTADO DE LA EMPRESA CUANDO SE LEVANTA DESDE EL EXCEL"
    Public Sub LevantamientoExcelInsertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String)
        Try
            Dim GES_ESTADOEMPRESADatos As New GES_ESTADOEMPRESADAT
            GES_ESTADOEMPRESADatos.LevantamientoExcelInsertar(dr, sp, sqlCmd, usuario_actualizacion)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#END REGION
end class
