using Inheritance;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Heks h = new Heks("Gwendolien",200,300,2.5);
            Kobol k = new Kobol("Karel", 300, 50, 8.0);
            Barbaar b = new Barbaar("Guy", 500, 500, 1.5);
            Console.WriteLine(h);
            Console.WriteLine(k); 
            Console.WriteLine(b);
            h.Verschijn();
            b.WordWild();
            h.Beweeg();
            k.Beweeg();
            b.Beweeg();
            h.Verberg();
            k.SteelGoud();
        }
    }
}
