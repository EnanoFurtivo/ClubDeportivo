<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="UIWeb.InicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 310px;
        }
        .auto-style2 {
            height: 31px;
        }
        .auto-style3 {
            height: 31px;
            width: 497px;
        }
        .auto-style4 {
            width: 497px;
        }
        .auto-style5 {
            height: 31px;
            width: 252px;
        }
        .auto-style6 {
            width: 252px;
        }
        .auto-style8 {
            margin-top: 30px;
        }
    </style>
</head>
<body style="height: 307px">
    <form id="form1" runat="server" class="auto-style1">
            <table style="width: 100%; height: 195px;">
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style5" style="text-align: center">
                <asp:Label ID="LabelInicioSesion" runat="server" style="font-weight: 700" Text="INICIO SESIÓN"></asp:Label>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">Dni<asp:TextBox ID="TxtBoxDni" runat="server" style="margin-left: 32px; " CssClass="auto-style8"></asp:TextBox>
                        <br />
            Clave<asp:TextBox ID="TxtBoxClave" runat="server" style="margin-left: 18px; margin-top: 45px;" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">
            <asp:Button ID="ButIngresar" runat="server" Text="Ingresar" OnClick="ButtonIngresar_Click" style="margin-left: 54px; font-weight: 700;" Width="126px" CssClass="auto-style8" />
                    </td>
                    <td>
            <asp:Label ID="LabelDeError" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
    </form>
</body>
</html>
