using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public class Helper
    {
        public static void Swap(int[] data, int position1, int position2)
        {
            int temp = data[position1];
            data[position1] = data[position2];
            data[position2] = temp;
        }
    }
}
