Imports System.Data


public class GES_ASIGNACIONCARGANEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GES_ASIGNACIONCARGA as GES_ASIGNACIONCARGAENT)
       Try
           Dim GES_ASIGNACIONCARGADatos as new GES_ASIGNACIONCARGADAT
           GES_ASIGNACIONCARGADatos.insertar(GES_ASIGNACIONCARGA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GES_ASIGNACIONCARGA as GES_ASIGNACIONCARGAENT)
       Try
           Dim GES_ASIGNACIONCARGADatos as new GES_ASIGNACIONCARGADAT
           GES_ASIGNACIONCARGADatos.actualizar(GES_ASIGNACIONCARGA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GES_ASIGNACIONCARGA as GES_ASIGNACIONCARGAENT)
       Try
           Dim GES_ASIGNACIONCARGADatos as new GES_ASIGNACIONCARGADAT
           GES_ASIGNACIONCARGADatos.eliminar(GES_ASIGNACIONCARGA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GES_ASIGNACIONCARGAENT()
       Try
           Dim GES_ASIGNACIONCARGADatos as new GES_ASIGNACIONCARGADAT
           return GES_ASIGNACIONCARGADatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#End Region

#Region "PERTENECE A LA CARGA ASIGNADA"
    Public Function PerteneceCargaRut(ByVal rut As Integer, ByVal id_encuesta As Integer, ByVal usuario As String) As DataTable
        Try
            Dim GES_ASIGNACIONCARGADatos As New GES_ASIGNACIONCARGADAT
            Return GES_ASIGNACIONCARGADatos.PerteneceCargaRut(rut, id_encuesta, usuario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function PerteneceCargaRol(ByVal rol As Integer, ByVal id_encuesta As Integer, ByVal usuario As String, ByVal periodo As Integer, ByVal ano As Integer) As DataTable
        Try
            Dim GES_ASIGNACIONCARGADatos As New GES_ASIGNACIONCARGADAT
            Return GES_ASIGNACIONCARGADatos.PerteneceCargaRol(rol, id_encuesta, usuario, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "INSERCIÓN DE CARGA DE TRABAJO"
    Public Sub InsertarCargaTrabajo(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            Dim GES_ASIGNACIONCARGADatos As New GES_ASIGNACIONCARGADAT
            GES_ASIGNACIONCARGADatos.InsertarCargaTrabajo(sp, sqlCmd, dr, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "LISTAR ROLES SIN ASIGNAR EN UN PERIODO ESPECÍFICO"
    Public Function ListarRolesSinAsignar(ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim GES_ASIGNACIONCARGADatos As New GES_ASIGNACIONCARGADAT
            Return GES_ASIGNACIONCARGADatos.ListarRolesSinAsignar(periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "LISTAR ANALISTAS, ANALISTAS REGIONALES Y DIGITADORES EN UNA SÓLA COLUMNA"
    Public Function Listar_A_AR_D_Unidos(ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim GES_ASIGNACIONCARGADatos As New GES_ASIGNACIONCARGADAT
            Return GES_ASIGNACIONCARGADatos.Listar_A_AR_D_Unidos(periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "LISTAR ROLES FILTRADOS"
    Public Function ListarRolesFiltrados(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal region As Integer, ByVal tipo_establecimiento As String, ByVal periodo As Integer, ByVal ano As Integer, ByVal usuario As String) As Data.DataTable
        Try
            Dim GES_ASIGNACIONCARGADatos As New GES_ASIGNACIONCARGADAT
            Return GES_ASIGNACIONCARGADatos.ListarRolesFiltrados(sp, sqlCmd, region, tipo_establecimiento, periodo, ano, usuario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "REASIGNAR LA CARGA DE TRABAJO"
    Public Sub ReasignarCarga(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal rol As Integer, ByVal origen As String, ByVal destino As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            Dim GES_ASIGNACIONCARGADatos As New GES_ASIGNACIONCARGADAT
            GES_ASIGNACIONCARGADatos.ReasignarCarga(sp, sqlCmd, rol, origen, destino, periodo, ano)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "LISTAR ROLES ASIGNADOS POR PERIODO A TABLA"
    Public Function ListarPorPeriodo(ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim GES_ASIGNACIONCARGADatos As New GES_ASIGNACIONCARGADAT
            Return GES_ASIGNACIONCARGADatos.ListarPorPeriodo(periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region
End Class
