
namespace WindowsFormsApp5
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
            this.Lbl資料結果顯示 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl成績總和結果 = new System.Windows.Forms.Label();
            this.Lbl成績平均結果 = new System.Windows.Forms.Label();
            this.Btn成績排序 = new System.Windows.Forms.Button();
            this.Btn姓名排序 = new System.Windows.Forms.Button();
            this.Btn列出所有學生 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt輸入姓名 = new System.Windows.Forms.TextBox();
            this.Btn姓名搜尋 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "學生成績查詢";
            // 
            // Lbl資料結果顯示
            // 
            this.Lbl資料結果顯示.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Lbl資料結果顯示.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl資料結果顯示.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl資料結果顯示.Location = new System.Drawing.Point(65, 48);
            this.Lbl資料結果顯示.Name = "Lbl資料結果顯示";
            this.Lbl資料結果顯示.Size = new System.Drawing.Size(274, 193);
            this.Lbl資料結果顯示.TabIndex = 1;
            this.Lbl資料結果顯示.Text = "資料結果顯示";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(401, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "成績總和";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(401, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "成績平均";
            // 
            // Lbl成績總和結果
            // 
            this.Lbl成績總和結果.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Lbl成績總和結果.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl成績總和結果.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl成績總和結果.Location = new System.Drawing.Point(521, 98);
            this.Lbl成績總和結果.Name = "Lbl成績總和結果";
            this.Lbl成績總和結果.Size = new System.Drawing.Size(100, 23);
            this.Lbl成績總和結果.TabIndex = 4;
            this.Lbl成績總和結果.Text = "計算結果";
            // 
            // Lbl成績平均結果
            // 
            this.Lbl成績平均結果.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Lbl成績平均結果.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl成績平均結果.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl成績平均結果.Location = new System.Drawing.Point(521, 161);
            this.Lbl成績平均結果.Name = "Lbl成績平均結果";
            this.Lbl成績平均結果.Size = new System.Drawing.Size(100, 23);
            this.Lbl成績平均結果.TabIndex = 5;
            this.Lbl成績平均結果.Text = "計算結果";
            // 
            // Btn成績排序
            // 
            this.Btn成績排序.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn成績排序.Location = new System.Drawing.Point(84, 262);
            this.Btn成績排序.Name = "Btn成績排序";
            this.Btn成績排序.Size = new System.Drawing.Size(105, 37);
            this.Btn成績排序.TabIndex = 6;
            this.Btn成績排序.Text = "成績排序";
            this.Btn成績排序.UseVisualStyleBackColor = true;
            this.Btn成績排序.Click += new System.EventHandler(this.Btn成績排序_Click);
            // 
            // Btn姓名排序
            // 
            this.Btn姓名排序.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn姓名排序.Location = new System.Drawing.Point(212, 262);
            this.Btn姓名排序.Name = "Btn姓名排序";
            this.Btn姓名排序.Size = new System.Drawing.Size(105, 37);
            this.Btn姓名排序.TabIndex = 7;
            this.Btn姓名排序.Text = "姓名排序";
            this.Btn姓名排序.UseVisualStyleBackColor = true;
            this.Btn姓名排序.Click += new System.EventHandler(this.Btn姓名排序_Click);
            // 
            // Btn列出所有學生
            // 
            this.Btn列出所有學生.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn列出所有學生.Location = new System.Drawing.Point(85, 305);
            this.Btn列出所有學生.Name = "Btn列出所有學生";
            this.Btn列出所有學生.Size = new System.Drawing.Size(232, 37);
            this.Btn列出所有學生.TabIndex = 8;
            this.Btn列出所有學生.Text = "列出所有學生";
            this.Btn列出所有學生.UseVisualStyleBackColor = true;
            this.Btn列出所有學生.Click += new System.EventHandler(this.Btn列出所有學生_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn姓名搜尋);
            this.groupBox1.Controls.Add(this.Txt輸入姓名);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(390, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 121);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜尋功能";
            // 
            // Txt輸入姓名
            // 
            this.Txt輸入姓名.Location = new System.Drawing.Point(15, 32);
            this.Txt輸入姓名.Name = "Txt輸入姓名";
            this.Txt輸入姓名.Size = new System.Drawing.Size(195, 33);
            this.Txt輸入姓名.TabIndex = 0;
            // 
            // Btn姓名搜尋
            // 
            this.Btn姓名搜尋.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn姓名搜尋.Location = new System.Drawing.Point(114, 79);
            this.Btn姓名搜尋.Name = "Btn姓名搜尋";
            this.Btn姓名搜尋.Size = new System.Drawing.Size(96, 36);
            this.Btn姓名搜尋.TabIndex = 1;
            this.Btn姓名搜尋.Text = "姓名搜尋";
            this.Btn姓名搜尋.UseVisualStyleBackColor = true;
            this.Btn姓名搜尋.Click += new System.EventHandler(this.Btn姓名搜尋_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(650, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn列出所有學生);
            this.Controls.Add(this.Btn姓名排序);
            this.Controls.Add(this.Btn成績排序);
            this.Controls.Add(this.Lbl成績平均結果);
            this.Controls.Add(this.Lbl成績總和結果);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl資料結果顯示);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Array得進階應用";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl資料結果顯示;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl成績總和結果;
        private System.Windows.Forms.Label Lbl成績平均結果;
        private System.Windows.Forms.Button Btn成績排序;
        private System.Windows.Forms.Button Btn姓名排序;
        private System.Windows.Forms.Button Btn列出所有學生;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn姓名搜尋;
        private System.Windows.Forms.TextBox Txt輸入姓名;
    }
}

