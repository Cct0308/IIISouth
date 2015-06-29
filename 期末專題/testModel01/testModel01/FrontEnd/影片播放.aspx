<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd/Site.Master" AutoEventWireup="true" CodeBehind="影片播放.aspx.cs" Inherits="testModel01.FrontEnd.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <div class="page-banner" style="padding: 40px 0; background: url(/./images/banner.jpg) center #f9f9f9;">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <h2>影片播放</h2>
                </div>
                <div class="col-md-6">
                    <ul class="breadcrumbs">
                        <li><a href="/./FrontEnd/Main.aspx">首頁</a></li>
                        <li>影片播放</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="formvideo" runat="server">
        <asp:SqlDataSource ID="SqlDataSourceVideo" runat="server" ConnectionString='<%$ ConnectionStrings:dbKSYYConnectionString %>' SelectCommand="SELECT * FROM [tUrl]" DataSourceMode="DataReader"></asp:SqlDataSource>
        <div class="project">
            <div class="container">
                <div class="recent-projects">
                    <h4 class="title"><span>影片播放</span></h4>
                    <div class="projects-carousel touch-carousel">
                        <asp:Literal ID="ltlVideo" runat="server"></asp:Literal>
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
