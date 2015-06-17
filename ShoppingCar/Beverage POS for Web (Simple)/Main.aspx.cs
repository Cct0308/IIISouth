using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Beverage_POS__Simple_;

public partial class Main : System.Web.UI.Page
{
    BeverageFactory bf = new BeverageFactory();
    Dictionary<Button, Beverage> bfDic = new Dictionary<Button, Beverage>();
    int count;

    protected void Page_Load(object sender, EventArgs e)
    {

        PlaceHolder1.Controls.Clear();

        foreach (Beverage br in bf.getAll())
        {
            Button bfBtn = new Button();
            bfBtn.ID = "bfBtn" + br.no.ToString();
            bfBtn.Text = br.name;
            bfBtn.Height = 55;
            bfBtn.Width = 120;
            bfBtn.Click += new System.EventHandler(bfOrder);

            bfDic.Add(bfBtn, br);
            PlaceHolder1.Controls.Add(bfBtn);
        }

        if (Session["SC"] == null)
        {
            count = 0;
        }
        else
        {
            count = Convert.ToInt32(Session["SC"]);
        }

    }
    private void bfOrder(object sender, EventArgs e)
    {
        Session["NK"] = null;
        lbl品名.Text = (bfDic[sender as Button] as Beverage).name;
        lbl數量.Text = (bfDic[sender as Button] as Beverage).count.ToString();
        lbl單價.Text = (bfDic[sender as Button] as Beverage).unitPrice.ToString();
        lbl溫度.Text = (bfDic[sender as Button] as Beverage).noteT;
        lbl甜度.Text = (bfDic[sender as Button] as Beverage).noteS;
        lbl加料.Text = (bfDic[sender as Button] as Beverage).noteO;
        totalPrice();
    }

    protected void btnNumber(object sender, EventArgs e)
    {
        Session["NK"] += (sender as Button).Text;
        lbl數量.Text = Session["NK"].ToString();
        totalPrice();
    }
    protected void btnTemperature(object sender, EventArgs e)
    {
        lbl溫度.Text = (sender as Button).Text;
    }
    protected void btnSugar(object sender, EventArgs e)
    {
        lbl甜度.Text = (sender as Button).Text;
    }
    protected void btnOther(object sender, EventArgs e)
    {
        if (lbl品名.Text == "")
        {
            Response.Write("<script>alert('請先選擇品項!')</script>");
        }
        else
        {
            if (lbl加料.Text != "")
            {

            }
            else
            {
                if (lbl單價.Text == "0")
                {
                    lbl加料.Text = (sender as Button).Text;
                }
                else
                {
                    lbl加料.Text = (sender as Button).Text;
                    int other = Convert.ToInt32(lbl單價.Text);
                    other += 10;
                    lbl單價.Text = other.ToString();
                    totalPrice();
                }

            }
        }
    }

    protected void btn溫度正常_Click(object sender, EventArgs e)
    {
        lbl溫度.Text = "正常";
    }
    protected void btn甜度正常_Click(object sender, EventArgs e)
    {
        lbl甜度.Text = "正常";
    }
    protected void btn加料清除_Click(object sender, EventArgs e)
    {
        if (lbl品名.Text == "")
        {
            Response.Write("<script>alert('請先選擇品項!')</script>");
        }
        else
        {
            if (lbl加料.Text == "")
            {

            }
            else
            {
                if (lbl單價.Text == "0")
                {
                    lbl加料.Text = "";
                }
                else
                {
                    lbl加料.Text = "";
                    int other = Convert.ToInt32(lbl單價.Text);
                    other -= 10;
                    lbl單價.Text = other.ToString();
                    totalPrice();
                }
            }
        }
    }
    protected void btn取消交易_Click(object sender, EventArgs e)
    {
        Session["AC"] = null;
        Session["SC"] = null;
        Session["NK"] = null;
        lbl品名.Text = "";
        lbl數量.Text = "";
        lbl單價.Text = "";
        lbl溫度.Text = "";
        lbl甜度.Text = "";
        lbl加料.Text = "";
        lbl小計.Text = "";
    }
    protected void btn贈送_Click(object sender, EventArgs e)
    {
        if (lbl品名.Text == "")
        {
            Response.Write("<script>alert('請先選擇品項!')</script>");
        }
        else
        {
            lbl單價.Text = "0";
            totalPrice();
        }
    }
    protected void btn歸零_Click(object sender, EventArgs e)
    {
        if (lbl品名.Text == "")
        {
            Response.Write("<script>alert('請先選擇品項!')</script>");
        }
        else
        {
            Session["NK"] = null;
            lbl數量.Text = "1";
            totalPrice();
        }
    }
    protected void btn購物車_Click(object sender, EventArgs e)
    {
        Response.Redirect("SCar.aspx");
    }
    protected void btn確認_Click(object sender, EventArgs e)
    {
        if (lbl品名.Text == "")
        {
            Response.Write("<script>alert('請先選擇品項!')</script>");
        }
        else
        {
            List<Beverage> list = Session["AC"] as List<Beverage>;
            if (list == null)
            {
                list = new List<Beverage>();
                Session["AC"] = list;
            }

            count++;
            Session["SC"] = count;

            Beverage item = new Beverage();
            item.no = count;
            item.name = lbl品名.Text;
            item.count = Convert.ToInt32(lbl數量.Text);
            item.unitPrice = Convert.ToInt32(lbl單價.Text);
            item.noteT = lbl溫度.Text;
            item.noteS = lbl甜度.Text;
            item.noteO = lbl加料.Text;
            item.price = Convert.ToInt32(lbl小計.Text);
            list.Add(item);
            Response.Redirect("SCar.aspx");
        }
    }
    private void totalPrice()
    {
        lbl小計.Text = (Convert.ToInt32(lbl數量.Text) * Convert.ToInt32(lbl單價.Text)).ToString();
    }
}