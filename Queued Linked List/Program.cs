using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queued_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueLinkedList<int> Queue = new QueueLinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                Queue.EnQ(i);
            }
            Queue.DeQ();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Queue.DeQ());
            }
            Console.ReadKey();
        }
    }
}
