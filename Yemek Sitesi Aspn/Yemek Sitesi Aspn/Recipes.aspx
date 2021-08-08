<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Recipes.aspx.cs" Inherits="Yemek_Sitesi_Aspn.Recipes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <table class="nav-justified">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("YemekAd") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Malzemeler") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Tarifler") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="94px" ImageUrl='<%# Eval("Resimler") %>' Width="165px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("EklenmeTarihi") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("Puan") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                     <td>
                        <a href="CommentsByRecipes.aspx?id=<%# Eval("YemekID") %>"><input type="button" value="Yemeğe ait yorumları göster" /></a> 
                     </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</form>
</asp:Content>
