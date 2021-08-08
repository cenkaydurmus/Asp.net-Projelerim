<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true"  CodeBehind="SatışİsteğiOnayla.aspx.cs" Inherits="Asp.net_Araba_satış_sitesi.SatışİsteğiOnayla" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
   <div class="container">
      
           <form id="form" runat="server">
               
            <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("CarModel") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text='<%# Eval("CarFuelType") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" Text='<%# Eval("CarDescription") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label9" runat="server" Text='<%# Eval("CarContact") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label10" runat="server" Text='<%# Eval("CarSeller") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label11" runat="server" Text='<%# Eval("CarPrice") %>'></asp:Label>
                        </td>
                    </tr>
                      <tr >
                        <td>
                               <asp:HyperLink BackColor="Black" runat="server" ID="hl" NavigateUrl='<%# "Onay.aspx?CarID="+ Eval("CarID") %>'>Onay</asp:HyperLink>
                        </td>
                    </tr>
                    <tr >
                        <td style="border-bottom:1px solid black">
                            <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("CarPhoto") %>' />
                        </td>
                    </tr>

                   
                </table>
            </ItemTemplate>
        </asp:DataList>
           </form>
     
        </div>
</asp:Content>
