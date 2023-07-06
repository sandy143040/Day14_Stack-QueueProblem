using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_QueueProblem
{
    public class StackOperations<T>
    {
        public Node<T> top;
        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if(top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.next = top;
                top = newNode;
            }
        }
        public void Display()
        {
            Node<T> temp = top;
            if(top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
