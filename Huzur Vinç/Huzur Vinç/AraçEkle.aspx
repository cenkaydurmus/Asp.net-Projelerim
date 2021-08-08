<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AraçEkle.aspx.cs" Inherits="Huzur_Vinç.AraçEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <p>
            Araç Ekle</p>
        <p>
            <asp:DropDownList ID="DropDownList1" placeholder="Araç kategorisini seçiniz" runat="server" Height="21px" Width="126px">
            </asp:DropDownList>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox  ID="tboxAd" placeholder="Araç için başlık giriniz" runat="server" Width="227px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="tboxExp" placeholder="Araca açıklama giriniz" runat="server" Height="114px" TextMode="MultiLine" Width="232px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="tboxPhoto" placeholder="Aracın fotoğraf linkini giriniz" runat="server" Width="228px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnAdd" CssClass="btn btn-danger" runat="server" Text="Ekle" Width="91px" OnClick="btnAdd_Click" />
        </p>
    </form>
</asp:Content>
