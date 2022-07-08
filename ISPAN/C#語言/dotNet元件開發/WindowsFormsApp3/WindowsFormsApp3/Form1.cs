using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        //作業規格:至少要有12冷飲品項
        List<string> list品項名稱 = new List<string>();//key
        List<int> list品項價格 = new List<int>();//value
        List<string> list甜度 = new List<string>();
        List<string> list冰塊 = new List<string>();
        string[,] list加料價格 = new string[,] {{ "無", "0" },{ "仙草凍", "5" },{ "珍珠", "10" }, { "波霸", "10"  }, { "椰果", "10"  },{ "粉粿", "10"   },{ "奶蓋", "15"  },{ "布丁", "15"  }};
        //作業規格:加料價格
        int 品項杯數 = 0;
        int 單價=0;
        int 品項總價=0;
        string 訂購品項="";
        string 甜度="";
        string 冰塊="";
        string 加料 = "";

        int 加料價格 = 0;

        public Form1()
        {
            InitializeComponent();
        }
     

        private void Form1_Load(object sender, EventArgs e)
        {
            //key
            list品項名稱.Add("阿薩姆紅茶");
            list品項名稱.Add("錫蘭紅茶");
            list品項名稱.Add("伯爵紅茶");
            list品項名稱.Add("茉莉綠茶");
            list品項名稱.Add("四季春茶");
            list品項名稱.Add("阿里山冰茶");
            list品項名稱.Add("珍珠紅茶拿鐵");
            list品項名稱.Add("波霸紅茶拿鐵");
            list品項名稱.Add("阿薩姆鮮奶茶");
            list品項名稱.Add("錫蘭鮮奶茶");
            list品項名稱.Add("伯爵鮮奶茶");
            list品項名稱.Add("鐵觀音拿鐵");
           
            //value
            list品項價格.Add(30);
            list品項價格.Add(30);
            list品項價格.Add(30);
            list品項價格.Add(30);
            list品項價格.Add(30);
            list品項價格.Add(30);
            list品項價格.Add(55);
            list品項價格.Add(55);
            list品項價格.Add(55);
            list品項價格.Add(50);
            list品項價格.Add(50);
            list品項價格.Add(50);

            foreach (string itemName in list品項名稱)
            {
                lbox冷飲品項.Items.Add(itemName);
            }

            //lbox冷飲品項.SelectedIndex = 0; //SelectedIndex 預選
            txt品項杯數.Text = 品項杯數.ToString();
            品項杯數 = 1;

            //甜度
            list甜度.Add("正常");
            list甜度.Add("半糖");
            list甜度.Add("少糖");
            list甜度.Add("微糖");
            list甜度.Add("無糖");
            foreach(string itemName in list甜度)
            {
                cbox甜度.Items.Add(itemName);
            }
            cbox甜度.SelectedIndex = 0;

            //冰塊
            list冰塊.Add("正常");
            list冰塊.Add("少冰");
            list冰塊.Add("微冰");
            list冰塊.Add("去冰");
            foreach (string itemName in list冰塊)
            {
                cbox冰塊.Items.Add(itemName);
            }
            cbox冰塊.SelectedIndex = 0;

            //加料,有價格
            string Msg = "";
            for (int idx = 0; idx <= list加料價格.GetUpperBound(0); idx++)
            {
                for (int jdx = 0; jdx < list加料價格.GetUpperBound(1); jdx++)
                {
                    Msg = string.Format("{0},價錢{1}\n", list加料價格[idx, jdx], list加料價格[idx, jdx + 1]);
                    cbox配料.Items.Add(Msg);
                }
            }
            cbox配料.SelectedIndex = 0;

        }

        private void lbox冷飲品項_SelectedIndexChanged(object sender, EventArgs e)
        {
            加料 = "";
            加料價格 = 0;
            cbox配料.SelectedIndex = 0;
            lbox配料.Items.Clear();
            int selIndex = lbox冷飲品項.SelectedIndex;
            訂購品項 = list品項名稱[selIndex];
            單價 = list品項價格[selIndex];
            lbl單價.Text = 單價.ToString() + "元";
            品項總價 = 品項杯數 * (單價 + 加料價格);
            lbl品項總價.Text = 品項總價.ToString() + "元";
            txt品項杯數.Text = 品項杯數.ToString();
        }

        private void cbox甜度_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cbox甜度.SelectedIndex;
            甜度 = list甜度[selIndex];

        }

        private void cbox冰塊_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = cbox冰塊.SelectedIndex;
            冰塊 = list冰塊[selIndex];
        }

        //加分題 配料可以複選
        private void cbox配料_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int selIndex = cbox配料.SelectedIndex;

            if (selIndex != 0)
            {
                string lbox配料txt = list加料價格[selIndex, 0];
                加料 += list加料價格[selIndex, 0];
                加料價格 += Convert.ToInt32(list加料價格[selIndex, 1]);
                lbox配料.Items.Add(lbox配料txt);
            }
           
            品項總價 = 品項杯數 * (單價 + 加料價格);
            lbl品項總價.Text = 品項總價.ToString() + "元";

           
        }
            

        

        private void btn加入訂購單_Click(object sender, EventArgs e)
        {
            //ArrayList 品項訂購資訊 = new ArrayList(); //作業請用自訂類別
            Order o = new Order();
            o.訂購品項 = 訂購品項;
            o.單價 = 單價;
            o.品項杯數 = 品項杯數;
            o.品項總價 = 品項總價;
            o.甜度 = 甜度;
            o.冰塊 = 冰塊;
            o.加料 = 加料.ToString();
            o.加料價格 = 加料價格;

            if (o.訂購品項 == "")
            {
                MessageBox.Show("請先選擇飲料");
            }
            else
            {              
                GlobalVar.list訂購品項列表.Add(o);
                GlobalVar.訂購人資訊 = txt訂購人電話.Text;
                MessageBox.Show("已加入結賬單");
            }

        }

        //作業規格:避免與改正輸入錯誤
        private void txt品項杯數_KeyPress(object sender, KeyPressEventArgs e)
        {
            try { 
            if (e.KeyChar != (char)13)
            {
                return;
            }
            else
            {
                品項杯數 = Convert.ToInt32(txt品項杯數.Text);
                品項總價 = 品項杯數 * (單價 + 加料價格);
                lbl品項總價.Text = 品項總價.ToString() + "元";
            }
            }
            catch
            {
                MessageBox.Show("請輸入數字");
                txt品項杯數.Clear();
            }
        }

        private void btn查看訂購單_Click(object sender, EventArgs e)
        {
            GlobalVar.form菜單 = this;
            Form2 form結賬單 = new Form2();
            GlobalVar.form結賬單 = form結賬單;
            form結賬單.Show();
            this.Hide();
            GlobalVar.訂購人資訊 = txt訂購人電話.Text;
        }

  
    }
}
