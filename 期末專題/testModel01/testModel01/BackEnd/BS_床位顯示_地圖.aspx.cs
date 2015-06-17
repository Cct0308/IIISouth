using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testModel01.BackEnd
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        //string str_Data_Source = @"CCT-PC\SQLEXPRESS";
       // string str_Data_Source = @"CR4-06\MSSQLSERVER2013";
        //string str_Data_Source = @"CR4-11\MSSQLSERVER2013";//資策
        // string str_Data_Source = @"SHAWN-PC";//家3
       //string str_Data_Source = @"WIN-R56ALTBAKPC\SQLEXPRESS";//家2               
        string str_Data_Source = WebConfigurationManager.OpenWebConfiguration("/testModel01").ConnectionStrings.ConnectionStrings["dbKSYYConnectionString"].ConnectionString;
        int[] intA_member = new int[3];
         public List<Button> listbtn = new List<Button>();
         string[][] stra ;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            m_initial();
        }

        private void m_initial()
        {
            intA_member[0] = intA_member[1] = intA_member[2] = 0;
            SqlDataSource sds = new SqlDataSource();
            //sds.ConnectionString = "Data Source=" + str_Data_Source + ";Initial Catalog=dbKSYY;Integrated Security=True";
            sds.ConnectionString = str_Data_Source;
            sds.SelectCommand = "SELECT * from  T床位系統 WHERE f姓名 IS NOT NULL";

            DataView dn=(DataView)sds.Select(DataSourceSelectArguments.Empty);
            stra = new string[3][];
            stra[0] = new string[dn.Count];
            stra[1] = new string[dn.Count];
            stra[2] = new string[dn.Count];
            for (int a = 0; a < dn.Count; a++)
            {
                stra[0][a] = dn[a]["f床號"].ToString();                 
                stra[1][a] = dn[a]["f姓名"].ToString();
                stra[2][a] = dn[a]["f是否住院中"].ToString();
            }
                m_FindControlRecursive(Panel1, typeof(Button));
                m_ShowMember();
        }

       
        public void m_FindControlRecursive(Control root, Type type)
        {
            int a=0;
          
                if (root.GetType() == type)
                {
                    Button c = ((Button)root);
                    try
                    {
                        for (a = 0; a < stra[0].GetLength(0); a++)
                        {
                            if (c.ToolTip.ToString() == stra[0][a].ToString())
                            {
                                if (stra[2][a].ToString() == "1")
                                    m_setbtnH(c, stra[1][a]);
                                else
                                    m_setbtn(c, stra[1][a]);
                                break;
                            }
                        }
                        if (a == stra[0].GetLength(0))
                        { m_setbtnwhite(c); }                   
                    }
                    catch (Exception ddd)
                    {
                        m_setbtnwhite(c);
                    }
                }
            
            foreach (Control c in root.Controls)
                m_FindControlRecursive(c, type);
            }

        private void m_setbtn(Button c ,string name)
        {
            c.CssClass = "mybtnG";
            c.Text = name;
            intA_member[1]++;
        }

        private void m_setbtnH(Button c , string name)
        {
            c.CssClass = "mybtnB";
            c.Text = name;
            intA_member[2]++;
        }

        private void m_setbtnwhite(Button c)
        {
            c.CssClass = "mybtnW";
            intA_member[0]++;
        }
        private void m_ShowMember()
        {
            lbl_W.Text = intA_member[0] + "";
            lbl_G.Text = intA_member[1] + "";
            lbl_B.Text = intA_member[2] + "";
            
        }



    }
}