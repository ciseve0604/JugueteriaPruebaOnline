Imports System.Data


public class GES_MENUDAT

#REGION "METODO INGRESO"

   Public Sub Insertar(byval GES_MENU as GES_MENUENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_MENU_Insertar")
           sp.AgregarParametro("NOMBRE_MENU",GES_MENU.NOMBRE_MENU)
           sp.AgregarParametro("LINK_MENU",GES_MENU.LINK_MENU)
           sp.AgregarParametro("ORDEN",GES_MENU.ORDEN)
           sp.AgregarParametro("PADRE",GES_MENU.PADRE)
           sp.AgregarParametro("ESTADO",GES_MENU.ESTADO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ACTUALIZAR"

   Public Sub Actualizar(byval GES_MENU as GES_MENUENT )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_MENU_Actualizar")
           sp.AgregarParametro("ID_MENU",GES_MENU.ID_MENU)
           sp.AgregarParametro("NOMBRE_MENU",GES_MENU.NOMBRE_MENU)
           sp.AgregarParametro("LINK_MENU",GES_MENU.LINK_MENU)
           sp.AgregarParametro("ORDEN",GES_MENU.ORDEN)
           sp.AgregarParametro("PADRE",GES_MENU.PADRE)
           sp.AgregarParametro("ESTADO",GES_MENU.ESTADO)
           sp.EjecutarProcedimiento()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub
#End Region
#REGION "METODO ELIMINAR"

   Public Sub Eliminar( PARAMETROS )
       Try
           Dim sp As New StoredProcedure_class("SP_GES_MENU_Eliminar")
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

   Public Function Listar() as GES_MENUENT()
       Try
           Dim dr as DataRow
           Dim dt as DataTable
           Dim i as Integer
           Dim sp As New StoredProcedure_class("SP_GES_MENU_Listar")
           dt = sp.EjecutarProcedimiento().tables(0)
           Dim GES_MENU(dt.Rows.count() - 1) as GES_MENUENT
           i = 0
           for each dr in dt.rows
                GES_MENU(i) = New GES_MENUENT()
                GES_MENU(i).ID_MENU = dr("ID_MENU")
                GES_MENU(i).NOMBRE_MENU = dr("NOMBRE_MENU")
                GES_MENU(i).LINK_MENU = dr("LINK_MENU")
                GES_MENU(i).ORDEN = dr("ORDEN")
                GES_MENU(i).PADRE = dr("PADRE")
                GES_MENU(i).ESTADO = dr("ESTADO")
                i = i + 1
           next
           return GES_MENU
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
    End Function




    Public Function ListarMenuUsuario(ByVal nombre_usuario As String) As GES_MENUENT()
        Try
            Dim dr As DataRow
            Dim dt As DataTable
            Dim i As Integer
            Dim sp As New StoredProcedure_class("SP_GES_MENU_ListarUsuario")
            sp.AgregarParametro("nombre_usuario", nombre_usuario)
            dt = sp.EjecutarProcedimiento().Tables(0)
            Dim Ges_Menu(dt.Rows.Count() - 1) As Ges_MenuENT
            i = 0
            For Each dr In dt.Rows
                Ges_Menu(i) = New Ges_MenuENT()
                Ges_Menu(i).id_menu = dr("id_menu")
                Ges_Menu(i).nombre_menu = dr("nombre_menu")
                Ges_Menu(i).link_menu = dr("link_menu")
                Ges_Menu(i).orden = dr("orden")
                Ges_Menu(i).padre = dr("padre")
                Ges_Menu(i).estado = dr("estado")
                i = i + 1
            Next
            Return Ges_Menu
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
