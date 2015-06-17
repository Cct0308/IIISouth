using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testModel01.BackEnd
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn第一張圖_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("..");
            FileUpload1.SaveAs(path + @"\headImg\1.jpg");
        }

        protected void btn第三張圖_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("..");
            FileUpload3.SaveAs(path + @"\headImg\3.jpg");
        }

        protected void btn第二張圖_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("..");
            FileUpload2.SaveAs(path + @"\headImg\2.jpg");
        }
    }
}