using DataStructures.Types;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.LinearDS
{
    /// <summary>
    /// The double linked list.
    /// </summary>
    public class DoubleLinkedList<T>: ILinkedList<T>
    {
        DoubleLNode<T> HeadNode;
        private bool _IsEmpty;

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleLinkedList"/> class.
        /// </summary>
        /// <param name="headVal">The head val.</param>
        public DoubleLinkedList (T headVal) : this(new DoubleLNode<T>(value: headVal, next: null))
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DoupleLinkedList"/> class.
        /// </summary>
        /// <param name="head">The head.</param>
        public DoubleLinkedList (DoubleLNode<T> head)
        {
            this.HeadNode = head;
            this.HeadNode.Next = null;
            this.HeadNode.PrevNode = null;
        }

        /// <summary>
        /// Are the empty.
        /// </summary>
        /// <returns>A bool.</returns>
        public bool IsEmpty () { return HeadNode == null; }

        /// <summary>
        /// Adds the node.
        /// </summary>
        /// <param name="newNode">The new node.</param>
        public void AddNode (ILinkNode<T> newNode)
        {
            DoubleLNode<T> nnode = (DoubleLNode<T>)newNode;
            if (HeadNode == null)
                HeadNode = nnode;
            else
            {
                nnode.Next = null;
                nnode.PrevNode = HeadNode;
                nnode.PrevNode.Next = nnode;
                HeadNode = nnode;
            }

            _IsEmpty = HeadNode == null;
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
            HeadNode = HeadNode.PrevNode;
            if (HeadNode != null)
                HeadNode.Next = null;
            if (HeadNode == null)
                _IsEmpty = true;
        }

        /// <summary>
        /// Enumerates the.
        /// </summary>
        /// <returns>A list of ILinkNode.</returns>
        public IEnumerable<ILinkNode<T>> Enumerate ()
        {
            DoubleLNode<T> h = HeadNode;
            while (h != null)
            {
                yield return h;
                h = h.PrevNode;
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
                DoubleLNode<T> h = HeadNode;
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
