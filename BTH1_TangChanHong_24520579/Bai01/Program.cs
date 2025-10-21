using System;

namespace Bai01
{
    internal class Program
    {
        static void TaoMang(int[] a, int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++) a[i] = rand.Next(0, 100);
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap n: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            int[] a = new int[n];
            TaoMang(a, n);
            Console.Write("Mang vua tao: ");
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine("----------------------------------");
            Console.Write("Tong cac so le: ");
            Console.WriteLine(TongLe(a, n));
            Console.Write("So nguyen to trong mang: ");
            Console.WriteLine(DemNT(a, n));

            int check = SoCPNhoNhat(a, n);
            if (check == -1) Console.WriteLine("Khong co so chinh phuong");
            else Console.WriteLine("So chinh phuong nho nhat: " + check);
            Console.ReadLine();
        }
        static int TongLe(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++) if (a[i] % 2 == 1) tong += a[i];
            return tong;
        }
        static bool CheckNT(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++) if (x % i == 0) return false;
            return true;
        }
        static int DemNT(int[] a, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++) if (CheckNT(a[i])) dem++;
            return dem;
        }
        static bool checkCP(int x)
        {
            if (x < 0) return false;
            int temp = (int)Math.Sqrt(x);
            return temp * temp == x;
        }
        static int SoCPNhoNhat(int[] a, int n)
        {
            int? temp = null;
            for (int i = 0; i < n; i++) if (checkCP(a[i])) if (temp == null || temp > a[i])
                        temp = a[i];
            return temp ?? -1;
        }
    }
}
