<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ÖğrenciDüzenle.aspx.cs" Inherits="Yaz_Okulu.ÖğrenciDüzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <h2>Öğrenci Düzenleme sayfası</h2>
    <form runat="server" id="form1"> 
        <asp:TextBox ID="tboxAd" placeholder="İsminizi giriniz" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:TextBox ID="tboxSoyad" placeholder="Soyisminizi giriniz" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:TextBox ID="tboxMail" placeholder="Mail adresinizi giriniz" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:TextBox ID="tboxPas" placeholder="Şifrenizi giriniz" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:TextBox ID="tboxNo" placeholder="Okul Numaranızı giriniz" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Button ID="btn" runat="server" Text="Düzenle" CssClass="btn btn-danger" OnClick="btn_Click" />
    </form>
</asp:Content>
