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

namespace 期中
{
    public partial class Manager : Form 
    {
        List<string> listCakeName = new List<string>();
        List<int> listCakePrice = new List<int>();
        List<int> listCakeId = new List<int>();
        public int CakeClassId = 0;

        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            GlobalVar.mssql();
            GlobalVar.manager = this;
            ReadCake(CakeClassId);
        }
        public void ReadCake(int CakeClassId)
        {

            SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
            con.Open();
            string strSQL = "";

            switch (CakeClassId)
            {
                case 0:
                    strSQL = "select * from Cake;";
                    break;
                case 1:
                    strSQL = "select * from Cake where ClassId = 1;";
                    break;
                case 2:
                    strSQL = "select * from Cake where ClassId = 2;";
                    break;
                case 3:
                    strSQL = "select * from Cake where ClassId = 3;";
                    break;
                case 4:
                    strSQL = "select * from Cake where ClassId = 4;";
                    break;
                case 5:
                    strSQL = "select * from Cake where ClassId = 5;";
                    break;
                default:
                    strSQL = "select * from Cake where ClassId = 6;";
                    break;
            }

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"images\";
            string image_name = "";
            listCakeId.Clear();
            listCakeName.Clear();
            listCakePrice.Clear();
            imageList1.Images.Clear();

            while (reader.Read())
            {
                listCakeId.Add((int)reader["CakeId"]);
                listCakeName.Add((string)reader["CakeName"]);
                listCakePrice.Add((int)reader["CakePrice"]);
                image_name = (string)reader["CakeImage"];
                imageList1.Images.Add(Image.FromFile(image_dir + image_name));
            }
            reader.Close();
            con.Close();
            listView();
        }

        void listView()
        {
            listView2.Clear();
            listView2.View = View.LargeIcon; //LargeIcon, SmallIcon, List, Tile
            imageList1.ImageSize = new Size(150, 135);
            listView2.LargeImageList = imageList1; //LargeIcon, Tile
            listView2.SmallImageList = imageList1; //SmallIcon, List
            for (int i = 0; i < imageList1.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
                item.Text = listCakeName[i];
                item.Text += " $" + listCakePrice[i];
                item.Tag = listCakeId[i];
                listView2.Items.Add(item);
            }
        }


        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVar.home.Close();
        }      


        private void btnManage_Click(object sender, EventArgs e)
        {
            GlobalVar.manager = this;
            Member member = new Member();
            GlobalVar.member = member;
            member.Show();
            this.Hide();
        }
       

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (GlobalVar.mcakedetail == null)
            {
                MCakeDetail mcakedetail = new MCakeDetail();
                GlobalVar.mcakedetail = mcakedetail;
            } 
            GlobalVar.mcakedetail.isSelect = true;
               GlobalVar.mcakedetail.cakeid = (int)listView2.SelectedItems[0].Tag;
               GlobalVar.mcakedetail.ShowDialog();
              
        }


        private void btnUserManage_Click(object sender, EventArgs e)
        {

            Accounts accounts = new Accounts();
            GlobalVar.accounts = accounts;
            accounts.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確定登出?", "登出", MessageBoxButtons.YesNo);
            if (R == DialogResult.Yes)
            {//yes
                Application.Restart();

            }
        }


        private void btnAll_Click(object sender, EventArgs e)
        {
            ReadCake(CakeClassId = 0);

        }
        private void btnClass1_Click_1(object sender, EventArgs e)
        {
            ReadCake(CakeClassId = 1);
        }

        private void btnClass2_Click_1(object sender, EventArgs e)
        {
            ReadCake(CakeClassId = 2);
        }

        private void btnClass3_Click_1(object sender, EventArgs e)
        {
            ReadCake(CakeClassId = 3);
        }

        private void btnClass4_Click_1(object sender, EventArgs e)
        {
            ReadCake(CakeClassId = 4);
        }

        private void btnClass5_Click_1(object sender, EventArgs e)
        {
            ReadCake(CakeClassId = 5);
        }

        private void btnClass6_Click_1(object sender, EventArgs e)
        {
            ReadCake(CakeClassId = 6);
        }

        private void btnAddCake_Click(object sender, EventArgs e)
        {
            if (GlobalVar.mcakedetail == null) { 
            MCakeDetail mcakedetail = new MCakeDetail();
            GlobalVar.mcakedetail = mcakedetail;
            }
            GlobalVar.mcakedetail.cakeid = 0;
            GlobalVar.mcakedetail.isSelect = false;
            GlobalVar.mcakedetail.ShowDialog();        
          
        }

        private void btnOrderManage_Click(object sender, EventArgs e)
        {
            Morder morder = new Morder();
            GlobalVar.morder = morder;
            morder.Show();
            this.Hide();
        }
    }
}
