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
            this.lbl今日值日生title = new System.Windows.Forms.Label();
            this.lbl目前時間title = new System.Windows.Forms.Label();
            this.lbl今日值日生 = new System.Windows.Forms.Label();
            this.lbl目前時間 = new System.Windows.Forms.Label();
            this.gb訂購作業 = new System.Windows.Forms.GroupBox();
            this.btn程式結束 = new System.Windows.Forms.Button();
            this.gb系統訊息 = new System.Windows.Forms.GroupBox();
            this.tb系統訊息 = new System.Windows.Forms.TextBox();
            this.lbl期別 = new System.Windows.Forms.Label();
            this.lbl店家 = new System.Windows.Forms.Label();
            this.btn登入 = new System.Windows.Forms.Button();
            this.btn登出 = new System.Windows.Forms.Button();
            this.gb值日生登入 = new System.Windows.Forms.GroupBox();
            this.cb值日生 = new System.Windows.Forms.ComboBox();
            this.lbl值日生 = new System.Windows.Forms.Label();
            this.cb期別 = new System.Windows.Forms.ComboBox();
            this.timer目前時間 = new System.Windows.Forms.Timer(this.components);
            this.cb店家 = new System.Windows.Forms.ComboBox();
            this.btn全部清除 = new System.Windows.Forms.Button();
            this.lbl品名 = new System.Windows.Forms.Label();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.lbl數量 = new System.Windows.Forms.Label();
            this.lbl備註 = new System.Windows.Forms.Label();
            this.cb品名 = new System.Windows.Forms.ComboBox();
            this.tb單價 = new System.Windows.Forms.TextBox();
            this.tb數量 = new System.Windows.Forms.TextBox();
            this.tb備註 = new System.Windows.Forms.TextBox();
            this.lbl姓名 = new System.Windows.Forms.Label();
            this.cb訂購人 = new System.Windows.Forms.ComboBox();
            this.btn送出 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn開始訂購 = new System.Windows.Forms.Button();
            this.btn明細修改 = new System.Windows.Forms.Button();
            this.btn清單刪除確認 = new System.Windows.Forms.Button();
            this.cb清單刪除 = new System.Windows.Forms.ComboBox();
            this.lbl清單刪除 = new System.Windows.Forms.Label();
            this.lbl取消訂購 = new System.Windows.Forms.Label();
            this.cb取消訂購 = new System.Windows.Forms.ComboBox();
            this.btn取消訂購確認 = new System.Windows.Forms.Button();
            this.lbl明細修改 = new System.Windows.Forms.Label();
            this.cb明細修改 = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.gb訂購作業.SuspendLayout();
            this.gb系統訊息.SuspendLayout();
            this.gb值日生登入.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.lbl目前日期title.Location = new System.Drawing.Point(6, 40);
            this.lbl目前日期title.Name = "lbl目前日期title";
            this.lbl目前日期title.Size = new System.Drawing.Size(78, 21);
            this.lbl目前日期title.TabIndex = 1;
            this.lbl目前日期title.Text = "目前日期 :";
            this.lbl目前日期title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl目前日期
            // 
            this.lbl目前日期.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl目前日期.Location = new System.Drawing.Point(90, 40);
            this.lbl目前日期.Name = "lbl目前日期";
            this.lbl目前日期.Size = new System.Drawing.Size(127, 21);
            this.lbl目前日期.TabIndex = 3;
            this.lbl目前日期.Text = "2015年02月05日";
            this.lbl目前日期.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl今日值日生title
            // 
            this.lbl今日值日生title.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl今日值日生title.Location = new System.Drawing.Point(6, 19);
            this.lbl今日值日生title.Name = "lbl今日值日生title";
            this.lbl今日值日生title.Size = new System.Drawing.Size(100, 21);
            this.lbl今日值日生title.TabIndex = 0;
            this.lbl今日值日生title.Text = "今日值日生 :";
            this.lbl今日值日生title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl目前時間title
            // 
            this.lbl目前時間title.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl目前時間title.Location = new System.Drawing.Point(6, 61);
            this.lbl目前時間title.Name = "lbl目前時間title";
            this.lbl目前時間title.Size = new System.Drawing.Size(78, 21);
            this.lbl目前時間title.TabIndex = 4;
            this.lbl目前時間title.Text = "目前時間 :";
            this.lbl目前時間title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl今日值日生
            // 
            this.lbl今日值日生.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl今日值日生.Location = new System.Drawing.Point(112, 19);
            this.lbl今日值日生.Name = "lbl今日值日生";
            this.lbl今日值日生.Size = new System.Drawing.Size(105, 21);
            this.lbl今日值日生.TabIndex = 2;
            this.lbl今日值日生.Text = "值日生未選擇";
            this.lbl今日值日生.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl目前時間
            // 
            this.lbl目前時間.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl目前時間.Location = new System.Drawing.Point(90, 61);
            this.lbl目前時間.Name = "lbl目前時間";
            this.lbl目前時間.Size = new System.Drawing.Size(127, 21);
            this.lbl目前時間.TabIndex = 5;
            this.lbl目前時間.Text = "00:00:00 AM";
            this.lbl目前時間.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gb訂購作業
            // 
            this.gb訂購作業.Controls.Add(this.lbl目前時間);
            this.gb訂購作業.Controls.Add(this.lbl今日值日生);
            this.gb訂購作業.Controls.Add(this.lbl目前時間title);
            this.gb訂購作業.Controls.Add(this.lbl今日值日生title);
            this.gb訂購作業.Controls.Add(this.lbl目前日期);
            this.gb訂購作業.Controls.Add(this.lbl目前日期title);
            this.gb訂購作業.Location = new System.Drawing.Point(12, 12);
            this.gb訂購作業.Name = "gb訂購作業";
            this.gb訂購作業.Size = new System.Drawing.Size(223, 87);
            this.gb訂購作業.TabIndex = 1;
            this.gb訂購作業.TabStop = false;
            this.gb訂購作業.Text = "BDOrderSystem訂購作業";
            // 
            // btn程式結束
            // 
            this.btn程式結束.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn程式結束.Location = new System.Drawing.Point(12, 683);
            this.btn程式結束.Name = "btn程式結束";
            this.btn程式結束.Size = new System.Drawing.Size(68, 35);
            this.btn程式結束.TabIndex = 9;
            this.btn程式結束.Text = "程式結束";
            this.btn程式結束.UseVisualStyleBackColor = true;
            this.btn程式結束.Click += new System.EventHandler(this.btn程式結束_Click);
            // 
            // gb系統訊息
            // 
            this.gb系統訊息.Controls.Add(this.tb系統訊息);
            this.gb系統訊息.Location = new System.Drawing.Point(12, 239);
            this.gb系統訊息.Name = "gb系統訊息";
            this.gb系統訊息.Size = new System.Drawing.Size(223, 438);
            this.gb系統訊息.TabIndex = 0;
            this.gb系統訊息.TabStop = false;
            this.gb系統訊息.Text = "系統訊息";
            // 
            // tb系統訊息
            // 
            this.tb系統訊息.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb系統訊息.Location = new System.Drawing.Point(6, 22);
            this.tb系統訊息.Multiline = true;
            this.tb系統訊息.Name = "tb系統訊息";
            this.tb系統訊息.ReadOnly = true;
            this.tb系統訊息.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb系統訊息.Size = new System.Drawing.Size(211, 410);
            this.tb系統訊息.TabIndex = 1;
            this.tb系統訊息.Text = "您好! 歡迎使用本系統!\r\n請選擇今日的值日生登入!\r\n";
            this.tb系統訊息.TextChanged += new System.EventHandler(this.tb系統訊息_TextChanged);
            // 
            // lbl期別
            // 
            this.lbl期別.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl期別.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl期別.Location = new System.Drawing.Point(6, 19);
            this.lbl期別.Name = "lbl期別";
            this.lbl期別.Size = new System.Drawing.Size(100, 29);
            this.lbl期別.TabIndex = 0;
            this.lbl期別.Text = "期別";
            // 
            // lbl店家
            // 
            this.lbl店家.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl店家.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl店家.Location = new System.Drawing.Point(241, 9);
            this.lbl店家.Name = "lbl店家";
            this.lbl店家.Size = new System.Drawing.Size(63, 29);
            this.lbl店家.TabIndex = 2;
            this.lbl店家.Text = "店家";
            // 
            // btn登入
            // 
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(6, 86);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(100, 35);
            this.btn登入.TabIndex = 1;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = true;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // btn登出
            // 
            this.btn登出.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登出.Location = new System.Drawing.Point(117, 86);
            this.btn登出.Name = "btn登出";
            this.btn登出.Size = new System.Drawing.Size(100, 35);
            this.btn登出.TabIndex = 4;
            this.btn登出.Text = "登出";
            this.btn登出.UseVisualStyleBackColor = true;
            this.btn登出.Click += new System.EventHandler(this.btn登出_Click);
            // 
            // gb值日生登入
            // 
            this.gb值日生登入.Controls.Add(this.cb值日生);
            this.gb值日生登入.Controls.Add(this.lbl值日生);
            this.gb值日生登入.Controls.Add(this.cb期別);
            this.gb值日生登入.Controls.Add(this.btn登出);
            this.gb值日生登入.Controls.Add(this.btn登入);
            this.gb值日生登入.Controls.Add(this.lbl期別);
            this.gb值日生登入.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gb值日生登入.Location = new System.Drawing.Point(12, 105);
            this.gb值日生登入.Name = "gb值日生登入";
            this.gb值日生登入.Size = new System.Drawing.Size(223, 128);
            this.gb值日生登入.TabIndex = 0;
            this.gb值日生登入.TabStop = false;
            this.gb值日生登入.Text = "值日生登入";
            // 
            // cb值日生
            // 
            this.cb值日生.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb值日生.FormattingEnabled = true;
            this.cb值日生.Location = new System.Drawing.Point(94, 51);
            this.cb值日生.Name = "cb值日生";
            this.cb值日生.Size = new System.Drawing.Size(123, 29);
            this.cb值日生.TabIndex = 7;
            this.cb值日生.Text = "請選擇值日生";
            // 
            // lbl值日生
            // 
            this.lbl值日生.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl值日生.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl值日生.Location = new System.Drawing.Point(6, 51);
            this.lbl值日生.Name = "lbl值日生";
            this.lbl值日生.Size = new System.Drawing.Size(100, 29);
            this.lbl值日生.TabIndex = 6;
            this.lbl值日生.Text = "值日生";
            // 
            // cb期別
            // 
            this.cb期別.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb期別.FormattingEnabled = true;
            this.cb期別.Location = new System.Drawing.Point(94, 19);
            this.cb期別.Name = "cb期別";
            this.cb期別.Size = new System.Drawing.Size(123, 29);
            this.cb期別.TabIndex = 5;
            this.cb期別.Text = "請選擇期別";
            this.cb期別.SelectedIndexChanged += new System.EventHandler(this.cb期別_SelectedIndexChanged);
            // 
            // timer目前時間
            // 
            this.timer目前時間.Interval = 10;
            this.timer目前時間.Tick += new System.EventHandler(this.timer目前時間_Tick);
            // 
            // cb店家
            // 
            this.cb店家.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb店家.FormattingEnabled = true;
            this.cb店家.Location = new System.Drawing.Point(310, 9);
            this.cb店家.Name = "cb店家";
            this.cb店家.Size = new System.Drawing.Size(123, 29);
            this.cb店家.TabIndex = 6;
            this.cb店家.Text = "請選擇店家";
            this.cb店家.SelectedIndexChanged += new System.EventHandler(this.cb店家_SelectedIndexChanged);
            // 
            // btn全部清除
            // 
            this.btn全部清除.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn全部清除.Location = new System.Drawing.Point(310, 402);
            this.btn全部清除.Name = "btn全部清除";
            this.btn全部清除.Size = new System.Drawing.Size(100, 29);
            this.btn全部清除.TabIndex = 10;
            this.btn全部清除.Text = "全部清除";
            this.btn全部清除.UseVisualStyleBackColor = true;
            this.btn全部清除.Click += new System.EventHandler(this.btn全部清除_Click);
            // 
            // lbl品名
            // 
            this.lbl品名.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl品名.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl品名.Location = new System.Drawing.Point(241, 331);
            this.lbl品名.Name = "lbl品名";
            this.lbl品名.Size = new System.Drawing.Size(63, 29);
            this.lbl品名.TabIndex = 13;
            this.lbl品名.Text = "品名";
            // 
            // lbl單價
            // 
            this.lbl單價.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl單價.Location = new System.Drawing.Point(439, 297);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(63, 29);
            this.lbl單價.TabIndex = 14;
            this.lbl單價.Text = "單價";
            // 
            // lbl數量
            // 
            this.lbl數量.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl數量.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl數量.Location = new System.Drawing.Point(439, 331);
            this.lbl數量.Name = "lbl數量";
            this.lbl數量.Size = new System.Drawing.Size(63, 29);
            this.lbl數量.TabIndex = 15;
            this.lbl數量.Text = "數量";
            // 
            // lbl備註
            // 
            this.lbl備註.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl備註.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl備註.Location = new System.Drawing.Point(241, 367);
            this.lbl備註.Name = "lbl備註";
            this.lbl備註.Size = new System.Drawing.Size(63, 29);
            this.lbl備註.TabIndex = 16;
            this.lbl備註.Text = "備註";
            // 
            // cb品名
            // 
            this.cb品名.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb品名.FormattingEnabled = true;
            this.cb品名.Location = new System.Drawing.Point(310, 332);
            this.cb品名.Name = "cb品名";
            this.cb品名.Size = new System.Drawing.Size(123, 29);
            this.cb品名.TabIndex = 17;
            this.cb品名.Text = "請選擇品名";
            this.cb品名.SelectedIndexChanged += new System.EventHandler(this.cb品名_SelectedIndexChanged);
            // 
            // tb單價
            // 
            this.tb單價.Enabled = false;
            this.tb單價.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb單價.Location = new System.Drawing.Point(508, 297);
            this.tb單價.Name = "tb單價";
            this.tb單價.Size = new System.Drawing.Size(123, 29);
            this.tb單價.TabIndex = 18;
            this.tb單價.Text = "0";
            this.tb單價.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb數量
            // 
            this.tb數量.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb數量.Location = new System.Drawing.Point(508, 331);
            this.tb數量.Name = "tb數量";
            this.tb數量.Size = new System.Drawing.Size(123, 29);
            this.tb數量.TabIndex = 19;
            this.tb數量.Text = "0";
            this.tb數量.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb備註
            // 
            this.tb備註.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb備註.Location = new System.Drawing.Point(310, 367);
            this.tb備註.Name = "tb備註";
            this.tb備註.Size = new System.Drawing.Size(321, 29);
            this.tb備註.TabIndex = 22;
            // 
            // lbl姓名
            // 
            this.lbl姓名.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl姓名.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl姓名.Location = new System.Drawing.Point(241, 297);
            this.lbl姓名.Name = "lbl姓名";
            this.lbl姓名.Size = new System.Drawing.Size(63, 29);
            this.lbl姓名.TabIndex = 23;
            this.lbl姓名.Text = "姓名";
            // 
            // cb訂購人
            // 
            this.cb訂購人.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb訂購人.FormattingEnabled = true;
            this.cb訂購人.Location = new System.Drawing.Point(310, 297);
            this.cb訂購人.Name = "cb訂購人";
            this.cb訂購人.Size = new System.Drawing.Size(123, 29);
            this.cb訂購人.TabIndex = 24;
            this.cb訂購人.Text = "請選擇訂購人";
            // 
            // btn送出
            // 
            this.btn送出.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn送出.Location = new System.Drawing.Point(574, 402);
            this.btn送出.Name = "btn送出";
            this.btn送出.Size = new System.Drawing.Size(57, 29);
            this.btn送出.TabIndex = 25;
            this.btn送出.Text = "送出";
            this.btn送出.UseVisualStyleBackColor = true;
            this.btn送出.Click += new System.EventHandler(this.btn送出_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(241, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 240);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(241, 437);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(755, 240);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btn開始訂購
            // 
            this.btn開始訂購.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn開始訂購.Location = new System.Drawing.Point(439, 7);
            this.btn開始訂購.Name = "btn開始訂購";
            this.btn開始訂購.Size = new System.Drawing.Size(100, 29);
            this.btn開始訂購.TabIndex = 28;
            this.btn開始訂購.Text = "開始訂購";
            this.btn開始訂購.UseVisualStyleBackColor = true;
            this.btn開始訂購.Click += new System.EventHandler(this.btn開始訂購_Click);
            // 
            // btn明細修改
            // 
            this.btn明細修改.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn明細修改.Location = new System.Drawing.Point(939, 331);
            this.btn明細修改.Name = "btn明細修改";
            this.btn明細修改.Size = new System.Drawing.Size(57, 29);
            this.btn明細修改.TabIndex = 30;
            this.btn明細修改.Text = "確認";
            this.btn明細修改.UseVisualStyleBackColor = true;
            this.btn明細修改.Click += new System.EventHandler(this.btn明細修改_Click);
            // 
            // btn清單刪除確認
            // 
            this.btn清單刪除確認.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清單刪除確認.Location = new System.Drawing.Point(939, 402);
            this.btn清單刪除確認.Name = "btn清單刪除確認";
            this.btn清單刪除確認.Size = new System.Drawing.Size(57, 29);
            this.btn清單刪除確認.TabIndex = 31;
            this.btn清單刪除確認.Text = "確認";
            this.btn清單刪除確認.UseVisualStyleBackColor = true;
            this.btn清單刪除確認.Click += new System.EventHandler(this.btn清單刪除確認_Click);
            // 
            // cb清單刪除
            // 
            this.cb清單刪除.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb清單刪除.FormattingEnabled = true;
            this.cb清單刪除.Location = new System.Drawing.Point(810, 402);
            this.cb清單刪除.Name = "cb清單刪除";
            this.cb清單刪除.Size = new System.Drawing.Size(123, 29);
            this.cb清單刪除.TabIndex = 32;
            this.cb清單刪除.Text = "選擇明細編號";
            // 
            // lbl清單刪除
            // 
            this.lbl清單刪除.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl清單刪除.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl清單刪除.Location = new System.Drawing.Point(741, 402);
            this.lbl清單刪除.Name = "lbl清單刪除";
            this.lbl清單刪除.Size = new System.Drawing.Size(63, 29);
            this.lbl清單刪除.TabIndex = 33;
            this.lbl清單刪除.Text = "刪除";
            // 
            // lbl取消訂購
            // 
            this.lbl取消訂購.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl取消訂購.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl取消訂購.Location = new System.Drawing.Point(694, 9);
            this.lbl取消訂購.Name = "lbl取消訂購";
            this.lbl取消訂購.Size = new System.Drawing.Size(110, 29);
            this.lbl取消訂購.TabIndex = 36;
            this.lbl取消訂購.Text = "取消訂購";
            // 
            // cb取消訂購
            // 
            this.cb取消訂購.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb取消訂購.FormattingEnabled = true;
            this.cb取消訂購.Location = new System.Drawing.Point(810, 9);
            this.cb取消訂購.Name = "cb取消訂購";
            this.cb取消訂購.Size = new System.Drawing.Size(123, 29);
            this.cb取消訂購.TabIndex = 35;
            this.cb取消訂購.Text = "選擇訂單編號";
            // 
            // btn取消訂購確認
            // 
            this.btn取消訂購確認.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消訂購確認.Location = new System.Drawing.Point(939, 9);
            this.btn取消訂購確認.Name = "btn取消訂購確認";
            this.btn取消訂購確認.Size = new System.Drawing.Size(57, 29);
            this.btn取消訂購確認.TabIndex = 34;
            this.btn取消訂購確認.Text = "確認";
            this.btn取消訂購確認.UseVisualStyleBackColor = true;
            this.btn取消訂購確認.Click += new System.EventHandler(this.btn取消訂購確認_Click);
            // 
            // lbl明細修改
            // 
            this.lbl明細修改.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl明細修改.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl明細修改.Location = new System.Drawing.Point(741, 331);
            this.lbl明細修改.Name = "lbl明細修改";
            this.lbl明細修改.Size = new System.Drawing.Size(63, 29);
            this.lbl明細修改.TabIndex = 39;
            this.lbl明細修改.Text = "修改";
            // 
            // cb明細修改
            // 
            this.cb明細修改.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb明細修改.FormattingEnabled = true;
            this.cb明細修改.Location = new System.Drawing.Point(810, 331);
            this.cb明細修改.Name = "cb明細修改";
            this.cb明細修改.Size = new System.Drawing.Size(123, 29);
            this.cb明細修改.TabIndex = 38;
            this.cb明細修改.Text = "選擇明細編號";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.lbl明細修改);
            this.Controls.Add(this.cb明細修改);
            this.Controls.Add(this.lbl取消訂購);
            this.Controls.Add(this.cb取消訂購);
            this.Controls.Add(this.btn取消訂購確認);
            this.Controls.Add(this.lbl清單刪除);
            this.Controls.Add(this.cb清單刪除);
            this.Controls.Add(this.btn清單刪除確認);
            this.Controls.Add(this.btn明細修改);
            this.Controls.Add(this.btn開始訂購);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn送出);
            this.Controls.Add(this.cb訂購人);
            this.Controls.Add(this.lbl姓名);
            this.Controls.Add(this.tb備註);
            this.Controls.Add(this.tb數量);
            this.Controls.Add(this.tb單價);
            this.Controls.Add(this.cb品名);
            this.Controls.Add(this.lbl備註);
            this.Controls.Add(this.lbl數量);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.lbl品名);
            this.Controls.Add(this.cb店家);
            this.Controls.Add(this.btn全部清除);
            this.Controls.Add(this.gb系統訊息);
            this.Controls.Add(this.btn程式結束);
            this.Controls.Add(this.gb值日生登入);
            this.Controls.Add(this.lbl店家);
            this.Controls.Add(this.gb訂購作業);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.gb訂購作業.ResumeLayout(false);
            this.gb系統訊息.ResumeLayout(false);
            this.gb系統訊息.PerformLayout();
            this.gb值日生登入.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl目前日期title;
        private System.Windows.Forms.Label lbl目前日期;
        private System.Windows.Forms.Label lbl今日值日生title;
        private System.Windows.Forms.Label lbl目前時間title;
        private System.Windows.Forms.Label lbl今日值日生;
        private System.Windows.Forms.Label lbl目前時間;
        private System.Windows.Forms.GroupBox gb訂購作業;
        private System.Windows.Forms.Button btn程式結束;
        private System.Windows.Forms.GroupBox gb系統訊息;
        private System.Windows.Forms.Label lbl期別;
        private System.Windows.Forms.Label lbl店家;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btn登出;
        private System.Windows.Forms.GroupBox gb值日生登入;
        private System.Windows.Forms.Timer timer目前時間;
        private System.Windows.Forms.ComboBox cb店家;
        private System.Windows.Forms.ComboBox cb期別;
        private System.Windows.Forms.Button btn全部清除;
        private System.Windows.Forms.Label lbl品名;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label lbl數量;
        private System.Windows.Forms.Label lbl備註;
        private System.Windows.Forms.ComboBox cb品名;
        private System.Windows.Forms.TextBox tb單價;
        private System.Windows.Forms.TextBox tb數量;
        private System.Windows.Forms.TextBox tb備註;
        private System.Windows.Forms.Label lbl姓名;
        private System.Windows.Forms.ComboBox cb訂購人;
        private System.Windows.Forms.Button btn送出;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn開始訂購;
        private System.Windows.Forms.Button btn明細修改;
        private System.Windows.Forms.Button btn清單刪除確認;
        private System.Windows.Forms.ComboBox cb清單刪除;
        private System.Windows.Forms.Label lbl清單刪除;
        private System.Windows.Forms.Label lbl取消訂購;
        private System.Windows.Forms.ComboBox cb取消訂購;
        private System.Windows.Forms.Button btn取消訂購確認;
        private System.Windows.Forms.Label lbl明細修改;
        private System.Windows.Forms.ComboBox cb明細修改;
        private System.Windows.Forms.ComboBox cb值日生;
        private System.Windows.Forms.Label lbl值日生;
        private System.Windows.Forms.TextBox tb系統訊息;


    }
}

