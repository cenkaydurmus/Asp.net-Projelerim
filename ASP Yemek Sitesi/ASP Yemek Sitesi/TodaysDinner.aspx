<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="TodaysDinner.aspx.cs" Inherits="ASP_Yemek_Sitesi.TodaysDinner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("GYemekAd") %>'></asp:Label>
                &nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("GYemekTarih") %>'></asp:Label>
                <br />
                <asp:Image ID="Image1" runat="server" Height="123px" ImageUrl='<%# Eval("GYemekResim") %>' Width="370px" />
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("GYemekMalzeme") %>'></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text='<%# Eval("GYemekTarif") %>'></asp:Label>
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
    </form>
</asp:Content>
