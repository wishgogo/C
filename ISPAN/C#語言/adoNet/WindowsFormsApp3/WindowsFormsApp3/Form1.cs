using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //導航列
        private void personsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate(); //預設欄位檢查
            this.personsBindingSource.EndEdit(); //結束編輯模式
            this.tableAdapterManager.UpdateAll(this.mydbDataSet); //所有DATASET全部再儲存一遍

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'mydbDataSet.persons' 資料表。您可以視需要進行移動或移除。
            this.personsTableAdapter.Fill(this.mydbDataSet.persons);
            cboxFind.Items.Add("姓名");
            cboxFind.Items.Add("電話");
            cboxFind.Items.Add("地址");
            cboxFind.Items.Add("email");
            cboxFind.SelectedIndex = 0;

            cboxFilter.Items.Add("姓名");
            cboxFilter.Items.Add("電話");
            cboxFilter.Items.Add("地址");
            cboxFilter.Items.Add("email");
            cboxFilter.SelectedIndex = 0;

            顯示第幾筆共幾筆資料();
        }

        void 顯示第幾筆共幾筆資料()
        {
            int 目前第幾筆=personsBindingSource.Position+1;
            lbl第X筆共X筆.Text="第"+目前第幾筆+"筆"+"/"+"共"+personsBindingSource.Count+"筆";

        }
        private void btn第一筆_Click(object sender, EventArgs e)
        {
            personsBindingSource.MoveFirst();
            顯示第幾筆共幾筆資料();
        }

        private void btn上一筆_Click(object sender, EventArgs e)
        {
            personsBindingSource.MovePrevious();
            顯示第幾筆共幾筆資料();
        }

        private void btn下一筆_Click(object sender, EventArgs e)
        {
            personsBindingSource.MoveNext();
            顯示第幾筆共幾筆資料();
        }

        private void btn最後一筆_Click(object sender, EventArgs e)
        {
            personsBindingSource.MoveLast(); 
            顯示第幾筆共幾筆資料();
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("你確認要儲存?", "儲存確認", MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                //yes儲存
                //未來工作時要做欄位檢查
                Validate();
                personsBindingSource.EndEdit();
                personsTableAdapter.Update(mydbDataSet.persons);
                顯示第幾筆共幾筆資料();
                MessageBox.Show("資料儲存成功");
            }
            else
            {
                //no

            }
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("你確認要刪除此筆資料?","刪除確認",MessageBoxButtons.YesNo);

            if(R == DialogResult.Yes)
            {//yes
                personsBindingSource.EndEdit();
                int idxCurrent = personsBindingSource.Position;
                personsBindingSource.RemoveAt(idxCurrent);
                personsTableAdapter.Update(mydbDataSet.persons);
                personsBindingSource.Position = 0;
                顯示第幾筆共幾筆資料();
                MessageBox.Show("資料刪除成功");
            }else
            {// no

            }
        }

        private void btn回復資料_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("您確認要回復資料","資料回復",MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                //yes
                personsBindingSource.EndEdit();
                int idxCurrent = personsBindingSource.Position;
                personsTableAdapter.Fill(mydbDataSet.persons); //Fill 再讀一次
                personsBindingSource.Position = idxCurrent;
                顯示第幾筆共幾筆資料();
                MessageBox.Show("資料回復成功");
            }
            else
            {
                //No
            }
        }

        private void btn新增資料_新增_Click(object sender, EventArgs e)
        {
            personsBindingSource.AddNew();
            dtp生日.Value = new DateTime(1900,1,1,0,0,0);
            chk婚姻狀態.Checked=false;

        }

        private void btn新增資料_儲存_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("你確認要新增?","新增確認",MessageBoxButtons.YesNo);

            if (R == DialogResult.Yes)
            {
                //yes儲存
                //未來工作時要做欄位檢查
                Validate();
                personsBindingSource.EndEdit();
                personsTableAdapter.Update(mydbDataSet.persons);
                顯示第幾筆共幾筆資料();
                MessageBox.Show("資料新增成功");
            }
            else
            {
                //no

            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (textFind.Text != "")
            {
                string strSearch = textFind.Text;
                string str欄位名稱 = cboxFind.SelectedItem.ToString();
                int idxFind = personsBindingSource.Find(str欄位名稱,strSearch);

                if (idxFind >= 0)
                {
                    personsBindingSource.Position = idxFind;
              
                }
                else
                {
                    //找不到 -1
                    MessageBox.Show("找不到資料");
                }
            }
            else
            {
                MessageBox.Show("請輸入Find搜尋關鍵字");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (textFilter.Text != "")
            {
                string strFilter = textFilter.Text;
                string str欄位名稱 = cboxFilter.SelectedItem.ToString();
                personsBindingSource.Filter = str欄位名稱 + " like " + "'%" + strFilter + "%'";
             
            }
            else
            {
                MessageBox.Show("請輸入Filter搜尋關鍵字");

            }
        }

        private void btn移除Filter條件_Click(object sender, EventArgs e)
        {
            personsBindingSource.RemoveFilter();
            textFilter.Clear();
            MessageBox.Show("Filter條件已以移除");
        }
    }
}
