using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Beverage_POS__Simple_;

public partial class SCar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AC"] == null)
            Response.Redirect("Main.aspx");

        GridView1.DataSource = Session["AC"];
        GridView1.DataBind();

        double sum = 0;
        List<Beverage> list = Session["AC"] as List<Beverage>;
        foreach (Beverage item in list)
        {
            sum += item.count * item.unitPrice;
            lbl金額.Text = sum.ToString();
        }

    }
    protected void btnCarNumber(object sender, EventArgs e)
    {
        lbl現金.Text += (sender as Button).Text;
    }
    protected void btn清除_Click(object sender, EventArgs e)
    {
        lbl現金.Text = "";
    }
    protected void btn找零_Click(object sender, EventArgs e)
    {
        if (lbl現金.Text == "")
        {
            Response.Write("<script>alert('請先輸入欲交易之現金再進行找零!')</script>");
        }
        else
        {
            lbl找零.Text = (Convert.ToInt32(lbl現金.Text) - Convert.ToInt32(lbl金額.Text)).ToString();

            if (Convert.ToInt32(lbl找零.Text) < 0)
            {
                Response.Write("<script>alert('輸入之交易現金數目有誤, 請確認後再進行找零!')</script>");
                lbl現金.Text = "";
                lbl找零.Text = "";
            }
        }
    }
    protected void btn繼續購物_Click(object sender, EventArgs e)
    {
        Response.Redirect("Main.aspx");
    }
    protected void btn結帳_Click(object sender, EventArgs e)
    {
        if (lbl找零.Text == "")
        {
            Response.Write("<script>alert('請先找零再進行結帳!')</script>");
        }
        else
        {
            Session["AC"] = null;
            Session["SC"] = null;
            lbl現金.Text = "";
            Response.Redirect("Main.aspx");
        }
    }
}