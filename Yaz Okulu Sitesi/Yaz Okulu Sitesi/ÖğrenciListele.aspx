<%@ Page Title="" Language="C#" MasterPageFile="~/AnaSayfa.master" AutoEventWireup="true" CodeFile="ÖğrenciListele.aspx.cs" Inherits="ÖğrenciListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="table table-bordered table-responsive">
        <tr>
            <th>ID</th>
            <th>Ad</th>
            <th>Soyad</th>
            <th>Mail</th>
            <th>Şifre</th>
            <th>Bakiye</th>
            <th>Okul No</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("OGRAD") %></td>
                        <td><%# Eval("OGRSOYAD") %></td>
                        <td><%# Eval("OGRMAIL") %></td>
                        <td><%# Eval("OGRSIFRE") %></td>
                        <td><%# Eval("BAKIYE") %></td>
                        <td><%# Eval("OGROKULNO") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/ÖğrenciSil.aspx?OgrID=" + Eval("ID") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/ÖğrenciGüncelle.aspx?OgrID=" + Eval("ID") %>' ID="HyperLink1" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>


</asp:Content>

