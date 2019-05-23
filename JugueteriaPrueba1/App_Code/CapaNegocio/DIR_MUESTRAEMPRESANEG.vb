Imports System.Data


public class DIR_MUESTRAEMPRESANEG

#REGION "METODOS DE LOGICA"

    Public Sub Insertar(ByVal DIR_MUESTRAEMPRESA As Data.DataRow, ByVal SP As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodoInicio As Integer, ByVal periodoFin As Integer, ByVal anoInicio As Integer, ByVal anoFin As Integer)
        Try
            Dim DIR_MUESTRAEMPRESADatos As New DIR_MUESTRAEMPRESADAT
            DIR_MUESTRAEMPRESADatos.Insertar(DIR_MUESTRAEMPRESA, SP, sqlCmd, usuario_actualizacion, periodoInicio, periodoFin, anoInicio, anoFin)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

   Public Sub Actualizar(byval DIR_MUESTRAEMPRESA as DIR_MUESTRAEMPRESAENT)
       Try
           Dim DIR_MUESTRAEMPRESADatos as new DIR_MUESTRAEMPRESADAT
           DIR_MUESTRAEMPRESADatos.actualizar(DIR_MUESTRAEMPRESA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval DIR_MUESTRAEMPRESA as DIR_MUESTRAEMPRESAENT)
       Try
           Dim DIR_MUESTRAEMPRESADatos as new DIR_MUESTRAEMPRESADAT
           DIR_MUESTRAEMPRESADatos.eliminar(DIR_MUESTRAEMPRESA)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as DIR_MUESTRAEMPRESAENT()
       Try
           Dim DIR_MUESTRAEMPRESADatos as new DIR_MUESTRAEMPRESADAT
           return DIR_MUESTRAEMPRESADatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

    

#End Region


#Region "OBTENER LOS DATOS DE UNA EMPRESA DE LA MUESTRA"
    Public Function ObtenerDatoEmpresaRutPeriodo(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal rut As Integer, ByVal periodo As Integer, ByVal ano As Integer) As Data.DataRow
        Try
            Dim DIR_MUESTRAEMPRESADatos As New DIR_MUESTRAEMPRESADAT
            Return DIR_MUESTRAEMPRESADatos.ObtenerDatoEmpresaRutPeriodo(sp, sqlCmd, rut, periodo, ano)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

End Class
