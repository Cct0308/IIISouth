using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testModel01.BackEnd
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            lbl8.Visible = false;
        }

        protected void btn第一張圖_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {                
                string savePath = Server.MapPath(@"../images/1.jpg");                
                FileUpload1.SaveAs(savePath);
                lbl1.Visible = true;
                lbl1.Text = "上傳成功";
            }                       
        }

        protected void btn第二張圖_Click(object sender, EventArgs e)
        {
            if (FileUpload2.HasFile)
            {                
                string savePath = Server.MapPath(@"../images/2.jpg");               
                FileUpload2.SaveAs(savePath);
                lbl2.Visible = true;
                lbl2.Text = "上傳成功";
            }
        }

        protected void btn第三張圖_Click(object sender, EventArgs e)
        {
            if (FileUpload3.HasFile)
            {
                string savePath = Server.MapPath(@"../images/3.jpg");
                FileUpload3.SaveAs(savePath);
                lbl3.Visible = true;
                lbl3.Text = "上傳成功";
            }
        }

        protected void btn第四張圖_Click(object sender, EventArgs e)
        {
            if (FileUpload4.HasFile)
            {
                string savePath = Server.MapPath(@"../images/4.jpg");
                FileUpload4.SaveAs(savePath);
                lbl4.Visible = true;
                lbl4.Text = "上傳成功";
            }
        }

        protected void btn第五張圖_Click(object sender, EventArgs e)
        {
            if (FileUpload5.HasFile)
            {
                string savePath = Server.MapPath(@"../images/5.jpg");
                FileUpload5.SaveAs(savePath);
                lbl5.Visible = true;
                lbl5.Text = "上傳成功";
            }            
        }

        protected void btn第六張圖_Click(object sender, EventArgs e)
        {
            if (FileUpload6.HasFile)
            {
                string savePath = Server.MapPath(@"../images/6.jpg");
                FileUpload6.SaveAs(savePath);
                lbl6.Visible = true;
                lbl6.Text = "上傳成功";
            }
        }

        protected void btn第七張圖_Click(object sender, EventArgs e)
        {
            if (FileUpload7.HasFile)
            {
                string savePath = Server.MapPath(@"../images/7.jpg");
                FileUpload7.SaveAs(savePath);
                lbl7.Visible = true;
                lbl7.Text = "上傳成功";
            }
        }

        protected void btn第八張圖_Click(object sender, EventArgs e)
        {
            if (FileUpload8.HasFile)
            {
                string savePath = Server.MapPath(@"../images/8.jpg");
                FileUpload8.SaveAs(savePath);
                lbl8.Visible = true;
                lbl8.Text = "上傳成功";
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

            }
        }

       
    }
}