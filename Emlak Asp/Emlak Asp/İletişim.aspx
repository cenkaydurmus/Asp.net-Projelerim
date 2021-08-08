<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="İletişim.aspx.cs" Inherits="Emlak_Asp.İletişim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="pad2">
            <h2 class="pad_bot1 pad_top1">Bizimle İletişime Geçin !</h2>
            <form runat="server" id="ContactForm" method="post">
              <div>
                <div  class="wrapper"> <span>Ad-Soyad:</span>
                    <asp:TextBox ID="tboxNameSurname" CssClass="input" runat="server"></asp:TextBox>
                  
                </div>
                <div  class="wrapper"> <span>Mail adresi:</span>
                   <asp:TextBox ID="tboxMail" CssClass="input" runat="server"></asp:TextBox>
                </div>
                <div  class="textarea_box"> <span>Mesajınız:</span>
                  <textarea runat="server" id="tboxMessage" name="textarea" cols="1" rows="1"></textarea>
                </div>
                <span>&nbsp;</span> <asp:Button OnClick="btnClear_Click" ID="btnClear" runat="server" CssClass="button" Text="Temizle" /> <asp:Button ID="btnSend" OnClick="btnSend_Click" runat="server" CssClass="button" Text="Gönder" /> </div>
            </form>
          </div>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>


