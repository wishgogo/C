
namespace WindowsFormsApp5
{
    partial class FormDetail
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl序號 = new System.Windows.Forms.Label();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.txt商品描述 = new System.Windows.Forms.TextBox();
            this.txt商品價格 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox修改商品 = new System.Windows.Forms.GroupBox();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            this.btn選取商品照片 = new System.Windows.Forms.Button();
            this.groupBox新增商品 = new System.Windows.Forms.GroupBox();
            this.btn選取商品照片2 = new System.Windows.Forms.Button();
            this.btn儲存商品 = new System.Windows.Forms.Button();
            this.btn新增商品 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox修改商品.SuspendLayout();
            this.groupBox新增商品.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "序號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品名稱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(22, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品價格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(22, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "商品描述";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(367, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "商品圖檔";
            // 
            // lbl序號
            // 
            this.lbl序號.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl序號.Location = new System.Drawing.Point(129, 19);
            this.lbl序號.Name = "lbl序號";
            this.lbl序號.Size = new System.Drawing.Size(89, 24);
            this.lbl序號.TabIndex = 5;
            this.lbl序號.Text = "000000000";
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.Location = new System.Drawing.Point(132, 63);
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(153, 22);
            this.txt商品名稱.TabIndex = 6;
            // 
            // txt商品描述
            // 
            this.txt商品描述.Location = new System.Drawing.Point(132, 167);
            this.txt商品描述.Multiline = true;
            this.txt商品描述.Name = "txt商品描述";
            this.txt商品描述.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt商品描述.Size = new System.Drawing.Size(205, 173);
            this.txt商品描述.TabIndex = 7;
            // 
            // txt商品價格
            // 
            this.txt商品價格.Location = new System.Drawing.Point(132, 119);
            this.txt商品價格.Name = "txt商品價格";
            this.txt商品價格.Size = new System.Drawing.Size(153, 22);
            this.txt商品價格.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(370, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox修改商品
            // 
            this.groupBox修改商品.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox修改商品.Controls.Add(this.btn儲存修改);
            this.groupBox修改商品.Controls.Add(this.btn選取商品照片);
            this.groupBox修改商品.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox修改商品.Location = new System.Drawing.Point(26, 363);
            this.groupBox修改商品.Name = "groupBox修改商品";
            this.groupBox修改商品.Size = new System.Drawing.Size(288, 156);
            this.groupBox修改商品.TabIndex = 10;
            this.groupBox修改商品.TabStop = false;
            this.groupBox修改商品.Text = "修改商品資訊";
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.Location = new System.Drawing.Point(78, 83);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(130, 41);
            this.btn儲存修改.TabIndex = 1;
            this.btn儲存修改.Text = "儲存修改";
            this.btn儲存修改.UseVisualStyleBackColor = true;
            this.btn儲存修改.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // btn選取商品照片
            // 
            this.btn選取商品照片.Location = new System.Drawing.Point(78, 36);
            this.btn選取商品照片.Name = "btn選取商品照片";
            this.btn選取商品照片.Size = new System.Drawing.Size(130, 41);
            this.btn選取商品照片.TabIndex = 0;
            this.btn選取商品照片.Text = "選取商品照片";
            this.btn選取商品照片.UseVisualStyleBackColor = true;
            this.btn選取商品照片.Click += new System.EventHandler(this.btn選取商品照片_Click);
            // 
            // groupBox新增商品
            // 
            this.groupBox新增商品.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox新增商品.Controls.Add(this.btn選取商品照片2);
            this.groupBox新增商品.Controls.Add(this.btn儲存商品);
            this.groupBox新增商品.Controls.Add(this.btn新增商品);
            this.groupBox新增商品.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox新增商品.Location = new System.Drawing.Point(330, 363);
            this.groupBox新增商品.Name = "groupBox新增商品";
            this.groupBox新增商品.Size = new System.Drawing.Size(298, 156);
            this.groupBox新增商品.TabIndex = 11;
            this.groupBox新增商品.TabStop = false;
            this.groupBox新增商品.Text = "新增商品資訊";
            // 
            // btn選取商品照片2
            // 
            this.btn選取商品照片2.Location = new System.Drawing.Point(63, 64);
            this.btn選取商品照片2.Name = "btn選取商品照片2";
            this.btn選取商品照片2.Size = new System.Drawing.Size(179, 37);
            this.btn選取商品照片2.TabIndex = 2;
            this.btn選取商品照片2.Text = "選取商品照片";
            this.btn選取商品照片2.UseVisualStyleBackColor = true;
            this.btn選取商品照片2.Click += new System.EventHandler(this.btn選取商品照片_Click);
            // 
            // btn儲存商品
            // 
            this.btn儲存商品.Location = new System.Drawing.Point(63, 106);
            this.btn儲存商品.Name = "btn儲存商品";
            this.btn儲存商品.Size = new System.Drawing.Size(179, 37);
            this.btn儲存商品.TabIndex = 3;
            this.btn儲存商品.Text = "儲存商品";
            this.btn儲存商品.UseVisualStyleBackColor = true;
            this.btn儲存商品.Click += new System.EventHandler(this.btn儲存商品_Click);
            // 
            // btn新增商品
            // 
            this.btn新增商品.Location = new System.Drawing.Point(63, 21);
            this.btn新增商品.Name = "btn新增商品";
            this.btn新增商品.Size = new System.Drawing.Size(179, 37);
            this.btn新增商品.TabIndex = 2;
            this.btn新增商品.Text = "新增商品(清空欄位)";
            this.btn新增商品.UseVisualStyleBackColor = true;
            this.btn新增商品.Click += new System.EventHandler(this.btn新增商品_Click);
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(654, 520);
            this.Controls.Add(this.groupBox新增商品);
            this.Controls.Add(this.groupBox修改商品);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt商品價格);
            this.Controls.Add(this.txt商品描述);
            this.Controls.Add(this.txt商品名稱);
            this.Controls.Add(this.lbl序號);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDetail";
            this.Text = "商品詳細資訊";
            this.Load += new System.EventHandler(this.FormDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox修改商品.ResumeLayout(false);
            this.groupBox新增商品.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl序號;
        private System.Windows.Forms.TextBox txt商品名稱;
        private System.Windows.Forms.TextBox txt商品描述;
        private System.Windows.Forms.TextBox txt商品價格;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox修改商品;
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.Button btn選取商品照片;
        private System.Windows.Forms.GroupBox groupBox新增商品;
        private System.Windows.Forms.Button btn選取商品照片2;
        private System.Windows.Forms.Button btn儲存商品;
        private System.Windows.Forms.Button btn新增商品;
    }
}