using Xunit;

namespace LinkedList.Tests
{
    public class MergeSortedLinkedLists
    {
        [Fact]
        public void Test_Merge_When_One_List_Is_Empty()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);

            LinkedList list2 = new LinkedList(); // Empty list

            // Act
            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            // Assert
            Assert.Equal("Head -> 1 -> 3 -> 5 -> Null", GetListAsString(mergedList));
        }

        [Fact]
        public void Test_Merge_When_Both_Lists_Are_Empty()
        {
            // Arrange
            LinkedList list1 = new LinkedList(); // Empty list
            LinkedList list2 = new LinkedList(); // Empty list

            // Act
            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            // Assert
            Assert.Equal("Head -> Null", GetListAsString(mergedList));
        }

        [Fact]
        public void Test_Merge_List1_And_List2_From_Example()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            list1.Add(5);
            list1.Add(10);
            list1.Add(15);

            LinkedList list2 = new LinkedList();
            list2.Add(2);
            list2.Add(3);
            list2.Add(20);

            // Act
            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            // Assert
            Assert.Equal("Head -> 2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null", GetListAsString(mergedList));
        }

        // Helper method to convert linked list to string for easy assertion
        private string GetListAsString(LinkedList list)
        {
            var current = list.head;
            var result = "Head -> ";
            while (current != null)
            {
                result += current.Data + " -> ";
                current = current.Next;
            }
            result += "Null";
            return result;
        }
    }
}
