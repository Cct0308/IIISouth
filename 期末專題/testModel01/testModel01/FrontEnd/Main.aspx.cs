using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testModel01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string str_Data_Source = WebConfigurationManager.OpenWebConfiguration("/testModel01").ConnectionStrings.ConnectionStrings["dbKSYYConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            Initial_loadpageAD();
            Initial_loadpageNews();             
        }

        private void Initial_loadpageAD()
        {
            Literal ltlCarouselAD = (Literal)home.FindControl("ltlCarouselAD");
            String strCarouselAD = "";
            int countAD = 0;

            SqlDataSource sds_carousel = new SqlDataSource();
            sds_carousel.DataSourceMode = SqlDataSourceMode.DataReader;
            sds_carousel.ConnectionString = str_Data_Source;
            sds_carousel.SelectCommand = "SELECT fId, fPic, fFirst, fSecond, fThird from t前台輪播";
            System.Data.SqlClient.SqlDataReader sdr輪播 = (System.Data.SqlClient.SqlDataReader)sds_carousel.Select(DataSourceSelectArguments.Empty);

            if (sdr輪播.HasRows)
            {
                while (sdr輪播.Read())
                {
                    countAD++;

                    if(countAD == 1)
                    {
                        strCarouselAD += "<div class='item active'>";
                        strCarouselAD += "<img class='img-responsive' src='" + sdr輪播["fPic"].ToString() + "' alt='slider' style='width:1600px;height:300px' />";
                        strCarouselAD += "<div class='slider-content'>";
                        strCarouselAD += "<div class='col-md-12 text-center'>";
                        strCarouselAD += "<h3 class='animated2 white'>";
                        strCarouselAD += "<span><strong>" + sdr輪播["fFirst"].ToString() + "</strong>" + sdr輪播["fSecond"].ToString() + "</span>";
                        strCarouselAD += "</h3><br />";
                        strCarouselAD += "<h4 class='animated3'>";
                        strCarouselAD += "<span>" + sdr輪播["fThird"].ToString() + "</span></h4></div></div></div>";
                    }

                    if (countAD == 2)
                    {
                        strCarouselAD += "<div class='item'>";
                        strCarouselAD += "<img class='img-responsive' src='" + sdr輪播["fPic"].ToString() + "' alt='slider' style='width:1600px;height:300px' />";
                        strCarouselAD += "<div class='slider-content'>";
                        strCarouselAD += "<div class='col-md-12 text-center'>";
                        strCarouselAD += "<h3 class='animated4 white'>";
                        strCarouselAD += "<span><strong>" + sdr輪播["fFirst"].ToString() + "</strong>" + sdr輪播["fSecond"].ToString() + "</span>";
                        strCarouselAD += "</h3><br />";
                        strCarouselAD += "<h4 class='animated5'>";
                        strCarouselAD += "<span>" + sdr輪播["fThird"].ToString() + "</span></h4></div></div></div>";
                    }

                    if (countAD == 3)
                    {
                        strCarouselAD += "<div class='item'>";
                        strCarouselAD += "<img class='img-responsive' src='" + sdr輪播["fPic"].ToString() + "' alt='slider' style='width:1600px;height:300px' />";
                        strCarouselAD += "<div class='slider-content'>";
                        strCarouselAD += "<div class='col-md-12 text-center'>";
                        strCarouselAD += "<h3 class='animated7 white'>";
                        strCarouselAD += "<span><strong>" + sdr輪播["fFirst"].ToString() + "</strong>" + sdr輪播["fSecond"].ToString() + "</span>";
                        strCarouselAD += "</h3><br />";
                        strCarouselAD += "<h4 class='animated8'>";
                        strCarouselAD += "<span>" + sdr輪播["fThird"].ToString() + "</span></h4></div></div></div>";
                    }
                }
            }

            ltlCarouselAD.Text = strCarouselAD;
        }

        private void Initial_loadpageNews()
        {
            Literal ltlLatestNews = (Literal)formMainNews.FindControl("ltlLatestNews");
            String strLatestNewsSub = "";

            System.Data.SqlClient.SqlDataReader sdrLatestNews = (System.Data.SqlClient.SqlDataReader)SqlDataSourceNews.Select(DataSourceSelectArguments.Empty);
            if (sdrLatestNews.HasRows)
            {
                while (sdrLatestNews.Read())
                {
                    strLatestNewsSub += "<div class='post-row item'>";
                    strLatestNewsSub += "<div class='left-meta-post'>";
                    strLatestNewsSub += "<div class='post-type'><i class='fa'><span  style='font-size:14px;font-weight:bold;'>" + sdrLatestNews["fYear"].ToString() + "</span></i></div>";
                    strLatestNewsSub += "<div class='post-date' style='font-weight:bold;'><span class='month'>" + sdrLatestNews["fMonth"].ToString() + "</span><span class='month'>" + sdrLatestNews["fDay"].ToString() + "</span></div>";
                    strLatestNewsSub += "</div>";
                    strLatestNewsSub += "<h3 class='post-title'><a href='/./FrontEnd/最新消息內容.aspx?fid=" + sdrLatestNews["fid"].ToString() + "'>";
                    strLatestNewsSub += sdrLatestNews["fSubject"].ToString() + "</a></h3>";
                    strLatestNewsSub += "<div class='post-content'>";
                    strLatestNewsSub += "<p>";
                    strLatestNewsSub += sdrLatestNews["fPreview"].ToString() + "<br/><a class='read-more' href='/./FrontEnd/最新消息內容.aspx?fid=" + sdrLatestNews["fid"].ToString() + "'>Read More...</a>";
                    strLatestNewsSub += "</p>";
                    strLatestNewsSub += "</div>";
                    strLatestNewsSub += "<div class='hr1 margin-60'></div>";
                    strLatestNewsSub += "</div>";
                }
            }

            ltlLatestNews.Text = strLatestNewsSub;
        }
    }
}