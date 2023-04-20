using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clock.BL;

namespace clock
{
    class Program
    {
        static void Main(string[] args)
        {
            //empty time
            ClockType empty_time = new ClockType();
            Console.Write("Empty Time: ");
            empty_time.PrintTime();
            Console.WriteLine(" ");
            //time with one parameter
            ClockType hour_time = new ClockType(8);
            Console.Write("Hour Time : ");
            hour_time.PrintTime();
            Console.WriteLine(" ");
            // time with 2 parameters
            ClockType minute_time = new ClockType(8, 10);
            Console.Write("Minute Time: ");
            minute_time.PrintTime();
            Console.WriteLine(" ");
            // time with three parameters
            ClockType full_time = new ClockType(8, 10, 11);
            Console.Write("Full Time : ");
            full_time.PrintTime();
            Console.WriteLine(" ");
            // increment seconds
            full_time.IncrementSeconds();
            Console.Write("Full Time (increment seconds :  ");
            full_time.PrintTime();
            Console.WriteLine(" ");
            // increment minutes
            full_time.IncrementMinutes();
            Console.Write("Full Time (increment minutes :  ");
            full_time.PrintTime();
            Console.WriteLine(" ");
            // increment hours
            full_time.IncrementHours();
            Console.Write("Full Time (increment hours : ");
            full_time.PrintTime();
            Console.WriteLine(" ");
            // check
            bool flag = full_time.IsEqual(9, 11, 12);
            Console.WriteLine("Flag: " + flag);
            // check with object
            ClockType cmp = new ClockType(10, 12, 11);
            flag = full_time.IsEqual(cmp);
            Console.WriteLine("Object flag: " + flag);
            Console.WriteLine(" ");
            // subtracting for remaining time
            ClockType remaining_time = new ClockType();
            remaining_time.CalculateRemainig(full_time.hours, full_time.minutes, full_time.seconds);
            Console.Write("Remaining time in hours: ");
            remaining_time.ConvertToHours(remaining_time);
            remaining_time.PrintTime();
            Console.WriteLine(" ");
            // input time elapsed
            ClockType elapsed_time = new ClockType(1, 2, 3);
            Console.Write("Input for Elapsed time in hours : " + elapsed_time.hours + " " + elapsed_time.minutes + " " + elapsed_time.seconds);
            Console.WriteLine(" ");

            //subtracting for elapsed time
            full_time.CalculateElapsed(elapsed_time);
            Console.Write("Elapsed Time in seconds: ");
            full_time.PrintTime();
            full_time.ConvertToHours(full_time);
            Console.Write("Elapsed time in hours: ");
            full_time.PrintTime();

            ////  time difference
            ClockType e = new ClockType();
            e.hours = full_time.hours - remaining_time.hours;
            e.minutes = full_time.minutes - remaining_time.minutes;
            e.seconds = full_time.seconds - remaining_time.seconds;

            Console.Write("Difference : ");
            e.PrintTime();





            Console.ReadKey();




        }
    }
}
