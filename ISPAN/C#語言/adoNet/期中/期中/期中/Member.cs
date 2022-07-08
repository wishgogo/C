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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();

            GlobalVar.mssql();
            member();


        }
        private void Member_Load_1(object sender, EventArgs e)
        {
         
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text != "") && (txtEmail.Text != "") && (txtPassWord.Text != "") && (txtCellPhone.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
                con.Open();
                string strSQL = "update Member set Name=@NewName,Email=@NewEmail,PassWord=@NewPassWord, CellPhone=@NewCellPhone where MemberId=@NewMemberId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtUser.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewPassWord", txtPassWord.Text);
                cmd.Parameters.AddWithValue("@NewCellPhone", txtCellPhone.Text);
                cmd.Parameters.AddWithValue("@NewMemberId", GlobalVar.memberid);
                DialogResult R = MessageBox.Show("確定修改?", "會員資料", MessageBoxButtons.YesNo);
                if (R == DialogResult.Yes)
                {//yes
                    MessageBox.Show("會員資料已變更");
                    cmd.ExecuteNonQuery();
                    con.Close();
                    member();
                }
            }
            else
            {
                MessageBox.Show("所有欄位必填");
            }
        }

        private void Member_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(GlobalVar.isManager)
                GlobalVar.manager.Show();
            else
                GlobalVar.home.Show();


        }
        public void member()
        {
            SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
            con.Open();
            string strSQL = "select * from Member where MemberId like @NewMemBerId";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewMemBerId", GlobalVar.memberid);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                txtUser.Text = string.Format("{0}", reader["Name"]);
                txtCellPhone.Text = string.Format("{0}", reader["CellPhone"]);
                txtEmail.Text = string.Format("{0}", reader["Email"]);
                txtPassWord.Text = string.Format("{0}", reader["PassWord"]);
                bool memberstate = Convert.ToBoolean(reader["MemberState"]);
                if (memberstate)
                {
                    btnSave.Enabled = false;
                    btnSave.Text = "帳號已被停權";
                }
            }

            reader.Close();
            con.Close();
        }
    }
}
