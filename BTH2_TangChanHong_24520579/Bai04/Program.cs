using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    class phanSo
    {
        private int tuSo, mauSo;
        public phanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }

        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            tuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            mauSo = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"{tuSo}/{mauSo}");
        }
        public phanSo RutGon()
        {
            phanSo kq = new phanSo();
            int a = tuSo, b = mauSo;
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            kq.tuSo = tuSo / a;
            kq.mauSo = mauSo / a;
            return kq;
        }
        public phanSo Cong(phanSo p)
        {
            phanSo kq = new phanSo();
            kq.tuSo = tuSo * p.mauSo + mauSo * p.tuSo;
            kq.mauSo = mauSo * p.mauSo;
            return kq.RutGon();
        }
        public phanSo Tru(phanSo p)
        {
            phanSo kq = new phanSo();
            kq.tuSo = tuSo * p.mauSo - mauSo * p.tuSo;
            kq.mauSo = mauSo * p.mauSo;
            return kq.RutGon();
        }
        public phanSo Nhan(phanSo p)
        {
            phanSo kq = new phanSo();
            kq.tuSo = tuSo * p.tuSo;
            kq.mauSo = mauSo * p.mauSo;
            return kq.RutGon();
        }
        public phanSo Chia(phanSo p)
        {
            phanSo kq = new phanSo();
            kq.tuSo = tuSo * p.mauSo;
            kq.mauSo = mauSo * p.tuSo;
            return kq.RutGon();
        }
        public bool LonHon(phanSo p)
        {
            return tuSo * p.mauSo > mauSo * p.tuSo;
        }
    }
    class danhSachPhanSo
    {
        private List<phanSo> ds;
        public danhSachPhanSo()
        {
            ds = new List<phanSo>();
        }
        public void Nhap()
        {
            Console.Write("Nhap so luong phan so: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                phanSo p = new phanSo();
                p.Nhap();
                ds.Add(p);
            }
        }
        public void Xuat()
        {
            foreach (var p in ds)
            {
                p.Xuat();
            }
        }
        public void SapXepGiamDan()
        {
            ds.Sort((p1, p2) => p2.LonHon(p1) ? 1 : -1);
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 2 phan so:");
            phanSo p1 = new phanSo(), p2 = new phanSo(), temp = new phanSo();
            p1.Nhap();p2.Nhap();
            temp = p1.Cong(p2);
            Console.WriteLine("Tong 2 phan so: "); temp.Xuat();
            temp=p1.Tru(p2);
            Console.WriteLine("Hieu 2 phan so: "); temp.Xuat();
            temp = p1.Nhan(p2);
            Console.WriteLine("Tich 2 phan so: "); temp.Xuat();
            temp = p1.Chia(p2);
            Console.WriteLine("Thuong 2 phan so: "); temp.Xuat();
            Console.ReadKey();
            danhSachPhanSo ds = new danhSachPhanSo();
            ds.Nhap();
            Console.WriteLine("Danh sach phan so vua nhap:");
            ds.Xuat();
            ds.SapXepGiamDan();
            ds.Xuat();
            Console.ReadKey();
        }
    }
}
