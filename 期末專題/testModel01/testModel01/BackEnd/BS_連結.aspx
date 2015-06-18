<%@ Page Title="" Language="C#" MasterPageFile="~/BackEnd/BS_Site.Master" AutoEventWireup="true" CodeBehind="BS_連結.aspx.cs" Inherits="testModel01.BackEnd.WebForm10" %>

<asp:Content ID="Content1" ContentPlaceHolderID="BS_HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BS_BodyContent" runat="server">
    <link href="../Content/jasny-bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jasny-bootstrap.min.js"></script>
    <div class="container">
        <table class="nav-justified">
            <tr>
                <td>
                    <h2 style="color: #000000; font-family: 微軟正黑體;">修改連結1圖片</h2>
                    <div class="fileinput fileinput-new input-group" data-provides="fileinput">
                        <div class="form-control" data-trigger="fileinput">
                            <i class="glyphicon glyphicon-file fileinput-exists"></i>
                            <span class="fileinput-filename"></span>
                        </div>
                        <span class="input-group-addon btn btn-default btn-file">
                            <span class="fileinput-new">Select file</span>
                            <span class="fileinput-exists">Change</span>
                            <asp:FileUpload ID="FileUpload1" runat="server" Width="100%" />
                        </span>
                        <a href="#" class="input-group-addon btn btn-default fileinput-exists" data-dismiss="fileinput">Remove</a>
                    </div>
                    <asp:Button ID="btn第一張圖" runat="server" Text="確定上傳" CssClass="btn btn-primary" OnClick="btn第一張圖_Click" Font-Names="微軟正黑體" />
                    <asp:Label ID="lbl1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td>
                    <h2 style="color: #000000; font-family: 微軟正黑體;">修改連結2圖片</h2>
                    <div class="fileinput fileinput-new input-group" data-provides="fileinput">
                        <div class="form-control" data-trigger="fileinput">
                            <i class="glyphicon glyphicon-file fileinput-exists"></i>
                            <span class="fileinput-filename"></span>
                        </div>
                        <span class="input-group-addon btn btn-default btn-file">
                            <span class="fileinput-new">Select file</span>
                            <span class="fileinput-exists">Change</span>
                            <asp:FileUpload ID="FileUpload2" runat="server" Width="100%" />
                        </span>
                        <a href="#" class="input-group-addon btn btn-default fileinput-exists" data-dismiss="fileinput">Remove</a>
                    </div>
                    <asp:Button ID="btn第二張圖" runat="server" Text="確定上傳" CssClass="btn btn-primary" OnClick="btn第二張圖_Click" Font-Names="微軟正黑體" />
                    <asp:Label ID="lbl2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <h2 style="color: #000000; font-family: 微軟正黑體;">修改連結3圖片</h2>
                    <div class="fileinput fileinput-new input-group" data-provides="fileinput">
                        <div class="form-control" data-trigger="fileinput">
                            <i class="glyphicon glyphicon-file fileinput-exists"></i>
                            <span class="fileinput-filename"></span>
                        </div>
                        <span class="input-group-addon btn btn-default btn-file">
                            <span class="fileinput-new">Select file</span>
                            <span class="fileinput-exists">Change</span>
                            <asp:FileUpload ID="FileUpload3" runat="server" Width="100%" />
                        </span>
                        <a href="#" class="input-group-addon btn btn-default fileinput-exists" data-dismiss="fileinput">Remove</a>
                    </div>
                    <asp:Button ID="btn第三張圖" runat="server" Text="確定上傳" CssClass="btn btn-primary" OnClick="btn第三張圖_Click" Font-Names="微軟正黑體" />
                    <asp:Label ID="lbl3" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <h2 style="color: #000000; font-family: 微軟正黑體;">修改連結4圖片</h2>
                    <div class="fileinput fileinput-new input-group" data-provides="fileinput">
                        <div class="form-control" data-trigger="fileinput">
                            <i class="glyphicon glyphicon-file fileinput-exists"></i>
                            <span class="fileinput-filename"></span>
                        </div>
                        <span class="input-group-addon btn btn-default btn-file">
                            <span class="fileinput-new">Select file</span>
                            <span class="fileinput-exists">Change</span>
                            <asp:FileUpload ID="FileUpload4" runat="server" Width="100%" />
                        </span>
                        <a href="#" class="input-group-addon btn btn-default fileinput-exists" data-dismiss="fileinput">Remove</a>
                    </div>
                    <asp:Button ID="btn第四張圖" runat="server" Text="確定上傳" CssClass="btn btn-primary" OnClick="btn第四張圖_Click" Font-Names="微軟正黑體" />
                    <asp:Label ID="lbl4" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <h2 style="color: #000000; font-family: 微軟正黑體;">修改連結5圖片</h2>
                    <div class="fileinput fileinput-new input-group" data-provides="fileinput">
                        <div class="form-control" data-trigger="fileinput">
                            <i class="glyphicon glyphicon-file fileinput-exists"></i><span class="fileinput-filename"></span>
                        </div>
                        <span class="input-group-addon btn btn-default btn-file"><span class="fileinput-new">Select file</span> <span class="fileinput-exists">Change</span>
                            <asp:FileUpload ID="FileUpload5" runat="server" Width="100%" />
                        </span><a class="input-group-addon btn btn-default fileinput-exists" data-dismiss="fileinput" href="#">Remove</a>
                    </div>
                    <asp:Button ID="btn第五張圖" runat="server" CssClass="btn btn-primary" Text="確定上傳" OnClick="btn第五張圖_Click" Font-Names="微軟正黑體" />
                    <asp:Label ID="lbl5" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <h2 style="color: #000000; font-family: 微軟正黑體;">修改連結6圖片</h2>
                    <div class="fileinput fileinput-new input-group" data-provides="fileinput">
                        <div class="form-control" data-trigger="fileinput">
                            <i class="glyphicon glyphicon-file fileinput-exists"></i><span class="fileinput-filename"></span>
                        </div>
                        <span class="input-group-addon btn btn-default btn-file"><span class="fileinput-new">Select file</span> <span class="fileinput-exists">Change</span>
                            <asp:FileUpload ID="FileUpload6" runat="server" Width="100%" />
                        </span><a class="input-group-addon btn btn-default fileinput-exists" data-dismiss="fileinput" href="#">Remove</a>
                    </div>
                    <asp:Button ID="btn第六張圖" runat="server" CssClass="btn btn-primary" Text="確定上傳" OnClick="btn第六張圖_Click" Font-Names="微軟正黑體" />
                    <asp:Label ID="lbl6" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <h2 style="color: #000000; font-family: 微軟正黑體;">修改連結7圖片</h2>
                    <div class="fileinput fileinput-new input-group" data-provides="fileinput">
                        <div class="form-control" data-trigger="fileinput">
                            <i class="glyphicon glyphicon-file fileinput-exists"></i><span class="fileinput-filename"></span>
                        </div>
                        <span class="input-group-addon btn btn-default btn-file"><span class="fileinput-new">Select file</span> <span class="fileinput-exists">Change</span>
                            <asp:FileUpload ID="FileUpload7" runat="server" Width="100%" />
                        </span><a class="input-group-addon btn btn-default fileinput-exists" data-dismiss="fileinput" href="#">Remove</a>
                    </div>
                    <asp:Button ID="btn第七張圖" runat="server" CssClass="btn btn-primary" Text="確定上傳" OnClick="btn第七張圖_Click" Font-Names="微軟正黑體" />
                    <asp:Label ID="lbl7" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <h2 style="color: #000000; font-family: 微軟正黑體;">修改連結8圖片</h2>
                    <div class="fileinput fileinput-new input-group" data-provides="fileinput">
                        <div class="form-control" data-trigger="fileinput">
                            <i class="glyphicon glyphicon-file fileinput-exists"></i><span class="fileinput-filename"></span>
                        </div>
                        <span class="input-group-addon btn btn-default btn-file"><span class="fileinput-new">Select file</span> <span class="fileinput-exists">Change</span>
                            <asp:FileUpload ID="FileUpload8" runat="server" Width="100%" />
                        </span><a class="input-group-addon btn btn-default fileinput-exists" data-dismiss="fileinput" href="#">Remove</a>
                    </div>
                    <asp:Button ID="btn第八張圖" runat="server" CssClass="btn btn-primary" Text="確定上傳" OnClick="btn第八張圖_Click" Font-Names="微軟正黑體" />
                    <asp:Label ID="lbl8" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>





        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover" DataKeyNames="fId" DataSourceID="SqlDataSource1" Font-Names="微軟正黑體" Font-Size="Medium" Width="100%">
                <columns>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" OnClientClick="return confirm('確定要更新嗎?')" Text="更新"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" OnClientClick="return confirm('確定要取消嗎?')" Text="取消"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="編輯"></asp:LinkButton>
                    </ItemTemplate>
                    <ControlStyle Width="50px" />
                </asp:TemplateField>
                <asp:BoundField DataField="fId" HeaderText="fId" InsertVisible="False" ReadOnly="True" SortExpression="fId" Visible="False" />
                    <asp:TemplateField HeaderText="網站名稱" SortExpression="fName">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("fName") %>' Width="100%"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("fName") %>'></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle CssClass="info text-center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="網址" SortExpression="fConnection">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("fConnection") %>' Width="100%"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("fConnection") %>'></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle CssClass="info text-center" />
                    </asp:TemplateField>
            </columns>
            </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbKSYYConnectionString %>" DeleteCommand="DELETE FROM [t連結] WHERE [fId] = @fId" InsertCommand="INSERT INTO [t連結] ([fName], [fConnection]) VALUES (@fName, @fConnection)" SelectCommand="SELECT [fId], [fName], [fConnection] FROM [t連結]" UpdateCommand="UPDATE [t連結] SET [fName] = @fName, [fConnection] = @fConnection WHERE [fId] = @fId">
                <deleteparameters>
                <asp:Parameter Name="fId" Type="Int32" />
            </deleteparameters>
                <insertparameters>
                <asp:Parameter Name="fName" Type="String" />
                <asp:Parameter Name="fConnection" Type="String" />
            </insertparameters>
                <updateparameters>
                <asp:Parameter Name="fName" Type="String" />
                <asp:Parameter Name="fConnection" Type="String" />
                <asp:Parameter Name="fId" Type="Int32" />
            </updateparameters>
            </asp:SqlDataSource>
        




    </div>
</asp:Content>
