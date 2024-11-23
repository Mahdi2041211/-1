using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task
{
    internal class Node
    {
        public Student Student { get; set; }
        public Node Next { get; set; }

        public Node() { }
        public Node(Student student) { Student = student; }

    }
}
