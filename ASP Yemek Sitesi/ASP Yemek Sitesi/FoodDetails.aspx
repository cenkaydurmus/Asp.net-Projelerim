<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="FoodDetails.aspx.cs" Inherits="ASP_Yemek_Sitesi.FoodDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="nav-justified">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("YemekAd") %>'></asp:Label>
                            &nbsp;
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("EklenmeTarihi") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("KategoriID") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 20px">
                            <asp:Image ID="Image1" runat="server" Height="188px" ImageUrl='<%# Eval("Resimler") %>' Width="846px" />
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
                        <td style="border-bottom-style: solid; border-bottom-width: thin">
                            &nbsp;</td>
                    </tr>
                       <tr>
                        <td style="border-bottom-style: solid; border-bottom-width: thin">
                            YOUR EMAIL :
                            <asp:TextBox ID="tboxMail" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="border-bottom-style: solid; border-bottom-width: thin">
                            YOUR COMMENT:<asp:TextBox ID="tboxComment" runat="server" Height="211px" TextMode="MultiLine" Width="278px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="border-bottom-style: solid; border-bottom-width: thin">&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="border-bottom-style: solid; border-bottom-width: thin">
                            <asp:Button ID="btnAdd" runat="server" Text="Add Comment To This Food" />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </form>
</asp:Content>
