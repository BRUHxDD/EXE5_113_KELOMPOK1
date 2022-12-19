using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class QueueLinkedList
    {
        class Node
        {
            public int TF;
            public Node next;
            public Node(int tf)
            {
                TF = tf;
            }
        }
        bool empty()
        {
            if (Teuku == null)
                return (true); else return (false);
        }
        Node Teuku;
        Node Fadhilah;
        public void insert(string tf)
        {
            var newNode == new Node(tf);
            if (Fadhilah != null)
            {
                Fadhilah.next = newNode;
            }
            Fadhilah = newNode;
            if (Teuku == null)
            {
                Teuku = newNode;
            }
        }
        public void delete()
        {
            if (Teuku == null)
            {
                throw new InvalidProgramException("The queue is empty");
            }
            var tf = Teuku.TF;
            Teuku = Teuku.next;
            if (Teuku == null)
            {
                Teuku = null;
            }
        }
    }
}