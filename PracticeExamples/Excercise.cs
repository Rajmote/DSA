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
                if(node.Data==data)
                {
                    occurenceCnt++;
                }
                FindOccurenceOfElement ( node.LeftNode,ref occurenceCnt, data );
                FindOccurenceOfElement ( node.RightNode,ref occurenceCnt, data );
            }
        }

        //Q.2) Write a program that displays the roots of those sub-trees of a tree, which have exactly k nodes, where k is an integer.
        public void PrintRootNodesOfSubTreesWithKNodes(int k) 
        {

        }
    }

    public class Excercise
    {
        public void Run ( )
        {
            Tree newTree = GetTree ( );

            //Q.1) Write a program that finds the number of occurrences of a number in a tree of numbers. 
            int occurenceCnt=0;
            newTree.FindOccurenceOfElement(newTree.Root,ref occurenceCnt,11);

            //Q.2) Write a program that displays the roots of those sub-trees of a tree, which have exactly k nodes, where k is an integer.


        }

        public Tree GetTree ( )
        {
            Tree binTree = new Tree();
            binTree.Insert ( 11 );
            binTree.Insert ( 21 );
            binTree.Insert ( 11 );
            binTree.Insert ( 78 );
            binTree.Insert ( 11 );
            binTree.Insert ( 31 );
            binTree.Insert ( 11 );
            binTree.Insert ( 101 );
            binTree.Insert ( 11 );
            binTree.Insert ( 51 );
            binTree.Insert ( 11 );
            binTree.Insert ( 82 );
            binTree.Insert ( 11 );
            return binTree;
        }

       
      
    }
}
