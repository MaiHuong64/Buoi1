using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bai9
{
    internal class phuongtrinhbac2
    {
        private int a, b, c;

        public phuongtrinhbac2() {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }
        public phuongtrinhbac2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        public void TinhNghiem(int a, int b, int c)
        {
            if(a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Phuong trinh vo nghiem!");
                else Console.WriteLine($"Phuong trinh co mot nghiem x = {-c / b}");
                return;
            }
            double x1, x2;
            int del = b * b - 4 * a * c;
            if (del > 0)
            {
                x1 = (-b + Math.Sqrt(del)) / (2 * a);
                x2 = (-b - Math.Sqrt(del)) / (2 * a);
                Console.WriteLine($"Phuong trinh co 2 nghiem: x1 = {x1} va x2 = {x2}");
            }
            else if(del == 0)
            {
                x1 = x2 = -b / a;
                Console.WriteLine($"Phuong trinh co nghiem duy nhat x1 = x2 = {x1}");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem!");
            }
        }
        public void HienThi(int a, int b, int c)
        {
            Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");
            TinhNghiem(a, b, c);
        }
    }
}
