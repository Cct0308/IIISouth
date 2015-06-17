using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_POS__Simple_
{
    public partial class Main : Form
    {
        Form1 f1 = new Form1();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string mainDate = f1.reportDate;

            toolStripStatusLabel1.Text = "就緒";
            toolStripStatusLabel2.Text = mainDate;
            timer1.Enabled = true;

            (new Login()).ShowDialog();

            Form1 f = new Form1();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void tSB本日業績_Click(object sender, EventArgs e)
        {
            string mainDate = f1.reportDate;
            Process.Start(mainDate + ".xls");
        }

        private void tSB使用說明_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Index);
        }

        private void tSB小算盤_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\System32\Calc.exe");
        }

        private void tSB登入_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                (new Login()).ShowDialog();

                Form1 f = new Form1();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void tSB登出_Click(object sender, EventArgs e)
        {
            logOut();
        }        

        private void tSB關閉_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要關閉程式嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                logOut();
                Application.Exit();
            }
        }   

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = String.Format(DateTime.Now.ToString("hh:mm:ss tt",
                new System.Globalization.CultureInfo("en-us")));
        }

        private void logOut()
        {
            Form1 f = this.ActiveMdiChild as Form1;
            if (this.ActiveMdiChild != null)
            {
                f.frmclose();
                this.ActiveMdiChild.Close();
            }
        }
    }
}
