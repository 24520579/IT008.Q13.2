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
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
        static void TaoMaTran(int n, int m, int[,] matrix)
        {
            //Console.Clear();
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
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            TaoMaTran(n, m, matrix);
            XuatMaTran(n, m, matrix);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Phan tu lon nhat: " + getMax(n, m, matrix));
            Console.WriteLine("Phan tu nho nhat: " + getMin(n, m, matrix));
            Console.WriteLine("Dong co tong lon nhat:");
            DongLonNhat(n, m, matrix);
            Console.WriteLine();
            TongNotNT(n, m, matrix);
            XoaDong(ref n, m, ref matrix);
            Console.WriteLine("Ma tran sau khi xoa cot co phan tu lon nhat:");
            XoaCotLonNhat(n, ref m, ref matrix);
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
                for (int j = 0; j < m; j++) if (maxx < matrix[i, j]) maxx = matrix[i, j];
            return maxx;
        }
        static void DongLonNhat(int n, int m, int[,] matrix)
        {
            int temp = 0, tong=0, vt=0;
            for(int i=0;i<n;i++)
            {
                temp = 0;
                for (int j = 0; j < m; j++) temp += matrix[i, j];
                if (temp > tong)
                {
                    tong = temp;
                    vt = i;
                }
            }
            for(int i=0;i<m;i++) Console.Write(matrix[vt,i]+" ");
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
        static void XoaDong(ref int n, int m, ref int[,]matrix)
        {
            Console.Write("Xoa dong: ");
            int k = int.Parse(Console.ReadLine())-1;
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
        static void XoaCotLonNhat(int n, ref int m, ref int[,] matrix)
        {
            int max = getMax(n, m, matrix);
            bool[] xoa = new bool[m];
            for (int j = 0; j < m; j++)
                for (int i = 0; i < n; i++)
                    if (matrix[i, j] == max)
                    {
                        xoa[j] = true;
                        break;
                    }

            int newM = 0;
            for (int j = 0; j < m; j++)
            {
                if (!xoa[j])
                {
                    for (int i = 0; i < n; i++)
                        matrix[i, newM] = matrix[i, j];
                    newM++;
                }
            }

            m = newM;
            XuatMaTran(n, m, matrix);
        }
    }
}
