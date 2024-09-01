using StackAndQueue;
namespace StackAndQueueTest
{
    public class StackTest
    {
        [Fact]
        public void Push_ShouldAddNodeToTopOfStack()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push(10);
            stack.Push(5);

            // Assert
            Assert.Equal(5, stack.Peek());
        }

        [Fact]
        public void Pop_ShouldRemoveAndReturnTopNodeFromStack()
        {
            // Arrange
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(5);

            // Act
            int poppedValue = stack.Pop();

            // Assert
            Assert.Equal(5, poppedValue);
            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void IsEmpty_ShouldReturnTrueWhenStackIsEmpty()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            bool isEmpty = stack.IsEmpty();

            // Assert
            Assert.True(isEmpty);
        }

        [Fact]
        public void IsEmpty_ShouldReturnFalseWhenStackIsNotEmpty()
        {
            // Arrange
            Stack stack = new Stack();
            stack.Push(10);

            // Act
            bool isEmpty = stack.IsEmpty();

            // Assert
            Assert.False(isEmpty);
        }
    }
}