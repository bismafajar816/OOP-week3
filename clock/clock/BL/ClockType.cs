using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock.BL
{
    class ClockType
    {
        public ClockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public ClockType(int hours)
        {
            this.hours = hours;

        }
        public ClockType(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }
        public ClockType(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public void IncrementSeconds()
        {
            seconds++;
        }
        public void IncrementMinutes()
        {
            minutes++;
        }
        public void IncrementHours()
        {
            hours++;
        }
        public void PrintTime()
        {
            Console.WriteLine(hours + ": " + minutes + ": " + seconds);
        }
        public bool IsEqual(int h,int m , int s)
        {
            if(hours == h  && minutes == m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsEqual(ClockType temp)
        {
            if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
      
        public void CalculateElapsed(ClockType e)
        {
            hours = (24 * 3600) - (e.hours*3600);
            minutes = (60 * 60) - (e.minutes*60);
            seconds = 60 - e.seconds;
        }
        public void CalculateRemainig(int h , int m , int s)
        {
          
            hours = (24 * 3600) - (h * 3600);
            minutes = (60 * 60) - (m * 60);
            seconds = 60 - s;

            Console.Write("Remaining Time: ");
            Console.WriteLine(hours + ": " + minutes + ": " + seconds);

        }
        public void ConvertToHours(ClockType e)
        {
            e.hours = e.hours / 3600;
            e.minutes = e.minutes / 60;

        }
      
        public int hours;
        public int minutes;
        public int seconds;
    }
}
