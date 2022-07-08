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
    public partial class Form1 : Form
    {
        List<int> InputNumberList = new List<int>();
        bool btnbigsmall = false;
        bool btneasy = false;
        bool btnoddeven = false;
        bool superstate = false;
        bool autostate = false;

        string bigsmallvalue = "";
        string oddevenvalue = "";
        int star = 0;
        bool starstate = false;
        bool easystate = false;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnLottery_Click(object sender, EventArgs e)
        {
           /* this.Hide();*/ //隱藏父視窗

            Form2 form2 = new Form2(); //創建子視窗

            //將Form1中textBox的資料透過公開方法傳遞給Form2
            if (btneasy) {
                superstate = InputSuper.Checked;               
                star = Convert.ToInt32(InputStar.Text);
            }
            form2.AnyState(btneasy, btnbigsmall, btnoddeven, superstate, star, bigsmallvalue, oddevenvalue,autostate,InputNumberList);
            form2.StarLottery();

         
            if (btneasy|| btnbigsmall|| btnoddeven)
            {
                form2.Redeem(InputNumberList);
            }
            switch (form2.ShowDialog(this))
            {
                case DialogResult.Yes: //Form2中按下btnAgain按鈕
                    this.Show(); //顯示父視窗     
                    break;
                case DialogResult.No: //Form2中按下關閉鈕
                    this.Close();  //關閉父視窗 (同時結束應用程式)
                    break;
                default:
                    break;
            }
        }
       

        private void btnClear_Click(object sender, EventArgs e)
        {
            AllClear();
            btnClear.Enabled = false;
        }    

        private void StarInput(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != (char)13)
                {
                    return;
                }
                else
                {
                     star = Convert.ToInt32(InputStar.Text);

                    if (star <= 10 && star > 0)
                    {
                        msgStar.Text = "你選擇的星級數: " + InputStar.Text;
                        starstate = true;
                        InputNumber.Text = "";
                        InputNumberList.Clear();
                        
                        msg.Text = "";
                        if (autostate)
                        {
                            btnLottery.Enabled = true;
                        }
                    }
                    else
                    {
                        msgStar.Text = "";
                        MessageBox.Show("請輸入1~10");
                        InputStar.Text = "";
                        starstate = false;
                        btnLottery.Enabled = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("請輸入數字");
                msgStar.Text = "";
                starstate = false;
                btnLottery.Enabled = false;
            }
            msgStar.Visible = true;
            InputNumber.Visible = true;
            labNumber.Visible = true;
            InputSuper.Visible = true;
            InputAuto.Visible = true;
        }
      

        private void NumberInput(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (e.KeyChar != (char)13)
                {
                    return;
                }
                else
                {
                    bool istrue = false;
                    if (Convert.ToInt32(InputNumber.Text) > 0 && Convert.ToInt32(InputNumber.Text) <= 80)
                    {
                        if (Convert.ToInt32(InputStar.Text) > InputNumberList.Count)
                        {
                            //檢查有沒有重複
                            while (true)
                            {
                                for (int i = 0; i < InputNumberList.Count; i++)
                                {

                                    if (Convert.ToInt32(InputNumber.Text) == InputNumberList[i])
                                    {
                                        MessageBox.Show("輸入的號碼重複了");
                                        istrue = true;
                                    }

                                }
                                break;
                            }
                            if (istrue == false)
                            {
                                InputNumberList.Add(Convert.ToInt32(InputNumber.Text));
                            }

                        }
                        else
                        {
                            MessageBox.Show("輸入數字超過星級數範圍");
                        }
                    }
                    else
                    {
                        MessageBox.Show("請輸入1~80");

                    }
                    msg.Text = "";
                    InputNumber.Text = "";
                    msg.Text = "你選擇的號碼: ";
                    foreach (int myNumber in InputNumberList)
                    {
                        msg.Text += myNumber + " ";
                    }
                }
            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }

                

            if (autostate && InputNumberList.Count!=star)
            {
                btnLottery.Enabled = true;
            }
            else
            {
                if (InputNumberList.Count == star)
                 {
                    btnLottery.Enabled = true;
                    InputAuto.Enabled = false;
                    InputAuto.Checked = false;
                }
                else
                 {
                     btnLottery.Enabled = false;

                 }
            }
            msg.Visible = true;
            easystate = true;

        }


        private void btnEasy_Click(object sender, EventArgs e)
        {
            if (btneasy != true) { 
            btnLottery.Enabled = false;
            btnLottery.Text = "兌獎";
            btneasy = true;
            btnEasy.BackColor = Color.DarkOrange;
            btnClear.Enabled = true;
            InputStar.Visible = true;            
            labStar.Visible = true;
            InputAuto.Enabled = true;
            easystate = false;
            }
            else
            {
                if (btnbigsmall == false && btnoddeven==false)
                {
                    btnLottery.Text = "開獎";
                    btnLottery.Enabled = true;
                    btnClear.Enabled = false;
                }
                btnEasy.BackColor =Color.SteelBlue;
                btnLottery.Enabled = true;
                InputStar.Visible = false;
                InputStar.Text = "";
                InputNumber.Visible = false;
                star = 0;
                InputNumberList.Clear();
                labNumber.Visible = false;
                labStar.Visible = false;
                InputAuto.Visible = false;
                InputSuper.Visible = false;
                msg.Visible = false;
                msgStar.Visible = false;
                btneasy = false;
                InputSuper.Checked = false;
                InputAuto.Checked = false;
                autostate = false;
                superstate = false;
                starstate = false;
              
            }
        }

  
        private void btnBigSmall_Click(object sender, EventArgs e)
        {
            bigsmallvalue = "";
            if (btnbigsmall!=true) {
                btnBig.Visible = true;
                btnSmall.Visible = true;
                btnbigsmall = true;
                btnLottery.Text = "兌獎";
                btnLottery.Enabled = false;
                btnClear.Enabled = true;
                btnBigSmall.BackColor = Color.DarkOrange;

            }
            else
            {
                if (btneasy == false && btnoddeven==false ) { 
                btnLottery.Text = "開獎";
                btnClear.Enabled = false;
                btnLottery.Enabled = true;
                }
                btnBigSmall.BackColor = Color.SteelBlue;
                btnBig.Visible = false;
                btnSmall.Visible = false;
                btnbigsmall = false;
                btnSmall.BackColor = Color.SteelBlue;
                btnBig.BackColor = Color.SteelBlue;
            }


        }

        private void btnOddEven_Click(object sender, EventArgs e)
        {
            oddevenvalue = "";
            if (btnoddeven != true)
            {
                btnOddEven.BackColor = Color.DarkOrange;
                btnOdd.Visible = true;
                btnEven.Visible = true;
                btnSmallOdd.Visible = true;
                btnSmallEven.Visible = true;
                btnSafe.Visible = true;
                btnoddeven = true;
                btnClear.Enabled = true;
                btnLottery.Text = "兌獎";
                btnLottery.Enabled = false;
                
            }
            else
            {
                if (btneasy == false && btnbigsmall==false)
                {
                    btnLottery.Text = "開獎";
                    btnClear.Enabled = false;
                    btnLottery.Enabled = true;
                }
                btnOddEven.BackColor = Color.SteelBlue;
                btnOdd.Visible = false;
                btnEven.Visible = false;
                btnSmallOdd.Visible = false;
                btnSmallEven.Visible = false;
                btnSafe.Visible = false;
                btnoddeven = false;
                btnOdd.BackColor = Color.SteelBlue;
                btnEven.BackColor = Color.SteelBlue;
                btnSmallOdd.BackColor = Color.SteelBlue;
                btnSmallEven.BackColor = Color.SteelBlue;
                btnSafe.BackColor = Color.SteelBlue;

            }
        }

        public void AllClear()
        {
            InputNumberList.Clear();
            msgStar.Text = "";
            msg.Text = "";
            InputStar.Text = "";
            InputNumber.Text = "";
            bigsmallvalue = "";
            oddevenvalue = "";
            btnLottery.Text = "開獎";
            btnClear.Enabled = false;
            InputAuto.Enabled = true;
            btneasy = false;
            superstate = false;
            autostate = false;
            easystate = false;
            labStar.Visible = false;
            labNumber.Visible = false;
            InputStar.Visible = false;
            InputNumber.Visible = false;
            InputAuto.Visible = false;
            InputSuper.Visible = false;
            msgStar.Visible = false;
            msg.Visible = false;
            btnLottery.Enabled = true;
            InputAuto.Checked = false;
            InputSuper.Checked = false;
            btnBig.Visible = false;
            btnSmall.Visible = false;
            btnbigsmall = false;
            btneasy = false;
            btnoddeven = false;
            btnOdd.Visible = false;
            btnEven.Visible = false;
            btnSmallOdd.Visible = false;
            btnSmallEven.Visible = false;
            btnSafe.Visible = false;
            btnEasy.BackColor = Color.SteelBlue;
            btnBigSmall.BackColor = Color.SteelBlue;
            btnOddEven.BackColor = Color.SteelBlue;
            btnSmall.BackColor = Color.SteelBlue;
            btnBig.BackColor = Color.SteelBlue;
            btnOdd.BackColor = Color.SteelBlue;
            btnEven.BackColor = Color.SteelBlue;
            btnSmallOdd.BackColor = Color.SteelBlue;
            btnSmallEven.BackColor = Color.SteelBlue;
            btnSafe.BackColor = Color.SteelBlue;




        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            
            bigsmallvalue = "大";
            
                btnBig.BackColor = Color.DarkOrange;
                btnSmall.BackColor = Color.SteelBlue;
            
            if((btnoddeven && oddevenvalue == "") || (btneasy && easystate==false))
            {
                btnLottery.Enabled = false;
            }
            else
            {
                btnLottery.Enabled = true;
            }

        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            bigsmallvalue = "小";
            
                btnSmall.BackColor = Color.DarkOrange;
                btnBig.BackColor = Color.SteelBlue;

            if ((btnoddeven && oddevenvalue == "") || (btneasy && easystate == false))
            {
                btnLottery.Enabled = false;
            }
            else
            {
                btnLottery.Enabled = true;
            }


        }     

        private void btnOdd_Click(object sender, EventArgs e)
        {

            oddevenvalue = "單";
            
                btnOdd.BackColor = Color.DarkOrange;
                btnEven.BackColor = Color.SteelBlue;
                btnSmallOdd.BackColor = Color.SteelBlue;
                btnSmallEven.BackColor = Color.SteelBlue;
                btnSafe.BackColor = Color.SteelBlue;
            if ((btnbigsmall && bigsmallvalue == "") || (btneasy && easystate == false))
            {
                btnLottery.Enabled = false;
            }
            else
            {
                btnLottery.Enabled = true;
            }
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            oddevenvalue = "雙";
          
                btnOdd.BackColor = Color.SteelBlue;
                btnEven.BackColor = Color.DarkOrange;
                btnSmallOdd.BackColor = Color.SteelBlue;
                btnSmallEven.BackColor = Color.SteelBlue;
                btnSafe.BackColor = Color.SteelBlue;
            if ((btnbigsmall && bigsmallvalue == "") || (btneasy && easystate == false))
            {
                btnLottery.Enabled = false;
            }
            else
            {
                btnLottery.Enabled = true;
            }

        }

        private void btnSmallOdd_Click(object sender, EventArgs e)
        {

            oddevenvalue = "小單";
          
                btnOdd.BackColor = Color.SteelBlue;
                btnEven.BackColor = Color.SteelBlue;
                btnSmallOdd.BackColor = Color.DarkOrange;
                btnSmallEven.BackColor = Color.SteelBlue;
                btnSafe.BackColor = Color.SteelBlue;
            if ((btnbigsmall && bigsmallvalue == "") || (btneasy && easystate == false))
            {
                btnLottery.Enabled = false;
            }
            else
            {
                btnLottery.Enabled = true;
            }

        }

        private void btnSmallEven_Click(object sender, EventArgs e)
        {
            oddevenvalue = "小雙";
            
                btnOdd.BackColor = Color.SteelBlue;
                btnEven.BackColor = Color.SteelBlue;
                btnSmallOdd.BackColor = Color.SteelBlue;
                btnSmallEven.BackColor = Color.DarkOrange;
                btnSafe.BackColor = Color.SteelBlue;
            if ((btnbigsmall && bigsmallvalue == "") || (btneasy && easystate == false))
            {
                btnLottery.Enabled = false;
            }
            else
            {
                btnLottery.Enabled = true;
            }

        }

        private void btnSafe_Click(object sender, EventArgs e)
        {
            oddevenvalue = "和";
          
                btnOdd.BackColor = Color.SteelBlue;
                btnEven.BackColor = Color.SteelBlue;
                btnSmallOdd.BackColor = Color.SteelBlue;
                btnSmallEven.BackColor = Color.SteelBlue;
                btnSafe.BackColor = Color.DarkOrange;
            if ((btnbigsmall && bigsmallvalue == "") || (btneasy && easystate == false))
            {
                btnLottery.Enabled = false;
            }
            else
            {
                btnLottery.Enabled = true;
            }

        }

        private void InputAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (btneasy)
            { 
               autostate = InputAuto.Checked;
               if (autostate && starstate )
               {
                   btnLottery.Enabled = true;
               }
               else if(!easystate || InputNumberList.Count != star)
               {
                   btnLottery.Enabled = false;

               }
            }
        }
    }
}