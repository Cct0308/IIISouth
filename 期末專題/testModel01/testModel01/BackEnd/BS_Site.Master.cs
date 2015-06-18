using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testModel01
{
    public partial class BS_Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"]==null || (Session["login"].ToString() != "已登入"))
                {
                    Response.Redirect(@"..\Login.aspx");
                }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["login"] = null;
            Response.Redirect(@"..\FrontEnd\Main.aspx");
        }
    }
}