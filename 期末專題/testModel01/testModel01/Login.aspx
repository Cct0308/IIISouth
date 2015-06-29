<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="testModel01.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/loginBackground.css" rel="stylesheet" />
    <link href="Content/loginUI01.css" rel="stylesheet" />
    <link href="Content/loginUI02.css" rel="stylesheet" />

    <script src="Scripts/jquery-1.9.1.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <%--<script src="Scripts/loginBackground.js"></script>--%>

</head>
<body>
    <%--<div id="wrap">
        <img class="bgfade" src="loginImg/1.jpg" />
        <img class="bgfade" src="loginImg/2.jpg" />
        <img class="bgfade" src="loginImg/3.jpg" />
        <img class="bgfade" src="loginImg/4.jpg" />
        <img class="bgfade" src="loginImg/5.jpg" />
    </div>--%>
    <div class="container">
        <form class="form-signin" role="form" runat="server">
            <h4 class="form-signin-heading">請輸入帳號及密碼登入</h4>
            <label for="inputAccount" class="sr-only">帳號</label>
            <asp:TextBox ID="TBox_id" runat="server"
                class="form-control" placeholder="請輸入帳號"></asp:TextBox>
            <label for="inputPassword" class="sr-only">密碼</label>
            <asp:TextBox ID="TBox_pw" runat="server"
                class="form-control" placeholder="請輸入密碼" TextMode="Password"></asp:TextBox>
            <table class="nav-justified">
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="登入" class="btn btn-lg btn-primary btn-block pull-left" Style="width: 140px" OnClick="Button1_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="清除" class="btn btn-lg btn-primary btn-block pull-right" Style="width: 140px" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <p class="text-muted pull-right">&copy; <%: DateTime.Now.Year %> - KSYY <a id="A1" runat="server" href="/./FrontEnd/Main.aspx">回首頁</a></p>
            <br />
        </form>
    </div>
</body>
</html>
