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
}
