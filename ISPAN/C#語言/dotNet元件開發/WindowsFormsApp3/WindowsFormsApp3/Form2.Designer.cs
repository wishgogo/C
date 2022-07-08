
namespace WindowsFormsApp3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl訂購人 = new System.Windows.Forms.Label();
            this.lbox訂購品項列表 = new System.Windows.Forms.ListBox();
            this.lbl訂購總價 = new System.Windows.Forms.Label();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.btn清除所有品項 = new System.Windows.Forms.Button();
            this.chktax = new System.Windows.Forms.CheckBox();
            this.radioDiscount1 = new System.Windows.Forms.RadioButton();
            this.radioDiscount2 = new System.Windows.Forms.RadioButton();
            this.radioDiscount3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(218, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "冷飲訂購品項列表";
            // 
            // lbl訂購人
            // 
            this.lbl訂購人.BackColor = System.Drawing.Color.Bisque;
            this.lbl訂購人.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人.Location = new System.Drawing.Point(407, 78);
            this.lbl訂購人.Name = "lbl訂購人";
            this.lbl訂購人.Size = new System.Drawing.Size(171, 24);
            this.lbl訂購人.TabIndex = 1;
            this.lbl訂購人.Text = "訂購人資料";
            // 
            // lbox訂購品項列表
            // 
            this.lbox訂購品項列表.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox訂購品項列表.FormattingEnabled = true;
            this.lbox訂購品項列表.HorizontalScrollbar = true;
            this.lbox訂購品項列表.ItemHeight = 19;
            this.lbox訂購品項列表.Location = new System.Drawing.Point(31, 114);
            this.lbox訂購品項列表.Name = "lbox訂購品項列表";
            this.lbox訂購品項列表.Size = new System.Drawing.Size(547, 213);
            this.lbox訂購品項列表.TabIndex = 2;
            // 
            // lbl訂購總價
            // 
            this.lbl訂購總價.BackColor = System.Drawing.Color.Bisque;
            this.lbl訂購總價.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購總價.Location = new System.Drawing.Point(407, 341);
            this.lbl訂購總價.Name = "lbl訂購總價";
            this.lbl訂購總價.Size = new System.Drawing.Size(171, 24);
            this.lbl訂購總價.TabIndex = 3;
            this.lbl訂購總價.Text = "訂購單總價XXXXX元";
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.BackColor = System.Drawing.Color.Silver;
            this.btn移除所選品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.Location = new System.Drawing.Point(336, 387);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(118, 42);
            this.btn移除所選品項.TabIndex = 15;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = false;
            this.btn移除所選品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // btn清除所有品項
            // 
            this.btn清除所有品項.BackColor = System.Drawing.Color.Silver;
            this.btn清除所有品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所有品項.Location = new System.Drawing.Point(460, 387);
            this.btn清除所有品項.Name = "btn清除所有品項";
            this.btn清除所有品項.Size = new System.Drawing.Size(118, 42);
            this.btn清除所有品項.TabIndex = 16;
            this.btn清除所有品項.Text = "清除所有品項";
            this.btn清除所有品項.UseVisualStyleBackColor = false;
            this.btn清除所有品項.Click += new System.EventHandler(this.btn清除所有品項_Click);
            // 
            // chktax
            // 
            this.chktax.AutoSize = true;
            this.chktax.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chktax.Location = new System.Drawing.Point(156, 342);
            this.chktax.Name = "chktax";
            this.chktax.Size = new System.Drawing.Size(111, 23);
            this.chktax.TabIndex = 17;
            this.chktax.Text = "加入5%稅金";
            this.chktax.UseVisualStyleBackColor = true;
            this.chktax.CheckedChanged += new System.EventHandler(this.chktax_CheckedChanged);
            // 
            // radioDiscount1
            // 
            this.radioDiscount1.AutoSize = true;
            this.radioDiscount1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioDiscount1.Location = new System.Drawing.Point(6, 34);
            this.radioDiscount1.Name = "radioDiscount1";
            this.radioDiscount1.Size = new System.Drawing.Size(87, 23);
            this.radioDiscount1.TabIndex = 18;
            this.radioDiscount1.TabStop = true;
            this.radioDiscount1.Text = "買二送一";
            this.radioDiscount1.UseVisualStyleBackColor = true;
            this.radioDiscount1.CheckedChanged += new System.EventHandler(this.radioDiscount1_CheckedChanged);
            // 
            // radioDiscount2
            // 
            this.radioDiscount2.AutoSize = true;
            this.radioDiscount2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioDiscount2.Location = new System.Drawing.Point(6, 63);
            this.radioDiscount2.Name = "radioDiscount2";
            this.radioDiscount2.Size = new System.Drawing.Size(87, 23);
            this.radioDiscount2.TabIndex = 19;
            this.radioDiscount2.TabStop = true;
            this.radioDiscount2.Text = "買三送一";
            this.radioDiscount2.UseVisualStyleBackColor = true;
            this.radioDiscount2.CheckedChanged += new System.EventHandler(this.radioDiscount2_CheckedChanged);
            // 
            // radioDiscount3
            // 
            this.radioDiscount3.AutoSize = true;
            this.radioDiscount3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioDiscount3.Location = new System.Drawing.Point(6, 92);
            this.radioDiscount3.Name = "radioDiscount3";
            this.radioDiscount3.Size = new System.Drawing.Size(102, 23);
            this.radioDiscount3.TabIndex = 20;
            this.radioDiscount3.TabStop = true;
            this.radioDiscount3.Text = "第二件半價";
            this.radioDiscount3.UseVisualStyleBackColor = true;
            this.radioDiscount3.CheckedChanged += new System.EventHandler(this.radioDiscount3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.radioDiscount1);
            this.groupBox1.Controls.Add(this.radioDiscount3);
            this.groupBox1.Controls.Add(this.radioDiscount2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(31, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 125);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "折扣活動";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.Location = new System.Drawing.Point(482, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 33);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "關閉表單";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(361, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 33);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "儲存訂單TXT";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(598, 477);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chktax);
            this.Controls.Add(this.btn清除所有品項);
            this.Controls.Add(this.btn移除所選品項);
            this.Controls.Add(this.lbl訂購總價);
            this.Controls.Add(this.lbox訂購品項列表);
            this.Controls.Add(this.lbl訂購人);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "冷飲店結賬單";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl訂購人;
        private System.Windows.Forms.ListBox lbox訂購品項列表;
        private System.Windows.Forms.Label lbl訂購總價;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.Button btn清除所有品項;
        private System.Windows.Forms.CheckBox chktax;
        private System.Windows.Forms.RadioButton radioDiscount1;
        private System.Windows.Forms.RadioButton radioDiscount2;
        private System.Windows.Forms.RadioButton radioDiscount3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}