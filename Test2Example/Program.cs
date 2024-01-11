using System;
using System.Collections.Generic;

namespace Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Root: ");
            int rootValue = int.Parse(Console.ReadLine());
            Root root = new Root(rootValue);
            Console.Write("Branch count: ");
            int N = int.Parse(Console.ReadLine());
            List<Branch> branches = new List<Branch>();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Branch {0}:", i);
                Console.Write("Value: ");
                int value = int.Parse(Console.ReadLine());
                Console.Write("Parent's number: ");
                int parentIndex = int.Parse(Console.ReadLine());
                Node parent;
                if (parentIndex >= 0 && parentIndex < branches.Count)
                    parent = branches[parentIndex];
                else parent = root;
                Console.Write("Is leaf? ");
                bool isLeaf = Console.ReadLine() == "Y";
                if (isLeaf)
                    branches.Add(new Leaf(value, parent));
                else branches.Add(new Branch(value, parent));
            }
            Console.Write("Number of value addings: ");
            int M = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                Console.Write("Number of branch: ");
                int branchIndex = int.Parse(Console.ReadLine());
                Console.Write("Value: ");
                int value = int.Parse(Console.ReadLine());
                branches[branchIndex].Add(value);
            }
            for (int i = 0; i < N; i++)
                Console.WriteLine(branches[i]);
        }
    }
}
