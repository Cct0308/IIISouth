using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testModel01
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn上傳word檔_Click(object sender, EventArgs e)
        {
            //string path = Server.MapPath("..");
            //FileUpload1.SaveAs(path + @"\AssessFile\assess.doc");
	        string path = Server.MapPath( @"\.\AssessFile\assess.doc");
            FileUpload1.SaveAs(path);
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlDataSource1.Insert();
        }

        //protected void btn上傳收費評估表_Click(object sender, EventArgs e)
        //{
        //    //string path = Server.MapPath("..");
        //    //FileUpload_收費評估表.SaveAs(path + @"\AssessFile\123.xlsx");
        //    string path = Server.MapPath( @"\.\AssessFile\123.xlsx");
        //    FileUpload_收費評估表.SaveAs(path);
        //}                
    }
}