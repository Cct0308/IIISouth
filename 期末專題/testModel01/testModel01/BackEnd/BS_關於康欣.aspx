<%@ Page Title="" Language="C#" MasterPageFile="~/BackEnd/BS_Site.Master" AutoEventWireup="true" CodeBehind="BS_關於康欣.aspx.cs" Inherits="testModel01.BackEnd.WebForm2" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BS_HeadContent" runat="server">
    <p style="font-size: xx-large; color: #0000CC">
        <strong>關於康欣</strong></p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BS_BodyContent" runat="server">
   
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbKSYYConnectionString %>" DeleteCommand="DELETE FROM [about] WHERE [Id] = @Id" InsertCommand="INSERT INTO [about] ([Id], [article]) VALUES (@Id, @article)" SelectCommand="SELECT * FROM [about]" UpdateCommand="UPDATE [about] SET [article] = @article WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Id" Type="Int32" />
                <asp:Parameter Name="article" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="article" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" Width="100%" CssClass="table table-bordered table-hover">
            <Columns>
                <asp:TemplateField HeaderText="關於我們">
                    <ItemTemplate>
                        <asp:Label ID="lb1" runat="server" Text='<%# Bind("article") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <CKEditor:CKEditorControl ID="CKEditorControl1" runat="server" Text='<%#Bind("article") %>'></CKEditor:CKEditorControl>
                   
                    </EditItemTemplate>
                    <HeaderStyle CssClass="info text-center" Font-Size="Medium" />
                    <ItemStyle Font-Size="Medium" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="修改" ShowHeader="False">
                    <EditItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="True" CommandName="Update" ImageUrl="~/pic/save32x32.png" OnClientClick="return confirm('確定要儲存？')" Text="儲存" ToolTip="點我儲存" />
                        &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" CausesValidation="False" CommandName="Cancel" ImageUrl="~/pic/Cancel32x32.png" Text="取消" ToolTip="點我取消" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Edit" ImageUrl="~/pic/reverse32x32.png" Text="修改" ToolTip="點我修改" />
                    </ItemTemplate>
                    <HeaderStyle CssClass="info text-center" Font-Size="Medium" />
                    <ItemStyle CssClass="text-center" Font-Size="Medium" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
  
</asp:Content>
