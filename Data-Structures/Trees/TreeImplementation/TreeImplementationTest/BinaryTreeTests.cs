using System.Collections.Generic;
using Xunit;
using TreeImplementation;
public class BinaryTreeTests
{
    [Fact]
    public void TestPreOrderTraversal()
    {
        BinaryTree tree = new BinaryTree();
        tree.Root = new Node(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);
        tree.Root.Left.Left = new Node(4);
        tree.Root.Left.Right = new Node(5);

        List<int> expected = new List<int> { 1, 2, 4, 5, 3 };
        Assert.Equal(expected, tree.PreOrder());
    }

    [Fact]
    public void TestInOrderTraversal()
    {
        BinaryTree tree = new BinaryTree();
        tree.Root = new Node(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);
        tree.Root.Left.Left = new Node(4);
        tree.Root.Left.Right = new Node(5);

        List<int> expected = new List<int> { 4, 2, 5, 1, 3 };
        Assert.Equal(expected, tree.InOrder());
    }

    [Fact]
    public void TestPostOrderTraversal()
    {
        BinaryTree tree = new BinaryTree();
        tree.Root = new Node(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);
        tree.Root.Left.Left = new Node(4);
        tree.Root.Left.Right = new Node(5);

        List<int> expected = new List<int> { 4, 5, 2, 3, 1 };
        Assert.Equal(expected, tree.PostOrder());
    }



    [Fact]
    public void TestFindSecondMax()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(10);
        Btree.Root.Left = new Node(5);
        Btree.Root.Right = new Node(20);
        Btree.Root.Left.Left = new Node(3);
        Btree.Root.Left.Right = new Node(7);
        Btree.Root.Right.Left = new Node(15);
        Btree.Root.Right.Right = new Node(25);

        // Act
        int? secondMax = Btree.FindSecondMax();

        // Assert
        Assert.Equal(20, secondMax);
    }

    [Fact]
    public void TestFindSecondMaxSingleValue()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(10);

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => Btree.FindSecondMax());
    }

    [Fact]
    public void TestFindSecondMaxFewerThanTwoUniqueValues()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(10);
        Btree.Root.Left = new Node(10);
        Btree.Root.Right = new Node(10);

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => Btree.FindSecondMax());
    }

    [Fact]
    public void TestFindSecondMaxNegativeValues()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(-10);
        Btree.Root.Left = new Node(-20);
        Btree.Root.Right = new Node(-5);

        // Act
        int? secondMax = Btree.FindSecondMax();

        // Assert
        Assert.Equal(-10, secondMax);
    }
    [Fact]

    public void LeafSum_ShouldReturnSumOfAllLeafNodes()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(9);
        Btree.Root.Left = new Node(8);
        Btree.Root.Right = new Node(12);
        Btree.Root.Left.Left = new Node(3);
        Btree.Root.Left.Right = new Node(7);
        Btree.Root.Right.Left = new Node(17);
        Btree.Root.Right.Right = new Node(23);
        Btree.Root.Left.Left.Right = new Node(4);

        // Act
        int leafSum = Btree.LeafSum();

        // Assert
        Assert.Equal(51, leafSum);
    }
    [Fact]
    public void LargestValueEachLevel_ShouldReturnCorrectValues()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(5);
        Btree.Root.Left = new Node(13);
        Btree.Root.Right = new Node(7);
        Btree.Root.Left.Left = new Node(3);
        Btree.Root.Left.Right = new Node(7);
        Btree.Root.Right.Left = new Node(12);
        Btree.Root.Right.Right = new Node(20);
        Btree.Root.Left.Left.Left = new Node(1);
        Btree.Root.Left.Left.Right = new Node(4);
        Btree.Root.Right.Left.Right = new Node(11);

        // Act
        List<int> largestValues = Btree.LargestValueEachLevel();

        // Assert
        var expectedValues = new List<int> { 5, 13, 20, 11 };
        Assert.Equal(expectedValues, largestValues);
    }

    [Fact]
    public void LargestValueEachLevel_ShouldThrowException_WhenTreeIsEmpty()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => Btree.LargestValueEachLevel());
    }

    [Fact]
    public void LargestValueEachLevel_ShouldHandleSingleElementTree()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(42);

        // Act
        List<int> largestValues = Btree.LargestValueEachLevel();

        // Assert
        var expectedValues = new List<int> { 42 };
        Assert.Equal(expectedValues, largestValues);
    }
}

