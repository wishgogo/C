﻿
namespace WindowsFormsApp4
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.btn修改資料 = new System.Windows.Forms.Button();
            this.btn新增資料 = new System.Windows.Forms.Button();
            this.btn刪除資料 = new System.Windows.Forms.Button();
            this.btn資料筆數 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt點數 = new System.Windows.Forms.TextBox();
            this.chk婚姻狀態 = new System.Windows.Forms.CheckBox();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.lblID = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt欄位關鍵字 = new System.Windows.Forms.TextBox();
            this.cbx欄位名稱 = new System.Windows.Forms.ComboBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp開始生日 = new System.Windows.Forms.DateTimePicker();
            this.dtp結束生日 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.lbox搜尋結果 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radio婚姻未婚 = new System.Windows.Forms.RadioButton();
            this.radio婚姻已婚 = new System.Windows.Forms.RadioButton();
            this.radio婚姻全部 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btn清空欄位);
            this.groupBox1.Controls.Add(this.btn資料搜尋);
            this.groupBox1.Controls.Add(this.btn修改資料);
            this.groupBox1.Controls.Add(this.btn新增資料);
            this.groupBox1.Controls.Add(this.btn刪除資料);
            this.groupBox1.Controls.Add(this.btn資料筆數);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能選單";
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Location = new System.Drawing.Point(20, 392);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(91, 34);
            this.btn清空欄位.TabIndex = 5;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn資料搜尋
            // 
            this.btn資料搜尋.Location = new System.Drawing.Point(20, 110);
            this.btn資料搜尋.Name = "btn資料搜尋";
            this.btn資料搜尋.Size = new System.Drawing.Size(91, 34);
            this.btn資料搜尋.TabIndex = 4;
            this.btn資料搜尋.Text = "資料搜尋";
            this.btn資料搜尋.UseVisualStyleBackColor = true;
            this.btn資料搜尋.Click += new System.EventHandler(this.btn資料搜尋_Click);
            // 
            // btn修改資料
            // 
            this.btn修改資料.Location = new System.Drawing.Point(20, 181);
            this.btn修改資料.Name = "btn修改資料";
            this.btn修改資料.Size = new System.Drawing.Size(91, 34);
            this.btn修改資料.TabIndex = 3;
            this.btn修改資料.Text = "修改資料";
            this.btn修改資料.UseVisualStyleBackColor = true;
            this.btn修改資料.Click += new System.EventHandler(this.btn修改資料_Click);
            // 
            // btn新增資料
            // 
            this.btn新增資料.Location = new System.Drawing.Point(20, 252);
            this.btn新增資料.Name = "btn新增資料";
            this.btn新增資料.Size = new System.Drawing.Size(91, 34);
            this.btn新增資料.TabIndex = 2;
            this.btn新增資料.Text = "新增資料";
            this.btn新增資料.UseVisualStyleBackColor = true;
            this.btn新增資料.Click += new System.EventHandler(this.btn新增資料_Click);
            // 
            // btn刪除資料
            // 
            this.btn刪除資料.Location = new System.Drawing.Point(20, 321);
            this.btn刪除資料.Name = "btn刪除資料";
            this.btn刪除資料.Size = new System.Drawing.Size(91, 34);
            this.btn刪除資料.TabIndex = 1;
            this.btn刪除資料.Text = "刪除資料";
            this.btn刪除資料.UseVisualStyleBackColor = true;
            this.btn刪除資料.Click += new System.EventHandler(this.btn刪除資料_Click);
            // 
            // btn資料筆數
            // 
            this.btn資料筆數.Location = new System.Drawing.Point(20, 41);
            this.btn資料筆數.Name = "btn資料筆數";
            this.btn資料筆數.Size = new System.Drawing.Size(91, 34);
            this.btn資料筆數.TabIndex = 0;
            this.btn資料筆數.Text = "資料筆數";
            this.btn資料筆數.UseVisualStyleBackColor = true;
            this.btn資料筆數.Click += new System.EventHandler(this.btn資料筆數_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.txt點數);
            this.groupBox2.Controls.Add(this.chk婚姻狀態);
            this.groupBox2.Controls.Add(this.dtp生日);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txt地址);
            this.groupBox2.Controls.Add(this.txt電話);
            this.groupBox2.Controls.Add(this.txt姓名);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(135, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 445);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "資料欄位";
            // 
            // txt點數
            // 
            this.txt點數.Location = new System.Drawing.Point(54, 293);
            this.txt點數.Name = "txt點數";
            this.txt點數.Size = new System.Drawing.Size(85, 25);
            this.txt點數.TabIndex = 23;
            // 
            // chk婚姻狀態
            // 
            this.chk婚姻狀態.AutoSize = true;
            this.chk婚姻狀態.Location = new System.Drawing.Point(86, 260);
            this.chk婚姻狀態.Name = "chk婚姻狀態";
            this.chk婚姻狀態.Size = new System.Drawing.Size(56, 19);
            this.chk婚姻狀態.TabIndex = 25;
            this.chk婚姻狀態.Text = "已婚";
            this.chk婚姻狀態.UseVisualStyleBackColor = true;
            // 
            // dtp生日
            // 
            this.dtp生日.Location = new System.Drawing.Point(54, 225);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(158, 25);
            this.dtp生日.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblID.Location = new System.Drawing.Point(54, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 21);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "0";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(54, 191);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 25);
            this.txtEmail.TabIndex = 21;
            // 
            // txt地址
            // 
            this.txt地址.Location = new System.Drawing.Point(54, 157);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(233, 25);
            this.txt地址.TabIndex = 20;
            // 
            // txt電話
            // 
            this.txt電話.Location = new System.Drawing.Point(54, 118);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(152, 25);
            this.txt電話.TabIndex = 19;
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(54, 77);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(109, 25);
            this.txt姓名.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(6, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "點數";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(5, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "婚姻狀態";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(5, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "生日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(5, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(5, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(5, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "電話";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(5, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.lbox搜尋結果);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.dtp結束生日);
            this.groupBox3.Controls.Add(this.dtp開始生日);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btn搜尋);
            this.groupBox3.Controls.Add(this.cbx欄位名稱);
            this.groupBox3.Controls.Add(this.txt欄位關鍵字);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(428, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 445);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "進階搜尋";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(641, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 445);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "會員資料列表";
            // 
            // txt欄位關鍵字
            // 
            this.txt欄位關鍵字.Location = new System.Drawing.Point(11, 41);
            this.txt欄位關鍵字.Name = "txt欄位關鍵字";
            this.txt欄位關鍵字.Size = new System.Drawing.Size(119, 25);
            this.txt欄位關鍵字.TabIndex = 0;
            // 
            // cbx欄位名稱
            // 
            this.cbx欄位名稱.FormattingEnabled = true;
            this.cbx欄位名稱.Location = new System.Drawing.Point(136, 43);
            this.cbx欄位名稱.Name = "cbx欄位名稱";
            this.cbx欄位名稱.Size = new System.Drawing.Size(70, 23);
            this.cbx欄位名稱.TabIndex = 1;
            // 
            // btn搜尋
            // 
            this.btn搜尋.Location = new System.Drawing.Point(11, 73);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(196, 25);
            this.btn搜尋.TabIndex = 2;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(10, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "欄位關鍵字搜尋";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(10, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "生日區間";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(27, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "從";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(27, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "到";
            // 
            // dtp開始生日
            // 
            this.dtp開始生日.Location = new System.Drawing.Point(50, 139);
            this.dtp開始生日.Name = "dtp開始生日";
            this.dtp開始生日.Size = new System.Drawing.Size(139, 25);
            this.dtp開始生日.TabIndex = 7;
            this.dtp開始生日.Value = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            // 
            // dtp結束生日
            // 
            this.dtp結束生日.Location = new System.Drawing.Point(50, 172);
            this.dtp結束生日.Name = "dtp結束生日";
            this.dtp結束生日.Size = new System.Drawing.Size(139, 25);
            this.dtp結束生日.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(9, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 9;
            this.label13.Text = "搜尋結果";
            // 
            // lbox搜尋結果
            // 
            this.lbox搜尋結果.FormattingEnabled = true;
            this.lbox搜尋結果.ItemHeight = 15;
            this.lbox搜尋結果.Location = new System.Drawing.Point(28, 311);
            this.lbox搜尋結果.Name = "lbox搜尋結果";
            this.lbox搜尋結果.Size = new System.Drawing.Size(177, 124);
            this.lbox搜尋結果.TabIndex = 10;
            this.lbox搜尋結果.SelectedIndexChanged += new System.EventHandler(this.lbox搜尋結果_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radio婚姻全部);
            this.groupBox5.Controls.Add(this.radio婚姻已婚);
            this.groupBox5.Controls.Add(this.radio婚姻未婚);
            this.groupBox5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox5.Location = new System.Drawing.Point(12, 212);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(193, 74);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "婚姻狀態";
            // 
            // radio婚姻未婚
            // 
            this.radio婚姻未婚.AutoSize = true;
            this.radio婚姻未婚.Location = new System.Drawing.Point(71, 31);
            this.radio婚姻未婚.Name = "radio婚姻未婚";
            this.radio婚姻未婚.Size = new System.Drawing.Size(47, 16);
            this.radio婚姻未婚.TabIndex = 0;
            this.radio婚姻未婚.TabStop = true;
            this.radio婚姻未婚.Text = "未婚";
            this.radio婚姻未婚.UseVisualStyleBackColor = true;
            this.radio婚姻未婚.CheckedChanged += new System.EventHandler(this.radio婚姻未婚_CheckedChanged);
            // 
            // radio婚姻已婚
            // 
            this.radio婚姻已婚.AutoSize = true;
            this.radio婚姻已婚.Location = new System.Drawing.Point(124, 31);
            this.radio婚姻已婚.Name = "radio婚姻已婚";
            this.radio婚姻已婚.Size = new System.Drawing.Size(47, 16);
            this.radio婚姻已婚.TabIndex = 1;
            this.radio婚姻已婚.TabStop = true;
            this.radio婚姻已婚.Text = "已婚";
            this.radio婚姻已婚.UseVisualStyleBackColor = true;
            this.radio婚姻已婚.CheckedChanged += new System.EventHandler(this.radio婚姻已婚_CheckedChanged);
            // 
            // radio婚姻全部
            // 
            this.radio婚姻全部.AutoSize = true;
            this.radio婚姻全部.Location = new System.Drawing.Point(16, 31);
            this.radio婚姻全部.Name = "radio婚姻全部";
            this.radio婚姻全部.Size = new System.Drawing.Size(47, 16);
            this.radio婚姻全部.TabIndex = 2;
            this.radio婚姻全部.TabStop = true;
            this.radio婚姻全部.Text = "全部";
            this.radio婚姻全部.UseVisualStyleBackColor = true;
            this.radio婚姻全部.CheckedChanged += new System.EventHandler(this.radio婚姻全部_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(206, 415);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 466);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ADO.net程式化語法";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn資料搜尋;
        private System.Windows.Forms.Button btn修改資料;
        private System.Windows.Forms.Button btn新增資料;
        private System.Windows.Forms.Button btn刪除資料;
        private System.Windows.Forms.Button btn資料筆數;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt點數;
        private System.Windows.Forms.CheckBox chk婚姻狀態;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbox搜尋結果;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp結束生日;
        private System.Windows.Forms.DateTimePicker dtp開始生日;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ComboBox cbx欄位名稱;
        private System.Windows.Forms.TextBox txt欄位關鍵字;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radio婚姻全部;
        private System.Windows.Forms.RadioButton radio婚姻已婚;
        private System.Windows.Forms.RadioButton radio婚姻未婚;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

