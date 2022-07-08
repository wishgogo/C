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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
          
        }


        private void Login_Load(object sender, EventArgs e)
        {
            GlobalVar.mssql();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" && txtPassword.Text!="")
            {
                string strSQL = "select * from Member where Email like @InputEmail and Password like  @InputPassWord;";
                SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@InputEmail",txtUser.Text);
                cmd.Parameters.AddWithValue("@InputPassWord",txtPassword.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                int i = 0;

                if (reader.Read())
                {
                    GlobalVar.isManager = Convert.ToBoolean(reader["IsManager"]);
                    if (!GlobalVar.isManager)
                    {
                        GlobalVar.user = "        會員 ";
                    }
                    else
                    {
                        
                        GlobalVar.user = "        管理員 ";
                    }
                    GlobalVar.user +=" "+reader["Email"];
                    GlobalVar.userState = Convert.ToBoolean(reader["MemberState"]);
                    GlobalVar.memberid=Convert.ToInt32(reader["MemberId"]);
                    i += 1;
                    MessageBox.Show("登入成功");
                    reader.Close();
                    con.Close();
                    this.Close();
                    islogin();


                }
                if (i <= 0)
                {
                    MessageBox.Show("帳號密碼錯誤");
                }
               
            }
            else
            {
                MessageBox.Show("請輸入帳號密碼");
            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVar.home.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                
                GlobalVar.login = this;
                AddMember addMember = new AddMember();
                GlobalVar.addmember = addMember;
                GlobalVar.addmember.Show();
                this.Hide();
            
        }
        static public void islogin()
        {
            if (GlobalVar.isManager)
            {
                Manager manager = new Manager();
                GlobalVar.manager = manager;
                GlobalVar.manager.btnManage.Text = GlobalVar.user;
                GlobalVar.home.Hide();
                manager.Show();
            }
            else
            {
                DateTime Date = DateTime.Now;

                GlobalVar.home.btnUser.Text = GlobalVar.user;
                GlobalVar.home.btnUser.Visible = true;
                GlobalVar.home.btnLogout.Visible = true;
                GlobalVar.home.btnMember.Text = "WelCome!";
                GlobalVar.home.btnMyFavorite.Visible = true;
                GlobalVar.home.btnMyOrder.Visible = true;
                GlobalVar.home.btnCar.Visible = true;
                GlobalVar.home.Show();

            }
        }
    }
}
