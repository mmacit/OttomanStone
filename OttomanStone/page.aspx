<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/ottoman.Master" AutoEventWireup="true" CodeBehind="page.aspx.cs" Inherits="OttomanStone.page" %>

<%@ Register Src="~/Controls/Contents/Contents.ascx" TagPrefix="uc1" TagName="Contents" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <script type="text/javascript" src="/js/photo-stack.js"></script>
    <div class="navig-nivo ps">
        <a class="prev"></a>
        <a class="next"></a>
    </div>
    <section id="slide">
        <div id="ps-slider" class="ps-slider">
            <div id="ps-albums">
                <asp:Literal ID="lt_ametist" runat="server"></asp:Literal>
            </div>
        </div>

    </section>
    <div class="entry">
    <uc1:Contents runat="server" ID="Contents" /></div>
</asp:Content>
