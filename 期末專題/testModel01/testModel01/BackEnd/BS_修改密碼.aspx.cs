using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testModel01.BackEnd
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_change_Click(object sender, EventArgs e)
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
                string str_temp = dn["f帳號"].ToString();
                if (TBox_pw0.Text == (dn["f密碼"].ToString()))
                {

                    if (TBox_pw2.Text == TBox_pw1.Text && !string.IsNullOrEmpty(TBox_pw1.Text))
                    {
                        sds.UpdateCommand= "update  T後台登入系統  set f密碼=@新密碼"
                            +" where f帳號=@帳號";
                        sds.UpdateParameters.Add("新密碼", TBox_pw1.Text);
                        sds.UpdateParameters.Add("帳號",str_temp);
                        sds.Update();
                        Session["login"] = null;
                        Response.Write("<script>alert('已修改密碼，請重新登入')</script>");    
                    }
                    else
                    {
                        // 密碼不同錯誤
                        Response.Write("<script>alert('確認密碼欄位有錯，請重新輸入')</script>");                   
                        return;
                    }
                }
                else
                {
                    Response.Write("<script>alert('密碼，請重新輸入')</script>");
                    //Response.Redirect(@"/./Login.aspx");
                }
            }
            catch (ArgumentException nex)
            {
                //顯示查無帳號
                Response.Write("<script>alert('請重新輸入')</script>");
                dn = null;
                return;
            }

        }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            TBox_pw0.Text = TBox_pw2.Text = TBox_pw1.Text = "";
        }

    }
}