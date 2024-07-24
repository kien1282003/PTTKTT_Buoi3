using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongMang
{
    public class CoDeQuy
    {
        public int TongCoDeQuy(int[] array, int startArray, int endArray)
        {
            if (startArray == endArray)
            {
                return array[startArray];
            }

            int mid = (startArray + endArray) / 2;
            int leftSum = TongCoDeQuy(array, startArray, mid);
            int rightSum = TongCoDeQuy(array, mid + 1, endArray);

            return leftSum + rightSum;
        }

    }
}
