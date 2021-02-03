using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string wert1 = "Hans;Meier;Dorfstrasse 5;9000;St.Gallen";

            string[] splittedWert = wert1.Split(';');

            Person neuePerson = new Person();
            neuePerson.Name = splittedWert[1];
            neuePerson.Vonrame = splittedWert[0];
            neuePerson.Plz = int.Parse(splittedWert[3]);

            Console.WriteLine(neuePerson.Name);
            Console.WriteLine(neuePerson.Plz);

            Console.ReadKey();

        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Vonrame { get; set; }
        public int Plz { get; set; }
    }
}
