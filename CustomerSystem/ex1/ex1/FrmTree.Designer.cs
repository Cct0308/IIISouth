namespace ex1
{
    partial class FrmTree
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(138, 12);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(235, 12);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(235, 44);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(138, 44);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(235, 76);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(138, 76);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(235, 108);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(138, 108);
            // 
            // txtAddrs
            // 
            this.txtAddrs.Location = new System.Drawing.Point(235, 140);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(138, 140);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(120, 157);
            this.treeView1.TabIndex = 16;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // FrmTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 180);
            this.Controls.Add(this.treeView1);
            this.Name = "FrmTree";
            this.Text = "FrmTree";
            this.Load += new System.EventHandler(this.FrmTree_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtAddrs, 0);
            this.Controls.SetChildIndex(this.treeView1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}