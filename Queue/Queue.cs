using System;
using System.Collections.Generic;

namespace basics.Collections
{
    internal class Queue
    {
        
        private Queue<int> queue = new Queue<int>();
        public void Enqueue(int data)
        {
            queue.Enqueue(data);
        }
        public void Print()
        {
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Reverse()
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
    }
}
