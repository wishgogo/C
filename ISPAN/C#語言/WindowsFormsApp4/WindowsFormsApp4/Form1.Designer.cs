
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_cbv1 = new System.Windows.Forms.Label();
            this.lab_cbv2 = new System.Windows.Forms.Label();
            this.lab_cbv3 = new System.Windows.Forms.Label();
            this.lab_cbr1 = new System.Windows.Forms.Label();
            this.lab_cbr2 = new System.Windows.Forms.Label();
            this.lab_cbr3 = new System.Windows.Forms.Label();
            this.Btn_cbv測試 = new System.Windows.Forms.Button();
            this.Btn_cbr測試 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(105, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "傳值呼叫 Call By Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(95, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "傳址呼叫 Call By Reference";
            // 
            // lab_cbv1
            // 
            this.lab_cbv1.AutoSize = true;
            this.lab_cbv1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_cbv1.Location = new System.Drawing.Point(106, 82);
            this.lab_cbv1.Name = "lab_cbv1";
            this.lab_cbv1.Size = new System.Drawing.Size(59, 24);
            this.lab_cbv1.TabIndex = 2;
            this.lab_cbv1.Text = "CBV1";
            // 
            // lab_cbv2
            // 
            this.lab_cbv2.AutoSize = true;
            this.lab_cbv2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_cbv2.Location = new System.Drawing.Point(105, 117);
            this.lab_cbv2.Name = "lab_cbv2";
            this.lab_cbv2.Size = new System.Drawing.Size(59, 24);
            this.lab_cbv2.TabIndex = 3;
            this.lab_cbv2.Text = "CBV2";
            // 
            // lab_cbv3
            // 
            this.lab_cbv3.AutoSize = true;
            this.lab_cbv3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_cbv3.Location = new System.Drawing.Point(106, 154);
            this.lab_cbv3.Name = "lab_cbv3";
            this.lab_cbv3.Size = new System.Drawing.Size(59, 24);
            this.lab_cbv3.TabIndex = 4;
            this.lab_cbv3.Text = "CBV3";
            // 
            // lab_cbr1
            // 
            this.lab_cbr1.AutoSize = true;
            this.lab_cbr1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_cbr1.Location = new System.Drawing.Point(107, 247);
            this.lab_cbr1.Name = "lab_cbr1";
            this.lab_cbr1.Size = new System.Drawing.Size(58, 24);
            this.lab_cbr1.TabIndex = 5;
            this.lab_cbr1.Text = "CBR1";
            // 
            // lab_cbr2
            // 
            this.lab_cbr2.AutoSize = true;
            this.lab_cbr2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_cbr2.Location = new System.Drawing.Point(107, 297);
            this.lab_cbr2.Name = "lab_cbr2";
            this.lab_cbr2.Size = new System.Drawing.Size(58, 24);
            this.lab_cbr2.TabIndex = 6;
            this.lab_cbr2.Text = "CBR2";
            // 
            // lab_cbr3
            // 
            this.lab_cbr3.AutoSize = true;
            this.lab_cbr3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_cbr3.Location = new System.Drawing.Point(105, 349);
            this.lab_cbr3.Name = "lab_cbr3";
            this.lab_cbr3.Size = new System.Drawing.Size(58, 24);
            this.lab_cbr3.TabIndex = 7;
            this.lab_cbr3.Text = "CBR3";
            // 
            // Btn_cbv測試
            // 
            this.Btn_cbv測試.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_cbv測試.Location = new System.Drawing.Point(487, 82);
            this.Btn_cbv測試.Name = "Btn_cbv測試";
            this.Btn_cbv測試.Size = new System.Drawing.Size(131, 43);
            this.Btn_cbv測試.TabIndex = 8;
            this.Btn_cbv測試.Text = "CBV測試";
            this.Btn_cbv測試.UseVisualStyleBackColor = true;
            this.Btn_cbv測試.Click += new System.EventHandler(this.Btn_cbv測試_Click);
            // 
            // Btn_cbr測試
            // 
            this.Btn_cbr測試.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_cbr測試.Location = new System.Drawing.Point(487, 257);
            this.Btn_cbr測試.Name = "Btn_cbr測試";
            this.Btn_cbr測試.Size = new System.Drawing.Size(131, 43);
            this.Btn_cbr測試.TabIndex = 9;
            this.Btn_cbr測試.Text = "CBR測試";
            this.Btn_cbr測試.UseVisualStyleBackColor = true;
            this.Btn_cbr測試.Click += new System.EventHandler(this.Btn_cbr測試_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 435);
            this.Controls.Add(this.Btn_cbr測試);
            this.Controls.Add(this.Btn_cbv測試);
            this.Controls.Add(this.lab_cbr3);
            this.Controls.Add(this.lab_cbr2);
            this.Controls.Add(this.lab_cbr1);
            this.Controls.Add(this.lab_cbv3);
            this.Controls.Add(this.lab_cbv2);
            this.Controls.Add(this.lab_cbv1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "傳值呼叫與傳址呼叫";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_cbv1;
        private System.Windows.Forms.Label lab_cbv2;
        private System.Windows.Forms.Label lab_cbv3;
        private System.Windows.Forms.Label lab_cbr1;
        private System.Windows.Forms.Label lab_cbr2;
        private System.Windows.Forms.Label lab_cbr3;
        private System.Windows.Forms.Button Btn_cbv測試;
        private System.Windows.Forms.Button Btn_cbr測試;
    }
}

