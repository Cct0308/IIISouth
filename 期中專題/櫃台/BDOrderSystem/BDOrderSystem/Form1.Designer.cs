namespace BDOrderSystem
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl目前日期title = new System.Windows.Forms.Label();
            this.lbl目前日期 = new System.Windows.Forms.Label();
            this.lbl目前時間title = new System.Windows.Forms.Label();
            this.lbl目前時間 = new System.Windows.Forms.Label();
            this.gb櫃台作業 = new System.Windows.Forms.GroupBox();
            this.btn程式結束 = new System.Windows.Forms.Button();
            this.gb統計 = new System.Windows.Forms.GroupBox();
            this.tb總價 = new System.Windows.Forms.TextBox();
            this.tb總數 = new System.Windows.Forms.TextBox();
            this.lbl總價 = new System.Windows.Forms.Label();
            this.lbl總數 = new System.Windows.Forms.Label();
            this.gb選擇訂單 = new System.Windows.Forms.GroupBox();
            this.btn選擇訂單編號確認 = new System.Windows.Forms.Button();
            this.cb選擇訂單編號 = new System.Windows.Forms.ComboBox();
            this.timer目前時間 = new System.Windows.Forms.Timer(this.components);
            this.gb訂單狀態 = new System.Windows.Forms.GroupBox();
            this.btn訂購完成確認 = new System.Windows.Forms.Button();
            this.gb訂單 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb選擇訂單日期 = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lbl個 = new System.Windows.Forms.Label();
            this.lbl元 = new System.Windows.Forms.Label();
            this.rb訂購完成 = new System.Windows.Forms.RadioButton();
            this.rb訂購取消 = new System.Windows.Forms.RadioButton();
            this.lbl選擇訂單日期 = new System.Windows.Forms.Label();
            this.lbl選擇訂單編號 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.gb櫃台作業.SuspendLayout();
            this.gb統計.SuspendLayout();
            this.gb選擇訂單.SuspendLayout();
            this.gb訂單狀態.SuspendLayout();
            this.gb訂單.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 446);
            this.label7.TabIndex = 4;
            this.label7.Text = "歡迎使用本系統!\r\n請輸入您的帳號及密碼登入!\r\n";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 468);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "系統訊息";
            // 
            // lbl目前日期title
            // 
            this.lbl目前日期title.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl目前日期title.Location = new System.Drawing.Point(6, 19);
            this.lbl目前日期title.Name = "lbl目前日期title";
            this.lbl目前日期title.Size = new System.Drawing.Size(78, 21);
            this.lbl目前日期title.TabIndex = 1;
            this.lbl目前日期title.Text = "目前日期 :";
            this.lbl目前日期title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl目前日期
            // 
            this.lbl目前日期.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl目前日期.Location = new System.Drawing.Point(90, 19);
            this.lbl目前日期.Name = "lbl目前日期";
            this.lbl目前日期.Size = new System.Drawing.Size(127, 21);
            this.lbl目前日期.TabIndex = 3;
            this.lbl目前日期.Text = "2015年02月05日";
            this.lbl目前日期.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl目前時間title
            // 
            this.lbl目前時間title.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl目前時間title.Location = new System.Drawing.Point(6, 40);
            this.lbl目前時間title.Name = "lbl目前時間title";
            this.lbl目前時間title.Size = new System.Drawing.Size(78, 21);
            this.lbl目前時間title.TabIndex = 4;
            this.lbl目前時間title.Text = "目前時間 :";
            this.lbl目前時間title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl目前時間
            // 
            this.lbl目前時間.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl目前時間.Location = new System.Drawing.Point(90, 40);
            this.lbl目前時間.Name = "lbl目前時間";
            this.lbl目前時間.Size = new System.Drawing.Size(127, 21);
            this.lbl目前時間.TabIndex = 5;
            this.lbl目前時間.Text = "00:00:00 AM";
            this.lbl目前時間.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gb櫃台作業
            // 
            this.gb櫃台作業.Controls.Add(this.lbl目前時間);
            this.gb櫃台作業.Controls.Add(this.lbl目前時間title);
            this.gb櫃台作業.Controls.Add(this.lbl目前日期);
            this.gb櫃台作業.Controls.Add(this.lbl目前日期title);
            this.gb櫃台作業.Location = new System.Drawing.Point(12, 12);
            this.gb櫃台作業.Name = "gb櫃台作業";
            this.gb櫃台作業.Size = new System.Drawing.Size(223, 66);
            this.gb櫃台作業.TabIndex = 1;
            this.gb櫃台作業.TabStop = false;
            this.gb櫃台作業.Text = "BDOrderSystem櫃台作業";
            // 
            // btn程式結束
            // 
            this.btn程式結束.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn程式結束.Location = new System.Drawing.Point(12, 515);
            this.btn程式結束.Name = "btn程式結束";
            this.btn程式結束.Size = new System.Drawing.Size(68, 35);
            this.btn程式結束.TabIndex = 9;
            this.btn程式結束.Text = "程式結束";
            this.btn程式結束.UseVisualStyleBackColor = true;
            this.btn程式結束.Click += new System.EventHandler(this.btn程式結束_Click);
            // 
            // gb統計
            // 
            this.gb統計.Controls.Add(this.lbl元);
            this.gb統計.Controls.Add(this.lbl個);
            this.gb統計.Controls.Add(this.tb總價);
            this.gb統計.Controls.Add(this.tb總數);
            this.gb統計.Controls.Add(this.lbl總價);
            this.gb統計.Controls.Add(this.lbl總數);
            this.gb統計.Location = new System.Drawing.Point(12, 224);
            this.gb統計.Name = "gb統計";
            this.gb統計.Size = new System.Drawing.Size(223, 157);
            this.gb統計.TabIndex = 0;
            this.gb統計.TabStop = false;
            this.gb統計.Text = "統計";
            // 
            // tb總價
            // 
            this.tb總價.Enabled = false;
            this.tb總價.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb總價.Location = new System.Drawing.Point(74, 82);
            this.tb總價.Name = "tb總價";
            this.tb總價.Size = new System.Drawing.Size(75, 33);
            this.tb總價.TabIndex = 13;
            this.tb總價.Text = "0";
            this.tb總價.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb總數
            // 
            this.tb總數.Enabled = false;
            this.tb總數.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb總數.Location = new System.Drawing.Point(74, 34);
            this.tb總數.Name = "tb總數";
            this.tb總數.Size = new System.Drawing.Size(75, 33);
            this.tb總數.TabIndex = 2;
            this.tb總數.Text = "0";
            this.tb總數.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl總價
            // 
            this.lbl總價.AutoSize = true;
            this.lbl總價.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總價.Location = new System.Drawing.Point(20, 91);
            this.lbl總價.Name = "lbl總價";
            this.lbl總價.Size = new System.Drawing.Size(48, 24);
            this.lbl總價.TabIndex = 12;
            this.lbl總價.Text = "總價";
            // 
            // lbl總數
            // 
            this.lbl總數.AutoSize = true;
            this.lbl總數.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總數.Location = new System.Drawing.Point(20, 43);
            this.lbl總數.Name = "lbl總數";
            this.lbl總數.Size = new System.Drawing.Size(48, 24);
            this.lbl總數.TabIndex = 11;
            this.lbl總數.Text = "總數";
            // 
            // gb選擇訂單
            // 
            this.gb選擇訂單.Controls.Add(this.lbl選擇訂單日期);
            this.gb選擇訂單.Controls.Add(this.lbl選擇訂單編號);
            this.gb選擇訂單.Controls.Add(this.cb選擇訂單日期);
            this.gb選擇訂單.Controls.Add(this.btn選擇訂單編號確認);
            this.gb選擇訂單.Controls.Add(this.cb選擇訂單編號);
            this.gb選擇訂單.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gb選擇訂單.Location = new System.Drawing.Point(12, 84);
            this.gb選擇訂單.Name = "gb選擇訂單";
            this.gb選擇訂單.Size = new System.Drawing.Size(223, 134);
            this.gb選擇訂單.TabIndex = 0;
            this.gb選擇訂單.TabStop = false;
            this.gb選擇訂單.Text = "選擇訂單";
            // 
            // btn選擇訂單編號確認
            // 
            this.btn選擇訂單編號確認.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn選擇訂單編號確認.Location = new System.Drawing.Point(160, 95);
            this.btn選擇訂單編號確認.Name = "btn選擇訂單編號確認";
            this.btn選擇訂單編號確認.Size = new System.Drawing.Size(57, 32);
            this.btn選擇訂單編號確認.TabIndex = 1;
            this.btn選擇訂單編號確認.Text = "確認";
            this.btn選擇訂單編號確認.UseVisualStyleBackColor = true;
            this.btn選擇訂單編號確認.Click += new System.EventHandler(this.btn選擇訂單編號確認_Click);
            // 
            // cb選擇訂單編號
            // 
            this.cb選擇訂單編號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb選擇訂單編號.FormattingEnabled = true;
            this.cb選擇訂單編號.Location = new System.Drawing.Point(54, 60);
            this.cb選擇訂單編號.Name = "cb選擇訂單編號";
            this.cb選擇訂單編號.Size = new System.Drawing.Size(163, 29);
            this.cb選擇訂單編號.TabIndex = 0;
            this.cb選擇訂單編號.Text = "請選擇訂單編號";
            // 
            // timer目前時間
            // 
            this.timer目前時間.Interval = 10;
            this.timer目前時間.Tick += new System.EventHandler(this.timer目前時間_Tick);
            // 
            // gb訂單狀態
            // 
            this.gb訂單狀態.Controls.Add(this.rb訂購取消);
            this.gb訂單狀態.Controls.Add(this.btn訂購完成確認);
            this.gb訂單狀態.Controls.Add(this.rb訂購完成);
            this.gb訂單狀態.Location = new System.Drawing.Point(12, 387);
            this.gb訂單狀態.Name = "gb訂單狀態";
            this.gb訂單狀態.Size = new System.Drawing.Size(223, 64);
            this.gb訂單狀態.TabIndex = 10;
            this.gb訂單狀態.TabStop = false;
            this.gb訂單狀態.Text = "訂單狀態";
            // 
            // btn訂購完成確認
            // 
            this.btn訂購完成確認.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂購完成確認.Location = new System.Drawing.Point(160, 20);
            this.btn訂購完成確認.Name = "btn訂購完成確認";
            this.btn訂購完成確認.Size = new System.Drawing.Size(57, 28);
            this.btn訂購完成確認.TabIndex = 11;
            this.btn訂購完成確認.Text = "確認";
            this.btn訂購完成確認.UseVisualStyleBackColor = true;
            this.btn訂購完成確認.Click += new System.EventHandler(this.btn訂購完成確認_Click);
            // 
            // gb訂單
            // 
            this.gb訂單.Controls.Add(this.dataGridView3);
            this.gb訂單.Controls.Add(this.dataGridView2);
            this.gb訂單.Controls.Add(this.dataGridView1);
            this.gb訂單.Location = new System.Drawing.Point(241, 12);
            this.gb訂單.Name = "gb訂單";
            this.gb訂單.Size = new System.Drawing.Size(531, 538);
            this.gb訂單.TabIndex = 11;
            this.gb訂單.TabStop = false;
            this.gb訂單.Text = "訂單";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(6, 126);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(519, 200);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(519, 100);
            this.dataGridView1.TabIndex = 0;
            // 
            // cb選擇訂單日期
            // 
            this.cb選擇訂單日期.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb選擇訂單日期.FormattingEnabled = true;
            this.cb選擇訂單日期.Location = new System.Drawing.Point(54, 22);
            this.cb選擇訂單日期.Name = "cb選擇訂單日期";
            this.cb選擇訂單日期.Size = new System.Drawing.Size(163, 29);
            this.cb選擇訂單日期.TabIndex = 2;
            this.cb選擇訂單日期.Text = "請選擇訂單日期";
            this.cb選擇訂單日期.SelectedIndexChanged += new System.EventHandler(this.cb選擇訂單日期_SelectedIndexChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Enabled = false;
            this.dataGridView3.Location = new System.Drawing.Point(6, 332);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(519, 200);
            this.dataGridView3.TabIndex = 2;
            // 
            // lbl個
            // 
            this.lbl個.AutoSize = true;
            this.lbl個.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl個.Location = new System.Drawing.Point(155, 43);
            this.lbl個.Name = "lbl個";
            this.lbl個.Size = new System.Drawing.Size(29, 24);
            this.lbl個.TabIndex = 14;
            this.lbl個.Text = "個";
            // 
            // lbl元
            // 
            this.lbl元.AutoSize = true;
            this.lbl元.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl元.Location = new System.Drawing.Point(155, 91);
            this.lbl元.Name = "lbl元";
            this.lbl元.Size = new System.Drawing.Size(29, 24);
            this.lbl元.TabIndex = 15;
            this.lbl元.Text = "元";
            // 
            // rb訂購完成
            // 
            this.rb訂購完成.AutoSize = true;
            this.rb訂購完成.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb訂購完成.Location = new System.Drawing.Point(23, 22);
            this.rb訂購完成.Name = "rb訂購完成";
            this.rb訂購完成.Size = new System.Drawing.Size(60, 25);
            this.rb訂購完成.TabIndex = 12;
            this.rb訂購完成.TabStop = true;
            this.rb訂購完成.Text = "完成";
            this.rb訂購完成.UseVisualStyleBackColor = true;
            this.rb訂購完成.CheckedChanged += new System.EventHandler(this.rb訂購完成_CheckedChanged);
            // 
            // rb訂購取消
            // 
            this.rb訂購取消.AutoSize = true;
            this.rb訂購取消.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rb訂購取消.Location = new System.Drawing.Point(89, 22);
            this.rb訂購取消.Name = "rb訂購取消";
            this.rb訂購取消.Size = new System.Drawing.Size(60, 25);
            this.rb訂購取消.TabIndex = 13;
            this.rb訂購取消.TabStop = true;
            this.rb訂購取消.Text = "取消";
            this.rb訂購取消.UseVisualStyleBackColor = true;
            this.rb訂購取消.CheckedChanged += new System.EventHandler(this.rb訂購取消_CheckedChanged);
            // 
            // lbl選擇訂單日期
            // 
            this.lbl選擇訂單日期.AutoSize = true;
            this.lbl選擇訂單日期.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl選擇訂單日期.Location = new System.Drawing.Point(6, 25);
            this.lbl選擇訂單日期.Name = "lbl選擇訂單日期";
            this.lbl選擇訂單日期.Size = new System.Drawing.Size(42, 21);
            this.lbl選擇訂單日期.TabIndex = 12;
            this.lbl選擇訂單日期.Text = "日期";
            // 
            // lbl選擇訂單編號
            // 
            this.lbl選擇訂單編號.AutoSize = true;
            this.lbl選擇訂單編號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl選擇訂單編號.Location = new System.Drawing.Point(6, 63);
            this.lbl選擇訂單編號.Name = "lbl選擇訂單編號";
            this.lbl選擇訂單編號.Size = new System.Drawing.Size(42, 21);
            this.lbl選擇訂單編號.TabIndex = 13;
            this.lbl選擇訂單編號.Text = "編號";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.gb訂單);
            this.Controls.Add(this.gb訂單狀態);
            this.Controls.Add(this.gb統計);
            this.Controls.Add(this.btn程式結束);
            this.Controls.Add(this.gb選擇訂單);
            this.Controls.Add(this.gb櫃台作業);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.gb櫃台作業.ResumeLayout(false);
            this.gb統計.ResumeLayout(false);
            this.gb統計.PerformLayout();
            this.gb選擇訂單.ResumeLayout(false);
            this.gb選擇訂單.PerformLayout();
            this.gb訂單狀態.ResumeLayout(false);
            this.gb訂單狀態.PerformLayout();
            this.gb訂單.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl目前日期title;
        private System.Windows.Forms.Label lbl目前日期;
        private System.Windows.Forms.Label lbl目前時間title;
        private System.Windows.Forms.Label lbl目前時間;
        private System.Windows.Forms.GroupBox gb櫃台作業;
        private System.Windows.Forms.Button btn程式結束;
        private System.Windows.Forms.GroupBox gb統計;
        private System.Windows.Forms.GroupBox gb選擇訂單;
        private System.Windows.Forms.Timer timer目前時間;
        private System.Windows.Forms.Button btn選擇訂單編號確認;
        private System.Windows.Forms.ComboBox cb選擇訂單編號;
        private System.Windows.Forms.Label lbl總價;
        private System.Windows.Forms.Label lbl總數;
        private System.Windows.Forms.GroupBox gb訂單狀態;
        private System.Windows.Forms.Button btn訂購完成確認;
        private System.Windows.Forms.GroupBox gb訂單;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb總價;
        private System.Windows.Forms.TextBox tb總數;
        private System.Windows.Forms.ComboBox cb選擇訂單日期;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lbl元;
        private System.Windows.Forms.Label lbl個;
        private System.Windows.Forms.RadioButton rb訂購完成;
        private System.Windows.Forms.RadioButton rb訂購取消;
        private System.Windows.Forms.Label lbl選擇訂單日期;
        private System.Windows.Forms.Label lbl選擇訂單編號;


    }
}

