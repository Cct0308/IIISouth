using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            (new Login()).ShowDialog();

            toolStripStatusLabel1.Text = "就緒";
            toolStripStatusLabel3.Text = "登入：yooo";
            toolStripStatusLabel2.Text = DateTime.Now.ToString("yyyy-MM-dd"); 
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmTree f = new FrmTree();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmGrid f = new FrmGrid();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Form1 f = this.ActiveMdiChild as Form1;

            if (this.ActiveMdiChild != null)
                f.moveFirst();            
        }       

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Form1 f = this.ActiveMdiChild as Form1;

            if (this.ActiveMdiChild != null)
                f.moveLeft();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                (this.ActiveMdiChild as IUiListener).moveRight();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                (this.ActiveMdiChild as IUiListener).moveLast();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Index);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要離開嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void 水平排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void 階梯式排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void 關閉目前視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void 關閉所有視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }          
    }
}
