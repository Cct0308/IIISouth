<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 100%;
            height: 450px;
        }
        .auto-style10 {
            font-size: large;
            font-family: 微軟正黑體;
        }
        .auto-style12 {
            font-size: xx-small;
        }
        .auto-style13 {
            width: 648px;
            font-size: xx-small;
            height: 218px;
        }
        .auto-style14 {
            width: 275px;
            font-size: xx-small;
            text-align: center;
        }
        .auto-style15 {
            width: 340px;
            font-size: xx-small;
            height: 218px;
        }
        .auto-style16 {
            font-size: small;
        }
        .auto-style17 {
            width: 648px;
            font-size: xx-small;
            height: 250px;
        }
        .auto-style18 {
            width: 340px;
            font-size: xx-small;
            height: 250px;
        }
    </style>
</head>
<body style="text-align: center;">
    <form id="form1" runat="server">
    <div style="height: 480px; text-align: center;">
    
        <table class="auto-style4" align="center">
            <tr>
                <td class="auto-style14" rowspan="2">
                    <asp:Button ID="btn購物車" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="購物車" Width="75px" OnClick="btn購物車_Click" />
                        <br />
                </td>
                <td class="auto-style17">
                    <br />
                    <br />
                        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </td>
                <td class="auto-style18">
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style10" Text="品名: "></asp:Label>
                        <asp:Label ID="lbl品名" runat="server" CssClass="auto-style10" Width="250px"></asp:Label>
                        <br />
                        <asp:Label ID="Label2" runat="server" CssClass="auto-style10" Text="數量: "></asp:Label>
                        <asp:Label ID="lbl數量" runat="server" CssClass="auto-style10" Width="250px"></asp:Label>
                        <br />
                        <asp:Label ID="Label3" runat="server" CssClass="auto-style10" Text="單價: "></asp:Label>
                        <asp:Label ID="lbl單價" runat="server" CssClass="auto-style10" Width="250px"></asp:Label>
                        <br />
                        <asp:Label ID="Label4" runat="server" CssClass="auto-style10" Text="溫度: "></asp:Label>
                        <asp:Label ID="lbl溫度" runat="server" CssClass="auto-style10" Width="250px"></asp:Label>
                        <br />
                        <asp:Label ID="Label5" runat="server" CssClass="auto-style10" Text="甜度: "></asp:Label>
                        <asp:Label ID="lbl甜度" runat="server" CssClass="auto-style10" Width="250px"></asp:Label>
                        <br />
                        <asp:Label ID="Label6" runat="server" CssClass="auto-style10" Text="加料: "></asp:Label>
                        <asp:Label ID="lbl加料" runat="server" CssClass="auto-style10" Width="250px"></asp:Label>
                        <br />
                        <asp:Label ID="Label7" runat="server" CssClass="auto-style10" Text="小計: "></asp:Label>
                        <asp:Label ID="lbl小計" runat="server" CssClass="auto-style10" Width="250px"></asp:Label>
                        <br />
                </td>
                <td class="auto-style12" rowspan="2">
                        <asp:Button ID="btn確認" runat="server" Height="50px" OnClick="btn確認_Click" style="font-family: 微軟正黑體; font-size: medium" Text="確認" Width="75px" />
                        <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style13">
    <asp:Button ID="btn熱" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="熱" Width="55px" CssClass="auto-style16" OnClick="btnTemperature" />
    &nbsp;<asp:Button ID="btn溫熱" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="溫熱" Width="55px" CssClass="auto-style16" OnClick="btnTemperature" />
    &nbsp;<asp:Button ID="btn溫" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="溫" Width="55px" CssClass="auto-style16" OnClick="btnTemperature" />
    &nbsp;<asp:Button ID="btn微溫" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="微溫" Width="55px" CssClass="auto-style16" OnClick="btnTemperature" />
    &nbsp;<asp:Button ID="btn常溫" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="常溫" Width="55px" CssClass="auto-style16" OnClick="btnTemperature" />
    &nbsp;<asp:Button ID="btn少冰" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="少冰" Width="55px" CssClass="auto-style16" OnClick="btnTemperature" />
    &nbsp;<asp:Button ID="btn微冰" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="微冰" Width="55px" CssClass="auto-style16" OnClick="btnTemperature" />
    &nbsp;<asp:Button ID="btn碎冰" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="碎冰" Width="55px" CssClass="auto-style16" OnClick="btnTemperature" />
    &nbsp;<asp:Button ID="btn去冰" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="去冰" Width="55px" CssClass="auto-style16" OnClick="btnTemperature" />
    &nbsp;<asp:Button ID="btn完全去冰" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="完去" Width="55px" CssClass="auto-style16" OnClick="btnTemperature" />
                    <br />
                    <br />
    <asp:Button ID="btn7分糖" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="7分糖" Width="55px" CssClass="auto-style16" OnClick="btnSugar" />
    &nbsp;<asp:Button ID="btn5分糖" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="5分糖" Width="55px" CssClass="auto-style16" OnClick="btnSugar" />
    &nbsp;<asp:Button ID="btn3分糖" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="3分糖" Width="55px" CssClass="auto-style16" OnClick="btnSugar" />
    &nbsp;<asp:Button ID="btn1分糖" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="1分糖" Width="55px" CssClass="auto-style16" OnClick="btnSugar" />
    &nbsp;<asp:Button ID="btn無糖" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="無糖" Width="55px" CssClass="auto-style16" OnClick="btnSugar" />
    &nbsp;<asp:Button ID="btn大珍珠" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="大珍珠" Width="55px" CssClass="auto-style16" OnClick="btnOther" />
    &nbsp;<asp:Button ID="btn小珍珠" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="小珍珠" Width="55px" CssClass="auto-style16" OnClick="btnOther" />
    &nbsp;<asp:Button ID="btn仙草凍" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="仙草凍" Width="55px" CssClass="auto-style16" OnClick="btnOther" />
    &nbsp;<asp:Button ID="btn椰果" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="椰果" Width="55px" CssClass="auto-style16" OnClick="btnOther" />
    &nbsp;<asp:Button ID="btn布丁" runat="server" Height="50px" style="font-family: 微軟正黑體; " Text="布丁" Width="55px" CssClass="auto-style16" OnClick="btnOther" />
                    <br />
                </td>
                <td class="auto-style15">
                        <asp:Button ID="btn7" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="7" Width="50px" OnClick="btnNumber" />
                        &nbsp;<asp:Button ID="btn8" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="8" Width="50px" OnClick="btnNumber" />
                        &nbsp;<asp:Button ID="btn9" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="9" Width="50px" OnClick="btnNumber" />
                        &nbsp;<asp:Button ID="btn溫度正常" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="溫度正常" Width="75px" OnClick="btn溫度正常_Click" />
                        <br />
                        <asp:Button ID="btn4" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="4" Width="50px" OnClick="btnNumber" />
                        &nbsp;<asp:Button ID="btn5" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="5" Width="50px" OnClick="btnNumber" />
                        &nbsp;<asp:Button ID="btn6" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="6" Width="50px" OnClick="btnNumber" />
                        &nbsp;<asp:Button ID="btn甜度正常" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="甜度正常" Width="75px" OnClick="btn甜度正常_Click" />
                        <br />
                        <asp:Button ID="btn1" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="1" Width="50px" OnClick="btnNumber" />
                        &nbsp;<asp:Button ID="btn2" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="2" Width="50px" OnClick="btnNumber" />
                        &nbsp;<asp:Button ID="btn3" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="3" Width="50px" OnClick="btnNumber" />
                        &nbsp;<asp:Button ID="btn加料清除" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="加料清除" Width="75px" OnClick="btn加料清除_Click" />
                        <br />
                        <asp:Button ID="btn0" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="0" Width="50px" OnClick="btnNumber" />
                        &nbsp;<asp:Button ID="btn歸零" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="歸零" Width="50px" OnClick="btn歸零_Click" />
                        &nbsp;<asp:Button ID="btn贈送" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="贈送" Width="50px" OnClick="btn贈送_Click" />
                        &nbsp;<asp:Button ID="btn取消交易" runat="server" Height="50px" style="font-family: 微軟正黑體; font-size: medium" Text="取消交易" Width="75px" OnClick="btn取消交易_Click" />
                        <br />
                </td>
            </tr>
        </table>
    
        <br />
    
    </div>
    </form>
</body>
</html>
