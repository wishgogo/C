﻿
namespace WindowsFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.lbl品項總價 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt訂購人電話 = new System.Windows.Forms.TextBox();
            this.txt品項杯數 = new System.Windows.Forms.TextBox();
            this.btn加入訂購單 = new System.Windows.Forms.Button();
            this.btn查看訂購單 = new System.Windows.Forms.Button();
            this.lbox冷飲品項 = new System.Windows.Forms.ListBox();
            this.cbox甜度 = new System.Windows.Forms.ComboBox();
            this.cbox冰塊 = new System.Windows.Forms.ComboBox();
            this.cbox配料 = new System.Windows.Forms.ComboBox();
            this.lbox配料 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(181, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "冷飲店訂購單";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "訂購人(電話)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(27, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "冷飲品項";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(288, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "甜度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(288, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "配料";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(288, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "冰塊";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(34, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "數量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(282, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "品項總價";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(163, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "單價";
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.BackColor = System.Drawing.Color.LightCoral;
            this.lbl單價.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(166, 431);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(59, 21);
            this.lbl單價.TabIndex = 9;
            this.lbl單價.Text = "XXX元";
            // 
            // lbl品項總價
            // 
            this.lbl品項總價.AutoSize = true;
            this.lbl品項總價.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl品項總價.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl品項總價.Location = new System.Drawing.Point(288, 431);
            this.lbl品項總價.Name = "lbl品項總價";
            this.lbl品項總價.Size = new System.Drawing.Size(59, 21);
            this.lbl品項總價.TabIndex = 10;
            this.lbl品項總價.Text = "XXX元";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(93, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "杯";
            // 
            // txt訂購人電話
            // 
            this.txt訂購人電話.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購人電話.Location = new System.Drawing.Point(29, 95);
            this.txt訂購人電話.Name = "txt訂購人電話";
            this.txt訂購人電話.Size = new System.Drawing.Size(205, 23);
            this.txt訂購人電話.TabIndex = 12;
            // 
            // txt品項杯數
            // 
            this.txt品項杯數.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt品項杯數.Location = new System.Drawing.Point(30, 429);
            this.txt品項杯數.Name = "txt品項杯數";
            this.txt品項杯數.Size = new System.Drawing.Size(63, 23);
            this.txt品項杯數.TabIndex = 13;
            this.txt品項杯數.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt品項杯數_KeyPress);
            // 
            // btn加入訂購單
            // 
            this.btn加入訂購單.BackColor = System.Drawing.Color.Silver;
            this.btn加入訂購單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入訂購單.Location = new System.Drawing.Point(200, 469);
            this.btn加入訂購單.Name = "btn加入訂購單";
            this.btn加入訂購單.Size = new System.Drawing.Size(117, 46);
            this.btn加入訂購單.TabIndex = 14;
            this.btn加入訂購單.Text = "加入訂購單";
            this.btn加入訂購單.UseVisualStyleBackColor = false;
            this.btn加入訂購單.Click += new System.EventHandler(this.btn加入訂購單_Click);
            // 
            // btn查看訂購單
            // 
            this.btn查看訂購單.BackColor = System.Drawing.Color.Silver;
            this.btn查看訂購單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查看訂購單.Location = new System.Drawing.Point(335, 469);
            this.btn查看訂購單.Name = "btn查看訂購單";
            this.btn查看訂購單.Size = new System.Drawing.Size(117, 46);
            this.btn查看訂購單.TabIndex = 15;
            this.btn查看訂購單.Text = "查看訂購單";
            this.btn查看訂購單.UseVisualStyleBackColor = false;
            this.btn查看訂購單.Click += new System.EventHandler(this.btn查看訂購單_Click);
            // 
            // lbox冷飲品項
            // 
            this.lbox冷飲品項.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox冷飲品項.FormattingEnabled = true;
            this.lbox冷飲品項.ItemHeight = 19;
            this.lbox冷飲品項.Location = new System.Drawing.Point(31, 152);
            this.lbox冷飲品項.Name = "lbox冷飲品項";
            this.lbox冷飲品項.Size = new System.Drawing.Size(249, 232);
            this.lbox冷飲品項.TabIndex = 16;
            this.lbox冷飲品項.SelectedIndexChanged += new System.EventHandler(this.lbox冷飲品項_SelectedIndexChanged);
            // 
            // cbox甜度
            // 
            this.cbox甜度.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox甜度.FormattingEnabled = true;
            this.cbox甜度.Location = new System.Drawing.Point(327, 167);
            this.cbox甜度.Name = "cbox甜度";
            this.cbox甜度.Size = new System.Drawing.Size(112, 21);
            this.cbox甜度.TabIndex = 17;
            this.cbox甜度.SelectedIndexChanged += new System.EventHandler(this.cbox甜度_SelectedIndexChanged);
            // 
            // cbox冰塊
            // 
            this.cbox冰塊.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox冰塊.FormattingEnabled = true;
            this.cbox冰塊.Location = new System.Drawing.Point(327, 222);
            this.cbox冰塊.Name = "cbox冰塊";
            this.cbox冰塊.Size = new System.Drawing.Size(112, 21);
            this.cbox冰塊.TabIndex = 18;
            this.cbox冰塊.SelectedIndexChanged += new System.EventHandler(this.cbox冰塊_SelectedIndexChanged);
            // 
            // cbox配料
            // 
            this.cbox配料.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox配料.FormattingEnabled = true;
            this.cbox配料.Location = new System.Drawing.Point(327, 280);
            this.cbox配料.Name = "cbox配料";
            this.cbox配料.Size = new System.Drawing.Size(112, 21);
            this.cbox配料.TabIndex = 19;
            this.cbox配料.SelectedIndexChanged += new System.EventHandler(this.cbox配料_SelectedIndexChanged);
            // 
            // lbox配料
            // 
            this.lbox配料.BackColor = System.Drawing.Color.MistyRose;
            this.lbox配料.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox配料.FormattingEnabled = true;
            this.lbox配料.ItemHeight = 19;
            this.lbox配料.Location = new System.Drawing.Point(326, 307);
            this.lbox配料.Name = "lbox配料";
            this.lbox配料.Size = new System.Drawing.Size(113, 80);
            this.lbox配料.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(464, 527);
            this.Controls.Add(this.lbox配料);
            this.Controls.Add(this.cbox配料);
            this.Controls.Add(this.cbox冰塊);
            this.Controls.Add(this.cbox甜度);
            this.Controls.Add(this.lbox冷飲品項);
            this.Controls.Add(this.btn查看訂購單);
            this.Controls.Add(this.btn加入訂購單);
            this.Controls.Add(this.txt品項杯數);
            this.Controls.Add(this.txt訂購人電話);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl品項總價);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "冷飲店訂購單";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label lbl品項總價;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt訂購人電話;
        private System.Windows.Forms.TextBox txt品項杯數;
        private System.Windows.Forms.Button btn加入訂購單;
        private System.Windows.Forms.Button btn查看訂購單;
        private System.Windows.Forms.ListBox lbox冷飲品項;
        private System.Windows.Forms.ComboBox cbox甜度;
        private System.Windows.Forms.ComboBox cbox冰塊;
        private System.Windows.Forms.ComboBox cbox配料;
        private System.Windows.Forms.ListBox lbox配料;
    }
}

