using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSort
    {
        public void Quicksort(int[] array, int start, int end)
        {
            if (start < end) //Nếu như vị trí bắt đầu nhỏ hơn vị trí kết thúc thì thực thi
            {
                int divide = Partition(array, start, end); //Chia mảng thành 2 phần

                Quicksort(array, start, divide - 1); //Sắp xếp phần từ vị trí bắt đầu đến vị trí được chia
                Quicksort(array, divide + 1, end); //Sắp xếp phần tử từ vị trí được chia đến vị trí kết thúc
            }
        }

        static int Partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int i = start - 1;

            for (int j = start; j < end; j++) //Sử dụng vòng lặp for để so sánh phần tử đầu và phần tử "trục" trong mảng
            {
                if (array[j] <= pivot) //Nếu phần từ được so sánh và trục nhỏ hơn thì bắt đầu thực hiện hành động swap
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, end);
            return i + 1;
        }

        static void Swap(int[] array, int i, int j) //Hàm đổi chỗ để sắp xếp các phần tử
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
