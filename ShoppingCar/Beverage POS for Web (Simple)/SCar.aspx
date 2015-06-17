<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SCar.aspx.cs" Inherits="SCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 500px;
            font-size: xx-small;
            text-align: center;
        }
        .auto-style3 {
            height: 20px;
        }
        .auto-style4 {
            width: 500px;
            font-size: xx-small;
            text-align: center;
            height: 20px;
        }
        .auto-style5 {
            width: 289px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
                <td class="auto-style3" colspan="2"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td style="text-align: center; font-size: xx-small">
                    <asp:Button ID="btn繼續購物" runat="server" Height="50px" OnClick="btn繼續購物_Click" style="font-family: 微軟正黑體; font-size: medium" Text="繼續購物" Width="75px" />
                </td>
                <td class="auto-style2">
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="font-size: medium; font-family: 微軟正黑體">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </td>
                <td class="auto-style5" style="text-align: center; font-size: xx-small">
                    <br />
                    <asp:Label ID="Label1" runat="server" style="font-family: 微軟正黑體; font-size: large" Text="金額: "></asp:Label>
                    <asp:Label ID="lbl金額" runat="server" style="font-family: 微軟正黑體; font-size: large" Width="100px"></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" style="font-family: 微軟正黑體; font-size: large" Text="現金: "></asp:Label>
                    <asp:Label ID="lbl現金" runat="server" style="font-family: 微軟正黑體; font-size: large" Width="100px"></asp:Label>
                    <br />
                    <asp:Label ID="Label3" runat="server" style="font-family: 微軟正黑體; font-size: large" Text="找零: "></asp:Label>
                    <asp:Label ID="lbl找零" runat="server" style="font-family: 微軟正黑體; font-size: large" Width="100px"></asp:Label>
                    <br />
                </td>
                <td style="text-align: left; font-size: xx-small">
                    <br />
                        <asp:Button ID="btn7" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="7" Width="50px" OnClick="btnCarNumber" />
                        &nbsp;<asp:Button ID="btn8" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="8" Width="50px" OnClick="btnCarNumber" />
                        &nbsp;<asp:Button ID="btn9" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="9" Width="50px" OnClick="btnCarNumber" />
                        <br />
                        <asp:Button ID="btn4" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="4" Width="50px" OnClick="btnCarNumber" />
                        &nbsp;<asp:Button ID="btn5" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="5" Width="50px" OnClick="btnCarNumber" />
                        &nbsp;<asp:Button ID="btn6" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="6" Width="50px" OnClick="btnCarNumber" />
                        <br />
                        <asp:Button ID="btn1" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="1" Width="50px" OnClick="btnCarNumber" />
                        &nbsp;<asp:Button ID="btn2" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="2" Width="50px" OnClick="btnCarNumber" />
                        &nbsp;<asp:Button ID="btn3" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="3" Width="50px" OnClick="btnCarNumber" />
                        &nbsp;<asp:Button ID="btn清除" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="清除" Width="50px" OnClick="btn清除_Click" />
                        <br />
                        <asp:Button ID="btn0" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="0" Width="50px" OnClick="btnCarNumber" />
                        &nbsp;<asp:Button ID="btn00" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="00" Width="50px" OnClick="btnCarNumber" />
                        &nbsp;<asp:Button ID="btn000" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="000" Width="50px" OnClick="btnCarNumber" />
                        &nbsp;<asp:Button ID="btn找零" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="找零" Width="50px" OnClick="btn找零_Click" />
                        <br />
                </td>
                <td style="text-align: center; font-size: xx-small">
                    <asp:Button ID="btn結帳" runat="server" Height="50px" OnClick="btn結帳_Click" style="font-family: 微軟正黑體; font-size: medium; margin-bottom: 2px" Text="結帳" Width="75px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
