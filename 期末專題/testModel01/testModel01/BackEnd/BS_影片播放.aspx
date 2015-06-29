<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BS_影片播放.aspx.cs" Inherits="testModel01.BackEnd.BS_影片播放" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

</head>
<body>
    <form id="form689" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:dbKSYYConnectionString %>' SelectCommand="SELECT * FROM [tUrl] WHERE ([fId] = @fId)">
            <SelectParameters>
                <asp:QueryStringParameter QueryStringField="fId" Name="fId" Type="Int32"></asp:QueryStringParameter>
            </SelectParameters>
        </asp:SqlDataSource>

        <div>
            <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" >
                <ItemTemplate>

                    <div class="modal-header">
                        <%--<button id="btnClose" runat="server" type="button" class="close" aria-label="Close" onclick="btnClose_Click" >
                            <span aria-hidden="true">&times;</span>                                       
                        </button>--%>
                        <asp:Button ID="btn" runat="server" type="button" class="close"  aria-label="Close" OnClientClick="" aria-hidden="true" Text="&times;" OnClick="btnClose_Click"/>

                        <h4 class="modal-title" id="myModalLabel" >影片欣賞</h4>
                    </div>
                    <div class="modal-body">
                        
                        <iframe style="width: 100%;height:500px; align-items: center; "  src='<%# "https://www.youtube.com/embed/" + Eval("fUrl") %>' frameborder="0" allowfullscreen></iframe>                        
                    </div>

                </ItemTemplate>
            </asp:ListView>
        </div>
    </form>
</body>
</html>
<%--<iframe width="560" height="315" src="https://www.youtube.com/embed/PQjovLrnvVo" frameborder="0" allowfullscreen></iframe>--%>


<%--<button id="btnClose" runat="server" type="button" class="close" aria-label="Close" onclick="window.close();window.open('/./BackEnd/BS_編輯影片.aspx')" >
                            <span aria-hidden="true">&times;</span>                                       
                        </button>--%>