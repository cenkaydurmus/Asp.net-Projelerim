<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="AdminAnaKategoriEkle.aspx.cs" ValidateRequest="false"  Inherits="Asp_Kurs.AdminAnaKategoriEkle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
<script src="https://cdn.ckeditor.com/4.16.0/standard/ckeditor.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display:flex;flex-direction:column;">
            <asp:TextBox ID="tboxCategoryName" runat="server"></asp:TextBox>
            <asp:Button ID="btnAdd" runat="server" Text="Ana kategori ekle" OnClick="btnAdd_Click" />
        </div>

          <textarea runat="server" id="editor1" name="editor1"></textarea>
                <script>
                    CKEDITOR.replace('editor1');
                </script>

    <asp:Button ID="Button1" runat="server" Text="Metni Düzenle" OnClick="Button1_Click" />
    </form>

 

</body>
</html>


