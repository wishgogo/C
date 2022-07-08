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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try { 
            if ((txtUser.Text != "") && (txtCellPhone.Text != "") && (txtEmail.Text != "") && (txtPassWord.Text != ""))
            {              
                SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
                con.Open();
                
                string strSQL = "insert into Member values(@NewName,@NewEmail,@NewPassWord,@NewCellPhone,@NewIsManager,@NewMemberState);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtUser.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewPassWord", txtPassWord.Text);
                cmd.Parameters.AddWithValue("@NewCellPhone", txtCellPhone.Text);
                cmd.Parameters.AddWithValue("@NewIsManager", 0);
                cmd.Parameters.AddWithValue("@NewMemberState", 0);
                cmd.ExecuteNonQuery(); 
                con.Close();          
                MessageBox.Show("註冊成功");
           
                GlobalVar.user = "        會員 " + txtEmail.Text;
                GlobalVar.userState = false;
                Login.islogin();
                this.Close();
                GlobalVar.home.Show();
            }
            else
            {
                MessageBox.Show("所有欄位必填");
            }
            }
            catch
            {
                MessageBox.Show("請確認格式是否正確");
            }

        }


        private void AddMember_FormClosed(object sender, FormClosedEventArgs e)
        {
           GlobalVar.home.Show();
        }

    }
}
