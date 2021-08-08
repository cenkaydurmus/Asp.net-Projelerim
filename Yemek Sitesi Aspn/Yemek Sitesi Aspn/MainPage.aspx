<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Yemek_Sitesi_Aspn.MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <h1>Recipe Categories !</h1>

    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <table class="nav-justified">
                <tr>
                    <td>
                      <a href="RecipesByCategories.aspx?KategoriID=<%# Eval("KategoriID") %>">  <asp:Label ID="Label1" runat="server" Text='<%# Eval("Ad") %>'></asp:Label></a>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </ItemTemplate>

    </asp:DataList>
    </form>
</asp:Content>
