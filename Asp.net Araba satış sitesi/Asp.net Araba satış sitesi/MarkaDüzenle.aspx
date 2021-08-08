<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MarkaDüzenle.aspx.cs" Inherits="Asp.net_Araba_satış_sitesi.MarkaDüzenle" %>
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
                <td>Markanın adını değiştiriniz</td>
                <td>
                    <asp:TextBox ID="tboxName" runat="server"></asp:TextBox>
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
