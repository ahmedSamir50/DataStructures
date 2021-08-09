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
            StackLIFO<int> queueFIFO = new StackLIFO<int>(0);
            queueFIFO.Push(1);
            queueFIFO.Push(2);
            queueFIFO.Push(3);
            queueFIFO.PushAll(4 , 5 , 6);

            List<int> l = queueFIFO.DisplayAll().ToList();

            PrintElements(l);
            queueFIFO.Pop();
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
