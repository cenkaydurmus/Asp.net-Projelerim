<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="MesajlarıGör.aspx.cs" Inherits="Huzur_Vinç.MesajlarıGör" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                Gönderen kişinin adı:<asp:Label ID="Label1" runat="server" Text='<%# Eval("MessageFName") %>'></asp:Label>
                <br />
                Gönderen kişinin soyadı:<asp:Label ID="Label2" runat="server" Text='<%# Eval("MessageLName") %>'></asp:Label>
                <br />
                Gönderen kişinin mail adresi:<asp:Label ID="Label3" runat="server" Text='<%# Eval("MessageMail") %>'></asp:Label>
                <br />
                Mesaj:
                <asp:Label ID="Label4" runat="server" Text='<%# Eval("MessageExp") %>'></asp:Label>
                <br />
                <br />
               
                <br />
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
    </form>
</asp:Content>
