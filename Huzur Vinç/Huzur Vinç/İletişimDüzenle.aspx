<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="İletişimDüzenle.aspx.cs" Inherits="Huzur_Vinç.İletişimDüzenle1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="nav-justified">
            <tr>
                <td>İİletişim Düzenle</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tboxMail" placeholder="İletişim mail adresini giriniz" runat="server" Width="334px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tboxAdress" placeholder="Adresi giriniz" runat="server" Width="334px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tboxPhone" placeholder="İleitşim telefon numarasını giriniz" runat="server" Width="334px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tboxGMap" placeholder="Google map linkini giriniz" runat="server" Width="334px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button class="btn btn-danger" ID="btnEdit" runat="server" Height="45px" Text="Düzenle" Width="119px" OnClick="btnEdit_Click" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
