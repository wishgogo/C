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
    public partial class Form2 : Form
    {
        bool is計算稅金 = false;
        int 折扣活動代碼 = 0;
        int 總價 = 0;
        string str單品資訊 = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl訂購人.Text = GlobalVar.訂購人資訊;

            for (int i = 0; i < GlobalVar.list訂購品項列表.Count; i += 1)
            {
                Order myOrder = GlobalVar.list訂購品項列表[i];
                 str單品資訊 = string.Format("{0}, 單價:{1},{2}{3},加料:{4}, 加料價格:{5},杯數:{6},總價:{7}", myOrder.訂購品項, myOrder.單價, myOrder.甜度, myOrder.冰塊, myOrder.加料, myOrder.加料價格, myOrder.品項杯數,myOrder.品項總價);
               
                lbox訂購品項列表.Items.Add(str單品資訊);
            }
            計算訂單總價();

        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            if (lbox訂購品項列表.SelectedIndex >= 0)
            {
                int selIndex = lbox訂購品項列表.SelectedIndex;
                lbox訂購品項列表.Items.RemoveAt(selIndex);
                GlobalVar.list訂購品項列表.RemoveAt(selIndex);
                計算訂單總價();
            }
            else
            {
                MessageBox.Show("請選擇品項");
            }
        }

        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            lbox訂購品項列表.Items.Clear();
            GlobalVar.list訂購品項列表.Clear();
            計算訂單總價();
        }

        //作業規格:計算訂單總價
        void 計算訂單總價()
        {
            int small = 0;
            int cups = 0;
            int even = 0; //雙
            int odd = 0;    //單
            int evencup = 0; 
            int oddcup = 0;
            int temp = 1;
            bool flag = false;
            bool flag2 = false;

            總價 = 0;            
            for (int i = 0; i < GlobalVar.list訂購品項列表.Count; i += 1)
            {
                Order myOrder = GlobalVar.list訂購品項列表[i];              
                總價 += (myOrder.單價 + myOrder.加料價格) * myOrder.品項杯數;
                cups += myOrder.品項杯數;
                if (small == 0)
                {
                    small = myOrder.單價 + myOrder.加料價格;
                }
                if (small >= myOrder.單價 + myOrder.加料價格)
                {
                    small = myOrder.單價 + myOrder.加料價格;
                }
            }
            if (折扣活動代碼 == 101)
            {
                總價 -= small * (cups / 3);
            }
            else if (折扣活動代碼 == 102)
            {
                總價 -= small * (cups / 4);
            }
            else if (折扣活動代碼 == 103)
            {
                 總價 = 0;
                for (int i = 0; i < GlobalVar.list訂購品項列表.Count; i += 1)
                {
                    Order myOrder = GlobalVar.list訂購品項列表[i];
                    //雙
                    if (i % 2 == 0)
                    {
                        even = myOrder.單價 + myOrder.加料價格;
                        evencup = myOrder.品項杯數;
                        for(int ecup = 1; ecup <= evencup; ecup++)
                        {
                            if (temp % 2 == 0)//第二杯
                            {
                                temp = 1;
                                if (flag2)
                                {
                                    if (even >= odd)
                                    {
                                        總價 -= odd;
                                        總價 += even;
                                        總價 += Convert.ToInt32(odd * 0.5);
                                    }
                                    else
                                    {
                                      
                                        總價 += Convert.ToInt32(even * 0.5);
                                    }
                                    flag2 = false;
                                }
                                else { 
                                總價 += Convert.ToInt32(even * 0.5);
                                
                                }
                            }
                            else
                            {
                                總價 += even;
                                temp++;
                                flag = true;
                            }
                        }
                    }
                    else
                    {
                        odd = myOrder.單價 + myOrder.加料價格;
                        oddcup = myOrder.品項杯數;
                        for(int ocup = 1; ocup <= oddcup; ocup++)
                        {
                           
                            if (temp % 2 == 0)
                            {   
                                temp = 1;
                                if (flag) { 
                                if (even >= odd)
                                {
                                    
                                    總價 += Convert.ToInt32(odd * 0.5);
                                }
                                else
                                {
                                    總價 -= even;
                                    總價 += odd;
                                    總價 += Convert.ToInt32(even * 0.5);
                                }
                                }else
                                {
                                    總價 += Convert.ToInt32(odd * 0.5);
                                }
                                flag = false;
                            }
                            else
                            {
                                總價 += odd;
                                temp++;
                                flag2 = true;
                            }
                        }
                    }
                }




            }
            

            if (is計算稅金 == false) //加分題:計算稅金
            {
                lbl訂購總價.Text = 總價.ToString();
            }
            else
            {
                總價 += Convert.ToInt32(總價 * 0.05);
                lbl訂購總價.Text = 總價.ToString();
            }

        }

        private void chktax_CheckedChanged(object sender, EventArgs e)
        {
            if (chktax.Checked == true)
            {
                is計算稅金 = true;
            }
            else
            {
                is計算稅金 = false;
            }
            計算訂單總價();
        }
        //加分題 贈品以低價為準
        private void radioDiscount1_CheckedChanged(object sender, EventArgs e)
        {
            //加分題買二送一
            折扣活動代碼 = 101;
            計算訂單總價();
        }

        private void radioDiscount2_CheckedChanged(object sender, EventArgs e)
        {
            //加分題買三送一
            折扣活動代碼 = 102;
            計算訂單總價();
        }

        private void radioDiscount3_CheckedChanged(object sender, EventArgs e)
        {
            //加分題第二件半價
            折扣活動代碼 = 103;
            計算訂單總價();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {          
            this.Close();
        }      

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVar.form菜單.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string str檔案路徑 = @"C:\Users\iii\Desktop\C#\C#語言\dotNet元件開發\飲料訂購單";
            System.Random myRnd = new Random();
            int myNum = myRnd.Next(1000, 9999);
            string str檔名 = DateTime.Now.ToString("yyMMddHHmmss") + myNum + @"訂購檔.txt";
            string str完整檔案路徑 = str檔案路徑 + @"\" + str檔名;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str檔案路徑;
            sfd.FileName = str檔名;
            sfd.Filter = "Text File|*.txt";

            DialogResult R = sfd.ShowDialog(); //ShowDialog 獨佔模式 (ex:form2開啟form1不能選擇)

            if (R == DialogResult.OK)
            {
                str完整檔案路徑 = sfd.FileName;
            }
            else
            {
                return;
            }

            //訂單內容存檔
            List<string> list訂單資訊 = new List<string>();
            list訂單資訊.Add("***********冷飲店訂購單************");
            list訂單資訊.Add("----------------------------------");
            list訂單資訊.Add("訂購時間:" + DateTime.Now.ToString() + "訂購人:" + GlobalVar.訂購人資訊);
            list訂單資訊.Add("----------------------------------");
            list訂單資訊.Add("<<<<訂購品項>>>>");
            for (int i = 0; i < GlobalVar.list訂購品項列表.Count; i += 1)
            {
                Order myOrder = GlobalVar.list訂購品項列表[i];
                str單品資訊 = string.Format("{0}, 單價:{1},{2}{3},加料:{4}, 加料價格:{5},杯數:{6},總價:{7}", myOrder.訂購品項, myOrder.單價, myOrder.甜度, myOrder.冰塊, myOrder.加料, myOrder.加料價格, myOrder.品項杯數, myOrder.品項總價);

                lbox訂購品項列表.Items.Add(str單品資訊);
            }

            list訂單資訊.Add("----------------------------------");
            list訂單資訊.Add("折扣" + "買二送一" + "稅金:" + "35" + "元");
            list訂單資訊.Add("總價" + 總價);
            list訂單資訊.Add("----------------------------------");
            list訂單資訊.Add("************謝謝光臨*************");

            System.IO.File.WriteAllLines(str完整檔案路徑, list訂單資訊, Encoding.UTF8);
            MessageBox.Show("存檔成功");

        }
    }
}