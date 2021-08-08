<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Satış.aspx.cs" Inherits="Asp.net_Araba_satış_sitesi.Satış1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">

    <form id="form" runat="server">
        <div class="container">
            <h2>Araba satış sayfası</h2>
            <asp:DropDownList runat="server" ID="ddbrand">
            </asp:DropDownList>
            <asp:DropDownList runat="server" ID="ddfuel">
                <asp:ListItem Selected hidden>Benzin tipini seçiniz</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="tboxModel" placeholder="Araba modelini yazınız" runat="server"></asp:TextBox>
            <asp:TextBox ID="tboxContact" TextMode="Phone" placeholder="Telefon numaranızı yazınız" runat="server"></asp:TextBox>
            <asp:TextBox ID="tboxSeller" placeholder="Adınızı soyadınızı yazınız" runat="server"></asp:TextBox>
             <asp:TextBox ID="tboxImage" placeholder="Resim linkini giriniz" runat="server"></asp:TextBox>
              <asp:TextBox ID="tboxPrice" placeholder="Aracın fiyatını yazınız" TextMode="Number" runat="server"></asp:TextBox>
            <asp:TextBox ID="tboxDescription" TextMode="MultiLine" placeholder="Araba ile ilgili açıkla yazınız" runat="server"></asp:TextBox>

            <asp:Button ID="btnsubmit" runat="server" Text="Satış isteğini gönder" CssClass="btn" OnClick="btnsubmit_Click" />
        </div>
    </form>

</asp:Content>
