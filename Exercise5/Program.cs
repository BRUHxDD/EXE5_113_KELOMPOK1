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
            public string TF;
            public Node next;
            public Node(string tf)
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
            var newNode = new Node(tf);
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
        public void Display()
        {
            Node tmp;
            if (empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for (tmp = Teuku; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.TF);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            QueueLinkedList q = new QueueLinkedList();
            while (true)
            {
                Console.WriteLine("\nStack Menu");
                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Delete");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter your choice: ");
                string input = Console.ReadLine();
                char ch = Convert.ToChar(input == "" ? "0" : input);
                switch (ch)
                {
                    case '1':
                        Console.WriteLine("\nEnter your alfabeth: ");
                        string num = Convert.ToString(Console.ReadLine());
                        q.insert(num);
                        break;
                    case '2':
                        q.delete();
                        Console.WriteLine("item delete");
                        break;
                    case '3':
                        q.Display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice");
                        break;
                }
            }
        }
    }
}