using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task
{
    internal class Student
    {
        int id;
        static int nextID = 0;
        public int ID 
        {
            get { return id; }
        }
        public string Name { get; set; }
        public int Mark1 { get; set; } // علامة الاختبار الأول
        public int Mark2 { get; set; } // علامة الاختبار الثاني
        public Estimation Estimation { get; set; }
        public int FinalMark { get { return (Mark2 + Mark1) / 2; } } // أحسن ما أعملها بميثود

        public Student() { id = nextID++; }
        public Student(string name, int mark1, int mark2) : this()
        {
            Name = name;
            Mark1 = mark1;
            Mark2 = mark2;
        }

        public override string ToString()
        {
            return $"ID is: {ID}\nName is: {Name}\nmark1 is: {Mark1}\nmark2 is: {Mark2}\nfinal mark is: {FinalMark}\nEstimation is: {Estimation}";
        }
    }
    enum Estimation
    {
        Fail,
        Good,
        VeryGood,
        Excellent
    }
}
