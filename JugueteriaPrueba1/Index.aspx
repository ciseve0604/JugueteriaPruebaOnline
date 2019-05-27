<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Index.aspx.vb" Inherits="JugueteriaPrueba1.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"/>
    <title>Grumpix Inicio</title>

    <!-- Stylesheets -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">

    <style type="text/css">
        html,body{
          height: 100%;
          width: 100%;

        }

        .body {
            /* The image used */

            background-image: url(/Resources/Images/Index/Fondo_nubes.jpg);
            /*src="~/Resources/Images/Index/Fondo_nubes.jpg" */
            /* Full height */
            height: 100%;

            /* Center and scale the image nicely */
            background-repeat: no-repeat;
            background-size: cover;

        }

        .login{
            border: 1px solid #E1E1E1;
            border-radius: 5px;
            padding: 17px;
            width:300px;
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
        }
    </style>
</head>
<body class="body">
    <form id="form1" runat="server">
        <%--<div>
            <div class="container">
                <div class="col-4 login" style="background-color:white;">
                    <div class="col-9 col-md-12 col-lg-12">
                        <div class="form-row">
                            <h3>Ingreso al sistema</h3>
                            <img class="img-fluid rounded-circle  centrado" src="https://www.cpiprodesign.com/imagenes/logo1.png" alt="cpiprodesign">
                        </div>
                        <div class="form-row">
                            <div class="form-group col-md-8">
                                <div>
                                    <label for="inputCity">Usuario</label>
                                    <asp:TextBox ID="TextBox1" placeholder="usuario" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div>
                                    <label for="inputCity">Password</label>
                                    <asp:TextBox ID="TextBox2" type="password" placeholder="Password" CssClass="form-control" runat="server"></asp:TextBox><br />
                                    <asp:Label ID="Label1" runat="server" ForeColor="#CC0000"></asp:Label>
                                </div>
                                <div>
                                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Login" />
                                </div>    
                           </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>--%>
        <div class="login">
            <div class="form-group">
                <label>Nombre</label><br />
                <asp:TextBox ID="txt_nombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Clave</label><br />
                <asp:TextBox ID="txt_password" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="btn_login" runat="server" Text="Ingresar" CssClass="form-control" />
        </div>
    </form>
</body>
</html>
