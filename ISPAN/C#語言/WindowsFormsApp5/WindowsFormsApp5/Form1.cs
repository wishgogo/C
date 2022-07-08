using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        //類別變數,本類別可視
        string[] arrayStudentName; //學生姓名陣列
        int[] arrayStudentScore;    //學生成績陣列
        string[] arrayTempStudentName; //學生姓名暫存陣列
        int[] arrayTempStudentScore; //學生成績暫存陣列

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //姓名-成績,key-value,鍵值對應
            arrayStudentName = new string[5];
            arrayStudentName[0] = "王小明";
            arrayStudentName[1] = "陳大貓";
            arrayStudentName[2] = "林阿霈";
            arrayStudentName[3] = "張大書";
            arrayStudentName[4] = "黃忠孝";

            arrayStudentScore = new int[5];
            arrayStudentScore[0] = 76;
            arrayStudentScore[1] = 68;
            arrayStudentScore[2] = 54;
            arrayStudentScore[3] = 92;
            arrayStudentScore[4] = 86;

            arrayTempStudentName = new string[5];
            arrayTempStudentScore = new int[5];

            Lbl成績總和結果.Text = totalScore(arrayStudentScore).ToString();
            Lbl成績平均結果.Text = average(arrayStudentScore).ToString();
        }

        private void Btn成績排序_Click(object sender, EventArgs e)
        {
              Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
              Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.Length);

            成績排序(arrayTempStudentName,arrayTempStudentScore);
        }

        void 成績排序(string[] myArrayName, int[] myArrayScore)
        {
            Array.Sort(myArrayScore, myArrayName); //key-value sort 跟著前一個key索引
            //
            //
            string strMsg = "";
            for (int idx = myArrayScore.GetUpperBound(0); idx >= 0; idx -= 1)
            {
                strMsg += String.Format("姓名:{0} 成績:{1}\n", myArrayName[idx], myArrayScore[idx]);
            }
            Lbl資料結果顯示.Text = strMsg;
        }

        int totalScore(int[] myArrayScore)
        {
            int total = 0;
            foreach(int myScore in myArrayScore)
            {
                total += myScore;
            }
            return total;
        }

        double average(int[] myArrayScore)
        {
            double avg = 0.0;

            avg = Convert.ToDouble(totalScore(myArrayScore)) / myArrayScore.Length;

            return avg;
        }

        private void Btn姓名排序_Click(object sender, EventArgs e)
        {
            //copy 複製一個新的避免動到原始資料
            //(原本的arrayStudentName,新的arrayTempStudentName,長度arrayStudentName.Length)
            System.Array.Copy(arrayStudentName,arrayTempStudentName, arrayStudentName.Length);

            姓名排序(arrayTempStudentName);
        }
        void 姓名排序(string[] myArrayName)
        {
            //sort 排序
            System.Array.Sort(myArrayName);
            string strMsg = "";
            for (int idx = 0; idx < myArrayName.Length; idx += 1)
            {
                strMsg += string.Format("姓名:{0}\n", myArrayName[idx]);
            }
            Lbl資料結果顯示.Text = strMsg;

        }

        private void Btn列出所有學生_Click(object sender, EventArgs e)
        {

            列出所有人員();           
        }

        void 列出所有人員()
        {
            string strMsg = "";
            for (int idx = 0; idx < arrayStudentName.Length; idx += 1)
            {
                strMsg += string.Format("索引值:{0} 姓名:{1} 成績:{2}\n", idx, arrayStudentName[idx], arrayStudentScore[idx]);
            }

            Lbl資料結果顯示.Text = strMsg;
        }

        private void Btn姓名搜尋_Click(object sender, EventArgs e)
        {
            if (Txt輸入姓名.Text.Length > 0)
            {
                int index, num = 0;
                string strMsg = "搜尋結果\n-------------\n";
                string strSearcName = Txt輸入姓名.Text;


                Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
                Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.Length);

                成績排序(arrayTempStudentName, arrayTempStudentScore);

                index = System.Array.IndexOf(arrayTempStudentName, strSearcName); //搜尋陣列所在位置的資料索引值並回傳,找不到會回傳-1
                if (index == -1)
                { //找不到
                    strMsg += "查無此人";
                }else
                { //找到了
                    //num =//求名次
                    num = arrayTempStudentName.Length - index;
                    strMsg += string.Format($"{arrayTempStudentName[index]} {arrayTempStudentScore[index] }分\n,第{num}名");
                }
                Lbl資料結果顯示.Text = strMsg;
            }
            else
            {
                MessageBox.Show("請輸入姓名:");
            }
        }


    }
}
