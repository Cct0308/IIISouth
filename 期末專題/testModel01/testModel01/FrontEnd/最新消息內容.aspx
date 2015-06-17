<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd/Site.Master" AutoEventWireup="true" CodeBehind="最新消息內容.aspx.cs" Inherits="testModel01.WebForm14" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <div class="page-banner" style="padding: 40px 0; background: url(../../images/banner.jpg) center #f9f9f9;">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <h2>消息內容</h2>
                </div>
                <div class="col-md-6">
                    <ul class="breadcrumbs">
                        <li><a href="Main.aspx">首頁</a></li>
                        <li>消息內容</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="formNewsContent" runat="server">

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [tNews] WHERE ([fId] = @fId)">
            <SelectParameters>
                <asp:QueryStringParameter Name="fId" QueryStringField="fid" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>



        <div class="hr1 margin-60"></div>
        <h4 class="classic-title" id="消息內容"><span>消息內容</span></h4>
        <div>
            <asp:DataList ID="DataList1" runat="server" DataKeyField="fId" DataSourceID="SqlDataSource2" Width="100%">
                <ItemTemplate>
                    <table class="table table-bordered table-condensed" style="width: 100%">
                        <tr>
                            <td class="info text-center h4">
                                <asp:Label ID="Label3" runat="server" Text="標題" Font-Bold="True" Font-Size="Large"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="text-center">
                                <asp:Label ID="fSubjectLabel" runat="server" Text='<%# Eval("fSubject") %>' Font-Size="Medium" />
                            </td>
                        </tr>
                        <tr>
                            <td class="info text-center h4">
                                <asp:Label ID="Label4" runat="server" Text="內文" Font-Bold="True" Font-Size="Large"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div class="container">
                                    <asp:Label ID="fContentLabel" runat="server" Text='<%# Eval("fContent") %>' Font-Size="Medium" />
                                    <asp:Label ID="fDateLabel" runat="server" Text='<%# Eval("fDate") %>' CssClass=" pull-right text-muted" Font-Size="Small" />
                                </div>
                            </td>
                        </tr>
                    </table>
                    <asp:Label ID="fIdLabel" runat="server" Text='<%# Eval("fId") %>' Visible="False" />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</asp:Content>
