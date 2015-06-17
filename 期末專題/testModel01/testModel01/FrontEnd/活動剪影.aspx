<%@ Page Title="康欣剪影" Language="C#" MasterPageFile="~/FrontEnd/Site.Master" AutoEventWireup="true" CodeBehind="活動剪影.aspx.cs" Inherits="testModel01.WebForm6" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <div class="page-banner" style="padding:40px 0; background: url(../../images/banner.jpg) center #f9f9f9;">
      <div class="container">
        <div class="row">
          <div class="col-md-6">
            <h2>康欣剪影</h2>
          </div>
          <div class="col-md-6">
            <ul class="breadcrumbs">
              <li><a href="Main.aspx">首頁</a></li>
              <li>康欣剪影</li>
            </ul>
          </div>
        </div>
      </div>
    </div>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="formpicts" runat="server">
        <div class="row_6">
            <div class="containerpics">
                <div class="hr1 margin-60"></div>
                <h4 class="classic-title" id="康欣剪影"><span>康欣剪影</span></h4>
                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12">
                        <div id="options" class="clearfix">
                            <p id="filters" class="pagination option-set clearfix" data-option-key="filter">
                                <a href="#filter" class="btn-system btn-mini border-btn selected" data-option-value="*">顯示全部</a>
                                <a href="#filter" class="btn-system btn-mini border-btn" data-option-value=".outlook">庭院</a>
                                <a href="#filter" class="btn-system btn-mini border-btn" data-option-value=".inside">內部</a>
                                <a href="#filter" class="btn-system btn-mini border-btn" data-option-value=".birthday">慶生</a>
                                <a href="#filter" class="btn-system btn-mini border-btn" data-option-value=".washfoot">泡腳</a>
                                <a href="#filter" class="btn-system btn-mini border-btn" data-option-value=".rehab">復健</a>
                                <a href="#filter" class="btn-system btn-mini border-btn" data-option-value=".cuthair">義剪</a>
                                <a href="#filter" class="btn-system btn-mini border-btn" data-option-value=".other">其他</a>
                            </p>
                        </div>
                        <div class="containerExtra">
                            <div id="containerpics" class="clearfix">
                                <asp:Literal ID="ltlLatestPicts" runat="server"></asp:Literal>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
