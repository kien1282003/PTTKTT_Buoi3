using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class BSCoDeQuy
    {
        static int BinarySearchCoDeQuy(int[] array, int target, int low, int high)
        {
            if (low > high)
            {
                return -1; // Không tìm thấy phần tử
            }

            int mid = low + (high - low) / 2;

            if (array[mid] == target)
            {
                return mid; // Tìm thấy phần tử
            }
            else if (array[mid] < target)
            {
                return BinarySearchCoDeQuy(array, target, mid + 1, high); // Tìm kiếm trong nửa mảng bên phải
            }
            else
            {
                return BinarySearchCoDeQuy(array, target, low, mid - 1); // Tìm kiếm trong nửa mảng bên trái
            }
        }
    }
}
