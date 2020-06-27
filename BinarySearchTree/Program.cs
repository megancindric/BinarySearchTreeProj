using System;
using System.Dynamic;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BSTree myTree = new BSTree();
            myTree.AddNode(5);
            myTree.AddNode(2);
            myTree.AddNode(9);
            myTree.AddNode(7);
            myTree.AddNode(1);
            myTree.AddNode(8);
            myTree.AddNode(10);
            Console.WriteLine(myTree.Search(7));
            Console.WriteLine(myTree.Search(4));
            Console.ReadLine();   
        }
    }
}
