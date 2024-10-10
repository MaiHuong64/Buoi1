using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Nhậ mảng có n phần tử (n>1).
- In các phần tử của mảng.
- T m á ị lớn nhấ ỏ nhất.
- Tính tổng các phần tử trong mảng.
- Sắp xếp mả ă ần. 
*/
namespace Bai4
{
    internal class MangSoNguyen
    {
        public int Input()
        {
            int num;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("Vui long nhap so > 0");
                }
            }
            while (num < 0);
            return num;
        }
        public void NhapMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void XuatMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0}\t", arr[i]);
        }
        public int Max(int[] arr)
        {
            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            return max;
        }
        public int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min < arr[i])
                    min = arr[i];
            }
            return min;
        }
        
        public int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum;
        }
        public void SapXepTang(int[] arr)
        {
            for(int i = 0;i < arr.Length-1; i++)
            {
                for(int j = i+1;  j < arr.Length; j++)
                    if(arr[j] < arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
            }
        }
    }
}
