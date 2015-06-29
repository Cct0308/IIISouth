<%@ Page Title="" Language="C#" MasterPageFile="~/BackEnd/BS_Site.Master" AutoEventWireup="true" CodeBehind="BS_修改密碼.aspx.cs" Inherits="testModel01.BackEnd.WebForm12" %>

<asp:Content ID="Content1" ContentPlaceHolderID="BS_HeadContent" runat="server">
    <style type="text/css">
        .my_Text {
            width: 150px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BS_BodyContent" runat="server">


    <h1 style="text-align: center;">修改密碼</h1>
    <hr />

    <label for="inputPassword">舊密碼:</label><br />
    <asp:TextBox ID="TBox_pw0" runat="server"
        placeholder="請輸入密碼" TextMode="Password"></asp:TextBox>
    <br />
    <br />

    <label for="inputPassword">新密碼:</label><br />
    <asp:TextBox ID="TBox_pw1" runat="server"
        placeholder="請輸入密碼" TextMode="Password"></asp:TextBox>
    <br />
    <br />


    <label for="inputPassword">確認密碼:</label><br />
    <asp:TextBox ID="TBox_pw2" runat="server"
        placeholder="請輸入密碼" TextMode="Password"></asp:TextBox>

    <br />
    <br />
    <br />
    <asp:Button ID="btn_change" runat="server" Text="確定修改" class="btn btn-lg btn-primary" OnClick="btn_change_Click" />

    <asp:Button ID="btn_clear" runat="server" Text="清除" class="btn btn-lg btn-primary" OnClick="btn_clear_Click" />


</asp:Content>
