using System;
using System.IO;
using System.Text;

namespace _02
{
    class Program
    {
        public static void Main()
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
