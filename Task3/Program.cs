using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("our linked list now is <string> and this app is to show you how does this list work.");
            LinkedList<string> list = new LinkedList<string>();
            bool run = true;
            while (run)
            {
                Console.WriteLine("chose what do you wont to do:");
                Console.WriteLine("1 addFirst");
                Console.WriteLine("2 addLast");
                Console.WriteLine("3 addIndex");
                Console.WriteLine("4 removeFirst");
                Console.WriteLine("5 removeLast");
                Console.WriteLine("6 removeAt");
                Console.WriteLine("7 print the list");
                Console.WriteLine("8 exit");

                string chose = Console.ReadLine();
                switch (chose)
                {
                    case "1":
                        Console.WriteLine("enter the string that you wont to add:");
                        list.AddFirst(Console.ReadLine());
                        break;
                    case "2":
                        Console.WriteLine("enter the string that you wont to add:");
                        list.AddLast(Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine("enter the string that you wont to add:");
                        string str = Console.ReadLine();
                        Console.WriteLine("enter the index:");
                        int index = Convert.ToInt32(Console.ReadLine());
                        try 
                        { 
                            list.AddIndex(str, index);
                            break;
                        }
                        catch (Exception e) 
                        { 
                            Console.WriteLine(e.Message);
                            break;
                        }
                    case "4":
                        try
                        {
                            list.RemoveFirst();
                            Console.WriteLine("removed!");
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                    case "5":
                        try
                        {
                            list.RemoveLast();
                            Console.WriteLine("removed!");
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                    case "6":
                        Console.WriteLine("enter the index to remove:");
                        int i = int.Parse(Console.ReadLine());
                        try
                        {
                            list.RemoveAt(i);
                            Console.WriteLine("removed!");
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                    case "7":
                        list.Print();
                        break;
                    case "8":
                        run = false;
                        break;
                        
                }
            }
        }
    }
    class Node<T>
    {

        Node<T> next;
        T value;

        public Node<T> Next
        {
            set { next = value; }
            get { return next; }
        }
        public T Value
        {
            set { this.value = value; }
            get { return value; }
        }

        public Node() { }
        public Node(T value) { this.value = value; }
        public Node(Node<T> next, T value) : this(value) { this.next = next; }
    }
    class LinkedList<T>
    {
        Node<T> first = null;
        Node<T> last = null;
        int count = 0;
        public Node<T> First
        {
            set { first = value; }
            get { return first; }
        }
        public Node<T> Last
        {
            set { last = value; }
            get { return last; }
        }
        public int Count
        {
            set { count = value; }
            get { return count; }
        }

        public LinkedList() { }
        public LinkedList(Node<T> first, Node<T> last)
        {
            this.first = first;
            this.last = last;
        }

        public void AddFirst(Node<T> node)
        {
            if (first == null)
            {
                first = node;
                last = node;
            }
            else
            {
                node.Next = first;
                first = node;
            }
            count++;
        }
        public void AddFirst(T value) { AddFirst(new Node<T>(value)); }

        public void AddLast(Node<T> node)
        {
            if (first == null)
            {
                AddFirst(node);
            }
            else
            {
                last.Next = node;
                last = node;
                count++;
            }
        }
        public void AddLast(T value) { AddLast(new Node<T>(value)); }

        public void AddIndex(Node<T> node, int index)
        {
            if (index > count || index < 0)
                throw new IndexOutOfRangeException();
            if (index == 0)
                AddFirst(node);
            else if (index == count)
                AddLast(node);
            else
            {
                Node<T> temp = first;
                for (int i = 0; i != index - 1; i++)
                    temp = temp.Next;
                node.Next = temp.Next;
                temp.Next = node;
                count++;
            }
        }
        public void AddIndex(T value, int index) { AddIndex(new Node<T>(value), index); }

        public T RemoveFirst()
        {
            if (first == null)
                throw new Exception("the linkedList is empty.");
            Node<T> temp = first.Next;
            T value = first.Value;
            first = null;
            first = temp;
            if (count == 1)
                last = null;
            count--;
            return value;
        }
        public T RemoveLast()
        {
            if (last == null)
                throw new Exception("the linkedList is empty.");
            Node<T> temp = first;
            T value;
            for (int i = 1; i < count - 2; i++)
                temp = temp.Next;
            value = temp.Next.Value;
            temp.Next = null;
            last = temp;
            if (count == 1)
                first = null;
            count--;
            return value;
        }
        public T RemoveAt(int index)
        {
            if (index == 0)
                return RemoveFirst();
            if (index == count - 1)
                return RemoveLast();
            if (first == null)
                throw new Exception("the linkedList is empty.");
            Node<T> temp = first;
            T value;
            for (int i = 1; i < index - 1; i++)
                temp = temp.Next;
            value = temp.Next.Value;
            Node<T> node = temp.Next;
            temp.Next = temp.Next.Next;
            node = null;
            return value;
        }
        public void Print()
        {
            for (Node<T> node = first; node != null; node = node.Next)
                Console.WriteLine(node.Value.ToString());
        }
    }
}