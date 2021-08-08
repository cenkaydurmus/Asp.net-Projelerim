<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ÖğretmenEkle.aspx.cs" Inherits="Yaz_Okulu.ÖğretmenEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h2>Öğretmen Ekleme sayfası</h2>
    <form runat="server" id="form1"> 
        <asp:TextBox ID="tboxAd" placeholder="İsminizi giriniz" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server">
            <asp:ListItem Value="">Select</asp:ListItem>
        </asp:DropDownList>
    <asp:Button ID="btn" runat="server" Text="Ekle" CssClass="btn btn-danger" OnClick="btn_Click"  />
    </form>
</asp:Content>
