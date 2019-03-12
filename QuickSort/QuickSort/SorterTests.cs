using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace QuickSort
{
    [TestFixture]
    class SorterTests
    {
        public void CheckSort(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
                Assert.True(array[i] <= array[i + 1]);
        }



        [Test]
        public void SortedArray()
        {
            var array = new int[] { 1, 2, 3 };
            Sorter.QuickSort(array);
            CheckSort(array);
        }

        [Test]
        public void TwoArray()
        {
            var array = new int[] { 2, 2, 2 };
            Sorter.QuickSort(array);
            CheckSort(array);
        }

        [Test]
        public void ShortArray()
        {
            var array = new int[] { 1 };
            Sorter.QuickSort(array);
            CheckSort(array);
        }

        [Test]
        public void SimpleArray()
        {
            var array = new int[] { 2, 1 };
            Sorter.QuickSort(array);
            CheckSort(array);
        }

        [Test]
        public void OneNumberArray()
        {
            var array = new int[10];
            Sorter.QuickSort(array);
            CheckSort(array);
        }

        [Test]
        public void RandomArray()
        {
            var rnd = new Random();
            var array = new int[1000];
            for (var i = 0; i < array.Length; i++)
                array[i] = rnd.Next(-100, 100);
            Sorter.QuickSort(array);
            for(var i = 0; i < 10; i++)
            {
                var j = rnd.Next(0, array.Length - 1);
                Assert.GreaterOrEqual(array[j + 1], array[j]);
            }
        }

        [Test]
        public void EmptyArray()
        {
            Sorter.QuickSort(null);
        }

        [Test]
        public void BigRandomArray()
        {
            var rnd = new Random();
            var array = new int[150000000];
            for (var i = 0; i < array.Length; i++)
                array[i] = rnd.Next(-100, 100);
            Sorter.QuickSort(array);
            for (var i = 0; i < 1000; i++)
            {
                var j = rnd.Next(0, array.Length - 1);
                Assert.GreaterOrEqual(array[j + 1], array[j]);
            }
        }
    }
}
