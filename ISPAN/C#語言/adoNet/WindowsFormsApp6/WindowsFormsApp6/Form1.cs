using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        List<Button> myDbuttonList = new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myUserControlOne1.lbl標籤標題.Text = "使用者控制像標題";
            myUserControlOne1.txt輸入文字.Text = "請輸入文字";
            myUserControlOne1.btn更改標題.Text = "Modify Title";

            動態產生按鈕(8,4);
            Random myRnd = new Random();
            int intRand = myRnd.Next(1, 32);
            myDbuttonList[intRand].BackColor = Color.Red;
            自訂MyLabelButton();

        }

        void 動態產生按鈕(int intRow, int intColumn)
        {
            int serialNo = 0;


            for (int i=0;i< intRow; i++)
            {
                for (int j=0;j< intColumn; j+=1) {
                serialNo += 1;
                Button dButton = new Button();
                dButton.BackColor = Color.Pink;
                dButton.ForeColor = Color.FromArgb(104,37,144);
                dButton.Font = new Font("微軟正黑體",12);
                dButton.Name = "btnDbutton" + serialNo;
                dButton.TextAlign = ContentAlignment.MiddleCenter;
                dButton.Size = new Size(120, 45); //寬,高
                dButton.Location = new Point(20 + 125 * j , 180 + 45 * i); // X,y Y大於高度才不會重疊
                dButton.Text = "動態按鈕" + serialNo;
                dButton.Click += new EventHandler(btn動態按鈕_Click);
                //+=事件指定關聯運算子
                //-=事件解除關聯運算子
                Controls.Add(dButton);
                myDbuttonList.Add(dButton);
                }
            }
        }
        private void btn動態按鈕_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;

            if (myButton.BackColor==Color.Red)
            {
                myButton.BackColor = Color.Pink;
            }
            else
            {
                myButton.BackColor = Color.Red;
            }
            MessageBox.Show("按下按鈕"+myButton.Text);
        }

        void 自訂MyLabelButton()
        {
            MyLabelButton lblBtnOne = new MyLabelButton();
            lblBtnOne.BackColor = Color.LightYellow;
            lblBtnOne.ForeColor = Color.Blue;
            lblBtnOne.Font = new Font("微軟正黑體", 16);
            lblBtnOne.Name = "lblBtnOne";
            lblBtnOne.Text = "自訂標籤文字";
            lblBtnOne.TextAlign = ContentAlignment.MiddleLeft;
            lblBtnOne.Location = new Point(520, 150);
            lblBtnOne.Size = new Size(260, 100);
            lblBtnOne.myDButton.Click += new EventHandler(lblButton_Click);

            Controls.Add(lblBtnOne);
        }

        private void lblButton_Click(object sender, EventArgs e)
        { 
            Button myButton=(Button)sender;
            MessageBox.Show("按下"+myButton.Name);
        }
    }
}

//使用其他類別的物件把ModiFiers 改成 public

//ListView 固定、 FlowLayoutPanel類似ListView 但可自定控制項
