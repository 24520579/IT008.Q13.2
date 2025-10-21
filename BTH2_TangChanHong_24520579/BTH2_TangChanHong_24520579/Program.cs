using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BTH2_TangChanHong_24520579
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            do
            {
                Console.Clear();
                Console.WriteLine("1: Bai 1 - In lich");
                Console.WriteLine("2: Bai 2 - In ten tap tin");
                Console.WriteLine("3: Bai 3 - Ma tran");
                Console.WriteLine("4: Bai 4 - Phan so");
                Console.WriteLine("5: Bai 5 - Cong ty dia oc");
                Console.WriteLine("0: Thoat");
                Console.WriteLine("---------------------------------");
                Console.Write("Nhap lua chon cua ban: ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.Clear();
                        Bai01.Run();
                        break;
                    case 2:
                        Console.Clear();
                        Bai02.Run();
                        break;
                    case 3:
                        Console.Clear();
                        Bai03.Run();
                        break;
                    case 4:
                        Console.Clear();
                        Bai04.Run();
                        break;
                    case 5:
                        Console.Clear();
                        Bai05.Run();
                        break;
                    case 0:
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long thu lai!");
                        Console.ReadKey();
                        break;
                }   
            } while (!stop);
            Console.ReadKey();
        }
    }
}
