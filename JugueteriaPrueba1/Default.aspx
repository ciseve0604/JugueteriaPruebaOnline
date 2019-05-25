<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="JugueteriaPrueba1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="Login">
        <table>
            <tr>
                <td>
                    <asp:TextBox ID ="txt_usuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID ="txt_password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:button ID ="btn_ingresar" runat="server" Text="Ingresar"></asp:button>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:label ID ="lbl_prueba" runat="server"></asp:label>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
