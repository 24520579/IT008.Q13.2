using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class Program
    {
        static bool CheckNT(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++) if (x % i == 0) return false;
            return true;
        }
        static void TinhTong(int x)
        {
            long tong = 0;
            for (int i = 2; i < x; i++) if (CheckNT(i)) tong+=i;
            Console.WriteLine(tong);
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n=int.Parse(Console.ReadLine());
            Console.Write("Tong cac so nguyen to nho hon " + n+ ": ");
            TinhTong (n);
            Console.ReadKey();
        }
    }
}
