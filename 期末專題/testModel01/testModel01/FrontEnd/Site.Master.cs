using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testModel01
{
    public partial class Site : System.Web.UI.MasterPage
    {
        string str_Data_Source = WebConfigurationManager.OpenWebConfiguration("/testModel01").ConnectionStrings.ConnectionStrings["dbKSYYConnectionString"].ConnectionString;

        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // 下面的程式碼有助於防禦 XSRF 攻擊
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // 使用 Cookie 中的 Anti-XSRF 權杖
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // 產生新的防 XSRF 權杖並儲存到 cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // 設定 Anti-XSRF 權杖
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // 驗證 Anti-XSRF 權杖
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Anti-XSRF 權杖驗證失敗。");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Initial_loadConnect();
        }

        private void Initial_loadConnect()
        {
            Literal ltlConnect = (Literal)connect.FindControl("ltlConnect");
            String strConnect = "";
            SqlDataSource sds_connect = new SqlDataSource();
            sds_connect.DataSourceMode = SqlDataSourceMode.DataReader;
            sds_connect.ConnectionString = str_Data_Source;
            sds_connect.SelectCommand = "SELECT * from  t連結";
            System.Data.SqlClient.SqlDataReader sdr連結 = (System.Data.SqlClient.SqlDataReader)sds_connect.Select(DataSourceSelectArguments.Empty);

            if (sdr連結.HasRows)
            {
                while (sdr連結.Read())
                {
                    strConnect += "<div class='client-item item'>";
                    strConnect += "<a href='" + sdr連結["fConnection"].ToString() + "'>";
                    strConnect += "<img src='" + sdr連結["fPic"].ToString() + "' alt='" + sdr連結["fName"].ToString() + "'/></a></div>";

                }
            }
            ltlConnect.Text = strConnect;
        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            //Context.GetOwinContext().Authentication.SignOut();
        }
    }
}