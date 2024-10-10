using Buoi1_bai1;

namespace Buoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimSoLonNhat timSoLonNhat = new TimSoLonNhat();
            Console.Write("Nhap a: ");
            int a = timSoLonNhat.Input();
            Console.Write("Nhap b: ");
            int b= timSoLonNhat.Input();
            Console.Write("Nhap c: ");
            int c = timSoLonNhat.Input();
            Console.WriteLine("So lon nhat trong ba so {0}, {1}, {2} la: {3}", a, b, c, timSoLonNhat.TimMax(a, b, c));
        }
    }
}
