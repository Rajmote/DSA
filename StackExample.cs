using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class HanoiTower
    {
        public int DiscsCount { get; private set; }
        public int MovesCount { get; private set; }
        public Stack<int> From { get; private set; }
        public Stack<int> To { get; private set; }
        public Stack<int> Auxiliary { get; private set; }
        public event EventHandler<EventArgs> MoveCompleted;
    }
    public static class StackExample
    {

        public static void RunStackExample()
        {
            //Stack<char> chars = new Stack<char>();
            //foreach (char c in "LET'S REVERSE!")
            //{
            //    chars.Push(c);
            //}
            //foreach (char c in chars)
            //{
            //    Console.WriteLine(c);
            //}
            //while (chars.Count > 0)
            //{
            //    Console.Write(chars.Pop());
            //}
            //Console.WriteLine();



        }
    }
}
