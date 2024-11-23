using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task
{
    internal class StudentsList
    {
        public Node First {  get; set; }
        public void Add(Node Stud)
        {
            if (First == null)
            {
                First = Stud;
                return;
            }
            if (First.Student.FinalMark > Stud.Student.FinalMark)
            {
                Stud.Next = First;
                First = Stud;
                return;
            }
            Node move = First;
            for (; move.Next != null; move = move.Next)
                if (move.Next.Student.FinalMark >  Stud.Student.FinalMark)
                {
                    Stud.Next = move.Next;
                    move.Next = Stud;
                    return;
                }
            move.Next = Stud;
        }
        public void Add(Student student)
        {
            Add(new Node(student));
        }
        public void Print()
        {
            for (Node node = First; node != null; node = node.Next)
                Console.WriteLine(node.Student);
        }
    }
}
