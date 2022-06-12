<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="UIWeb.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 412px">
    <form id="form1" runat="server">
        <div style="height: 413px">
            Dni<asp:TextBox ID="TextBoxDni" runat="server" style="margin-left: 32px"></asp:TextBox>
            <br />
            Clave<asp:TextBox ID="TextBoxClave" runat="server" style="margin-left: 18px"></asp:TextBox>
            <br />
            <asp:Button ID="ButIngresar" runat="server" Text="Ingresar" OnClick="Button1_Click" style="margin-left: 111px; margin-top: 18px" />
            <br />
            <br />
&nbsp;&nbsp;
            <asp:ListBox ID="ListBoxActividades" runat="server" Height="249px" Width="202px"></asp:ListBox>
            <asp:ListBox ID="ListBoxInscriptas" runat="server" Height="249px" Width="202px" style="margin-left: 66px"></asp:ListBox>
            <asp:Button ID="Button5" runat="server" style="margin-left: 729px" Text="Button" Visible="False" />
            <asp:Button ID="ButInscribir" runat="server" Text="Inscribirse" OnClick="Button2_Click" style="margin-left: 282px; margin-top: 12px" />
            <asp:Button ID="ButDesasignar" runat="server" OnClick="Button4_Click" Text="Desasignar" style="margin-left: 14px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
