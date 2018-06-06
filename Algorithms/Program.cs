using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var qs = new MyQuickSort(); 
            int[] arr = new int[] { 4, 6, 1, 2, 5, 8 };
            qs.DoQuickSort(arr, 0, arr.Length - 1);
        }
    }
}
