using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public class QuickSort
    {
        public int[] data = { 40, 10, 80, 30, 90, 50, 70 };
        private int low;
        private int high;
        /*
         * p    i   j   
         * 40   1   0   10,40,80,30,90,50,70
         * 40   2   0
         * 40   3   1   10,30,80,40,90,50,70
         * 40   4   1
         * */
        public void Sort()
        {

        }
        private int Partition(int[] data, int low, int high)
        {
            int pivot = data[low];
            int j = low - 1;
            for (int i = low + 1; i <= high; i++)
            {
                if (data[i] < pivot)
                {
                    j++;
                    Swap(data, i, j);
                }
            }

            return j + 1;
        }

        private void Swap(int[] data, int position1, int position2)
        {
            int temp = data[position1];
            data[position1] = data[position2];
            data[position2] = temp;
        }
    }

}
