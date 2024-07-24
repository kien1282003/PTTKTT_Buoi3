using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Search
    {
        static void Main(string[] args)
        {
            BSKhongDeQuy bsKhongDeQuy = new BSKhongDeQuy();
            BSCoDeQuy bSCoDeQuy = new BSCoDeQuy();
            Console.Write("Nhap so luong phan tu n: "); //Nhập số lượng phần tử n
            int n = int.Parse(Console.ReadLine());
            int[] array1 = NhapMangRandom(n); //In mảng Random
            Array.Sort(array1);
            Console.Write("\n\nMang random: ");
            foreach (int value in array1)
            {
                Console.Write(value + " ");
            }
            Console.Write("\n\nNhap so tim kiem bang phuong phap khong de quy: "); //Nhập số tìm kiếm bằng phương pháp không đệ quy
            int target = int.Parse(Console.ReadLine());
            int indexKhongDeQuy = bsKhongDeQuy.BinarySearchKhongDeQuy(array1, target);
            if (indexKhongDeQuy != -1)
            {
                Console.WriteLine($"\nTim thay phan tu {target} tai vi tri {indexKhongDeQuy} bang phuong phap khong de quy");
            }
            else
            {
                Console.WriteLine($"\nKhong tim thay phan tu {target}");
            }
            Console.Write("\nNhap so tim kiem bang phuong phap khong de quy: "); //Nhập số tìm kiếm bằng phương pháp có đệ quy
            int target2 = int.Parse(Console.ReadLine());
            int indexCoDeQuy = bsKhongDeQuy.BinarySearchKhongDeQuy(array1, target2);
            if (indexCoDeQuy != -1)
            {
                Console.WriteLine($"\nTim thay phan tu {target} tai vi tri {indexCoDeQuy} bang phuong phap co de quy");
            }
            else
            {
                Console.WriteLine($"\nKhong tim thay phan tu {target2}");
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
