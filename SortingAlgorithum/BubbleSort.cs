using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.SortingAlgorithum
{
    public class BubbleSort
    {
        public static void RunBubbleSort()
        {
            var numArray = new int[9] { 25, 26, 21, 2, 8, 9, 78, 1, 0 };
            for (int i = 0; i < 9; i++)
            {
                Console.Write(numArray[i] + " ");
            }
            GetSortedArrayByBubbleSort(numArray);
            Console.WriteLine();
            for (int i = 0; i < 9; i++)
            {
                Console.Write(numArray[i]+" ");
            }
        }
        public static void GetSortedArrayByBubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-i-1; j++)
                {
                    if(array[j] > array[j+1])
                    {
                        int minValue = array[j + 1];
                        array[j+1]=array[j];
                        array[j] = minValue;
                    }
                }
            }
        }
    }
}
