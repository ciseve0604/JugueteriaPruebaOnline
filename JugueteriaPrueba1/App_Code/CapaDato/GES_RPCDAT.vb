Imports System.Data


public class GES_RPCDAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GES_RPC as GES_RPCENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_RPC_Insertar")
           sp.AgregarParametro("REGION",GES_RPC.REGION)
           sp.AgregarParametro("PROVINCIA",GES_RPC.PROVINCIA)
           sp.AgregarParametro("COMUNA",GES_RPC.COMUNA)
           sp.AgregarParametro("GLOSA",GES_RPC.GLOSA)
           sp.AgregarParametro("TIPO",GES_RPC.TIPO)
           sp.AgregarParametro("GLOSA_TIPO",GES_RPC.GLOSA_TIPO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GES_RPC as GES_RPCENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_RPC_Actualizar")
           sp.AgregarParametro("REGION",GES_RPC.REGION)
           sp.AgregarParametro("PROVINCIA",GES_RPC.PROVINCIA)
           sp.AgregarParametro("COMUNA",GES_RPC.COMUNA)
           sp.AgregarParametro("GLOSA",GES_RPC.GLOSA)
           sp.AgregarParametro("TIPO",GES_RPC.TIPO)
           sp.AgregarParametro("GLOSA_TIPO",GES_RPC.GLOSA_TIPO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_RPC_Eliminar")
'Aqui deben definir los parametros necesarios
           sp.AgregarParametro("","")
'Fin de parametros necesarios
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

#END REGION
#REGION "METODO LISTAR"

   Public Function Listar() as GES_RPCENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GES_RPC_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GES_RPC(dt.Rows.count() - 1) as GES_RPCENT
           i = 0
           for each dr in dt.rows
                GES_RPC(i) = New GES_RPCENT()
                GES_RPC(i).REGION = dr("REGION")
                GES_RPC(i).PROVINCIA = dr("PROVINCIA")
                GES_RPC(i).COMUNA = dr("COMUNA")
                GES_RPC(i).GLOSA = dr("GLOSA")
                GES_RPC(i).TIPO = dr("TIPO")
                GES_RPC(i).GLOSA_TIPO = dr("GLOSA_TIPO")
                i = i + 1
           next
           return GES_RPC
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Function

    Public Function ListarComunas() As GES_RPCENT()
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim i As Integer
            Dim sp As New StoredProcedure_class("SP_GES_RPC_ListarComuna")
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim GES_RPC(dt.Rows.Count() - 1) As GES_RPCENT
            i = 0
            For Each dr In dt.Rows
                GES_RPC(i) = New GES_RPCENT()
                GES_RPC(i).REGION = dr("REGION")
                GES_RPC(i).PROVINCIA = dr("PROVINCIA")
                GES_RPC(i).COMUNA = dr("COMUNA")
                GES_RPC(i).GLOSA = dr("GLOSA")
                GES_RPC(i).TIPO = dr("TIPO")
                GES_RPC(i).GLOSA_TIPO = dr("GLOSA_TIPO")
                i = i + 1
            Next
            Return GES_RPC
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function ListarRegiones() As GES_RPCENT()
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim i As Integer
            Dim sp As New StoredProcedure_class("SP_GES_RPC_ListarRegiones")
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim GES_RPC(dt.Rows.Count() - 1) As GES_RPCENT
            i = 0
            For Each dr In dt.Rows
                GES_RPC(i) = New GES_RPCENT()
                GES_RPC(i).REGION = dr("REGION")
                GES_RPC(i).GLOSA = dr("GLOSA")
                i = i + 1
            Next
            Return GES_RPC
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function ListarComunaRegion(ByVal region As String) As GES_RPCENT()
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim i As Integer
            Dim sp As New StoredProcedure_class("SP_GES_RPC_ListarRegionesComuna")
            sp.AgregarParametro("REGION", region)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim GES_RPC(dt.Rows.Count() - 1) As GES_RPCENT
            i = 0
            For Each dr In dt.Rows
                GES_RPC(i) = New GES_RPCENT()
                GES_RPC(i).COMUNA = dr("COMUNA")
                GES_RPC(i).GLOSA = dr("GLOSA")
                i = i + 1
            Next
            Return GES_RPC
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarProvinciasRegion(ByVal region As String) As GES_RPCENT()
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim i As Integer
            Dim sp As New StoredProcedure_class("SP_GES_RPC_ListarProvinciasporRegion")
            sp.AgregarParametro("region", region)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim GES_RPC(dt.Rows.Count() - 1) As GES_RPCENT
            i = 0
            For Each dr In dt.Rows
                GES_RPC(i) = New GES_RPCENT()
                GES_RPC(i).PROVINCIA = dr("PROVINCIA")
                GES_RPC(i).GLOSA = dr("GLOSA")
                i = i + 1
            Next
            Return GES_RPC
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function ListarComunasProvincias(ByVal provincia As String) As GES_RPCENT()
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim i As Integer
            Dim sp As New StoredProcedure_class("SP_GES_RPC_ListarComunasporProvincias")
            sp.AgregarParametro("provincia", provincia)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim GES_RPC(dt.Rows.Count() - 1) As GES_RPCENT
            i = 0
            For Each dr In dt.Rows
                GES_RPC(i) = New GES_RPCENT()
                GES_RPC(i).COMUNA = dr("COMUNA")
                GES_RPC(i).GLOSA = dr("GLOSA")
                i = i + 1
            Next
            Return GES_RPC
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "METODO OBTENER PROVINCIA"
    Public Function ObtenerProvinciaPorComuna(ByVal comuna As String) As Integer
        Try
            Dim dr As DataRow
            Dim dt As Data.DataTable
            Dim sp As New StoredProcedure_class("SP_GES_RPC_ObtenerProvinciaPorComuna")
            sp.AgregarParametro("comuna", comuna)
            dt = sp.EjecutarProcedimiento().Tables(0)
            dr = dt.Rows(0)

            Return dr("PROVINCIA")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
