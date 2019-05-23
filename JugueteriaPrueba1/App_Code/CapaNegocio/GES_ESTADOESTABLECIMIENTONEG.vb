Imports System.Data


public class GES_ESTADOESTABLECIMIENTONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GES_ESTADOESTABLECIMIENTO as GES_ESTADOESTABLECIMIENTOENT)
       Try
           Dim GES_ESTADOESTABLECIMIENTODatos as new GES_ESTADOESTABLECIMIENTODAT
           GES_ESTADOESTABLECIMIENTODatos.insertar(GES_ESTADOESTABLECIMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Sub

    Public Sub Insertar_conexion(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer, ByVal ID_ESTADOESTABLECIMIENTO As String)
        Try
            Dim GES_ESTADOESTABLECIMIENTODatos As New GES_ESTADOESTABLECIMIENTODAT
            GES_ESTADOESTABLECIMIENTODatos.Insertar_conexion(dr, sp, sqlCmd, usuario_actualizacion, periodo, ano, ID_ESTADOESTABLECIMIENTO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String)
        Try
            Dim GES_ESTADOESTABLECIMIENTODatos As New GES_ESTADOESTABLECIMIENTODAT
            GES_ESTADOESTABLECIMIENTODatos.Insertar(dr, sp, sqlCmd, usuario_actualizacion)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

   Public Sub Actualizar(byval GES_ESTADOESTABLECIMIENTO as GES_ESTADOESTABLECIMIENTOENT)
       Try
           Dim GES_ESTADOESTABLECIMIENTODatos as new GES_ESTADOESTABLECIMIENTODAT
           GES_ESTADOESTABLECIMIENTODatos.actualizar(GES_ESTADOESTABLECIMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GES_ESTADOESTABLECIMIENTO as GES_ESTADOESTABLECIMIENTOENT)
       Try
           Dim GES_ESTADOESTABLECIMIENTODatos as new GES_ESTADOESTABLECIMIENTODAT
           GES_ESTADOESTABLECIMIENTODatos.eliminar(GES_ESTADOESTABLECIMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GES_ESTADOESTABLECIMIENTOENT()
       Try
           Dim GES_ESTADOESTABLECIMIENTODatos as new GES_ESTADOESTABLECIMIENTODAT
           return GES_ESTADOESTABLECIMIENTODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#End Region

#Region "OBTENER ESTADO DEL ESTABLECIMIENTO"
    Public Function estadoestablecimiento(ByVal rol As Integer, ByVal encuesta As Integer) As DataTable
        Try
            Dim GES_ESTADOESTABLECIMIENTODatos As New GES_ESTADOESTABLECIMIENTODAT

            Return GES_ESTADOESTABLECIMIENTODatos.obtenerestadoestablecimiento(rol, encuesta)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

#End Region

#Region "ACTUALIZAR EL ESTADO DEL ESTABLECIMIENTO"
    Public Sub ActualizarEstado(ByVal ROL As Integer, ByVal encuesta As Integer, ByVal estado As Integer, ByVal usuario As String)
        Try
            Dim GES_ESTADOESTABLECIMIENTODatos As New GES_ESTADOESTABLECIMIENTODAT
            GES_ESTADOESTABLECIMIENTODatos.ActualizarEstado(ROL, encuesta, estado, usuario)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "INSERTAR EL ESTADO DEL ESTABLECIMIENTO CUANDO SE CARGA LA MUESTRA"
    Public Sub MuestraInsertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String)
        Try
            Dim GES_ESTADOESTABLECIMIENTODatos As New GES_ESTADOESTABLECIMIENTODAT
            GES_ESTADOESTABLECIMIENTODatos.MuestraInsertar(dr, sp, sqlCmd, usuario_actualizacion)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "INSERTAR EL ESTADO DEL ESTABLECIMIENTO CUANDO SE LEVANTA DESDE EXCEL"
    Public Sub LevantamientoExcelInsertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String)
        Try
            Dim GES_ESTADOESTABLECIMIENTODatos As New GES_ESTADOESTABLECIMIENTODAT
            GES_ESTADOESTABLECIMIENTODatos.LevantamientoExcelInsertar(dr, sp, sqlCmd, usuario_actualizacion)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "LISTAR A TABLA"
    Public Function ListarAtabla() As Data.DataTable
        Try
            Dim GES_ESTADOESTABLECIMIENTODatos As New GES_ESTADOESTABLECIMIENTODAT
            Return GES_ESTADOESTABLECIMIENTODatos.ListarATabla()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region


End Class
