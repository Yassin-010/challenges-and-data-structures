using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class RemoveDuplicatesTests
    {

        //CC7

        [Fact]
        public void RemoveDuplicate_NoDuplicates_ListUnchanged()
        {
            // Arrange
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // Act
            list.RemoveDuplicate();

            // Assert
            Assert.True(list.Includes(1));
            Assert.True(list.Includes(2));
            Assert.True(list.Includes(3));
            Assert.False(list.Includes(4));
        }

        [Fact]
        public void RemoveDuplicate_RemovesOnlyDuplicateNodes()
        {
            // Arrange
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            list.Add(5);
            list.Add(20);
            list.Add(20);
            list.Add(10);
            list.Add(5);
            list.Add(10);

            // Act
            list.RemoveDuplicate();

            // Assert
            Assert.Equal(1, list.GetOccurrences(5));
            Assert.Equal(1, list.GetOccurrences(20));
            Assert.Equal(1, list.GetOccurrences(10));

            // Ensure no other nodes were inadvertently removed
            Assert.Equal(3, list.GetNodeCount());
        }

        [Fact]
        public void RemoveDuplicate_AllDuplicates_SingleNodeLeft()
        {
            // Arrange
            LinkedList.LinkedList list = new LinkedList.LinkedList();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);

            // Act
            list.RemoveDuplicate();

            // Assert
            Assert.True(list.Includes(1));
            Assert.Equal(1, list.GetNodeCount());
        }
    }
}
