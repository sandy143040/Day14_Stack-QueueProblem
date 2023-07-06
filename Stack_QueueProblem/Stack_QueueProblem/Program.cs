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
            StackOperations stackOperations = new StackOperations();
            stackOperations.Push(70);
            stackOperations.Push(30);
            stackOperations.Push(56);
            
            while(!stackOperations.IsEmpty())
            {
                Console.WriteLine(stackOperations.Peek());
                stackOperations.Pop();
            }

            Console.ReadLine();
        }
    }
}
