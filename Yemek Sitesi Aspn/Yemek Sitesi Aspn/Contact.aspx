<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Yemek_Sitesi_Aspn.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <h1>SEND US A MESSAGE</h1>
    <p>
        <asp:TextBox ID="tboxMail" runat="server" TextMode="Email" Width="243px"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="tboxMessage" runat="server" Height="140px" TextMode="MultiLine" Width="248px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnSend" runat="server" Height="68px" OnClick="btnSend_Click" Text="Send" Width="129px" />
    </p>
</form>
</asp:Content>
