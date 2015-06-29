using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testModel01.BackEnd
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Substring(32,11);
            string str_Data_Source = WebConfigurationManager.OpenWebConfiguration("/testModel01").ConnectionStrings.ConnectionStrings["dbKSYYConnectionString"].ConnectionString;
            SqlDataSource sds = new SqlDataSource();
            sds.ConnectionString = str_Data_Source;
            sds.InsertCommand = "insert into tUrl (fUrl,fSubject) values (@url,@subject)";
            sds.InsertParameters.Add("url",url);
            sds.InsertParameters.Add("subject",txtSubject.Text);
            sds.Insert();

            Response.Redirect(@"/./BackEnd/BS_編輯影片.aspx");
        }
    }
}