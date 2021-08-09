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
            FixedLengthQueueFIFO<int> queueFIFO = new FixedLengthQueueFIFO<int>(6);
            queueFIFO.EnQueue(1);
            queueFIFO.EnQueue(2);
            queueFIFO.EnQueue(3);
            queueFIFO.EnQueue(4);
            queueFIFO.EnQueue(5);
            queueFIFO.EnQueue(6);
            List<int> l = queueFIFO.DisplayAll().ToList();
            queueFIFO.DeQueue();
           
            l.ForEach((node) =>
            {
                Console.WriteLine("Elem: "+node);
                //lList.DeleteNode();
            });

            Console.ReadLine();
        }
    }
}
