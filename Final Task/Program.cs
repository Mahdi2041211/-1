using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentsList students = new StudentsList();
            do
            {
                Console.WriteLine(
                    "enter number of what do you want to do:\n" +
                    "1: Add stud.\n" +
                    "2: Print list\n" +
                    "3: exit."
                    );
                string chose = Console.ReadLine();
                if (chose == "1")
                {
                    Student student = new Student();
                    Console.WriteLine("enter the name of the student:");
                    student.Name = Console.ReadLine();
                    Console.WriteLine("enter mark1:");
                    student.Mark1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter mark2:");
                    student.Mark2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    students.Add(student);
                    Console.WriteLine("the student added");
                }
                else if (chose == "2")
                {
                    Console.Clear();
                    students.Print();
                }
                else if (chose == "3")
                    break;
                else Console.Clear();
            } while (true);
            students.Print();
        }
    }
}
