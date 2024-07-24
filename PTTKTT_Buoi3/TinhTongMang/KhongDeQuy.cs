using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongMang
{
    public class KhongDeQuy
    {
        public int TongKhongDeQuy(int[] array)
        {
            if (array.Length == 1)
            {
                return array[0];
            }

            int mid = array.Length / 2;
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < mid; i++)
            {
                leftSum += array[i];
            }

            for (int i = mid; i < array.Length; i++)
            {
                rightSum += array[i];
            }

            return leftSum + rightSum;
        }
    }
}
