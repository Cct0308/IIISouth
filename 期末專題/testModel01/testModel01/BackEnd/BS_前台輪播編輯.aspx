<%@ Page Title="" Language="C#" MasterPageFile="~/BackEnd/BS_Site.Master" AutoEventWireup="true" CodeBehind="BS_前台輪播編輯.aspx.cs" Inherits="testModel01.BackEnd.WebForm9" %>

<asp:Content ID="Content1" ContentPlaceHolderID="BS_HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BS_BodyContent" runat="server">
    <link href="../Content/jasny-bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jasny-bootstrap.min.js"></script>

    

    <div class="container">
        <h2 style="color: #FF6600">第一張圖修改</h2>

        <div class="fileinput fileinput-new input-group" data-provides="fileinput" style="width: 50%">
            <div class="form-control" data-trigger="fileinput">
                <i class="glyphicon glyphicon-file fileinput-exists"></i>
                <span class="fileinput-filename"></span>
            </div>
            <span class="input-group-addon btn btn-default btn-file">
                <span class="fileinput-new">Select file</span>
                <span class="fileinput-exists">Change</span>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </span>
            <a href="#" class="input-group-addon btn btn-default fileinput-exists" data-dismiss="fileinput">Remove</a>
        </div>
        <asp:Button ID="btn第一張圖" runat="server" Text="確定上傳" OnClick="btn第一張圖_Click" CssClass="btn btn-primary" />

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:dbKSYYConnectionString %>' SelectCommand="SELECT * FROM [t前台輪播] WHERE ([fId] = @fId)" UpdateCommand="UPDATE [t前台輪播] SET [fFirst] = @fFirst, [fSecond] = @fSecond, [fThird] = @fThird WHERE [fId] = @fId">
            <SelectParameters>
                <asp:Parameter DefaultValue="1" Name="fId" Type="Int32"></asp:Parameter>
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="fPic" Type="String"></asp:Parameter>
                <asp:Parameter Name="fFirst" Type="String"></asp:Parameter>
                <asp:Parameter Name="fSecond" Type="String"></asp:Parameter>
                <asp:Parameter Name="fThird" Type="String"></asp:Parameter>
                <asp:Parameter Name="fId" Type="Int32"></asp:Parameter>
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover" DataSourceID="SqlDataSource1" Font-Names="微軟正黑體" Width="100%" DataKeyNames="fId">
            <Columns>
                <asp:BoundField DataField="fId" HeaderText="fId" SortExpression="fId" InsertVisible="False" ReadOnly="True" Visible="false"></asp:BoundField>
                <asp:BoundField DataField="fPic" HeaderText="fPic" SortExpression="fPic" Visible="false"></asp:BoundField>


                <asp:BoundField DataField="fFirst" HeaderText="抬頭" SortExpression="fFirst">
                    <HeaderStyle CssClass="info text-center" Font-Bold="True" Font-Size="Large" />
                    <ItemStyle CssClass="text-left" Font-Size="Medium" />
                </asp:BoundField>
                <asp:BoundField DataField="fSecond" HeaderText="標題" SortExpression="fSecond">
                    <HeaderStyle CssClass="info text-center" Font-Bold="True" Font-Size="Large" />
                    <ItemStyle CssClass="text-left" Font-Size="Medium" />
                </asp:BoundField>
                <asp:BoundField DataField="fThird" HeaderText="副標題" SortExpression="fThird">
                    <HeaderStyle CssClass="info text-center" Font-Bold="True" Font-Size="Large" />
                    <ItemStyle CssClass="text-left" Font-Size="Medium" />
                </asp:BoundField>

                <asp:TemplateField ShowHeader="False" >
                    <HeaderStyle CssClass="info text-center" Font-Bold="True" Font-Size="Large" />
                    <ItemStyle CssClass="text-left" Font-Size="Medium" />
                    <EditItemTemplate>
                        <asp:LinkButton runat="server" Text="確定" CommandName="Update" CausesValidation="True" ID="LinkButton1" ></asp:LinkButton>&nbsp;<asp:LinkButton runat="server" Text="取消" CommandName="Cancel" CausesValidation="False" ID="LinkButton2"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton runat="server" Text="編輯" CommandName="Edit" CausesValidation="False" ID="LinkButton1"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
        <%--  --%>

        <h2 style="color: #FF6600">第二張圖修改</h2>

        <div class="fileinput fileinput-new input-group" data-provides="fileinput" style="width: 50%">
            <div class="form-control" data-trigger="fileinput">
                <i class="glyphicon glyphicon-file fileinput-exists"></i>
                <span class="fileinput-filename"></span>
            </div>
            <span class="input-group-addon btn btn-default btn-file">
                <span class="fileinput-new">Select file</span>
                <span class="fileinput-exists">Change</span>
                <asp:FileUpload ID="FileUpload2" runat="server" />
            </span>
            <a href="#" class="input-group-addon btn btn-default fileinput-exists" data-dismiss="fileinput">Remove</a>
        </div>
        <asp:Button ID="btn第二張圖" runat="server" Text="確定上傳" OnClick="btn第二張圖_Click" CssClass="btn btn-primary" />

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString='<%$ ConnectionStrings:dbKSYYConnectionString %>' SelectCommand="SELECT * FROM [t前台輪播] WHERE ([fId] = @fId)" UpdateCommand="UPDATE [t前台輪播] SET [fFirst] = @fFirst, [fSecond] = @fSecond, [fThird] = @fThird WHERE [fId] = @fId">
            <SelectParameters>
                <asp:Parameter DefaultValue="2" Name="fId" Type="Int32"></asp:Parameter>
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="fPic" Type="String"></asp:Parameter>
                <asp:Parameter Name="fFirst" Type="String"></asp:Parameter>
                <asp:Parameter Name="fSecond" Type="String"></asp:Parameter>
                <asp:Parameter Name="fThird" Type="String"></asp:Parameter>
                <asp:Parameter Name="fId" Type="Int32"></asp:Parameter>
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover" DataSourceID="SqlDataSource2" Font-Names="微軟正黑體" Width="100%" DataKeyNames="fId">
            <Columns>
                <asp:BoundField DataField="fId" HeaderText="fId" SortExpression="fId" InsertVisible="False" ReadOnly="True" Visible="false"></asp:BoundField>
                <asp:BoundField DataField="fPic" HeaderText="fPic" SortExpression="fPic" Visible="false"></asp:BoundField>


                <asp:BoundField DataField="fFirst" HeaderText="抬頭" SortExpression="fFirst">
                    <HeaderStyle CssClass="info text-center" Font-Bold="True" Font-Size="Large" />
                    <ItemStyle CssClass="text-left" Font-Size="Medium" />
                </asp:BoundField>
                <asp:BoundField DataField="fSecond" HeaderText="標題" SortExpression="fSecond">
                    <HeaderStyle CssClass="info text-center" Font-Bold="True" Font-Size="Large" />
                    <ItemStyle CssClass="text-left" Font-Size="Medium" />
                </asp:BoundField>
                <asp:BoundField DataField="fThird" HeaderText="副標題" SortExpression="fThird">
                    <HeaderStyle CssClass="info text-center" Font-Bold="True" Font-Size="Large" />
                    <ItemStyle CssClass="text-left" Font-Size="Medium" />
                </asp:BoundField>

                <asp:TemplateField ShowHeader="False" >
                    <HeaderStyle CssClass="info text-center" Font-Bold="True" Font-Size="Large" />
                    <ItemStyle CssClass="text-left" Font-Size="Medium" />
                    <EditItemTemplate>
                        <asp:LinkButton runat="server" Text="確定" CommandName="Update" CausesValidation="True" ID="LinkButton1" ></asp:LinkButton>&nbsp;<asp:LinkButton runat="server" Text="取消" CommandName="Cancel" CausesValidation="False" ID="LinkButton2"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton runat="server" Text="編輯" CommandName="Edit" CausesValidation="False" ID="LinkButton1"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>

        <%--  --%>

        <h2 style="color: #FF6600">第三張圖修改</h2>

        <div class="fileinput fileinput-new input-group" data-provides="fileinput" style="width: 50%">
            <div class="form-control" data-trigger="fileinput">
                <i class="glyphicon glyphicon-file fileinput-exists"></i>
                <span class="fileinput-filename"></span>
            </div>
            <span class="input-group-addon btn btn-default btn-file">
                <span class="fileinput-new">Select file</span>
                <span class="fileinput-exists">Change</span>
                <asp:FileUpload ID="FileUpload3" runat="server" />
            </span>
            <a href="#" class="input-group-addon btn btn-default fileinput-exists" data-dismiss="fileinput">Remove</a>
        </div>
        <asp:Button ID="btn第三張圖" runat="server" Text="確定上傳" OnClick="btn第三張圖_Click" CssClass="btn btn-primary" />

        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString='<%$ ConnectionStrings:dbKSYYConnectionString %>' SelectCommand="SELECT * FROM [t前台輪播] WHERE ([fId] = @fId)" UpdateCommand="UPDATE [t前台輪播] SET [fFirst] = @fFirst, [fSecond] = @fSecond, [fThird] = @fThird WHERE [fId] = @fId">
            <SelectParameters>
                <asp:Parameter DefaultValue="3" Name="fId" Type="Int32"></asp:Parameter>
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="fPic" Type="String"></asp:Parameter>
                <asp:Parameter Name="fFirst" Type="String"></asp:Parameter>
                <asp:Parameter Name="fSecond" Type="String"></asp:Parameter>
                <asp:Parameter Name="fThird" Type="String"></asp:Parameter>
                <asp:Parameter Name="fId" Type="Int32"></asp:Parameter>
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover" DataSourceID="SqlDataSource3" Font-Names="微軟正黑體" Width="100%" DataKeyNames="fId">
            <Columns>
                <asp:BoundField DataField="fId" HeaderText="fId" SortExpression="fId" InsertVisible="False" ReadOnly="True" Visible="false"></asp:BoundField>
                <asp:BoundField DataField="fPic" HeaderText="fPic" SortExpression="fPic" Visible="false"></asp:BoundField>


                <asp:BoundField DataField="fFirst" HeaderText="抬頭" SortExpression="fFirst">
                    <HeaderStyle CssClass="info text-center" Font-Bold="True" Font-Size="Large" />
                    <ItemStyle CssClass="text-left" Font-Size="Medium" />
                </asp:BoundField>
                <asp:BoundField DataField="fSecond" HeaderText="標題" SortExpression="fSecond">
                    <HeaderStyle CssClass="info text-center" Font-Bold="True" Font-Size="Large" />
                    <ItemStyle CssClass="text-left" Font-Size="Medium" />
                </asp:BoundField>
                <asp:BoundField DataField="fThird" HeaderText="副標題" SortExpression="fThird">
                    <HeaderStyle CssClass="info text-center" Font-Bold="True" Font-Size="Large" />
                    <ItemStyle CssClass="text-left" Font-Size="Medium" />
                </asp:BoundField>

                <asp:TemplateField ShowHeader="False" >
                    <HeaderStyle CssClass="info text-center" Font-Bold="True" Font-Size="Large" />
                    <ItemStyle CssClass="text-left" Font-Size="Medium" />
                    <EditItemTemplate>
                        <asp:LinkButton runat="server" Text="確定" CommandName="Update" CausesValidation="True" ID="LinkButton1" ></asp:LinkButton>&nbsp;<asp:LinkButton runat="server" Text="取消" CommandName="Cancel" CausesValidation="False" ID="LinkButton2"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton runat="server" Text="編輯" CommandName="Edit" CausesValidation="False" ID="LinkButton1"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>

    </div>
</asp:Content>
