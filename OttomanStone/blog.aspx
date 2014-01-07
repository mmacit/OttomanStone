<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/ottoman.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="OttomanStone.blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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

        .entry #container {
            float: left;
            width: 960px !important;
        }

        .navigation.blog {
            margin: 20px 0 0 0;
            width: 950px;
        }
    </style>
    <div class="entry">
        <div id="container">
            <div class="double-header">
                <span class="first-head">Blog</span>
                <!--<span class="second-head">Check out latest news and events</span>-->
            </div>
            <asp:Literal ID="lt_bloglist" runat="server"></asp:Literal>

            <div id="paging" runat="server">
                <div id="nav-above" class="navigation blog">
                    <ul class="paginator">
                        <li class="larr"><a href="<%= ilk_sayfa %>" class="button" title=""><span>İlk Sayfa</span></a></li>
                        <asp:Literal ID="lt_pages" runat="server"></asp:Literal>
                        <li class="rarr"><a href="<%= son_sayfa %>" class="button" title=""><span>Son Sayfa</span></a></li>
                    </ul>
                    <div class="paginator-r">
                        <span class="pagin-info">Sayfa <%= simdiki_sayfa %> / <%= total_sayfa %></span>
                        <a class="prev" href="<%= onceki_sayfa %>"></a>
                        <a class="next" href="<%= sonraki_sayfa %>"></a>
                    </div>
                </div>
            </div>
        </div>
        <!-- #container-->
    </div>
</asp:Content>
