<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Veriİşlemleri.aspx.cs" Inherits="Asp_Kurs.Veriİşlemleri" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Verileri Listele" />
&nbsp;&nbsp;
    <br />
    <br />
    <asp:TextBox ID="tboxID" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Girilen id ye göre veriyi listele" Width="204px" />
    <br />
    <br />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Girilen id ye göre veriyi sil" />
    <br />
    <br />
    <br />
    <br />
    <asp:TextBox ID="txtBoxEditID" runat="server" OnTextChanged="txtBoxEditID_TextChanged"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtBoxEditp1" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtBoxEditp2" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Girilen id ye göre veriyi düzenle" Width="245px" />
    <br />
    <br />
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
             <asp:Label ID="Label3" runat="server" Text='<%# Eval("KurumsalID") %>'></asp:Label>
              <br />
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("AltKategori1") %>'></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text='<%# Eval("AltKategori2") %>'></asp:Label>
        </ItemTemplate>
    </asp:DataList>
    <br />
</asp:Content>
