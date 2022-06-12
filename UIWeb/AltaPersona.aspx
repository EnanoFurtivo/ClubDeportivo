<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaPersona.aspx.cs" Inherits="UIWeb.AltaPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            DNI <asp:TextBox ID="TextBox2" runat="server" Width="147px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nombre<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 34px" Width="274px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Aceptar y Salir" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancelar y Salir" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
