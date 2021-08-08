<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="TodaysDinner.aspx.cs" Inherits="Yemek_Sitesi_Aspn.TodaysDinner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="nav-justified">
                    <tr>
                        <td>Yemek Adı:<asp:Label ID="Label1" runat="server" Text='<%# Eval("GYemekAd") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Malzemeler:<asp:Label ID="Label2" runat="server" Text='<%# Eval("GYemekMalzeme") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Tarif:<asp:Label ID="Label3" runat="server" Text='<%# Eval("GYemekTarif") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Puan:<asp:Label ID="Label4" runat="server" Text='<%# Eval("GYemekPuan") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Tarih:<asp:Label ID="Label5" runat="server" Text='<%# Eval("GYemekTarih") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="Image1" runat="server" Height="193px" ImageUrl='<%# Eval("GYemekResim") %>' Width="799px" />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </form>
</asp:Content>
