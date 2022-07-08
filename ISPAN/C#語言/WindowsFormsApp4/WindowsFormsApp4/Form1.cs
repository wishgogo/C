using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cbv測試_Click(object sender, EventArgs e)
        {
            int x = 5;
            lab_cbv1.Text = "變數在傳遞前的值" + x.ToString();
            callByValue(x);
            lab_cbv3.Text = "變數在傳遞後的值" + x.ToString();
        }

        void  callByValue(int y)
        {
            y += 1;
            lab_cbv2.Text = "參數在方法裡面的值:" + y.ToString();
        }

        private void Btn_cbr測試_Click(object sender, EventArgs e)
        {
            int x = 5;
            lab_cbr1.Text = "變數在傳遞前的值" + x.ToString();
            callByReference(ref x);
            lab_cbr3.Text = "變數在傳遞後的值" + x.ToString();
        }

        void callByReference(ref int y)
        {
            // ref記憶體位址相同 x就是y 
            y += 1;
            lab_cbr2.Text = "參數在方法裡面的值:" + y.ToString();
        }
    }
}
