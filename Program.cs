using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateNow = DateTime.Now;
            Console.Write("{0}年 {1}月\n", dateNow.Year, dateNow.Month);
            DateTime dateFirst = DateTime.Parse(string.Format("{0}/{1}/1",
                dateNow.Year, dateNow.Month));
            //DisplayCalendar(dateFirst);
            Console.ReadLine();
        }
        static void DisplayCalendar(DateTime dateFirst)
        {
            int week;
            int month = dateFirst.Month;

            Console.Write("--------------------\n");
            Console.Write("日 月 火 水 木 金 土\n");

            for (week = 0; week < (int)dateFirst.DayOfWeek; week++)
                Console.Write("   ");
            while (month == dateFirst.Month)
            {
                for (; week < 7 && month == dateFirst.Month; week++)
                {
                    Console.Write("{0,2} ", dateFirst.Day);
                    dateFirst = dateFirst.AddDays(1);
                }
                Console.Write("\n");
                week = 0;
            }
        }
    }
}
