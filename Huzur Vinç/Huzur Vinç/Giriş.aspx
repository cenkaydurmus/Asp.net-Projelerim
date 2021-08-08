<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giriş.aspx.cs" Inherits="Huzur_Vinç.Giriş" %>

<!DOCTYPE html>
<html lang="tr">
<head>
    <title>Bootstrap Example</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

</head>
<body>

   <form runat="server" style="display:flex;flex-direction:column; width:100%; height:250px;justify-content:space-between;align-items:center;">
       <div>GİRİŞ YAP</div>
       <input runat="server"  style="width:200px" placeholder="Kullanıcı adı giriniz"  type="text" id="tboxKa" class="form-control"/>
         <input runat="server"  style="width:200px" placeholder="Şifre giriniz" type="password" id="tboxPass" class="form-control" />
       <asp:Button ID="Button1" runat="server" Text="Giriş yap" CssClass="btn btn-danger" OnClick="Button1_Click" />
   </form>


</body>
</html>
