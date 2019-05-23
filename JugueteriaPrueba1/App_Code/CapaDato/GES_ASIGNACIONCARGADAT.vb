Imports System.Data


public class GES_ASIGNACIONCARGADAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GES_ASIGNACIONCARGA as GES_ASIGNACIONCARGAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ASIGNACIONCARGA_Insertar")
           sp.AgregarParametro("ID_ENCUESTA",GES_ASIGNACIONCARGA.ID_ENCUESTA)
           sp.AgregarParametro("RUT",GES_ASIGNACIONCARGA.RUT)
           sp.AgregarParametro("ROL",GES_ASIGNACIONCARGA.ROL)
           sp.AgregarParametro("DIGITADOR",GES_ASIGNACIONCARGA.DIGITADOR)
           sp.AgregarParametro("ANALISTA_REGIONAL",GES_ASIGNACIONCARGA.ANALISTA_REGIONAL)
           sp.AgregarParametro("ANALISTA",GES_ASIGNACIONCARGA.ANALISTA)
           sp.AgregarParametro("ANO",GES_ASIGNACIONCARGA.ANO)
           sp.AgregarParametro("PERIODO",GES_ASIGNACIONCARGA.PERIODO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GES_ASIGNACIONCARGA as GES_ASIGNACIONCARGAENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ASIGNACIONCARGA_Actualizar")
           sp.AgregarParametro("ID_ENCUESTA",GES_ASIGNACIONCARGA.ID_ENCUESTA)
           sp.AgregarParametro("RUT",GES_ASIGNACIONCARGA.RUT)
           sp.AgregarParametro("ROL",GES_ASIGNACIONCARGA.ROL)
           sp.AgregarParametro("DIGITADOR",GES_ASIGNACIONCARGA.DIGITADOR)
           sp.AgregarParametro("ANALISTA_REGIONAL",GES_ASIGNACIONCARGA.ANALISTA_REGIONAL)
           sp.AgregarParametro("ANALISTA",GES_ASIGNACIONCARGA.ANALISTA)
           sp.AgregarParametro("ANO",GES_ASIGNACIONCARGA.ANO)
           sp.AgregarParametro("PERIODO",GES_ASIGNACIONCARGA.PERIODO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_ASIGNACIONCARGA_Eliminar")
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

   Public Function Listar() as GES_ASIGNACIONCARGAENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GES_ASIGNACIONCARGA_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GES_ASIGNACIONCARGA(dt.Rows.count() - 1) as GES_ASIGNACIONCARGAENT
           i = 0
           for each dr in dt.rows
                GES_ASIGNACIONCARGA(i) = New GES_ASIGNACIONCARGAENT()
                GES_ASIGNACIONCARGA(i).ID_ENCUESTA = dr("ID_ENCUESTA")
                GES_ASIGNACIONCARGA(i).RUT = dr("RUT")
                GES_ASIGNACIONCARGA(i).ROL = dr("ROL")
                GES_ASIGNACIONCARGA(i).DIGITADOR = dr("DIGITADOR")
                GES_ASIGNACIONCARGA(i).ANALISTA_REGIONAL = dr("ANALISTA_REGIONAL")
                GES_ASIGNACIONCARGA(i).ANALISTA = dr("ANALISTA")
                GES_ASIGNACIONCARGA(i).ANO = dr("ANO")
                GES_ASIGNACIONCARGA(i).PERIODO = dr("PERIODO")
                i = i + 1
           next
           return GES_ASIGNACIONCARGA
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function

#END REGION

#Region "PERTENECE A LA CARGA ASIGNADA"
    Public Function PerteneceCargaRut(ByVal rut As Integer, ByVal id_encuesta As Integer, ByVal usuario As String) As DataTable
        Try
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_GES_ASIGNACIONCARGA_PerteneceCargaRut")
            sp.AgregarParametro("RUT", rut)
            sp.AgregarParametro("ID_ENCUESTA", id_encuesta)
            sp.AgregarParametro("USUARIO", usuario)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function PerteneceCargaRol(ByVal rol As Integer, ByVal id_encuesta As Integer, ByVal usuario As String, ByVal periodo As Integer, ByVal ano As Integer) As DataTable
        Try
            Dim dt As DataTable
            Dim sp As New StoredProcedure_class("SP_GES_ASIGNACIONCARGA_PerteneceCargaRol")
            sp.AgregarParametro("ROL", rol)
            sp.AgregarParametro("ID_ENCUESTA", id_encuesta)
            sp.AgregarParametro("USUARIO", usuario)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "INSERCIÓN DE LA CARGA DE TRABAJO"
    Public Sub InsertarCargaTrabajo(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal dr As Data.DataRow, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            sp.AgregarParametro("ID_ENCUESTA", 1)
            sp.AgregarParametro("RUT", dr("Rut"))
            sp.AgregarParametro("ROL", dr("Rol"))
            sp.AgregarParametro("DIGITADOR", dr("Digitador"))
            sp.AgregarParametro("ANALISTA_REGIONAL", dr("Analista_regional"))
            sp.AgregarParametro("ANALISTA", dr("Analista"))
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)

            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "LISTAR ROLES NO ASIGNADOS EN UN PERIODO ESPECÍFICO"
    Public Function ListarRolesSinAsignar(ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim sp As New StoredProcedure_class("SP_GES_ASIGNACIONCARGA_ListarRolesSinAsignar")
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            Return sp.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "LISTAR ANALISTAS, ANALISTAS REGIONALES Y DIGITADORES EN UNA SÓLA COLUMNA"
    Public Function Listar_A_AR_D_Unidos(ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim dt As Data.DataTable
            Dim dtAARD As New Data.DataTable
            Dim dr As Data.DataRow
            Dim drAARD As Data.DataRow
            Dim i As Integer = 1

            Dim GES_ASIGNACIONCARGADatos As New GES_ASIGNACIONCARGADAT

            Dim sp As New StoredProcedure_class("SP_GES_ASIGNACIONCARGA_Listar_A_AR_D_Juntos")
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            dt = sp.EjecutarProcedimiento().Tables(0)

            dtAARD.Columns.Add("ID_TIPOACCESO")
            dtAARD.Columns.Add("AARD")
            For Each dr In dt.Rows
                If dr("ANALISTA") IsNot DBNull.Value Then
                    If dtAARD.Select("AARD='" & dr("ANALISTA") & "'").Length = 0 Then
                        drAARD = dtAARD.NewRow()
                        drAARD("ID_TIPOACCESO") = i
                        drAARD("AARD") = dr("ANALISTA")
                        dtAARD.Rows.Add(drAARD)
                        i = i + 1
                    End If
                End If
                If dr("ANALISTA_REGIONAL") IsNot DBNull.Value Then
                    If dtAARD.Select("AARD='" & dr("ANALISTA_REGIONAL") & "'").Length = 0 Then
                        drAARD = dtAARD.NewRow()
                        drAARD("ID_TIPOACCESO") = i
                        drAARD("AARD") = dr("ANALISTA_REGIONAL")
                        dtAARD.Rows.Add(drAARD)
                        i = i + 1
                    End If
                End If
                If dr("DIGITADOR") IsNot DBNull.Value Then
                    If dtAARD.Select("AARD='" & dr("DIGITADOR") & "'").Length = 0 Then
                        drAARD = dtAARD.NewRow()
                        drAARD("ID_TIPOACCESO") = i
                        drAARD("AARD") = dr("DIGITADOR")
                        dtAARD.Rows.Add(drAARD)
                        i = i + 1
                    End If
                End If
            Next
            Return dtAARD
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "LISTAR ROLES FILTRADOS"
    Public Function ListarRolesFiltrados(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal region As Integer, ByVal tipo_establecimiento As String, ByVal periodo As Integer, ByVal ano As Integer, ByVal usuario As String) As Data.DataTable
        Try
            sp.AgregarParametro("REGION", region)
            sp.AgregarParametro("TIPO_ESTABLECIMIENTO", tipo_establecimiento)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("USUARIO", usuario)

            Return sp.EjecutarProcedimiento(sqlCmd).Tables(0)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "REASIGNAR CARGA DE TRABAJO"
    Public Sub ReasignarCarga(ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal rol As Integer, ByVal origen As String, ByVal destino As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try

            sp.AgregarParametro("ROL", rol)
            sp.AgregarParametro("USUARIO_ORIGEN", origen)
            sp.AgregarParametro("USUARIO_DESTINO", destino)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            sp.EjecutarProcedimiento(sqlCmd)
  
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

#Region "LISTAR POR PERIODOSO LOS ROLES ASIGNADOS"
    Public Function ListarPorPeriodo(ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim sp As New StoredProcedure_class("SP_GES_ASIGNACIONCARGA_ListarPorPeriodo")
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)

            Return sp.EjecutarProcedimiento().Tables(0)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region

#Region "LISTAR CARGA POR ROL"
    Public Function ListarCargaPorRol(ByVal usuario As String, ByVal periodo As Integer, ByVal ano As Integer) As Data.DataTable
        Try
            Dim sp As New StoredProcedure_class("SP_GES_ASIGNACIONCARGA_ListarCargaRoles")
            sp.AgregarParametro("usuario", usuario)
            sp.AgregarParametro("periodo", periodo)
            sp.AgregarParametro("ano", ano)
            Return sp.EjecutarProcedimiento().Tables(0)
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
