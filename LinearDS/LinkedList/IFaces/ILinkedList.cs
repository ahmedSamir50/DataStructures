using System.Collections.Generic;

namespace DataStructures.LinearDS
{
    /// <summary>
    /// The linked list.
    /// </summary>
    public interface ILinkedList<T> {
        /// <summary>
        /// Adds the node.
        /// </summary>
        /// <param name="newNode">The new node.</param>
        public  void AddNode (ILinkNode<T> newNode);

        public  void AddNode (T newNode);
        /// <summary>
        /// Deletes the node.
        /// </summary>
        public void DeleteNode ();

        /// <summary>
        /// Enumerates the.
        /// </summary>
        /// <returns>A list of ILinkNode.</returns>
        public  IEnumerable<ILinkNode<T>> Enumerate();
    }
}
