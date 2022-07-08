using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 期中
{
    class GlobalVar
    {
        public static string user = "";
        public static bool isManager = false;
        public static int memberid;
        public static bool userState = false;
        public static Home home; //菜單
        public static Login login;
        public static CakeDetail cakedetail;
        public static MCakeDetail mcakedetail;
        public static Morder morder;
        public static Car car;
        public static Order order;
        public static Accounts accounts;
        public static MyFavorite favorite;
        public static Manager manager;
        public static AddMember addmember;
        public static Member member;

        public static string CakeConnectionString = "";
        public static int CakeClassId = 0;
        //public static List<string> listCakeName = new List<string>();
        //public static List<int> listCakePrice = new List<int>();
        //public static List<int> listCakeId = new List<int>();


        public static void mssql()
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Cake";
            scsb.IntegratedSecurity = true;
            CakeConnectionString = scsb.ToString();
        }
        
       
    }
}
