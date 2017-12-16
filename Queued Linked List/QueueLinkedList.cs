using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queued_Linked_List
{
    class QueueLinkedList<T> where T : IComparable<T>
    {
        
        int count { get; set; }
        public QNode<T> Head = null;
        public QueueLinkedList()
        {
            Head = null;
        }
        bool isEmpty()
        {
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region ENQ
        public void EnQ(T Value)
        {
            QNode<T> NewNode = new QNode<T>(Value);
            if (Head == null)
            {
                Head = new QNode<T>(Value); count++;
            }
            else if (Head.NextNode == null)
            {
                Head.NextNode = new QNode<T>(Value); count++;
            }
            else
            {
                count++;
                QNode<T> traversalNode = Head;
                while (traversalNode.NextNode != null)
                {
                    traversalNode = traversalNode.NextNode;
                }
                traversalNode.NextNode = new QNode<T>(Value);
            }
        }
        #endregion
        #region DEQ
        public T DeQ()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Cannot Dequeue an Empty Queue");
            }
            else 
            {
                QNode<T> temp = Head;
                Head = Head.NextNode;
                count--;
                return temp.Data;
            }
        }
        #endregion
            
    }
}
