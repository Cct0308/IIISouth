using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testModel01.FrontEnd
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string str_Data_Source = WebConfigurationManager.OpenWebConfiguration("/testModel01").ConnectionStrings.ConnectionStrings["dbKSYYConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            Initial_loadpageVideo();
        }

        private void Initial_loadpageVideo()
        {
            Literal ltlVideo = (Literal)formvideo.FindControl("ltlVideo");
            String strVideoSub = "";

            System.Data.SqlClient.SqlDataReader sdrVideo = (System.Data.SqlClient.SqlDataReader)SqlDataSourceVideo.Select(DataSourceSelectArguments.Empty);
            if (sdrVideo.HasRows)
            {
                while (sdrVideo.Read())
                {
                    strVideoSub += "<div class='portfolio-item item'>";
                    strVideoSub += "<div class='portfolio-border'>";
                    strVideoSub += "<div class='portfolio-thumb'>";
                    strVideoSub += "<a class='lightbox' data-lightbox-type='ajax' href='https://www.youtube.com/watch?v=";
                    strVideoSub += sdrVideo["fUrl"].ToString() + "'>";
                    strVideoSub += "<div class='thumb-overlay'><i class='fa fa-play'></i></div>";
                    strVideoSub += "<img alt='' src='http://img.youtube.com/vi/" + sdrVideo["fUrl"].ToString() + "/0.jpg'" + "/>";
                    strVideoSub += "</a>";
                    strVideoSub += "</div>";
                    strVideoSub += "<div class='portfolio-details'>";
                    strVideoSub += "<a href='#'>";
                    strVideoSub += "<h4>" + sdrVideo["fSubject"].ToString() + "</h4>";
                    //strVideoSub += "<span>test</span>";
                    //strVideoSub += "<span>test</span>";
                    strVideoSub += "</a>";
                    strVideoSub += "</div>";
                    strVideoSub += "</div>";
                    strVideoSub += "</div>";
                }
            }

            ltlVideo.Text = strVideoSub;
        }
    }
}