using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Stack_QueueProblem
{
    public class StackOperations
    {
        public Node head;
        public StackOperations()
        {
            head = null;
        }
        public bool IsEmpty()
        {
            return head == null;
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if(IsEmpty())
            {
                head = newNode;
                return;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }
        public int Peek()
        {
            if(IsEmpty())
            {
                 return -1;
            }
             return head.data;
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            int top = head.data;
            head = head.next;
            return top;
        }
    }
}
