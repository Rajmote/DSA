using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Trees
{
    public static class TraversingTree<T>
    {
        public static void TraversePreOrder(BinaryTreeNode<T> node,List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                result.Add(node);
                TraversePreOrder(node.Left, result);
                TraversePreOrder(node.Right, result);
            }
        }

        public static void TraverseInOrder(BinaryTreeNode<T> node,List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, result);
                result.Add(node);
                TraverseInOrder(node.Right, result);
            }
        }

        public static void TraversePostOrder(BinaryTreeNode<T> node,List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraversePostOrder(node.Left, result);
                TraversePostOrder(node.Right, result);
                result.Add(node);
            }
        }

        //public static List<BinaryTreeNode<T>> Traverse(TraversalEnum mode)
        //{
        //    List<BinaryTreeNode<T>> nodes = new List<BinaryTreeNode<T>>();
        //    switch (mode)
        //    {
        //        case TraversalEnum.PREORDER:
        //            TraversePreOrder(Root, nodes);
        //            break;
        //        case TraversalEnum.INORDER:
        //            TraverseInOrder(Root, nodes);
        //            break;
        //        case TraversalEnum.POSTORDER:
        //            TraversePostOrder(Root, nodes);
        //            break;
        //    }
        //    return nodes;
        //}
    }

    //public enum TraversalEnum
    //{
    //    PREORDER,
    //    INORDER,
    //    POSTORDER
    //}
}
