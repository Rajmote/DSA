using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Trees
{
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        public BinaryTreeNode()
        {
            Children = new List<TreeNode<T>>() { null, null };
        }

        public BinaryTreeNode<T> Left
        {
            get { return (BinaryTreeNode<T>)Children[0]; }
            set { Children[0] = value; }
        }
        public BinaryTreeNode<T> Right
        {
            get { return (BinaryTreeNode<T>)Children[1]; }
            set { Children[1] = value; }
        }

        //public int GetHeight()
        //{
        //    int height = 0;
        //    foreach (BinaryTreeNode<T> node  in Traverse(TraversalEnum.PREORDER))
        //    {
        //        height = Math.Max(height, node.GetHeight());
        //    }
        //    return height;
        //}
    }
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }
        public int Count { get; set; }
    }
}
