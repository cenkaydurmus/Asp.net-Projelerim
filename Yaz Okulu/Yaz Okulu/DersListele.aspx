<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="DersListele.aspx.cs" Inherits="Yaz_Okulu.DersListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="table table-responsive"> 
        <thead>
            <tr>
                <th>ID</th>
                <th>Ders Adı</th>
                <th>Maximum Kontenjan</th>
                <th>Minimum Kontenjan</th>
                <th>Öğrenci Sayısı</th>
             
                <th>Düzenle</th>
                <th>Sil</th>
            </tr>
        </thead>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("DersID") %></td>
                        <td><%# Eval("DersAd") %></td>
                          <td><%# Eval("MaxKont") %></td>
                          <td><%# Eval("MinKont") %></td>
                          <td><%# Eval("OgrSayısı") %></td>
                         
                          <td ><a href="DersDüzenle.aspx?DersID=<%# Eval("DersID") %>" class="btn btn-danger">Düzenle</a></td>
                         <td ><a href="DersSil.aspx?DersID=<%# Eval("DersID") %>" class="btn btn-danger">Sil</a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
