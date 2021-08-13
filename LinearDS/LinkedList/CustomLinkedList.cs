using DataStructures.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.LinearDS
{
    /// <summary>
    /// single ref linked list. // QUEUE
    /// </summary>
    public class CustomLinkedList<T> : ILinkedList<T>
    {
        // 1,2,3,4,5,6 => .... head is 6 
        Node<T> Head;
        private bool _IsEmpty;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedList"/> class.
        /// </summary>
        /// <param name="head">The head.</param>
        public CustomLinkedList (Node<T> head)
        {
            this.Head = head;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLinkedList"/> class.
        /// </summary>
        /// <param name="headVal">The head val.</param>
        public CustomLinkedList (T headVal) : this(new Node<T>(value: headVal, next: null))
        {

        }


        /// <summary>
        /// Are the empty.
        /// </summary>
        /// <returns>A bool.</returns>
        public bool IsEmpty () { return Head == null; }
       

        /// <summary>
        /// Adds the node. as head
        /// </summary>
        /// <param name="newNode">The new node.</param>
        public void AddNode (ILinkNode<T> newNode)
        { // O(1)
            Node<T> n = (Node<T>)newNode;
            if (Head == null)
                Head = n;
            else
            {
                n.Next = Head;
                Head = n;
            }

            _IsEmpty = Head == null;
        }

        /// <summary>
        /// Adds the node.
        /// </summary>
        /// <param name="newNodeValue">The new node value.</param>
        public void AddNode (T newNodeValue)
        {
            Node<T> n = new Node<T>(newNodeValue);
            this.AddNode(n);
        }

        /// <summary>
        /// Deletes the head / first node.
        /// </summary>
        public virtual void DeleteNode ()
        { // O(1)
            Head = Head.Next;
            if (Head == null)
                _IsEmpty = true;
        }

        /// <summary>
        /// Gets the all.
        /// </summary>
        /// <returns>A list of Node.</returns>
        public IEnumerable<ILinkNode<T>> Enumerate ()
        {
            Node<T> h = Head;
            while (h!=null)
            {
                yield return h;
                h = h.Next;
            }
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <returns>An int of this list count.</returns>
        public int GetCount ()
        {
            return this._IsEmpty ? 0 : this.Enumerate().ToList().Count;
        }

        /// <summary>
        /// Contains the.
        /// </summary>
        /// <param name="seachFor">The seach for.</param>
        /// <returns>A bool.</returns>
        public bool Contains (T seachFor)
        {
            if (_IsEmpty)
                return false;
            else
            {
                Node<T> h = Head;
                while (h != null)
                {
                    if (h.Value.Equals(seachFor))
                        return true;
                    h = h.Next;
                }
                return false;
            }
        }
    }
}
