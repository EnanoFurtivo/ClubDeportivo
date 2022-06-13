<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="UIWeb.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 403px">
    <form id="form1" runat="server">
        <div style="height: 318px">
            <div style="height: 35px; top: 0px; vertical-align: middle; text-align: center; background-color: #FFFFFF; line-height: normal;">
&nbsp;<asp:Label ID="LabelIniciarSesion" runat="server" Text="INICIAR SESIÓN"></asp:Label>
            </div>
            <p style="margin-left: 533px">
            Dni<asp:TextBox ID="TextBoxDni" runat="server" style="margin-left: 26px; margin-top: 55px;" OnTextChanged="TextBoxDni_TextChanged"></asp:TextBox>
            <br />
            Clave<asp:TextBox ID="TextBoxClave" runat="server" style="margin-left: 13px; margin-top: 48px;"></asp:TextBox>
            <br />
            <asp:Button ID="ButIngresar" runat="server" Text="Ingresar" OnClick="ButtonIngresar_Click" style="margin-left: 49px; margin-top: 42px" Width="124px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelError" runat="server" Text="Label"></asp:Label>
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
