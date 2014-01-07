<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/ottoman.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="OttomanStone._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="navig-nivo"></div>

    <section id="slide">
        <div id="fancytile-slide">
            <ul>
                <asp:Literal ID="lt_ust" runat="server"></asp:Literal>
            </ul>
        </div>
        <div class="mask">
            <div class="swf">
                <script src="/js/swfobject_modified.js"></script>
                <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="950" height="420" id="FlashID" title="Ametist tanıtım videosu">
                    <param name="movie" value="/flash/ottoman-video-2.swf">
                    <param name="quality" value="high">
                    <param name="wmode" value="opaque">
                    <param name="swfversion" value="8.0.35.0">
                    <!-- This param tag prompts users with Flash Player 6.0 r65 and higher to download the latest version of Flash Player. Delete it if you don’t want users to see the prompt. -->
                    <param name="expressinstall" value="/js/expressInstall.swf">
                    <!-- Next object tag is for non-IE browsers. So hide it from IE using IECC. -->
                    <!--[if !IE]>-->
                    <object type="application/x-shockwave-flash" data="/flash/ottoman-video-2.swf" width="950" height="420">
                        <!--<![endif]-->
                        <param name="quality" value="high">
                        <param name="wmode" value="opaque">
                        <param name="swfversion" value="8.0.35.0">
                        <param name="expressinstall" value="/js/expressInstall.swf">
                        <!-- The browser displays the following alternative content for users with Flash Player 6.0 and older. -->
                        <div>
                        </div>
                        <!--[if !IE]>-->
                    </object>
                    <!--<![endif]-->
                </object>
            </div>
        </div>
    </section>
    <br />
    <section class="gallery2">
        <div class="navig-category-22">
            <div class="gallery-inner">
                <div id="duvar">
                    <h3>DEKORATİF DUVAR VEYA DUVAR KAPLAMA PANELLERİNİZE AMETİST DEKORLAR
                        <br />
                        Amethyst Decor Decorative Wall or Wall cladding panels
                    </h3>
                </div>
                <asp:Literal ID="lt_4item" runat="server"></asp:Literal>

            </div>
        </div>
    </section>

    <section id="about">
        <div class="about">
            Sitemizde bulunan ürünlerimiz doğal ürün olduklarından dünyada tektir. Sadece ona yakın benzeri ürünleri bulunmaktadır. Şekil ve kilo itibariyle birbirlerinden farklılık gösterebilirler. Bu bakımdan beğendiğiniz ürün varsa kaçırmamanızı tavsiye ederiz.
			
        </div>
        <a href="/urunler/amestist-taslar/0" class="button big" title="Submit"><span>Sipariş Ver</span></a>
    </section>

    <div id="container" class="full-width ancient">
        <section class="full">
            <h3>DOĞAL VE SAĞLIKLI AMETİST JEOT TAŞI / Amethyst Geode Natural and Healthy Stone
            </h3>
            <p><span class="about half" style="width: 675px;">Toptan siparişlerinizde çok özel indirimlerden faydalanmak  <span class="blue">Ottoman Stone </span>avantajlarınızı yakalamak için bizimle iletişime geçebilirsiniz ya da sipariş formunu doldurup yollamanız yeterli. En kısa sürede yetkililerimiz sizinle iletişime geçecektir.</span></p>
            <div id="siparisver">
                <a href="/urunler/amestist-taslar/0" class="button big" title="Toptan Siparişleriniz için"><span>Toptan Sipariş Ver</span></a>
            </div>
            <a href="/urunler/amestist-taslar/0">
                <img class="do-ico" alt="Doğal ve Sağlıklı Taş Ametist" src="/images/ametist-2.png" width="960" height="425"></a>
        </section>
        <section class="half">
        </section>
    </div>

    <section id="partners" class="full w-photo">
        <h2>AMETİST JEOT NERELERDE KULLANILIR? / Where to use Amethyst Geode?
        </h2>
        <div class="list-carousel recent">
            <div class="caroufredsel_wrapper" style="float: none; top: auto; right: auto; bottom: auto; left: auto; margin: 0px; overflow: hidden; position: relative; width: 735px; height: 306px;">
                <ul id="foo1" style="float: none; margin: 0px; position: absolute; width: 2940px; height: 306px;">
                    <asp:Literal ID="lt_8item" runat="server"></asp:Literal>
                </ul>
            </div>
            <a id="prev1" class="prev" href="#" style="display: block;"></a><a id="next1" class="next" href="#" style="display: block;"></a>
        </div>
        <%--        <script>
            $(function () {
                $(".photo").click(function () {
                    return hs.expand(this, galleryOptions);
                });
            });
        </script>--%>
    </section>
    <asp:Literal ID="lt_8item2" runat="server"></asp:Literal>
</asp:Content>
