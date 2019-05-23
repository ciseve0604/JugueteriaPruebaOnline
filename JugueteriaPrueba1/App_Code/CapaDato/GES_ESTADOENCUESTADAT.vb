Imports System.Data


public class GES_ESTADOENCUESTADAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GES_ESTADOENCUESTA as GES_ESTADOENCUESTAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ESTADOENCUESTA_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",GES_ESTADOENCUESTA.ID_ENCUESTA)
           sp.AgregarParametro("RUT",GES_ESTADOENCUESTA.RUT)
           sp.AgregarParametro("ROL",GES_ESTADOENCUESTA.ROL)
           sp.AgregarParametro("DVROL",GES_ESTADOENCUESTA.DVROL)
           sp.AgregarParametro("ID_ESTADOENCUESTA",GES_ESTADOENCUESTA.ID_ESTADOENCUESTA)
           sp.AgregarParametro("PERIODO",GES_ESTADOENCUESTA.PERIODO)
           sp.AgregarParametro("ANO",GES_ESTADOENCUESTA.ANO)
           sp.AgregarParametro("USUARIO_ACTUALIZACION",GES_ESTADOENCUESTA.USUARIO_ACTUALIZACION)
            'sp.AgregarParametro("FECHA_ACTUALIZACION",GES_ESTADOENCUESTA.FECHA_ACTUALIZACION)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GES_ESTADOENCUESTA as GES_ESTADOENCUESTAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ESTADOENCUESTA_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",GES_ESTADOENCUESTA.ID_ENCUESTA)
           sp.AgregarParametro("RUT",GES_ESTADOENCUESTA.RUT)
           sp.AgregarParametro("ROL",GES_ESTADOENCUESTA.ROL)
           sp.AgregarParametro("DVROL",GES_ESTADOENCUESTA.DVROL)
           sp.AgregarParametro("ID_ESTADOENCUESTA",GES_ESTADOENCUESTA.ID_ESTADOENCUESTA)
           sp.AgregarParametro("PERIODO",GES_ESTADOENCUESTA.PERIODO)
           sp.AgregarParametro("ANO",GES_ESTADOENCUESTA.ANO)
           sp.AgregarParametro("USUARIO_ACTUALIZACION",GES_ESTADOENCUESTA.USUARIO_ACTUALIZACION)
           sp.AgregarParametro("FECHA_ACTUALIZACION",GES_ESTADOENCUESTA.FECHA_ACTUALIZACION)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ESTADOENCUESTA_Eliminar")
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

   Public Function Listar() as GES_ESTADOENCUESTAENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GES_ESTADOENCUESTA_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GES_ESTADOENCUESTA(dt.Rows.count() - 1) as GES_ESTADOENCUESTAENT
           i = 0
           for each dr in dt.rows
                GES_ESTADOENCUESTA(i) = New GES_ESTADOENCUESTAENT()
                GES_ESTADOENCUESTA(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                GES_ESTADOENCUESTA(i).RUT = dr("RUT")
                GES_ESTADOENCUESTA(i).ROL = dr("ROL")
                GES_ESTADOENCUESTA(i).DVROL = dr("DVROL")
                GES_ESTADOENCUESTA(i).ID_ESTADOENCUESTA = dr("ID_ESTADOENCUESTA")
                GES_ESTADOENCUESTA(i).PERIODO = dr("PERIODO")
                GES_ESTADOENCUESTA(i).ANO = dr("ANO")
                GES_ESTADOENCUESTA(i).USUARIO_ACTUALIZACION = dr("USUARIO_ACTUALIZACION")
                GES_ESTADOENCUESTA(i).FECHA_ACTUALIZACION = dr("FECHA_ACTUALIZACION")
                i = i + 1
           next
           return GES_ESTADOENCUESTA
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION

#Region "MÉTODO INSERTAR CON SP POR PARAMETRO, CONEXIÓN EXTERNA"
    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal id_estadoencuesta As Integer, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal periodo As Integer, ByVal ano As Integer, ByVal usuario_actualizacion As String)
        Try
            sp.AgregarParametro("ID_ENCUESTA", 1)
            sp.AgregarParametro("RUT", dr("RUT"))
            sp.AgregarParametro("ROL", dr("ROL"))
            sp.AgregarParametro("DVROL", dr("DVROL"))
            sp.AgregarParametro("ID_ESTADOENCUESTA", id_estadoencuesta)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("USUARIO_ACTUALIZACION", usuario_actualizacion)
            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "OBTENER MÁXIMO ESTADO DE ENCUESTA UN ROL EN UN PERIODO"
    Public Function ObtenerEstado(ByVal rol As Integer, ByVal periodo As Integer, ByVal ano As Integer) As Integer
        Try
            Dim sp As New StoredProcedure_class("SP_GES_ESTADOENCUESTA_ObtenerEstado")

            sp.AgregarParametro("ROL", rol)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)

            If sp.EjecutarProcedimiento.Tables(0).Rows.Count > 0 And sp.EjecutarProcedimiento.Tables(0).Rows(0)(0).ToString <> "" Then
                Return sp.EjecutarProcedimiento.Tables(0).Rows(0).Item(0)
            Else
                Return -1
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
#End Region

#Region "LISTAR ESTADOS DE UN ROL POR PERIODO"
    Public Function ListarPorRolPeriodo(ByVal rol As Integer, ByVal periodo As Integer, ByVal ano As Integer) As GES_ESTADOENCUESTAENT()
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim i As Integer
            Dim sp As New StoredProcedure_class("SP_GES_ESTADOENCUESTA_ListarEstadosRolPeriodo")
            sp.AgregarParametro("ROL", rol)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim GES_ESTADOENCUESTA(dt.Rows.Count() - 1) As GES_ESTADOENCUESTAENT
            i = 0
            For Each dr In dt.Rows
                GES_ESTADOENCUESTA(i) = New GES_ESTADOENCUESTAENT()
                GES_ESTADOENCUESTA(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                GES_ESTADOENCUESTA(i).RUT = dr("RUT")
                GES_ESTADOENCUESTA(i).ROL = dr("ROL")
                GES_ESTADOENCUESTA(i).DVROL = dr("DVROL")
                GES_ESTADOENCUESTA(i).ID_ESTADOENCUESTA = dr("ID_ESTADOENCUESTA")
                GES_ESTADOENCUESTA(i).PERIODO = dr("PERIODO")
                GES_ESTADOENCUESTA(i).ANO = dr("ANO")
                GES_ESTADOENCUESTA(i).USUARIO_ACTUALIZACION = dr("USUARIO_ACTUALIZACION")
                GES_ESTADOENCUESTA(i).FECHA_ACTUALIZACION = dr("FECHA_ACTUALIZACION")
                i = i + 1
            Next
            Return GES_ESTADOENCUESTA
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "ELIMINAR ESTADO DE LA ENCUESTA SEGÚN ROL, PERIODO, ANO"
    Public Sub eliminarPorRolPeriodo(ByVal rol As Integer, ByVal estadoEncuesta As Integer, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            Dim sp As New StoredProcedure_class("SP_GES_ESTADOENCUESTA_EliminarPorRolPeriodo")
            sp.AgregarParametro("ROL", rol)
            sp.AgregarParametro("ID_ESTADOENCUESTA", estadoEncuesta)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "LISTA EL NÚMERO DE ROLES QUE SE ENCUENTRAN EN LOS DISTINTOS ESTADOS DE LA ENCUESTA, POR PERIODO"
    Public Function ListarEstadosEncuestasTodos(ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim sp As New StoredProcedure_class("SP_GES_ESTADOENCUESTA_ContarRolesEnEstados")
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            Return sp.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "LISTA EL NÚMERO DE ROLES QUE SE ENCUENTRAN EN LOS DISTINTOS ESTADOS DE LA ENCUESTA, POR CARGA DEL ANALISTA Y POR PERIODO"
    Public Function ListarEstadosEncuestasPorAnalista(ByVal nombre_usuario As String, ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim sp As New StoredProcedure_class("SP_GES_ESTADOENCUESTA_ContarRolesEnEstadosPorAnalista")
            sp.AgregarParametro("USUARIO", nombre_usuario)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            Return sp.EjecutarProcedimiento().Tables(0)
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
