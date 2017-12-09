using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queued_Linked_List
{
    class QNode <T>
    {
        public T Data;
        public QNode<T> NextNode;
        public QNode<T> Previous;
        public QNode(T data)
        {
            Data = data;
            NextNode = null;
            Previous = null;
        }
    }
}
