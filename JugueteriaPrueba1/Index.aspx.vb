'<%-----------------------------------------------------------------------------------------------------------------------------------------------%>
'<%---------------------------------------------------------------BIBLIOTECAS A UTILIZAR----------------------------------------------------------%>
'<%-----------------------------------------------------------------------------------------------------------------------------------------------%>



'<%-----------------------------------------------------------------------------------------------------------------------------------------------%>
'<%-------------------------------------------------------------------CUERPO DEL CODE BEHIND------------------------------------------------------%>
'<%-----------------------------------------------------------------------------------------------------------------------------------------------%>
Public Class Index
    Inherits System.Web.UI.Page

    Public sp As New StoredProcedure_class

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    'Boton que permite realizar el registro en el sistema
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim nombre_usuario As String = Me.txt_nombre.Text
        Dim password_usuario As String = Me.txt_password.Text
        Dim existe_usuario As String = sp.EjecutarConsulta("IF EXISTS (SELECT 1 FROM GES_USUARIO WHERE NOMBRE_USUARIO='" & nombre_usuario & "' AND PASSWORD='" & password_usuario & "') SELECT 1 ELSE SELECT 0").Tables(0).Rows(0)(0).ToString

        Response.Redirect("~/Site.Master")

        MsgBox(existe_usuario)
    End Sub
End Class