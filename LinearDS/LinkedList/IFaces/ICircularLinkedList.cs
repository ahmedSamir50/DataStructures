namespace DataStructures.LinearDS
{
    /// <summary>
    /// The circular linked list.
    /// </summary>
    public interface ICircularLinkedList<T>:ILinkedList<T>{
        /// <summary>
        /// Gets the first element.
        /// </summary>
        /// <returns>A DoubleLNode.</returns>
        DoubleLNode<T> GetFirstElement ();
        /// <summary>
        /// Gets the last element.
        /// </summary>
        /// <returns>A DoubleLNode.</returns>
        DoubleLNode<T> GetLastElement ();
    }
}
