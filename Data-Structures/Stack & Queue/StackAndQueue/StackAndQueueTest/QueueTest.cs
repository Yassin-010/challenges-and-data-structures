using StackAndQueue;

namespace StackAndQueueTest
{
    public class QueueTest
    {
        [Fact]
        public void Enqueue_ShouldAddNodeToEndOfQueue()
        {
            // Arrange
            Queue queue = new Queue();

            // Act
            queue.Enqueue(10);
            queue.Enqueue(5);

            // Assert
            Assert.Equal(10, queue.Peek());
        }

        [Fact]
        public void Dequeue_ShouldRemoveAndReturnFrontNodeFromQueue()
        {
            // Arrange
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(5);

            // Act
            int dequeuedValue = queue.Dequeue();

            // Assert
            Assert.Equal(10, dequeuedValue);
            Assert.Equal(5, queue.Peek());
        }

        [Fact]
        public void IsEmpty_ShouldReturnTrueWhenQueueIsEmpty()
        {
            // Arrange
            Queue queue = new Queue();

            // Act
            bool isEmpty = queue.IsEmpty();

            // Assert
            Assert.True(isEmpty);
        }

        [Fact]
        public void IsEmpty_ShouldReturnFalseWhenQueueIsNotEmpty()
        {
            // Arrange
            Queue queue = new Queue();
            queue.Enqueue(10);

            // Act
            bool isEmpty = queue.IsEmpty();

            // Assert
            Assert.False(isEmpty);
        }
    }
}
