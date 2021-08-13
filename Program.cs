using DataStructures.LinearDS;
using System;
using System.Linq;
using System.Collections.Generic;
using DataStructures.Trees;
using DataStructures.Types;

namespace DataStructures
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Hello World!");
            // Linked List 
            BinaryTree<char> bTree = new BinaryTree<char>();
            TreeNode<char> rootNode = new TreeNode<char>('A');
            bTree.AddNode(rootNode);
            bTree.AddNode(new TreeNode<char>('C'), rootNode);
            bTree.AddNode(new TreeNode<char>('B'), rootNode);
            bTree.AddNode(new TreeNode<char>('d'), rootNode);
            bTree.AddNode(new TreeNode<char>('b'));
            bTree.AddNode(new TreeNode<char>('f'));
            bTree.AddNode(new TreeNode<char>('F'), rootNode);
            bTree.AddNode(new TreeNode<char>('g'));
            bTree.AddNode(new TreeNode<char>('h'));
            bTree.AddNode(new TreeNode<char>('i'));


            bool hasOne = bTree.Contains('G');
            TreeNode<char> x_C = bTree.GetFirstTreeNodeByVal('C');
            TreeNode<char> x_d = bTree.GetFirstTreeNodeByVal('d');

            Console.WriteLine(hasOne);
            Console.WriteLine(x_C.Left.Value);
            Console.WriteLine(x_C.Right.Value);

            Console.WriteLine(x_d.Left.Value);
            Console.WriteLine(x_d.Right.Value);
            Console.ReadLine();
        }

        /// <summary>
        /// Prints the elements.
        /// </summary>
        /// <param name="l">The l.</param>
        private static void PrintElements<T> (List<T> l)
        {
            l.ForEach((node) => Console.WriteLine("Elem: " + node));
        }
    }
}
