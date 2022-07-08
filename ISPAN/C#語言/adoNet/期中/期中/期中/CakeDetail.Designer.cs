
namespace 期中
{
    partial class CakeDetail
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
            this.lblDetailSize = new System.Windows.Forms.Label();
            this.lblDetailPrice = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.lblDetailName = new System.Windows.Forms.Label();
            this.pictureBoxCake = new System.Windows.Forms.PictureBox();
            this.btnFavorite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCake)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetailSize
            // 
            this.lblDetailSize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDetailSize.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDetailSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(62)))), ((int)(((byte)(38)))));
            this.lblDetailSize.Location = new System.Drawing.Point(46, 45);
            this.lblDetailSize.Name = "lblDetailSize";
            this.lblDetailSize.Size = new System.Drawing.Size(363, 47);
            this.lblDetailSize.TabIndex = 13;
            this.lblDetailSize.Text = "Email";
            this.lblDetailSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDetailPrice
            // 
            this.lblDetailPrice.BackColor = System.Drawing.Color.White;
            this.lblDetailPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDetailPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(62)))), ((int)(((byte)(38)))));
            this.lblDetailPrice.Location = new System.Drawing.Point(172, 399);
            this.lblDetailPrice.Name = "lblDetailPrice";
            this.lblDetailPrice.Size = new System.Drawing.Size(133, 40);
            this.lblDetailPrice.TabIndex = 14;
            this.lblDetailPrice.Text = "$ ";
            this.lblDetailPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudQuantity
            // 
            this.nudQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudQuantity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nudQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(62)))), ((int)(((byte)(38)))));
            this.nudQuantity.Location = new System.Drawing.Point(148, 477);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(90, 29);
            this.nudQuantity.TabIndex = 15;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(62)))), ((int)(((byte)(38)))));
            this.btnAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCar.FlatAppearance.BorderSize = 0;
            this.btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCar.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddCar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCar.Location = new System.Drawing.Point(259, 469);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(155, 44);
            this.btnAddCar.TabIndex = 16;
            this.btnAddCar.Text = "加入購物車";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtDetail);
            this.panel1.Controls.Add(this.lblDetailName);
            this.panel1.Controls.Add(this.lblDetailPrice);
            this.panel1.Controls.Add(this.lblDetailSize);
            this.panel1.Controls.Add(this.pictureBoxCake);
            this.panel1.Location = new System.Drawing.Point(43, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 452);
            this.panel1.TabIndex = 17;
            // 
            // txtDetail
            // 
            this.txtDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDetail.CausesValidation = false;
            this.txtDetail.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(62)))), ((int)(((byte)(38)))));
            this.txtDetail.Location = new System.Drawing.Point(41, 292);
            this.txtDetail.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetail.Size = new System.Drawing.Size(368, 105);
            this.txtDetail.TabIndex = 18;
            // 
            // lblDetailName
            // 
            this.lblDetailName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDetailName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDetailName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(62)))), ((int)(((byte)(38)))));
            this.lblDetailName.Location = new System.Drawing.Point(46, 14);
            this.lblDetailName.Name = "lblDetailName";
            this.lblDetailName.Size = new System.Drawing.Size(363, 31);
            this.lblDetailName.TabIndex = 11;
            this.lblDetailName.Text = "Email";
            this.lblDetailName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxCake
            // 
            this.pictureBoxCake.BackColor = System.Drawing.Color.White;
            this.pictureBoxCake.Location = new System.Drawing.Point(116, 94);
            this.pictureBoxCake.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCake.Name = "pictureBoxCake";
            this.pictureBoxCake.Size = new System.Drawing.Size(235, 193);
            this.pictureBoxCake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCake.TabIndex = 10;
            this.pictureBoxCake.TabStop = false;
            // 
            // btnFavorite
            // 
            this.btnFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(62)))), ((int)(((byte)(38)))));
            this.btnFavorite.BackgroundImage = global::期中.Properties.Resources.LOVE3;
            this.btnFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavorite.FlatAppearance.BorderSize = 0;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFavorite.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFavorite.Location = new System.Drawing.Point(420, 466);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(71, 50);
            this.btnFavorite.TabIndex = 18;
            this.btnFavorite.UseVisualStyleBackColor = false;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // CakeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(62)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(560, 523);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CakeDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品詳細";
            this.Load += new System.EventHandler(this.CakeDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCake;
        private System.Windows.Forms.Label lblDetailSize;
        private System.Windows.Forms.Label lblDetailPrice;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Label lblDetailName;
    }
}