using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_TangChanHong_24520579
{
    internal class Bai04
    {
        public static void Run()
        {
            Console.WriteLine("Nhap 2 phan so:");
            phanSo p1 = new phanSo(), p2 = new phanSo(), temp = new phanSo();
            p1.Nhap(); p2.Nhap();
            temp = p1.Cong(p2);
            Console.WriteLine("\nTong 2 phan so: ");
            if (temp.GetTuSo() == 0) Console.Write("0");  else temp.Xuat();

            temp = p1.Tru(p2);
            Console.WriteLine("\nHieu 2 phan so: ");
            if (temp.GetTuSo() == 0) Console.Write("0"); else temp.Xuat();

            temp = p1.Nhan(p2);
            Console.WriteLine("\nTich 2 phan so: ");
            if (temp.GetTuSo() == 0) Console.Write("0"); else temp.Xuat();

            temp = p1.Chia(p2);
            Console.WriteLine("\nThuong 2 phan so: ");
            if (temp.GetTuSo() == 0) Console.Write("0"); else temp.Xuat();
            Console.ReadLine();
            danhSachPhanSo ds = new danhSachPhanSo();
            ds.Nhap();
            ds.SapXepGiamDan();
            Console.WriteLine("\nPhan so lon nhat:");
            ds[0].Xuat();
            Console.WriteLine("\nDanh sach phan so sap xep giam dan:");
            ds.Xuat();
            Console.ReadKey();

        }
        class phanSo
        {
            private int tuSo, mauSo;
            public phanSo()
            {
                tuSo = 0;
                mauSo = 1;
            }
            public int GetTuSo()
            {
                return tuSo;
            }
            public void Nhap()
            {
                do
                {
                    Console.Write("Nhap tu so: ");
                    tuSo = int.Parse(Console.ReadLine());
                    Console.Write("Nhap mau so: ");
                    mauSo = int.Parse(Console.ReadLine());
                    if(mauSo == 0)
                        Console.WriteLine("Mau so khong duoc bang 0. Vui long nhap lai!");
                } while (mauSo == 0);
            }
            public void Xuat()
            {
                Console.Write($"{tuSo}/{mauSo} \t");
            }
            public phanSo RutGon()
            {
                if (tuSo == 0)
                {
                    phanSo kqZero = new phanSo();
                    kqZero.tuSo = 0;
                    kqZero.mauSo = 1;
                    return kqZero;
                }

                int ts = tuSo;
                int ms = mauSo;

                if (ms < 0)
                {
                    ts = -ts;
                    ms = -ms;
                }

                int a = Math.Abs(ts);
                int b = Math.Abs(ms);

                while (b != 0)
                {
                    int r = a % b;
                    a = b;
                    b = r;
                }

                phanSo kq = new phanSo();
                kq.tuSo = ts / a;
                kq.mauSo = ms / a;
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
                if(n <= 0)
                {
                    Console.WriteLine("So luong phan so phai lon hon 0.");
                    Console.ReadLine();
                    return;
                }
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
            public phanSo this[int index]
            {
                get
                {
                    return ds[index];
                }
                set
                {
                    ds[index] = value;
                }
            }
            public void SapXepGiamDan()
            {
                ds.Sort((p1, p2) => p2.LonHon(p1) ? 1 : -1);
            }
        }
    }
}
