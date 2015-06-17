<%@ Page Title="" Language="C#" MasterPageFile="~/BackEnd/BS_Site.Master" AutoEventWireup="true" CodeBehind="BS_收費評估表.aspx.cs" Inherits="testModel01.WebForm11" %>

<asp:Content ID="Content1" ContentPlaceHolderID="BS_HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BS_BodyContent" runat="server">
    <link href="../Content/jasny-bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jasny-bootstrap.min.js"></script>
  
    <div class="container">

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

        <h2 style="color: #FF6600">收費評估表修改(前台顯示)</h2>

        <div class="fileinput fileinput-new input-group" data-provides="fileinput" style="width: 50%">
            <div class="form-control" data-trigger="fileinput">
                <i class="glyphicon glyphicon-file fileinput-exists"></i>
                <span class="fileinput-filename"></span>
            </div>
            <span class="input-group-addon btn btn-default btn-file">
                <span class="fileinput-new">Select file</span>
                <span class="fileinput-exists">Change</span>
                <asp:FileUpload ID="FileUpload_收費評估表" runat="server" />
            </span>
            <a href="#" class="input-group-addon btn btn-default fileinput-exists" data-dismiss="fileinput">Remove</a>
        </div>

        <asp:Button ID="btn上傳收費評估表" runat="server" Text="確定上傳" OnClick="btn上傳收費評估表_Click" CssClass="btn btn-primary" />
      
    </div>
</asp:Content>
