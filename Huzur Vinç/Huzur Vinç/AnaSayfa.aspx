<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="Huzur_Vinç.AnaSayfa" %>

<!DOCTYPE html>
<html lang="tr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Staatliches&display=swap" rel="stylesheet">
    <link href="maincss.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" rel="stylesheet">
    <title>Ana Sayfa</title>
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
            <a class="links" runat="server" id="linkudinsta" target="_blank">
                <i style="margin-right: 5px; font-size: 25px; margin-top: 5px;" class="fab fa-instagram"></i>
            </a>

            <a class="links" runat="server" id="linkudface" target="_blank">
                <i style="margin-right: 5px; font-size: 25px; margin-top: 5px;" class="fab fa-facebook"></i>
            </a>

            <a class="links" runat="server" id="linkudwp" target="_blank">
                <i style="margin-right: 5px; font-size: 25px; margin-top: 5px;" class="fab fa-whatsapp"></i>
            </a>

            <a class="links" runat="server" id="linkudmap" target="_blank">
                <i style="margin-right: 5px; font-size: 25px; margin-top: 5px;" class="fas fa-map-marked-alt"></i>
            </a>

            <a class="links" runat="server" id="linkudphone">
                <i style="margin-right: 5px; font-size: 25px; margin-top: 5px;" class="fas fa-phone"></i>
            </a>
        </div>



    </nav>

    <div class="slideshow-container" data-transition="crossfade" data-loop="true" data-skip="false">
        <div class="mySlides fade">
            <div class="numbertext">1 / 7</div>
            <asp:Image ID="Image1" runat="server" class="slide-img" Style="width: 100%; height: 604px;" />

        </div>


        <div class="mySlides fade">
            <div class="numbertext">2 / 7</div>
            <asp:Image ID="Image2" runat="server" class="slide-img" Style="width: 100%; height: 604px;" />

        </div>

        <div class="mySlides fade">
            <div class="numbertext">3 / 7</div>
            <asp:Image ID="Image3" runat="server" class="slide-img" Style="width: 100%; height: 604px;" />

        </div>

        <div class="mySlides fade">
            <div class="numbertext">4 / 7</div>
            <asp:Image ID="Image4" runat="server" class="slide-img" Style="width: 100%; height: 604px;" />

        </div>

        <div class="mySlides fade">
            <div class="numbertext">5 / 7</div>
            <asp:Image ID="Image5" runat="server" class="slide-img" Style="width: 100%; height: 604px;" />

        </div>

        <div class="mySlides fade">
            <div class="numbertext">6/ 7</div>
            <asp:Image ID="Image6" runat="server" class="slide-img" Style="width: 100%; height: 604px;" />

        </div>

        <div class="mySlides fade">
            <div class="numbertext">7 / 7</div>
            <asp:Image ID="Image7" runat="server" class="slide-img" Style="width: 100%; height: 604px;" />

        </div>


    </div>



    </div>



    <br>

    <div style="text-align: center">
        <span class="dot"></span>
        <span class="dot"></span>
        <span class="dot"></span>
        <span class="dot"></span>
        <span class="dot"></span>
        <span class="dot"></span>
        <span class="dot"></span>
    </div>



    <div class="main-news-container">

        <p class="services-header">SON GELİŞMELER</p>

        <asp:DataList ID="DataList2" runat="server">
            <ItemTemplate>
                <div class="main-news-line">
                    <span><%# Eval("NewsDate") %></span>
                    <span>&nbsp;</span>
                    <span>&nbsp;</span>
                    <span>&nbsp;</span>
                    <span><%# Eval("NewsHeader") %></span>
                    <span>&nbsp;</span>
                    <span>&nbsp;</span>
                    <span>&nbsp;</span>
                    <a href="TekGelişme.aspx?id=<%# Eval("NewsID") %>">
                        <button class="btn-news">Habere git &#8594;</button></a>
                </div>
            </ItemTemplate>
        </asp:DataList>

    </div>





    <div class="services-content">



        <div class="services-box">
            <p class="services-header">HİZMETLERİMİZ</p>



            <asp:DataList ID="DataList1" Width="80%" runat="server">
                <ItemTemplate>

                    <div class="services-detailed">
                        <img class="imgs" runat="server" src='<%# Eval("CategoryPhoto") %>'>
                        <a href="Makineler2.aspx?id=<%# Eval("CategoryID") %>" class="links">
                            <p class="services-little-header"><%# Eval("CategoryName") %></p>
                        </a>
                    </div>
                </ItemTemplate>
            </asp:DataList>




        </div>
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

            <a class="links" runat="server" id="btnphone">
                <div class="button-call">
                    <p class="midp">Bizi arayın</p>
                </div>
            </a>

        </div>
    </footer>
</body>
</html>

<script>
    var slideIndex = 0;
    showSlides();

    function showSlides() {
        var i;
        var slides = document.getElementsByClassName("mySlides");
        var dots = document.getElementsByClassName("dot");
        for (i = 0; i < slides.length; i++) {
            slides[i].style.display = "none";
        }
        slideIndex++;
        if (slideIndex > slides.length) { slideIndex = 1 }
        for (i = 0; i < dots.length; i++) {
            dots[i].className = dots[i].className.replace(" active", "");
        }
        slides[slideIndex - 1].style.display = "block";
        dots[slideIndex - 1].className += " active";
        setTimeout(showSlides, 5000); // Change image every 2 seconds
    }

</script>
