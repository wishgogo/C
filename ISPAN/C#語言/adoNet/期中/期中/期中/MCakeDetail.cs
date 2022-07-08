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
    public partial class MCakeDetail : Form
    {

        public int cakeid;
        public bool isFavorite;
        public string image_dir = @"images\";
        public string image_name = "";
        public bool isChange;
        public bool isSelect;

        public MCakeDetail()
        {
            InitializeComponent();
        }

        private void MCakeDetail_Load(object sender, EventArgs e)
        {
            btnAdd.Text = "新增";
            btnClear.Text = "清除";
            txtDetailName.Text = "";
            txtDetail.Text = "";
            txtSize.Text = "";
            image_name = "";
            pictureBoxCake.Image = null;
            cbxState.Checked = false;
            txtDetailPrice.Text = "";

            GlobalVar.mssql();
            ReadClass();
            if (isSelect) {
                Detail();
            }

        }
        public void ReadClass()
        {

            cboxClass.Items.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
            con.Open();
            string strSQL = "select * from Class order by ClassId";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cboxClass.Items.Add(reader["CakeClass"].ToString());

            }
            cboxClass.SelectedIndex = 0;
            reader.Close();
            con.Close();

        }
        public void Detail()
        {
            SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
            con.Open();
            string strSQL = "select * from Cake where CakeId = @cakeid";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue(@"cakeid", cakeid);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cboxClass.SelectedIndex = Convert.ToInt32(reader["ClassId"]) - 1;
                txtDetailName.Text = reader["CakeName"].ToString();
                txtDetail.Text = reader["CakeDetail"].ToString();
                txtSize.Text = reader["SizeDetail"].ToString();
                image_name = reader["CakeImage"].ToString();
                pictureBoxCake.Image = Image.FromFile(image_dir + image_name);
                cbxState.Checked = Convert.ToBoolean(reader["CakeState"]);
                txtDetailPrice.Text = reader["CakePrice"].ToString();
            }
            btnAdd.Text = "修改";
            btnClear.Text = "刪除";
            reader.Close();
            con.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if ((txtDetailName.Text != "") && (txtDetailPrice.Text != "") && (pictureBoxCake.Image != null) && (txtDetail.Text != "") && (txtSize.Text != ""))
            {
                if (isChange == true)
                {
                    pictureBoxCake.Image.Save(image_dir + image_name);
                    isChange = false;
                }

                if (isSelect)
                {   //儲存修改        
                    save();
                }

                //新增
          
                else
                    {
                    try { 
                        SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
                        con.Open();
                        string strSQL = "insert into Cake values(@NewClassId,@NewCakeName,@NewCakeDetail,@NewSizeDetail,@NewCakeImage,@NewCakeState,@NewCakePrice);";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewClassId", cboxClass.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@NewCakeName", txtDetailName.Text);
                        cmd.Parameters.AddWithValue("@NewCakeDetail", txtDetail.Text);
                        cmd.Parameters.AddWithValue("@NewSizeDetail", txtSize.Text);
                        cmd.Parameters.AddWithValue("@NewCakeImage", image_name);
                        cmd.Parameters.AddWithValue("@NewCakeState", cbxState.Checked);                      
                        int intPrice;
                        Int32.TryParse(txtDetailPrice.Text, out intPrice);
                        if (intPrice <= 0)
                        {
                            MessageBox.Show("商品價格請輸入整數或大於0");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@NewCakePrice", intPrice);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("新增成功");
                            reset();

                        }
                      
                    }
                    catch
                    {
                        MessageBox.Show("商品名稱重複");
                }
                    }
            }
        
            else
            {
                MessageBox.Show("所有欄位必填");
            }
            
           

        }     

        private void pictureBoxCake_Click(object sender, EventArgs e)
        {
            selectPictur();        
        }
        public void selectPictur()
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "圖檔類型 (*.jpg *.jpeg *.png)|*.jpeg;*.jpg;*.png"; //檔案類型過濾
            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBoxCake.Image = Image.FromFile(f.FileName);
                string fileExt = System.IO.Path.GetExtension(f.SafeFileName); //取得副檔名
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMdHHmmss") + myRand.Next(1000, 10000).ToString() + fileExt;
                isChange = true;
                Console.WriteLine(image_name);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //刪除
            if (isSelect)
            {             
                 DialogResult R = MessageBox.Show("確定刪除?", "刪除商品", MessageBoxButtons.YesNo);
                    if (R == DialogResult.Yes)
                    {//yes
                        SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
                        con.Open();
                        string strSQL = "delete from Cake where CakeId = @NewCakeId;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("NewCakeId", cakeid);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        reset();
                    }            
            }
            //清空
            else {
            txtDetailName.Text = "";
            txtDetailPrice.Text = "";
            txtDetail.Text="";
            txtSize.Text = "";
            image_name = "";
            cbxState.Checked = false;
            pictureBoxCake.Image = null;
            cboxClass.SelectedIndex = 0;
            }
        }

        public void save()
        {
        
            SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
            con.Open();
            string strSQL = "update Cake set ClassId=@NewClassId,CakeName=@NewCakeName,CakeDetail=@NewCakeDetail,SizeDetail=@NewSizeDetail,CakeImage=@NewCakeImage,CakeState=@NewCakeState,CakePrice=@NewCakePrice where CakeId=@NewCakeId";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewCakeId", cakeid);
            cmd.Parameters.AddWithValue("@NewClassId", cboxClass.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@NewCakeName", txtDetailName.Text);
            cmd.Parameters.AddWithValue("@NewCakeDetail", txtDetail.Text);
            cmd.Parameters.AddWithValue("@NewSizeDetail", txtSize.Text);
            cmd.Parameters.AddWithValue("@NewCakeImage", image_name);
            cmd.Parameters.AddWithValue("@NewCakeState", cbxState.Checked);

            int intPrice;
            Int32.TryParse(txtDetailPrice.Text, out intPrice);
            try
            {
                if (intPrice <= 0)
                {
                    MessageBox.Show("商品價格請輸入數字");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NewCakePrice", intPrice);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("修改成功");
                    reset();

                }
            }
            catch
            {
                MessageBox.Show("商品名稱重複");

            }
   
        }
        void reset()
        {
            GlobalVar.manager.ReadCake(GlobalVar.manager.CakeClassId);
            this.Close();
            GlobalVar.manager.Show();
        }
    }
}
