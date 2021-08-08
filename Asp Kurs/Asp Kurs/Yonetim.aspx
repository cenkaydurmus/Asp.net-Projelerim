<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Yonetim.aspx.cs" Inherits="Asp_Kurs.Yonetim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
    <title></title>
    <style>
        body{
            height:100vh;
        }

        .tboxClass{
            width:200px;
            height:30px;
            margin-left:15px;
            margin-top:20px
        }

        .btnClass{
            width:200px;
            height:40px;
            margin-top:15px;
            margin-left:15px;
        }
    </style>
</head>
<body>
    <form  id="form1" runat="server" style="height:100%;display:flex; flex-direction:column;justify-content:center;align-items:center;" >
        <div style="display:flex;flex-direction:column; justify-content:center;align-items:center">
              <asp:TextBox CssClass="form-control tboxClass" ID="tboxKA" runat="server"></asp:TextBox>
        <asp:TextBox CssClass=" form-control tboxClass" ID="tboxŞifre" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Giriş Yap" CssClass="btn btn-danger btnClass" OnClick="Button1_Click" />
        </div>
      
    </form>
</body>
</html>
