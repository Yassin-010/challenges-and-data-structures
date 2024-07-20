using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        // Add a node to linked list
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Add a node to First
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        // Check if the linked list contains a specified node
        public bool Includes(int data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        // Remove node 
        public void Remove(int data)
        {
            if (head == null)
            {
                return;
            }

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        // Print All nodes
        public void PrintList()
        {
            Node current = head;
            Console.Write("Head -> ");
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }



        // Remove duplicate nodes from the linked list
        public void RemoveDuplicate()
        {
            try
            {
                Node current = head;
                while (current != null)
                {
                    Node previous = current;
                    Node index = current.Next;
                    while (index != null)
                    {
                        if (current.Data == index.Data)
                        {
                            previous.Next = index.Next;
                        }
                        else
                        {
                            previous = index;
                        }
                        index = index.Next;
                    }
                    current = current.Next;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        // Get the occurrences of a node
        public int GetOccurrences(int data)
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    count++;
                }
                current = current.Next;
            }
            return count;
        }

        // Get the total number of nodes
        public int GetNodeCount()
        {
            int nodeCount = 0;
            Node currentNode = head;
            while (currentNode != null)
            {
                nodeCount++;
                currentNode = currentNode.Next;
            }
            return nodeCount;
        }


    }

}
