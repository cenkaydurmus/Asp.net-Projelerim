<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Alış.aspx.cs" Inherits="Asp.net_Araba_satış_sitesi.Satış" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <form id="form1" runat="server">
    <div class="container-row">
        <div class="sidebar">
            <h2>MARKALAR</h2>
            <asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
                   <a href="AlışAraç.aspx?BrandID=<%# Eval("BrandID") %>" class="brandlinks"><asp:Label ID="Label1" runat="server"  Text='<%# Eval("BrandName") %>'></asp:Label></a> 
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
    </form>
</asp:Content>
