<%@ Page Title="關於康欣" Language="C#" MasterPageFile="~/FrontEnd/Site.Master" AutoEventWireup="true" CodeBehind="關於康欣.aspx.cs" Inherits="testModel01.WebForm3" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <div class="page-banner" style="padding:40px 0; background: url(/./images/banner.jpg) center #f9f9f9;">
      <div class="container">
        <div class="row">
          <div class="col-md-6">
            <h2>關於康欣</h2>
          </div>
          <div class="col-md-6">
            <ul class="breadcrumbs">
              <li><a href="/./FrontEnd/Main.aspx">首頁</a></li>
              <li>關於康欣</li>
            </ul>
          </div>
        </div>
      </div>
    </div>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="form1" runat="server">
        <div class="hr1 margin-60"></div>
        <h4 class="classic-title"><span>關於康欣</span></h4>
        <table border="0" style="text-align: left; width: 98%; color: rgb(51, 51, 51); font-family: 新細明體, Verdana, Arial, Helvetica, sans-serif; font-size: 13px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: 1px; line-height: normal; orphans: initial; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255);">
            <tr style="padding: 0px; margin: 0px;">
                <td style="padding: 0px; margin: 0px; width: 100%">
                    <div id="text" style="font-size: 10.5pt; font-family: 微軟正黑體, 新細明體, Verdana, Arial, Helvetica, sans-serif; line-height: 1.5; color: rgb(49, 49, 49); word-spacing: 1px; margin: 0px; padding: 0px; text-align: left;">
                        <p class="auto-style4">
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:dbKSYYConnectionString %>' SelectCommand="SELECT * FROM [about]">
                            </asp:SqlDataSource>
                        </p>
                        <p class="auto-style4">
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover" DataKeyNames="Id" DataSourceID="SqlDataSource1" Width="100%">
                                <Columns>
                                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" Visible="False" />
                                    <asp:BoundField DataField="article" HeaderText="關於我們" HtmlEncode="False" SortExpression="article">
                                        <HeaderStyle CssClass="info" Font-Size="Medium" />
                                        <ItemStyle CssClass="text" Font-Size="Medium" />
                                    </asp:BoundField>
                                </Columns>
                            </asp:GridView>
                        </p>
                    </div>
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
