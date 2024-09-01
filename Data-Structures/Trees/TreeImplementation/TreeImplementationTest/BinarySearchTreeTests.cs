using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TreeImplementationTest
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void TestAddingNode()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(5);
            bst.Add(3);
            bst.Add(7);

            Assert.Equal(new List<int> { 3, 5, 7 }, bst.InOrder());
        }

        [Fact]
        public void TestContainsNode()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(5);
            bst.Add(3);
            bst.Add(7);

            Assert.True(bst.Contains(3));
            Assert.False(bst.Contains(4));
        }

        [Fact]
        public void TestRemovingNode()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(5);
            bst.Add(3);
            bst.Add(7);
            bst.Add(1);
            bst.Add(9);

            bst.Remove(3);
            Assert.Equal(new List<int> { 1, 5, 7, 9 }, bst.InOrder());

            bst.Remove(5);
            Assert.Equal(new List<int> { 1, 7, 9 }, bst.InOrder());
        }
    }
}
