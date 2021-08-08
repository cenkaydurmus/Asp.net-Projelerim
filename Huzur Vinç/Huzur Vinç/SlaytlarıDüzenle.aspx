<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="SlaytlarıDüzenle.aspx.cs" Inherits="Huzur_Vinç.SlaytlarıDüzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="nav-justified">
            <tr>
                <td>Slaytları Düzenle</td>
            </tr>
            <tr>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="1. slaytın linki" ID="TextBox1" runat="server" Width="292px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="2. slaytın linki" ID="TextBox2" runat="server" Width="292px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="3. slaytın linki" ID="TextBox3" runat="server" Width="292px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="4. slaytın linki" ID="TextBox4" runat="server" Width="292px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="5. slaytın linki" ID="TextBox5" runat="server" Width="292px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="6. slaytın linki" ID="TextBox6" runat="server" Width="292px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox placeholder="7. slaytın linki" ID="TextBox7" runat="server" Width="292px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button CssClass="btn btn-danger" ID="btnEdit" runat="server" Text="Düzenle" Width="84px" OnClick="btnEdit_Click" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
