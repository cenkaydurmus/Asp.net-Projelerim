<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="AdminSeeAllMessages.aspx.cs" Inherits="Yemek_Sitesi_Aspn.AdminSeeAllMessages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="nav-justified">
                    <tr>
                        <td>Yorum sahibi:<asp:Label ID="Label1" runat="server" Text='<%# Eval("MesajMail") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="border-bottom:1px solid black">Yorum:<asp:TextBox ID="tboxContent" runat="server" Height="123px" ReadOnly="True" Text='<%# Eval("Mesajİçerik") %>' TextMode="MultiLine" Width="391px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="border-bottom:1px solid black">
                          <a href="AdminDeleteMessage.aspx?id=<%# Eval("MesajID") %>"> <input type="button" value="Yorumu sil"  /></a>
                        </td>
                    </tr>
                    <tr>
                        <td style="border-bottom:1px solid black">
                            <asp:Label ID="lblID" runat="server" Text='<%# Eval("MesajID") %>' Visible="False"></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </form>
</asp:Content>
