using System;

namespace StackAndQueue
{
    public class Queue
    {
        private Node front;
        private Node tail;

        public Queue()
        {
            front = tail = null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (tail == null)
            {
                front = tail = newNode;
                return;
            }

            tail.Next = newNode;
            tail = newNode;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            int data = front.Data;
            front = front.Next;

            if (front == null)
            {
                tail = null;
            }

            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return front.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public void PrintQueue()
        {
            Node current = front;
            Console.Write("Queue: ");
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

}
