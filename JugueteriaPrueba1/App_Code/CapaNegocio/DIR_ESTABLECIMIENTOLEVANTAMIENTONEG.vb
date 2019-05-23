Imports System.Data


public class DIR_ESTABLECIMIENTOLEVANTAMIENTONEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval DIR_ESTABLECIMIENTOLEVANTAMIENTO as DIR_ESTABLECIMIENTOLEVANTAMIENTOENT)
       Try
           Dim DIR_ESTABLECIMIENTOLEVANTAMIENTODatos as new DIR_ESTABLECIMIENTOLEVANTAMIENTODAT
           DIR_ESTABLECIMIENTOLEVANTAMIENTODatos.insertar(DIR_ESTABLECIMIENTOLEVANTAMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal spInsertar As StoredProcedure_class, ByVal sqlCmdInsertar As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            Dim DIR_ESTABLECIMIENTOLEVANTAMIENTODatos As New DIR_ESTABLECIMIENTOLEVANTAMIENTODAT
            DIR_ESTABLECIMIENTOLEVANTAMIENTODatos.Insertar(dr, spInsertar, sqlCmdInsertar, usuario_actualizacion, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
   Public Sub Actualizar(byval DIR_ESTABLECIMIENTOLEVANTAMIENTO as DIR_ESTABLECIMIENTOLEVANTAMIENTOENT)
       Try
           Dim DIR_ESTABLECIMIENTOLEVANTAMIENTODatos as new DIR_ESTABLECIMIENTOLEVANTAMIENTODAT
           DIR_ESTABLECIMIENTOLEVANTAMIENTODatos.actualizar(DIR_ESTABLECIMIENTOLEVANTAMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval DIR_ESTABLECIMIENTOLEVANTAMIENTO as DIR_ESTABLECIMIENTOLEVANTAMIENTOENT)
       Try
           Dim DIR_ESTABLECIMIENTOLEVANTAMIENTODatos as new DIR_ESTABLECIMIENTOLEVANTAMIENTODAT
           DIR_ESTABLECIMIENTOLEVANTAMIENTODatos.eliminar(DIR_ESTABLECIMIENTOLEVANTAMIENTO)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as DIR_ESTABLECIMIENTOLEVANTAMIENTOENT()
       Try
           Dim DIR_ESTABLECIMIENTOLEVANTAMIENTODatos as new DIR_ESTABLECIMIENTOLEVANTAMIENTODAT
           return DIR_ESTABLECIMIENTOLEVANTAMIENTODatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

    Public Function ListarUsuariobuscador(ByVal rol As String, ByVal encuesta As Integer) As DIR_ESTABLECIMIENTOLEVANTAMIENTOENT()
        Try
            Dim DIR_ESTABLECIMIENTOLEVANTAMIENTODatos As New DIR_ESTABLECIMIENTOLEVANTAMIENTODAT
            Return DIR_ESTABLECIMIENTOLEVANTAMIENTODatos.ListarUsuarioBuscador(rol, encuesta)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarRol(ByVal rut As Integer, ByVal encuesta As Integer) As DIR_ESTABLECIMIENTOLEVANTAMIENTOENT()
        Try
            Dim DIR_ESTABLECIMIENTOLEVANTAMIENTODatos As New DIR_ESTABLECIMIENTOLEVANTAMIENTODAT
            Return DIR_ESTABLECIMIENTOLEVANTAMIENTODatos.ListarRol(rut, encuesta)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function Verificar(ByVal Rol As Integer, ByVal id_encuestas As Integer) As Boolean
        Try
            Dim DIR_ESTABLECIMIENTOLEVANTAMIENTODatos As New DIR_ESTABLECIMIENTOLEVANTAMIENTODAT
            Return DIR_ESTABLECIMIENTOLEVANTAMIENTODatos.Verificar(Rol, id_encuestas)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "METODOS LLENAR PANELES"
    Public Function ListarPanelEstablecimiento(ByVal rol As Integer, ByVal encuesta As Integer) As DataTable
        Try
            Dim DIR_ESTABLECIMIENTOLEVANTAMIENTODatos As New DIR_ESTABLECIMIENTOLEVANTAMIENTODAT
            Return DIR_ESTABLECIMIENTOLEVANTAMIENTODatos.ListarPanelEstablecimiento(rol, encuesta)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region
#Region "OBTENER ROL"
    Public Function obtenerrol(ByVal rut As Integer, ByVal encuesta As Integer) As DataTable
        Try
            Dim DIR_ESTABLECIMIENTOLEVANTAMIENTODatos As New DIR_ESTABLECIMIENTOLEVANTAMIENTODAT
            Return DIR_ESTABLECIMIENTOLEVANTAMIENTODatos.obtenerrol(rut, encuesta)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region
    
#Region "ArchivoExcel, OBTENER DATOS DE LA MUESTRA PARA POSTERIOR INSERCION"
    Public Function ObtenerDatosMuestraParaInsercion(ByVal dr As Data.DataRow, ByVal spObtenerDatos As StoredProcedure_class, ByVal sqlCmdObtenerDatos As Data.SqlClient.SqlCommand, ByVal periodo As Integer, ByVal ano As Integer) As Data.DataRow
        Try
            Dim DIR_ESTABLECIMIENTOLEVANTAMIENTODatos As New DIR_ESTABLECIMIENTOLEVANTAMIENTODAT
            Return DIR_ESTABLECIMIENTOLEVANTAMIENTODatos.ObtenerDatosMuestraParaInsercion(dr, spObtenerDatos, sqlCmdObtenerDatos, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region



#Region "LISTAR POR PERIODO"
    Public Function ListarPorPeriodo(ByVal ano As Integer, ByVal periodo As Integer) As Data.DataTable
        Try
            Dim DIR_ESTABLECIMIENTOLEVANTAMIENTODatos As New DIR_ESTABLECIMIENTOLEVANTAMIENTODAT
            Return DIR_ESTABLECIMIENTOLEVANTAMIENTODatos.ListarPorPeriodo(ano, periodo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region




End Class
