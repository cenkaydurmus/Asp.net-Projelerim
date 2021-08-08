<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="EditAboutUs.aspx.cs" Inherits="Yemek_Sitesi_Aspn.EditAboutUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
    <table class="nav-justified">
        <tr>
            <td>EDIT ABOUT US</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="tboxContent" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="tboxImage" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnEdit" runat="server" Height="25px" OnClick="btnEdit_Click" Text="Edit" Width="126px" />
            </td>
        </tr>
    </table>
</form>

</asp:Content>
