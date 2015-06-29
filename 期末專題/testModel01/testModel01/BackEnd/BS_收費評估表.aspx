<%@ Page Title="" Language="C#" MasterPageFile="~/BackEnd/BS_Site.Master" AutoEventWireup="true" CodeBehind="BS_收費評估表.aspx.cs" Inherits="testModel01.WebForm11" %>

<asp:Content ID="Content1" ContentPlaceHolderID="BS_HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BS_BodyContent" runat="server">
    <link href="/./Content/jasny-bootstrap.min.css" rel="stylesheet" />
    <script src="/./Scripts/jasny-bootstrap.min.js"></script>

   

        <h2 style="color: #FF6600">收費評估表修改(使用者下載的 Word 檔)</h2>

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
        <asp:Button ID="btn上傳word檔" runat="server" Text="確定上傳" OnClick="btn上傳word檔_Click" CssClass="btn btn-primary" />

    
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbKSYYConnectionString %>" DeleteCommand="DELETE FROM [t收費評估表] WHERE [f1] = @f1" InsertCommand="INSERT INTO [t收費評估表] ([f2], [f3], [f4], [f5]) VALUES (NULL, NULL, NULL, NULL)" SelectCommand="SELECT * FROM [t收費評估表]" UpdateCommand="UPDATE [t收費評估表] SET [f2] = @f2, [f3] = @f3, [f4] = @f4, [f5] = @f5 WHERE [f1] = @f1">
            <DeleteParameters>
                <asp:Parameter Name="f1" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="f2" Type="String" />
                <asp:Parameter Name="f3" Type="String" />
                <asp:Parameter Name="f4" Type="String" />
                <asp:Parameter Name="f5" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="f2" Type="String" />
                <asp:Parameter Name="f3" Type="String" />
                <asp:Parameter Name="f4" Type="String" />
                <asp:Parameter Name="f5" Type="String" />
                <asp:Parameter Name="f1" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-hover" ShowHeader="False" DataKeyNames="f1" DataSourceID="SqlDataSource1" Font-Names="微軟正黑體">
            <Columns>
                <asp:BoundField DataField="f1" HeaderText="f1" InsertVisible="False" ReadOnly="True" SortExpression="f1" Visible="False" />
                <asp:BoundField DataField="f2" HeaderText="f2" SortExpression="f2" />
                <asp:BoundField DataField="f3" HeaderText="f3" SortExpression="f3" />
                <asp:TemplateField HeaderText="f4" SortExpression="f4">
                    <EditItemTemplate>
                        <asp:TextBox runat="server" Text='<%# Bind("f4") %>' ID="TextBox2" Width="200px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%# Bind("f4") %>' ID="Label2"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="f5" SortExpression="f5">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("f5") %>' Width="200px"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("f5") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="更新" ForeColor="Red" Font-Bold="true"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" ForeColor="Red" Font-Bold="true"></asp:LinkButton>

                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="編輯" ></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" OnClientClick="return confirm('確定要刪除嗎?')" Text="刪除"></asp:LinkButton>

                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    <asp:Button ID="btnInsert" runat="server" Text="新增" OnClick="btnInsert_Click" CssClass="btn btn-primary"/>
        </ContentTemplate>
    </asp:UpdatePanel>
        
</asp:Content>
