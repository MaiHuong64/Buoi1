namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GiaiThuaN gt = new GiaiThuaN();
            Console.Write("Nhap n: ");
            int n = gt.Input();
            Console.WriteLine("Giai thua cua {0} = {1}", n, gt.TinhGiaiThua(n));
        }
    }
}
