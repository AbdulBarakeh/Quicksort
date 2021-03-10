using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;
namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            //TEST WITH CUSTOME QUICKSORT
            var unsortedArray = new int[] { 21, 547, 8, 56, 6, 357, 32, 487, 3, 4, 547, 243, 4, 1, 48, 5, 46, 78, 1877, 7, 54, 8, 5, 46, 23, 1, 567, 61, 54, 61, 3, 21, 547, 8, 56, 6, 357, 32, 487, 3, 4, 547, 243, 4, 1, 48, 5, 46, 78, 1877, 7, 54, 8, 5, 46, 23, 1, 567, 61, 54, 61, 3, 21, 547, 8, 56, 6, 357, 32, 487, 3, 4, 547, 243, 4, 1, 48, 5, 46, 78, 1877, 7, 54, 8, 5, 46, 23, 1, 567, 61, 54, 61, 3, 21, 547, 8, 56, 6, 357, 32, 487, 3, 4, 547, 243, 4, 1, 48, 5, 46, 78, 1877, 7, 54, 8, 5, 46, 23, 1, 567, 61, 54, 61, 3, 21, 547, 8, 56, 6, 357, 32, 487, 3, 4, 547, 243, 4, 1, 48, 5, 46, 78, 1877, 7, 54, 8, 5, 46, 23, 1, 567, 61, 54, 61, 3, 21, 547, 8, 56, 6, 357, 32, 487, 3, 4, 547, 243, 4, 1, 48, 5, 46, 78, 1877, 7, 54, 8, 5, 46, 23, 1, 567, 61, 54, 61, 3, 21, 547, 8, 56, 6, 357, 32, 487, 3, 4, 547, 243, 4, 1, 48, 5, 46, 78, 1877, 7, 54, 8, 5, 46, 23, 1, 567, 61, 54, 61, 3, };
            var timer = new Stopwatch();
            timer.Start();
            var sortedArray = Sort(unsortedArray, 0, unsortedArray.Length);
            timer.Stop();
            TimeSpan time = timer.Elapsed;
            string res = "Time taken: " + time.ToString(@"m\:ss\.fff");

            foreach (var item in sortedArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(res);

            ////TEST WITH MICROSOFT SORT FUNCTION IN LIST CLASS
            //var unsortedArray = new List<int> { 21, 547, 8, 56, 6, 357, 32, 487, 3, 4, 547, 243, 4, 1, 48, 5, 46, 78, 1877, 7, 54, 8, 5, 46, 23, 1, 567, 61, 54, 61, 3, 21, 547, 8, 56, 6, 357, 32, 487, 3, 4, 547, 243, 4, 1, 48, 5, 46, 78, 1877, 7, 54, 8, 5, 46, 23, 1, 567, 61, 54, 61, 3, 21, 547, 8, 56, 6, 357, 32, 487, 3, 4, 547, 243, 4, 1, 48, 5, 46, 78, 1877, 7, 54, 8, 5, 46, 23, 1, 567, 61, 54, 61, 3, 21, 547, 8, 56, 6, 357, 32, 487, 3, 4, 547, 243, 4, 1, 48, 5, 46, 78, 1877, 7, 54, 8, 5, 46, 23, 1, 567, 61, 54, 61, 3, 21, 547, 8, 56, 6, 357, 32, 487, 3, 4, 547, 243, 4, 1, 48, 5, 46, 78, 1877, 7, 54, 8, 5, 46, 23, 1, 567, 61, 54, 61, 3, 21, 547, 8, 56, 6, 357, 32, 487, 3, 4, 547, 243, 4, 1, 48, 5, 46, 78, 1877, 7, 54, 8, 5, 46, 23, 1, 567, 61, 54, 61, 3, 21, 547, 8, 56, 6, 357, 32, 487, 3, 4, 547, 243, 4, 1, 48, 5, 46, 78, 1877, 7, 54, 8, 5, 46, 23, 1, 567, 61, 54, 61, 3, };
            //var timer = new Stopwatch();
            //timer.Start();
            //unsortedArray.Sort();
            //timer.Stop();
            //TimeSpan time = timer.Elapsed;
            //string res = "Time taken: " + time.ToString(@"m\:ss\.fff");

            //unsortedArray.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine(res);
        }
        private static int[] Sort(int[] array, int first, int last){
            if (first < last)
            {
                var pivot = Partition(array, first, last);
                Sort(array,first,pivot);
                Sort(array,pivot+1,last);
            }

            return array;
        }
        private static void Swap(int[] array, int first, int last)
        {
            var temp = array[first];
            array[first] = array[last];
            array[last] = temp;
        }
        private static int Partition(int[] array, int first , int last){
            int pivot = array[first];
            int swapIndex = first;

            for (int testIndex = first+1; testIndex < last; testIndex++)
            {
                if (array[testIndex]<pivot)
                {
                    swapIndex++;
                    Swap(array, testIndex, swapIndex);
                }

            }
            Swap(array, first, swapIndex);

            return swapIndex;
        }


    }
}
