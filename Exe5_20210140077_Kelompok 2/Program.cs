using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5_20210140077_Kelompok_2
{
    
    class Node
    {
        public string name;
        public Node next;
    }
    class queue
    {
        Node Hamam, Priyatmoko;
        public queue()
        {
            Hamam = null;
            Priyatmoko = null;
        }
        public void insert()
        {
            string k2;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            k2 = Console.ReadLine();
            newnode.name = k2;
            newnode.next = null;
            if (Hamam == null)
            {
                Hamam = newnode;
                Priyatmoko = newnode;
                return;
            }
            Hamam = newnode;
            Priyatmoko = newnode;
        }
        public void delete()
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

}
