Imports System.Data


public class GES_MENUNEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GES_MENU as GES_MENUENT)
       Try
           Dim GES_MENUDatos as new GES_MENUDAT
           GES_MENUDatos.insertar(GES_MENU)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Actualizar(byval GES_MENU as GES_MENUENT)
       Try
           Dim GES_MENUDatos as new GES_MENUDAT
           GES_MENUDatos.actualizar(GES_MENU)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Sub Eliminar(byval GES_MENU as GES_MENUENT)
       Try
           Dim GES_MENUDatos as new GES_MENUDAT
           GES_MENUDatos.eliminar(GES_MENU)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

   Public Function Listar() as GES_MENUENT()
       Try
           Dim GES_MENUDatos as new GES_MENUDAT
           return GES_MENUDatos.listar()
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Function





    Public Function ListarMenuUsuario(ByVal usuario As String) As GES_MENUENT()
        Try
            Dim Ges_MenuDatos As New Ges_MenuDAT
            Return Ges_MenuDatos.ListarMenuUsuario(usuario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#END REGION
end class
