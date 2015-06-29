<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BS_收費標準表Edit.aspx.cs" Inherits="testModel01.BackEnd.BS_收費標準表Edit" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="/./Content/bootstrap.css" rel="stylesheet" />
    <link href="/./Content/BackEndUI.css" rel="stylesheet" />
    <script src="/./Scripts/jquery-1.9.1.js"></script>
    <script src="/./Scripts/bootstrap.js"></script>

    <script src="/./ckeditor/ckeditor.js"></script>
</head>
<body>
    <form id="form100" runat="server">
        <div class="container-NewsEdit">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbKSYYConnectionString %>" SelectCommand="SELECT * FROM [Fees_table_1] WHERE ([id] = @id)" DeleteCommand="DELETE FROM [Fees_table_1] WHERE [id] = @id" InsertCommand="INSERT INTO [Fees_table_1] ([room], [price], [care], [careprice]) VALUES (@room, @price, @care, @careprice)" UpdateCommand="UPDATE [Fees_table_1] SET [room] = @room, [price] = @price, [care] = @care, [careprice] = @careprice WHERE [id] = @id">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="room" Type="String" />
                    <asp:Parameter Name="price" Type="String" />
                    <asp:Parameter Name="care" Type="String" />
                    <asp:Parameter Name="careprice" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:QueryStringParameter Name="id" QueryStringField="id" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="room" Type="String" />
                    <asp:Parameter Name="price" Type="String" />
                    <asp:Parameter Name="care" Type="String" />
                    <asp:Parameter Name="careprice" Type="String" />
                    <asp:Parameter Name="id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:FormView ID="FormView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" DefaultMode="Edit" OnItemCommand="FormView1_ItemCommand" OnItemUpdated="FormView1_ItemUpdated" Width="100%">
                <EditItemTemplate>
                    <div class="modal-header">
                        <%--<button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>--%>
                        <h4 class="modal-title" id="myModalLabel">編輯中...</h4>
                    </div>
                    <div class="modal-body">
                        <table class="table table table-bordered table-condensed" style="width: 100%">
                            <tr>
                                <td class="info text-center h4">
                                    <asp:Label ID="lblroom" runat="server" Text="住  房" Font-Bold="True" Font-Names="微軟正黑體" Font-Size="Large"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="fSubjectTextBox" runat="server" Text='<%# Bind("room") %>' CssClass="form-control" Font-Names="微軟正黑體" Font-Size="Medium" />
                                </td>
                            </tr>
                            <tr>
                                <td class="info text-center h4">
                                    <asp:Label ID="lblprice" runat="server" Text="基本月費（含住房費、水電費、洗衣費、一般伙食費）" Font-Bold="True" Font-Names="微軟正黑體" Font-Size="Large"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="fSubjectTextBox1" runat="server" Text='<%# Bind("price") %>' CssClass="form-control" Font-Names="微軟正黑體" Font-Size="Medium" />
                                </td>
                            </tr>
                            <tr>
                                <td class="info text-center h4">
                                    <asp:Label ID="lblcare" runat="server" Text="特殊照護費" Font-Bold="True" Font-Names="微軟正黑體" Font-Size="Large"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="fSubjectTextBox2" runat="server" Text='<%# Bind("care") %>' CssClass="form-control" Font-Names="微軟正黑體" Font-Size="Medium" />
                                </td>
                            </tr>
                            <tr>
                                <td class="info text-center h4">
                                    <asp:Label ID="lblcareprice" runat="server" Text="費  用" Font-Bold="True" Font-Names="微軟正黑體" Font-Size="Large"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="fSubjectTextBox3" runat="server" Text='<%# Bind("careprice") %>' CssClass="form-control" Font-Names="微軟正黑體" Font-Size="Medium" />
                                </td>
                            </tr>
                         </table>
                    </div>
                    <div class="modal-footer">
                        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="&lt;img src=&quot;/./pic/save32x32.png&quot; /&gt;" OnClientClick="return confirm('確定要儲存？')" ToolTip="點我儲存"></asp:LinkButton>
                        <asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="&lt;img src=&quot;/./pic/Cancel32x32.png&quot; /&gt;" ToolTip="點我取消"></asp:LinkButton>
                    </div>
                    
                </EditItemTemplate>
                <InsertItemTemplate>
                    room:
                <asp:TextBox ID="roomTextBox" runat="server" Text='<%# Bind("room") %>' />
                    <br />
                    price:
                <asp:TextBox ID="priceTextBox" runat="server" Text='<%# Bind("price") %>' />
                    <br />
                    care:
                <asp:TextBox ID="careTextBox" runat="server" Text='<%# Bind("care") %>' />
                    <br />
                    careprice:
                <asp:TextBox ID="carepriceTextBox" runat="server" Text='<%# Bind("careprice") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="插入" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
                </InsertItemTemplate>
                <ItemTemplate>
                    id:
                <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                    <br />
                    room:
                <asp:Label ID="roomLabel" runat="server" Text='<%# Bind("room") %>' />
                    <br />
                    price:
                <asp:Label ID="priceLabel" runat="server" Text='<%# Bind("price") %>' />
                    <br />
                    care:
                <asp:Label ID="careLabel" runat="server" Text='<%# Bind("care") %>' />
                    <br />
                    careprice:
                <asp:Label ID="carepriceLabel" runat="server" Text='<%# Bind("careprice") %>' />
                    <br />
                    <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="修改" />
                    &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="刪除" />
                    &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="新增" />
                </ItemTemplate>
            </asp:FormView>
        </div>
    </form>
</body>
</html>
