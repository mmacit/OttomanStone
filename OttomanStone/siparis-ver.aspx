<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/ottoman.Master" AutoEventWireup="true" CodeBehind="siparis-ver.aspx.cs" Inherits="OttomanStone.siparis_ver" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript">
        $(function () {
            $("#drp_urun").change(function () {
                $("#fiyat").html("Yükleniyor...");
                var id = $("#drp_urun option:selected").val();
                $.ajax({
                    type: "POST",
                    url: "/siparis-ver.aspx/GetUrunFiyat",  //WebMethod'umuzun yerini gösteriyoruz
                    data: "{id:" + id + "}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        $("#fiyat").html("Tutar : " + msg.d);
                    }
                });
            });

            $("#fiyat").html("Yükleniyor...");
            var id = $("#drp_urun option:selected").val();
            $.ajax({
                type: "POST",
                url: "/siparis-ver.aspx/GetUrunFiyat",  //WebMethod'umuzun yerini gösteriyoruz
                data: "{id:" + id + "}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (msg) {
                    $("#fiyat").html("Tutar : " + msg.d);
                }
            });

        });
    </script>
    <style>
        #home-bg {
            background-position-y: -485px !important;
        }

        .get-in-touch {
            float: none;
        }

        .gallery .textwidget {
            margin: 0 0px 18px 0;
        }
    </style>
    <div class="entry uniform get-in-touch">
        <div id="container">
            <h1>Ürün Sipariş Bölümü</h1>
            <div class="entry-content cont">
                <div class="conact-info">
                    <p>
                        Ürünlerimizi tek sayfada ve çok hızlı siparişlerinizi verebilirsiniz.                      
                    </p>
                    <p>
                        Gerekli alanlar &quot;e-Mail - Telefon - Ad Soyad - Şehir&quot;

                    </p>
                </div>

                <div id="form-holder" class="cont">
                    <div id="dv_bilgilendirme" runat="server" clientidmode="static" class="bilgilendirme">
                        <asp:Literal ID="lt_bilgi" runat="server"></asp:Literal>
                    </div>
                    <h2>Alıcı Bilgileri</h2>
                    <div class="i-h">
                        <input runat="server" id="ad_soyad" type="text" class="" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Style="margin-left: 115px; color: red; margin-top: 4px; position: absolute;" ErrorMessage="*" ControlToValidate="ad_soyad" ValidationGroup="vld_siparis"></asp:RequiredFieldValidator>
                        <div class="i-l"><span>Ad Soyad</span></div>
                    </div>
                    <div class="i-h">
                        <input runat="server" id="telefon" type="text" class="" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Style="margin-left: 115px; color: red; margin-top: 4px; position: absolute;" ErrorMessage="*" ControlToValidate="telefon" ValidationGroup="vld_siparis"></asp:RequiredFieldValidator>
                        <div class="i-l"><span>Telefon</span></div>
                    </div>
                    <div class="i-h">
                        <input runat="server" id="email" type="text" class="" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Style="margin-left: 115px; color: red; margin-top: 4px; position: absolute;" ErrorMessage="*" ControlToValidate="email" ValidationGroup="vld_siparis"></asp:RequiredFieldValidator>
                        <div class="i-l"><span>E-mail</span></div>
                    </div>
                    <div class="i-h">
                        <input runat="server" id="adres1" type="text" class="" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Style="margin-left: 115px; color: red; margin-top: 4px; position: absolute;" ErrorMessage="*" ControlToValidate="adres1" ValidationGroup="vld_siparis"></asp:RequiredFieldValidator>
                        <div class="i-l"><span>Adres-1</span></div>
                    </div>
                    <div class="i-h">
                        <input runat="server" id="adres2" type="text" class="" /><div class="i-l"><span>Adres-2</span></div>
                    </div>
                    <div class="i-h">
                        <input runat="server" id="ulke" type="text" class="" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Style="margin-left: 115px; color: red; margin-top: 4px; position: absolute;" ErrorMessage="*" ControlToValidate="ulke" ValidationGroup="vld_siparis"></asp:RequiredFieldValidator>
                        <div class="i-l"><span>Ülke</span></div>
                    </div>
                    <div class="i-h">
                        <input runat="server" id="sehir" type="text" class="" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Style="margin-left: 115px; color: red; margin-top: 4px; position: absolute;" ErrorMessage="*" ControlToValidate="sehir" ValidationGroup="vld_siparis"></asp:RequiredFieldValidator>
                        <div class="i-l"><span>Şehir</span></div>
                    </div>
                    <div class="i-h">
                        <input runat="server" id="ilce" type="text" class="" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" Style="margin-left: 115px; color: red; margin-top: 4px; position: absolute;" runat="server" ErrorMessage="*" ControlToValidate="ilce" ValidationGroup="vld_siparis"></asp:RequiredFieldValidator>
                        <div class="i-l"><span>İlçe</span></div>
                    </div>
                    <div class="i-h">
                        <input runat="server" id="posta_kodu" type="text" class="" /><div class="i-l"><span>Posta Kodu</span></div>
                    </div>
                    <div class="t-h">
                        <textarea runat="server" id="message1" class=""></textarea>
                    </div>
                    <div class="temizle"></div>
                    <h2>Sipariş verilecek ürün bilgileri</h2>
                    <div class="i-k">
                        <span class="form_childs">
                            <asp:DropDownList ID="drp_urun" ClientIDMode="Static" runat="server"></asp:DropDownList>
                        </span>
                    </div>
                    <div class="i-k">
                        <span class="form_childs">
                            <select runat="server" id="odeme_sekli" class="i-k">
                                <option value="1">Yapılacak Ödeme Şeklini Seçin</option>
                                <option value="2">Havale ile ödeme</option>
                                <option value="3">EFT ile ödeme</option>
                                <option value="4">Mağazadan Teslim Alınacak</option>
                            </select>
                        </span>
                    </div>
                    <span id="fiyat" runat="server" clientidmode="static">Tutar : </span>
                    <a runat="server" id="a_siparis_ver" class="button" validationgroup="vld_siparis" title="Submit"><span><i class="submit"></i>Sipariş Ver</span></a>
                    <a href="/siparis-ver" class="do-clear">Sipariş Formunu Sil</a>
                </div>
                <div class="havale-metni">
                    <ul class="categories type">
                        <h2>Sipariş için notlar</h2>
                        <li class="quote">
                            <h4><a href="#">Banka havalesi ile EFT veya mağazamızdan teslim alma ile siparişlerinizi tamamladıktan sonra sizinle kısa süre içerisinde yetkili arkadaşlar verdiğiniz iletişim bilgilerinden ulaşıp bilgilendirecektir. </a></h4>
                        </li>
                    </ul>
                    <p></p>
                    <p></p>
                    <ul class="categories type">
                        <li class="quote">
                            <h4><a href="#">%10 - %15 indirimden yararlanmanız için ottomanstone.com sitemizden sipariş vererek ürün siparişlerinizden Mağazadan Teslim seçeneği ile Ametist Ürünlerde %10 ile %15 indirimlerinden yararlanabilirsiniz.</a></h4>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
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
                <div class="header">
                    Yararları
    							
                </div>
                <div class="reviews-t">
                    <div class="coda-slider-wrapper">
                        <div class="coda-slider preload" id="coda-slider-1">
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


        </aside>
    </div>
</asp:Content>
