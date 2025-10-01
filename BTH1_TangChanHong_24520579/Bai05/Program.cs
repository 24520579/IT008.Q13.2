using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Program
    {
        static bool isYear(int x)
        {
            if (x < 1)
                return false;
            return true;
        }
        static bool isMonth(int x)
        {
            if (x < 1 || x > 12)
                return false;
            return true;
        }
        static bool isDay(int y, int m, int d)
        {
            if (d > 0 && d <= DateTime.DaysInMonth(y, m)) return true;
            return false;
        }
        static void Main(string[] args)
        {
            bool check = false;
            do
            {
                Console.Clear();
                Console.Write("Nhap ngay: ");
                int ngay = int.Parse(Console.ReadLine());
                Console.Write("Nhap thang: ");
                int thang = int.Parse(Console.ReadLine());
                Console.Write("Nhap nam: ");
                int nam = int.Parse(Console.ReadLine());
                if (isYear(nam) && isMonth(thang) && isDay(nam, thang, ngay))
                {
                    check = true;
                    DateTime temp = new DateTime(nam, thang, ngay);
                    Console.WriteLine("Ngay "+ngay+" thang "+thang+" nam "+nam+" la: ");
                    Console.WriteLine(temp.DayOfWeek.ToString());
                }
                else Console.WriteLine("Nam thang khong hop le, nhap lai");
                Console.ReadKey();
            } while (check == false);
        }
    }
}
