<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="UIWeb.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 15px;
            margin-top: 18px;
        }
    </style>
</head>
<body style="height: 412px">
    <form id="form1" runat="server">
        <div style="height: 453px">
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelBienvenida" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Actividades del club"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="Tus Inscripciones"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;
            <asp:ListBox ID="ListBoxActividades" runat="server" Height="249px" Width="195px" style="overflow-x:auto;"></asp:ListBox>
            <asp:ListBox ID="ListBoxInscriptas" runat="server" Height="249px" Width="208px" style="margin-left: 66px; overflow-x:auto;"></asp:ListBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;
            <br />
            <div>
            <asp:Button ID="ButInscribir" runat="server" Text="Inscribirse" OnClick="ButtonInscribirse_Click" style="margin-left: 282px; margin-top: 12px" />
            <asp:Button ID="ButDesasignar" runat="server" OnClick="ButtonDesasignar_Click" Text="Desasignar" style="margin-left: 14px" />
                <div>
                    <asp:Button ID="ButCerrarSesion" runat="server" CssClass="auto-style1" OnClick="ButCerrarSesion_Click" Text="Cerrar Sesión" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
