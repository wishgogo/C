using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //繼承 Inheritance
    class Manager : Person, IMan
    {
        public int 職稱代號 = 0;

        //建構式不會繼承
        public Manager()
        {
            
        }
        public Manager(string myName)
        {
            姓名 = myName + " 主管";

        }

        public override double 薪資
        {
            get
            {
                return _薪資;
            }
            set
            {
                if (value < 25250.0)
                {
                    value = 25250.0;
                }
                else
                {
                    //符合勞基法最低薪資
                }
                value += 6000;//主管管理加給
                _薪資 = value;
            }
        }

        public override void 顯示基本資料()
        {
            //多型 Polymorphism
            // 子類別覆寫要加override

            string strInfo = string.Format("姓名:{0}\n身高:{1:F}公分\n體重:{2:F}公斤\n薪資:{3:C}元\n到職日:{4:D}\n職稱:{5}\n部門名稱:{6}\n", 姓名, 身高, 體重, 薪資, 到職日,顯示職稱(職稱代號),顯示部門名稱(部門代號));

            strInfo += "管理者職務";
            MessageBox.Show(strInfo);

        }

        public string 顯示職稱(int 職稱代號)
        {
            string strMsn = "";

            switch (職稱代號)
            {
                case (int)MyEnums.Man.董事長:
                    strMsn = "董事長";
                    break;
                case (int)MyEnums.Man.總經理:
                    strMsn = "總經理";
                    break;
                case (int)MyEnums.Man.經理:
                    strMsn = "經理";
                    break;
                case (int)MyEnums.Man.組長:
                    strMsn = "組長";
                    break;
                case (int)MyEnums.Man.副總:
                    strMsn = "副總";
                    break;
                default:
                    strMsn = "無此職稱";
                    break;
            }

            return strMsn;
        }

    }
}
