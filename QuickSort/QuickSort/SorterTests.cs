﻿using System;
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
                var j = rnd.Next(0, array.Length - 2);
                var k = rnd.Next(j, array.Length - 1);
                Assert.GreaterOrEqual(array[k], array[j]);
            }
        }

        [Test]
        public void NullArray()
        {
            Sorter.QuickSort(null);
        }
        
        [Test]
        public void EmptyArray()
        {
            Sorter.QuickSort(new int[0]);
        }

        [Test]
        public void BigRandomArray()
        {
            var rnd = new Random();
            var array = new int[300000000];
            for (var i = 0; i < array.Length; i++)
                array[i] = rnd.Next(int.MinValue, int.MaxValue);
            Sorter.QuickSort(array);
            for (var i = 0; i < array.Length - 1; i++)
            {
                Assert.GreaterOrEqual(array[i + 1], array[i]);
            }
        }
    }
}
