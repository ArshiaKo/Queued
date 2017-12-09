using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queued_Linked_List
{
    class QueueLinkedList<T>
    {
        bool isEmpty = true;
        public QNode<T> Head = null;
        public QueueLinkedList()
        {
            Head = null;
        }
        #region ENQ
        public void EnQ(T Value)
        {
            QNode<T> NewNode = new QNode<T>(Value);
            if (Head == null)
            {
                Head = new QNode<T>(Value);
            }
            else if (Head.NextNode == null)
            {
                Head.NextNode = new QNode<T>(Value);
            }
            else
            {
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
            QNode<T> temp = Head;
            Head.Previous = Head;
            return;
        }
        #endregion
    }
}
