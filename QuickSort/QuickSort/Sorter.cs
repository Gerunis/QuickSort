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

        static void Sort(int[] a, int l, int r)
        {
            var v = a[r];
            if (r <= l)
                return;
            int i = l;
            int j = r - 1;
            int p = l - 1;
            int q = r;
            while(i <= j)
            {
                while (a[i] < v) i++ ;
                while (a[j] > v) j-- ;
                if (i >= j) break;
                Swap(a, i, j);
                if (a[i] == v)
                {
                    p++;
                    Swap(a, p, i);
                }
                i++;
                if (a[j] == v)
                {
                    q--;
                    Swap(a, q, j);
                }
                j--;
            }
            Swap(a, i, r);
            j = i - 1;
            i++;
            for (var k = l; k <= p; k++, j--)
                Swap(a, k, j);
            for (var k = r - l; k >= q; k--, i++)
                Swap(a, k, i);
            Sort(a, l, j);
            Sort(a, i, r);
        }

        static void Swap(int[] array, int i, int j)
        {
            var e = array[i];
            array[i] = array[j];
            array[j] = e;
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
