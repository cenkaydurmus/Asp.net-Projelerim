<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TekGelişme.aspx.cs" Inherits="Huzur_Vinç.TekGelişme" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Staatliches&display=swap" rel="stylesheet">
    <link href="maincss.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" rel="stylesheet">
    <title>Gelişmeler</title>
</head>
<body>
    <nav class="navbar">
        <img src="15696427_1288705651167851_1215887781_o.jpg" class="nav-img">
        <div style="font-size: 25px; margin-left: -80px; color: whitesmoke;">HUZUR VİNÇ</div>

        <a class="links" href="Makineler1.aspx">
            <div class="button-navigation">
                Makine & Ekipmanlar
            </div>
        </a>


        <a class="links" href="Gelişmeler.aspx">
            <div class="button-navigation">
                Gelişmeler
            </div>
        </a>

        <a class="links" href="Kurumsal.aspx">
            <div class="button-navigation">
                Kurumsal
            </div>
        </a>

        <a class="links" href="SosyalMedya.aspx">
            <div class="button-navigation">
                Sosyal Medyada Biz
            </div>
        </a>

        <a class="links" href="İletişim.aspx">
            <div class="button-navigation">
                İletişim
            </div>
        </a>

        <div>
            <a class="links" runat="server" id="linkudinsta" target="_blank" >
                <i style="margin-right: 5px; font-size: 25px; margin-top: 5px;" class="fab fa-instagram"></i>
            </a>

            <a class="links" runat="server" id="linkudface" target="_blank" >
                <i style="margin-right: 5px; font-size: 25px; margin-top: 5px;" class="fab fa-facebook"></i>
            </a>

            <a class="links"  runat="server" id="linkudwp" target="_blank" >
                <i style="margin-right: 5px; font-size: 25px; margin-top: 5px;" class="fab fa-whatsapp"></i>
            </a>

            <a class="links"  runat="server" id="linkudmap" target="_blank">
                <i style="margin-right: 5px; font-size: 25px; margin-top: 5px;" class="fas fa-map-marked-alt"></i>
            </a>

            <a class="links"  runat="server" id="linkudphone" >
                <i style="margin-right: 5px; font-size: 25px; margin-top: 5px;" class="fas fa-phone"></i>
            </a>
        </div>



    </nav>


  <div class="news-container" style="margin-bottom: 45px;">
        <p class="services-header">GELİŞMELER</p>

        <asp:DataList ID="DataList1" runat="server" Width="100%">
            <ItemTemplate>
                <div class="news-container" style="margin-bottom: 45px;min-height:1000px">
                    <a href="#" class="links" style="color: black;">
                        <p class="news-header"><%# Eval("NewsHeader") %></p>
                    </a>
                    <img class="news-img" src='<%# Eval("NewsPhoto") %>'>
                    <div style="align-self: flex-start; margin-left: 70px;"><%# Eval("NewsDate") %></div>
                    <p class="news-p">
                        <%# Eval("NewsExp") %>
                    </p>
                </div>
            </ItemTemplate>
        </asp:DataList>

      </div>





     <footer class="footer">
        <div class="aboutus-box">
            <h1 class="aboutus-header">HAKKIMIZDA</h1>
            <p class="aboutus-writing" runat="server" id="pabout">
               
            </p>
        </div>

        <div class="contact-box">
            <h1 class="aboutus-header">BİZİMLE İLETİŞİM KURUN</h1>
            <p class="aboutus-writing" runat="server" id="padress">
               
            </p>
            <p style="margin-top: 20px;" class="aboutus-writing" runat="server" id="pphone">
               
            </p>

            <p style="margin-top: 20px;" class="aboutus-writing" runat="server" id="pmail">
              
            </p>
        </div>

        <div class="call-button-box">

            <a class="links" runat="server" id="btnphone" >
                <div class="button-call">
                    <p class="midp">Bizi arayın</p>
                </div>
            </a>

        </div>
    </footer>
</body>
</html>
