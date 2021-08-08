<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AddTodaysDinner.aspx.cs" Inherits="Yemek_Sitesi_Aspn.AddTodaysDinner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="nav-justified">
            <tr>
                <td>Günün yemeği adı:<asp:TextBox ID="tboxAd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Malzemeler:<asp:TextBox ID="tboxMalzeme" runat="server" Height="68px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Tarif:<asp:TextBox ID="tboxTarif" runat="server" Height="62px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Günün yemeği puan:<asp:TextBox ID="tboxPuan" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Resim linki:<asp:TextBox ID="tboxResim" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Height="43px" OnClick="btnAdd_Click" Text="Add" Width="117px" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
