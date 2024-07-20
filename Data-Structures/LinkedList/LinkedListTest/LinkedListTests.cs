using LinkedList;

namespace LinkedListTest
{
    public class LinkedListTests
    {
        [Fact]
        public void Remove_NodeFromEndOfLinkedList_RemovesCorrectNode()
        {
            // Arrange
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);

            // Act
            list.Remove(30);

            // Assert
            Assert.False(list.Includes(30));
        }

        [Fact]
        public void PrintList_CorrectlyPrintsLinkedListContents()
        {
            // Arrange
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);

            // Redirect Console output
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            list.PrintList();
            var output = stringWriter.ToString().Trim();

            // Assert
            Assert.Equal("Head -> 5 -> 10 -> 20 -> 30 -> Null", output);
        }
    }
}