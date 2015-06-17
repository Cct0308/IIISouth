namespace Beverage_POS__Simple_
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSB本日業績 = new System.Windows.Forms.ToolStripButton();
            this.tSB小算盤 = new System.Windows.Forms.ToolStripButton();
            this.tSB使用說明 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSB登入 = new System.Windows.Forms.ToolStripButton();
            this.tSB登出 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSB關閉 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB本日業績,
            this.tSB小算盤,
            this.tSB使用說明,
            this.toolStripSeparator2,
            this.tSB登入,
            this.tSB登出,
            this.toolStripSeparator1,
            this.tSB關閉});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1584, 55);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSB本日業績
            // 
            this.tSB本日業績.Image = ((System.Drawing.Image)(resources.GetObject("tSB本日業績.Image")));
            this.tSB本日業績.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB本日業績.Name = "tSB本日業績";
            this.tSB本日業績.Size = new System.Drawing.Size(60, 52);
            this.tSB本日業績.Text = "本日業績";
            this.tSB本日業績.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSB本日業績.Click += new System.EventHandler(this.tSB本日業績_Click);
            // 
            // tSB小算盤
            // 
            this.tSB小算盤.Image = ((System.Drawing.Image)(resources.GetObject("tSB小算盤.Image")));
            this.tSB小算盤.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB小算盤.Name = "tSB小算盤";
            this.tSB小算盤.Size = new System.Drawing.Size(48, 52);
            this.tSB小算盤.Text = "小算盤";
            this.tSB小算盤.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSB小算盤.Click += new System.EventHandler(this.tSB小算盤_Click);
            // 
            // tSB使用說明
            // 
            this.tSB使用說明.Image = ((System.Drawing.Image)(resources.GetObject("tSB使用說明.Image")));
            this.tSB使用說明.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB使用說明.Name = "tSB使用說明";
            this.tSB使用說明.Size = new System.Drawing.Size(60, 52);
            this.tSB使用說明.Text = "使用說明";
            this.tSB使用說明.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSB使用說明.Click += new System.EventHandler(this.tSB使用說明_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // tSB登入
            // 
            this.tSB登入.Image = ((System.Drawing.Image)(resources.GetObject("tSB登入.Image")));
            this.tSB登入.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB登入.Name = "tSB登入";
            this.tSB登入.Size = new System.Drawing.Size(60, 52);
            this.tSB登入.Text = "系統登入";
            this.tSB登入.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSB登入.Click += new System.EventHandler(this.tSB登入_Click);
            // 
            // tSB登出
            // 
            this.tSB登出.Image = ((System.Drawing.Image)(resources.GetObject("tSB登出.Image")));
            this.tSB登出.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB登出.Name = "tSB登出";
            this.tSB登出.Size = new System.Drawing.Size(60, 52);
            this.tSB登出.Text = "系統登出";
            this.tSB登出.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSB登出.Click += new System.EventHandler(this.tSB登出_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // tSB關閉
            // 
            this.tSB關閉.Image = ((System.Drawing.Image)(resources.GetObject("tSB關閉.Image")));
            this.tSB關閉.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB關閉.Name = "tSB關閉";
            this.tSB關閉.Size = new System.Drawing.Size(60, 52);
            this.tSB關閉.Text = "程式關閉";
            this.tSB關閉.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tSB關閉.Click += new System.EventHandler(this.tSB關閉_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 840);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1584, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1536, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = " ";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel2.Text = " ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel3.Text = " ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel4.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://www.google.com.tw/";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 862);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB本日業績;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripButton tSB使用說明;
        private System.Windows.Forms.ToolStripButton tSB登入;
        private System.Windows.Forms.ToolStripButton tSB登出;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tSB關閉;
        private System.Windows.Forms.ToolStripButton tSB小算盤;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}