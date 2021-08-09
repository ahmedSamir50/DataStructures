using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinearDS
{
    /// <summary>
    /// The queue FIFO.
    /// </summary>
    public class DynamicLengthQueueFIFO<T>
    {
        // FROM REARE TO FRONT
        private T[] FiFoQueueList;
        public int RearIndex { get; private set; }
        public int FrontIndex { get; private set; }
        public int Size { get; private set; }

        /// <summary>
        /// Gets a value indicating whether is empty.
        /// </summary>
        public bool IsEmpty { get => this.FrontIndex == -1 || FrontIndex > RearIndex; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueFIFO"/> class.
        /// </summary>
        public DynamicLengthQueueFIFO (T firstElem)
        {
            this.Size = 1;
            this.FiFoQueueList = new T[] { firstElem};
            this.RearIndex = 0;
            this.FrontIndex = 0;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueFIFO"/> class.
        /// </summary>
        public DynamicLengthQueueFIFO ()
        {
            this.Size = 0;
            this.FiFoQueueList = new T[0];
            this.RearIndex = -1;
            this.FrontIndex = -1;
        }

        /// <summary>
        /// Ins the queue.
        /// </summary>
        /// <param name="addElem">The add elem.</param>
        /// <returns>A T.</returns>
        public T EnQueue (T addElem)
        {
            Size = FiFoQueueList.Length +1 ;
            T[] tempArr = new T[Size];
            Array.Copy(FiFoQueueList,0, tempArr,1, FiFoQueueList.Length);
            tempArr[0] = addElem;
            FiFoQueueList = tempArr;
            RearIndex = tempArr.Length-1;
            if (FrontIndex == -1)
                FrontIndex = 0;
            return tempArr[0];
        }

        /// <summary>
        /// Ins the queue.
        /// </summary>
        /// <param name="addElem">The add elem.</param>
        /// <returns>A T.</returns>
        public T DeQueue ()
        {
            if (Size == 0)
                throw new Exception("Queue Is Empty");
            Size = FiFoQueueList.Length ;
            --Size;
            T[] tempArr = new T[Size];
            T removed = FiFoQueueList[0];
            Array.Copy(FiFoQueueList,1 ,tempArr,0, FiFoQueueList.Length-1);
            FiFoQueueList = tempArr;
            RearIndex = tempArr.Length-1;
            if (Size == 0)
                FrontIndex = -1;
            return removed;
        }

        /// <summary>
        /// Displays the all.
        /// </summary>
        /// <returns>A list of TS.</returns>
        public IEnumerable<T> DisplayAll () {
            foreach (T item in FiFoQueueList)
            {
                yield return item;
            }
        }
    }

    /// <summary>
    /// The fixed length queue f i f o.
    /// </summary>
    public class FixedLengthQueueFIFO<T>
    {
        // FROM REARE TO FRONT
        private T[] FiFoQueueList;
        /// <summary>
        /// Gets the rear index.
        /// </summary>
        public int RearIndex { get; private set; }
        /// <summary>
        /// Gets the front index.
        /// </summary>
        public int FrontIndex { get; private set; }
        /// <summary>
        /// Gets the Size.
        /// </summary>
        public int Size { get; private set; }

        /// <summary>
        /// Gets a value indicating whether is full.
        /// </summary>
        public bool IsFull { get => this.RearIndex == this.Size; }
        /// <summary>
        /// Gets a value indicating whether is empty.
        /// </summary>
        public bool IsEmpty { get => this.FrontIndex == -1 || FrontIndex > RearIndex; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueFIFO"/> class.
        /// </summary>
        public FixedLengthQueueFIFO (int qSize)
        {
            this.Size = qSize;
            this.FiFoQueueList = new T[qSize] ;
            this.RearIndex = -1;
            this.FrontIndex = -1;
        }


        /// <summary>
        /// Ins the queue.
        /// </summary>
        /// <param name="addElem">The add elem.</param>
        /// <returns>A T.</returns>
        public T EnQueue (T addElem)
        {
            if (IsFull)
                throw new Exception("Queue reached Full State");
            Size = FiFoQueueList.Length;
            FiFoQueueList[++RearIndex] = addElem;
            if (FrontIndex == -1)
                FrontIndex = 0;
            return FiFoQueueList[RearIndex];
        }

        /// <summary>
        /// Ins the queue.
        /// </summary>
        /// <param name="addElem">The add elem.</param>
        /// <returns>Removed Element </returns>
        public T DeQueue ()
        {
            if (IsEmpty)
                return default;
            T removed = FiFoQueueList[RearIndex];
            FiFoQueueList[RearIndex] = default;
            --RearIndex;
            if (RearIndex == -1)
                FrontIndex = -1;
            return removed;
        }

        /// <summary>
        /// Displays the all.
        /// </summary>
        /// <returns>A list of TS.</returns>
        public IEnumerable<T> DisplayAll ()
        {
            foreach (T item in FiFoQueueList)
            {
                yield return item;
            }
        }
    }
}
