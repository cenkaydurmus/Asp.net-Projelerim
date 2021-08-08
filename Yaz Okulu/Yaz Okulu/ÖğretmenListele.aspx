<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ÖğretmenListele.aspx.cs" Inherits="Yaz_Okulu.ÖğretmenListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <table class="table table-responsive"> 
        <thead>
            <tr>
                <th>ID</th>
                <th>Öğretmen Adı Soyadu</th>
                <th>Öğretmenin Dersi</th>
               
                <th>Düzenle</th>
                <th>Sil</th>
            </tr>
        </thead>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("OgrtID") %></td>
                        <td><%# Eval("OgrtAdSoyad") %></td>
                          <td><%# Eval("DersAd") %></td>
                          <td ><a href="ÖğretmenDüzenle.aspx?OgrtID=<%# Eval("OgrtID") %>" class="btn btn-danger">Düzenle</a></td>
                         <td ><a href="ÖğretmenSil.aspx?OgrtID=<%# Eval("OgrtID") %>" class="btn btn-danger">Sil</a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
