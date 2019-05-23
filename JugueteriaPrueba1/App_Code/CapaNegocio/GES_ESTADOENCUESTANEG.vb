Imports System.Data


public class GES_ESTADOENCUESTANEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GES_ESTADOENCUESTA as GES_ESTADOENCUESTAENT)
       Try
           Dim GES_ESTADOENCUESTADatos as new GES_ESTADOENCUESTADAT
           GES_ESTADOENCUESTADatos.insertar(GES_ESTADOENCUESTA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GES_ESTADOENCUESTA as GES_ESTADOENCUESTAENT)
       Try
           Dim GES_ESTADOENCUESTADatos as new GES_ESTADOENCUESTADAT
           GES_ESTADOENCUESTADatos.actualizar(GES_ESTADOENCUESTA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GES_ESTADOENCUESTA as GES_ESTADOENCUESTAENT)
       Try
           Dim GES_ESTADOENCUESTADatos as new GES_ESTADOENCUESTADAT
           GES_ESTADOENCUESTADatos.eliminar(GES_ESTADOENCUESTA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GES_ESTADOENCUESTAENT()
       Try
           Dim GES_ESTADOENCUESTADatos as new GES_ESTADOENCUESTADAT
           return GES_ESTADOENCUESTADatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#End Region

#Region "INSERTAR CON PASO DEL PROCEDIMIENTO, CONEXIÓN EXTERNA"
    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal id_estadoencuesta As Integer, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal periodo As Integer, ByVal ano As Integer, ByVal usuario_actualizacion As String)
        Try
            Dim GES_ESTADOENCUESTADatos As New GES_ESTADOENCUESTADAT
            GES_ESTADOENCUESTADatos.Insertar(dr, id_estadoencuesta, sp, sqlCmd, periodo, ano, usuario_actualizacion)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "OBTENER MÁXIMO ESTADO DE ENCUESTA UN ROL EN UN PERIODO"
    Public Function ObtenerEstado(ByVal rol As Integer, ByVal periodo As Integer, ByVal ano As Integer) As Integer
        Try
            Dim GES_ESTADOENCUESTADatos As New GES_ESTADOENCUESTADAT

            Return GES_ESTADOENCUESTADatos.ObtenerEstado(rol, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
#End Region

#Region "OBTENER LOS ESTADOS DE UN ROL EN ESPECÍFICO POR PERIODO"
    Public Function ListarPorRolPeriodo(ByVal rol As Integer, ByVal periodo As Integer, ByVal ano As Integer) As GES_ESTADOENCUESTAENT()
        Try
            Dim GES_ESTADOENCUESTADatos As New GES_ESTADOENCUESTADAT
            Return GES_ESTADOENCUESTADatos.ListarPorRolPeriodo(rol, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "ELIMINAR ESTADO DE LA ENCUESTA SEGÚN ROL, PERIODO, ANO"
    Public Sub eliminarPorRolPeriodo(ByVal rol As Integer, ByVal estadoEncuesta As Integer, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            Dim GES_ESTADOENCUESTADatos As New GES_ESTADOENCUESTADAT
            GES_ESTADOENCUESTADatos.eliminarPorRolPeriodo(rol, estadoEncuesta, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "LISTA EL NÚMERO DE ROLES QUE SE ENCUENTRAN EN LOS DISTINTOS ESTADOS DE LA ENCUESTA, POR PERIODO"
    Public Function ListarEstadosEncuestasTodos(ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim GES_ESTADOENCUESTADatos As New GES_ESTADOENCUESTADAT
            Return GES_ESTADOENCUESTADatos.ListarEstadosEncuestasTodos(periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "LISTA EL NÚMERO DE ROLES QUE SE ENCUENTRAN EN LOS DISTINTOS ESTADOS DE LA ENCUESTA, POR CARGA DEL ANALISTA Y POR PERIODO"
    Public Function ListarEstadosEncuestasPorAnalista(ByVal nombre_usuario As String, ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim GES_ESTADOENCUESTADatos As New GES_ESTADOENCUESTADAT
            Return GES_ESTADOENCUESTADatos.ListarEstadosEncuestasPorAnalista(nombre_usuario, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region
end class
