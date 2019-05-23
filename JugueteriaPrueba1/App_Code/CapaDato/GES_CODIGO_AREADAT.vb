Imports System.Data


public class GES_CODIGO_AREADAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GES_CODIGO_AREA as GES_CODIGO_AREAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_CODIGO_AREA_Insertar")
           sp.AgregarParametro("ID",GES_CODIGO_AREA.ID)
           sp.AgregarParametro("CODIGO",GES_CODIGO_AREA.CODIGO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GES_CODIGO_AREA as GES_CODIGO_AREAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_CODIGO_AREA_Actualizar")
           sp.AgregarParametro("ID",GES_CODIGO_AREA.ID)
           sp.AgregarParametro("CODIGO",GES_CODIGO_AREA.CODIGO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_CODIGO_AREA_Eliminar")
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

   Public Function Listar() as GES_CODIGO_AREAENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GES_CODIGO_AREA_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GES_CODIGO_AREA(dt.Rows.count() - 1) as GES_CODIGO_AREAENT
           i = 0
           for each dr in dt.rows
                GES_CODIGO_AREA(i) = New GES_CODIGO_AREAENT()
                GES_CODIGO_AREA(i).ID = dr("ID")
                GES_CODIGO_AREA(i).CODIGO = dr("CODIGO")
                i = i + 1
           next
           return GES_CODIGO_AREA
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION

#Region "METODO LISTAR codigos area"

    Public Function ListarCod() As GES_CODIGO_AREAENT()
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim i As Integer
            Dim sp As New StoredProcedure_class("SP_GES_CODIGO_AREA_ListarCod")
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim GES_CODIGO_AREA(dt.Rows.Count() - 1) As GES_CODIGO_AREAENT
            i = 0
            For Each dr In dt.Rows
                GES_CODIGO_AREA(i) = New GES_CODIGO_AREAENT()
                GES_CODIGO_AREA(i).id = dr("id")
                GES_CODIGO_AREA(i).codigo = dr("codigo")
                i = i + 1
            Next
            Return GES_CODIGO_AREA
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#End Region

#Region "OBTENER PARAMETROS"
    Public Function obtenercodigo(ByVal codigo) As DataTable
        Try
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_GES_CODIGO_AREA_ObtenerCodigo")
            sp.AgregarParametro("codigo_g", codigo)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
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
