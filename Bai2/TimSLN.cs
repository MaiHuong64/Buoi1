using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class TimSLN
    {
        public int Input()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        public int TimMax(int num)
        {
            int max, i, temp;
            max = 0;
            i = 0;
            do
            {
                Console.Write("Nhap so thu {0}: ", i + 1);
                temp = Convert.ToInt32(Console.ReadLine());
                if(max<temp)
                    max = temp;
                i++;
            }
            while (i<num);
            return max;
        }
    }
}
