<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AcceptRecipes.aspx.cs" Inherits="Yemek_Sitesi_Aspn.AcceptRecipes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="nav-justified">
                    <tr>
                        <td>Tarif Adı:<asp:TextBox ID="tboxAd" runat="server" ReadOnly="True" Text='<%# Eval("Ad") %>'></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Malzemeler:<asp:TextBox ID="tbboxMalzeme" runat="server" Height="83px" TextMode="MultiLine" ReadOnly="True" Text='<%# Eval("Malzeme") %>'></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Yapılış:<asp:TextBox ID="tboxYapılış" runat="server" Height="90px" TextMode="MultiLine" ReadOnly="True" Text='<%# Eval("TarifYapılış") %>'></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Tarifi gönderenin adı-soyadı:<asp:TextBox ID="tboxKişiAd" runat="server" ReadOnly="True" Text='<%# Eval("TarifKişi") %>'></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Tarif resim linki:<asp:Image ID="Image1" runat="server" Height="166px" ImageUrl='<%# Eval("TarifResim") %>' Width="246px" />
                        </td>
                    </tr>
                    <tr>
                        <td>Tarifi gönderenin mail adresi:<asp:TextBox ID="tboxMail" runat="server" ReadOnly="True" Text='<%# Eval("TarifKişiMail") %>'></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                          <a href="AcceptRecipes2.aspx?id=<%# Eval("TarifID") %>"><input type="button" value="Accept" /></a> 
                        </td>
                    </tr>
                  
                </table>
            </ItemTemplate>
        </asp:DataList>
    </form>
    
</asp:Content>
