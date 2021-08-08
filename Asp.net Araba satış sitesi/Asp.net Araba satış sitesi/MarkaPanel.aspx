<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MarkaPanel.aspx.cs" Inherits="Asp.net_Araba_satış_sitesi.MarkaPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="container">
        <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("BrandName") %>'></asp:Label>
                        </td>
                        <td>
                            <a href="MarkaSil.aspx?BrandID=<%# Eval("BrandID") %>">
                                 <input type="button"  value="Sil"/>
                            </a>
                    
                        </td>
                        <td>
                             <a href="MarkaDüzenle.aspx?BrandID=<%# Eval("BrandID") %>">
                                 <input type="button"  value="Düzenle"/>
                            </a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
            <asp:TextBox ID="txtboxBrandName" placholder="Marka adını giriniz" runat="server"></asp:TextBox>
            <asp:Button OnClick="Button3_Click" ID="Button3" runat="server" Text="Marka Ekle" />
    </form>
    </div>
    
</asp:Content>
