using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace 期中
{
    public partial class Order : Form
    {
        List<string> listCakeId = new List<string>();
        List<string> listCakeName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listQuantity = new List<int>();
        List<int> listId = new List<int>();
        List<string> listBuytime = new List<string>();
        List<int> listState = new List<int>();


        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            GlobalVar.mssql();
            Detail();
        }

        public void Detail()
        {
            SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
            con.Open();

            string strSQL = "select * from CakeOrder where MemberId = @memberid order by BuyTime desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@memberid", GlobalVar.memberid);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\";
            string image_name = "";
            while (reader.Read())
            {
                listId.Add((int)reader["OrderId"]);
                listCakeId.Add(reader["CakeId"].ToString());
                listQuantity.Add((int)reader["Quantity"]);
                listPrice.Add((int)reader["Price"]);
                listBuytime.Add(reader["BuyTime"].ToString());
                listState.Add(Convert.ToInt32(reader["OrderState"]));
                //image_name = (string)reader["pimage"];
                //imageList1.Images.Add(Image.FromFile(image_dir + image_name));

            }
            reader.Close();

            for (int i = 0; i < listId.Count; i += 1)
            {
                strSQL = "select * from Cake where CakeId = @NewlistName";
                SqlCommand cmdd = new SqlCommand(strSQL, con);
                cmdd.Parameters.AddWithValue("@NewlistName", listCakeId[i]);
                reader = cmdd.ExecuteReader();
                while (reader.Read())
                {
                    image_name = (string)reader["CakeImage"];
                    imageList1.Images.Add(Image.FromFile(image_dir + image_name));
                    listCakeName.Add((string)reader["CakeName"]);
                }
                reader.Close();
            }
            con.Close();

            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("", 50);
            listView1.Columns.Add("商品", 230);
            listView1.Columns.Add("數量", 70);
            listView1.Columns.Add("總價", 80);          
            listView1.Columns.Add("購買時間", 260);
            listView1.Columns.Add("訂單狀態", 60);

            listView1.SmallImageList = imageList1; //SmallIcon,List
            listView1.FullRowSelect = true;

            for (int i = 0; i < imageList1.Images.Count; i += 1)
            {

                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 15, FontStyle.Regular);
                //第一欄一定是text
                //第一欄之後SubItems
                item.ImageIndex = i;
                item.SubItems.Add(listCakeName[i]);
                //item.ImageIndex = i;
                item.SubItems.Add(listQuantity[i].ToString());
                item.SubItems.Add(listPrice[i].ToString());
                item.SubItems.Add(listBuytime[i].ToString());
                if (listState[i] == 0)
                {
                    item.SubItems.Add("正常");
                }
                else
                {
                    item.SubItems.Add("取消");
                }
                item.Tag = listId[i];
                listView1.Items.Add(item);

            }

         


        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVar.home.Show();
        }
    }
}
