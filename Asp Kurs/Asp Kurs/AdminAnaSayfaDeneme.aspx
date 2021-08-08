<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminAnaSayfaDeneme.aspx.cs" Inherits="Asp_Kurs.AdminAnaSayfaDeneme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <h1>HOŞ GELDİNİZ !</h1>
    <p>&nbsp;</p>
    <asp:Button ID="Button1" runat="server" Text="Çıkış Yap" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Ana kategori ekle" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Alt kategori ekle" OnClick="Button3_Click"  />
    </form>
  
</body>
</html>
