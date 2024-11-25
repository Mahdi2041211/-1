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
        public Estimation Estimation
        {
            get
            {
                if (FinalMark <= 100 && FinalMark > 80)
                    return Estimation.Excellent;
                else if (FinalMark <= 80 && FinalMark > 60)
                    return Estimation.VeryGood;
                else if (FinalMark <= 60 && FinalMark > 40)
                    return Estimation.Good;
                else if (FinalMark <= 40 && FinalMark >= 0)
                    return Estimation.Fail;
                else throw new IndexOutOfRangeException("the final mark should be between 0 and 100");
            }
        }
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
