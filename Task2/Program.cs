using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] list = new int[10];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = rnd.Next(100);
            }
            for (int i = 0; i < list.Length; i++)
                Console.Write(list[i] + "\t");
            Console.WriteLine();
            Sort(list);
            for (int i = 0; i < list.Length; i++)
                Console.Write(list[i] + "\t");
            Console.WriteLine();
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine(Generic<int>.BackingPinarySearch(list, value, 0, list.Length - 1));
        }
        class Generic<T>
        {
            public static int PinarySearch(int[] list, int value)
            {
                Sort(list);
                int first = 0, last = list.Length - 1;
                while (first != last)
                {
                    int dim = (first + last) / 2;
                    if (list[dim] == value)
                        return dim;
                    if (list[dim] > value)
                        last = --dim;
                    else first = ++dim;
                }
                if (list[first] == value)
                    return first;
                return -1;
            }
            public static int BackingPinarySearch(int[] list, int value, int first, int last)
            {
                if (first == last && list[first] != value) return -1;
                int dim = (last + first) / 2;
                if (list[dim] == value)
                    return dim;
                if (list[dim] < value)
                    return BackingPinarySearch(list, value, dim + 1, last);
                return BackingPinarySearch(list, value, first, last - 1);
            }
        }
        static void Sort(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                int max = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < list[max])
                        max = j;
                }
                if (list[i] > list[max])
                {
                    int temp = list[i];
                    list[i] = list[max];
                    list[max] = temp;
                }
            }
        }
    }
}
