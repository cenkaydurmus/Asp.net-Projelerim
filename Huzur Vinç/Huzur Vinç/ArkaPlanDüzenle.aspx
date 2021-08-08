<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="ArkaPlanDüzenle.aspx.cs" Inherits="Huzur_Vinç.ArkaPlanDüzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <p>
            Arka plan düzenle</p>
        <p>
            <asp:TextBox ID="tboxLink" runat="server" Width="213px"></asp:TextBox>
        </p>
        <p>
            <asp:Button class="btn btn-danger" ID="btnEdit" runat="server" Text="Button" OnClick="btnEdit_Click" />
        </p>
    </form>
</asp:Content>
