Imports System.Data


public class GES_ESTADOEMPRESADAT

#REGION "METODO INGRESO"

    Public Sub Insertar_conexion(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer, ByVal ID_ESTADOEMPRESA As String)
        Try
            sp.AgregarParametro("ID_ENCUESTA", 1)
            sp.AgregarParametro("RUT", dr("RUT"))
            sp.AgregarParametro("ESTADOEMPRESA", ID_ESTADOEMPRESA.ToString)
            sp.AgregarParametro("USUARIO_ACTUALIZACION", usuario_actualizacion)
            sp.AgregarParametro("COMENTARIO", "")
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            sp.EjecutarProcedimiento(sqlCmd)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Public Sub Insertar(ByVal GES_ESTADOEMPRESA As GES_ESTADOEMPRESAENT)
        Try
            Dim sp As New StoredProcedure_class("SP_GES_ESTADOEMPRESA_Insertar")
            sp.AgregarParametro("ID_ENCUESTA", GES_ESTADOEMPRESA.ID_ENCUESTA)
            sp.AgregarParametro("RUT", GES_ESTADOEMPRESA.RUT)
            sp.AgregarParametro("ID_ESTADOEMPRESA", GES_ESTADOEMPRESA.ID_ESTADOEMPRESA)
            sp.AgregarParametro("FECHA_ACTUALIZACION", GES_ESTADOEMPRESA.FECHA_ACTUALIZACION)
            sp.AgregarParametro("USUARIO_ACTUALIZACION", GES_ESTADOEMPRESA.USUARIO_ACTUALIZACION)
            sp.AgregarParametro("COMENTARIO", GES_ESTADOEMPRESA.COMENTARIO)
            sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GES_ESTADOEMPRESA as GES_ESTADOEMPRESAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ESTADOEMPRESA_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",GES_ESTADOEMPRESA.ID_ENCUESTA)
           sp.AgregarParametro("RUT",GES_ESTADOEMPRESA.RUT)
           sp.AgregarParametro("ID_ESTADOEMPRESA",GES_ESTADOEMPRESA.ID_ESTADOEMPRESA)
           sp.AgregarParametro("FECHA_ACTUALIZACION",GES_ESTADOEMPRESA.FECHA_ACTUALIZACION)
           sp.AgregarParametro("USUARIO_ACTUALIZACION",GES_ESTADOEMPRESA.USUARIO_ACTUALIZACION)
           sp.AgregarParametro("COMENTARIO",GES_ESTADOEMPRESA.COMENTARIO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ESTADOEMPRESA_Eliminar")
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

   Public Function Listar() as GES_ESTADOEMPRESAENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GES_ESTADOEMPRESA_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GES_ESTADOEMPRESA(dt.Rows.count() - 1) as GES_ESTADOEMPRESAENT
           i = 0
           for each dr in dt.rows
                GES_ESTADOEMPRESA(i) = New GES_ESTADOEMPRESAENT()
                GES_ESTADOEMPRESA(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                GES_ESTADOEMPRESA(i).RUT = dr("RUT")
                GES_ESTADOEMPRESA(i).ID_ESTADOEMPRESA = dr("ID_ESTADOEMPRESA")
                GES_ESTADOEMPRESA(i).FECHA_ACTUALIZACION = dr("FECHA_ACTUALIZACION")
                GES_ESTADOEMPRESA(i).USUARIO_ACTUALIZACION = dr("USUARIO_ACTUALIZACION")
                GES_ESTADOEMPRESA(i).COMENTARIO = dr("COMENTARIO")
                i = i + 1
           next
           return GES_ESTADOEMPRESA
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION

#Region "OBTENER DATO EMPRESA"
    Public Function obtenerestadoempresa(ByVal rut As Integer, ByVal encuesta As Integer) As DataTable
        Try
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_GES_ESTADOEMPRESA_ObtenerEstadoEmpresa")
            sp.AgregarParametro("RUT", rut)
            sp.AgregarParametro("ID_ENCUESTA", encuesta)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
#End Region

#Region "INSERTAR EL ESTADO DE LA EMPRESA CUANDO SE CARGA LA MUESTRA"
    Public Sub MuestraInsertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String)
        Try
            'Dim sp As New StoredProcedure_class("SP_GES_ESTADOEMPRESA_Insertar")
            sp.AgregarParametro("ID_ENCUESTA", 1)
            sp.AgregarParametro("RUT", dr("RUT"))
            sp.AgregarParametro("ESTADOEMPRESA", dr("EstadoEmpresa"))
            sp.AgregarParametro("USUARIO_ACTUALIZACION", usuario_actualizacion)
            sp.AgregarParametro("COMENTARIO", "")
            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#End Region

#Region "INSERTAR EL ESTADO DE LA EMPRESA CUANDO SE LEVANTA DESDE EL EXCEL"
    Public Sub LevantamientoExcelInsertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String)
        Try
            'Dim sp As New StoredProcedure_class("SP_GES_ESTADOEMPRESA_Insertar")
            sp.AgregarParametro("ID_ENCUESTA", 1)
            sp.AgregarParametro("RUT", dr("RUT"))
            sp.AgregarParametro("ESTADOEMPRESA", dr("ESTADO_EMPRESA"))
            sp.AgregarParametro("USUARIO_ACTUALIZACION", usuario_actualizacion)
            sp.AgregarParametro("COMENTARIO", "")
            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#End Region

#Region "INSERTAR EL ESTADO DE LA EMPRESA"
    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String)
        Try
            'Dim sp As New StoredProcedure_class("SP_GES_ESTADOEMPRESA_Insertar")
            sp.AgregarParametro("ID_ENCUESTA", 1)
            sp.AgregarParametro("RUT", dr("RUT"))
            sp.AgregarParametro("ESTADOEMPRESA", dr("ESTADO_EMPRESA"))
            sp.AgregarParametro("USUARIO_ACTUALIZACION", usuario_actualizacion)
            sp.AgregarParametro("COMENTARIO", "")
            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#End Region


#Region "ACTUALIZAR EL ESTADO DE UNA EMPRESA"
    Public Sub ActualizarEstado(ByVal rut As Integer, ByVal encuesta As Integer, ByVal estado As Integer, ByVal usuario As String)
        Try
            Dim sp As New StoredProcedure_class("SP_GES_ESTADOEMPRESA_ActualizarEstado")
            sp.AgregarParametro("RUT", rut)
            sp.AgregarParametro("ID_ENCUESTA", encuesta)
            sp.AgregarParametro("ID_ESTADOEMPRESA", estado)
            sp.AgregarParametro("USUARIO_ACTUALIZACION", usuario)
            sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region



#Region "CONSTRUCTORES DE LA CLASE"
    Public Sub New()

    End Sub
#End Region

End Class
