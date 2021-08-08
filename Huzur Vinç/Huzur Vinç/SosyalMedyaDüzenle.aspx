<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="SosyalMedyaDüzenle.aspx.cs" Inherits="Huzur_Vinç.İletişimDüzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="nav-justified">
            <tr>
                <td style="height: 20px">Sosyal Medya Düzenle</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="Yazacak adı giriniz" ID="tboxName" runat="server" Width="352px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="Birinci instagram giriniz" ID="tboxInsta1" runat="server" Width="352px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="İkinci instagram giriniz" ID="tboxInsta2" runat="server" Width="354px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="Facebook giriniz" ID="tboxFace" runat="server" Width="355px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="Telefon numarasını giriniz" ID="tboxPhone" runat="server" Width="352px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="Mail adresini giriniz" ID="tboxMail" runat="server" Width="356px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnEdit" CssClass="btn btn-danger" runat="server" Height="31px" Text="Düzenle" Width="108px" OnClick="btnEdit_Click" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
