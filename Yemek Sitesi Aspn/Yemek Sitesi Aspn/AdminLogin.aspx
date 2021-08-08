<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Yemek_Sitesi_Aspn.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" style="display:flex;flex-direction:column;justify-content:space-between">
        <asp:TextBox ID="tboxUsername"  runat="server"></asp:TextBox>
        <asp:TextBox ID="tboxPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Login as Admin" OnClick="Button1_Click" />
    </form>
</asp:Content>
