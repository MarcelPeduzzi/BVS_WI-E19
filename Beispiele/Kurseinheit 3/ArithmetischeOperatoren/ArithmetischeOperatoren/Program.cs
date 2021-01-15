using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmetischeOperatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 7;

            int c = a + b;
            Console.WriteLine("a + b = " + c);

            c = a - b;
            Console.WriteLine("a - b = " + c);

            c = a / b;
            Console.WriteLine("a / b = " + c); // liefert 1 da in einem int keine Nachkommastellen vorhanden sind

            c = a * b;
            Console.WriteLine("a * b = " + c);

            c = a % b;
            Console.WriteLine("a % b = " + c); // Module = Restwert


            Console.ReadKey(false);
        }
    }
}
