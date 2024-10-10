namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimSLN sln = new TimSLN();
            Console.Write("Nhap n: ");
            int n = sln.Input();
            Console.WriteLine("So lon nhat trong {0} vua nhap la: {1}", n, sln.TimMax(n));
        }
    }
}
