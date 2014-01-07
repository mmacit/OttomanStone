<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Contents.ascx.cs" Inherits="NewsPortal.Controls.Contents.Contents" %>
<script type="text/javascript">var switchTo5x = true;</script>
<script type="text/javascript" src="http://w.sharethis.com/button/buttons.js"></script>
<script type="text/javascript">stLight.options({ publisher: "847ad59b-ec44-4cf4-a840-47c0f4d41c01", doNotHash: false, doNotCopy: false, hashAddressBar: false });</script>

<div class="myriadroman-12-beyaz" id="icerik1" runat="server" clientidmode="static" style="line-height: 130%;">
    <asp:Literal ID="li_content" runat="server"></asp:Literal>
</div>
<br />
<asp:Panel ID="pnl_form" runat="server"></asp:Panel>
<div class="dv_social" style="width:100%;display:none;">
    <div class="fr" style="margin-left: 8px; padding-left: 5px; border-left: 1px solid #00AEEF; height: 32px;">
        <a href="#" id="a_pdf" runat="server">
            <img src="/images/pdf.png" style="padding-left: 5px;display:none;" /></a>&nbsp;&nbsp;<a href="" class="print_icerik">
                <img src="/images/print.png" />
            </a>
    </div>
    <div class="fr">
        <span class='st_facebook_large' displaytext='Facebook'></span>
        <span class='st_twitter_large' displaytext='Tweet'></span>
        <span class='st_googleplus_large' displaytext='Google +'></span>
    </div>
</div>
