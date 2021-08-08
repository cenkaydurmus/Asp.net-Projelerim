<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="ContactPage.aspx.cs" Inherits="ASP_Yemek_Sitesi.ContactPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="nav-justified">
            <tr>
                <td>Send Us Message</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tboxMail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tboxContent" runat="server" Height="120px" TextMode="MultiLine" Width="187px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSendMessage" runat="server" OnClick="btnSendMessage_Click" Text="Send Message" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
