using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.SortingAlgorithum
{
    public class InsertionSort
    {
        public static void RunInsertionSort()
        {
            var numArray = new int[9] { 25, 26, 21, 2, 8, 9, 78, 1, 0 };
            Sort<int>(numArray);
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(numArray[i]);
            }
        }
        private static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    Swap(array, j, j - 1);
                    j--;
                }
            }
        }
    }

    public class SimpleInsertionSort
    {
        public static void RunInsertionSort()
        {
             int[] array = new int[10] { 56, 26, 3, 5, 4, 9, 8, 2, 7, 7 };
            //int[] array = new int[9] { 25, 26, 21, 2, 8, 9, 78, 1, 0 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            GetSortedArrayByInsertionSort(array);

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static int[] GetSortedArrayByInsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    int minValue = array[j];
                    array[j] = array[j - 1]; 
                    array[j-1] = minValue;              
                    j--;
                }
            }
            return array;
        }


    }
}
