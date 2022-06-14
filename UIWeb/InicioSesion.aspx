<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="UIWeb.InicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 520px;
        }
    </style>
</head>
<body style="height: 412px">
    <form id="form1" runat="server">
        <div style="height: 319px">
            <div style="height: 28px; vertical-align: middle; line-height: normal; text-align: center;">
                <asp:Label ID="LabelInicioSesion" runat="server" style="font-weight: 700" Text="INICIO SESIÓN"></asp:Label>
            </div>
            <p class="auto-style1">
            Dni<asp:TextBox ID="TxtBoxDni" runat="server" style="margin-left: 32px; margin-top: 54px;"></asp:TextBox>
            <br class="auto-style1" />
            Clave<asp:TextBox ID="TxtBoxClave" runat="server" style="margin-left: 18px; margin-top: 45px;"></asp:TextBox>
            <br class="auto-style1" />
            <asp:Button ID="ButIngresar" runat="server" Text="Ingresar" OnClick="ButtonIngresar_Click" style="margin-left: 54px; margin-top: 41px; font-weight: 700;" Width="126px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelDeError" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;
            <br />
            </p>
        </div>
    </form>
</body>
</html>
