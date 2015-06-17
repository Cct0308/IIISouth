<%@ Page Title="" Language="C#" MasterPageFile="~/BackEnd/BS_Site.Master" AutoEventWireup="true" CodeBehind="BS_床位顯示_表格.aspx.cs" Inherits="testModel01.BackEnd.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BS_HeadContent" runat="server">

    <style>
        .mybox {
        width:15%;
        text-align: center;
        height:50px;
        }
            .auto-style2 {
            width: 15%;
            text-align: center;
            height:50px;
        }
        .mytext {
        font-size:30px;
        }
        .mytable {
        margin-left:5%;
        margin-right:5%;
        width:90%;
        }
        .mybtnW {
            width: 45px;
            height: 45px;
            background-image: url("../pic/床位照片/add_1.png");
                background-size:cover;       
        }    
    .mybtnB {
            width:90%;
            height:45px;            
            background-color:rgba(171, 235, 235, 1);
        }
    .mybtnG {
            width:90%;
            height:45px;
            background-image:url("");
            background-color:rgba(174, 239, 173, 1);
        }
        .myimg_bed {
        width:73px;        
        max-height:40px;
        }
        
        .auto-style3 {
            font-size: x-large;
        }
        .auto-style5 {
            text-align: right;
            width: 15%;
        }
         .auto-style6 {
            text-align: left;
            width: 15%;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BS_BodyContent" runat="server">

  <div class="modal fade" id="myModal" tabindex="-1" role="dialog" 
         aria-labelledby="myModalLabel" aria-hidden="true" data-backdrop="static" data-keyboard="false">
        <div class="modal-dialog modal-content" style="width:70%">
        </div>
    </div>

    <asp:Panel ID="Panel1" runat="server">
    <table id="table1" class="table  table-bordered mytable">
        <tr class="active">
            <td class="auto-style2 mytext" rowspan="2">
                <br />
                房號</td>
            <td class="text-center info mytext" colspan="5">床號</td>
        </tr>

        <tr>
            <td class="mybox mytext">A</td>
            <td class="mybox mytext">B</td>
            <td class="mybox mytext">C</td>
            <td class="mybox mytext">D</td>
            <td class="mybox mytext">E</td>
        </tr>

        <tr>
            <td class="auto-style2 mytext">101(隔離室)</td>
            <td class="mybox">
                <a id="A5"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=101"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button2" runat="server"   ToolTip="101"  />
                       </a>
            </td>
            <td class="mybox"></td>
            <td class="mybox">&nbsp;</td>
            <td class="mybox">&nbsp;</td>
            <td class="mybox">&nbsp;</td>
        </tr>

        <tr>
            <td class="auto-style2 mytext">102</td>
            <td class="mybox">
                <a id="A1"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=102-1(A)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button1" runat="server"   ToolTip="102-1(A)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A2"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=102-2(B)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button3" runat="server"   ToolTip="102-2(B)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A3"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=102-3(C)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button4" runat="server"   ToolTip="102-3(C)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A4"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=102-5(D)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button5" runat="server"   ToolTip="102-5(D)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A6"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=102-6(E)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button6" runat="server"   ToolTip="102-6(E)"  />
                       </a>
            </td>
        </tr>

       <tr>
            <td class="auto-style2 mytext">103</td>
            <td class="mybox">
                <a id="A7"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=103-1(A)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button7" runat="server"   ToolTip="103-1(A)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A8"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=103-2(B)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button8" runat="server"   ToolTip="103-2(B)"  />
                       </a>
            </td>
            <td class="mybox"> </td>
            <td class="mybox"> </td>
            <td class="mybox"> </td>
        </tr>
      
        <tr>
            <td class="auto-style2 mytext">105</td>
            <td class="mybox">
                <a id="A9"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=105-1(A)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button9" runat="server"   ToolTip="105-1(A)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A10"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=105-2(B)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button10" runat="server"   ToolTip="105-2(B)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A11"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=105-3(C)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button11" runat="server"   ToolTip="105-3(C)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A12"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=105-5(D)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button12" runat="server"   ToolTip="105-5(D)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A13"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=105-6(E)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button13" runat="server"   ToolTip="105-6(E)"  />
                       </a>
            </td>
        </tr>
                
        <tr>
            <td class="auto-style2 mytext">106</td>
            <td class="mybox">
                <a id="A14"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=106-1(A)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button14" runat="server"   ToolTip="106-1(A)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A15"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=106-2(B)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button15" runat="server"   ToolTip="106-2(B)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A16"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=106-3(C)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button16" runat="server"   ToolTip="106-3(C)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A17"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=106-5(D)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button17" runat="server"   ToolTip="106-5(D)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A18"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=106-6(E)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button18" runat="server"   ToolTip="106-6(E)"  />
                       </a>
            </td>
        </tr>

        <tr>
            <td class="auto-style2 mytext">107</td>
            <td class="mybox">
                <a id="A19"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=107-1(A)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button19" runat="server"   ToolTip="107-1(A)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A20"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=107-2(B)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button20" runat="server"   ToolTip="107-2(B)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A21"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=107-3(C)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button21" runat="server"   ToolTip="107-3(C)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A22"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=107-5(D)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button22" runat="server"   ToolTip="107-5(D)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A23"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=107-6(E)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button23" runat="server"   ToolTip="107-6(E)"  />
                       </a>
            </td>
        </tr>
        
        <tr>
            <td class="auto-style2 mytext">108</td>
            <td class="mybox">
                <a id="A24"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=108-1(A)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button24" runat="server"   ToolTip="108-1(A)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A25"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=108-2(B)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button25" runat="server"   ToolTip="108-2(B)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A26"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=108-3(C)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button26" runat="server"   ToolTip="108-3(C)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A27"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=108-5(D)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button27" runat="server"   ToolTip="108-5(D)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A28"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=108-6(E)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button28" runat="server"   ToolTip="108-6(E)"  />
                       </a>
            </td>
        </tr>
             
        <tr>
            <td class="auto-style2 mytext">109</td>
            <td class="mybox">
                <a id="A29"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=109-1(A)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button29" runat="server"   ToolTip="109-1(A)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A30"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=109-2(B)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button30" runat="server"   ToolTip="109-2(B)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A31"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=109-3(C)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button31" runat="server"   ToolTip="109-3(C)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A32"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=109-5(D)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button32" runat="server"   ToolTip="109-5(D)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A33"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=109-6(E)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button33" runat="server"   ToolTip="109-6(E)"  />
                       </a>
            </td>
        </tr>
              
        <tr>
            <td class="auto-style2 mytext">110</td>
            <td class="mybox">
                <a id="A34"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=110-1(A)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button34" runat="server"   ToolTip="110-1(A)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A35"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=110-2(B)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button35" runat="server"   ToolTip="110-2(B)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A36"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=110-3(C)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button36" runat="server"   ToolTip="110-3(C)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A37"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=110-5(D)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button37" runat="server"   ToolTip="110-5(D)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A38"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=110-6(E)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button38" runat="server"   ToolTip="110-6(E)"  />
                       </a>
            </td>
        </tr>
                      
        <tr>
            <td class="auto-style2 mytext">111</td>
            <td class="mybox">
                <a id="A39"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=111-1(A)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button39" runat="server"   ToolTip="111-1(A)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A40"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=111-2(B)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button40" runat="server"   ToolTip="111-2(B)"  />
                       </a>
            </td>
            <td class="mybox">    </td>
            <td class="mybox"> </td>
            <td class="mybox">      </td>
        </tr>

        <tr>
            <td class="auto-style2 mytext">112</td>
            <td class="mybox">
                <a id="A41"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=112-1(A)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button41" runat="server"   ToolTip="112-1(A)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A42"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=112-2(B)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button42" runat="server"   ToolTip="112-2(B)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A43"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=112-3(C)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button43" runat="server"   ToolTip="112-3(C)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A44"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=112-5(D)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button44" runat="server"   ToolTip="112-5(D)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A45"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=112-6(E)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button45" runat="server"   ToolTip="112-6(E)"  />
                       </a>
            </td>
        </tr>
                
        <tr>
            <td class="auto-style2 mytext">113</td>
            <td class="mybox">
                <a id="A46"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=113-1(A)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button46" runat="server"   ToolTip="113-1(A)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A47"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=113-2(B)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button47" runat="server"   ToolTip="113-2(B)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A48"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=113-3(C)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button48" runat="server"   ToolTip="113-3(C)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A49"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=113-5(D)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button49" runat="server"   ToolTip="113-5(D)"  />
                       </a>
            </td>
            <td class="mybox">
                <a id="A50"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=113-6(E)"
                         data-toggle="modal"   data-target="#myModal" >          
                             <asp:Button ID="Button50" runat="server"   ToolTip="113-6(E)"  />
                       </a>
            </td>
        </tr>
    </table>
        <br/>

        <table class="table  table-bordered mytable">
            <tr>
                <td class="text-center" colspan="6">
                    <div align="center" style="font-size:30px">
                        統計
                    </div>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                   <img src="../pic/床位照片/床位1%20-白.jpg"  class="myimg_bed_bed" />
                    空床:</td>
                <td class="auto-style6">
                    <asp:Label ID="lbl_W" runat="server" Text="Label" CssClass="auto-style3"></asp:Label>
                    <span class="auto-style3">人</span></td>
                <td class="auto-style5">
                           <img src="../pic/床位照片/床位1%20-綠.jpg" class="myimg_bed"  />
                           有人:</td>
                <td class="auto-style6">
                    <asp:Label ID="lbl_G" runat="server" Text="Label" CssClass="auto-style3"></asp:Label>
                    <span class="auto-style3">人</span></td>
                <td class="auto-style5">
                           <img src="../pic/床位照片/床位1%20-藍.jpg" class="myimg_bed" />
                           住院:</td>
                <td class="auto-style6">
                    <asp:Label ID="lbl_B" runat="server" Text="Label" CssClass="auto-style3"></asp:Label>
                    <span class="auto-style3">人</span></td>
            </tr>
        </table>
        <br/>

        </asp:Panel>
</asp:Content>
