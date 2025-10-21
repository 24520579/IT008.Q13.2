using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_TangChanHong_24520579
{
    internal class Bai03
    {
        public static void Run()
        {
            Console.Write("Nhap so dong n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            NhapMaTran(n, m, matrix);
            Console.Write("---------------------");
            XuatMaTran(n, m, matrix);
            Console.Write("Nhap gia tri can tim: ");
            int x = int.Parse(Console.ReadLine());
            TimKiemPhanTu(matrix, n, m, x);
            XuatNguyenTo(matrix, n, m);
            DongCoNhieuNguyenTo(matrix, n, m);
            Console.ReadKey();
        }
        static void NhapMaTran(int n, int m, int[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Dong " + i + ": ");
                string[] row = Console.ReadLine().Trim().Split(' ');

                for (int j = 0; j < m; j++)
                    matrix[i, j] = int.Parse(row[j]);
            }
        }
        static void XuatMaTran(int n, int m, int[,] matrix)
        {
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
        static void TimKiemPhanTu(int[,] matrix, int n, int m, int x)
        {
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == x)
                    {
                        Console.WriteLine($"{x} o vi tri [{i}, {j}]");
                        found = true;
                    }
                }
            }

            if (!found)
                Console.WriteLine($"Khong ton tai {x}");
        }
        static bool isPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void XuatNguyenTo(int[,] matrix, int n, int m)
        {
            Console.Write("Cac so nguyen to trong ma tran: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (isPrime(matrix[i, j]))
                        Console.Write(matrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
        static void DongCoNhieuNguyenTo(int[,] matrix, int n, int m)
        {
            int maxx = 0, vt = -1;
            for (int i = 0; i < n; i++)
            {
                int dem = 0;
                for (int j = 0; j < m; j++) if (isPrime(matrix[i, j])) dem++;
                if (dem > maxx)
                {
                    maxx = dem;
                    vt = i;
                }
            }
            if (vt != -1) Console.WriteLine($"Dong co nhieu so nguyen to nhat: {vt}");
            else Console.WriteLine("Khong co so nguyen to nao trong ma tran");
        }
    }
}
