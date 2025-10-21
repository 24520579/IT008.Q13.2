using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_TangChanHong_24520579
{
    internal class Bai02
    {
        public static void Run()
        {

            Console.Write("Nhap duong dan: ");
            string directoryPath = Console.ReadLine();
            DirectoryInfo directory = new DirectoryInfo(directoryPath);
            foreach (DirectoryInfo folder in directory.GetDirectories())
                Console.WriteLine("+ " + folder.Name);
            foreach (FileInfo file in directory.GetFiles())
                Console.WriteLine("  -  " + file.Name);

            Console.ReadKey();
        }
    }
}
