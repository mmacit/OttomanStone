<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/ottoman.Master" AutoEventWireup="true" CodeBehind="urunler.aspx.cs" Inherits="OttomanStone.urunler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        #home-bg {
            background-position-y: -485px !important;
        }

        .gallery .textwidget {
            margin: 0 0px 18px 0;
        }
    </style>
    <div class="entry">
        <div id="container">
            <h1><%= baslik %>  </h1>
            </br> Amethyst Geode Natural Healing Products 
      		
            <section class="gallery">
                <div class="navig-category">
                    <a class="button act" href="<%= sayfalink %>/urunler"><span>AMETİST ÜRÜNLER</span></a>
                    <a class="button" href="<%= sayfalink %>/urunler?mod=ozel-tasarim"><span><i class="lik"></i>ÖZEL TASARIM ÜRÜNLER</span></a>
                    <a class="button" href="<%= sayfalink %>/urunler?mod=yeni-urunler"><span><i class="more"></i>YENİ ÜRÜNLER</span></a>
                </div>
                <div class="textwidget text first">
                    <asp:Literal ID="lt_uruns" runat="server"></asp:Literal>
                </div>
                <!-- ürünler son-->


            </section>
            <div id="nav-above" class="navigation">
                <ul class="paginator">
                    <asp:Literal ID="li_dots" runat="server"></asp:Literal>
                    <li class="larr"><a href="#" class="button" title=""><span>Başa Dön</span></a></li><li><a href="" class="buttonY" title=""><span>BİZİ TAKİP EDİN, YENİ ÜRÜNLERİ İLK SİZ SEÇİN</span></a></li>


                </ul>
            </div>
        </div>
        <!-- #container-->
        <aside id="aside">
            <div class="widget">
                <div class="header">
                    AMETİST TAŞININ BULUNDUĞU ORTAMDA İNSAN ÜZERİNDEKİ ETKİLERİ
    							
                </div>
                <ul class="categories type">
                    <li class="quote"><a href="#">Negatif Elektiriği Alır</a></li>
                    <li class="quote"><a href="#">Sarhoşluğu Yok Eder</a></li>
                    <li class="quote"><a href="#">Bilinci Aktifleştirir</a></li>
                    <li class="quote"><a href="#">Yoğunlaşmayı Arttırır</a></li>
                    <li class="quote"><a href="#">Sürekli Pozitif Enerji Verir</a></li>
                    <li class="quote"><a href="#">Enerjisiyle Huzur Vericidir</a></li>
                    <li class="quote"><a href="#">Takıntılı Düşüncelerden Alıkoyar</a></li>
                    <li class="quote"><a href="#">Uyum ve Denge Sağlar</a></li>
                    <li class="quote"><a href="#">Cilt Hastalıklarına Faydalıdır</a></li>
                    <li class="quote"><a href="#">Depresyona Karşı Tavsiye Edilir</a></li>
                    <li class="quote"><a href="#">Tenin Güzelleşmesinde Etkilidir</a></li>
                    <li class="quote"><a href="#">Başta Alerjiye İyi Gelir</a></li>
                    <li class="quote"><a href="#">Kalp Baş ve Migrene İyi Gelir</a></li>
                    <li class="quote"><a href="#">Uyku Problemli Kişiye Önerilir</a></li>
                    <li class="quote"><a href="#">Kanı Temizler</a></li>
                </ul>
            </div>
            <div class="widget">
                <div class="header">Kullanım Alanları</div>
                <div class="list-carousel recent">
                    <ul id="foo1">
                        <li>
                            <div class="textwidget first">
                                <div class="textwidget-photo">
                                    <a class="photo highslide" href="images/kullanim-alanlari/bahce/ametist-bahce-2.jpg" onclick="return hs.expand(this, galleryOptions)">
                                        <img alt="Ametist Bahçe" src="images/kullanim-alanlari/bahce/ametist-bahce-2-k.jpg" width="202" height="122" /></a> <a class="like"><span>01</span></a>
                                </div>
                            </div>
                        </li>
                        <li>
                            <div class="textwidget">
                                <div class="textwidget-photo">
                                    <a class="photo highslide" href="images/kullanim-alanlari/otel/ametist-otelde-2.jpg" onclick="return hs.expand(this, galleryOptions)">
                                        <img alt="Ametist Otel" src="images/kullanim-alanlari/otel/ametist-otelde-2-k.jpg" width="202" height="122" /></a> <a class="like"><span>02</span></a>
                                </div>
                            </div>
                        </li>
                        <li>
                            <div class="textwidget">
                                <div class="textwidget-photo">
                                    <a class="photo highslide" href="images/kullanim-alanlari/otel/ametist-otelde-3.jpg" onclick="return hs.expand(this, galleryOptions)">
                                        <img alt="Ametist Geode hotel" src="images/kullanim-alanlari/otel/ametist-otelde-3-k.jpg" width="202" height="122" /></a> <a class="like"><span>03</span></a>
                                </div>
                            </div>
                        </li>
                        <li>
                            <div class="textwidget">
                                <div class="textwidget-photo">
                                    <a class="photo highslide" href="images/kullanim-alanlari/ofis/ametist-ofis-1.jpg" onclick="return hs.expand(this, galleryOptions)">
                                        <img alt="Amethyst Office" src="images/kullanim-alanlari/ofis/ametist-ofis-1-k.jpg" width="202" height="122" /></a> <a class="like"><span>04</span></a>
                                </div>
                            </div>
                        </li>
                        <li>
                            <div class="textwidget">
                                <div class="textwidget-photo">
                                    <a class="photo highslide" href="images/kullanim-alanlari/ofis/ametist-ofis-2.jpg" onclick="return hs.expand(this, galleryOptions)">
                                        <img alt="Ametist  Ofis" src="images/kullanim-alanlari/ofis/ametist-ofis-2-k.jpg" width="202" height="122" /></a> <a class="like"><span>05</span></a>
                                </div>
                            </div>
                        </li>
                        <li>
                            <div class="textwidget">
                                <div class="textwidget-photo">
                                    <a class="photo highslide" href="images/kullanim-alanlari/ofis/ametist-ofis-3.jpg" onclick="return hs.expand(this, galleryOptions)">
                                        <img alt="Ametist - Amethyst" src="images/kullanim-alanlari/ofis/ametist-ofis-3-k.jpg" width="215" height="122" /></a> <a class="like"><span>06</span></a>
                                </div>
                            </div>
                        </li>
                    </ul>
                    <a id="prev1" class="prev" href="#"></a><a id="next1" class="next" href="#"></a>
                </div>
            </div>
            <div class="widget">
                <div class="header">
                    Yararları
    							
                </div>
                <div class="reviews-t">
                    <div class="coda-slider-wrapper">
                        <div class="coda-slider preload" id="coda-slider-2">
                            <div class="panel">
                                <div class="panel-wrapper">
                                    <p>İnsana iç huzuru vererek ani ve doğru karar verme yetisini güçlendirir. Pembe kuvars ile birlikte taşındığında veya bulundurulduğunda aklı güçlendirdiği bilinir.</p>
                                </div>
                            </div>
                            <div class="panel">
                                <div class="panel-wrapper">
                                    <p>Bedende sürekli negatif elektirik bulunduğu için bedendeki fazla elektrik yükünü toplayarak, beynin çalışmasını hızlandırır.</p>
                                </div>
                            </div>
                            <div class="panel">
                                <div class="panel-wrapper">
                                    <p>Göz rahatsızlıklarına, migrana, kalp hastalıklarına ve özellikle alerjiye iyi gelmektedir.</p>
                                </div>
                            </div>
                            <div class="panel">
                                <div class="panel-wrapper">
                                    <p>Şifası yüksek olan ametist taşı cilt hastalıklarına karşı etkisi birebirdir. </p>
                                </div>
                            </div>
                            <div class="panel">
                                <div class="panel-wrapper">
                                    <p>Bulunduğu ortamdaki bütün negatif elektirikleri toplayıp pozitif enerjiye çevirmesiyle odanın veya mekanınızın herhangi bir yerinde bile durması pozitif enerjisinden faydalanmanız için yeterlidir. </p>
                                </div>
                            </div>
                            <div class="panel">
                                <div class="panel-wrapper">
                                    <p>İnsanların gereksiz takıntı ve rahatsız edici düşüncelerinizden alıkoyup vucudunuzdan uzakyaştırır. Bu etkileşimle insanın rahatlaması ve dinç düşünmesine sebeb olur.</p>
                                </div>
                            </div>
                            <div class="panel">
                                <div class="panel-wrapper">
                                    <p>Taşlar arasında negatif enerjiyi pozitif enerjiye dönüştürüp insanın ruh ve beden sağlığında iyi olduğu tek taş ametist taşıdır. </p>
                                </div>
                            </div>
                            <div class="panel">
                                <div class="panel-wrapper">
                                    <p>Yaydığı pozitif enerjisiyle vucutda uyum ve denge oluşmasına neden olur.</p>
                                </div>
                            </div>
                            <div class="panel">
                                <div class="panel-wrapper">
                                    <p>Ametist taşındaki hoş ve güzel renkleriyle insanları psikolojik rahatlıklar ile huzurlu olmasını sağlar.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="reviews-b">
                    </div>
                </div>
                <p class="autor">Psikolojik etkileri</p>
            </div>



            <!-- #facebook başlangıç -->
            <div id="fb-root"></div>
            <div class="fb-like-box" data-href="http://www.facebook.com/ottomanstone" data-width="210" data-height="300" data-show-faces="true" data-stream="false" data-header="false"></div>
            <!-- #facebook son -->

            <!-- #twitter başlangıç -->
            <div class="widget"></div>
            <a href="https://twitter.com/OttomanStone" class="twitter-follow-button" data-show-count="false" data-lang="tr" data-size="large" data-dnt="true">Takip et: @OttomanStone</a>
            <!-- #twitter son -->
            <!-- #google+ başlangıç -->
            <!-- Bu etiketi +1 düğmesinin görüntülenmesini istediğiniz yere yerleştirin -->
            <div class="g-plusone"></div>
            <!-- #google+ son -->

            <!-- #alibaba link baş -->
            <div class="textwidget-photo">
                <a target="_blank" class="photo highslide" href="http://www.alibabadogaltas.com.tr">
                    <img alt="alibaba doğal taş" src="images/alibabadogaltas-link1.png" /></a>
            </div>
            <!-- #alibaba link son -->

        </aside>
        <!-- #aside -->
    </div>
</asp:Content>
