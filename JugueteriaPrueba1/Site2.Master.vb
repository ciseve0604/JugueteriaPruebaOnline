Public Class Site2
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    'Boton que permite validar la conexión con el server online
    Private Sub btn_prueba_click_Click(sender As Object, e As EventArgs) Handles btn_prueba_click.Click

        MsgBox("Hola usuario prueba")


    End Sub



End Class