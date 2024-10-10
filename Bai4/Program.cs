namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MangSoNguyen msn = new MangSoNguyen();
            Console.Write("Nhap so phan tu cua mang: ");
            int n = msn.Input();
            int[] arr = new int[n];
            msn.NhapMang(arr);
            Console.Write("Mang vua nhap: ");
            msn.XuatMang(arr);
            Console.WriteLine("\nSo lon nhat trong mang: {0}", msn.Max(arr));
            Console.WriteLine("So nho nhat trong mang: {0}", msn.Min(arr));
            Console.WriteLine("Tong cac phan tu trong mang = {0}", msn.Sum(arr));
            Console.WriteLine("Mang sau khi duoc sap xep tang dan");
            msn.SapXepTang(arr);
            msn.XuatMang(arr);
        }
    }
}
