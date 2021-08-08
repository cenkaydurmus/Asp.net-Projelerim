<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="ASP_Yemek_Sitesi.AboutUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                ABOUT US<br />
                <asp:TextBox ID="tboxAbout"  runat="server" Height="143px" ReadOnly="True" Text='<%# Eval("Hakkımızda") %>' TextMode="MultiLine" Width="770px"></asp:TextBox>
                <br />
                <asp:Image ID="Image1" runat="server" Height="212px" ImageUrl='<%# Eval("Resim") %>' Width="778px" />
            </ItemTemplate>
        </asp:DataList>
    </form>
</asp:Content>
