using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Configuration;

namespace testModel01.BackEnd
{
    public partial class WebForm6 : System.Web.UI.Page
    {

        string str_Data_Source = WebConfigurationManager.OpenWebConfiguration("/testModel01").ConnectionStrings.ConnectionStrings["dbKSYYConnectionString"].ConnectionString;//家2

        DropDownList[] ddlist = new DropDownList[3];  //暫存
        Image img1;//暫存
        FileUpload fupload; //暫存
        Control contrl_temp;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                m_initial();
            }

          }

        private void m_initial()
        {
            string str_bednum= Request.QueryString["f床號"].ToString();
          
            SqlDataSource sds = new SqlDataSource();
            sds.ConnectionString = str_Data_Source;
            sds.SelectCommand = "SELECT * from  T床位系統 WHERE f床號 ='"+str_bednum+"'";
            DataView dn = (DataView)sds.Select(DataSourceSelectArguments.Empty);            
            int[] inta_ = new int[3];

            //dropdownlist的全部選擇
            m_FindControl_ddlist(FormView16, typeof(DropDownList));
         
                ddlist[0].SelectedIndex = Convert.ToInt32(dn[0]["f是否住院中"]);
                ddlist[1].SelectedIndex = Convert.ToInt32(dn[0]["f鼻胃管"]);
                ddlist[2].SelectedIndex = Convert.ToInt32(dn[0]["f導尿管"]);
                 try
            {
            }
            catch (Exception exc)
            {
                ddlist[0] = ddlist[1] = ddlist[2] = new DropDownList();
                ddlist[0].SelectedIndex = 0;
            }

    
         try
         {
             img1 = new Image();  
             img1.ImageUrl = dn[0]["f照片"].ToString();
             if (img1.ImageUrl.Length < 5)
             {
               
                 img1.ImageUrl = @"../pic/床位照片/大頭照/defaultimg.png";
             }
          
         }
         catch (Exception ee)
         {
             img1.ImageUrl = @"../pic/床位照片/大頭照/defaultimg.png";
         }
         m_FindControl_Control(FormView16, typeof(Image));
         ((Image)contrl_temp).ImageUrl = img1.ImageUrl;
        }

        public void m_FindControl_ddlist(Control root, Type type)
        {

            if (root.GetType() == type)
            {
                if (((DropDownList)root).ID == "DDList_hospital")
                {
                    ddlist[0] = ((DropDownList)root);                    
                }else
                if (((DropDownList)root).ID == "DDList_nose")
                {
                    ddlist[1] = ((DropDownList)root);
                }
                else
                    if (((DropDownList)root).ID == "DDList_pee")
                    {
                        ddlist[2] = ((DropDownList)root);
                    }
            }
            foreach (Control c in root.Controls)
                m_FindControl_ddlist(c, type);
        }

        public void m_FindControl_Control(Control root, Type type)
        {
            if (root.GetType() == type)
            {
                contrl_temp = root;
                    return;
            }
            foreach (Control c in root.Controls)
                m_FindControl_Control(c, type);
        }

        protected void FormView1_ItemCommand(object sender, FormViewCommandEventArgs e)
        {
            if (e.CommandName == "Cancel")
            {
                Response.Redirect(this.Page.Request.UrlReferrer.ToString());
            }
        }

        protected void FormView1_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
        {
            Response.Redirect(this.Page.Request.UrlReferrer.ToString());
        }

        protected void FormView16_ItemUpdating(object sender, FormViewUpdateEventArgs e)
        {
            FormView f = (FormView)sender;


            m_FindControl_ddlist(FormView16, typeof(DropDownList));
            try
            {

                e.NewValues["f是否住院中"] = ddlist[0].SelectedIndex.ToString();
                e.NewValues["f鼻胃管"] = ddlist[1].SelectedIndex.ToString();
                e.NewValues["f導尿管"] = ddlist[2].SelectedIndex.ToString();

            }
            catch (Exception exc)
            {
         
            }

            
            //照片

            m_FindControl_Control(FormView16, typeof(FileUpload));
            fupload = (FileUpload)contrl_temp;


            m_FindControl_Control(FormView16, typeof(Image));
            img1 = ((Image)contrl_temp);
            //////
     
           if (fupload.HasFile)//是否有上傳的檔案
            {

                if ("jpg".Equals(fupload.FileName.Substring(fupload.FileName.LastIndexOf(".") + 1).ToLower()) ||
                             "png".Equals(fupload.FileName.Substring(fupload.FileName.LastIndexOf(".") + 1).ToLower()) ||
                             "bmp".Equals(fupload.FileName.Substring(fupload.FileName.LastIndexOf(".") + 1).ToLower()) ||
                             "gif".Equals(fupload.FileName.Substring(fupload.FileName.LastIndexOf(".") + 1).ToLower()))
                {
                    //是否符合副檔名
                    //刪除照片
                    string str_expath = System.Web.Hosting.HostingEnvironment.MapPath("~");
                    if (img1.ImageUrl.Substring(img1.ImageUrl.LastIndexOf(@"/\") + 1).ToLower()
                        !="defaultimg.png")
                    {
                        string str_temp = str_expath + img1.ImageUrl.Substring(4, img1.ImageUrl.Length - 4);
                        if (System.IO.File.Exists(str_temp))
                            System.IO.File.Delete(str_temp);
                    }
                    //上傳照片                   
                        fupload.SaveAs(Server.MapPath(@"~\pic\床位照片\大頭照\" + fupload.FileName));
                        e.NewValues["f照片"] = @"..\pic\床位照片\大頭照\" + fupload.FileName;
                 }
            }
           else
               e.NewValues["f照片"] = img1.ImageUrl;
        }

        protected void FormView16_ItemDeleted(object sender, FormViewDeletedEventArgs e)
        {
            Response.Redirect(this.Page.Request.UrlReferrer.ToString());
        }

        protected void FormView16_Unload(object sender, EventArgs e)
        {

        }

        protected void FormView16_ItemDeleting(object sender, FormViewDeleteEventArgs e)
        {
            m_FindControl_Control(FormView16, typeof(Image));
            img1 = ((Image)contrl_temp);

            if (img1.ImageUrl.Substring(img1.ImageUrl.LastIndexOf(@"/") + 1).ToLower()
                     != "defaultimg.png" &&
                img1.ImageUrl.Substring(img1.ImageUrl.LastIndexOf(@"\") + 1).ToLower()
                     != "defaultimg.png")
            {
                string str_expath = System.Web.Hosting.HostingEnvironment.MapPath("~");
                string str_temp = str_expath + img1.ImageUrl.Substring(3, img1.ImageUrl.Length - 3);
                if (System.IO.File.Exists(str_temp))
                    System.IO.File.Delete(str_temp);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect(this.Page.Request.UrlReferrer.ToString());
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          
        }

        protected void btn_delpic_Click1(object sender, EventArgs e)
        {
            m_FindControl_Control(FormView16, typeof(Image));
            img1 = ((Image)contrl_temp);

            if (img1.ImageUrl.Substring(img1.ImageUrl.LastIndexOf(@"/") + 1).ToLower()
                     != "defaultimg.png" &&
                img1.ImageUrl.Substring(img1.ImageUrl.LastIndexOf(@"\") + 1).ToLower()
                     != "defaultimg.png")
            {
                string str_expath = System.Web.Hosting.HostingEnvironment.MapPath("~");
                string str_temp = str_expath + img1.ImageUrl.Substring(3, img1.ImageUrl.Length - 3);
                if (System.IO.File.Exists(str_temp))
                    System.IO.File.Delete(str_temp);
       

            SqlDataSource sds = new SqlDataSource();
            sds.ConnectionString = str_Data_Source;
            sds.UpdateCommand = "update T床位系統 set f照片 = null WHERE f照片 ='" + img1.ImageUrl + "'";
            sds.Update();
            Response.Redirect(this.Page.Request.UrlReferrer.ToString());
            }
        }

   

  
    }
}