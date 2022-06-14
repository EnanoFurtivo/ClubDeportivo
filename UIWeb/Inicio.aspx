<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="UIWeb.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 412px">
    <form id="form1" runat="server">
        <div style="height: 453px">
            <br />
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;
            <asp:ListBox ID="ListBoxActividades" runat="server" Height="249px" Width="202px"></asp:ListBox>
            <asp:ListBox ID="ListBoxInscriptas" runat="server" Height="249px" Width="202px" style="margin-left: 66px" Visible="False"></asp:ListBox>
            <asp:Button ID="Button5" runat="server" style="margin-left: 700px" Text="Button" Visible="False" />
            <asp:Button ID="ButInscribir" runat="server" Text="Inscribirse" OnClick="ButtonInscribirse_Click" style="margin-left: 282px; margin-top: 12px" Visible="False" />
            <asp:Button ID="ButDesasignar" runat="server" OnClick="ButtonDesasignar_Click" Text="Desasignar" style="margin-left: 14px" Visible="False" />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
