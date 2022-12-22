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
            if (Hamam == null)
            {
                Console.WriteLine("Queue is Empty!!!");
                return;
            }
            Hamam = Hamam.next;
            if (Hamam == null)
                Priyatmoko = null;
        }
        public void display()
        {
            if (Hamam == null)
            {
                Console.WriteLine("Queue is Empty or Filled !!!");
                return;
            }
            Node display;
            for (display = Hamam; display != null; display = display.next)
                Console.WriteLine(display.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            queue q = new queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            q.insert();
                            break;
                        case '2':
                            q.delete();
                            break;
                        case '3':
                            q.display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered");
                }
            }
        }
    }

}
