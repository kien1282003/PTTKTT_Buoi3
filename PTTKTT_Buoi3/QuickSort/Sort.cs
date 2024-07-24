using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Sort
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu n: "); //Nhập số lượng phần tử n
            int n = int.Parse(Console.ReadLine());
            int[] array1 = NhapMangRandom(n); //In mảng Random
            Console.Write("\n\nMang random: ");
            foreach (int value in array1)
            {
                Console.Write(value + " ");
            }
            QuickSort sort = new QuickSort();
            sort.Quicksort(array1,0,array1.Length-1);
            Console.Write("\n\nMang sau khi sap xep la: "); //In mảng sau khi sắp xếp
            foreach (int value in array1)
            {
                Console.Write(value + " ");
            }
            Console.ReadKey();
        }
        static int[] NhapMangRandom(int n) //Hàm nhập mảng random
        {
            Random random = new Random();
            if (n <= 0)
            {
                throw new ArgumentException("Kich thuc mang phai lon hon 0");
            }

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1, 100); //Tạo số ngẫu nhiên trong phạm vi
            }

            return array;
        }
    }
}
