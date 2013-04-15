using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{

    class Program
    {
        static void Main(string[] args)
        {

            int numberOfNodes = 7;
            int[] values = new int[numberOfNodes];
            Random r = new Random();
            r.Next(numberOfNodes);

            for (int i = 0; i < numberOfNodes; i++)
                values[i] = r.Next(numberOfNodes);

            BinaryTree b = new BinaryTree(values);

            int searchFor = 99; // r.Next(numberOfNodes);

            Console.WriteLine(string.Format("BFS searching for {0} result: {1}", searchFor, BreadthFirstSearch(b, searchFor)));

            //Console.WriteLine(string.Format("DFS searching for {0} result: {1}", searchFor, DFS(b, searchFor)));

            Console.Write("PreOrder: ");
            DFSPreOrder(b);
            Console.WriteLine("\n");

            Console.Write("InOrder: ");
            DFSInOrder(b);
            Console.WriteLine("\n");

            Console.Write("PostOrder: ");
            DFSPostOrder(b);
            Console.WriteLine("\n");


            if (Debugger.IsAttached)
                Console.ReadLine();
        }

        static bool DFS(BinaryTree node, int searchFor)
        {

            if (node == null)
                return false;

            if (node.Value == searchFor)
                return true;

            return DFS(node.Left, searchFor)
                || DFS(node.Right, searchFor);

        }

        static void DFSPreOrder(BinaryTree node)
        {
            if (node == null)
                return;

            Console.Write(string.Format(" {0} ", node.Value));
            DFSPreOrder(node.Left);
            DFSPreOrder(node.Right);
        }

        static void DFSInOrder(BinaryTree node)
        {
            if (node == null)
                return;

            DFSInOrder(node.Left);
            Console.Write(string.Format(" {0} ", node.Value));
            DFSInOrder(node.Right);
        }

        static void DFSPostOrder(BinaryTree node)
        {
            if (node == null)
                return;

            DFSPreOrder(node.Left);
            DFSPreOrder(node.Right);
            Console.Write(string.Format(" {0} ", node.Value));
        }


        static bool DepthFirstSearchIterative(BinaryTree node, int searchFor)
        {
            Stack<BinaryTree> nodeStack = new Stack<BinaryTree>();
            nodeStack.Push(node);

            while (nodeStack.Count > 0)
            {
                BinaryTree current = nodeStack.Pop();

                if (current.Value == searchFor)
                    return true;

                if (current.Right != null)
                    nodeStack.Push(current.Right);

                if (current.Left != null)
                    nodeStack.Push(current.Left);
            }

            return false;
        }

        static bool BreadthFirstSearch(BinaryTree root, int searchFor)
        {
            Queue<BinaryTree> queue = new Queue<BinaryTree>();

            queue.Enqueue(root);

            int count = 0;
            while (queue.Count > 0)
            {
                BinaryTree current = queue.Dequeue();

                if (current == null)
                    continue;

                Console.WriteLine(string.Format("{3}: {0} <-- {1} --> {2}",
                    current.Left == null ? "" : current.Left.Value.ToString(),
                    current.Value,
                    current.Right == null ? "" : current.Right.Value.ToString(),
                    count++
                    ));

                queue.Enqueue(current.Left);
                queue.Enqueue(current.Right);

                if (current.Value == searchFor)
                    return true;
            }
            return false;
        }

    }

    class BinaryTree
    {
        public int Value;
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }

        public List<BinaryTree> Nodes { get { return new List<BinaryTree> { Left, Right }; } }

        public BinaryTree(int[] values) : this(values, 0) { }

        BinaryTree(int[] values, int index)
        {
            Load(this, values, index);
        }

        void Load(BinaryTree tree, int[] values, int index)
        {
            Value = values[index];
            if (index * 2 + 1 < values.Length)
            {
                Left = new BinaryTree(values, index * 2 + 1);
            }
            if (index * 2 + 2 < values.Length)
            {
                Right = new BinaryTree(values, index * 2 + 2);
            }
        }
    }
}
