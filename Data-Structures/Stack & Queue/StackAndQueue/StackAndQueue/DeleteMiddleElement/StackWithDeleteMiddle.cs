using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.DeleteMiddleElement
{
    public class StackWithDeleteMiddle : Stack
    {
        public void DeleteMiddle()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            // Calculate the middle index
            int count = GetCount();
            int middleIndex = count / 2;

            // If the stack has an even number of elements, remove the lower middle element
            if (count % 2 == 0)
            {
                middleIndex--;
            }

            //Console.WriteLine($"Middle Index: {middleIndex}");

            // Use an additional stack to hold elements temporarily
            Stack tempStack = new Stack();

            // Pop elements until reaching the middle
            for (int i = 0; i < middleIndex; i++)
            {
                tempStack.Push(this.Pop());
            }

            // Remove the middle element
            this.Pop();

            // Push the held elements back onto the original stack
            while (!tempStack.IsEmpty())
            {
                this.Push(tempStack.Pop());
            }
        }

        private int GetCount()
        {
            int count = 0;
            Node current = top;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }
}