using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Trees
{
    public static class EmployeeTree
    {

        public static void RunEmployeeTree()
        {
            Tree<Employee> emplyeeTree = new Trees.Tree<Employee>();
            emplyeeTree.Root = new TreeNode<Employee>() { Data = new Employee() { Id = 1, Name = "Raj", Rank = "Architech" } };
            emplyeeTree.Root.Children = new List<TreeNode<Employee>>()
            {
               new TreeNode<Employee>(){ Data=new Employee() { Id = 1, Name = "Raj", Rank = "Architech" },Parent=emplyeeTree.Root },
               new TreeNode<Employee>(){ Data= new Employee(){ Id = 2, Name = "Shubh", Rank = "Tester" },Parent=emplyeeTree.Root },
               new TreeNode<Employee>(){ Data= new Employee(){Id = 2, Name = "Ram", Rank = "Dev" },Parent=emplyeeTree.Root }
            };
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
    }
}
