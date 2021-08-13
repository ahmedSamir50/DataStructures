using DataStructures.LinearDS;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DataStructures.Types
{
    /// <summary>
    /// The tree node.
    /// </summary>
    public class TreeNode<T> : ILinkNode<T> , IEquatable<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeNode"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public TreeNode (T value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeNode"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="leftNode">The left node.</param>
        public TreeNode (T value, TreeNode<T> leftNode)
        {
            this.Value = value;
            this.Left = leftNode;
            this.Right = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeNode"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="leftNode">The left node.</param>
        /// <param name="rightNode">The right node.</param>
        public TreeNode (T value, TreeNode<T> leftNode, TreeNode<T> rightNode)
        {
            this.Value = value;
            this.Left = leftNode;
            this.Right = rightNode;
        }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public T Value { get; set; }
        /// <summary>
        /// Gets or sets the left.
        /// </summary>
        public TreeNode<T> Left { get; set; }
        /// <summary>
        /// Gets or sets the right.
        /// </summary>
        public TreeNode<T> Right { get; set; }


        /// <summary>
        /// Compares the.
        /// </summary>
        /// <param name="a">The a.</param>
        /// <param name="b">The b.</param>
        /// <returns>An int.</returns>
        private static int Compare (T a, T b )
        {
            Comparer<T> comparer = Comparer<T>.Default;
            int compared = comparer.Compare(a, b);
            return compared ;
        }

        // true if a > b 
        /// <summary>
        /// Are the bigger than.
        /// </summary>
        /// <param name="a">The a. main comparing member </param>
        /// <param name="b">The b. second / other comparing member </param>
        /// <returns>A boolean</returns>
        public static bool IsBiggerThan (  T a, T b) { return Compare(a, b)>=1; }

        private static bool IsEqualTo ( T a, T b) { return Compare(a, b)==0; }

        /// <summary>
        /// true if a < b
        /// </summary>
        /// <param name="a">The a. main comparing member</param>
        /// <param name="b">The b. second / other comparing member</param>
        /// <returns>A boolean</returns>
        public static bool IsLessThan ( T a, T b) { return Compare(a, b)<=-1; }

        public bool Equals (T other)
        {
            return IsEqualTo( this.Value , other);
        }

        // An override of Equals(Object).
        public override bool Equals (Object obj)
        {
            if (obj is TreeNode<T> node)
                return Equals(node);
            return false;
        }
    }



}
