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
                        
            lbl目前日期.Text = String.Format(DateTime.Now.ToString("yyyy年MM月dd日"));
            timer目前時間.Enabled = true;

            cb期別.Enabled = true;
            cb值日生.Enabled = true;
            btn登入.Enabled = true;
            btn登出.Enabled = false;

            this.bindMyGridView1();
            this.bindMyGridView2();
            this.cbmemberin();
            this.cbstoreselect();
            this.cbmasterdelete();
            this.cbodud();
            this.oddelete();

            dataGridView1.Visible = false;
            lbl店家.Visible = false;
            cb店家.Visible = false;
            btn開始訂購.Visible = false;
            lbl取消訂購.Visible = false;            
            cb取消訂購.Visible = false;
            btn取消訂購確認.Visible = false;

            dataGridView2.Visible = false;
            lbl姓名.Visible = false;
            cb訂購人.Visible = false;
            lbl品名.Visible = false;
            cb品名.Visible = false;
            lbl單價.Visible = false;
            tb單價.Visible = false;
            lbl數量.Visible = false;
            tb數量.Visible = false;
            lbl備註.Visible = false;
            tb備註.Visible = false;
            btn全部清除.Visible = false;
            btn送出.Visible = false;
            lbl明細修改.Visible = false;
            cb明細修改.Visible = false;
            btn明細修改.Visible = false;
            lbl清單刪除.Visible = false;
            cb清單刪除.Visible = false;
            btn清單刪除確認.Visible = false;            
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

        private void bindMyGridView1()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select om.master_number as 訂單編號, mb.name as 訂單負責人, st.name as 店家名稱, om.order_date as 訂購日期, om.bdocheck as 是否已完成訂購 " +
                "from order_master as om inner join member as mb on om.member_number=mb.member_number " +
                "inner join store as st on om.store_number=st.store_number " +
                "where om.bdocheck=0", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Load(reader);
            dataGridView1.DataSource = myDataTable;
            reader.Close();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                cb店家.Text = row.Cells[2].Value.ToString();
            }
        }

        private void bindMyGridView2()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select od.detail_number as 明細編號, om.master_number as 訂單編號, mb.name as 訂購人, mn.name as 品名, od.quantity as 數量, od.price as 單價, (od.quantity * od.price) as 小計, od.note as 備註 " +
                "from order_detail as od inner join order_master as om on od.master_number=om.master_number " +
                "inner join member as mb on od.member_number=mb.member_number " +
                "inner join menu as mn on od.menu_number=mn.menu_number " +
                "where od.master_number in (select master_number from order_master where bdocheck=0)", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Load(reader);
            dataGridView2.DataSource = myDataTable;
            reader.Close();
            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                cb訂購人.Text = row.Cells[2].Value.ToString();
                cb品名.Text = row.Cells[3].Value.ToString();
                tb單價.Text = row.Cells[5].Value.ToString();
                tb數量.Text = row.Cells[4].Value.ToString();
                tb備註.Text = row.Cells[7].Value.ToString();
            }
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
            cb值日生.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select * from member where class ='" + cb期別.Text + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb值日生.Items.Add(reader[1]);
            }

            reader.Close();
            con.Close();

            /***/

            cb訂購人.Items.Clear();

            SqlConnection con1 = new SqlConnection(scsb.ToString());
            con1.Open();
            SqlCommand cmd1 = new SqlCommand(
                "select * from member where class ='" + cb期別.Text + "'", con1);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                cb訂購人.Items.Add(reader1[1]);
            }

            reader1.Close();
            con1.Close();
        }

        private void cbstoreselect()
        {
            cb店家.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select * from store", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb店家.Items.Add(reader[1]);
            }

            reader.Close();
            con.Close();
        }

        private void cb店家_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb品名.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select * from menu where store_number = (" +
                "select store_number from store where name = '" + cb店家.Text +
                "')", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb品名.Items.Add(reader[2]);
            }

            reader.Close();
            con.Close();
        }

        private void cb品名_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb單價.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select * from menu where name = '" + cb品名.Text + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tb單價.Text = Convert.ToString(reader[3]);
            }

            reader.Close();
            con.Close();
        }

        private void btn開始訂購_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要開始訂購?", "訂購開始確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                int selectsn = 0;

                SqlConnection con1 = new SqlConnection(scsb.ToString());
                con1.Open();
                SqlCommand cmd1 = new SqlCommand(
                    "select * from store where name = '" + cb店家.Text + "'", con1);
                SqlDataReader reader1 = cmd1.ExecuteReader();

                reader1.Read();
                selectsn = Convert.ToInt32(reader1[0]);

                reader1.Close();
                con1.Close();

                /***/

                int selectmn = 0;

                SqlConnection con2 = new SqlConnection(scsb.ToString());
                con2.Open();
                SqlCommand cmd2 = new SqlCommand(
                    "select * from member where name = '" + cb值日生.Text + "'", con2);
                SqlDataReader reader2 = cmd2.ExecuteReader();

                reader2.Read();
                selectmn = Convert.ToInt32(reader2[0]);

                reader2.Close();
                con2.Close();

                /***/

                SqlConnection con3 = new SqlConnection(scsb.ToString());
                con3.Open();
                SqlCommand cmd3 = new SqlCommand(
                    "Insert into order_master Values(@store_number, @member_number, @order_date, @bdocheck)", con3);

                cmd3.Parameters.AddWithValue("@store_number", selectsn);
                cmd3.Parameters.AddWithValue("@member_number", selectmn);
                cmd3.Parameters.AddWithValue("@order_date", DateTime.Now.ToString("yyyy/MM/dd"));
                cmd3.Parameters.AddWithValue("@bdocheck", 0);

                int rows = cmd3.ExecuteNonQuery();
                con3.Close();

                string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
                MessageBox.Show(TimeNow + String.Format("\n新增訂購完畢, 影響{0}筆資料", rows), "通知");
                tb系統訊息.Text += "[" + TimeNow + "]" + String.Format(" 新增{0}筆訂單資料!\r\n", rows);

                this.bindMyGridView1();
                this.bindMyGridView2();
                cb取消訂購.Text = "選擇訂單編號";
                this.cbmasterdelete();
            }
        }

        private void cbmasterdelete()
        {
            cb取消訂購.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select * from order_master where bdocheck=0", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb取消訂購.Items.Add(reader[0]);
            }

            reader.Close();
            con.Close();
        }

        private void btn取消訂購確認_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要取消訂購?", "訂購取消確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "Delete from order_master Where master_number=@master_number", con);

                cmd.Parameters.AddWithValue("@master_number", cb取消訂購.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
                MessageBox.Show(TimeNow + String.Format("\n取消訂購完畢, 影響{0}筆資料", rows), "通知");
                tb系統訊息.Text += "[" + TimeNow + "]" + String.Format(" 取消{0}筆訂單資料!\r\n", rows);

                this.bindMyGridView1();
                cb店家.Text = "請選擇店家";
                this.cbstoreselect();
                cb取消訂購.Text = "選擇訂單編號";
                this.cbmasterdelete();

                cb訂購人.Text = "請選擇訂購人";
                cb品名.Text = "請選擇品名";
                tb單價.Text = "0";
                tb數量.Text = "0";
                tb備註.Clear();

                this.bindMyGridView2();
                cb明細修改.Text = "選擇明細編號";
                this.cbodud();
                cb清單刪除.Text = "選擇明細編號";
                this.oddelete();                
            }
        }
        
        private void btn全部清除_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要清空所有欄位?", "清空確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                cb訂購人.Text = "請選擇訂購人";
                cb品名.Text = "請選擇品名";
                tb單價.Text = "0";
                tb數量.Text = "0";
                tb備註.Clear();
            }
        }

        private void btn送出_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要送出訂單?", "訂單送出確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                int selectmasterst = 0;

                SqlConnection con1 = new SqlConnection(scsb.ToString());
                con1.Open();
                SqlCommand cmd1 = new SqlCommand(
                    "select * from store where name = '" + cb店家.Text + "'", con1);
                SqlDataReader reader1 = cmd1.ExecuteReader();

                reader1.Read();
                selectmasterst = Convert.ToInt32(reader1[0]);

                reader1.Close();
                con1.Close();

                /***/

                int selectmastermb = 0;

                SqlConnection con2 = new SqlConnection(scsb.ToString());
                con2.Open();
                SqlCommand cmd2 = new SqlCommand(
                    "select * from member where name = '" + cb值日生.Text + "'", con2);
                SqlDataReader reader2 = cmd2.ExecuteReader();

                reader2.Read();
                selectmastermb = Convert.ToInt32(reader2[0]);

                reader2.Close();
                con2.Close();

                /***/

                int selectmaster = 0;
                string selectmasterdate = DateTime.Now.ToString("yyyy/MM/dd");

                SqlConnection con3 = new SqlConnection(scsb.ToString());
                con3.Open();
                SqlCommand cmd3 = new SqlCommand(
                    "select * from order_master where store_number = '" + selectmasterst +
                    "' and member_number = '" + selectmastermb +
                    "' and order_date = '" + selectmasterdate + "'", con3);
                SqlDataReader reader3 = cmd3.ExecuteReader();

                reader3.Read();
                selectmaster = Convert.ToInt32(reader3[0]);

                reader3.Close();
                con3.Close();

                /***/

                int selectmember = 0;

                SqlConnection con4 = new SqlConnection(scsb.ToString());
                con4.Open();
                SqlCommand cmd4 = new SqlCommand(
                    "select * from member where name = '" + cb訂購人.Text + "'", con4);
                SqlDataReader reader4 = cmd4.ExecuteReader();

                reader4.Read();
                selectmember = Convert.ToInt32(reader4[0]);

                reader4.Close();
                con4.Close();

                /***/

                int selectmenu = 0;

                SqlConnection con5 = new SqlConnection(scsb.ToString());
                con5.Open();
                SqlCommand cmd5 = new SqlCommand(
                    "select * from menu where name = '" + cb品名.Text + "'", con5);
                SqlDataReader reader5 = cmd5.ExecuteReader();

                reader5.Read();
                selectmenu = Convert.ToInt32(reader5[0]);

                reader5.Close();
                con5.Close();

                /***/

                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "Insert into order_detail Values(@master_number, @member_number, @menu_number, @quantity, @price, @note)", con);

                cmd.Parameters.AddWithValue("@master_number", selectmaster);
                cmd.Parameters.AddWithValue("@member_number", selectmember);
                cmd.Parameters.AddWithValue("@menu_number", selectmenu);
                cmd.Parameters.AddWithValue("@quantity", tb數量.Text);
                cmd.Parameters.AddWithValue("@price", tb單價.Text);
                cmd.Parameters.AddWithValue("@note", tb備註.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
                MessageBox.Show(TimeNow + String.Format("\n送出訂單完畢, 影響{0}筆資料", rows), "通知");
                tb系統訊息.Text += "[" + TimeNow + "]" + String.Format(" 送出{0}筆訂購資料!\r\n", rows);

                this.bindMyGridView1();
                this.bindMyGridView2();
                cb明細修改.Text = "選擇明細編號";
                this.cbodud();
                cb清單刪除.Text = "選擇明細編號";
                this.oddelete();
            }
        }

        private void cbodud()
        {
            cb明細修改.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select * from order_detail where master_number in (select master_number from order_master where bdocheck=0)", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb明細修改.Items.Add(reader[0]);
            }

            reader.Close();
            con.Close();
        }

        private void btn明細修改_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要修改訂單?", "訂單修改確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                int udselectmnn = 0;

                SqlConnection con1 = new SqlConnection(scsb.ToString());
                con1.Open();
                SqlCommand cmd1 = new SqlCommand(
                    "select * from menu where name = '" + cb品名.Text + "'", con1);
                SqlDataReader reader1 = cmd1.ExecuteReader();

                reader1.Read();
                udselectmnn = Convert.ToInt32(reader1[0]);

                reader1.Close();
                con1.Close();

                /***/

                int udselectmbn = 0;

                SqlConnection con2 = new SqlConnection(scsb.ToString());
                con2.Open();
                SqlCommand cmd2 = new SqlCommand(
                    "select * from member where name = '" + cb訂購人.Text + "'", con2);
                SqlDataReader reader2 = cmd2.ExecuteReader();

                reader2.Read();
                udselectmbn = Convert.ToInt32(reader2[0]);

                reader2.Close();
                con2.Close();

                /***/

                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "Update order_detail set member_number=@member_number, menu_number=@menu_number, quantity=@quantity, price=@price, note=@note Where detail_number=@detail_number", con);

                cmd.Parameters.AddWithValue("@detail_number", cb明細修改.Text);
                cmd.Parameters.AddWithValue("@member_number", udselectmbn);
                cmd.Parameters.AddWithValue("@menu_number", udselectmnn);
                cmd.Parameters.AddWithValue("@quantity", tb數量.Text);
                cmd.Parameters.AddWithValue("@price", tb單價.Text);
                cmd.Parameters.AddWithValue("@note", tb備註.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
                MessageBox.Show(TimeNow + String.Format("\n訂單修改完畢, 影響{0}筆資料", rows), "通知");
                tb系統訊息.Text += "[" + TimeNow + "]" + String.Format(" 修改{0}筆訂購資料!\r\n", rows);

                this.bindMyGridView1();
                this.bindMyGridView2();
                cb明細修改.Text = "選擇明細編號";
                this.cbodud();
                cb清單刪除.Text = "選擇明細編號";
                this.oddelete();
            }
        }

        private void oddelete()
        {
            cb清單刪除.Items.Clear();

            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "select * from order_detail where master_number in (select master_number from order_master where bdocheck=0)", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb清單刪除.Items.Add(reader[0]);
            }

            reader.Close();
            con.Close();
        }

        private void btn清單刪除確認_Click(object sender, EventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("您確認要刪除此筆訂單?", "訂購刪除確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drResult == DialogResult.Cancel)
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "Delete from order_detail Where detail_number=@detail_number", con);

                cmd.Parameters.AddWithValue("@detail_number", cb清單刪除.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                string TimeNow = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us")));
                MessageBox.Show(TimeNow + String.Format("\n刪除訂單完畢, 影響{0}筆資料", rows), "通知");
                tb系統訊息.Text += "[" + TimeNow + "]" + String.Format(" 刪除{0}筆訂購資料!\r\n", rows);

                this.bindMyGridView1();
                this.bindMyGridView2();
                cb明細修改.Text = "選擇明細編號";
                this.cbodud();
                cb清單刪除.Text = "選擇明細編號";
                this.oddelete();
            }
        }       

        private void btn登入_Click(object sender, EventArgs e)
        {
            if (cb值日生.Text.Length >= 6)
            {
                string memberlogin = "";
                memberlogin = "值日生未選擇!\n請先選擇本日值日生再登入。";
                MessageBox.Show(memberlogin, "無法登入", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else
            {
                lbl今日值日生.Text = cb值日生.Text;
                tb系統訊息.Text = "[" + String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                    new System.Globalization.CultureInfo("en-us"))) + "]" +
                    " 登入完成! " + cb值日生.Text + "\r\n";

                cb期別.Enabled = false;
                cb值日生.Enabled = false;
                btn登入.Enabled = false;
                btn登出.Enabled = true;

                this.bindMyGridView1();
                this.bindMyGridView2();

                dataGridView1.Visible = true;
                lbl店家.Visible = true;
                cb店家.Visible = true;
                btn開始訂購.Visible = true;
                lbl取消訂購.Visible = true;
                cb取消訂購.Visible = true;
                btn取消訂購確認.Visible = true;

                dataGridView2.Visible = true;
                lbl姓名.Visible = true;
                cb訂購人.Visible = true;
                lbl品名.Visible = true;
                cb品名.Visible = true;
                lbl單價.Visible = true;
                tb單價.Visible = true;
                lbl數量.Visible = true;
                tb數量.Visible = true;
                lbl備註.Visible = true;
                tb備註.Visible = true;
                btn全部清除.Visible = true;
                btn送出.Visible = true;
                lbl明細修改.Visible = true;
                cb明細修改.Visible = true;
                btn明細修改.Visible = true;
                lbl清單刪除.Visible = true;
                cb清單刪除.Visible = true;
                btn清單刪除確認.Visible = true;
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
                lbl今日值日生.Text = "值日生未選擇";
                cb期別.Text = "請選擇期別";
                cb值日生.Text = "請選擇值日生";
                tb系統訊息.Text = "您好! 歡迎使用本系統!\r\n請選擇今日的值日生登入!\r\n";

                cb期別.Enabled = true;
                cb值日生.Enabled = true;
                btn登入.Enabled = true;
                btn登出.Enabled = false;

                cb店家.Text = "請選擇店家";
                cb取消訂購.Text = "選擇訂單編號";

                cb訂購人.Text = "請選擇訂購人";
                cb品名.Text = "請選擇品名";
                tb單價.Text = "0";
                tb數量.Text = "0";
                tb備註.Clear();                
                cb明細修改.Text = "選擇明細編號";
                cb清單刪除.Text = "選擇明細編號";

                dataGridView1.Visible = false;
                lbl店家.Visible = false;
                cb店家.Visible = false;
                btn開始訂購.Visible = false;
                lbl取消訂購.Visible = false;
                cb取消訂購.Visible = false;
                btn取消訂購確認.Visible = false;

                dataGridView2.Visible = false;
                lbl姓名.Visible = false;
                cb訂購人.Visible = false;
                lbl品名.Visible = false;
                cb品名.Visible = false;
                lbl單價.Visible = false;
                tb單價.Visible = false;
                lbl數量.Visible = false;
                tb數量.Visible = false;
                lbl備註.Visible = false;
                tb備註.Visible = false;
                btn全部清除.Visible = false;
                btn送出.Visible = false;
                lbl明細修改.Visible = false;
                cb明細修改.Visible = false;
                btn明細修改.Visible = false;
                lbl清單刪除.Visible = false;
                cb清單刪除.Visible = false;
                btn清單刪除確認.Visible = false;
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
                FormClose = "目前值日生登入中!\n請值日生先登出再結束程式。";
                MessageBox.Show(FormClose, "無法關閉", MessageBoxButtons.OK, MessageBoxIcon.Warning);              
            }
        }                        
    }
}
