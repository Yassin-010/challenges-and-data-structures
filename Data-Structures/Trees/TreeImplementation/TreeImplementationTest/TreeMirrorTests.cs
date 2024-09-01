
using System.Collections.Generic;
using TreeImplementation;
using Xunit;

public class TreeMirrorTests
{
    [Fact]
    public void TestMirrorTree()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(4);
        Btree.Root.Left = new Node(8);
        Btree.Root.Right = new Node(7);
        Btree.Root.Left.Left = new Node(12);
        Btree.Root.Left.Right = new Node(9);

        List<int> expectedOriginalInorder = new List<int> { 12, 8, 9, 4, 7 };
        List<int> expectedMirroredInorder = new List<int> { 7, 4, 9, 8, 12 };

        TreeMirror treeMirror = new TreeMirror();

        // Act
        List<int> originalInorder = Btree.InOrder();
        treeMirror.MirrorTree(Btree);
        List<int> mirroredInorder = Btree.InOrder();

        // Assert
        Assert.Equal(expectedOriginalInorder, originalInorder);
        Assert.Equal(expectedMirroredInorder, mirroredInorder);
    }

    [Fact]
    public void TestMirrorSingleNodeTree()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(1);

        List<int> expectedInorder = new List<int> { 1 };

        TreeMirror treeMirror = new TreeMirror();

        // Act
        treeMirror.MirrorTree(Btree);
        List<int> inorder = Btree.InOrder();

        // Assert
        Assert.Equal(expectedInorder, inorder);
    }

    [Fact]
    public void TestMirrorEmptyTree()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();

        List<int> expectedInorder = new List<int>();

        TreeMirror treeMirror = new TreeMirror();

        // Act
        treeMirror.MirrorTree(Btree);
        List<int> inorder = Btree.InOrder();

        // Assert
        Assert.Equal(expectedInorder, inorder);
    }
}
