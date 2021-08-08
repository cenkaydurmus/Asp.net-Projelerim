<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="GiveUsRecipe.aspx.cs" Inherits="Yemek_Sitesi_Aspn.GiveUsRecipe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="nav-justified">
            <tr>
                <td>Tarif Adı:<asp:TextBox ID="tboxAd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Malzemeler:<asp:TextBox ID="tbboxMalzeme" runat="server" Height="83px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Yapılış:<asp:TextBox ID="tboxYapılış" runat="server" Height="90px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tarifi gönderenin adı-soyadı:<asp:TextBox ID="tboxKişiAd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tarif resim linki:<asp:TextBox ID="tboxLink" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tarifi gönderenin mail adresi:<asp:TextBox ID="tboxMail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnEkle" runat="server" Height="39px" OnClick="btnEkle_Click" Text="Tarif Gönder" Width="149px" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
