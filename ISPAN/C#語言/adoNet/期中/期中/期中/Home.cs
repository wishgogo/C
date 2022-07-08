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
    public partial class Home : Form
    {
        List<string> listCakeName = new List<string>();
        List<int> listCakePrice = new List<int>();
        List<int> listCakeId = new List<int>();
        int CakeClassId = 0;

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           GlobalVar.mssql();
           GlobalVar.home = this;
           ReadCake(CakeClassId);
        }

        void ReadCake(int CakeClassId)
        {

            SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
            con.Open();
            string strSQL = "";           
            switch (CakeClassId)
            {
                case 0:
                    strSQL = "select * from Cake where CakeState = 0;";
                    break;
                case 1:
                    strSQL = "select * from Cake where ClassId = 1 and CakeState = 0;";
                    break;
                case 2:
                    strSQL = "select * from Cake where ClassId = 2 and CakeState = 0;";
                    break;
                case 3:
                    strSQL = "select * from Cake where ClassId = 3 and CakeState = 0;";
                    break;
                case 4:
                    strSQL = "select * from Cake where ClassId = 4 and CakeState = 0;";
                    break;
                case 5:
                    strSQL = "select * from Cake where ClassId = 5 and CakeState = 0;";
                    break;
                default:
                    strSQL = "select * from Cake where ClassId = 6 and CakeState = 0;";
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
            listView1.Clear();
            listView1.View = View.LargeIcon; //LargeIcon, SmallIcon, List, Tile
            imageList1.ImageSize = new Size(150, 135);
            listView1.LargeImageList = imageList1; //LargeIcon, Tile
            listView1.SmallImageList = imageList1; //SmallIcon, List
            for (int i = 0; i < imageList1.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 10, FontStyle.Regular);               
                item.Text = listCakeName[i];
                item.Text +=" $"+listCakePrice[i];
                item.Tag = listCakeId[i];
                listView1.Items.Add(item);
            }
        }


        private void btnMember_Click(object sender, EventArgs e)
        {
            checkMember();
        }
        public void checkMember()
        {
            if (GlobalVar.memberid <= 0)
            {
                Login login = new Login();
                GlobalVar.login = login;
                login.Show();
                this.Hide();
            }         
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            
            ReadCake(CakeClassId=0);
        }

        private void btnClass1_Click(object sender, EventArgs e)
        {
            ReadCake(CakeClassId = 1);
        }

        private void btnClass2_Click(object sender, EventArgs e)
        {
            ReadCake(CakeClassId = 2);
        }

        private void btnClass3_Click(object sender, EventArgs e)
        {
            ReadCake(CakeClassId = 3);
        }

        private void btnClass4_Click(object sender, EventArgs e)
        {
            ReadCake(CakeClassId = 4);
        }

        private void btnClass5_Click(object sender, EventArgs e)
        {
            ReadCake(CakeClassId = 5);
        }

        private void btnClass6_Click(object sender, EventArgs e)
        {
            ReadCake(CakeClassId = 6);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("確定登出?", "登出", MessageBoxButtons.YesNo);
            if (R == DialogResult.Yes)
            {//yes
                Application.Restart();
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            GlobalVar.home = this;
            Member member = new Member();
            GlobalVar.member = member;
            member.Show();
            this.Hide();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (GlobalVar.cakedetail == null)
            {
                CakeDetail myCakeDetail = new CakeDetail();
                GlobalVar.cakedetail = myCakeDetail;
            }

            GlobalVar.cakedetail.cakeid = (int)listView1.SelectedItems[0].Tag;
            GlobalVar.cakedetail.ShowDialog();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            GlobalVar.car = car;
            car.Show();
            this.Hide();
        }

        private void btnMyOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            GlobalVar.order = order;
            order.Show();
            this.Hide();
        }

        private void btnMyFavorite_Click(object sender, EventArgs e)
        {
            mf();
        }
        public void mf()
        {
            MyFavorite favorite = new MyFavorite();
            GlobalVar.favorite = favorite;
            favorite.Show();
            this.Hide();
        }

    
    }
}
