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
}

