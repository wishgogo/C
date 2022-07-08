
namespace BingoBingo
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
            this.btnLottery = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSafe = new System.Windows.Forms.Button();
            this.btnSmallOdd = new System.Windows.Forms.Button();
            this.btnSmallEven = new System.Windows.Forms.Button();
            this.btnEven = new System.Windows.Forms.Button();
            this.btnOdd = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnBig = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.msgStar = new System.Windows.Forms.Label();
            this.InputAuto = new System.Windows.Forms.CheckBox();
            this.InputSuper = new System.Windows.Forms.CheckBox();
            this.labNumber = new System.Windows.Forms.Label();
            this.labStar = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.InputNumber = new System.Windows.Forms.TextBox();
            this.btnBigSmall = new System.Windows.Forms.Button();
            this.InputStar = new System.Windows.Forms.TextBox();
            this.btnOddEven = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLottery
            // 
            this.btnLottery.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnLottery.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLottery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLottery.Location = new System.Drawing.Point(268, 401);
            this.btnLottery.Name = "btnLottery";
            this.btnLottery.Size = new System.Drawing.Size(124, 65);
            this.btnLottery.TabIndex = 35;
            this.btnLottery.Text = "開獎";
            this.btnLottery.UseVisualStyleBackColor = false;
            this.btnLottery.Click += new System.EventHandler(this.btnLottery_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSafe);
            this.groupBox2.Controls.Add(this.btnSmallOdd);
            this.groupBox2.Controls.Add(this.btnSmallEven);
            this.groupBox2.Controls.Add(this.btnEven);
            this.groupBox2.Controls.Add(this.btnOdd);
            this.groupBox2.Controls.Add(this.btnSmall);
            this.groupBox2.Controls.Add(this.btnBig);
            this.groupBox2.Controls.Add(this.msg);
            this.groupBox2.Controls.Add(this.msgStar);
            this.groupBox2.Controls.Add(this.InputAuto);
            this.groupBox2.Controls.Add(this.InputSuper);
            this.groupBox2.Controls.Add(this.labNumber);
            this.groupBox2.Controls.Add(this.labStar);
            this.groupBox2.Controls.Add(this.btnEasy);
            this.groupBox2.Controls.Add(this.InputNumber);
            this.groupBox2.Controls.Add(this.btnBigSmall);
            this.groupBox2.Controls.Add(this.InputStar);
            this.groupBox2.Controls.Add(this.btnOddEven);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(120, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 348);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "選擇玩法";
            // 
            // btnSafe
            // 
            this.btnSafe.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSafe.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSafe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSafe.Location = new System.Drawing.Point(376, 227);
            this.btnSafe.Name = "btnSafe";
            this.btnSafe.Size = new System.Drawing.Size(130, 42);
            this.btnSafe.TabIndex = 57;
            this.btnSafe.Text = "和";
            this.btnSafe.UseVisualStyleBackColor = false;
            this.btnSafe.Visible = false;
            this.btnSafe.Click += new System.EventHandler(this.btnSafe_Click);
            // 
            // btnSmallOdd
            // 
            this.btnSmallOdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSmallOdd.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSmallOdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSmallOdd.Location = new System.Drawing.Point(376, 179);
            this.btnSmallOdd.Name = "btnSmallOdd";
            this.btnSmallOdd.Size = new System.Drawing.Size(63, 42);
            this.btnSmallOdd.TabIndex = 56;
            this.btnSmallOdd.Text = "小單";
            this.btnSmallOdd.UseVisualStyleBackColor = false;
            this.btnSmallOdd.Visible = false;
            this.btnSmallOdd.Click += new System.EventHandler(this.btnSmallOdd_Click);
            // 
            // btnSmallEven
            // 
            this.btnSmallEven.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSmallEven.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSmallEven.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSmallEven.Location = new System.Drawing.Point(445, 179);
            this.btnSmallEven.Name = "btnSmallEven";
            this.btnSmallEven.Size = new System.Drawing.Size(63, 42);
            this.btnSmallEven.TabIndex = 55;
            this.btnSmallEven.Text = "小雙";
            this.btnSmallEven.UseVisualStyleBackColor = false;
            this.btnSmallEven.Visible = false;
            this.btnSmallEven.Click += new System.EventHandler(this.btnSmallEven_Click);
            // 
            // btnEven
            // 
            this.btnEven.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEven.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEven.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEven.Location = new System.Drawing.Point(445, 132);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(63, 42);
            this.btnEven.TabIndex = 53;
            this.btnEven.Text = "雙";
            this.btnEven.UseVisualStyleBackColor = false;
            this.btnEven.Visible = false;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnOdd
            // 
            this.btnOdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOdd.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdd.Location = new System.Drawing.Point(376, 132);
            this.btnOdd.Name = "btnOdd";
            this.btnOdd.Size = new System.Drawing.Size(63, 42);
            this.btnOdd.TabIndex = 52;
            this.btnOdd.Text = "單";
            this.btnOdd.UseVisualStyleBackColor = false;
            this.btnOdd.Visible = false;
            this.btnOdd.Click += new System.EventHandler(this.btnOdd_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSmall.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSmall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSmall.Location = new System.Drawing.Point(290, 180);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(47, 42);
            this.btnSmall.TabIndex = 51;
            this.btnSmall.Text = "小";
            this.btnSmall.UseVisualStyleBackColor = false;
            this.btnSmall.Visible = false;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnBig
            // 
            this.btnBig.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBig.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBig.Location = new System.Drawing.Point(290, 132);
            this.btnBig.Name = "btnBig";
            this.btnBig.Size = new System.Drawing.Size(47, 42);
            this.btnBig.TabIndex = 49;
            this.btnBig.Text = "大";
            this.btnBig.UseVisualStyleBackColor = false;
            this.btnBig.Visible = false;
            this.btnBig.Click += new System.EventHandler(this.btnBig_Click);
            // 
            // msg
            // 
            this.msg.BackColor = System.Drawing.Color.DimGray;
            this.msg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.msg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.msg.Location = new System.Drawing.Point(6, 269);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(215, 58);
            this.msg.TabIndex = 47;
            this.msg.Text = "label1";
            this.msg.Visible = false;
            // 
            // msgStar
            // 
            this.msgStar.BackColor = System.Drawing.Color.DimGray;
            this.msgStar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.msgStar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.msgStar.Location = new System.Drawing.Point(6, 248);
            this.msgStar.Name = "msgStar";
            this.msgStar.Size = new System.Drawing.Size(215, 21);
            this.msgStar.TabIndex = 48;
            this.msgStar.Text = "label1";
            this.msgStar.Visible = false;
            // 
            // InputAuto
            // 
            this.InputAuto.AutoSize = true;
            this.InputAuto.Location = new System.Drawing.Point(401, 299);
            this.InputAuto.Name = "InputAuto";
            this.InputAuto.Size = new System.Drawing.Size(105, 28);
            this.InputAuto.TabIndex = 47;
            this.InputAuto.Text = "自動選號";
            this.InputAuto.UseVisualStyleBackColor = true;
            this.InputAuto.Visible = false;
            this.InputAuto.CheckedChanged += new System.EventHandler(this.InputAuto_CheckedChanged);
            // 
            // InputSuper
            // 
            this.InputSuper.AutoSize = true;
            this.InputSuper.Location = new System.Drawing.Point(290, 299);
            this.InputSuper.Name = "InputSuper";
            this.InputSuper.Size = new System.Drawing.Size(105, 28);
            this.InputSuper.TabIndex = 46;
            this.InputSuper.Text = "超級獎號";
            this.InputSuper.UseVisualStyleBackColor = true;
            this.InputSuper.Visible = false;
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labNumber.Location = new System.Drawing.Point(6, 201);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(132, 21);
            this.labNumber.TabIndex = 45;
            this.labNumber.Text = "請輸入號碼1~80";
            this.labNumber.Visible = false;
            // 
            // labStar
            // 
            this.labStar.AutoSize = true;
            this.labStar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labStar.Location = new System.Drawing.Point(6, 152);
            this.labStar.Name = "labStar";
            this.labStar.Size = new System.Drawing.Size(136, 21);
            this.labStar.TabIndex = 44;
            this.labStar.Text = "請輸入星級1~10:";
            this.labStar.Visible = false;
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEasy.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEasy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEasy.Location = new System.Drawing.Point(121, 23);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(106, 109);
            this.btnEasy.TabIndex = 36;
            this.btnEasy.Text = "基本玩法";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // InputNumber
            // 
            this.InputNumber.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputNumber.ForeColor = System.Drawing.Color.LightSlateGray;
            this.InputNumber.Location = new System.Drawing.Point(148, 196);
            this.InputNumber.Name = "InputNumber";
            this.InputNumber.Size = new System.Drawing.Size(73, 39);
            this.InputNumber.TabIndex = 43;
            this.InputNumber.Visible = false;
            this.InputNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberInput);
            // 
            // btnBigSmall
            // 
            this.btnBigSmall.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBigSmall.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBigSmall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBigSmall.Location = new System.Drawing.Point(271, 26);
            this.btnBigSmall.Name = "btnBigSmall";
            this.btnBigSmall.Size = new System.Drawing.Size(86, 91);
            this.btnBigSmall.TabIndex = 39;
            this.btnBigSmall.Text = "猜大小";
            this.btnBigSmall.UseVisualStyleBackColor = false;
            this.btnBigSmall.Click += new System.EventHandler(this.btnBigSmall_Click);
            // 
            // InputStar
            // 
            this.InputStar.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputStar.ForeColor = System.Drawing.Color.LightSlateGray;
            this.InputStar.Location = new System.Drawing.Point(148, 145);
            this.InputStar.Name = "InputStar";
            this.InputStar.Size = new System.Drawing.Size(73, 39);
            this.InputStar.TabIndex = 42;
            this.InputStar.Visible = false;
            this.InputStar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StarInput);
            // 
            // btnOddEven
            // 
            this.btnOddEven.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOddEven.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOddEven.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOddEven.Location = new System.Drawing.Point(401, 26);
            this.btnOddEven.Name = "btnOddEven";
            this.btnOddEven.Size = new System.Drawing.Size(86, 91);
            this.btnOddEven.TabIndex = 40;
            this.btnOddEven.Text = "猜單雙";
            this.btnOddEven.UseVisualStyleBackColor = false;
            this.btnOddEven.Click += new System.EventHandler(this.btnOddEven_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SlateGray;
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(409, 401);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 65);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(749, 501);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLottery);
            this.Name = "Form1";
            this.Text = "BingoBingo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLottery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox InputAuto;
        private System.Windows.Forms.CheckBox InputSuper;
        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.Label labStar;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.TextBox InputNumber;
        private System.Windows.Forms.Button btnBigSmall;
        private System.Windows.Forms.TextBox InputStar;
        private System.Windows.Forms.Button btnOddEven;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label msgStar;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Button btnSafe;
        private System.Windows.Forms.Button btnSmallOdd;
        private System.Windows.Forms.Button btnSmallEven;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Button btnOdd;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnBig;
    }
}

