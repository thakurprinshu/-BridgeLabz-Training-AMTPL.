using System;
using System.Collections.Generic;

namespace basics.Collections
{
    internal class LinkedList
    {
      
        private LinkedList<int> list = new LinkedList<int>();

        public void Add(int data)
        {
            list.AddLast(data);
        }

        
        public void Print()
        {
            foreach (var item in list)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine("null");
        }

        public void Reverse()
        {
            LinkedList<int> reversed = new LinkedList<int>();

            foreach (var item in list)
            {
                reversed.AddFirst(item); 
            }

            list = reversed; 
        }
    }
}
