<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="HakkımızdaVeİletişim.aspx.cs" Inherits="Asp.net_Araba_satış_sitesi.HakkımızdaVeİletişim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <form id="form1" runat="server">
    <div class="container">

    
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td>HAKKIMIZDA</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("AboutDescription") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>TELEFON NUMARASI</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("ContactNumber") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>MAİL ADRESİ</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("ContactMail") %>'></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>

    
    </div>
    </form>
</asp:Content>
