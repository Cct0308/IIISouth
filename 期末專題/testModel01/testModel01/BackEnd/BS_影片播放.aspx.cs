using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testModel01.BackEnd
{
    public partial class BS_影片播放 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            //Response.Write("alert('132')");
            //Response.Write("<script>window.opener.location.href='/./BackEnd/BS_編輯影片.aspx';window.close();</script>");
            //Response.Redirect(@"/./BackEnd/BS_編輯影片.aspx");
            Response.Redirect(this.Page.Request.UrlReferrer.ToString());
        }
    }
}