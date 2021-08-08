<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="DersEkle.aspx.cs" Inherits="Yaz_Okulu.DersEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Ders Ekleme sayfası</h2>
    <form runat="server" id="form1"> 
        <asp:TextBox ID="tboxAd" placeholder="İsminizi giriniz" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:TextBox ID="tboxMax" placeholder="Max kontenjanı giriniz" TextMode="Number" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:TextBox ID="tboxMin" placeholder="Min kontenjanı giriniz" TextMode="Number" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:TextBox ID="tboxSayı" placeholder="Öğrenci sayısını giriniz" TextMode="Number" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:Button ID="btn" runat="server" Text="Ekle" CssClass="btn btn-danger" OnClick="btn_Click"  />
    </form>
</asp:Content>
