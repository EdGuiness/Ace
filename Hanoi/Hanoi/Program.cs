using System;
using System.Collections.Generic;
using System.Text;

namespace Hanoi
{
    class Tower : Stack<int>
    {
        public string Name { get; set; }
        public Tower(string name)
        {
            Name = name;
        }
    }

    class Program
    {
        static Tower A = new Tower("Tower A");
        static Tower B = new Tower("Tower B");
        static Tower C = new Tower("Tower C");

        static void Main(string[] args)
        {

            int numberOfDisks = 5;
            for (int i = numberOfDisks; i > 0; i--)
                A.Push(i);

            visualizeTowers();

            hanoi(numberOfDisks, from: A, to: C, intermediate: B);

            Console.ReadKey();
        }

        static void hanoi(int x, Tower from, Tower to, Tower intermediate)
        {
            if (x == 0) return;

            hanoi(x - 1, from, intermediate, to);

            move(x, from, to);

            hanoi(x - 1, intermediate, to, from);


        }

        static void move(int n, Tower from, Tower to)
        {
            Console.WriteLine(string.Format("Move disk {0} from {1} to {2}",
                n, from.Name, to.Name));

            int x = from.Pop();
            to.Push(x);

            visualizeTowers();
        }

        static void visualizeTowers()
        {
            foreach (Tower t in new List<Tower> { A, B, C })
            {
                Console.WriteLine(t.Name + ":");
                foreach (int i in t.ToArray())
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write('-');
                    Console.WriteLine();
                }
            }
        }
    }
}