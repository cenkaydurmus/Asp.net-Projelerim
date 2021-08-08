<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SosyalMedya.aspx.cs" Inherits="Huzur_Vinç.SosyalMedya" %>

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
    <title>Sosyal Medyada Biz!</title>
</head>
<body runat="server" id="PageBody">
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


      <div class="contact-div" style="margin-bottom:50px">

          <div style="display:flex;flex-direction:row;">
               <p class="services-header" style="margin-top: 25px;color:#439343;">Sosyal Medya Sorumlusu </p> <div>&nbsp;</div> <div>&nbsp;</div> <div>&nbsp;</div> <asp:Label ID="LabelName" class="services-header" style="margin-top: 25px;color:#439343;" runat="server" Text=""></asp:Label>
          </div>
       

       <div class="contact-info">
      <span>Mail adresi :</span>
        <span>&nbsp;</span>
        <span>&nbsp;</span>
           <asp:Label ID="LabelMail" runat="server" ></asp:Label>
        
       </div>

       <div class="contact-info">
        <span>Telefon numarası :</span>
          <span>&nbsp;</span>
          <span>&nbsp;</span>
           <asp:Label ID="LabelPhone" runat="server" ></asp:Label>
          
         </div>


         

             <a class="links" style="color: black;" id="linkpinsta" runat="server" target="_blank" >
                <div class="contact-info">
                    <i  style="line-height: 30px;" class="fab fa-instagram"></i>
                    <span style="margin-left: 5px;">Kişisel instagram hesabına ulaşmak için tıklayınız</span>
                     </div>
             </a>
           
             <a class="links" style="color: black;" id="linkinsta" runat="server" target="_blank">
                <div class="contact-info">
                    <i  style="line-height: 30px;" class="fab fa-instagram"></i>
                    <span style="margin-left: 5px;">Huzur Vinç Instagram hesabına ulaşmak için tıklayınız</span>
                     </div>
             </a>
         
       

             <a class="links" style="color: black;" id="linkfbook" runat="server" target="_blank">
                <div class="contact-info">
                    <i  style="line-height: 30px;" class="fab fa-facebook"></i>
                    <span style="margin-left: 5px;">Huzur Vinç Facebook hesabına ulaşmak için tıklayınız</span>
                     </div>
             </a>


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