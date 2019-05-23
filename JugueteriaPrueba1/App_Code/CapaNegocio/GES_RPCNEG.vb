Imports System.Data


public class GES_RPCNEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GES_RPC as GES_RPCENT)
       Try
           Dim GES_RPCDatos as new GES_RPCDAT
           GES_RPCDatos.insertar(GES_RPC)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GES_RPC as GES_RPCENT)
       Try
           Dim GES_RPCDatos as new GES_RPCDAT
           GES_RPCDatos.actualizar(GES_RPC)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GES_RPC as GES_RPCENT)
       Try
           Dim GES_RPCDatos as new GES_RPCDAT
           GES_RPCDatos.eliminar(GES_RPC)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

    Public Function ListarComunas() As GES_RPCENT()
        Try
            Dim GES_RPCDatos As New GES_RPCDAT
            Return GES_RPCDatos.ListarComunas()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

   Public Function Listar() as GES_RPCENT()
       Try
           Dim GES_RPCDatos as new GES_RPCDAT
           return GES_RPCDatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Function

    Public Function ListarRegiones() As GES_RPCENT()
        Try
            Dim GES_RPCDatos As New GES_RPCDAT
            Return GES_RPCDatos.ListarRegiones()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarComunaRegion(ByVal region As Integer) As GES_RPCENT()
        Try
            Dim GES_RPCDatos As New GES_RPCDAT
            Return GES_RPCDatos.ListarComunaRegion(region)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarProvinciasRegion(ByVal region As Integer) As GES_RPCENT()
        Try
            Dim GES_RPCDatos As New GES_RPCDAT
            Return GES_RPCDatos.ListarProvinciasRegion(region)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarComunasProvincias(ByVal provincia As Integer) As GES_RPCENT()
        Try
            Dim GES_RPCDatos As New GES_RPCDAT
            Return GES_RPCDatos.ListarComunasProvincias(provincia)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerProvinciaPorComuna(ByVal comuna As Integer) As Integer
        Try
            Dim GES_RPCDatos As New GES_RPCDAT
            Return GES_RPCDatos.ObtenerProvinciaPorComuna(comuna)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#END REGION
end class
