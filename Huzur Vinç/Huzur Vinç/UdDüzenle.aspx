<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="UdDüzenle.aspx.cs" Inherits="Huzur_Vinç.UdDüzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="nav-justified">
            <tr>
                <td>Alt ve Üst Kısımları Düzenle</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="Instagram linkini giriniz" ID="tboxInsta" runat="server" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="Facebook linkini giriniz" ID="tboxFace" runat="server" Width="299px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="Whatsapp linkini giriniz" ID="tboxWp" runat="server" Width="302px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="Adres linkini giriniz" ID="tboxGMap" runat="server" Width="304px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="Telefon numarasını giriniz" ID="tboxPhone" runat="server" Width="304px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tboxAbout" placeholder="Hakkımızda yazısı giriniz" runat="server" Width="303px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tboxAdress" placeholder="Adresi giriniz" runat="server" Width="301px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tboxMail" placeholder="Mail adresini giriniz" runat="server" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnEdit" CssClass="btn btn-danger" runat="server" Height="37px" Text="Düzenle" Width="163px" OnClick="btnEdit_Click" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
