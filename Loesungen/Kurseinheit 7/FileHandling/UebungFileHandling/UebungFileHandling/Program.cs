using System;
using System.IO;

namespace UebungFileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // File lesen und auf Console ausgeben
            string file = @"C:\Temp\Filehandling\Testdatei.txt";

            string[] lines;
            lines = File.ReadAllLines(file);

            int index = 0;
            foreach (var line in lines)
            {
                if (index>0)
                {
                    Console.WriteLine(line);
                }
                index++;
            }

            // Erstellen eines Directory
            Directory.CreateDirectory(@"C:\Temp\Filehandling\TestVerzeichnis");

            // File verschieben
            File.Move(@"C:\Temp\Filehandling\Testdatei.txt", @"C:\Temp\Filehandling\TestVerzeichnis\Testdatei.txt");
        }
    }
}
