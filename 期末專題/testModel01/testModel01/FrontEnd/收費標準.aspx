<%@ Page Title="收費標準" Language="C#" MasterPageFile="~/FrontEnd/Site.Master" AutoEventWireup="true" CodeBehind="收費標準.aspx.cs" Inherits="testModel01.WebForm4" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <div class="page-banner" style="padding:40px 0; background: url(/./images/banner.jpg) center #f9f9f9;">
      <div class="container">
        <div class="row">
          <div class="col-md-6">
            <h2>收費標準</h2>
            <p>如需詳細資訊請聯絡我們</p>
          </div>
          <div class="col-md-6">
            <ul class="breadcrumbs">
              <li><a href="/./FrontEnd/Main.aspx">首頁</a></li>
              <li>收費標準</li>
            </ul>
          </div>
        </div>
      </div>
    </div>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <form id="form1" runat="server">

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:dbKSYYConnectionString %>' SelectCommand="SELECT * FROM [Fees_table_1]">
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString='<%$ ConnectionStrings:dbKSYYConnectionString %>' SelectCommand="SELECT * FROM [note]"></asp:SqlDataSource>



         <div class="hr1 margin-60"></div>
        <h4 class="classic-title" id="收費標準表"><span>收費標準表</span></h4>
        <table style="background-color: #ff9933; width: 100%;">
            <tbody>
                <tr>
                    <td style="background-color: #ffffff;" colspan="4">
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover" DataKeyNames="room" DataSourceID="SqlDataSource1" Width="100%">
                            <Columns>
                                <asp:BoundField DataField="room" HeaderText="住  房" ReadOnly="True" SortExpression="room">
                                    <HeaderStyle CssClass="info text-center" />
                                    <ItemStyle CssClass="text-center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="price" HeaderText="基本月費（含住房費、水電費、洗衣費、一般伙食費）" SortExpression="price">
                                    <HeaderStyle CssClass="info text-center" />
                                    <ItemStyle CssClass="text-center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="care" HeaderText="特殊照護費" SortExpression="care">
                                    <HeaderStyle CssClass="info text-center" />
                                    <ItemStyle CssClass="text-center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="careprice" HeaderText="費用" SortExpression="careprice">
                                    <HeaderStyle CssClass="info text-center" />
                                    <ItemStyle CssClass="text-center" />
                                </asp:BoundField>
                            </Columns>
                        </asp:GridView>
                        <asp:GridView ID="GridView3" runat="server" CssClass="table table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2" Width="100%">
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" Visible="False" />
                                <asp:BoundField DataField="content" HeaderText="備註" HtmlEncode="False" SortExpression="content">
                                    <HeaderStyle CssClass="info text-center" />
                                </asp:BoundField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </tbody>
        </table>


        <div class="hr1 margin-60"></div>
        <h4 class="classic-title" id="入住注意事項"><span>入住注意事項</span></h4>
        <div>
            <asp:SqlDataSource ID="sqlAttention" runat="server" ConnectionString="<%$ ConnectionStrings:dbKSYYConnectionString %>" SelectCommand="SELECT * FROM [tAttention]"></asp:SqlDataSource>
            <asp:GridView ID="gvAttention" runat="server" AutoGenerateColumns="False" DataSourceID="sqlAttention" CssClass="table " ShowHeader="False" DataKeyNames="fId" GridLines="None">
                <Columns>
                    <asp:BoundField DataField="fNo" HeaderText="fNo" SortExpression="fNo" />
                    <asp:BoundField DataField="fContent" HeaderText="fContent" SortExpression="fContent" HtmlEncode="False" />
                </Columns>
            </asp:GridView>
        </div>
        <h4><span>入住必備日用品清單</span></h4>
        <div style="background-color: #FFFFCC">
            <asp:SqlDataSource ID="sqlCommodity" runat="server" ConnectionString="<%$ ConnectionStrings:dbKSYYConnectionString %>" SelectCommand="SELECT * FROM [tCommodity]"></asp:SqlDataSource>
            <asp:GridView ID="gvCommdoity" runat="server" AutoGenerateColumns="False" DataSourceID="sqlCommodity" CssClass="table " ShowHeader="False" DataKeyNames="fId" GridLines="None">
                <Columns>
                    <asp:BoundField DataField="fNo" HeaderText="fNo" SortExpression="fNo" />
                    <asp:BoundField DataField="fContent" HeaderText="fContent" SortExpression="fContent" HtmlEncode="False" />
                </Columns>
            </asp:GridView>
            <p class="attention-item4">以上用品依長輩之個別需要準備，請您於入住時即備妥並<span class="attention-item5"><strong>"寫上姓名"</strong></span>或由本機構代購，以方面作業！</p>
        </div>



        <div class="hr1 margin-60"></div>
        <h4 class="classic-title" id="日常照護收費評估表"><span>日常照護收費評估表</span></h4>
        <div>            
            <a href="/./AssessFile/assess.doc">
                <img title="下載住民日常照護收費評估表.doc" src="/./AssessFile/word.png" width="80" />
                <span>康欣老人長期照顧中心 日常照護收費評估表</span>
            </a>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString='<%$ ConnectionStrings:dbKSYYConnectionString %>' SelectCommand="SELECT * FROM [t收費評估表]"></asp:SqlDataSource>
                    <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-hover table-striped" ShowHeader="False" Width="100%" AutoGenerateColumns="False" DataKeyNames="f1" DataSourceID="SqlDataSource3">
                        <Columns>
                            <asp:BoundField DataField="f1" HeaderText="f1" ReadOnly="True" InsertVisible="False" SortExpression="f1" Visible="False"></asp:BoundField>
                            <asp:BoundField DataField="f2" HeaderText="f2" SortExpression="f2"></asp:BoundField>
                            <asp:BoundField DataField="f3" HeaderText="f3" SortExpression="f3"></asp:BoundField>
                            <asp:BoundField DataField="f4" HeaderText="f4" SortExpression="f4"></asp:BoundField>
                            <asp:BoundField DataField="f5" HeaderText="f5" SortExpression="f5"></asp:BoundField>
                        </Columns>
                    </asp:GridView>
                    <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Interval="5000"></asp:Timer>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

    </form>
</asp:Content>
