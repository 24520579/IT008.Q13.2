using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_TangChanHong_24520579
{
    internal class Bai05
    {
        class cKhuDat
        {
            protected string diaDiem;
            protected long giaBan;
            protected int dienTich;
            public cKhuDat()
            {
                diaDiem = "";
                giaBan = 0;
                dienTich = 0;
            }
            public long getGiaBan() { return giaBan; }
            public int getDienTich() { return dienTich; }
            public string getDiaDiem() { return diaDiem.ToLower(); }
            public virtual void Nhap()
            {
                Console.Write("Dia diem: ");
                diaDiem = Console.ReadLine();
                Console.Write("Gia ban: ");
                giaBan = long.Parse(Console.ReadLine());
                Console.Write("Dien tich: ");
                dienTich = int.Parse(Console.ReadLine());
            }
            public virtual void Xuat()
            {
                Console.Write($"Dia diem: {diaDiem}, Gia ban: {giaBan}, Dien tich: {dienTich}");
            }
        }
        class cNhaPho : cKhuDat
        {
            private int namXayDung;
            private int soTang;
            public override void Nhap()
            {
                base.Nhap();
                Console.Write("Nam xay dung: ");
                namXayDung = int.Parse(Console.ReadLine());
                Console.Write("So tang: ");
                soTang = int.Parse(Console.ReadLine());
            }
            public override void Xuat()
            {
                base.Xuat();
                Console.WriteLine($", Nam xay dung: {namXayDung}, So tang: {soTang}");
            }
        }
        class cChungCu : cKhuDat
        {
            private int soTang;
            public override void Nhap()
            {
                base.Nhap();
                Console.Write("So tang: ");
                soTang = int.Parse(Console.ReadLine());
            }
            public override void Xuat()
            {
                base.Xuat();
                Console.WriteLine($", So tang: {soTang}");
            }
        }
        class cDanhSach
        {
            List<cKhuDat> dsKhuDat = new List<cKhuDat>();
            public void Nhap()
            {
                Console.Write("Nhap so luong khu dat: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Nhap thong tin khu dat thu {i + 1}:");
                    Console.Write("Loai khu dat (1: Nha pho, 2: Chung cu): ");
                    int loai = int.Parse(Console.ReadLine());
                    if (loai == 1)
                    {
                        cKhuDat khuDat = new cNhaPho();
                        khuDat.Nhap();
                        dsKhuDat.Add(khuDat);
                    }
                    else
                    {
                        cKhuDat khuDat = new cChungCu();
                        khuDat.Nhap();
                        dsKhuDat.Add(khuDat);
                    }
                }
            }
            public void Xuat()
            {
                Console.WriteLine("Danh sach khu dat:");
                foreach (var khuDat in dsKhuDat)
                {
                    khuDat.Xuat();
                }
            }
            public void TongGiaBan()
            {
                long tongGiaBan = 0;
                foreach (var khuDat in dsKhuDat) tongGiaBan += khuDat.getGiaBan();
                Console.WriteLine($"Tong gia ban cua tat ca khu dat: {tongGiaBan}");
            }
            public void XuatYeuCau()
            {
                Console.WriteLine("Cac khu dat co dien tich > 100m2:");
                foreach (var khuDat in dsKhuDat)
                    if (khuDat.getDienTich() > 100)
                        khuDat.Xuat();
                Console.WriteLine("Nha pho co dien tich > 60m2 va nam xay dung > 2019:");
                foreach (var khuDat in dsKhuDat)
                    if (khuDat is cNhaPho)
                    {
                        cNhaPho nhaPho = (cNhaPho)khuDat;
                        if (nhaPho.getDienTich() > 60)
                        {
                            nhaPho.Xuat();
                        }
                    }
            }
            public void TimKiem()
            {
                Console.Write("Nhap dia diem can tim kiem: ");
                string diaDiemTimKiem = Console.ReadLine().ToLower();
                Console.Write("Nhap gia toi da: ");
                long giaToiDa = long.Parse(Console.ReadLine());
                Console.Write("Nhap dien tich toi thieu: ");
                int dienTichToiThieu = int.Parse(Console.ReadLine());
                Console.WriteLine("Ket qua tim kiem:");
                foreach (var khuDat in dsKhuDat)
                {
                    if (khuDat.getGiaBan() <= giaToiDa && khuDat.getDienTich() >= dienTichToiThieu)
                    {
                        var tempDiaDiem = khuDat.getDiaDiem();
                        if (tempDiaDiem.Contains(diaDiemTimKiem))
                        {
                            khuDat.Xuat();
                        }
                    }
                }
            }
        }
        public static void Run()
        {
            cDanhSach danhSach = new cDanhSach();
            danhSach.Nhap();
            bool stop = false;
            do
            {
                Console.Clear();
                Console.WriteLine("1: Xuat danh sach khu dat");
                Console.WriteLine("2: Tinh tong gia ban cua tat ca khu dat");
                Console.WriteLine("3: Xuat cac khu dat theo yeu cau");
                Console.WriteLine("4: Tim kiem khu dat");
                Console.WriteLine("0: Thoat");
                Console.WriteLine("-------------------------");
                Console.Write("Nhap lua chon: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        danhSach.Xuat();
                        Console.ReadKey();
                        break;
                    case 2:
                        danhSach.TongGiaBan();
                        Console.ReadKey();
                        break;
                    case 3:
                        danhSach.XuatYeuCau();
                        Console.ReadKey();
                        break;
                    case 4:
                        danhSach.TimKiem();
                        Console.ReadKey();
                        break;
                    case 0:
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long thu lai.");
                        Console.ReadKey();
                        break;
                }
            } while(!stop);
            Console.ReadKey();
        }
    }
}
