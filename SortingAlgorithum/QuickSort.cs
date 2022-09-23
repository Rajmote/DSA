using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.SortingAlgorithum
{
    public class QuickSort
    {
        // var numArray = new int[9] { 25, 26, 21, 2, 8, 9, 78, 1, 0 };
        static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /// <summary>
        /// Inserting array and low=0 , high = array.Length-1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        static int partition(int[] arr, int start, int end)
        {
            // Considering arr[high] as pivote 
            int pivot = arr[end];

            // initializing index for pivot for second run low-1
            int index = start - 1;

            // 1st run 0 to 8 (in our case because lenth of array is 9) and last element we are considering as pivot for first run
            for (int j = start; j < end; j++)
            {
                if (arr[j] < pivot)
                {
                    index++;
                    swap(arr, index, j);
                }
            }
            swap(arr, index + 1, end);

            return index+1;
        }

        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(arr, low, high);
                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }
        }

    }
}
