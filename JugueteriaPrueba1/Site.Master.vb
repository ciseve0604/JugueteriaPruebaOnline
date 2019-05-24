Public Class SiteMaster
    Inherits MasterPage


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    'Boton que permite validar la conexión con el server online
    Private Sub btn_prueba_click_Click(sender As Object, e As EventArgs) Handles btn_prueba_click.Click

        MsgBox("Hola usuario prueba")



    End Sub


    Private Class StoredProcedure_class
        Public Sub New()
        End Sub
    End Class
End Class