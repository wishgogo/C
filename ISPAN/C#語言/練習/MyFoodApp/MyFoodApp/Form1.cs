using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFoodApp
{
    public partial class Form1 : Form
    {
        string[,] arrayFood = new string[,] {{ "炸雞腿", "100" }, { "滷雞腿", "90"  }, { "炸排骨", "85"  },
                { "滷排骨", "80" },{ "炸雞排", "75"  }, { "炸魚排", "95"   },
                { "香腸", "70"  }, { "糖醋雞", "70"  }, { "水煮雞胸肉", "90"  }, { "五菜", "60"  } };

        string[,] arrayTempFood = new string[10,2];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl便當總價.Text = string.Format("便當總價:{0}",totalPrice().ToString());
            lbl便當均價.Text = string.Format("便當均價:{0}",averagePrice().ToString());
        }

        private void btn便當排序_Click(object sender, EventArgs e)
        {
            System.Array.Copy(arrayFood, arrayTempFood, arrayFood.Length);
            排序便當(arrayTempFood);
        }
        private void btn價格排序_Click(object sender, EventArgs e)
        {
            System.Array.Copy(arrayFood, arrayTempFood, arrayFood.Length);
            價格排序(arrayTempFood);
        }

        private void btn顯示所有便當_Click(object sender, EventArgs e)
        {
            所有便當();
        }


        private void btn搜尋_Click(object sender, EventArgs e)
        {
            
        }

        //顯示所有便當
        void 所有便當()
        {
            string Msg = "";
            for (int idx = 0; idx <= arrayFood.GetUpperBound(0); idx++)
            {
                for (int jdx = 0; jdx < arrayFood.GetUpperBound(1); jdx++)
                {
                    Msg += string.Format("{0}便當,價錢{1}\n", arrayFood[idx, jdx], arrayFood[idx, jdx +1]);
                    lbl顯示.Text = Msg;

                }
            }
          
        }
        // 總價
        int totalPrice()
        {
            int total = 0;
            for (int idx = 0; idx <= arrayFood.GetUpperBound(0); idx++) //idx<=9
            {
                for (int jdx = 0; jdx < arrayFood.GetUpperBound(1); jdx++)  //jdx<1
                {
                    total += Convert.ToInt32(arrayFood[idx, jdx + 1]);                 
                }
         
            }
            return total;

        }
        // 平均價格
        double averagePrice()
        {
            //double total = totalPrice() / (arrayFood.Length/2); // arrayFood.Length=10
            double total = totalPrice() / (arrayFood.GetUpperBound(0) + 1);
            return total;
        }

        //便當排序
        void 排序便當(string[,]arrayFood)
        {
            //sort 排序
            //Array.Sort(arrayFood);
            string Msg = "";
            string[] foodName = new string[10];
            int temp = 0;
            for (int idx = 0; idx <= arrayFood.GetUpperBound(0); idx++) //idx<=9
            {
                for (int jdx = 0; jdx < arrayFood.GetUpperBound(1); jdx++)  //jdx<1
                {
               
                    foodName[temp] = arrayFood[idx, jdx];
                    temp++;
                }
            } 
            Array.Sort(foodName);
            for (int idx = 0; idx < foodName.Length; idx ++ )
            {
                Msg += string.Format("便當:{0}\n", foodName[idx]);
            }
            lbl顯示.Text = Msg;
          
        }
        //價格排序
        void 價格排序(string[,] arrayTempFood)
        {
            string Msg = "";
            string[] price = new string[10];
            int temp = 0;
            for (int idx = 0; idx <= arrayFood.GetUpperBound(0); idx++) //idx<=9
            {
                for (int jdx = 0; jdx < arrayFood.GetUpperBound(1); jdx++)  //jdx<1
                {

                    price[temp] = arrayFood[idx, jdx];
                    temp++;
                }
            }
            Array.Sort(price);
            for (int idx = 0; idx < price.Length; idx++)
            {
                Msg += string.Format("便當:{0}\n", price[idx]);
            }
            lbl顯示.Text = Msg;

        }
    }
}
