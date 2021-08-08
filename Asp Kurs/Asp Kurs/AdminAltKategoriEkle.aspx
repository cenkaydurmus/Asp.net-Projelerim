<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminAltKategoriEkle.aspx.cs" Inherits="Asp_Kurs.AdminAltKategoriEkle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display:flex;flex-direction:column">
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <asp:TextBox ID="tboxAltCategoryName" runat="server" placeholder="Alt kategori adını giriniz"></asp:TextBox>
            <asp:TextBox ID="tboxAltLink" runat="server" placeholder="Alt kategori linkini giriniz"></asp:TextBox>
            <asp:Button  ID="Button1" runat="server" Text="Alt kategori ekle" OnClick="Button1_Click" />

           <a href="AdminAnaSayfaDeneme.aspx"><input type="button" value="Önceki sayfaya dön" /></a> 
        </div>
    </form>
</body>
</html>
