<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="KurumsalDüzenle.aspx.cs" Inherits="Huzur_Vinç.KurumsalDüzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:TextBox ID="tboxText" runat="server" Height="205px" TextMode="MultiLine" Width="454px"></asp:TextBox>
        <br />
        <asp:Button ID="btnEdit" runat="server" Height="32px" Text="Düzenle" CssClass="btn btn-danger" Width="87px" OnClick="btnEdit_Click" />
    </form>
</asp:Content>
