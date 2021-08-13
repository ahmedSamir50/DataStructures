using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinearDS
{
    /// <summary>
    /// The stack LAST IN FIRST OUT.
    /// </summary>
    public class StackLIFO<T>
    {
        private T[] stackList;
        // => 1,2,3,4,5,6,7,8,9,10=> first to get out is 10 then 9 ,....
        // So Rear Is 0 , Front is Last Index
        public int RearIndex { get; private set; }
        public int FrontIndex { get; private set; }
        public int Size { get; private set; }

        /// <summary>
        /// Gets a value indicating whether is empty.
        /// </summary>
        public bool IsEmpty { get => this.FrontIndex == -1 || RearIndex > FrontIndex  ; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackLIFO"/> class.
        /// </summary>
        public StackLIFO (T firstElem)
        {
            this.Size = 1;
            this.stackList = new T[] { firstElem };
            this.RearIndex = 0;
            this.FrontIndex = 0;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="StackLIFO"/> class.
        /// </summary>
        public StackLIFO ()
        {
            this.Size = 0;
            this.stackList = new T[0];
            this.RearIndex = -1;
            this.FrontIndex = -1;
        }

        /// <summary>
        /// Add To the Stack.
        /// </summary>
        /// <param name="addElem">The add elem.</param>
        /// <returns>Added element</returns>
        public T Push (T addElem)
        {
            Size = stackList.Length + 1;
            T[] tempArr = new T[Size];
            Array.Copy(stackList, 0, tempArr, 0, stackList.Length);
            tempArr[^1] = addElem;
            stackList = tempArr;
                FrontIndex = tempArr.Length - 1;
            if (RearIndex == -1)
            RearIndex = 0;
            return tempArr[0];
        }

        /// <summary>
        /// Pushes N. number of elements to the stack all.
        /// </summary>
        /// <param name="allNewElements">The all new elements.</param>
        /// <returns>An IEnumerable.</returns>
        public IEnumerable<T> PushAll (params T[] allNewElements) {
            List<T> addedElms = new List<T>(); ;

            Size = stackList.Length + allNewElements.Length;
            T[] tempArr = new T[Size];
            Array.Copy(stackList, 0, tempArr, 0, stackList.Length);
            int fromLastCounter = allNewElements.Length+1;
            foreach (T toAddElem in allNewElements)
            {
                tempArr[^--fromLastCounter] = toAddElem;
                addedElms.Add(toAddElem);
            }
            stackList = tempArr;
            FrontIndex = tempArr.Length - 1;
            if (RearIndex == -1)
                RearIndex = 0;
            return addedElms;
        }

        /// <summary>
        /// remove form the Stack.
        /// </summary>
        /// <returns> removed element</returns>
        public T Pop ()
        {
            if (Size == 0)
                throw new Exception("Stack Is Empty");
            Size = stackList.Length;
            --Size;
            T[] tempArr = new T[Size];
            T removed = stackList[^1];
            Array.Copy(stackList, 0, tempArr, 0, stackList.Length - 1);
            stackList = tempArr;
            FrontIndex = Size-1;
            if (Size == 0)
            RearIndex =  - 1;
            return removed;
        }

        /// <summary>
        /// Get The Next Head Element.
        /// </summary>
        /// <returns>Element of Type this Stack Type</returns>
        public T JustPeek () {
            if (Size == 0)
                throw new Exception("Stack Is Empty");
            return stackList[^1];
           
        }

        /// <summary>
        /// Displays the all.
        /// </summary>
        /// <returns>A list of TS.</returns>
        public IEnumerable<T> DisplayAll ()
        {
            foreach (T item in stackList)
            {
                yield return item;
            }
        }

    }

    /// <summary>
    /// dynamic type stack for non generic usage
    /// </summary>
    public class StackLIFO : StackLIFO<object> { }
}
