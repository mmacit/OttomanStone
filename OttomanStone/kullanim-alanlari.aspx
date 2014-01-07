<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/ottoman.Master" AutoEventWireup="true" CodeBehind="kullanim-alanlari.aspx.cs" Inherits="OttomanStone.kullanim_alanlari" %>

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
            <h1>Kullanım Alanları</h1>
            <section class="gallery">
                <div class="navig-category">
                    <asp:Literal ID="lt_buttons" runat="server"></asp:Literal>
                    <a class="button categ td-three" href="#grid"><span><i class="three-coll"></i></span></a>
                    <a class="button categ list-three act" href="#list"><span><i class="three-coll-t"></i></span></a>
                </div>
                <div class="gallery-inner">
                    <asp:Literal ID="lt_kalan" runat="server"></asp:Literal>
                </div>
            </section>
            <div id="nav-above" class="navigation">
                <ul class="paginator">
                    <li class="larr"><a href="#container" class="button" title=""><span>Başa Dön</span></a></li>

                </ul>
            </div>

        </div>
        <!-- #container-->
        <aside id="aside">
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
            <div class="widget"></div>
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
                    <img alt="Ametist Geode hotel" src="/images/alibabadogaltas-link1.png" /></a>
            </div>
            <!-- #alibaba link son -->
        </aside>
    </div>
    <!-- #aside -->
</asp:Content>
