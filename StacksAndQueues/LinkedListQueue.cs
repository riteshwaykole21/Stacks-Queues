using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class LinkedListQueue
    {
        Node head = null;
        public void Enque(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head= newNode;
                Console.WriteLine($"{newNode.data} is inserted into Queue.");
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp= temp.next;
                }
                temp.next= newNode;
                Console.WriteLine($"{newNode.data} is inserted into Queue");
            }
        }
        public void Deque()
        {
            if (head == null)
            {
                Console.WriteLine("Queue Is empty,Deletion is not possible");
                return;
            }
            else
            {
                while (this.head != null)
                {
                    Console.WriteLine($"{head.data} has been removed");
                    head = head.next;
                    break;
                }
            }
        }
        public void Display()
        {
            Node temp = this.head;
            Console.WriteLine("Displaying Nodes :"); 
            if(temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while(temp!= null)
            {
                Console.Write(temp.data+" ");
                temp= temp.next;
            }
            Console.WriteLine();
        }
    }
}
