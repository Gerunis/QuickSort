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
            var s = new Stack<Tuple<int, int>>();
            s.Push(new Tuple<int, int>(start, end));
            while(s.Count != 0)
            {
                var t = s.Pop();
                var l = t.Item1;
                var r = t.Item2;
                if (r <= l)
                    continue;
                int i = Divide(array, l, r);
                if (i - l > r - i)
                {
                    s.Push(new Tuple<int, int>(l, i - 1));
                    s.Push(new Tuple<int, int>(i + 1, r));
                }
                else
                {
                    s.Push(new Tuple<int, int>(i + 1, r));
                    s.Push(new Tuple<int, int>(l, i - 1));
                }
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
