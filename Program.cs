using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;
namespace Quicksort
{
    class Program
    {
        List<int> orderedLesser = new List<int>();
        List<int> orderedGreater = new List<int>();
        static void Main(string[] args)
        {
            int[] unsortedArray = {21,547,8,56,6,357,32,487,3,4,547,243,4,1,48,5,46,78,1877,7,54,8,5,46,23,1,567,61,54,61,3};

        }
        private int DivideArray(int[] array, int first, int last){
            int pivot = array[last];
            
            return pivot;
        }
        private void Sort(int[] array, int first , int last){
            int[] sortedArray = array;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<=pivot)
                {
                    
                }
            }
            return sortedArray;
        }


    }
}
