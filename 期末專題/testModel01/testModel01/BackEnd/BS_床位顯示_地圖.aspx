<%@ Page Title="" Language="C#" MasterPageFile="~/BackEnd/BS_Site.Master" AutoEventWireup="true" CodeBehind="BS_床位顯示_地圖.aspx.cs" Inherits="testModel01.BackEnd.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="BS_HeadContent" runat="server">

       <style type="text/css">
           .mybtnG {
               background-image: url("../pic/床位照片/床位1 -綠.jpg" );
                   background-size:cover;
           }
               .mybtnB {
           background-image:url("../pic/床位照片/床位1 -藍.jpg" );    
           background-size:cover;       
           }
                   .mybtnW {
           background-image:url("../pic/床位照片/床位1 -白.jpg" );    
           background-size:cover;       
           }
              .auto-style1 {
               height: 35px;
               width: 88px;
           }
           .auto-style2 {
               height: 45px;
               width: 88px;
           }
           .auto-style3 {
               height: 61px;
               width: 88px;
           }
           .auto-style4 {
               height: 117px;
               width: 88px;
           }
           .auto-style5 {
               width: 88px;
           }
           .auto-style6 {
               height: 166px;
               width: 88px;
           }
              .auto-style7 {
               font-size: 20px;
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
       <div style="width: 1235px; height: 847px; margin: 0 auto 0 auto">
        <table id="talbe_map" class="nav-justified" style="background-image: url(../pic/床位_地圖85趴.jpg); width: 100%">
            <tr>
                <td style="height: 35px; width: 108px;">    
                </td>
                <td style="height: 35px; " colspan="2"></td>
                <td style="height: 35px; width: 88px;"></td>
                <td style="height: 35px; width: 88px;"></td>
                <td style="height: 35px; width: 88px;"></td>
                <td style="height: 35px; " colspan="2"></td>
                <td class="auto-style1"></td>
                <td style="height: 35px; width: 88px;"></td>
                <td style="height: 35px; width: 88px;"></td>
                <td style="height: 35px; width: 88px;"></td>
                <td style="height: 35px; width: 88px;"></td>
                <td style="height: 35px; width: 88px;"></td>
                <td style="height: 35px; width: 88px;"></td>
                <td style="height: 35px"></td>
            </tr>
            <tr>
                <td style="height: 45px; width: 108px;"></td>
                <td style="height: 45px; " colspan="2">
                         <a id="A1"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=110-6(E)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="110-6(E)"  />
                       </a>
                </td>
                <td style="height: 45px; width: 88px; text-align:right" ></td>
                <td style="height: 45px; width: 88px;">&nbsp;</td>
                <td style="height: 45px; width: 88px;text-align:right">
                       <a  runat="server"  
                         href="BS_床位編輯.aspx?f床號=109-3(C)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px" ToolTip="109-3(C)" />
                       </a>

                </td>
                <td style="height: 45px; " colspan="2">
                    <a id="A5"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=108-6(E)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button ID="Button2" runat="server" Height="30px" Width="70px"  ToolTip="108-6(E)"  />
                       </a>
                </td>
                <td class="auto-style2"></td>
                <td style="height: 45px; width: 88px;"></td>
                <td style="height: 45px; width: 88px;text-align:right">
                       <a  runat="server"  
                         href="BS_床位編輯.aspx?f床號=107-3(C)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px" ToolTip="107-3(C)" />
                       </a>

                </td>
                <td style="height: 45px; width: 88px;">
                    <a id="A13"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=106-6(E)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button ID="Button10" runat="server" Height="30px" Width="70px"  ToolTip="106-6(E)"  />
                       </a>
                </td>
                <td style="height: 45px; width: 88px;"></td>
                <td style="height: 45px; width: 88px;">
                    
                </td>
                 <td style="height: 45px; width: 88px;text-align:right">
                       <a  runat="server"  
                         href="BS_床位編輯.aspx?f床號=105-3(C)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px" ToolTip="105-3(C)" />
                       </a>

                </td>
                <td style="height: 45px"></td>
            </tr>
            <tr>
                <td style="height: 45px; width: 108px;"></td>
                <td style="height: 45px; " colspan="2">
                         <a runat="server"  
                         href="BS_床位編輯.aspx?f床號=110-5(D)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px" ToolTip="110-5(D)" />
                       </a>
                </td>
                <td style="height: 45px; width: 88px;text-align:right">
                       <a  runat="server"  
                         href="BS_床位編輯.aspx?f床號=110-2(B)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px" ToolTip="110-2(B)" />
                       </a>
                    </td>
                <td style="height: 45px; width: 88px;">
                    <a id="A4"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=109-6(E)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button ID="Button1" runat="server" Height="30px" Width="70px"  ToolTip="109-6(E)"  />
                       </a>
                </td>
                <td style="height: 45px; width: 88px;text-align:right">
                       <a  runat="server"  
                         href="BS_床位編輯.aspx?f床號=109-2(B)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px" ToolTip="109-2(B)" />
                       </a>

                </td>
                <td style="height: 45px; " colspan="2">
                      <a id="A9" runat="server"  
                         href="BS_床位編輯.aspx?f床號=108-5(D)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button ID="Button6" runat="server" Height="30px" Width="70px" ToolTip="108-5(D)" />
                       </a>
                </td>
                <td class="auto-style2">
                       <div style="text-align:right">
                         <a id="A18"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=108-2(B)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="108-2(B)"  />
                       </a>
                    </div>
                </td>
                <td style="height: 45px; width: 88px;">
                    <a id="A6"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=107-6(E)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button ID="Button3" runat="server" Height="30px" Width="70px"  ToolTip="107-6(E)"  />
                       </a>
                </td>
                <td style="height: 45px; width: 88px;text-align:right">
                       <a  runat="server"  
                         href="BS_床位編輯.aspx?f床號=107-2(B)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px" ToolTip="107-2(B)" />
                       </a>

                </td>
                <td style="height: 45px; width: 88px;">
                      <a id="A11" runat="server"  
                         href="BS_床位編輯.aspx?f床號=106-5(D)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button ID="Button8" runat="server" Height="30px" Width="70px" ToolTip="106-5(D)" />
                       </a>
                </td>
                <td style="height: 45px; width: 88px;text-align:right">
                       <a  runat="server"  
                         href="BS_床位編輯.aspx?f床號=106-2(B)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px" ToolTip="106-2(B)" />
                       </a>

                </td>
                <td style="height: 45px; width: 88px;">
                    <a id="A7"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=105-6(E)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button ID="Button4" runat="server" Height="30px" Width="70px"  ToolTip="105-6(E)"  />
                       </a>
                </td>
                <td style="height: 45px; width: 88px;text-align:right">
                       <a  runat="server"  
                         href="BS_床位編輯.aspx?f床號=105-2(B)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px" ToolTip="105-2(B)" />
                       </a>

                </td>
                <td style="height: 45px"></td>
            </tr>
            <tr>
                <td style="height: 45px; width: 108px;"></td>
                <td style="height: 45px; " colspan="2">
                         <a id="A3"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=110-3(C)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="110-3(C)" />
                       </a>

                </td>
                <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A2"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=110-1(A)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="110-1(A)"  />
                       </a>
                                
                    </td>
                <td style="height: 45px; width: 88px;">
                      <a id="A8" runat="server"  
                         href="BS_床位編輯.aspx?f床號=109-5(D)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button ID="Button5" runat="server" Height="30px" Width="70px" ToolTip="109-5(D)" />
                       </a>
                </td>
                     <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A16"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=109-1(A)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="109-1(A)"  />
                       </a>
                </td>
                <td style="height: 45px; " colspan="2">
                     <a id="A14"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=108-3(C)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="108-3(C)" />
                       </a>
                </td>
                <td class="auto-style2"  >
                                <div style="text-align:right">
                         <a id="A17"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=108-1(A)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="108-1(A)"  />
                       </a>
                    </div>
                </td>
                <td style="height: 45px; width: 88px;">
                      <a id="A10" runat="server"  
                         href="BS_床位編輯.aspx?f床號=107-5(D)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button ID="Button7" runat="server" Height="30px" Width="70px" ToolTip="107-5(D)" />
                       </a>
                </td>
                      <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A19"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=107-1(A)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="107-1(A)"  />
                       </a>
                </td>
                <td style="height: 45px; width: 88px;">
                     <a id="A15"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=106-3(C)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="106-3(C)" />
                       </a>
                </td>
                      <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A20"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=106-1(A)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="106-1(A)"  />
                       </a>
                </td>
                <td style="height: 45px; width: 88px;">
                      <a id="A12" runat="server"  
                         href="BS_床位編輯.aspx?f床號=105-5(D)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button ID="Button9" runat="server" Height="30px" Width="70px" ToolTip="105-5(D)" />
                       </a>

                </td>
                  <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A21"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=105-1(A)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="105-1(A)"  />
                       </a>

                  </td>
                <td style="height: 45px"></td>
            </tr>
            <tr>
                <td style="height: 61px; width: 108px;"></td>
                <td style="height: 61px; " colspan="2"></td>
                <td style="height: 61px; width: 88px;"></td>
                <td style="height: 61px; width: 88px;"></td>
                <td style="height: 61px; width: 88px;"></td>
                <td style="height: 61px; " colspan="2"></td>
                <td class="auto-style3"></td>
                <td style="height: 61px; width: 88px;"></td>
                <td style="height: 61px; width: 88px;"></td>
                <td style="height: 61px; width: 88px;"></td>
                <td style="height: 61px; width: 88px;"></td>
                <td style="height: 61px; width: 88px;"></td>
                <td style="height: 61px; width: 88px;"></td>
                <td style="height: 61px"></td>
            </tr>
            <tr>
                <td style="height: 45px; width: 108px;"></td>
                <td style="width: 62px;" rowspan="2">&nbsp;</td>
                <td style="width: 24px;" rowspan="2"></td>
                 <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A22"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=111-1(A)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="111-1(A)"  />
                       </a>

                 </td>
                <td style="height: 45px; width: 88px;">
                         <a id="A30"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=112-1(A)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="112-1(A)"  />
                       </a>
                </td>
                 <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A24"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=112-5(D)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="112-5(D)"  />
                       </a>

                 </td>
                <td style="height: 45px; " colspan="2">
                             <a id="A40"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=113-1(A)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="113-1(A)" />
                       </a>
                </td>
               <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A38"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=113-3(C)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="113-3(C)"  />
                       </a>


                </td>
                <td style="height: 45px; width: 88px;"></td>
                <td style="height: 45px; width: 88px;"></td>
                <td style="height: 45px; width: 88px;">
                           <a id="A31"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=102-1(A)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="102-1(A)"  />
                       </a>
                </td>
                    <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A25"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=102-5(D)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="102-5(D)"  />
                       </a>


                </td>
                <td style="height: 45px; width: 88px;"></td>
                        <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A28"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=103-1(A)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="103-1(A)"  />
                       </a>

                </td>
                <td style="height: 45px"></td>
            </tr>
            <tr>
                <td style="height: 45px; width: 108px;"></td>
                 <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A23"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=111-2(B)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="111-1(B)"  />
                       </a>

                 </td>
                <td style="height: 45px; width: 88px;">
                           <a id="A32"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=112-2(B)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="112-2(B)"  />
                       </a>
                </td>
                 <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A26"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=112-6(E)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="112-6(E)"  />
                       </a>

                </td>
                <td style="height: 45px; " colspan="2">
                             <a id="A41"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=113-2(B)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="113-2(B)" />
                       </a>
                </td>
                <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A37"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=113-5(D)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="113-5(D)"  />
                       </a>

                </td>
                <td style="height: 45px; width: 88px;"></td>
                <td style="height: 45px; width: 88px;"></td>
                <td style="height: 45px; width: 88px;">
                            <a id="A33"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=102-2(B)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="102-2(B)"  />
                       </a>
                </td>
                    <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A27"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=102-6(E)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="102-6(E)"  />
                       </a>
                </td>
                <td style="height: 45px; width: 88px;"></td>
                   <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A29"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=103-2(B)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="103-2(B)"  />
                       </a>
                </td>
                <td style="height: 45px"></td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 108px; height: 45px;"></td>
                <td style="height: 45px; " colspan="2"></td>
                <td style="width: 88px; height: 45px"></td>
                <td style="width: 88px; height: 45px;">
                            <a id="A34"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=112-3(C)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="112-3(C)"  />
                       </a>
                </td>
                <td style="width: 88px; height: 45px"></td>
                <td style="height: 45px" colspan="2"></td>
                 <td style="height: 45px; width: 88px;text-align:right">
                         <a id="A39"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=113-6(E)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="113-6(E)"  />
                       </a>


                </td>
                <td style="width: 88px; height: 45px"></td>
                <td style="width: 88px; height: 45px"></td>
                <td style="width: 88px; height: 45px">
                            <a id="A35"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=102-3(C)"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="102-3(C)"  />
                       </a>
                </td>
                <td style="width: 88px; height: 45px"></td>
                <td style="width: 88px; height: 45px"></td>
                <td style="height: 45px; width: 88px;"></td>
                <td style="height: 45px"></td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 108px; height: 117px;"></td>
                <td style="height: 117px;" colspan="2"></td>
                <td style="width: 88px; height: 117px;"></td>
                <td style="width: 88px; height: 117px;"></td>
                <td style="width: 88px; height: 117px"></td>
                <td style="height: 117px" colspan="2"></td>
                <td class="auto-style4"></td>
                <td style="width: 88px; height: 117px"></td>
                <td style="width: 88px; height: 117px"></td>
                <td style="width: 88px; height: 117px"></td>
                <td style="width: 88px; height: 117px"></td>
                <td style="width: 88px; height: 117px"></td>
                <td style="height: 117px; width: 88px;"></td>
                <td style="height: 117px"></td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 108px; " rowspan="2"></td>
                <td colspan="4" rowspan="3">
                    <asp:Image ID="Image1" runat="server" Height="30px" ImageUrl="~/pic/床位照片/床位1 -白.jpg" Width="70px" />
                    &nbsp;<span class="auto-style7">空白床位:</span>&nbsp;
                    <asp:Label ID="lbl_W" runat="server" style="font-size: 20pt" Text="Label"></asp:Label>
                    人<br /> 
                    <br />
                    <br />
                    <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/pic/床位照片/床位1 -綠.jpg" Width="70px" />
                    <span class="auto-style7">有人床位:</span>&nbsp;
                    <asp:Label ID="lbl_G" runat="server" style="font-size: 20pt" Text="Label"></asp:Label>
                    人<br /> 
                    <br />
                    <br />
                    <asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/pic/床位照片/床位1 -藍.jpg" Width="70px" />
                    <span class="auto-style7">住院人數:</span>&nbsp;
                    <asp:Label ID="lbl_B" runat="server" style="font-size: 20pt" Text="Label"></asp:Label>
                    人</td>
                <td style="width: 88px; " rowspan="2"></td>
                <td style="width: 38px; " rowspan="2"></td>
                <td style="width: 50px; " rowspan="2"></td>
                <td rowspan="2" class="auto-style5">
                            <a id="A36"  runat="server"  
                         href="BS_床位編輯.aspx?f床號=101"
                         data-toggle="modal"   data-target="#myModal"
                                 >          
                             <asp:Button runat="server" Height="30px" Width="70px"  ToolTip="101"  />
                       </a>
                </td>
                <td style="width: 88px; " rowspan="2"></td>
                <td style="width: 88px; " rowspan="2"></td>
                <td style="height: 1px" colspan="2"></td>
                <td style="width: 88px; " rowspan="2"></td>
                <td style="width: 88px;" rowspan="2"></td>
                <td rowspan="2"></td>
            </tr>
            <tr>
                <td style="height: 68px" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 108px; height: 166px;"></td>
                <td style="width: 88px; height: 166px"></td>
                <td style="height: 166px" colspan="2"></td>
                <td class="auto-style6"></td>
                <td style="width: 88px; height: 166px"></td>
                <td style="width: 88px; height: 166px"></td>
                <td style="width: 88px; height: 166px"></td>
                <td style="width: 88px; height: 166px"></td>
                <td style="width: 88px; height: 166px"></td>
                <td style="height: 166px; width: 88px;"></td>
                <td style="height: 166px">&nbsp;</td>
            </tr>
        </table>
    </div>
    </asp:Panel>
</asp:Content>
