
namespace MyFoodApp
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
            this.lbl便當總價 = new System.Windows.Forms.Label();
            this.lbl便當均價 = new System.Windows.Forms.Label();
            this.btn顯示所有便當 = new System.Windows.Forms.Button();
            this.btn價格排序 = new System.Windows.Forms.Button();
            this.btn便當排序 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt搜尋 = new System.Windows.Forms.TextBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.lbl顯示 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Location = new System.Drawing.Point(208, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂購便當系統";
            // 
            // lbl便當總價
            // 
            this.lbl便當總價.BackColor = System.Drawing.Color.Gray;
            this.lbl便當總價.ForeColor = System.Drawing.Color.Pink;
            this.lbl便當總價.Location = new System.Drawing.Point(114, 361);
            this.lbl便當總價.Name = "lbl便當總價";
            this.lbl便當總價.Size = new System.Drawing.Size(154, 27);
            this.lbl便當總價.TabIndex = 2;
            this.lbl便當總價.Text = "便當總價:";
            // 
            // lbl便當均價
            // 
            this.lbl便當均價.BackColor = System.Drawing.Color.Gray;
            this.lbl便當均價.ForeColor = System.Drawing.Color.Pink;
            this.lbl便當均價.Location = new System.Drawing.Point(274, 361);
            this.lbl便當均價.Name = "lbl便當均價";
            this.lbl便當均價.Size = new System.Drawing.Size(154, 27);
            this.lbl便當均價.TabIndex = 3;
            this.lbl便當均價.Text = "便當均價:";
            // 
            // btn顯示所有便當
            // 
            this.btn顯示所有便當.BackColor = System.Drawing.Color.LightPink;
            this.btn顯示所有便當.ForeColor = System.Drawing.Color.DimGray;
            this.btn顯示所有便當.Location = new System.Drawing.Point(349, 258);
            this.btn顯示所有便當.Name = "btn顯示所有便當";
            this.btn顯示所有便當.Size = new System.Drawing.Size(134, 50);
            this.btn顯示所有便當.TabIndex = 4;
            this.btn顯示所有便當.Text = "顯示所有便當";
            this.btn顯示所有便當.UseVisualStyleBackColor = false;
            this.btn顯示所有便當.Click += new System.EventHandler(this.btn顯示所有便當_Click);
            // 
            // btn價格排序
            // 
            this.btn價格排序.BackColor = System.Drawing.Color.LightPink;
            this.btn價格排序.ForeColor = System.Drawing.Color.DimGray;
            this.btn價格排序.Location = new System.Drawing.Point(232, 265);
            this.btn價格排序.Name = "btn價格排序";
            this.btn價格排序.Size = new System.Drawing.Size(108, 36);
            this.btn價格排序.TabIndex = 5;
            this.btn價格排序.Text = "價格排序";
            this.btn價格排序.UseVisualStyleBackColor = false;
            this.btn價格排序.Click += new System.EventHandler(this.btn價格排序_Click);
            // 
            // btn便當排序
            // 
            this.btn便當排序.BackColor = System.Drawing.Color.LightPink;
            this.btn便當排序.ForeColor = System.Drawing.Color.DimGray;
            this.btn便當排序.Location = new System.Drawing.Point(118, 265);
            this.btn便當排序.Name = "btn便當排序";
            this.btn便當排序.Size = new System.Drawing.Size(108, 36);
            this.btn便當排序.TabIndex = 6;
            this.btn便當排序.Text = "便當排序";
            this.btn便當排序.UseVisualStyleBackColor = false;
            this.btn便當排序.Click += new System.EventHandler(this.btn便當排序_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt搜尋);
            this.groupBox1.Controls.Add(this.btn搜尋);
            this.groupBox1.ForeColor = System.Drawing.Color.LightPink;
            this.groupBox1.Location = new System.Drawing.Point(434, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 112);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜尋便當";
            // 
            // txt搜尋
            // 
            this.txt搜尋.Location = new System.Drawing.Point(20, 33);
            this.txt搜尋.Name = "txt搜尋";
            this.txt搜尋.Size = new System.Drawing.Size(162, 33);
            this.txt搜尋.TabIndex = 1;
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackColor = System.Drawing.Color.DimGray;
            this.btn搜尋.Location = new System.Drawing.Point(64, 72);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(81, 35);
            this.btn搜尋.TabIndex = 0;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // lbl顯示
            // 
            this.lbl顯示.BackColor = System.Drawing.Color.LightPink;
            this.lbl顯示.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl顯示.Location = new System.Drawing.Point(3, 0);
            this.lbl顯示.Name = "lbl顯示";
            this.lbl顯示.Size = new System.Drawing.Size(362, 365);
            this.lbl顯示.TabIndex = 8;
            this.lbl顯示.Text = "....";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbl顯示);
            this.panel1.Location = new System.Drawing.Point(118, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 199);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(640, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn便當排序);
            this.Controls.Add(this.btn價格排序);
            this.Controls.Add(this.btn顯示所有便當);
            this.Controls.Add(this.lbl便當均價);
            this.Controls.Add(this.lbl便當總價);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "訂便當系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl便當總價;
        private System.Windows.Forms.Label lbl便當均價;
        private System.Windows.Forms.Button btn顯示所有便當;
        private System.Windows.Forms.Button btn價格排序;
        private System.Windows.Forms.Button btn便當排序;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt搜尋;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.Label lbl顯示;
        private System.Windows.Forms.Panel panel1;
    }
}

