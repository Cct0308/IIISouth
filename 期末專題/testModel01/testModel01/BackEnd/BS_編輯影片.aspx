<%@ Page Title="" Language="C#" MasterPageFile="~/BackEnd/BS_Site.Master" AutoEventWireup="true" CodeBehind="BS_編輯影片.aspx.cs" Inherits="testModel01.BackEnd.WebForm11" %>

<asp:Content ID="Content1" ContentPlaceHolderID="BS_HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BS_BodyContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="標題:" Font-Size="Larger" CssClass="label label-success" Font-Names="微軟正黑體" />
    <asp:TextBox ID="txtSubject" runat="server" Font-Size="Larger" Width="500px"></asp:TextBox>
    <br />
    <br />

    <asp:Label ID="Label2" runat="server" Text="網址:" Font-Size="Larger" CssClass="label label-success" Font-Names="微軟正黑體" />
    <asp:TextBox ID="txtUrl" runat="server" Font-Size="Larger" Width="500px"></asp:TextBox>

    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" class="btn btn-primary" Text="新增" />
    <hr />

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:dbKSYYConnectionString %>' DeleteCommand="DELETE FROM [tUrl] WHERE [fId] = @fId" InsertCommand="INSERT INTO [tUrl] ([fUrl], [fSubject], [f1], [f2], [f3]) VALUES (@fUrl, @fSubject, @f1, @f2, @f3)" SelectCommand="SELECT * FROM [tUrl]" UpdateCommand="UPDATE [tUrl] SET [fUrl] = @fUrl, [fSubject] = @fSubject, [f1] = @f1, [f2] = @f2, [f3] = @f3 WHERE [fId] = @fId">
        <DeleteParameters>
            <asp:Parameter Name="fId" Type="Int32"></asp:Parameter>
        </DeleteParameters>
    </asp:SqlDataSource>

    <div class="row">
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" DataKeyNames="fId">
            <ItemTemplate>
                <div class="col-sm-6 col-md-3">
                    <div class="thumbnail">
                        <img src=' <%# "http://img.youtube.com/vi/" + Eval("fUrl") +"/0.jpg" %> ' 
                            />
                    </div>
                    <div class="caption">
                        <h3><%# Eval("fSubject") %></h3>
                        <p>
                            <asp:HyperLink ID="hyperlink1" runat="server" NavigateUrl='<%# Eval("fId", "/./BackEnd/BS_影片播放.aspx?fId={0}") %>' class="btn btn-primary" role="button" Font-Names="微軟正黑體" data-toggle="modal" data-target="#myModal">觀看</asp:HyperLink>
                            
                            <asp:LinkButton ID="LinkButton1" class="btn btn-default" runat="server" CommandName="Delete" Font-Names="微軟正黑體" OnClientClick="return confirm('確定要刪除?')">刪除</asp:LinkButton>
                        </p>
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>
    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true" data-backdrop="static" data-keyboard="false" >
        <div class="modal-dialog" style="width:50%;">
            <div class="modal-content" >
            </div>
        </div>
    </div>
</asp:Content>
