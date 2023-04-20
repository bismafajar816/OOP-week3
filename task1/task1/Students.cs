using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Students
    {
        public Students()
        {
            Console.WriteLine("Default constructor called");
        }
        public Students (Students s)
        {
            studentName = s.studentName;
            matricMarks = s.matricMarks;
            fscMarks = s.fscMarks;
            ecatMarks = s.ecatMarks;
            aggregate = s.aggregate;

        }
       /* public Students(string n, float A , float B, float C,float D)
        {
            studentName = n;
            matricMarks = A;
            fscMarks = B;
            ecatMarks = C;
            aggregate = D;





            *//*            DefCons*/
            /*  Console.WriteLine("Default constructor called");*/
            /*  studentName = "jill";
              matricMarks = 1040.0F;
              fscMarks = 1044.0F;
              ecatMarks = 200.35F;
              aggregate = 82.83F;*//*
        }*/
        public string studentName;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;

    }

}
