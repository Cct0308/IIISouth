using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BDOrderSystem
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb;
        int orderfinishck = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            //scsb.DataSource = @"CCT-PC\SQLEXPRESS";
            scsb.DataSource = @"CR4-06\MSSQLSERVER2013";
            scsb.InitialCatalog = "BDOrderSystem";
            scsb.IntegratedSecurity = true;
                        
            lbl目前日期.Text = String.Format(DateTime.Now.ToString("yyyy年MM月dd日"));
            timer目前時間.Enabled = true;

            this.orderdateselect();
        }

        private void timer目前時間_Tick(object sender, EventArgs e)
        {
            lbl目前時間.Text = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                new System.Globalization.CultureInfo("en-us")));
        }

        private void bindMyGridView1()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select om.master_number as 訂單編號, mb.name as 訂單負責人, st.name as 店家名稱, om.order_date as 訂購日期, om.bdocheck as 是否已完成訂購 " +
                "from order_master as om inner join member as mb on om.member_number=mb.member_number " +
                "inner join store as st on om.store_number=st.store_number " +
                "where master_number ='" + cb選擇訂單編號.Text + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Load(reader);
            dataGridView1.DataSource = myDataTable;
            reader.Close();
            con.Close();
        }

        private void bindMyGridView2()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select od.detail_number as 明細編號, mn.name as 品名, od.quantity as 數量, od.note as 備註 " +
                "from order_detail as od inner join menu as mn on od.menu_number=mn.menu_number " +
                "where od.master_number in (select master_number from order_master where master_number ='" + cb選擇訂單編號.Text + "')", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Load(reader);
            dataGridView2.DataSource = myDataTable;
            reader.Close();
            con.Close();
        }

        private void bindMyGridView3()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select mn.name as 品名, sum(od.quantity) as 數量, od.price as 單價, sum(od.quantity * od.price) as 小計 " +
                "from order_detail as od inner join menu as mn on od.menu_number=mn.menu_number " +
                "where od.master_number in (select master_number from order_master where master_number ='" + cb選擇訂單編號.Text + "') " +
                "group by mn.name, od.price", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Load(reader);
            dataGridView3.DataSource = myDataTable;
            reader.Close();
            con.Close();
        }

        private void orderdateselect()
        {
            cb選擇訂單日期.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select distinct order_date from order_master", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb選擇訂單日期.Items.Add(reader[0]);
            }

            reader.Close();
            con.Close();
        }

        private void cb選擇訂單日期_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb選擇訂單編號.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select * from order_master where order_date ='" + cb選擇訂單日期.Text + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb選擇訂單編號.Items.Add(reader[0]);
            }

            reader.Close();
            con.Close();
        }

        private void btn選擇訂單編號確認_Click(object sender, EventArgs e)
        {
            if ((cb選擇訂單日期.Text.Length <= 7) || (cb選擇訂單編號.Text.Length >= 7))
            {
                string memberlogin = "";
                memberlogin = "訂單日期或訂單編號未選擇!\n請選擇完訂單編號與訂單日期再確認。";
                MessageBox.Show(memberlogin, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.bindMyGridView1();
                this.bindMyGridView2();
                this.bindMyGridView3();

                /***/

                tb總數.Clear();
                tb總價.Clear();

                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "select sum(quantity), sum(quantity*price) from order_detail where master_number = '" + cb選擇訂單編號.Text + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tb總數.Text = Convert.ToString(reader[0]);
                    tb總價.Text = Convert.ToString(reader[1]);
                }

                reader.Close();
                con.Close();
            }
        }

        private void rb訂購完成_CheckedChanged(object sender, EventArgs e)
        {
            if (rb訂購完成.Checked == true)
            {
                orderfinishck = 1;
            }
        }

        private void rb訂購取消_CheckedChanged(object sender, EventArgs e)
        {
            if (rb訂購取消.Checked == true)
            {
                orderfinishck = 0;
            }
        }

        private void btn訂購完成確認_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("是否確認為所選之訂單狀態?", "訂單狀態確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "Update order_master set bdocheck=@bdocheck Where master_number=@master_number", con);

                cmd.Parameters.AddWithValue("@master_number", cb選擇訂單編號.Text);
                cmd.Parameters.AddWithValue("@bdocheck", orderfinishck);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                this.bindMyGridView1();
                this.bindMyGridView2();
                this.bindMyGridView3();
            }
        }

        private void btn程式結束_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要結束程式?", "結束確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                this.Close();
                Environment.Exit(Environment.ExitCode);
            }
        }
    }
}
