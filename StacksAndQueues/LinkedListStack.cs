using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class LinkedListStack
    {
        public Node top;
        public void Push(int data)   //UC1
        {
            Node newNode = new Node(data);
                if (top != null)
                {
                   newNode.next = top;
                }
            top = newNode;
            Console.WriteLine($"New Node {data} is added");
        }
        public void Display()
        {
            Console.WriteLine("Displaying Nodes");
            Node temp = this.top;
            if(temp == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("Values in the Stack :"+temp.data);
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }
    }
}
