<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Menu.ascx.vb" Inherits="JugueteriaPrueba1.Menu" %>

<asp:TreeView ID="trv_menu" runat="server" Visible="False"></asp:TreeView>

<%  
    Dim pathSistema As String
    pathSistema = "http://" & Request.Url.Host & ":" & Request.Url.Port & HttpContext.Current.Request.ApplicationPath
%>

<%-- Propiedades del CSS --%>
<style type="text/css">
    /*----------------------------- estilos interfaz interior -----------------------------*/
    .menu_lateral {
        background-color: #f9f9f9;
        border-right: 1px solid #e9e9e9;
        height: /*auto*/ 700px;
        float: left;
        /*width: 250px;*/
    }


    .box_encuesta {
        background-color: #7123dc;
        width: 929px;
        height: auto /*500px*/;
        float: right;
    }

    /*-- menu --*/
    #cssmenu,
    #cssmenu ul,
    #cssmenu ul li,
    #cssmenu ul li a {
        margin: 0;
        padding: 0;
        border: 0;
        list-style: none;
        line-height: 1;
        display: block;
        position: relative;
        -webkit-box-sizing: border-box;
        -moz-box-sizing: border-box;
        box-sizing: border-box;
    }

    #cssmenu { /*width: 250px;*/
        font-family: Helvetica, Arial, sans-serif;
        color: #ffffff;
    }

        #cssmenu ul ul {
            display: none;
        }

    .align-right {
        float: right;
    }

    #cssmenu > ul > li > a {
        padding: 15px 20px;
        border-left: 1px solid #6588a2;
        border-right: 1px solid #6588a2;
        border-top: 1px solid #6588a2;
        cursor: pointer;
        z-index: 2;
        font-size: 14px;
        font-weight: bold;
        text-decoration: none;
        color: #ffffff;
        text-shadow: 0 1px 1px rgba(0, 0, 0, 0.35);
        background: #789bb5;
        background: -webkit-linear-gradient(#789bb5, #6588a2);
        background: -moz-linear-gradient(#789bb5, #6588a2);
        background: -o-linear-gradient(#789bb5, #6588a2);
        background: -ms-linear-gradient(#789bb5, #6588a2);
        background: linear-gradient(#789bb5, #6588a2);
        box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.15);
    }

        #cssmenu > ul > li > a:hover,
        #cssmenu > ul > li.active > a,
        #cssmenu > ul > li.open > a {
            color: #eeeeee;
            background: #537690;
            background: -webkit-linear-gradient(#537690, #3e617b);
            background: -moz-linear-gradient(#537690, #3e617b);
            background: -o-linear-gradient(#537690, #3e617b);
            background: -ms-linear-gradient(#537690, #3e617b);
            background: linear-gradient(#537690, #3e617b);
        }

    #cssmenu > ul > li.open > a {
        box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.15), 0 1px 1px rgba(0, 0, 0, 0.15);
        border-bottom: 1px solid #6588a2;
    }

    #cssmenu > ul > li:last-child > a,
    #cssmenu > ul > li.last > a {
        border-bottom: 1px solid #6588a2;
    }

    .holder {
        width: 0;
        height: 0;
        position: absolute;
        top: 0;
        right: 0;
    }

        .holder::after,
        .holder::before {
            display: block;
            position: absolute;
            content: "";
            width: 6px;
            height: 6px;
            right: 20px;
            z-index: 10;
            -webkit-transform: rotate(-135deg);
            -moz-transform: rotate(-135deg);
            -ms-transform: rotate(-135deg);
            -o-transform: rotate(-135deg);
            transform: rotate(-135deg);
        }

        .holder::after {
            top: 17px;
            border-top: 2px solid #ffffff;
            border-left: 2px solid #ffffff;
        }

    #cssmenu > ul > li > a:hover > span::after,
    #cssmenu > ul > li.active > a > span::after,
    #cssmenu > ul > li.open > a > span::after {
        border-color: #eeeeee;
    }

    .holder::before {
        top: 18px;
        border-top: 2px solid;
        border-left: 2px solid;
        border-top-color: inherit;
        border-left-color: inherit;
    }

    #cssmenu ul ul li a {
        cursor: pointer;
        border-bottom: 1px solid #32373e;
        border-left: 1px solid #32373e;
        border-right: 1px solid #32373e;
        padding: 10px 20px;
        z-index: 1;
        text-decoration: none;
        font-size: 13px;
        color: #eeeeee;
        background: #525963;
        box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1);
    }

    #cssmenu ul ul li:hover > a,
    #cssmenu ul ul li.open > a,
    #cssmenu ul ul li.active > a {
        background: #424852;
        color: #ffffff;
    }

    #cssmenu ul ul li:first-child > a {
        box-shadow: none;
    }

    #cssmenu ul ul ul li:first-child > a {
        box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1);
    }

    #cssmenu ul ul ul li a {
        padding-left: 30px;
    }

    #cssmenu > ul > li > ul > li:last-child > a,
    #cssmenu > ul > li > ul > li.last > a {
        border-bottom: 0;
    }

    #cssmenu > ul > li > ul > li.open:last-child > a,
    #cssmenu > ul > li > ul > li.last.open > a {
        border-bottom: 1px solid #32373e;
    }

    #cssmenu > ul > li > ul > li.open:last-child > ul > li:last-child > a {
        border-bottom: 0;
    }

    #cssmenu ul ul li.has-sub > a::after {
        display: block;
        position: absolute;
        content: "";
        width: 5px;
        height: 5px;
        right: 20px;
        z-index: 10;
        top: 11.5px;
        border-top: 2px solid #eeeeee;
        border-left: 2px solid #eeeeee;
        -webkit-transform: rotate(-135deg);
        -moz-transform: rotate(-135deg);
        -ms-transform: rotate(-135deg);
        -o-transform: rotate(-135deg);
        transform: rotate(-135deg);
    }

    #cssmenu ul ul li.active > a::after,
    #cssmenu ul ul li.open > a::after,
    #cssmenu ul ul li > a:hover::after {
        border-color: #ffffff;
    }
    /*-- Fin menu --*/


    /*-- informativo --*/
    .informativo_1, .informativo_2, .informativo_3 {
        padding: 25px;
        border-right: 5px solid;
        font-family: "Helvetica Neue",Helvetica,Arial,sans-serif;
    }

    .informativo_1 {
        background-color: #D9EDF7;
        border-color: #BCE8F1;
        color: #31708F;
    }

    .informativo_2 {
        background-color: #DFF0D8;
        border-color: #D6E9C6;
        color: #3C763D;
    }

    .informativo_3 {
        background-color: #FCF8E3;
        border-color: #FAEBCC;
        color: #8A6D3B;
    }

    .informativo ul li h2 {
        font-weight: 100px;
    }

    .informativo ul li p {
        font-size: 250px;
    }
    /*-- Fin informativo --*/
</style>


<%-- Aquí se tiene la parte del menú relacionada con el aspecto legal. --%>
<div id="contenido">

    <%--<asp:Image ID="img_button" runat="server"  ImageUrl="~/resource/images/boton_aspecto/btn_aceptar.png" Style="margin-left:70px; width:120; height:40px;" OnClick="ImageButton_Click" />
--%>
<%--    <asp:ImageButton ID="img_btn" runat="server" ImageUrl="~/resource/images/boton_aspecto/btn_inicio6.png" Style="float: left; width: 120px; height: 31px;" />--%>

    <div class="menu_lateral">
        <span id="myControl" runat="server"></span>
        <div class='informativo_1'>
        </div>
    </div>
</div>

