using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.ReverseStackUsingQueue
{

    public class StackWithReverse : Stack
    {
        public void ReverseStack()
        {
            if (IsEmpty() || top.Next == null)
            {
                return;
            }

            Queue<int> queue = new Queue<int>();

            // Pop elements from stack and enqueue them into the queue
            while (!IsEmpty())
            {
                queue.Enqueue(Pop());
            }

            // Dequeue elements from queue and push them back to the stack
            while (queue.Count > 0)
            {
                Push(queue.Dequeue());
            }
        }
    }
}
