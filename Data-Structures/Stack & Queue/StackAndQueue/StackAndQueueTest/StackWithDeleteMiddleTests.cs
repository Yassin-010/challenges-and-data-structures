using StackAndQueue.DeleteMiddleElement;
namespace StackAndQueueTest

{
    public class StackWithDeleteMiddleTests
    {
        [Fact]
        public void DeleteMiddle_OddSizedStack_RemovesMiddleElement()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5);

            // Act
            stack.DeleteMiddle();

            // Assert
            string expected = "Stack: Top -> 5 -> 8 -> 14 -> 7 -> null";
            string actual = stack.ToString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteMiddle_EvenSizedStack_RemovesLowerMiddleElement()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5);
            stack.Push(2);

            // Act
            stack.DeleteMiddle();

            // Assert
            string expected = "Stack: Top -> 2 -> 5 -> 3 -> 14 -> 7 -> null";
            string actual = stack.ToString();
            Assert.Equal(expected, actual);
        }
    }
}
