<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HakkımızdaVeİletişimDeğiştir.aspx.cs" Inherits="Asp.net_Araba_satış_sitesi.HakkımızdaVeİletişimDeğiştir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>Hakkımızda Mesajı</td>
                <td>
                    <asp:TextBox ID="tboxabout" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>İletişim maili</td>
                <td>
                    <asp:TextBox ID="tboxcontactmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>İletişim numarası</td>
                <td>
                    <asp:TextBox ID="tboxcontactnum" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Değiştir" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
