// See https://aka.ms/new-console-template for more information
using DSA.Arrays;
using DSA.PracticeExamples;
using DSA.SortingAlgorithum;
using DSA.TreeInSimple;
using DSA.Trees;
using System.Numerics;

//SingleDimensionalArrays.MonthArray();
//MultiDimensionalArrays.MultiDimensionNumberArray();
//GameMap.RunMap();
//Transportation.RunTransport();
//var numArray = new int[9] { 25, 26, 21, 2, 8, 9, 78, 1, 0 };
//for (int i = 0; i < numArray.Length; i++)
//{
//    Console.Write(numArray[i] + " ");
//}
//Console.WriteLine();
//SelectionSort.Sort(numArray);
//InsertionSort.Sort(numArray); 
//BubbleSort.Sort(numArray); 
//QuickSort.Sort(numArray,0,numArray.Length-1);
//for (int i = 0; i < numArray.Length; i++)
//{
//    Console.Write(numArray[i] + " ");
//}
//DSA.LinkedListExample.RunLinkedListExample();
//DSA.StackExample.RunStackExample();
//BasicTree.RunBasicTree();
//EmployeeTree.RunEmployeeTree();
//var arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//    0       1     2
//0 = 1      2     3 
//1 = 4      5     6
//2 = 7      8     9
//(0,0) , (1,0), (2,0)
//(0,1),  (1,1), (2,1)
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(arr[i, j]);
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(arr[j, i]);
//    }
//    Console.WriteLine();
//}
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        system.out.println(transpose[i][j] + "");
//    }
//}
//var arr = new int[,] { { 1, 2, 3,4,5,6 }, { 1, 2, 3, 4, 5, 6 }, { 1, 2, 3,4,5,6 }, { 1, 2, 3,4,5,6 }, { 1, 2, 3,4,5,6 }, { 1, 2, 3,4,5,6 } };
//int sum=0;
//    int temp=0;
//    for ( int row = 1; row < arr.GetLength(0)- 1; row++ )
//        {
//        for ( int col = 1; col < arr.GetLength(1) - 1; col++ ) 
//            {
//            temp = arr[row, col]
//            + arr[row - 1, col - 1] + arr[row - 1, col] + arr[row - 1, col + 1]
//            + arr[row + 1, col - 1] + arr[row + 1, col] + arr[row + 1, col + 1];
//            if ( temp > sum )
//                {
//                sum = temp;
//                }
//            }
//        }
//Console.WriteLine ( sum );
//var ar = new int[]{1,2,3,4,5};
//for ( int i = 0; i < 4; i++ )
//    {
//    int temp=ar[0];
//    for ( int j = 0; j < ar.Length-1; j++ )
//        {
//        ar[j] = ar[j + 1];
//        }
//    ar[ar.Length - 1] = temp;
//    }
//for ( int j = 0; j < ar.Length; j++ )
//    {
//    Console.Write ( ar[j] + " " );
//    }

//BinaryTree binTree = new BinaryTree();

//binTree.Insert ( 11 );

//binTree.Insert ( 21 );

//binTree.Insert ( 78 );

//binTree.Insert ( 31 );

//binTree.Insert ( 101 );

//binTree.Insert ( 51 );

//binTree.Insert ( 82 );

//Node node = binTree.Search(51);

//int depth = binTree.GetDepth();

//Console.WriteLine ( "PreOrder Traversal:" );

//binTree.PreOrder ( binTree.Root );

//Console.WriteLine ();

//Console.WriteLine ( "InOrder Traversal:" );

//binTree.InOrder ( binTree.Root );

//Console.WriteLine ();

//Console.WriteLine ( "PostOrder Traversal:" );

//binTree.PostOrder ( binTree.Root );

//Console.WriteLine ();

//binTree.Delete ( 78 );

//binTree.Delete ( 82 );

//Console.WriteLine ( "After Remove Operation, Preorder Traversal:" );

//binTree.PreOrder ( binTree.Root );

//Console.WriteLine ();

//Console.ReadLine ();



//var srr= new String[]{"1","123654789658742365411236985","0","45","22"};

//for ( int i = 0; i < srr.Length-1; i++ )
//{
//    string temp="";
//    for ( int j = i+1; j < srr.Length; j++ )
//    {
//        if ( BigInteger.Parse ( srr[i] ) > BigInteger.Parse ( srr[j] ) )
//        {
//            temp = srr[i];
//            srr[i] = srr[j];
//            srr[j] = temp;
//        }
//    }
//}

//for ( int i = 0; i < srr.Length; i++ )
//{
//    Console.WriteLine ( srr[i] );
//}


Excercise excercise = new Excercise();
excercise.Run ();

Console.ReadLine ();


//public class Node<T>
//{
//    public T Data { get; set; }
//    public Node Parent { get;set; } 
//    public List<Node<T>> Children { get; set; }
//}

//public class Tree<T>
//{
//    public Node<T> Root { get; set; }
//}