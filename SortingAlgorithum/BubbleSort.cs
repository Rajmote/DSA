﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.SortingAlgorithum
{
    public static class BubbleSort
    {
        public static void Sort(int[] array) 
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
