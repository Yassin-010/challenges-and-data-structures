using System;

namespace TreeImplementation
{
    public class TreeMirror
    {
        public void MirrorTree(BinaryTree tree)
        {
            if (tree == null)
                throw new ArgumentNullException(nameof(tree), "The tree cannot be null.");

            if (tree.Root == null)
                return; // No operation if the root is null (empty tree)

            Mirror(tree.Root);
        }

        private void Mirror(Node node)
        {
            if (node == null) return;

            // Recursively mirror the left and right subtrees
            Mirror(node.Left);
            Mirror(node.Right);

            // Swap the left and right children
            Node temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }
    }
}
