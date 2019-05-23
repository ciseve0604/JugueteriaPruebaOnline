Imports System.Data


public class GES_ESTADOESTABLECIMIENTODAT

#REGION "METODO INGRESO"
    Public Sub Insertar_conexion(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer, ByVal ID_ESTADOESTABLECIMIENTO As String)
        Try
            sp.AgregarParametro("ID_ENCUESTA", 1)
            sp.AgregarParametro("ROL", dr("ROL"))
            sp.AgregarParametro("ESTADOESTABLECIMIENTO", ID_ESTADOESTABLECIMIENTO.ToString)
            sp.AgregarParametro("USUARIO_ACTUALIZACION", usuario_actualizacion)
            sp.AgregarParametro("COMENTARIO", "")
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            sp.EjecutarProcedimiento(sqlCmd)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

   Public Sub Insertar(byval GES_ESTADOESTABLECIMIENTO as GES_ESTADOESTABLECIMIENTOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ESTADOESTABLECIMIENTO_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",GES_ESTADOESTABLECIMIENTO.ID_ENCUESTA)
           sp.AgregarParametro("ROL",GES_ESTADOESTABLECIMIENTO.ROL)
           sp.AgregarParametro("ID_ESTADOESTABLECIMIENTO",GES_ESTADOESTABLECIMIENTO.ID_ESTADOESTABLECIMIENTO)
           sp.AgregarParametro("FECHA_ACTUALIZACION",GES_ESTADOESTABLECIMIENTO.FECHA_ACTUALIZACION)
           sp.AgregarParametro("USUARIO_ACTUALIZACION",GES_ESTADOESTABLECIMIENTO.USUARIO_ACTUALIZACION)
           sp.AgregarParametro("COMENTARIO",GES_ESTADOESTABLECIMIENTO.COMENTARIO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GES_ESTADOESTABLECIMIENTO as GES_ESTADOESTABLECIMIENTOENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ESTADOESTABLECIMIENTO_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",GES_ESTADOESTABLECIMIENTO.ID_ENCUESTA)
           sp.AgregarParametro("ROL",GES_ESTADOESTABLECIMIENTO.ROL)
           sp.AgregarParametro("ID_ESTADOESTABLECIMIENTO",GES_ESTADOESTABLECIMIENTO.ID_ESTADOESTABLECIMIENTO)
           sp.AgregarParametro("FECHA_ACTUALIZACION",GES_ESTADOESTABLECIMIENTO.FECHA_ACTUALIZACION)
           sp.AgregarParametro("USUARIO_ACTUALIZACION",GES_ESTADOESTABLECIMIENTO.USUARIO_ACTUALIZACION)
           sp.AgregarParametro("COMENTARIO",GES_ESTADOESTABLECIMIENTO.COMENTARIO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ESTADOESTABLECIMIENTO_Eliminar")
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

   Public Function Listar() as GES_ESTADOESTABLECIMIENTOENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GES_ESTADOESTABLECIMIENTO_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GES_ESTADOESTABLECIMIENTO(dt.Rows.count() - 1) as GES_ESTADOESTABLECIMIENTOENT
           i = 0
           for each dr in dt.rows
                GES_ESTADOESTABLECIMIENTO(i) = New GES_ESTADOESTABLECIMIENTOENT()
                GES_ESTADOESTABLECIMIENTO(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                GES_ESTADOESTABLECIMIENTO(i).ROL = dr("ROL")
                GES_ESTADOESTABLECIMIENTO(i).ID_ESTADOESTABLECIMIENTO = dr("ID_ESTADOESTABLECIMIENTO")
                GES_ESTADOESTABLECIMIENTO(i).FECHA_ACTUALIZACION = dr("FECHA_ACTUALIZACION")
                GES_ESTADOESTABLECIMIENTO(i).USUARIO_ACTUALIZACION = dr("USUARIO_ACTUALIZACION")
                GES_ESTADOESTABLECIMIENTO(i).COMENTARIO = dr("COMENTARIO")
                i = i + 1
           next
           return GES_ESTADOESTABLECIMIENTO
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION


#Region "OBTENER EL ESTADO DEL ESTABLECIMIENTO"
    Public Function obtenerestadoestablecimiento(ByVal rol As Integer, ByVal encuesta As Integer) As DataTable
        Try
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_GES_ESTADOESTABLECIMIENTO_ObtenerEstadoEstablecimiento")
            sp.AgregarParametro("ROL", rol)
            sp.AgregarParametro("ID_ENCUESTA", encuesta)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
#End Region

#Region "ACTUALIZAR EL ESTADO DEL ESTABLECIMIENTO"
    Public Sub ActualizarEstado(ByVal ROL As Integer, ByVal encuesta As Integer, ByVal estado As Integer, ByVal usuario As String)
        Try
            Dim sp As New StoredProcedure_class("SP_GES_ESTADOESTABLECIMIENTO_ActualizarEstado")
            sp.AgregarParametro("ROL", ROL)
            sp.AgregarParametro("ID_ENCUESTA", encuesta)
            sp.AgregarParametro("ID_ESTADOESTABLECIMIENTO", estado)
            sp.AgregarParametro("USUARIO_ACTUALIZACION", usuario)
            sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "INSERTAR EL ESTADO DEL ESTABLECIMIENTO CUANDO SE CARGA LA MUESTRA"
    Public Sub MuestraInsertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String)
        Try
            'Dim sp As New StoredProcedure_class("SP_GES_ESTADOEMPRESA_Insertar")
            sp.AgregarParametro("ID_ENCUESTA", 1)
            sp.AgregarParametro("ROL", dr("ROL"))
            sp.AgregarParametro("ESTADOESTABLECIMIENTO", dr("EstadoEstablecimiento"))
            sp.AgregarParametro("USUARIO_ACTUALIZACION", usuario_actualizacion)
            sp.AgregarParametro("COMENTARIO", "")
            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#End Region

#Region "INSERTAR EL ESTADO DEL ESTABLECIMIENTO CUANDO SE LEVANTA DESDE EL EXCEL"
    Public Sub LevantamientoExcelInsertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String)
        Try
            'Dim sp As New StoredProcedure_class("SP_GES_ESTADOEMPRESA_Insertar")
            sp.AgregarParametro("ID_ENCUESTA", 1)
            sp.AgregarParametro("ROL", dr("ROL"))
            sp.AgregarParametro("ESTADOESTABLECIMIENTO", dr("ESTADO_ESTABLECIMIENTO"))
            sp.AgregarParametro("USUARIO_ACTUALIZACION", usuario_actualizacion)
            sp.AgregarParametro("COMENTARIO", "")
            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#End Region


#Region "INSERTAR EL ESTADO DEL ESTABLECIMIENTO"
    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String)
        Try
            'Dim sp As New StoredProcedure_class("SP_GES_ESTADOEMPRESA_Insertar")
            sp.AgregarParametro("ID_ENCUESTA", 1)
            sp.AgregarParametro("ROL", dr("ROL"))
            sp.AgregarParametro("ESTADOESTABLECIMIENTO", dr("ESTADO_ESTABLECIMIENTO"))
            sp.AgregarParametro("USUARIO_ACTUALIZACION", usuario_actualizacion)
            sp.AgregarParametro("COMENTARIO", "")
            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#End Region

#Region "LISTAR A TABLA"
    Public Function ListarAtabla() As Data.DataTable
        Try
            Dim sp As New StoredProcedure_class("SP_GES_ESTADOESTABLECIMIENTO_Listar")
            Return sp.EjecutarProcedimiento.Tables(0)
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
