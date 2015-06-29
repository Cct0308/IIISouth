using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testModel01
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        // string str_Data_Source = @"CCT-PC\SQLEXPRESS";
        string str_Data_Source = WebConfigurationManager.OpenWebConfiguration("/testModel01").ConnectionStrings.ConnectionStrings["dbKSYYConnectionString"].ConnectionString;
        // string str_Data_Source = @"CR4-17\MSSQLSERVER2013";//資策
        // string str_Data_Source = @"SHAWN-PC";//家3
        // string str_Data_Source = @"WIN-R56ALTBAKPC\SQLEXPRESS";//家2               

        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlDataSource sds_outlook = new SqlDataSource();
            //sds_outlook.ConnectionString = "Data Source=" + str_Data_Source + ";Initial Catalog=dbKSYY;Integrated Security=True";
            //sds_outlook.SelectCommand = "SELECT fid,f庭院照片_s,f庭院照片_l from  T康欣_活動剪影 WHERE f庭院照片_s IS NOT NULL";
            //ListView_outlook.DataSource = sds_outlook.Select(DataSourceSelectArguments.Empty);
            //ListView_outlook.DataBind();

            //SqlDataSource sds_inside = new SqlDataSource();
            //sds_inside.ConnectionString = "Data Source=" + str_Data_Source + ";Initial Catalog=dbKSYY;Integrated Security=True";
            //sds_inside.SelectCommand = "SELECT fid,f內部照片_s,f內部照片_l from  T康欣_活動剪影 WHERE f內部照片_s IS NOT NULL";
            //ListView_inside.DataSource = sds_inside.Select(DataSourceSelectArguments.Empty);
            //ListView_inside.DataBind();

            //SqlDataSource sds_birthday = new SqlDataSource();
            //sds_birthday.ConnectionString = "Data Source=" + str_Data_Source + ";Initial Catalog=dbKSYY;Integrated Security=True";
            //sds_birthday.SelectCommand = "SELECT fid,f慶生照片_s,f慶生照片_l from  T康欣_活動剪影 WHERE f慶生照片_s IS NOT NULL";
            //ListView_birthday.DataSource = sds_birthday.Select(DataSourceSelectArguments.Empty);
            //ListView_birthday.DataBind();

            //SqlDataSource sds_washfoot = new SqlDataSource();
            //sds_washfoot.ConnectionString = "Data Source=" + str_Data_Source + ";Initial Catalog=dbKSYY;Integrated Security=True";
            //sds_washfoot.SelectCommand = "SELECT fid,f泡腳照片_s,f泡腳照片_l from  T康欣_活動剪影 WHERE f泡腳照片_s IS NOT NULL";
            //ListView_washfoot.DataSource = sds_washfoot.Select(DataSourceSelectArguments.Empty);
            //ListView_washfoot.DataBind();

            //SqlDataSource sds_rehab = new SqlDataSource();
            //sds_rehab.ConnectionString = "Data Source=" + str_Data_Source + ";Initial Catalog=dbKSYY;Integrated Security=True";
            //sds_rehab.SelectCommand = "SELECT fid,f復健照片_s,f復健照片_l from  T康欣_活動剪影 WHERE f復健照片_s IS NOT NULL";
            //ListView_rehab.DataSource = sds_rehab.Select(DataSourceSelectArguments.Empty);
            //ListView_rehab.DataBind();

            //SqlDataSource sds_cuthair = new SqlDataSource();
            //sds_cuthair.ConnectionString = "Data Source=" + str_Data_Source + ";Initial Catalog=dbKSYY;Integrated Security=True";
            //sds_cuthair.SelectCommand = "SELECT fid,f義剪照片_s,f義剪照片_l from  T康欣_活動剪影 WHERE f義剪照片_s IS NOT NULL";
            //ListView_cuthair.DataSource = sds_cuthair.Select(DataSourceSelectArguments.Empty);
            //ListView_cuthair.DataBind();

            Initial_loadpage();
        }

        public void Initial_loadpage()
        {
            Literal ltlLatestPicts = (Literal)formpicts.FindControl("ltlLatestPicts");
            String strLatestPicts = "";

            SqlDataSource sds_outlook = new SqlDataSource();
            sds_outlook.DataSourceMode = SqlDataSourceMode.DataReader;
            //sds_outlook.ConnectionString = "Data Source=" + str_Data_Source + ";Initial Catalog=dbKSYY;Integrated Security=True";
            sds_outlook.ConnectionString = str_Data_Source;
            sds_outlook.SelectCommand = "SELECT fid,f庭院照片_s,f庭院照片_l from  T康欣_活動剪影 WHERE f庭院照片_s IS NOT NULL";
            System.Data.SqlClient.SqlDataReader sdr庭院 = (System.Data.SqlClient.SqlDataReader)sds_outlook.Select(DataSourceSelectArguments.Empty);

            SqlDataSource sds_inside = new SqlDataSource();
            sds_inside.DataSourceMode = SqlDataSourceMode.DataReader;
            //sds_inside.ConnectionString = "Data Source=" + str_Data_Source + ";Initial Catalog=dbKSYY;Integrated Security=True";
            sds_inside.ConnectionString = str_Data_Source;
            sds_inside.SelectCommand = "SELECT fid,f內部照片_s,f內部照片_l from  T康欣_活動剪影 WHERE f內部照片_s IS NOT NULL";
            System.Data.SqlClient.SqlDataReader sdr內部 = (System.Data.SqlClient.SqlDataReader)sds_inside.Select(DataSourceSelectArguments.Empty);

            SqlDataSource sds_birthday = new SqlDataSource();
            sds_birthday.DataSourceMode = SqlDataSourceMode.DataReader;
            //sds_birthday.ConnectionString = "Data Source=" + str_Data_Source + ";Initial Catalog=dbKSYY;Integrated Security=True";
            sds_birthday.ConnectionString = str_Data_Source;
            sds_birthday.SelectCommand = "SELECT fid,f慶生照片_s,f慶生照片_l from  T康欣_活動剪影 WHERE f慶生照片_s IS NOT NULL";
            System.Data.SqlClient.SqlDataReader sdr慶生 = (System.Data.SqlClient.SqlDataReader)sds_birthday.Select(DataSourceSelectArguments.Empty);

            SqlDataSource sds_washfoot = new SqlDataSource();
            sds_washfoot.DataSourceMode = SqlDataSourceMode.DataReader;
            //sds_washfoot.ConnectionString = "Data Source=" + str_Data_Source + ";Initial Catalog=dbKSYY;Integrated Security=True";
            sds_washfoot.ConnectionString = str_Data_Source;
            sds_washfoot.SelectCommand = "SELECT fid,f泡腳照片_s,f泡腳照片_l from  T康欣_活動剪影 WHERE f泡腳照片_s IS NOT NULL";
            System.Data.SqlClient.SqlDataReader sdr泡腳 = (System.Data.SqlClient.SqlDataReader)sds_washfoot.Select(DataSourceSelectArguments.Empty);

            SqlDataSource sds_rehab = new SqlDataSource();
            sds_rehab.DataSourceMode = SqlDataSourceMode.DataReader;
            //sds_rehab.ConnectionString = "Data Source=" + str_Data_Source + ";Initial Catalog=dbKSYY;Integrated Security=True";
            sds_rehab.ConnectionString = str_Data_Source;
            sds_rehab.SelectCommand = "SELECT fid,f復健照片_s,f復健照片_l from  T康欣_活動剪影 WHERE f復健照片_s IS NOT NULL";
            System.Data.SqlClient.SqlDataReader sdr復健 = (System.Data.SqlClient.SqlDataReader)sds_rehab.Select(DataSourceSelectArguments.Empty);

            SqlDataSource sds_cuthair = new SqlDataSource();
            sds_cuthair.DataSourceMode = SqlDataSourceMode.DataReader;
            //sds_cuthair.ConnectionString = "Data Source=" + str_Data_Source + ";Initial Catalog=dbKSYY;Integrated Security=True";
            sds_cuthair.ConnectionString = str_Data_Source;
            sds_cuthair.SelectCommand = "SELECT fid,f義剪照片_s,f義剪照片_l from  T康欣_活動剪影 WHERE f義剪照片_s IS NOT NULL";
            System.Data.SqlClient.SqlDataReader sdr義剪 = (System.Data.SqlClient.SqlDataReader)sds_cuthair.Select(DataSourceSelectArguments.Empty);

            SqlDataSource sds_other = new SqlDataSource();
            sds_other.DataSourceMode = SqlDataSourceMode.DataReader;
            //sds_other.ConnectionString = "Data Source=" + str_Data_Source + ";Initial Catalog=dbKSYY;Integrated Security=True";
            sds_other.ConnectionString = str_Data_Source;
            sds_other.SelectCommand = "SELECT fid,f其他活動_s,f其他活動_l from  T康欣_活動剪影 WHERE f其他活動_s IS NOT NULL";
            System.Data.SqlClient.SqlDataReader sdr其他 = (System.Data.SqlClient.SqlDataReader)sds_other.Select(DataSourceSelectArguments.Empty);

            if (sdr庭院.HasRows)
            {
                while (sdr庭院.Read())
                {
                    strLatestPicts += "<div class='element transition outlook' data-category='transition'>";
                    strLatestPicts += "<a href='" + sdr庭院["f庭院照片_s"].ToString() + "' class='thumb'>";
                    strLatestPicts += "<figure class='img-polaroid'>";
                    strLatestPicts += "<img src='" + sdr庭院["f庭院照片_s"].ToString() + "' alt='' style='width:270px;height:190px'>";
                    strLatestPicts += "</figure>";
                    strLatestPicts += "</a><span class='description'>" + sdr庭院["f庭院照片_l"].ToString() + "</span>";
                    strLatestPicts += "</div>";

                    if (sdr內部.HasRows)
                    {
                        while (sdr內部.Read())
                        {
                            strLatestPicts += "<div class='element transition inside' data-category='transition'>";
                            strLatestPicts += "<a href='" + sdr內部["f內部照片_s"].ToString() + "' class='thumb'>";
                            strLatestPicts += "<figure class='img-polaroid'>";
                            strLatestPicts += "<img src='" + sdr內部["f內部照片_s"].ToString() + "' alt='' style='width:270px;height:190px'>";
                            strLatestPicts += "</figure>";
                            strLatestPicts += "</a><span class='description'>" + sdr內部["f內部照片_l"].ToString() + "</span>";
                            strLatestPicts += "</div>";

                            if (sdr慶生.HasRows)
                            {
                                while (sdr慶生.Read())
                                {
                                    strLatestPicts += "<div class='element transition birthday' data-category='transition'>";
                                    strLatestPicts += "<a href='" + sdr慶生["f慶生照片_s"].ToString() + "' class='thumb'>";
                                    strLatestPicts += "<figure class='img-polaroid'>";
                                    strLatestPicts += "<img src='" + sdr慶生["f慶生照片_s"].ToString() + "' alt='' style='width:270px;height:190px'>";
                                    strLatestPicts += "</figure>";
                                    strLatestPicts += "</a><span class='description'>" + sdr慶生["f慶生照片_l"].ToString() + "</span>";
                                    strLatestPicts += "</div>";

                                    if (sdr泡腳.HasRows)
                                    {
                                        while (sdr泡腳.Read())
                                        {
                                            strLatestPicts += "<div class='element transition washfoot' data-category='transition'>";
                                            strLatestPicts += "<a href='" + sdr泡腳["f泡腳照片_s"].ToString() + "' class='thumb'>";
                                            strLatestPicts += "<figure class='img-polaroid'>";
                                            strLatestPicts += "<img src='" + sdr泡腳["f泡腳照片_s"].ToString() + "' alt='' style='width:270px;height:190px'>";
                                            strLatestPicts += "</figure>";
                                            strLatestPicts += "</a><span class='description'>" + sdr泡腳["f泡腳照片_l"].ToString() + "</span>";
                                            strLatestPicts += "</div>";

                                            if (sdr復健.HasRows)
                                            {
                                                while (sdr復健.Read())
                                                {
                                                    strLatestPicts += "<div class='element transition rehab' data-category='transition'>";
                                                    strLatestPicts += "<a href='" + sdr復健["f復健照片_s"].ToString() + "' class='thumb'>";
                                                    strLatestPicts += "<figure class='img-polaroid'>";
                                                    strLatestPicts += "<img src='" + sdr復健["f復健照片_s"].ToString() + "' alt='' style='width:270px;height:190px'>";
                                                    strLatestPicts += "</figure>";
                                                    strLatestPicts += "</a><span class='description'>" + sdr復健["f復健照片_l"].ToString() + "</span>";
                                                    strLatestPicts += "</div>";

                                                    if (sdr義剪.HasRows)
                                                    {
                                                        while (sdr義剪.Read())
                                                        {
                                                            strLatestPicts += "<div class='element transition cuthair' data-category='transition'>";
                                                            strLatestPicts += "<a href='" + sdr義剪["f義剪照片_s"].ToString() + "' class='thumb'>";
                                                            strLatestPicts += "<figure class='img-polaroid'>";
                                                            strLatestPicts += "<img src='" + sdr義剪["f義剪照片_s"].ToString() + "' alt='' style='width:270px;height:190px'>";
                                                            strLatestPicts += "</figure>";
                                                            strLatestPicts += "</a><span class='description'>" + sdr義剪["f義剪照片_l"].ToString() + "</span>";
                                                            strLatestPicts += "</div>";

                                                            if (sdr其他.HasRows)
                                                            {
                                                                while (sdr其他.Read())
                                                                {
                                                                    strLatestPicts += "<div class='element transition other' data-category='transition'>";
                                                                    strLatestPicts += "<a href='" + sdr其他["f其他活動_s"].ToString() + "' class='thumb'>";
                                                                    strLatestPicts += "<figure class='img-polaroid'>";
                                                                    strLatestPicts += "<img src='" + sdr其他["f其他活動_s"].ToString() + "' alt='' style='width:270px;height:190px'>";
                                                                    strLatestPicts += "</figure>";
                                                                    strLatestPicts += "</a><span class='description'>" + sdr其他["f其他活動_l"].ToString() + "</span>";
                                                                    strLatestPicts += "</div>";
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            ltlLatestPicts.Text = strLatestPicts;
        }
    }
}