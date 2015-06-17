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

            this.bindMyGridView1();
            this.bindMyGridView2();
            this.bindMyGridView3();
            this.cbmemberin();
            this.cbmemberdelete();            
            this.cbstoredelete();
            this.cbmenudelete();
                        
            lbl目前日期.Text = String.Format(DateTime.Now.ToString("yyyy年MM月dd日"));
            timer目前時間.Enabled = true;

            cb期別.Enabled = true;
            cb使用者.Enabled = true;
            btn登入.Enabled = true;
            btn登出.Enabled = false;

            dataGridView1.Visible = false;
            lbl學員資料編號.Visible = false;
            lbl學員資料姓名.Visible = false;
            lbl學員資料期別.Visible = false;
            lbl學員資料電話.Visible = false;
            lbl學員資料信箱.Visible = false;
            tb學員資料編號.Visible = false;
            tb學員資料姓名.Visible = false;
            tb學員資料期別.Visible = false;
            tb學員資料電話.Visible = false;
            tb學員資料信箱.Visible = false;
            btn學員資料清空欄位.Visible = false;
            btn學員資料新增.Visible = false;
            btn學員資料修改.Visible = false;
            btn學員資料刪除.Visible = false;
            cb學員資料刪除.Visible = false;
            lbl學員資料刪除.Visible = false;

            dataGridView2.Visible = false;
            lbl廠商資料編號.Visible = false;
            lbl廠商資料名稱.Visible = false;
            lbl廠商資料電話.Visible = false;
            lbl廠商資料地址.Visible = false;
            lbl廠商資料官網.Visible = false;
            tb廠商資料編號.Visible = false;
            tb廠商資料名稱.Visible = false;
            tb廠商資料電話.Visible = false;
            tb廠商資料地址.Visible = false;
            tb廠商資料官網.Visible = false;
            btn廠商資料清空欄位.Visible = false;
            btn廠商資料新增.Visible = false;
            btn廠商資料修改.Visible = false;
            btn廠商資料刪除.Visible = false;
            cb廠商資料刪除.Visible = false;
            lbl廠商資料刪除.Visible = false;

            dataGridView3.Visible = false;
            lbl菜單資料編號.Visible = false;
            lbl菜單資料廠商編號.Visible = false;
            lbl菜單資料品名.Visible = false;
            lbl菜單資料單價.Visible = false;
            tb菜單資料編號.Visible = false;
            tb菜單資料廠商編號.Visible = false;
            tb菜單資料品名.Visible = false;
            tb菜單資料單價.Visible = false;
            btn菜單資料清空欄位.Visible = false;
            btn菜單資料新增.Visible = false;
            btn菜單資料修改.Visible = false;
            btn菜單資料刪除.Visible = false;
            cb菜單資料刪除.Visible = false;
            lbl菜單資料刪除.Visible = false;
        }

        private void timer目前時間_Tick(object sender, EventArgs e)
        {
            lbl目前時間.Text = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                new System.Globalization.CultureInfo("en-us")));
        }

        private void tb系統訊息_TextChanged(object sender, EventArgs e)
        {
            tb系統訊息.SelectionStart = tb系統訊息.Text.Length;
            tb系統訊息.ScrollToCaret();
        }

        private void cbmemberin()
        {
            cb期別.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select distinct class from member", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb期別.Items.Add(reader[0]);
            }

            reader.Close();
            con.Close();
        }

        private void cb期別_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb使用者.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select * from member where class ='" + cb期別.Text + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb使用者.Items.Add(reader[1]);
            }

            reader.Close();
            con.Close();
        }

        private void bindMyGridView1()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from member", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Load(reader);
            dataGridView1.DataSource = myDataTable;
            reader.Close();
            con.Close();
        }

        private void cbmemberdelete()
        {
            cb學員資料刪除.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select * from member", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb學員資料刪除.Items.Add(reader[0]);
            }

            reader.Close();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tb學員資料編號.Text = row.Cells[0].Value.ToString();
                tb學員資料姓名.Text = row.Cells[1].Value.ToString();
                tb學員資料期別.Text = row.Cells[2].Value.ToString();
                tb學員資料電話.Text = row.Cells[3].Value.ToString();
                tb學員資料信箱.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btn學員資料清空欄位_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要清空所有欄位?", "清空確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                tb學員資料編號.Clear();
                tb學員資料姓名.Clear();
                tb學員資料期別.Clear();
                tb學員資料電話.Clear();
                tb學員資料信箱.Clear();
            }
        }

        private void btn學員資料新增_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要新增?", "新增確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "Insert into member Values(@name, @class, @tel, @email)", con);

                cmd.Parameters.AddWithValue("@name", tb學員資料姓名.Text);
                cmd.Parameters.AddWithValue("@class", tb學員資料期別.Text);
                cmd.Parameters.AddWithValue("@tel", tb學員資料電話.Text);
                cmd.Parameters.AddWithValue("@email", tb學員資料信箱.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
                MessageBox.Show(TimeNow + String.Format("\n新增完畢, 影響{0}筆資料", rows), "通知");
                tb系統訊息.Text += "[" + TimeNow + "]" + String.Format(" 新增{0}筆學員資料!\r\n", rows);

                this.bindMyGridView1();
                this.bindMyGridView2();
                this.bindMyGridView3();
                this.cbmemberin();
                cb學員資料刪除.Text = "請選擇編號";
                this.cbmemberdelete();
            }
        }

        private void btn學員資料修改_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要修改?", "修改確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "Update member set name=@name, class=@class, tel=@tel, email=@email Where member_number=@member_number", con);

                cmd.Parameters.AddWithValue("@member_number", tb學員資料編號.Text);
                cmd.Parameters.AddWithValue("@name", tb學員資料姓名.Text);
                cmd.Parameters.AddWithValue("@class", tb學員資料期別.Text);
                cmd.Parameters.AddWithValue("@tel", tb學員資料電話.Text);
                cmd.Parameters.AddWithValue("@email", tb學員資料信箱.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
                MessageBox.Show(TimeNow + String.Format("\n修改完畢, 影響{0}筆資料", rows), "通知");
                tb系統訊息.Text += "[" + TimeNow + "]" + String.Format(" 修改{0}筆學員資料!\r\n", rows);

                this.bindMyGridView1();
                this.bindMyGridView2();
                this.bindMyGridView3();
                cb學員資料刪除.Text = "請選擇編號";
                this.cbmemberdelete();
            }
        }

        private void btn學員資料刪除_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要刪除?", "刪除確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "Delete from member Where member_number=@member_number", con);

                cmd.Parameters.AddWithValue("@member_number", cb學員資料刪除.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
                MessageBox.Show(TimeNow + String.Format("\n刪除完畢, 影響{0}筆資料", rows), "通知");
                tb系統訊息.Text += "[" + TimeNow + "]" + String.Format(" 刪除{0}筆學員資料!\r\n", rows);

                this.bindMyGridView1();
                this.bindMyGridView2();
                this.bindMyGridView3();
                cb學員資料刪除.Text = "請選擇編號";
                this.cbmemberdelete();
            }
        }

        private void bindMyGridView2()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from store", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Load(reader);
            dataGridView2.DataSource = myDataTable;
            reader.Close();
            con.Close();
        }

        private void cbstoredelete()
        {
            cb廠商資料刪除.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select * from store", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb廠商資料刪除.Items.Add(reader[0]);
            }

            reader.Close();
            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                tb廠商資料編號.Text = row.Cells[0].Value.ToString();
                tb廠商資料名稱.Text = row.Cells[1].Value.ToString();
                tb廠商資料電話.Text = row.Cells[2].Value.ToString();
                tb廠商資料地址.Text = row.Cells[3].Value.ToString();
                tb廠商資料官網.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btn廠商資料清空欄位_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要清空所有欄位?", "清空確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                tb廠商資料編號.Clear();
                tb廠商資料名稱.Clear();
                tb廠商資料電話.Clear();
                tb廠商資料地址.Clear();
                tb廠商資料官網.Clear();
            }
        }

        private void btn廠商資料新增_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要新增?", "新增確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "Insert into store Values(@name, @tel, @addrs, @website)", con);

                cmd.Parameters.AddWithValue("@name", tb廠商資料名稱.Text);
                cmd.Parameters.AddWithValue("@tel", tb廠商資料電話.Text);
                cmd.Parameters.AddWithValue("@addrs", tb廠商資料地址.Text);
                cmd.Parameters.AddWithValue("@website", tb廠商資料官網.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
                MessageBox.Show(TimeNow + String.Format("\n新增完畢, 影響{0}筆資料", rows), "通知");
                tb系統訊息.Text += "[" + TimeNow + "]" + String.Format(" 新增{0}筆廠商資料!\r\n", rows);

                this.bindMyGridView1();
                this.bindMyGridView2();
                this.bindMyGridView3();
                cb廠商資料刪除.Text = "請選擇編號";
                this.cbstoredelete();
            }
        }

        private void btn廠商資料修改_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要修改?", "修改確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "Update store set name=@name, tel=@tel, addrs=@addrs, website=@website Where store_number=@store_number", con);

                cmd.Parameters.AddWithValue("@store_number", tb廠商資料編號.Text);
                cmd.Parameters.AddWithValue("@name", tb廠商資料名稱.Text);
                cmd.Parameters.AddWithValue("@tel", tb廠商資料電話.Text);
                cmd.Parameters.AddWithValue("@addrs", tb廠商資料地址.Text);
                cmd.Parameters.AddWithValue("@website", tb廠商資料官網.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
                MessageBox.Show(TimeNow + String.Format("\n修改完畢, 影響{0}筆資料", rows), "通知");
                tb系統訊息.Text += "[" + TimeNow + "]" + String.Format(" 修改{0}筆廠商資料!\r\n", rows);

                this.bindMyGridView1();
                this.bindMyGridView2();
                this.bindMyGridView3();
                cb廠商資料刪除.Text = "請選擇編號";
                this.cbstoredelete();
            }
        }

        private void btn廠商資料刪除_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要刪除?", "刪除確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "Delete from store Where store_number=@store_number", con);

                cmd.Parameters.AddWithValue("@store_number", cb廠商資料刪除.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
                MessageBox.Show(TimeNow + String.Format("\n刪除完畢, 影響{0}筆資料", rows), "通知");
                tb系統訊息.Text += "[" + TimeNow + "]" + String.Format(" 刪除{0}筆廠商資料!\r\n", rows);

                this.bindMyGridView1();
                this.bindMyGridView2();
                this.bindMyGridView3();
                cb廠商資料刪除.Text = "請選擇編號";
                this.cbstoredelete();
                this.cbmenudelete();
            }
        }

        private void bindMyGridView3()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from menu", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Load(reader);
            dataGridView3.DataSource = myDataTable;
            reader.Close();
            con.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];
                tb菜單資料編號.Text = row.Cells[0].Value.ToString();
                tb菜單資料廠商編號.Text = row.Cells[1].Value.ToString();
                tb菜單資料品名.Text = row.Cells[2].Value.ToString();
                tb菜單資料單價.Text = row.Cells[3].Value.ToString();
            }
        }

        private void cbmenudelete()
        {
            cb菜單資料刪除.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select * from menu", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb菜單資料刪除.Items.Add(reader[0]);
            }

            reader.Close();
            con.Close();
        }

        private void btn菜單資料清空欄位_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要清空所有欄位?", "清空確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                tb菜單資料編號.Clear();
                tb菜單資料廠商編號.Clear();
                tb菜單資料品名.Clear();
                tb菜單資料單價.Clear();
            }
        }

        private void btn菜單資料新增_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要新增?", "新增確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "Insert into menu Values(@store_number, @name, @price)", con);

                cmd.Parameters.AddWithValue("@store_number", tb菜單資料廠商編號.Text);
                cmd.Parameters.AddWithValue("@name", tb菜單資料品名.Text);
                cmd.Parameters.AddWithValue("@price", tb菜單資料單價.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
                MessageBox.Show(TimeNow + String.Format("\n新增完畢, 影響{0}筆資料", rows), "通知");
                tb系統訊息.Text += "[" + TimeNow + "]" + String.Format(" 新增{0}筆菜單資料!\r\n", rows);

                this.bindMyGridView1();
                this.bindMyGridView2();
                this.bindMyGridView3();
                cb菜單資料刪除.Text = "請選擇菜單編號";
                this.cbmenudelete();
            }
        }

        private void btn菜單資料修改_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要修改?", "修改確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "Update menu set store_number=@store_number, name=@name, price=@price Where menu_number=@menu_number", con);

                cmd.Parameters.AddWithValue("@menu_number", tb菜單資料編號.Text);
                cmd.Parameters.AddWithValue("@store_number", tb菜單資料廠商編號.Text);
                cmd.Parameters.AddWithValue("@name", tb菜單資料品名.Text);
                cmd.Parameters.AddWithValue("@price", tb菜單資料單價.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
                MessageBox.Show(TimeNow + String.Format("\n修改完畢, 影響{0}筆資料", rows), "通知");
                tb系統訊息.Text += "[" + TimeNow + "]" + String.Format(" 修改{0}筆菜單資料!\r\n", rows);

                this.bindMyGridView1();
                this.bindMyGridView2();
                this.bindMyGridView3();
                cb菜單資料刪除.Text = "請選擇菜單編號";
                this.cbmenudelete();
            }
        }

        private void btn菜單資料刪除_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要刪除?", "刪除確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "Delete from menu Where menu_number=@menu_number", con);

                cmd.Parameters.AddWithValue("@menu_number", cb菜單資料刪除.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
                MessageBox.Show(TimeNow + String.Format("\n刪除完畢, 影響{0}筆資料", rows), "通知");
                tb系統訊息.Text += "[" + TimeNow + "]" + String.Format(" 刪除{0}筆菜單資料!\r\n", rows);

                this.bindMyGridView1();
                this.bindMyGridView2();
                this.bindMyGridView3();
                cb菜單資料刪除.Text = "請選擇菜單編號";
                this.cbmenudelete();
            }
        }      

        private void btn登入_Click(object sender, EventArgs e)
        {
            if (cb使用者.Text.Length >= 6)
            {
                string memberlogin = "";
                memberlogin = "使用者未選擇!\n請先選擇使用者再登入。";
                MessageBox.Show(memberlogin, "無法登入", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lbl當前使用者.Text = cb使用者.Text;
                tb系統訊息.Text = "[" + String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us"))) + "]" +
                    " 登入完成! " + cb使用者.Text + "\r\n";

                cb期別.Enabled = false;
                cb使用者.Enabled = false;
                btn登入.Enabled = false;
                btn登出.Enabled = true;

                dataGridView1.Visible = true;
                lbl學員資料編號.Visible = true;
                lbl學員資料姓名.Visible = true;
                lbl學員資料期別.Visible = true;
                lbl學員資料電話.Visible = true;
                lbl學員資料信箱.Visible = true;
                tb學員資料編號.Visible = true;
                tb學員資料姓名.Visible = true;
                tb學員資料期別.Visible = true;
                tb學員資料電話.Visible = true;
                tb學員資料信箱.Visible = true;
                btn學員資料清空欄位.Visible = true;
                btn學員資料新增.Visible = true;
                btn學員資料修改.Visible = true;                
                btn學員資料刪除.Visible = true;
                cb學員資料刪除.Visible = true;
                lbl學員資料刪除.Visible = true;

                dataGridView2.Visible = true;
                lbl廠商資料編號.Visible = true;
                lbl廠商資料名稱.Visible = true;
                lbl廠商資料電話.Visible = true;
                lbl廠商資料地址.Visible = true;
                lbl廠商資料官網.Visible = true;
                tb廠商資料編號.Visible = true;
                tb廠商資料名稱.Visible = true;
                tb廠商資料電話.Visible = true;
                tb廠商資料地址.Visible = true;
                tb廠商資料官網.Visible = true;
                btn廠商資料清空欄位.Visible = true;
                btn廠商資料新增.Visible = true;
                btn廠商資料修改.Visible = true;
                btn廠商資料刪除.Visible = true;
                cb廠商資料刪除.Visible = true;
                lbl廠商資料刪除.Visible = true;

                dataGridView3.Visible = true;
                lbl菜單資料編號.Visible = true;
                lbl菜單資料廠商編號.Visible = true;
                lbl菜單資料品名.Visible = true;
                lbl菜單資料單價.Visible = true;
                tb菜單資料編號.Visible = true;
                tb菜單資料廠商編號.Visible = true;
                tb菜單資料品名.Visible = true;
                tb菜單資料單價.Visible = true;
                btn菜單資料清空欄位.Visible = true;
                btn菜單資料新增.Visible = true;
                btn菜單資料修改.Visible = true;
                btn菜單資料刪除.Visible = true;
                cb菜單資料刪除.Visible = true;
                lbl菜單資料刪除.Visible = true;
            }
        }

        private void btn登出_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要登出?", "登出確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                lbl當前使用者.Text = "使用者未登入";
                cb期別.Text = "請選擇期別";
                cb使用者.Text = "請選擇使用者";
                tb系統訊息.Text = "您好! 歡迎使用本系統!\r\n請輸入帳號及密碼登入!\r\n";

                cb學員資料刪除.Text = "請選擇編號";
                tb學員資料編號.Text = "";
                tb學員資料姓名.Text = "";
                tb學員資料期別.Text = "";
                tb學員資料電話.Text = "";
                tb學員資料信箱.Text = "";
                cb廠商資料刪除.Text = "請選擇編號";
                tb廠商資料編號.Text = "";
                tb廠商資料名稱.Text = "";
                tb廠商資料電話.Text = "";
                tb廠商資料官網.Text = "";
                cb菜單資料刪除.Text = "請選擇菜單編號";
                tb菜單資料編號.Text = "";
                tb菜單資料廠商編號.Text = "";
                tb菜單資料品名.Text = "";
                tb菜單資料單價.Text = "";

                cb期別.Enabled = true;
                cb使用者.Enabled = true;
                btn登入.Enabled = true;
                btn登出.Enabled = false;

                dataGridView1.Visible = false;
                lbl學員資料編號.Visible = false;
                lbl學員資料姓名.Visible = false;
                lbl學員資料期別.Visible = false;
                lbl學員資料電話.Visible = false;
                lbl學員資料信箱.Visible = false;
                tb學員資料編號.Visible = false;
                tb學員資料姓名.Visible = false;
                tb學員資料期別.Visible = false;
                tb學員資料電話.Visible = false;
                tb學員資料信箱.Visible = false;
                btn學員資料清空欄位.Visible = false;
                btn學員資料新增.Visible = false;
                btn學員資料修改.Visible = false;
                btn學員資料刪除.Visible = false;
                cb學員資料刪除.Visible = false;
                lbl學員資料刪除.Visible = false;

                dataGridView2.Visible = false;
                lbl廠商資料編號.Visible = false;
                lbl廠商資料名稱.Visible = false;
                lbl廠商資料電話.Visible = false;
                lbl廠商資料地址.Visible = false;
                lbl廠商資料官網.Visible = false;
                tb廠商資料編號.Visible = false;
                tb廠商資料名稱.Visible = false;
                tb廠商資料電話.Visible = false;
                tb廠商資料地址.Visible = false;
                tb廠商資料官網.Visible = false;
                btn廠商資料清空欄位.Visible = false;
                btn廠商資料新增.Visible = false;
                btn廠商資料修改.Visible = false;
                btn廠商資料刪除.Visible = false;
                cb廠商資料刪除.Visible = false;
                lbl廠商資料刪除.Visible = false;

                dataGridView3.Visible = false;
                lbl菜單資料編號.Visible = false;
                lbl菜單資料廠商編號.Visible = false;
                lbl菜單資料品名.Visible = false;
                lbl菜單資料單價.Visible = false;
                tb菜單資料編號.Visible = false;
                tb菜單資料廠商編號.Visible = false;
                tb菜單資料品名.Visible = false;
                tb菜單資料單價.Visible = false;
                btn菜單資料清空欄位.Visible = false;
                btn菜單資料新增.Visible = false;
                btn菜單資料修改.Visible = false;
                btn菜單資料刪除.Visible = false;
                cb菜單資料刪除.Visible = false;
                lbl菜單資料刪除.Visible = false;
            }
        }

        private void btn程式結束_Click(object sender, EventArgs e)
        {
            if (btn登出.Enabled == false)
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
            else
            {
                string FormClose = "";
                FormClose = "目前帳號登入中!\n請先登出帳號再結束程式。";
                MessageBox.Show(FormClose, "無法關閉", MessageBoxButtons.OK, MessageBoxIcon.Warning);              
            }
        }                        
    }
}
