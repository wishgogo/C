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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mydbDataSet = new WindowsFormsApp3.mydbDataSet();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new WindowsFormsApp3.mydbDataSetTableAdapters.personsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.mydbDataSetTableAdapters.TableAdapterManager();
            this.personsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.personsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.txt信箱 = new System.Windows.Forms.TextBox();
            this.txt點數 = new System.Windows.Forms.TextBox();
            this.chk婚姻狀態 = new System.Windows.Forms.CheckBox();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.btn第一筆 = new System.Windows.Forms.Button();
            this.btn上一筆 = new System.Windows.Forms.Button();
            this.btn下一筆 = new System.Windows.Forms.Button();
            this.btn最後一筆 = new System.Windows.Forms.Button();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.btn回復資料 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn新增資料_儲存 = new System.Windows.Forms.Button();
            this.btn新增資料_新增 = new System.Windows.Forms.Button();
            this.lbl第X筆共X筆 = new System.Windows.Forms.Label();
            this.lbox姓名 = new System.Windows.Forms.ListBox();
            this.cboxEmail = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn移除Filter條件 = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.cboxFilter = new System.Windows.Forms.ComboBox();
            this.cboxFind = new System.Windows.Forms.ComboBox();
            this.textFilter = new System.Windows.Forms.TextBox();
            this.textFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingNavigator)).BeginInit();
            this.personsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "persons";
            this.personsBindingSource.DataSource = this.mydbDataSet;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.personsTableAdapter = this.personsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.mydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personsBindingNavigator
            // 
            this.personsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personsBindingNavigator.BindingSource = this.personsBindingSource;
            this.personsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personsBindingNavigatorSaveItem});
            this.personsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personsBindingNavigator.Name = "personsBindingNavigator";
            this.personsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.personsBindingNavigator.TabIndex = 0;
            this.personsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(51, 22);
            this.bindingNavigatorAddNewItem.Text = "新增";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(51, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // personsBindingNavigatorSaveItem
            // 
            this.personsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personsBindingNavigatorSaveItem.Image")));
            this.personsBindingNavigatorSaveItem.Name = "personsBindingNavigatorSaveItem";
            this.personsBindingNavigatorSaveItem.Size = new System.Drawing.Size(75, 22);
            this.personsBindingNavigatorSaveItem.Text = "儲存資料";
            this.personsBindingNavigatorSaveItem.Click += new System.EventHandler(this.personsBindingNavigatorSaveItem_Click);
            // 
            // personsDataGridView
            // 
            this.personsDataGridView.AutoGenerateColumns = false;
            this.personsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.personsDataGridView.DataSource = this.personsBindingSource;
            this.personsDataGridView.Location = new System.Drawing.Point(740, 28);
            this.personsDataGridView.Name = "personsDataGridView";
            this.personsDataGridView.RowTemplate.Height = 24;
            this.personsDataGridView.Size = new System.Drawing.Size(60, 116);
            this.personsDataGridView.TabIndex = 1;
            this.personsDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "姓名";
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "電話";
            this.dataGridViewTextBoxColumn3.HeaderText = "電話";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "地址";
            this.dataGridViewTextBoxColumn4.HeaderText = "地址";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn5.HeaderText = "email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "生日";
            this.dataGridViewTextBoxColumn6.HeaderText = "生日";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "婚姻狀態";
            this.dataGridViewCheckBoxColumn1.HeaderText = "婚姻狀態";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "點數";
            this.dataGridViewTextBoxColumn7.HeaderText = "點數";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "電話";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(22, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(22, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(22, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "生日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(22, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "婚姻狀態";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(22, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "點數";
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Id", true));
            this.lblId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblId.Location = new System.Drawing.Point(109, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(80, 21);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "0";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt姓名
            // 
            this.txt姓名.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "姓名", true));
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(105, 90);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(161, 27);
            this.txt姓名.TabIndex = 11;
            // 
            // txt電話
            // 
            this.txt電話.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "電話", true));
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(105, 126);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(161, 27);
            this.txt電話.TabIndex = 12;
            // 
            // txt地址
            // 
            this.txt地址.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "地址", true));
            this.txt地址.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt地址.Location = new System.Drawing.Point(105, 170);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(348, 27);
            this.txt地址.TabIndex = 13;
            // 
            // txt信箱
            // 
            this.txt信箱.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "email", true));
            this.txt信箱.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt信箱.Location = new System.Drawing.Point(105, 205);
            this.txt信箱.Name = "txt信箱";
            this.txt信箱.Size = new System.Drawing.Size(348, 27);
            this.txt信箱.TabIndex = 14;
            // 
            // txt點數
            // 
            this.txt點數.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "點數", true));
            this.txt點數.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt點數.Location = new System.Drawing.Point(105, 310);
            this.txt點數.Name = "txt點數";
            this.txt點數.Size = new System.Drawing.Size(84, 27);
            this.txt點數.TabIndex = 15;
            // 
            // chk婚姻狀態
            // 
            this.chk婚姻狀態.AutoSize = true;
            this.chk婚姻狀態.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.personsBindingSource, "婚姻狀態", true));
            this.chk婚姻狀態.Location = new System.Drawing.Point(105, 275);
            this.chk婚姻狀態.Name = "chk婚姻狀態";
            this.chk婚姻狀態.Size = new System.Drawing.Size(48, 16);
            this.chk婚姻狀態.TabIndex = 16;
            this.chk婚姻狀態.Text = "已婚";
            this.chk婚姻狀態.UseVisualStyleBackColor = true;
            // 
            // dtp生日
            // 
            this.dtp生日.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personsBindingSource, "生日", true));
            this.dtp生日.Location = new System.Drawing.Point(105, 239);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(161, 22);
            this.dtp生日.TabIndex = 17;
            // 
            // btn第一筆
            // 
            this.btn第一筆.BackColor = System.Drawing.Color.DarkGray;
            this.btn第一筆.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn第一筆.Location = new System.Drawing.Point(275, 312);
            this.btn第一筆.Name = "btn第一筆";
            this.btn第一筆.Size = new System.Drawing.Size(92, 35);
            this.btn第一筆.TabIndex = 18;
            this.btn第一筆.Text = "第一筆";
            this.btn第一筆.UseVisualStyleBackColor = false;
            this.btn第一筆.Click += new System.EventHandler(this.btn第一筆_Click);
            // 
            // btn上一筆
            // 
            this.btn上一筆.BackColor = System.Drawing.Color.DarkGray;
            this.btn上一筆.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn上一筆.Location = new System.Drawing.Point(380, 312);
            this.btn上一筆.Name = "btn上一筆";
            this.btn上一筆.Size = new System.Drawing.Size(92, 35);
            this.btn上一筆.TabIndex = 19;
            this.btn上一筆.Text = "上一筆";
            this.btn上一筆.UseVisualStyleBackColor = false;
            this.btn上一筆.Click += new System.EventHandler(this.btn上一筆_Click);
            // 
            // btn下一筆
            // 
            this.btn下一筆.BackColor = System.Drawing.Color.DarkGray;
            this.btn下一筆.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn下一筆.Location = new System.Drawing.Point(478, 312);
            this.btn下一筆.Name = "btn下一筆";
            this.btn下一筆.Size = new System.Drawing.Size(92, 35);
            this.btn下一筆.TabIndex = 20;
            this.btn下一筆.Text = "下一筆";
            this.btn下一筆.UseVisualStyleBackColor = false;
            this.btn下一筆.Click += new System.EventHandler(this.btn下一筆_Click);
            // 
            // btn最後一筆
            // 
            this.btn最後一筆.BackColor = System.Drawing.Color.DarkGray;
            this.btn最後一筆.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn最後一筆.Location = new System.Drawing.Point(576, 312);
            this.btn最後一筆.Name = "btn最後一筆";
            this.btn最後一筆.Size = new System.Drawing.Size(92, 35);
            this.btn最後一筆.TabIndex = 21;
            this.btn最後一筆.Text = "最後一筆";
            this.btn最後一筆.UseVisualStyleBackColor = false;
            this.btn最後一筆.Click += new System.EventHandler(this.btn最後一筆_Click);
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.BackColor = System.Drawing.Color.DarkGray;
            this.btn儲存修改.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存修改.Location = new System.Drawing.Point(275, 353);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(92, 35);
            this.btn儲存修改.TabIndex = 22;
            this.btn儲存修改.Text = "儲存修改";
            this.btn儲存修改.UseVisualStyleBackColor = false;
            this.btn儲存修改.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // btn刪除
            // 
            this.btn刪除.BackColor = System.Drawing.Color.DarkGray;
            this.btn刪除.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Location = new System.Drawing.Point(380, 353);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(92, 35);
            this.btn刪除.TabIndex = 23;
            this.btn刪除.Text = "刪除";
            this.btn刪除.UseVisualStyleBackColor = false;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // btn回復資料
            // 
            this.btn回復資料.BackColor = System.Drawing.Color.DarkGray;
            this.btn回復資料.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回復資料.Location = new System.Drawing.Point(478, 353);
            this.btn回復資料.Name = "btn回復資料";
            this.btn回復資料.Size = new System.Drawing.Size(92, 35);
            this.btn回復資料.TabIndex = 24;
            this.btn回復資料.Text = "回復資料";
            this.btn回復資料.UseVisualStyleBackColor = false;
            this.btn回復資料.Click += new System.EventHandler(this.btn回復資料_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.btn新增資料_儲存);
            this.groupBox1.Controls.Add(this.btn新增資料_新增);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(576, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 85);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增資料";
            // 
            // btn新增資料_儲存
            // 
            this.btn新增資料_儲存.BackColor = System.Drawing.Color.DarkGray;
            this.btn新增資料_儲存.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增資料_儲存.Location = new System.Drawing.Point(85, 22);
            this.btn新增資料_儲存.Name = "btn新增資料_儲存";
            this.btn新增資料_儲存.Size = new System.Drawing.Size(61, 55);
            this.btn新增資料_儲存.TabIndex = 27;
            this.btn新增資料_儲存.Text = "儲存";
            this.btn新增資料_儲存.UseVisualStyleBackColor = false;
            this.btn新增資料_儲存.Click += new System.EventHandler(this.btn新增資料_儲存_Click);
            // 
            // btn新增資料_新增
            // 
            this.btn新增資料_新增.BackColor = System.Drawing.Color.DarkGray;
            this.btn新增資料_新增.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增資料_新增.Location = new System.Drawing.Point(18, 22);
            this.btn新增資料_新增.Name = "btn新增資料_新增";
            this.btn新增資料_新增.Size = new System.Drawing.Size(61, 55);
            this.btn新增資料_新增.TabIndex = 26;
            this.btn新增資料_新增.Text = "新增";
            this.btn新增資料_新增.UseVisualStyleBackColor = false;
            this.btn新增資料_新增.Click += new System.EventHandler(this.btn新增資料_新增_Click);
            // 
            // lbl第X筆共X筆
            // 
            this.lbl第X筆共X筆.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lbl第X筆共X筆.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl第X筆共X筆.Location = new System.Drawing.Point(424, 288);
            this.lbl第X筆共X筆.Name = "lbl第X筆共X筆";
            this.lbl第X筆共X筆.Size = new System.Drawing.Size(111, 21);
            this.lbl第X筆共X筆.TabIndex = 26;
            this.lbl第X筆共X筆.Text = "第X筆/共X筆";
            this.lbl第X筆共X筆.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbox姓名
            // 
            this.lbox姓名.DataSource = this.personsBindingSource;
            this.lbox姓名.DisplayMember = "姓名";
            this.lbox姓名.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox姓名.FormattingEnabled = true;
            this.lbox姓名.ItemHeight = 15;
            this.lbox姓名.Location = new System.Drawing.Point(614, 156);
            this.lbox姓名.Name = "lbox姓名";
            this.lbox姓名.Size = new System.Drawing.Size(120, 94);
            this.lbox姓名.TabIndex = 27;
            // 
            // cboxEmail
            // 
            this.cboxEmail.DataSource = this.personsBindingSource;
            this.cboxEmail.DisplayMember = "email";
            this.cboxEmail.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxEmail.FormattingEnabled = true;
            this.cboxEmail.Location = new System.Drawing.Point(586, 256);
            this.cboxEmail.Name = "cboxEmail";
            this.cboxEmail.Size = new System.Drawing.Size(172, 23);
            this.cboxEmail.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.btn移除Filter條件);
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.cboxFilter);
            this.groupBox2.Controls.Add(this.cboxFind);
            this.groupBox2.Controls.Add(this.textFilter);
            this.groupBox2.Controls.Add(this.textFind);
            this.groupBox2.Location = new System.Drawing.Point(393, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 84);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜尋功能";
            // 
            // btn移除Filter條件
            // 
            this.btn移除Filter條件.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除Filter條件.Location = new System.Drawing.Point(293, 22);
            this.btn移除Filter條件.Name = "btn移除Filter條件";
            this.btn移除Filter條件.Size = new System.Drawing.Size(43, 47);
            this.btn移除Filter條件.TabIndex = 30;
            this.btn移除Filter條件.Text = "移除Filter條件";
            this.btn移除Filter條件.UseVisualStyleBackColor = true;
            this.btn移除Filter條件.Click += new System.EventHandler(this.btn移除Filter條件_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(244, 47);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(46, 23);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(244, 21);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(46, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cboxFilter
            // 
            this.cboxFilter.FormattingEnabled = true;
            this.cboxFilter.Location = new System.Drawing.Point(154, 49);
            this.cboxFilter.Name = "cboxFilter";
            this.cboxFilter.Size = new System.Drawing.Size(84, 20);
            this.cboxFilter.TabIndex = 3;
            // 
            // cboxFind
            // 
            this.cboxFind.FormattingEnabled = true;
            this.cboxFind.Location = new System.Drawing.Point(154, 22);
            this.cboxFind.Name = "cboxFind";
            this.cboxFind.Size = new System.Drawing.Size(84, 20);
            this.cboxFind.TabIndex = 2;
            // 
            // textFilter
            // 
            this.textFilter.Location = new System.Drawing.Point(7, 47);
            this.textFilter.Name = "textFilter";
            this.textFilter.Size = new System.Drawing.Size(141, 22);
            this.textFilter.TabIndex = 1;
            // 
            // textFind
            // 
            this.textFind.Location = new System.Drawing.Point(7, 22);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(141, 22);
            this.textFind.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboxEmail);
            this.Controls.Add(this.lbox姓名);
            this.Controls.Add(this.lbl第X筆共X筆);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn回復資料);
            this.Controls.Add(this.btn刪除);
            this.Controls.Add(this.btn儲存修改);
            this.Controls.Add(this.btn最後一筆);
            this.Controls.Add(this.btn下一筆);
            this.Controls.Add(this.btn上一筆);
            this.Controls.Add(this.btn第一筆);
            this.Controls.Add(this.dtp生日);
            this.Controls.Add(this.chk婚姻狀態);
            this.Controls.Add(this.txt點數);
            this.Controls.Add(this.txt信箱);
            this.Controls.Add(this.txt地址);
            this.Controls.Add(this.txt電話);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personsDataGridView);
            this.Controls.Add(this.personsBindingNavigator);
            this.Name = "Form1";
            this.Text = "會員資料表單(SQL Server)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingNavigator)).EndInit();
            this.personsBindingNavigator.ResumeLayout(false);
            this.personsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private mydbDataSetTableAdapters.personsTableAdapter personsTableAdapter;
        private mydbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView personsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.TextBox txt信箱;
        private System.Windows.Forms.TextBox txt點數;
        private System.Windows.Forms.CheckBox chk婚姻狀態;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.Button btn第一筆;
        private System.Windows.Forms.Button btn上一筆;
        private System.Windows.Forms.Button btn下一筆;
        private System.Windows.Forms.Button btn最後一筆;
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.Button btn刪除;
        private System.Windows.Forms.Button btn回復資料;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn新增資料_儲存;
        private System.Windows.Forms.Button btn新增資料_新增;
        private System.Windows.Forms.Label lbl第X筆共X筆;
        private System.Windows.Forms.ListBox lbox姓名;
        private System.Windows.Forms.ComboBox cboxEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cboxFilter;
        private System.Windows.Forms.ComboBox cboxFind;
        private System.Windows.Forms.TextBox textFilter;
        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.Button btn移除Filter條件;
    }
}

