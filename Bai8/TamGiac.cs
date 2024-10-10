    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class TamGiac
    {
        private int canh1, canh2, canh3, chuVi;
        private int loaiTamGiac;
        private float dienTich;

        // Phuong thuc khoi tao 6 tham so
        public TamGiac(int canh1, int canh2, int canh3, int chuVi, int loaiTamGiac, float dienTich)
        {
            this.a = canh1;
            this.b = canh2;
            this.c = canh3;
            this.ChuVi = chuVi;
            this.LoaiTamGiac = loaiTamGiac;
            this.DienTich = dienTich;
        }
        // Phuong thuc khoi tao khong tham so
        public TamGiac()
        {
            this.a = 3;
            this.b = 4;
            this.c = 5;
        }
        // Phuong thuc khoi tao 3 tham so   
        public TamGiac(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int a { get => canh1; set => canh1 = value; }
        public int b { get => canh2; set => canh2 = value; }
        public int c { get => canh3; set => canh3 = value; }
        public int ChuVi { get => chuVi; set => chuVi = value; }
        public int LoaiTamGiac { get => loaiTamGiac; set => loaiTamGiac = value; }
        public float DienTich { get => dienTich; set => dienTich = value; }

        public bool KTTamGiac(int a, int b, int c)
        {
            return ((a + b > c) && (a + c > b) && (b + c > a) && (a > 0 && b > 0 && c > 0));
               
        }
        public void CV(int a, int b, int c)
        {
           ChuVi = a + b + c;
        }

        public void DT(int a, int b, int c)
        {
            if(KTTamGiac(a, b, c))
            {
                float p = ChuVi / 2.0f;
                DienTich = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
           
        }
        public int TimTamGiac(int a, int b, int c)
        {
            int num = 0;
            if (KTTamGiac(a, b, c))
            {
                if ((a == b) && (b == c))
                    num = 1;
                else if ((a * a == b * b + c * c) || (b * b == a * a + c * c ||
                        c * c == a * a + b * b))
                    num = 2;
                else if (a == b || a == c || b == c)
                    num = 3;
                else if (((a * a + b * b == c * c) && (a == b) ||
                           (a * a + c * c == b * b) && (a == c)||
                           (b * b + c * c == a * a) && (b == c)))
                    num = 4;
                else
                    num = 5;
            }
            return num;
        }
        public void display()
        {
            CV(a, b, c);
            DT(a, b, c);
            do
            {
                Console.WriteLine($"Canh 1: {a}");
                Console.WriteLine($"Canh 2: {b}");
                Console.WriteLine($"Canh 3: {c}");
                if (!KTTamGiac(a, b, c))
                    Console.WriteLine("3 canh khong tao thanh tam giac");

            }
            while (!KTTamGiac(a, b, c));
            Console.WriteLine("Chu vi tam giac = " + ChuVi);
            Console.WriteLine("Dien tich tam giac = " + DienTich);
        }
    }
}
