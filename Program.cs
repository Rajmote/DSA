// See https://aka.ms/new-console-template for more information
using DSA.Arrays;
using DSA.SortingAlgorithum;

//SingleDimensionalArrays.MonthArray();
//MultiDimensionalArrays.MultiDimensionNumberArray();

//GameMap.RunMap();
//Transportation.RunTransport();



var numArray = new int[9] { 25, 26, 21, 2, 8, 9, 78, 1, 0 };

for (int i = 0; i < numArray.Length; i++)
{
    Console.Write(numArray[i] + " ");
}

Console.WriteLine();

SelectionSort.Sort(numArray);

InsertionSort.Sort(numArray); 

BubbleSort.Sort(numArray); 



for (int i = 0; i < numArray.Length; i++)
{
    Console.Write(numArray[i] + " ");
}

Console.ReadLine();
