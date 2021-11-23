using System;
using System.Collections.Generic;
using System.Threading;

namespace RefactoringGuru.DesignPatterns.Observer.Conceptual
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(6);
            Console.WriteLine(queue.GetEnumerator().ToString());
        }

    }
}