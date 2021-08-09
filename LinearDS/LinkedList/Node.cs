namespace DataStructures.LinearDS
{
    /// <summary>
    /// a single ref node.
    /// </summary>
    public class Node<T> : ILinkNode<T>
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public T Value { get; set; }
        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        public Node<T> Next { get; set; }
        /// <summary>Record Constructor</summary>
        /// <param name="value"><see cref="Value"/></param>
        /// <param name="next"><see cref="Next"/></param>
        public Node (T value, Node<T> next)
        {
            Value = value;
            Next = next;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public Node (T value) : this(value, null)
        {    
        }
    }
}
