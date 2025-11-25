using System;
using System.Collections.Generic;

namespace basics.Collections
{
    internal class LinkedList
    {
        private LinkedList<int> list = new LinkedList<int>();

        // Add element
        public void Add(int data)
        {
            list.AddLast(data);
        }

        // Print list
        public void Print()
        {
            foreach (var item in list)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine("null");
        }

        // Find middle using slow–fast pointer
        public int FindMiddle()
        {
            if (list.First == null)
                throw new InvalidOperationException("LinkedList is empty");

            LinkedListNode<int> slow = list.First;
            LinkedListNode<int> fast = list.First;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;      // move slow by 1
                fast = fast.Next.Next; // move fast by 2
            }

            return slow.Value;         // slow is now at middle
        }

        // Main method inside same file
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();

            ll.Add(10);
            ll.Add(20);
            ll.Add(30);
            ll.Add(40);
            ll.Add(50);

            Console.WriteLine("Linked List:");
            ll.Print();

            Console.WriteLine("\nMiddle Element: " + ll.FindMiddle());
        }
    }
}
