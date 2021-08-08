<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="GelişmeEkle.aspx.cs" Inherits="Huzur_Vinç.GelişmeEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <p>
            Gelişme Ekle</p>
        <p>
            <asp:TextBox ID="tboxHead" placeholder="Başlık giriniz" runat="server" Width="226px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="tboxPhoto" placeholder="Fotoğraf linki giriniz" runat="server" Width="223px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="tboxEXP" placeholder="Açıklama giriniz" runat="server" Height="123px" TextMode="MultiLine" Width="322px"></asp:TextBox>
        </p>
       
            <asp:Button ID="btnAdd" runat="server" Class="btn btn-danger" Height="49px" OnClick="btnAdd_Click" Text="Ekle" Width="99px" />
          </form>
</asp:Content>
