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
    public partial class Car : Form
    {
        List<string> listCakeId = new List<string>();
        List<string> listCakeName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listQuantity = new List<int>();
        List<int> listId = new List<int>();
        int allprice = 0;
        public Car()
        {
            InitializeComponent();
        }

        private void Car_Load(object sender, EventArgs e)
        {
            if (GlobalVar.userState == true)
            {
                btnAddCar.Enabled = false;
            }
            else
            {
                btnAddCar.Enabled = true;
            }
            GlobalVar.mssql();
            Detail();

        }
        public void Detail()
        {
            SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
            con.Open();
          
            string strSQL = "Select* From Cake Inner join Car on Cake.CakeId = Car.CakeId where MemberId = @memberid and CakeState = 0";

            //string strSQL = "select * from Car where MemberId = @memberid and CakeState = false";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@memberid", GlobalVar.memberid);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\";
            string image_name = "";
            while (reader.Read())
            {

                listCakeId.Add(reader["CakeId"].ToString());
                listQuantity.Add((int)reader["Quantity"]);
                listId.Add((int)reader["CarId"]);
                //image_name = (string)reader["pimage"];
                //imageList1.Images.Add(Image.FromFile(image_dir + image_name));
                              
            }
            reader.Close();

            for (int i = 0; i < listCakeId.Count; i += 1)
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
                    listPrice.Add((int)reader["CakePrice"]);
                }
                reader.Close();
            }         
            con.Close();

            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("", 100);            
            listView1.Columns.Add("商品", 230);
            listView1.Columns.Add("價格", 85);
            listView1.Columns.Add("數量", 70);

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
                item.SubItems.Add(listPrice[i].ToString());
                item.SubItems.Add(listQuantity[i].ToString());
                item.Tag = listId[i];
                listView1.Items.Add(item);
                allprice += (listPrice[i] * listQuantity[i]);
             
            }

            lblAllPrice.Text = "總價$ "+allprice;
            if (allprice == 0)
            {
                lblAllPrice.Text = "總價$ 0";
            }


        }
        private void Car_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVar.home.Show();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
           
            CakeDetail cakedetailCar = new CakeDetail();
            cakedetailCar.cakeid = Convert.ToInt32(listView1.SelectedItems[0].Tag);
            cakedetailCar.ShowDialog();
        
        }



        private void btnAddCar_Click(object sender, EventArgs e)
        {

            if (listId.Count > 0 && allprice!=0)
            {
                DateTime buytime = DateTime.Now;
                SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
                con.Open();
                for (int i = 0; i < listId.Count; i += 1) { 
                    string strSQL = "insert into CakeOrder values(@nMemberId,@nCakeId,@nQuantity,@nPrice,@nBuyTime,@nOrderState);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@nMemberId", GlobalVar.memberid);
                cmd.Parameters.AddWithValue("@nCakeId", listCakeId[i]);
                cmd.Parameters.AddWithValue("@nQuantity", listQuantity[i]);
                cmd.Parameters.AddWithValue("@nPrice", listPrice[i]* listQuantity[i]);
                cmd.Parameters.AddWithValue("@nBuyTime", buytime);
                cmd.Parameters.AddWithValue("@nOrderState", 0);
                cmd.ExecuteNonQuery();
                }
                con.Close();                
                MessageBox.Show("已結帳");
                this.Close();
                clear();
                GlobalVar.home.Show();
            }else
            {
                MessageBox.Show("結帳金額需大於0"); 
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listId.Count > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
                con.Open();
                string strSQL = "delete from Car where CarId = @NewlistId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("NewlistId", Convert.ToInt32(listView1.SelectedItems[0].Tag));
                cmd.ExecuteNonQuery();
                con.Close();
                listCakeId.Clear();
                listCakeName.Clear();
                listPrice.Clear();
                listQuantity.Clear();
                listId.Clear();
                imageList1.Images.Clear();                
                allprice = 0;
               
                Detail();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
                clear();
        }
        public void clear()
        {
            if (listId.Count > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
                con.Open();
                string strSQL = "delete from Car where MemberId = @NewMemberId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("NewMemberId", GlobalVar.memberid);
                cmd.ExecuteNonQuery();
                con.Close();
                listCakeId.Clear();
                listCakeName.Clear();
                listPrice.Clear();
                listQuantity.Clear();
                listId.Clear();
                imageList1.Images.Clear();
                allprice = 0;
                Detail();
            }
        }
    }
}
