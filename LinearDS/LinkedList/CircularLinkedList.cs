using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinearDS
{
    /// <summary>
    /// The circular linked list.
    /// </summary>
    public class CircularLinkedList<T> : ICircularLinkedList<T>
    {
        // |first| 1,2,3,4,5,6 |last| =>,..... 
        public DoubleLNode<T> FirstNode { get; private set; }
        // Last Is The Head 
        public DoubleLNode<T> LastNode { get; private set; }
        private bool _IsEmpty;

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleLinkedList"/> class.
        /// </summary>
        /// <param name="headVal">The head val.</param>
        public CircularLinkedList (T headVal) : this(new DoubleLNode<T>(value: headVal, next: null))
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DoupleLinkedList"/> class.
        /// </summary>
        /// <param name="head">The head.</param>
        public CircularLinkedList (DoubleLNode<T> head)
        {
            this.FirstNode = head;
            this.LastNode = head;
            this.FirstNode.Next = head;
            this.FirstNode.PrevNode = head;
        }

        /// <summary>
        /// Are the empty.
        /// </summary>
        /// <returns>A bool.</returns>
        public bool IsEmpty () { return FirstNode == null; }

        /// <summary>
        /// Adds the node.
        /// </summary>
        /// <param name="newNode">The new node.</param>
        public void AddNode (ILinkNode<T> newNode)
        {
            DoubleLNode<T> nnode = (DoubleLNode<T>)newNode;
            if (LastNode == null)
            {
                LastNode = nnode;
                FirstNode = LastNode;
            }
            else
            {
                nnode.Next = FirstNode;
                nnode.PrevNode = LastNode;
                nnode.PrevNode.Next = nnode;
                LastNode = nnode;
                FirstNode.PrevNode = nnode;
            }

            _IsEmpty = LastNode == null;
        }

        /// <summary>
        /// Adds the node.
        /// </summary>
        /// <param name="newNodeValue">The new node value.</param>
        public void AddNode (T newNodeValue)
        {
            DoubleLNode<T> n = new DoubleLNode<T>(newNodeValue);
            this.AddNode(n);
        }

        /// <summary>
        /// Deletes the node.
        /// </summary>
        public void DeleteNode ()
        {
            if (LastNode == FirstNode) {
                LastNode = null;
                FirstNode = null;
                _IsEmpty = true;
                return;
            }
            LastNode = LastNode.PrevNode;
            LastNode.Next = FirstNode;
            FirstNode.PrevNode = LastNode;

            if (LastNode == null)
            {
                _IsEmpty = true;
                FirstNode = null;
            }
        }

        /// <summary>
        /// Enumerates the.
        /// </summary>
        /// <returns>A list of ILinkNode.</returns>
        public IEnumerable<ILinkNode<T>> Enumerate ()
        {
            DoubleLNode<T> h = LastNode;
            while (h != null)
            {
                yield return h;
                if (h.PrevNode != LastNode)
                    h = h.PrevNode;
                else break;
            }
        }

        /// <summary>
        /// Gets the first element.
        /// </summary>
        /// <returns>A DoubleLNode.</returns>
        public DoubleLNode<T> GetFirstElement ()
        {
            return this.FirstNode;
        }

        /// <summary>
        /// Gets the last element.
        /// </summary>
        /// <returns>A DoubleLNode.</returns>
        public DoubleLNode<T> GetLastElement ()
        {
            return this.LastNode;
        }
    }
}
