using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Program
    {
        static void TaoMang(int[]a , int n)
        {
            Random rand = new Random();
            for(int i=0;i<n;i++) a[i] = rand.Next(0, 100);
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            TaoMang(a, n);
            int tmp;
            do
            {
                Console.Clear();
                Console.Write("Mang vua tao: ");
                Console.WriteLine(string.Join(" ", a));
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1. Tong cac so le");
                Console.WriteLine("2. Dem so nguyen to");
                Console.WriteLine("3. So chinh phuong nho nhat");
                Console.WriteLine("0. Thoat");
                Console.Write("Nhap lua chon: ");
                tmp = int.Parse(Console.ReadLine());
                switch (tmp)
                {
                    case 1:
                        {
                            Console.Write("Tong cac so le: ");
                            Console.WriteLine(TongLe(a, n));
                            break;
                        }
                    case 2:
                        {
                            Console.Write("So nguyen to trong mang: ");
                            Console.WriteLine(DemNT(a, n));
                            break;
                        }
                    case 3:
                        {
                            int check = SoCPNhoNhat(a, n);
                            if (check == -1) Console.WriteLine("Khong co so chinh phuong");
                            else Console.WriteLine("So chinh phuong nho nhat: ", check);
                            break;
                        }
                }
                Console.ReadLine();
            } while (tmp != 0);
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
        static int DemNT(int[]a, int n)
        {
            int dem = 0;
            for (int i = 0; i < n; i++) if (CheckNT(a[i])) dem++;
            return dem;
        }
        static bool checkCP(int x)
        {
            if (x < 0) return false;
            int temp = (int)Math.Sqrt(x);
            return temp*temp == x;
        }
        static int SoCPNhoNhat(int[]a, int n)
        {
            int? temp = null;
            for (int i = 0;i<n;i++) if (checkCP(a[i])) if (temp == null || temp > a[i]) 
                        temp = a[i];
            return temp??-1;
        }
    }
}
