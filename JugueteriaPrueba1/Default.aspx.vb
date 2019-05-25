Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.UI


Public Class _Default
    Inherits Page

    Public cmd As New SqlCommand
    Public con As New SqlConnection
    Public sda As New SqlDataAdapter
    Public ds As New DataSet

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load



        con.ConnectionString = "Data source=sql5021.site4now.net; initial catalog=DB_A48FC1_Juegueteria; User id=DB_A48FC1_Juegueteria_admin;Password=machine3.0;"
        con.Open()
    End Sub

    Protected Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        cmd.CommandText = "Select * from ges_login where usuario='" + txt_usuario.Text + "' and password='" + txt_password.Text + "'"
        cmd.Connection = con
        sda.SelectCommand = cmd
        sda.Fill(ds, "ges_login")

        If (ds.Tables(0).Rows.Count > 0) Then
            lbl_prueba.Text = "Conectado"
        Else
            lbl_prueba.Text = "Fallo coneccion"

        End If
    End Sub
End Class