using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testModel01
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["login"] != null)
            {
                if (Session["login"].ToString() == "已登入")
                    Response.Redirect(@"BackEnd\BS_關於康欣.aspx");
            }
            //cookie 記住我

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TBox_id.Text = TBox_pw.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str_Data_Source = WebConfigurationManager.OpenWebConfiguration("/testModel01").ConnectionStrings.ConnectionStrings["dbKSYYConnectionString"].ConnectionString;//家2
            System.Data.SqlClient.SqlDataReader dn;

            try
            {
                SqlDataSource sds = new SqlDataSource();
                sds.DataSourceMode = SqlDataSourceMode.DataReader;
                sds.ConnectionString = str_Data_Source;
                sds.SelectCommand = "SELECT * from  T後台登入系統 ";
                dn = (System.Data.SqlClient.SqlDataReader)sds.Select(DataSourceSelectArguments.Empty);
                dn.Read();
                if (TBox_id.Text == (dn["f帳號"].ToString()))
                {                   
                        if (TBox_pw.Text == dn["f密碼"].ToString())
                        {
                            Session["login"] = "已登入";
                            dn = null;
                            Response.Redirect(@"BackEnd\BS_關於康欣.aspx");
                        }
                        else
                        {
                            // 顯示密碼錯誤
                            Response.Write("<script>alert('密碼錯誤，請重新輸入')</script>");
                            dn = null;
                            return;
                        }                    
                }
                else
                {
                    Response.Write("<script>alert('帳號錯誤，請重新輸入')</script>");
                    //Response.Redirect(@"/./Login.aspx");
                }
            }
            catch (ArgumentException nex)
            {
                //顯示查無帳號
                Response.Write("<script>alert('查無此帳號，請重新輸入')</script>");
                dn = null;
                return;
            }


        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testModel01
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["login"] != null)
            {
                if (Session["login"].ToString() == "已登入")
                    Response.Redirect(@"BackEnd\BS_關於康欣.aspx");
            }
            //cookie 記住我

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TBox_id.Text = TBox_pw.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str_Data_Source = WebConfigurationManager.OpenWebConfiguration("/testModel01").ConnectionStrings.ConnectionStrings["dbKSYYConnectionString"].ConnectionString;//家2
            DataView dn;

            try
            {
                SqlDataSource sds = new SqlDataSource();
                sds.ConnectionString = str_Data_Source;
                sds.SelectCommand = "SELECT f密碼 from  T後台登入系統 WHERE f帳號 ='" + TBox_id.Text + "'";
                dn = (DataView)sds.Select(DataSourceSelectArguments.Empty);
                if (TBox_pw.Text == dn[0]["f密碼"].ToString())
                {
                    Session["login"] = "已登入";
                    dn = null;
                    Response.Redirect(@"BackEnd\BS_關於康欣.aspx");
                }
                else
                {
                    // 顯示密碼錯誤
                    Response.Write("<script>alert('密碼錯誤，請重新輸入')</script>");
                    dn = null;
                    return;
                }

            }
            catch (ArgumentException nex)
            {
                //顯示查無帳號
                Response.Write("<script>alert('查無此帳號，請重新輸入')</script>");
                dn = null;
                return;
            }
        

        }
    }
}*/