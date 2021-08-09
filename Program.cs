using DataStructures.LinearDS;
using System;
using System.Linq;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Hello World!");
            // Linked List 
            DynamicLengthQueueFIFO<int> queueFIFO = new DynamicLengthQueueFIFO<int>(0);
            queueFIFO.EnQueue(1);
            queueFIFO.EnQueue(2);
            queueFIFO.EnQueue(3);
            queueFIFO.EnQueue(4);
            queueFIFO.EnQueue(5);
            queueFIFO.EnQueue(6);
            List<int> l = queueFIFO.DisplayAll().ToList();

            PrintElements(l);
            queueFIFO.DeQueue();
            PrintElements(queueFIFO.DisplayAll().ToList());
            Console.ReadLine();
        }

        /// <summary>
        /// Prints the elements.
        /// </summary>
        /// <param name="l">The l.</param>
        private static void PrintElements<T> (List<T> l)
        {
            l.ForEach((node) => Console.WriteLine("Elem: " + node));
        }
    }
}
