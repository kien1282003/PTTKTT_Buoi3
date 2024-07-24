using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    public class BSKhongDeQuy
    {
        public int BinarySearchKhongDeQuy(int[] array, int target)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == target)
                {
                    return mid; // Tìm thấy phần tử
                }
                else if (array[mid] < target)
                {
                    low = mid + 1; // Tìm kiếm trong nửa mảng bên phải
                }
                else
                {
                    high = mid - 1; // Tìm kiếm trong nửa mảng bên trái
                }
            }

            return -1; // Không tìm thấy phần tử
        }
    }
}
