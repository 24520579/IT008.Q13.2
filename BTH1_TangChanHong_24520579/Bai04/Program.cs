using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
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
        static void Main(string[] args)
        {
            bool check = false;
            do
            {
                Console.Clear();
                Console.Write("Nhap thang: ");
                int thang = int.Parse(Console.ReadLine());
                Console.Write("Nhap nam: ");
                int nam = int.Parse(Console.ReadLine());
                if (isYear(nam) && isMonth(thang))
                {
                    check = true;
                    Console.WriteLine("Thang " + thang + " nam " + nam + " co " + DateTime.DaysInMonth(nam, thang) + " ngay");
                }
                else Console.WriteLine("Nam thang khong hop le, nhap lai");
                Console.ReadKey();
            } while (check == false);
        }
    }
}
