using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class GiaiThuaN
    { 
        public int Input()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        public int TinhGiaiThua(int num)
        {
            int gt = 1;
            for (int i = 1; i <= num; i++) 
                gt *= i;
            return gt;
        }
    }
}
