using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoBingo
{
    public partial class Form2 : Form
    {
        List<int> LotteryRandNumberList = new List<int>();
        List<int> inputnumberList = new List<int>();
        bool checksSort = false;
        bool btnbigsmall = false;
        bool btneasy = false;
        bool btnoddeven = false;
        bool superstate = false;
        bool autostate = false;
        string bigsmallvalue = "";
        string oddevenvalue = "";
        int super = 0;
        int star = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //實作一個公開方法，使其他Form可以傳遞資料進來
        public void AnyState(bool btnEasy, bool btnBigSmall, bool btnOddEven, bool superState, int Star,string bigSmallValue,string oddevenValue,bool AutoState, List<int> InputNumberList) 
        {
            btneasy = btnEasy;
            btnbigsmall= btnBigSmall;
            btnoddeven = btnOddEven;
            superstate = superState;
            star = Star;
            bigsmallvalue = bigSmallValue;
            oddevenvalue = oddevenValue;
            autostate = AutoState;
            inputnumberList = InputNumberList;
        }

        bool IsToForm1 = false; //紀錄是否要回到Form1

        private void btnAgain_Click(object sender, EventArgs e)
        {
            IsToForm1 = true;
            Form1 form1 = (Form1)this.Owner;
            form1.AllClear();
            
            this.Close(); //強制關閉Form2
        }
      
        protected override void OnClosing(CancelEventArgs e) //在視窗關閉時觸發
        {
            base.OnClosing(e);
            if (IsToForm1) //判斷是否要回到Form1
            {
                this.DialogResult = DialogResult.Yes; //利用DialogResult傳遞訊息
                Form1 form1 = (Form1)this.Owner; //取得父視窗的參考
                /*form1.SetTextBox(textBox2.Text);*/ //將Form2中textBox的資料透過公開方法傳遞給Form1
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }
        public void Rand()
        {
            System.Random myRnd = new Random();
            //電腦自動選號
            int autonumber = 0;
            if (autostate && inputnumberList.Count != star)
            {
               autonumber = star - inputnumberList.Count;
            }
            for(int k=0 ; k < autonumber; k++)
            {
                int AutoNumber = myRnd.Next(1, 80);

                if (inputnumberList.Count >= 1)
                {
                    //檢查有沒有重複 有就再隨機一次
                    while (true)
                    {
                        for (int jj = 0; jj < inputnumberList.Count; jj++)
                        {
                            if (inputnumberList[jj] == AutoNumber)
                            {
                                AutoNumber = myRnd.Next(1, 80);
                                jj = 0;
                            }
                        }
                        break;
                    }
                }
                inputnumberList.Add(AutoNumber);
            }

            //產生20個樂透亂數
            for (int i = 0; i < 20; i++)
            {   //產生範圍1~80
                int RandNumber = myRnd.Next(1, 80);
                //兩個數再開始檢查有沒有重複
                if (LotteryRandNumberList.Count >= 1)
                {
                    //檢查有沒有重複 有就再隨機一次
                    while (true)
                    {
                        for (int j = 0; j < LotteryRandNumberList.Count; j++)
                        {
                            if (LotteryRandNumberList[j] == RandNumber)
                            {
                                RandNumber = myRnd.Next(1, 80);
                                j = 0;
                            }
                        }
                        break;
                    }
                }

                LotteryRandNumberList.Add(RandNumber);
            }
          

        }
        public void IsBig()
        {
            int bigTemp = 0;
            int smallTemp = 0;

            for (int i = 0; i < LotteryRandNumberList.Count; i++)
            {
                if (LotteryRandNumberList[i] > 40)
                {
                    bigTemp++;
                }
                else
                {
                    smallTemp++;
                }

            }
            if (bigTemp >= 13)
            {
                labBigSmallBall.Text = "大";
            }
            else if (smallTemp >= 13)
            {
                labBigSmallBall.Text = "小";
            }
            else
            {
                labBigSmallBall.Text = "-";
            }
        }

        public void IsOdd()
        {
            int oddTemp = 0;
            int evenTemp = 0;

            for (int i = 0; i < LotteryRandNumberList.Count; i++)
            {
                if ((LotteryRandNumberList[i] % 2) != 0)
                {
                    oddTemp++;
                }
                else
                {
                    evenTemp++;
                }
            }

            if (oddTemp >= 13)
            {
                labOddorEvenorDeuceBall.Text = "單";
            }
            else if (oddTemp == 11 || oddTemp == 12)
            {
                labOddorEvenorDeuceBall.Text = "小單";
            }
            else if (evenTemp >= 13)
            {
                labOddorEvenorDeuceBall.Text = "雙";
            }
            else if (evenTemp == 11 || evenTemp == 12)
            {
                labOddorEvenorDeuceBall.Text = "小雙";
            }
            else if (oddTemp == 10 && evenTemp == 10)
            {
                labOddorEvenorDeuceBall.Text = "和";
            }


        }


        public void CheckSort()
        {
            LotteryRandNumberList.Sort();
            for (int i = 0; i < LotteryRandNumberList.Count - 1; i++)
            {
                if (LotteryRandNumberList[i] == LotteryRandNumberList[i + 1])
                {
                    checksSort = true;
                }

            }
        }


        public void StarLottery()
        {

            Rand();
            IsBig();
            IsOdd();
            super = LotteryRandNumberList[19];
            CheckSort(); //檢查排序是否有重複數字 (不知道為甚麼有時候排序會重複數字)

            if (checksSort != true)
            {

                for (int i = 0; i < LotteryRandNumberList.Count; i++)
                {                   
                    Label ball = (Label)groupBox1.Controls["labBall" + (i + 1)];
                    ball.Text = LotteryRandNumberList[i].ToString();
                    ball.Image = BingoBingo.Properties.Resources.yellow;
                    if (ball.Text == super.ToString())
                    {
                        ball.Image = BingoBingo.Properties.Resources.red;
                    } 
                }
                    labSuperBall.Text = super.ToString();
            }else
            {                
                LotteryRandNumberList.Clear();
                checksSort = false;
                StarLottery();
            }
            Msg();
        }
        public void Msg()
        {
            msg.Visible = true;
            msg2.Visible = true;
            msgAll.Visible = true;

            if (btneasy) {
                if (superstate)
                {
                    msg2.Text = string.Format("星號: {0}\n超級獎號: √\n號碼: ", star);

                    if (btnbigsmall && btnoddeven)
                     {
                         msg2.Text = string.Format("星號: {0}\n超級獎號: √\n猜大小: {1}\n猜單雙: {2}\n號碼: ", star, bigsmallvalue, oddevenvalue);

                     } else if (btnbigsmall)
                     {
                         msg2.Text = string.Format("星號: {0}\n超級獎號: √\n猜大小: {1}\n號碼: ", star, bigsmallvalue);
                     }
                     else if (btnoddeven)
                     {
                         msg2.Text = string.Format("星號: {0}\n超級獎號: √\n猜單雙: {1}\n號碼: ", star, oddevenvalue);
                     }
                }
                else
                {
                    msg2.Text = string.Format("星號: {0}\n 號碼: ", star);
                    if (btnbigsmall && btnoddeven)
                    {
                        msg2.Text = string.Format("星號: {0}\n猜大小: {1}\n猜單雙: {2}\n號碼: ", star, bigsmallvalue, oddevenvalue);

                    }
                    else if (btnbigsmall)
                    {
                        msg2.Text = string.Format("星號: {0}\n猜大小: {1}\n號碼: ", star, bigsmallvalue);
                    }
                    else if (btnoddeven)
                    {
                        msg2.Text = string.Format("星號: {0}\n猜單雙: {1}\n號碼: ", star, oddevenvalue);
                    }
                }
            }
            else { 

            if (btnbigsmall && btnoddeven)
                {
                    msg2.Text = string.Format("猜大小: {0}\n猜單雙: {1} ",  bigsmallvalue, oddevenvalue);

                }
                else if (btnbigsmall)
                {
                    msg2.Text = string.Format("猜大小: {0} ", bigsmallvalue);
                }
                else if (btnoddeven)
                {
                    msg2.Text = string.Format("猜單雙: {0} ", oddevenvalue);

                }
            }

        }

        public void Redeem(List<int> InputNumberList)
        {
            int numbertemp = 0;
            List<int> total = new List<int>();
            bool checksuper = false;
            bool checkbigsmall = false;
            bool checkoddeven = false;
            Msg();
            

                if (bigsmallvalue == labBigSmallBall.Text)
                {
                       checkbigsmall = true;
                }
                if (oddevenvalue == labOddorEvenorDeuceBall.Text)
                {
                    checkoddeven = true;
                }

                for (int i = 0; i < InputNumberList.Count; i++)
                {
               
                if (InputNumberList[i] == super)
                {
                    checksuper = true;
                }
                for (int j = 0; j < LotteryRandNumberList.Count; j++)
                {

                    if (InputNumberList[i] == LotteryRandNumberList[j])
                    {

                        total.Add(InputNumberList[i]);
                        numbertemp += 1;
                    }

                }
            }
            InputNumberList.Sort();
           
            for (int i = 0; i < InputNumberList.Count; i++)
            {
                msg2.Text += InputNumberList[i] + " ";

                if (i == 4)
                {
                    msg2.Text += "\n";
                }
            }
        

            if (btneasy)
            {
                if (numbertemp > 0)
                {
                    if (checksuper)
                    {
                        msgAll.Text = String.Format("恭喜你中獎了,中了{0}個號碼\n中了超級獎號~~\n中獎號碼: ", numbertemp);

                        if (checkbigsmall && checkoddeven)
                        {
                            msgAll.Text = String.Format("恭喜你中獎了,中了{0}個號碼\n中了超級獎號,猜大小的: {1},猜單雙的: {2}\n中獎號碼: ", numbertemp, bigsmallvalue, oddevenvalue);

                        }
                        else if (checkbigsmall)
                        {
                            msgAll.Text = String.Format("恭喜你中獎了,中了{0}個號碼\n中了超級獎號,猜大小的: {1}\n中獎號碼: ", numbertemp, bigsmallvalue);

                        }
                        else if (checkoddeven)
                        {
                            msgAll.Text = String.Format("恭喜你中獎了,中了{0}個號碼\n中了超級獎號,猜單雙的: {1}\n中獎號碼: ", numbertemp, oddevenvalue);

                        }
                    }
                    else
                    {
                        msgAll.Text = String.Format("恭喜你中獎了,中了{0}個號碼\n中獎號碼: ", numbertemp);
                        if (checkbigsmall && checkoddeven)
                        {
                            msgAll.Text = String.Format("恭喜你中獎了,中了{0}個號碼\n猜大小的: {1},猜單雙的: {2}\n中獎號碼: ", numbertemp, bigsmallvalue, oddevenvalue);

                        }
                        else if (checkbigsmall)
                        {
                            msgAll.Text = String.Format("恭喜你中獎了,中了{0}個號碼\n猜大小的: {1}\n中獎號碼: ", numbertemp, bigsmallvalue);

                        }
                        else if (checkoddeven)
                        {
                            msgAll.Text = String.Format("恭喜你中獎了,中了{0}個號碼\n猜單雙的: {1}\n中獎號碼: ", numbertemp, oddevenvalue);

                        }
                    }
                }
                else
                {
                    msgAll.Text = "哎呀!1個都沒中~";
                }
            }
            else
            {

                if (checkbigsmall && checkoddeven)
                {
                    msgAll.Text = string.Format("恭喜你中獎了,中了猜大小的: {0},猜單雙的: {1}", bigsmallvalue, oddevenvalue);

                }
                else if (checkbigsmall)
                {
                    msgAll.Text = string.Format("恭喜你中獎了,中了猜大小的: {0}", bigsmallvalue);
                }
                else if (checkoddeven)
                {
                    msgAll.Text = string.Format("恭喜你中獎了,中了猜單雙的: {0}",  oddevenvalue);
                }
                else
                {
                    msgAll.Text = "哎呀!1個都沒中~";
                }
            }

            total.Sort();

            for (int i = 0; i < total.Count; i++)
            {
                msgAll.Text += total[i] + " ";

                if (i == 9)
                {
                    msgAll.Text += "\n";
                }
            }


        }
    }


}
