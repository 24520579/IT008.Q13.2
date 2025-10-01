using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    internal class Program
    {
        static void XuatMaTran(int n, int m, int[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
        static void TaoMaTran(int n, int m, int[,] matrix)
        {
            Console.Clear();
            Random random = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i, j] = random.Next(0, 100);
        }
        static void Main(string[] args)
        {
            Console.Write("So dong n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("So cot m: ");
            int m=int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            TaoMaTran(n, m, matrix);
            bool check = false;
            do
            {
                Console.Clear();
                XuatMaTran(n, m, matrix);
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. Phan tu lon nhat, nho nhat");
                Console.WriteLine("2. Dong co tong lon nhat");
                Console.WriteLine("3. Tinh tong cac so khong phai so nguyen to");
                Console.WriteLine("4. Xoa dong thu k");
                Console.WriteLine("5. Xoa cot chua phan tu lon nhat");
                Console.WriteLine("0. Thoat");
                Console.Write("Nhap lua chon: ");
                int temp=int.Parse(Console.ReadLine());
                if (temp == 0) check = true;
                //else switch (temp)
                //    {
                //        case 
                //    }
            } while (check == false);
            Console.ReadKey();
        }
        static int getMin(int n, int m, int[,]matrix)
        {
            int minn = matrix[0, 0];
            for(int i = 0; i < n; i++) 
                for(int j = 0;j<m; j++) if (minn > matrix[i,j]) minn=matrix[i,j];
            return minn;
        }
        static int getMax(int n, int m, int[,] matrix)
        {
            int maxx = matrix[0, 0];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++) if (maxx > matrix[i, j]) maxx = matrix[i, j];
            return maxx;
        }
        static int DongLonNhat(int n, int m, int[,] matrix)
        {
            int temp = 0, tong=0, vt=0;
            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < m; j++) temp += matrix[i, j];
                if (temp > tong)
                {
                    tong = temp;
                    vt = i;
                }
            }
            return vt;
        }
        static bool CheckNT(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++) if (x % i == 0) return false;
            return true;
        }
        static void TongNotNT(int n, int m, int[,]matrix)
        {
            int tong = 0;
            for (int i = 0; i <n; i++)
                for(int j = 0;j<m;j++) if(CheckNT(matrix[i,j])==false) tong += matrix[i,j];
            Console.WriteLine("Tong cac so khong phai so nguyen to: " + tong);
        }
        static void XoaDong(ref int n, int m, int[,]matrix)
        {
            Console.Write("Xoa dong: ");
            int k = int.Parse(Console.ReadLine());
            if (k == n) n--;
            else
            {
                for (int i = k; i < n - 1; i++)
                    for (int j = 0; j < m; j++)
                        matrix[i, j] = matrix[i + 1, j];
                n--;
            }
            XuatMaTran(n, m, matrix);
        }
        static void XoaCotLonNhat(int n, ref int m, int[,] matrix)
        {
            int vt;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (getMax(n, m, matrix) == matrix[i, j]) vt = m;

            if(vt==m)
                m--;
            else
            {
                int maxTemp = getMax(n, m, matrix);
                while (maxTemp == getMax(n, m, matrix))
                {
                    for (int i = getMaxValuem(n, m, matrix); i < m - 1; i++)
                        for (int j = 0; j < n; j++)
                            matrix[j, i] = matrix[j, i + 1];
                    m--;
                }
            }
            Console.WriteLine(" Xóa hoàn tất");
        }
    }
}
