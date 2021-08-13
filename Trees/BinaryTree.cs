using DataStructures.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    
    /// <summary>
    /// The binary tree.
    /// </summary>
    public class BinaryTree<T> where T : IComparable<T>
    {
        /// <summary>
        /// Gets the tree root.
        /// </summary>
        public TreeNode<T> TreeRoot { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the tree is empty.
        /// </summary>
        public bool IsEmpty { get=>TreeRoot == null;}
        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryTree"/> class.
        /// </summary>
        public BinaryTree ()
        {
            this.TreeRoot = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryTree"/> class.
        /// </summary>
        /// <param name="root">The root.</param>
        public BinaryTree (TreeNode<T> root) {
            this.TreeRoot = root;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryTree"/> class.
        /// </summary>
        /// <param name="root">The root.</param>
        public BinaryTree (T root):this(new TreeNode<T>(root))
        {
        }


        /// <summary>
        /// Contains the.
        /// </summary>
        /// <param name="seachFor">The search for.</param>
        /// <returns>A bool.</returns>
        public bool Contains (T searchFor)
        {
            if (IsEmpty)
                return false;
            else
            {
                TreeNode<T> h = TreeRoot;
                while (h != null)
                {
                    if (h.Value.Equals(searchFor))
                        return true;
                    if (!TreeNode<T>.IsBiggerThan(h.Value, searchFor) )
                        h = h.Right;
                    else
                        h = h.Left;
                }
                return false;
            }
        }

        /// <summary>
        /// Gets the first tree node by val.
        /// </summary>
        /// <param name="seachFor">The search for.</param>
        /// <returns>A TreeNode.</returns>
        public TreeNode<T> GetFirstTreeNodeByVal (T searchFor) {
            if (IsEmpty)
                return null;
            else
            {
                TreeNode<T> h = TreeRoot;
                while (h != null)
                {
                    if (h.Value.Equals(searchFor))
                        return h;
                    if (TreeNode<T>.IsBiggerThan(h.Value, searchFor))
                        h = h.Left;
                    else
                        h = h.Right;
                }
                return null;
            }
        }

        /// <summary>
        /// Adds the node.
        /// </summary>
        /// <param name="newNode">The new node.</param>
        /// <param name="rootNode">The root node.</param>
        /// <returns>A TreeNode.</returns>
        public TreeNode<T> AddNode (TreeNode<T> newNode, TreeNode<T> rootNode)
        {
            if (!Contains(rootNode.Value)) return null;

            bool small = TreeNode<T>.IsLessThan(rootNode.Value, newNode.Value);

            if (TreeNode<T>.IsBiggerThan(rootNode.Value, newNode.Value))
            {
                TreeNode<T> tempLeft = rootNode.Left;
                if (tempLeft == null)
                {
                    rootNode.Left = newNode;
                    return newNode;
                }
                else
                {
                   return AddNode(newNode, tempLeft);
                }
            }
            else {
                TreeNode<T> tempRight = rootNode.Right;
                if (tempRight == null )
                {
                    rootNode.Right = newNode;
                    return newNode;
                }
                else
                {
                   return AddNode(newNode, tempRight);
                }
            }
               // return newNode;
        }

        /// <summary>
        /// Adds the node.
        /// </summary>
        /// <param name="newNode">The new node.</param>
        /// <param name="rootNode">The root node.</param>
        /// <returns>A TreeNode.</returns>
        public TreeNode<T> AddNode (TreeNode<T> newNode)
        {
            if (IsEmpty)
            {
                this.TreeRoot = newNode;
                return newNode;
            }

            return this.AddNode(newNode, this.TreeRoot);
           
        }
    }
}
