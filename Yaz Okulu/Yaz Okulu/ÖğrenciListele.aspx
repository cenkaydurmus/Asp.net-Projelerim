<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ÖğrenciListele.aspx.cs" Inherits="Yaz_Okulu.ÖğrenciListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-responsive"> 
        <thead>
            <tr>
                <th>ID</th>
                <th>Ad</th>
                <th>Soyad</th>
                <th>Mail</th>
                <th>Şifre</th>
                <th>Bakiye</th>
                <th>Okul No</th>
                <th>Düzenle</th>
                <th>Sil</th>
            </tr>
        </thead>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("OgrID") %></td>
                        <td><%# Eval("OgrAd") %></td>
                          <td><%# Eval("OgrSoyad") %></td>
                          <td><%# Eval("OgrMail") %></td>
                          <td><%# Eval("OgrSifre") %></td>
                          <td><%# Eval("Bakiye") %></td>
                          <td><%# Eval("OgrOkulNo") %></td>
                          <td ><a href="ÖğrenciDüzenle.aspx?OgrID=<%# Eval("OgrID") %>" class="btn btn-danger">Düzenle</a></td>
                         <td ><a href="ÖğrenciSil.aspx?OgrID=<%# Eval("OgrID") %>" class="btn btn-danger">Sil</a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
