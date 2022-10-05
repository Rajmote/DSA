using DSA.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DSA.Trees
    {
    public class QuizItem
        {
        public string Text { get; set; }
        public QuizItem ( string text ) => Text = text;
        }
    public class QuizTree
        {
        public static void Main ( string[] args )
            {
            BinaryTree<QuizItem> tree = GetTree();
            BinaryTreeNode<QuizItem> node = tree.Root;
            while ( node != null )
                {
                if ( node.Left != null || node.Right != null )
                    {
                    Console.Write ( node.Data.Text );
                    switch ( Console.ReadKey ( true ).Key )
                        {
                        case ConsoleKey.Y:
                            WriteAnswer ( " Yes" );
                            node = node.Left;
                            break;
                        case ConsoleKey.N:
                            WriteAnswer ( " No" );
                            node = node.Right;
                            break;
                        }
                    }
                else
                    {
                    WriteAnswer ( node.Data.Text );
                    node = null;
                    }
                }
            }

        public static void WriteAnswer ( string text )
            {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine ( text );
            Console.ForegroundColor = ConsoleColor.Gray;
            }

        public static BinaryTree<QuizItem> GetTree ( )
            {
            BinaryTree<QuizItem> tree = new BinaryTree<QuizItem>();

            tree.Root = new BinaryTreeNode<QuizItem> ()
                {
                Data = new QuizItem ( "Do you have experience in developing applications ? " ),

                Children = new List<TreeNode<QuizItem>> ()
                {
                    new BinaryTreeNode<QuizItem>()
                    {

                      Data = new QuizItem("Have you worked as adeveloper for more than 5 years ? "),

                      Children = new List<TreeNode<QuizItem>>()
                      {
                          new BinaryTreeNode<QuizItem>(){  Data = new QuizItem("Apply as a seniordeveloper!") },
                          new BinaryTreeNode<QuizItem>()
                          {
                            Data = new QuizItem("Apply as a middle[ 163 ]developer!")
                          }
                      }
                    },
                    new BinaryTreeNode<QuizItem>()
                    {
                        Data = new QuizItem("Have you completed the university?"),
                        Children = new List<TreeNode<QuizItem>>()
                        {
                            new BinaryTreeNode<QuizItem>()
                        {
                            Data = new QuizItem("Apply for a juniordeveloper!")
                            },
                            new BinaryTreeNode<QuizItem>()
                            {
                              Data = new QuizItem("Will you find sometime during the semester?"),
                              Children = new List<TreeNode<QuizItem>>()
                              {
                                new BinaryTreeNode<QuizItem>()
                                {
                                    Data = new QuizItem("Apply for ourlong-time internship program!")
                                },
                                new BinaryTreeNode<QuizItem>()
                                {
                                    Data = new QuizItem("Apply forsummer internship program!")
                                }
                              }
                            }
                        }
                    }
                }
                };
            tree.Count = 9;
            return tree;
            }
        }



    }
