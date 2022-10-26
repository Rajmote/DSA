using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DSA.PracticeExamples
{
    public class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public int Data { get; set; }
    }

    public class Tree
    {
        public Node Root { get; set; }

        public void Insert ( int data )
        {
            Node newNode = new Node();
            newNode.Data = data;

            if ( this.Root == null )
            {
                this.Root = newNode;
            }
            else
            {
                var current = Root;
                Node parent;

                while ( true )
                {
                    parent = current;
                    if ( newNode.Data > parent.Data )
                    {
                        current = parent.RightNode;
                        if ( current == null )
                        {
                            parent.RightNode = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = parent.LeftNode;
                        if ( current == null )
                        {
                            parent.LeftNode = newNode;
                            break;
                        }
                    }
                }

            }
        }


        //Q.1) Write a program that finds the number of occurrences of a number in a tree of numbers. 
        public void FindOccurenceOfElement ( Node node, ref int occurenceCnt, int data )
        {
            if ( node != null )
            {
                if ( node.Data == data )
                {
                    occurenceCnt++;
                }
                FindOccurenceOfElement ( node.LeftNode, ref occurenceCnt, data );
                FindOccurenceOfElement ( node.RightNode, ref occurenceCnt, data );
            }
        }

        //Q.2) Write a program that displays the roots of those sub-trees of a tree, which have exactly k nodes, where k is an integer.
        public void PrintRootNodesOfSubTreesWithKNodes ( Node node, int k, ref int occurenceCnt )
        {
            // we have binary tree so it will be only one or two children elements
            if ( node != null )
            {
                int K =0;
                if ( node.RightNode != null )
                {
                    K++;
                }
                if ( node.LeftNode != null )
                {
                    K++;
                }
                if ( k == K )
                {
                    occurenceCnt++;
                }
                PrintRootNodesOfSubTreesWithKNodes ( node.LeftNode, k, ref occurenceCnt );
                PrintRootNodesOfSubTreesWithKNodes ( node.RightNode, k, ref occurenceCnt );
            }

        }

        //Q.3) Write a program that finds the number of leaves and number of internal vertices of a tree.
        public void PrintNumOfLeavesAndNumOfInternalVertices ( Node node, ref int leaves, ref int internalVertices )
        {
            if ( node != null )
            {
                if ( node.LeftNode == null && node.RightNode == null )
                {
                    leaves++;
                }
                else
                {
                    internalVertices++;
                    PrintNumOfLeavesAndNumOfInternalVertices ( node.LeftNode, ref leaves, ref internalVertices );
                    PrintNumOfLeavesAndNumOfInternalVertices ( node.RightNode, ref leaves, ref internalVertices );
                }

            }
            
        }

    }

    public class Excercise
    {
        public void Run ( )
        {
            Tree newTree = GetTree ( );

           
            //Q.1) Write a program that finds the number of occurrences of a number in a tree of numbers. 
            int occurenceCnt=0;
            newTree.FindOccurenceOfElement ( newTree.Root, ref occurenceCnt, 11 );
            Console.WriteLine ( "The number of occurrences of a number in a tree of numbers is = " + occurenceCnt );

            //Q.2) Write a program that displays the roots of those sub-trees of a tree, which have exactly k nodes, where k is an integer.
            occurenceCnt = 0;
            newTree.PrintRootNodesOfSubTreesWithKNodes ( newTree.Root, 2, ref occurenceCnt );
            Console.WriteLine ( "The roots of those sub-trees of a tree, which have exactly k nodes = " + occurenceCnt );

            //Q.3) Write a program that finds the number of leaves and number of internal vertices of a tree.
            int leaves=0;
            int internalVertices=0;
            newTree.PrintNumOfLeavesAndNumOfInternalVertices ( newTree.Root, ref leaves, ref internalVertices );
            Console.WriteLine ( "Leaves = " + leaves + ", Internal Vertices = " + internalVertices );



        }

        public Tree GetTree ( )
        {
            Tree binTree = new Tree();
            binTree.Insert ( 50 );
            binTree.Insert ( 51 );
            binTree.Insert ( 49 );
            binTree.Insert ( 52 );
            binTree.Insert ( 48 );
            binTree.Insert ( 53 );
            binTree.Insert ( 47 );
            binTree.Insert ( 54 );
            binTree.Insert ( 46 );
            binTree.Insert ( 55 );
            binTree.Insert ( 45 );
            binTree.Insert ( 56 );
            return binTree;
        }



    }
}
