﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MyEnums
    {
        public enum Man
        {
            //職稱代號 for Manager
            董事長 = 10,
            總經理 = 11,
            副總 = 12,
            經理 = 13,
            組長 = 14
        }

        public enum Dep
        {
            //部門代號 for All
            行政處 = 101,
            資訊處 = 102,
            業務部 = 103,
            研發部 = 104
        }
    }
}
