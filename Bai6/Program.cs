namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.DateTime timenow = System.DateTime.Now;
            ThoiGian t1 = new ThoiGian();
            t1.HienThi();
            ThoiGian t2 = new ThoiGian(12, 10, 2014, 4, 56, 39);
            t2.HienThi();
            ThoiGian t3 = new ThoiGian(20, 05, 2014);
            t3.HienThi();
            ThoiGian t4 = new ThoiGian(t3);
            t4.HienThi();
            ThoiGian t5 = new ThoiGian(timenow);
            t5.HienThi();
        }
    }
}
