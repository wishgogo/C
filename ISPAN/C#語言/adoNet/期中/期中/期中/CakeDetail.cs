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
    public partial class CakeDetail : Form
    {
        public int cakeid;
        public bool isCake;
        public bool isFavorite;

        public CakeDetail()
        {
            InitializeComponent();
        }

        private void CakeDetail_Load(object sender, EventArgs e)
        {
            GlobalVar.mssql();
           
            Detail();

        }
        public void Detail()
        {
            isCake = false;
            SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
            con.Open();

            string strSQL = "select * from Cake where CakeId = @cakeid";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue(@"cakeid", cakeid);
            SqlDataReader reader = cmd.ExecuteReader();
            string image_dir = @"images\";
            string image_name = "";

            while (reader.Read())
            {
                lblDetailName.Text = reader["CakeName"].ToString();
                txtDetail.Text = reader["CakeDetail"].ToString();
                lblDetailSize.Text = reader["SizeDetail"].ToString();
                lblDetailPrice.Text = "$ " + reader["CakePrice"];
                image_name = reader["CakeImage"].ToString();
                pictureBoxCake.Image = Image.FromFile(image_dir + image_name);

            }

            if (GlobalVar.userState)
            {
                btnAddCar.Enabled = false;
                btnAddCar.Text = "此帳號目前被停用";
            }
            reader.Close();
            con.Close();
            checkFavorite();
            if (isFavorite)
            {
                btnFavorite.BackgroundImage = Properties.Resources.LOVE23;
            }
            else
            {
                btnFavorite.BackgroundImage = Properties.Resources.LOVE3;
            }
        }



        private void btnAddCar_Click(object sender, EventArgs e)
        {

            if (GlobalVar.memberid <= 0)
            {
                DialogResult R = MessageBox.Show("請先登入會員", "登入會員", MessageBoxButtons.YesNo);
                if (R == DialogResult.Yes)
                {
                    GlobalVar.home.checkMember();
                }
            }
            else if (nudQuantity.Value > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
                con.Open();

                checkCar();
                string strSQL = "";
                if (isCake)
                {
                    strSQL = "update Car set Quantity=@NewQuantity where CakeId=@NewCakeId and MemberId = @NewMemberId";
                }
                else
                {
                    strSQL = "insert into Car values(@NewMemberId,@NewCakeId,@NewQuantity);";
                }
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewMemberId", GlobalVar.memberid);
                cmd.Parameters.AddWithValue("@NewCakeId", cakeid);
                cmd.Parameters.AddWithValue("@NewQuantity", nudQuantity.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("已加入購物車");
                this.Close();
                GlobalVar.home.Show();
            }
            else
            {

                MessageBox.Show("數量請大於0");
            }

        }

        public void checkCar()
        {
            SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
            con.Open();
            string strSQL = "select * from Car where CakeId = @cakeid and MemberId = @NewMemberId";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue(@"cakeid", cakeid);
            cmd.Parameters.AddWithValue(@"NewMemberId", GlobalVar.memberid);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                isCake = true;
            }
            reader.Close();
            con.Close();
        }
        public void checkFavorite()
        {
            isFavorite = false;
            SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
            con.Open();
            string strSQL = "select * from Favorite where CakeId = @cakeid and MemberId = @NewMemberId";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue(@"cakeid", cakeid);
            cmd.Parameters.AddWithValue(@"NewMemberId", GlobalVar.memberid);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                isFavorite = true;
            }
           
            reader.Close();
            con.Close();
        }
        private void btnFavorite_Click(object sender, EventArgs e)
        {

            if (GlobalVar.memberid <= 0)
            {
                DialogResult R = MessageBox.Show("請先登入會員", "登入會員", MessageBoxButtons.YesNo);
                if (R == DialogResult.Yes)
                {
                    GlobalVar.home.checkMember();
                    this.Close();
                }
            }
            else
            {
                SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
                con.Open();
                checkFavorite();
                string strSQL = "";
                if (isFavorite)
                {               
                    strSQL = "delete from Favorite where MemberId = @NewMemberId and CakeId = @NewCakeId;";
                    btnFavorite.BackgroundImage = Properties.Resources.LOVE3;
                    MessageBox.Show("已移除最愛");
                }
                else
                {
                    strSQL = "insert into Favorite values(@NewMemberId,@NewCakeId);";
                    btnFavorite.BackgroundImage = Properties.Resources.LOVE23;
                    MessageBox.Show("已加入最愛");
                   
                }
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewMemberId", GlobalVar.memberid);
                cmd.Parameters.AddWithValue("@NewCakeId", cakeid);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

