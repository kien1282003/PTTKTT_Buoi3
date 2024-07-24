using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongMang
{
    internal class Sum
    {
        static void Main()
        {
            KhongDeQuy khongDeQuy = new KhongDeQuy();
            CoDeQuy coDeQuy = new CoDeQuy();
            Console.Write("Nhap so luong phan tu n: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = NhapMangRandom(n);
            int sum1 = khongDeQuy.TongKhongDeQuy(array);
            int sum2 = coDeQuy.TongCoDeQuy(array,0,array.Length-1);
            Console.Write("Mang random: ");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Tong cua mang khong su dung phuong phap de quy: " + sum1);
            Console.WriteLine("Tong cua mang co su dung phuong phap de quy: " + sum2);
            Console.ReadKey();
        }

        static int[] NhapMangRandom(int n)
        {
            Random random = new Random();
            if (n <= 0)
            {
                throw new ArgumentException("Kich thuc mang phai lon hon 0");
            }

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1,100); // Tạo số ngẫu nhiên trong phạm vi
            }

            return array;
        }

    }
}
