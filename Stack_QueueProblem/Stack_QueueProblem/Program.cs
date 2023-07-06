using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_QueueProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueOperations queueOperations = new QueueOperations();
            queueOperations.Enqueue(56);
            queueOperations.Enqueue(30);
            queueOperations.Enqueue(70);
            queueOperations.Display();

            Console.ReadLine();
        }
    }
}
