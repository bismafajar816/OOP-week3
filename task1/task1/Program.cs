using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Students s1 = new Students();
              Students s2 = new Students();
              DefCons(s1, s2);*/
            /* ParaCons();*/
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int x = 0; x < numbers.Count(); x++)
            {
                Console.WriteLine(numbers[x]);
            }
            List<int> numbers2 = new List<int> { 1, 2,  8, 9, 10 };
            foreach(var i in numbers2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();





        }
        static void DefCons(Students s1, Students s2)
        {
            /* Task 1*/

            Console.WriteLine(s1.studentName);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.ReadKey();
            /*   Task 2*/
            Console.ReadKey();
            /*Task 3*/
            Console.WriteLine(s1.studentName);
            Console.ReadKey();
            /*  Self assesment 1 a*/
            Console.WriteLine(s1.studentName);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.WriteLine();
            /*   self assesment 1 b*/
            Console.WriteLine(s2.studentName);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.fscMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.WriteLine(s2.aggregate);


        }
        static void ParaCons()
        {
            //task 1
          /*  Students s1 = new Students("bisma");
            Console.WriteLine(s1.studentName);

            Students s2 = new Students("fajar");
            Console.WriteLine(s2.studentName);*/
            //self assesment 1 a
          /*  Students s3 = new Students("bisma", 1040, 1044, 200, 82.83F);
            Console.WriteLine(s3.studentName);
            Console.WriteLine(s3.matricMarks);
            Console.WriteLine(s3.fscMarks);
            Console.WriteLine(s3.ecatMarks);
            Console.WriteLine(s3.aggregate);

            Console.ReadKey();
            *//*  self assesment 1 b*//*
            Students s4 = new Students("fajar", 1040, 1044, 200, 82.83F);
            Console.WriteLine(s4.studentName);
            Console.WriteLine(s4.matricMarks);
            Console.WriteLine(s4.fscMarks);
            Console.WriteLine(s4.ecatMarks);
            Console.WriteLine(s4.aggregate);
            Console.ReadKey();*/
        }
        static void CoCons()
        {
            Students s4 = new Students();
            s4.studentName = "biha";
            Students s5 = new Students(s4);
            Console.WriteLine(s4.studentName);
            Console.WriteLine(s5.studentName);
        }

    }
}
