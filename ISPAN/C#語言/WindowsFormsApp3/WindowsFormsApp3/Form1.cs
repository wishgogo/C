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
        //public Form1(string c)
        //{
        //    InitializeComponent();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            顯示歡迎訊息();
        }
        
        static void 顯示歡迎訊息()
        {
            MessageBox.Show("歡迎使用本程式");
        }

        private void btn_無參數的方法_Click(object sender, EventArgs e)
        {
            int mySum = 計算1到5的總和();
            MessageBox.Show("1到5的總和:" + mySum);
        }

        int 計算1到5的總和()
        {
            int sum = 0;
            sum = 1 + 2 + 3 + 4 + 5;
            return sum;
        }

        private void btn_有參數的方法_Click(object sender, EventArgs e)
        {
            有參數的方法("David", "Apple Watch", 12800.0, 5);
        }

        void 有參數的方法(string name, string product, double price, int amount)
        {
            string output = string.Format($"{name} 購買{product} -共{amount} 件 總價{price}元");
            MessageBox.Show(output);
        }

        private void btn_回傳值的方法_Click(object sender, EventArgs e)
        {
            int mySum = 總和(5, 4, 3, 2, 1);
            MessageBox.Show("總和:" + mySum);
        }

        int 總和(int a, int b, int c, int d, int e)
        {
            int sum = a + b + b + d + e;
            return sum;
        }

        //自訂方法


    }
}
