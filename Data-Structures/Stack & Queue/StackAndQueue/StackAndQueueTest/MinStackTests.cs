using System;
using Xunit;
using StackAndQueue;

namespace MinStackTests
{
    public class MinStackTests
    {
        [Fact]
        public void TestGetMin()
        {
            MinStack minStack = new MinStack();
            minStack.Push(10);
            minStack.Push(20);
            minStack.Push(5);
            Assert.Equal(5, minStack.GetMin());
        }

        [Fact]
        public void TestPopAndMin()
        {
            MinStack minStack = new MinStack();
            minStack.Push(10);
            minStack.Push(5);
            minStack.Push(7);
            minStack.Pop();
            Assert.Equal(5, minStack.GetMin());
        }

        [Fact]
        public void TestPushAndMin()
        {
            MinStack minStack = new MinStack();
            minStack.Push(10);
            minStack.Push(5);
            Assert.Equal(5, minStack.GetMin());
            minStack.Push(3);
            Assert.Equal(3, minStack.GetMin());
        }
    }
}
