using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BTH2_TangChanHong_24520579
{
    internal class Bai01
    {
        public static void Run()
        {
            Console.Write(" - Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write(" - Year: ");
            int year = int.Parse(Console.ReadLine());
            DateTime firstDay = new DateTime(year, month, 1);
            int startDay = (int)firstDay.DayOfWeek;
            int daysInMonth = DateTime.DaysInMonth(year, month);
            Console.WriteLine("SUN  MON  TUE  WED  THU  FRI  SAT");


            for (int i = 0; i < startDay; i++)
                Console.Write("     ");

            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write($"{day,2}   ");
                if ((day + startDay) % 7 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
