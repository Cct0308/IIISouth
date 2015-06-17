<%@ Page Title="聯絡我們" Language="C#" MasterPageFile="~/FrontEnd/Site.Master" AutoEventWireup="true" CodeBehind="聯絡我們.aspx.cs" Inherits="testModel01.WebForm7" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <div class="page-banner" style="padding: 40px 0; background: url(../../images/banner.jpg) center #f9f9f9;">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <h2>聯絡我們</h2>
                </div>
                <div class="col-md-6">
                    <ul class="breadcrumbs">
                        <li><a href="Main.aspx">首頁</a></li>
                        <li>聯絡我們</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>
    <style type="text/css">
        #user_gmap {
            width: 1600px;
            height: 400px;
            margin: 0;
            border: 0;
        }

        #user_glink {
            width: 1100px;
            text-align: right;
            font-size: 10px;
            font-weight: normal;
            padding: 0px;
            height: 20px;
            margin: 0px auto;
        }

        .auto-style4 {
            color: rgb(255, 0, 0);
        }
    </style>
    <script type="text/javascript">
        google.maps.event.addDomListener(window, 'load', function () {
            var mapdiv = document.getElementById('user_gmap');
            var myOptions = {
                zoom: 15,
                center: new google.maps.LatLng(22.7885764, 120.3434107),
                mapTypeId: google.maps.MapTypeId.ROADMAP,
                scaleControl: true
            };
            var map = new google.maps.Map(mapdiv, myOptions);
            var marker = new google.maps.Marker({
                position: new google.maps.LatLng(22.7885764, 120.3434107),
                map: map,
                title: '康欣老人長期照顧中心(養護型)'
            });
            var infowindow = new google.maps.InfoWindow({
                content: '<strong>康欣老人長期照顧中心(養護型)</strong><br />電話：(07)614-1273<br />傳真：(07)614-0136<br />E-mail：t18428603@yahoo.com.tw<br />地址：高雄市燕巢區安招里安東街188號',
                size: new google.maps.Size(200, 200)
            });
            google.maps.event.addListener(marker, 'click', function () {
                infowindow.open(map, marker);
            });
            infowindow.open(map, marker);
        });
    </script>
    <div id="user_gmap"></div>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="row">
        <div class="col-md-8">
            <h4 class="classic-title"><span>聯絡我們</span></h4>
            <form role="form" class="contact-form" id="contact-form" method="post">
                <div class="form-group">
                    <div class="controls">
                        <input type="text" placeholder="姓名" name="name">
                    </div>
                </div>                
                <div class="form-group">
                    <div class="controls">
                        <input type="email" class="email" placeholder="信箱" name="email">
                    </div>
                </div>
                <div class="form-group">
                    <div class="controls">
                        <input type="text" class="requiredField" placeholder="主旨" name="subject">
                    </div>
                </div>
                <div class="form-group">
                    <div class="controls">
                        <textarea rows="7" placeholder="訊息" name="message"></textarea>
                    </div>
                </div>
                <button type="submit" id="submit" class="btn-system btn-large">送出</button><div id="success" style="color: #34495e;"></div>
            </form>
        </div>

        <div class="col-md-4">
            <h4 class="classic-title"><span>聯絡資訊</span></h4>

            <div class="hr1" style="margin-bottom: 10px;"></div>

            <ul class="icons-list">
                <li><i class="fa fa-globe"></i><strong>地址 : </strong>高雄市燕巢區安招里安東街188號</li>
                <li><i class="fa fa-envelope-o"></i><strong>電子信箱 : </strong>t18428603@yahoo.com.tw</li>
                <li><i class="fa fa-mobile"></i><strong>電話 : </strong>(07)614-1273 ‧ 614-0367</li>
            </ul>

            <div class="hr1" style="margin-bottom: 15px;"></div>

            <h4 class="classic-title"><span>工作時間</span></h4>
            <ul class="list-unstyled">
                <li><strong>Monday - Sunday</strong> - 24HR</li>
            </ul>
        </div>
    </div>
</asp:Content>
