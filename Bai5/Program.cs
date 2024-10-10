namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong hoc sinh: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[n];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien thu {0}", (i + 1).ToString());
                students[i] = new Student();
                students[i].Nhap();
            }
            Console.WriteLine("Danh sach sinh vien");

            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "Ho Ten", "Diem Toan", "Diem Van", "DTB");

            for (int i = 0; i < students.Length; i++)
            {
                students[i].Xuat();
            }
        }
    }
}
