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
    public partial class Morder : Form
    {
        public List<int> listMemberId = new List<int>();
        public List<string> listName = new List<string>();
        public List<string> listEmail = new List<string>();
        public List<string> listCellPhone = new List<string>();

        public List<int> listMemberOrderId = new List<int>();
        List<string> listCakeId = new List<string>();
        List<string> listCakeName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listQuantity = new List<int>();
        List<int> listId = new List<int>();
        List<string> listBuytime = new List<string>();
        List<int> listState = new List<int>();


        public Morder()
        {
            InitializeComponent();
        }     

        private void Morder_Load(object sender, EventArgs e)
        {
            GlobalVar.mssql();
            GlobalVar.morder = this;
            Detail();
        }

        private void Morder_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVar.manager.Show();
        }


    
        public void Detail()
        {
            SqlConnection con = new SqlConnection(GlobalVar.CakeConnectionString);
            con.Open();

            string strSQL = "Select * From Member Inner join CakeOrder on  Member.MemberId  = CakeOrder.MemberId order by BuyTime desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

          
            while (reader.Read())
            {
                listMemberId.Add((int)reader["MemberId"]);
                listName.Add(reader["Name"].ToString());
                listEmail.Add((string)reader["Email"]);
                listCellPhone.Add((string)reader["CellPhone"]);
                listMemberOrderId.Add((int)reader["MemberId"]);
                listId.Add((int)reader["OrderId"]);
                listCakeId.Add(reader["CakeId"].ToString());
                listQuantity.Add((int)reader["Quantity"]);
                listPrice.Add((int)reader["Price"]);
                listBuytime.Add(reader["BuyTime"].ToString());
                listState.Add(Convert.ToInt32(reader["OrderState"]));
               

            }
            reader.Close();

            for (int i = 0; i < listId.Count; i += 1)
            {
                strSQL = "select * from Cake where CakeId = @NewlistName";
                SqlCommand cmdd = new SqlCommand(strSQL, con);
                cmdd.Parameters.AddWithValue("@NewlistName", listCakeId[i]);
                reader = cmdd.ExecuteReader();
                while (reader.Read())
                {                   
                    listCakeName.Add((string)reader["CakeName"]);
                }
                reader.Close();
            }
            con.Close();
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("", 10);
            listView1.Columns.Add("姓名", 80);
            listView1.Columns.Add("信箱", 210);
            listView1.Columns.Add("手機", 120);
            listView1.Columns.Add("商品", 230);
            listView1.Columns.Add("數量", 70);
            listView1.Columns.Add("總價", 80);
            listView1.Columns.Add("購買時間", 260);
            listView1.Columns.Add("訂單狀態", 60);
            listView1.SmallImageList = imageList1; //SmallIcon,List
            listView1.FullRowSelect = true;

         

            for (int i = 0; i < listId.Count; i += 1)
            {

                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 11, FontStyle.Regular);
                //第一欄一定是text
                //第一欄之後SubItems
                item.ImageIndex = i;

                item.SubItems.Add(listName[i]);
                item.SubItems.Add(listEmail[i].ToString());
                item.SubItems.Add(listCellPhone[i].ToString());

                item.SubItems.Add(listCakeName[i]);
                item.SubItems.Add(listQuantity[i].ToString());
                item.SubItems.Add(listPrice[i].ToString());
                item.SubItems.Add(listBuytime[i].ToString());
            
                item.Tag = listId[i];
                listView1.Items.Add(item);

            }

       


        }

    
    }
}
