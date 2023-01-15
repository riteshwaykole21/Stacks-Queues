using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stack Program in data Structure");
            Console.WriteLine("Please Select as per the Below Given Option : \n" +
               "Press 1: Creating coutom stack using LinkedList.\n"  +
               "Press 2: Using Peek and Pop in stack . \n"  +
               "Press 3: Using Enque in Queue . \n" +
               "Press 4: using Deque in Queue. \n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    LinkedListStack stackObject = new LinkedListStack();
                    stackObject.Push(70);
                    stackObject.Push(30);
                    stackObject.Push(56);
                    stackObject.Display();
                    break;
                case 2:
                    LinkedListStack stackobject1 = new LinkedListStack();
                    stackobject1.Push(70);
                    stackobject1.Push(30);
                    stackobject1.Push(56);
                    stackobject1.Display();
                    Console.WriteLine("Is List is empty?"+stackobject1.isEmpty());
                    stackobject1.Display();
                    break ;
                case 3:
                    LinkedListQueue queueObj = new LinkedListQueue();
                    queueObj.Enque(56);
                    queueObj.Enque(30);
                    queueObj.Enque(70);
                    queueObj.Display();
                    break;
                case 4:
                    LinkedListQueue queueObj1 = new LinkedListQueue();
                    queueObj1.Enque(56);
                    queueObj1.Enque(30);
                    queueObj1.Enque(70);
                    queueObj1.Display();
                    queueObj1.Deque();
                    queueObj1.Display();
                    queueObj1.Deque();
                    queueObj1.Display();
                    break;
                default:
                    break;
            }
            Console.ReadLine();
              
        }
    }
}
