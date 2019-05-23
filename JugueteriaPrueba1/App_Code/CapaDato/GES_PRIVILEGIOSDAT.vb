Imports System.Data


public class GES_PRIVILEGIOSDAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GES_PRIVILEGIOS as GES_PRIVILEGIOSENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_PRIVILEGIOS_Insertar")
           sp.AgregarParametro("ID_MENU",GES_PRIVILEGIOS.ID_MENU)
           sp.AgregarParametro("ID_TIPOACCESO",GES_PRIVILEGIOS.ID_TIPOACCESO)
           sp.AgregarParametro("ESTADO_PRIVILEGIO",GES_PRIVILEGIOS.ESTADO_PRIVILEGIO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

    Public Sub Actualizar(ByVal GES_PRIVILEGIOS As GES_PRIVILEGIOSENT, ByVal user As String)
        Try
            Dim sp As New StoredProcedure_class("SP_GES_PRIVILEGIOS_Actualizar")
            sp.AgregarParametro("ID_MENU", GES_PRIVILEGIOS.ID_MENU)
            sp.AgregarParametro("ID_TIPOACCESO", GES_PRIVILEGIOS.ID_TIPOACCESO)
            sp.AgregarParametro("ESTADO_PRIVILEGIO", GES_PRIVILEGIOS.ESTADO_PRIVILEGIO)
            sp.AgregarParametro("USER", user)
            sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_PRIVILEGIOS_Eliminar")
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

    Public Function Listar(ByVal PRIVILEGIO As Integer) As GES_PRIVILEGIOSENT()
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim i As Integer
            Dim sp As New StoredProcedure_class("SP_GES_PRIVILEGIOS_Listar")
            sp.AgregarParametro("ID_TIPOACCESO", PRIVILEGIO)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim GES_PRIVILEGIOS(dt.Rows.Count() - 1) As GES_PRIVILEGIOSENT
            i = 0
            For Each dr In dt.Rows
                GES_PRIVILEGIOS(i) = New GES_PRIVILEGIOSENT()
                GES_PRIVILEGIOS(i).ID_MENU = dr("ID_MENU")
                GES_PRIVILEGIOS(i).NOMBRE_MENU = dr("NOMBRE_MENU")
                GES_PRIVILEGIOS(i).ID_TIPOACCESO = dr("ID_TIPOACCESO")
                GES_PRIVILEGIOS(i).ESTADO_PRIVILEGIO = dr("ESTADO_PRIVILEGIO")
                i = i + 1
            Next
            Return GES_PRIVILEGIOS
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Sub CargarPrivilegios(ByVal PRIVILEGIO As Integer)
        Try
            Dim sp As New StoredProcedure_class("SP_GES_PRIVILEGIOS_CargarPorPrivilegio")
            sp.AgregarParametro("ID_TIPOACCESO", PRIVILEGIO)
            sp.EjecutarProcedimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
