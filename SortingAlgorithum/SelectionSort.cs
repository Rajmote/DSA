using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.SortingAlgorithum
{
    public static class SelectionSort
    {
        public static void RunSelectionSort()
        {
            var numArray =new int[9] { 25, 26, 21, 2, 8, 9, 78, 1, 0 };
            Sort<int>(numArray);
            for(int i = 0; i < 9; i++)
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
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                T minValue = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = array[j];
                    }
                }
                Swap(array, i, minIndex);
            }
        }
    }
}
