using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Student
    {
        private string ten;
        private int tuoi;
        private double diemToan;
        private double diemVan;
        private double diemTB;

        public Student() { }
        public Student(string ten, int tuoi, double diemToan, double diemVan, double diemTB)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.DiemToan = diemToan;
            this.DiemVan = diemVan;
            this.DiemTB = diemTB;
        }

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public double DiemToan { get => diemToan; set => diemToan = value; }
        public double DiemVan { get => diemVan; set => diemVan = value; }
        public double DiemTB { get => Math.Round(((DiemToan +DiemVan)/2),2); set => diemTB = value; }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Nhap diem toan: ");
                DiemToan = Convert.ToInt32(Console.ReadLine());
                if(DiemToan < 0)
                {
                    Console.WriteLine("Diem nam trong khoang 0 -> 10");
                }
            }
            while (DiemVan<0);
            do
            {
                Console.Write("Nhap diem van: ");
                DiemVan = Convert.ToInt32(Console.ReadLine());
                if (DiemVan < 0)
                {
                    Console.WriteLine("Diem nam trong khoang 0 -> 10");
                }
            }
            while (DiemVan < 0);
        }
        public void Xuat()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", Ten, DiemToan, DiemVan, DiemTB);
        }
    }
}
