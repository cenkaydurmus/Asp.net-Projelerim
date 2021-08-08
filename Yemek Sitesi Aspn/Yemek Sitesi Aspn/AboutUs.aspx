<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="Yemek_Sitesi_Aspn.AboutUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <h1>ABOUT US !</h1>
        <p>
            <asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Hakkımızda") %>'></asp:Label>
                    <br />
                    <asp:Image ID="Image1" runat="server" Height="195px" ImageUrl='<%# Eval("Resim") %>' Width="312px" />
                </ItemTemplate>
            </asp:DataList>
        </p>
    </form>
</asp:Content>
