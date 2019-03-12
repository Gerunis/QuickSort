using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Sorter
    {
        public static void QuickSort(int[] array)
        {
            if (array is null) return;
            Sort(array, 0, array.Length - 1);
        }

        static void Sort(int[] array, int start, int end)
        {
            if(end > start)
            {
                var p = Divide(array, start, end);
                Sort(array, start, p - 1);
                Sort(array, p + 1, end);
            }
        }

        static int Divide(int[] array, int start, int end)
        {
            var pivot = array[(start + end) / 2];
            var i = start;
            var j = end;

            while (true)
            {
                for (; array[i] < pivot; i++) ;
                for (; array[j] > pivot; j--) ;

                if (i >= j) return j;
                if (array[i] == array[j]) i++;
                else
                {
                    var e = array[i];
                    array[i] = array[j];
                    array[j] = e;
                }
            }
        }
    }
}
