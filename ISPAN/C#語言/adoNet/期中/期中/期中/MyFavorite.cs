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
    public partial class MyFavorite : Form
    {
        List<string> listCakeName = new List<string>();
        List<int> listCakePrice = new List<int>();
        List<int> listId = new List<int>();
        List<int> listCakeId = new List<int>();
        public MyFavorite()
        {
            InitializeComponent();
        }

        private void MyFavorite_Load(object sender, EventArgs e)
        {
            GlobalVar.favorite = this;
            GlobalVar.mssql();
            Detail();
        }

        public void Detail()
        {


            string image_dir = @"images\";
            string image_name = "";
            listId.Clear();
            listCakeName.Clear();
            listCakePrice.Clear();
            imageList1.Images.Clear();

            SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
            con.Open();
            string strSQL = "select * from Cake Inner join Favorite on Cake.CakeId = Favorite.CakeId  where MemberId = @memberid and CakeState = 0";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@memberid", GlobalVar.memberid);
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                listId.Add((int)reader["FavoriteId"]);
                image_name = (string)reader["CakeImage"];
                imageList1.Images.Add(Image.FromFile(image_dir + image_name));
                listCakeName.Add((string)reader["CakeName"]);
                listCakePrice.Add((int)reader["CakePrice"]);
                listCakeId.Add((int)reader["CakeId"]);
      
            }
            reader.Close();          
            con.Close();
            listView();
        }

        void listView()
        {
            listView1.Clear();
            listView1.View = View.LargeIcon; //LargeIcon, SmallIcon, List, Tile
            imageList1.ImageSize = new Size(80, 65);
            listView1.LargeImageList = imageList1; //LargeIcon, Tile
            listView1.SmallImageList = imageList1; //SmallIcon, List
            for (int i = 0; i < imageList1.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
                item.Text = listCakeName[i];
                item.Text += " $" + listCakePrice[i];
                item.Tag = listCakeId[i];
                item.Name = listId[i].ToString();
                listView1.Items.Add(item);
            }
           
        }

    

        private void MyFavorite_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVar.home.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listId.Count > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
                con.Open();
                string strSQL = "delete from Favorite where FavoriteId = @NewlistId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("NewlistId", Convert.ToInt32(listView1.SelectedItems[0].Name));
                cmd.ExecuteNonQuery();
                con.Close();
                listId.Clear();
                listCakeName.Clear();
                listCakePrice.Clear();
                imageList1.Images.Clear();
                listView1.Clear();
                //this.Close();
                //GlobalVar.home.mf();
                Detail();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (listId.Count > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
                con.Open();
                string strSQL = "delete from Favorite where MemberId = @NewMemberId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("NewMemberId", GlobalVar.memberid);
                cmd.ExecuteNonQuery();
                con.Close();
                listId.Clear();
                listCakeName.Clear();
                listCakePrice.Clear();               
                Detail();
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {

            if (GlobalVar.cakedetail == null)
            {
                CakeDetail cakedetail = new CakeDetail();
                GlobalVar.cakedetail = cakedetail;
            }
            GlobalVar.cakedetail.cakeid = Convert.ToInt32(listView1.SelectedItems[0].Tag);
            this.Close();
            GlobalVar.cakedetail.ShowDialog();
        
        }
    }
}
