using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_bai1
{
    internal class TimSoLonNhat
    {
        public int Input()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        public int TimMax(int a, int b, int c)
        {
            int max = a;
            if (max < b) max = b;
            else if (max < c) max = c;
            return max;
        }
    }
}
