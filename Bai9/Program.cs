namespace Bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            phuongtrinhbac2 pt = new phuongtrinhbac2();
            Console.Write("Nhap he so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap he so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap he so c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            pt.HienThi(a, b, c);
        }
    }
}
