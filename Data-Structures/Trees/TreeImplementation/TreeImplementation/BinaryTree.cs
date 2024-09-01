using System;
using System.Collections.Generic;

namespace TreeImplementation
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public List<int> PreOrder()
        {
            List<int> result = new List<int>();
            PreOrderTraversal(Root, result);
            return result;
        }

        private void PreOrderTraversal(Node node, List<int> result)
        {
            if (node == null) return;
            result.Add(node.Data);
            PreOrderTraversal(node.Left, result);
            PreOrderTraversal(node.Right, result);
        }

        public List<int> InOrder()
        {
            List<int> result = new List<int>();
            InOrderTraversal(Root, result);
            return result;
        }

        private void InOrderTraversal(Node node, List<int> result)
        {
            if (node == null) return;
            InOrderTraversal(node.Left, result);
            result.Add(node.Data);
            InOrderTraversal(node.Right, result);
        }

        public List<int> PostOrder()
        {
            List<int> result = new List<int>();
            PostOrderTraversal(Root, result);
            return result;
        }

        private void PostOrderTraversal(Node node, List<int> result)
        {
            if (node == null) return;
            PostOrderTraversal(node.Left, result);
            PostOrderTraversal(node.Right, result);
            result.Add(node.Data);
        }

        public void Print()
        {
            PrintTree(Root, 0);
        }

        private void PrintTree(Node node, int level)
        {
            if (node == null) return;
            PrintTree(node.Right, level + 1);
            Console.WriteLine(new string(' ', level * 4) + node.Data);
            PrintTree(node.Left, level + 1);
        }

        public int? FindSecondMax()
        {
            if (Root == null)
                throw new InvalidOperationException("The tree is empty.");

            int max = FindMax(Root);
            int? secondMax = FindSecondMaxHelper(Root, max);

            if (!secondMax.HasValue)
                throw new InvalidOperationException("The tree does not have a second maximum value.");

            return secondMax.Value;
        }

        private int FindMax(Node node)
        {
            if (node == null)
                throw new InvalidOperationException("The tree is empty.");

            int max = node.Data;
            if (node.Left != null)
                max = Math.Max(max, FindMax(node.Left));
            if (node.Right != null)
                max = Math.Max(max, FindMax(node.Right));

            return max;
        }

        private int? FindSecondMaxHelper(Node node, int max)
        {
            if (node == null)
                return null;

            int? leftMaxValue = FindSecondMaxHelper(node.Left, max);
            int? rightMaxValue = FindSecondMaxHelper(node.Right, max);

            if (node.Data < max)
            {
                // Determine the largest value less than max
                int? maxInSubtrees = null;
                if (leftMaxValue.HasValue)
                    maxInSubtrees = leftMaxValue;
                if (rightMaxValue.HasValue && (!maxInSubtrees.HasValue || rightMaxValue > maxInSubtrees))
                    maxInSubtrees = rightMaxValue;

                // Update the maxInSubtrees if the current node's value is valid
                if (!maxInSubtrees.HasValue || node.Data > maxInSubtrees)
                    maxInSubtrees = node.Data;

                return maxInSubtrees;
            }

            // If current node is not less than max, return the maximum found in subtrees
            if (leftMaxValue.HasValue && rightMaxValue.HasValue)
                return Math.Max(leftMaxValue.Value, rightMaxValue.Value);

            return leftMaxValue ?? rightMaxValue;
        }


        public int LeafSum()
        {
            return CalculateLeafSum(Root);
        }

        private int CalculateLeafSum(Node node)
        {
            if (node == null)
                return 0;

            if (node.Left == null && node.Right == null)
                return node.Data;

            return CalculateLeafSum(node.Left) + CalculateLeafSum(node.Right);
        }


        public List<int> LargestValueEachLevel()
        {
            if (Root == null)
                throw new InvalidOperationException("The tree is empty.");

            List<int> largestValues = new List<int>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxAtLevel = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();
                    maxAtLevel = Math.Max(maxAtLevel, currentNode.Data);

                    if (currentNode.Left != null)
                        queue.Enqueue(currentNode.Left);
                    if (currentNode.Right != null)
                        queue.Enqueue(currentNode.Right);
                }

                largestValues.Add(maxAtLevel);
            }

            return largestValues;
        }

    }
}
