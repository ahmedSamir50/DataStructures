using DataStructures.LinearDS;

namespace DataStructures.Types
{
    /// <summary>
    /// The double liked node.
    /// </summary>
    public class DoubleLNode<T> : ILinkNode<T>
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public T Value { get; set; }
        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        public DoubleLNode<T> Next { get; set; }
        /// <summary>
        /// Gets or sets the prev node.
        /// </summary>
        public DoubleLNode<T> PrevNode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleLNode"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="next">The next.</param>
        /// <param name="prev">The prev.</param>
        public DoubleLNode (T value, DoubleLNode<T> next, DoubleLNode<T> prev) : this(value, next)
        {
            this.PrevNode = prev;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleLNode"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="next">The next.</param>
        public DoubleLNode (T value, DoubleLNode<T> next) : this(value)
        {
            this.Next = next;
            this.PrevNode = null;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleLNode"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public DoubleLNode (T value) 
        {
            this.Value = value;
            this.PrevNode = null;
            this.Next = null;
        }


    }
}
