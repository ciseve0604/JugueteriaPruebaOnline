<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Login_Master.aspx.vb" Inherits="JugueteriaPrueba1.Login_Master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <style type="text/css">
            .login{
                border: 6px solid #E1E1E1;
                border-radius: 5px;
                padding: 17px;
                width:300px;
                position: absolute;
                top: 50%;
                left: 50%;
                transform: translate(-50%, -50%);
            }
        </style>

       <div class="login">
            <div class="form-group">
                <label>Nombre</label><br />
                <asp:TextBox ID="txt_nombre" runat="server" CssClass="form-control" placeholder="Usuario"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Clave</label><br />
                <asp:TextBox ID="txt_password" runat="server" CssClass="form-control" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
            </div>
            <asp:Button ID="btn_login" runat="server" Text="Ingresar" CssClass="form-control" />
        </div>

</asp:Content>
