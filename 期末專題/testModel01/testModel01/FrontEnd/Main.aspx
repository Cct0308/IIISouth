<%@ Page Title="首頁" Language="C#" MasterPageFile="~/FrontEnd/Site.Master"
    AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="testModel01.WebForm1" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <section id="home" runat="server">
        <div id="main-slide" class="carousel slide" data-ride="carousel">
            <%--<ol class="carousel-indicators">
                    <li data-target="#main-slide" data-slide-to="0" class="active"></li>
                    <li data-target="#main-slide" data-slide-to="1"></li>
                    <li data-target="#main-slide" data-slide-to="2"></li>
                </ol>--%>
            <div class='carousel-inner'>
                <asp:Literal ID="ltlCarouselAD" runat="server"></asp:Literal>
            </div>
            <a class="left carousel-control" href="#main-slide" data-slide="prev">
                <span><i class="fa fa-angle-left"></i></span>
            </a>
            <a class="right carousel-control" href="#main-slide" data-slide="next">
                <span><i class="fa fa-angle-right"></i></span>
            </a>
        </div>
    </section>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="formMainNews" runat="server">
        <asp:SqlDataSource ID="SqlDataSourceNews" runat="server" ConnectionString="<%$ ConnectionStrings:dbKSYYConnectionString %>" SelectCommand="SELECT * FROM [tNews] order by fId desc" DataSourceMode="DataReader"></asp:SqlDataSource>

        <div class="latest-posts">
            <h4 class="classic-title"><span>最新消息</span></h4>
            <div class="latest-posts-classic custom-carousel touch-carousel" data-appeared-items="3">
                <asp:Literal ID="ltlLatestNews" runat="server"></asp:Literal>
            </div>
        </div>
    </form>
</asp:Content>
