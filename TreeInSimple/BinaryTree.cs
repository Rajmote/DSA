using DSA.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.TreeInSimple
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public bool Insert ( int value )
        {
            Node newNode = new Node();
            newNode.Data = value;

            if ( Root == null )//Tree ise empty
            {
                Root = newNode;
            }
            else
            {
                var current = Root;
                Node Parent;
                while ( true )
                {
                    Parent = current;
                    if ( current.Data > newNode.Data )
                    {
                        current = current.LtNode;
                        if ( current == null )
                        {
                            Parent.LtNode = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.RtNode;
                        if ( current == null )
                        {
                            Parent.RtNode = newNode;
                            break;
                        }
                    }
                }
            }
            return true;
        }

        public Node Search ( int value )
        {
            return this.Search ( value, this.Root );
        }
        private Node Search ( int value, Node parent )
        {
            if ( parent != null )
            {
                if ( value == parent.Data )
                {
                    return parent;
                }

                if ( value < parent.Data )
                {
                    return Search ( value, parent.LtNode );
                }
                else
                {
                    return Search ( value, parent.RtNode );
                }
            }
            return null;
        }


        public void Delete ( int value )
        {
            this.Root = Delete ( this.Root, value );
        }

        private Node Delete ( Node parent, int key )
        {
            if ( parent == null )
            {
                return parent;
            }

            if ( key < parent.Data )
            {
                parent.LtNode = Delete ( parent.LtNode, key );
            }
            else if ( key > parent.Data )
            {
                parent.RtNode = Delete ( parent.RtNode, key );
            } // if the value is the same as the parent's value, then this node is to be deleted  
            else
            {
                // the node with one or no child  
                if ( parent.LtNode == null )
                {
                    return parent.RtNode;
                }
                else if ( parent.RtNode == null )
                {
                    return parent.LtNode;
                }

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Data = MinValue ( parent.RtNode );
                // Delete the inorder successor  
                parent.RtNode = Delete ( parent.RtNode, parent.Data );

            }

            return parent;

        }


        private int MinValue ( Node node )
        {
            int minv = node.Data;

            while ( node.LtNode != null )
            {
                minv = node.LtNode.Data;

                node = node.LtNode;
            }

            return minv;
        }


        public int GetDepth ( )
        {
            return this.GetDepth ( this.Root );
        }

        private int GetDepth ( Node parent )
        {
            return parent == null ? 0 : Math.Max ( GetDepth ( parent.LtNode ), GetDepth ( parent.RtNode ) ) + 1;
        }



        public void PreOrder ( Node parent )
        {
            if ( parent != null )
            {
                Console.Write ( parent.Data + " " );
                PreOrder ( parent.LtNode );
                PreOrder ( parent.RtNode );
            }
        }

        public void InOrder ( Node parent )
        {
            if ( parent != null )
            {
                InOrder ( parent.LtNode );
                Console.Write ( parent.Data + " " );
                InOrder ( parent.RtNode );
            }
        }

        public void PostOrder ( Node parent )
        {
            if ( parent != null )
            {
                PostOrder ( parent.LtNode );
                PostOrder ( parent.RtNode );
                Console.Write ( parent.Data + " " );
            }
        }
    }
}
