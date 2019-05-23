Imports System.Data


public class GES_ESTANDARACCESODAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GES_ESTANDARACCESO as GES_ESTANDARACCESOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ESTANDARACCESO_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",GES_ESTANDARACCESO.ID_ENCUESTA)
           sp.AgregarParametro("NOMBRE_USUARIO",GES_ESTANDARACCESO.NOMBRE_USUARIO)
           sp.AgregarParametro("ID_TIPOACCESO",GES_ESTANDARACCESO.ID_TIPOACCESO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GES_ESTANDARACCESO as GES_ESTANDARACCESOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ESTANDARACCESO_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",GES_ESTANDARACCESO.ID_ENCUESTA)
           sp.AgregarParametro("NOMBRE_USUARIO",GES_ESTANDARACCESO.NOMBRE_USUARIO)
           sp.AgregarParametro("ID_TIPOACCESO",GES_ESTANDARACCESO.ID_TIPOACCESO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ESTANDARACCESO_Eliminar")
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

   Public Function Listar() as GES_ESTANDARACCESOENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GES_ESTANDARACCESO_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GES_ESTANDARACCESO(dt.Rows.count() - 1) as GES_ESTANDARACCESOENT
           i = 0
           for each dr in dt.rows
                GES_ESTANDARACCESO(i) = New GES_ESTANDARACCESOENT()
                GES_ESTANDARACCESO(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                GES_ESTANDARACCESO(i).NOMBRE_USUARIO = dr("NOMBRE_USUARIO")
                GES_ESTANDARACCESO(i).ID_TIPOACCESO = dr("ID_TIPOACCESO")
                i = i + 1
           next
           return GES_ESTANDARACCESO
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Function

    Public Function CargarListaInformaticosEncuesta(ByVal encuesta As String) As String()
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim i As Integer
            Dim sp As New StoredProcedure_class("SP_GES_ESTANDARACCESO_ListarInformaticos")
            sp.AgregarParametro("ENCUESTA", encuesta)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim correos(dt.Rows.Count() - 1) As String
            i = 0
            For Each dr In dt.Rows
                correos(i) = dr("email")
                i = i + 1
            Next
            Return correos
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#END REGION
#Region "METODO OBTENER PERFIL USUARIO"
    Public Function ObtenerPerfilUsuario(ByVal NOMBRE_USUARIO As String) As GES_ESTANDARACCESOENT
        Try
            Dim dt As Data.DataTable
            Dim dr As Data.DataRow
            Dim sp As New StoredProcedure_class("SP_GES_ESTANDARACCESO_ObtenerPerfilUsuario")

            sp.AgregarParametro("NOMBRE_USUARIO", NOMBRE_USUARIO)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim GES_ESTANDARACCESO As GES_ESTANDARACCESOENT = New GES_ESTANDARACCESOENT
            For Each dr In dt.Rows
                GES_ESTANDARACCESO.ID_ENCUESTA = dr("ID_ENCUESTA")
                GES_ESTANDARACCESO.NOMBRE_USUARIO = dr("NOMBRE_USUARIO")
                GES_ESTANDARACCESO.ID_TIPOACCESO = dr("ID_TIPOACCESO")
            Next
            Return GES_ESTANDARACCESO
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region
#Region "METODO Verificar"

    Public Function Verificar(ByVal user As String, ByVal encuesta As Integer, ByVal tipo As Integer) As Boolean
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim resp As Boolean
            Dim sp As New StoredProcedure_class("SP_GES_ESTANDARACCESO_Verificar")
            sp.AgregarParametro("user", user)
            sp.AgregarParametro("encuesta", encuesta)
            sp.AgregarParametro("tipo", tipo)
            dt = sp.EjecutarProcedimiento().Tables(0)
            For Each dr In dt.Rows
                resp = IIf(dr("resp") = 1, True, False)
            Next
            Return resp
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "CONSTRUCTORES DE LA CLASE"
    Public Sub New()

    End Sub
#End Region

End Class
