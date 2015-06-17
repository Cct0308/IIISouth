<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="testModel01.BackEnd.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style type="text/css">
        
        .myimg {
            height:200px;
            max-width:300px;
            ime-mode:inactive;
             }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString='<%$ ConnectionStrings:dbKSYYConnectionString %>' 
            SelectCommand="SELECT * as 照片欄位 FROM [T康欣_活動剪影] WHERE (([f庭院照片_s] = @照片) or ([f庭院照片_l] = @照片)   )">

            <SelectParameters>
                <asp:QueryStringParameter QueryStringField="照片" Name="照片" Type="String"></asp:QueryStringParameter>
                <asp:QueryStringParameter QueryStringField="欄位" Name="欄位" Type="String"></asp:QueryStringParameter>
       
                     </SelectParameters>
        </asp:SqlDataSource>

        <br />
        <br />
        <asp:FormView ID="FormView1" runat="server" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("照片欄位") %>'></asp:Label>

            </ItemTemplate>
        </asp:FormView>
    </form>
</body>
</html>
