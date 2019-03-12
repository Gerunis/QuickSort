using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var array = new int[5];
            for (var i = 0; i < array.Length; i++)
                array[i] = rnd.Next(0, 10);
            Sorter.QuickSort(array);
            for (var i = 0; i < 1000; i++)
            {
                var j = rnd.Next(0, array.Length - 1);
                Console.Write(array[j + 1] <= array[j]);
            }
        }
    }
}
