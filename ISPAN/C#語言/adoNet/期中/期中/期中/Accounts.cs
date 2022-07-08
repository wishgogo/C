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
    public partial class Accounts : Form
    {
        public List<int> listMemberId = new List<int>();
        public List<string> listName = new List<string>();
        public List<string> listEmail = new List<string>();
        public List<string> listCellPhone = new List<string>();
        List<bool> listMemberState = new List<bool>();
        bool checkmemberstate;
        bool select;

        public Accounts()
        {
            InitializeComponent();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            GlobalVar.mssql();
            GlobalVar.accounts = this;
            Detail();
        }

        public void Detail()
        {

            listMemberId.Clear();
            listName.Clear();
            listEmail.Clear();
            listCellPhone.Clear();
            listMemberState.Clear();
            checkmemberstate =false;
            select = false;
            SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
            con.Open();

            string strSQL = "select * from Member where IsManager=0";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listMemberId.Add((int)reader["MemberId"]);
                listName.Add(reader["Name"].ToString());
                listEmail.Add((string)reader["Email"]);
                listCellPhone.Add((string)reader["CellPhone"]);
                listMemberState.Add((bool)reader["MemberState"]);
            }
            reader.Close();
            con.Close();

            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("", 10);
            listView1.Columns.Add(" 姓名", 80);
            listView1.Columns.Add("信箱", 210);
            listView1.Columns.Add("手機", 120);
            listView1.Columns.Add("會員狀態", 70);
            listView1.SmallImageList = imageList1; //SmallIcon,List
            listView1.FullRowSelect = true;

            for (int i = 0; i < listMemberId.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 11, FontStyle.Regular);
                //第一欄一定是text
                item.ImageIndex = i;
                item.Text = (i + 1).ToString();
                //第一欄之後SubItems
                item.SubItems.Add(listName[i]);
                //item.ImageIndex = i;
                item.SubItems.Add(listEmail[i].ToString());
                item.SubItems.Add(listCellPhone[i].ToString());
                item.SubItems.Add(listMemberState[i].ToString());
                item.Tag = listMemberId[i];
                listView1.Items.Add(item);
            }
        }

        private void Accounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVar.manager.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (select)
                {
                    SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
                    con.Open();
                    string strSQL = "update Member set MemberState=@memberstate where MemberId=@memberid;;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@memberid", Convert.ToInt32(listView1.SelectedItems[0].Tag));
                    if (checkmemberstate)
                    {
                        cmd.Parameters.AddWithValue("@memberstate", 0);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@memberstate", 1);
                    }
                    DialogResult R = MessageBox.Show("確定修改?", "會員資料", MessageBoxButtons.YesNo);
                    if (R == DialogResult.Yes)
                    {//yes
                        MessageBox.Show("會員資料已變更");
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    Detail();
                }
                else
                {
                    MessageBox.Show("請選擇會員");
                }
            }
            catch
            {

            }

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try {
                SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
                con.Open();

                string strSQL = "select * from Member where memberId=@nmemberId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@nmemberId", listView1.SelectedItems[0].Tag);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    checkmemberstate = Convert.ToBoolean(reader["MemberState"]);
                }
                reader.Close();
                con.Close();
                select = true;
            }
            catch{
             //MessageBox.Show("請選擇會員");
            }
        }
    }
}
