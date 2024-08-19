using TreeImplementation;

class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Add nodes to the BST
        bst.Add(10);
        bst.Add(5);
        bst.Add(15);
        bst.Add(7);

        Console.WriteLine("Binary Search Tree:");
        bst.Print();

        // Check if a node exists
        bool contains = bst.Contains(7);
        Console.WriteLine($"\nContains 7: {contains}");

        // Remove a node
        bst.Remove(5);
        Console.WriteLine("\nAfter removing 5:");
        bst.Print();

        // Check if the node is removed
        contains = bst.Contains(5);
        Console.WriteLine($"\nContains 5: {contains}");
    }
}