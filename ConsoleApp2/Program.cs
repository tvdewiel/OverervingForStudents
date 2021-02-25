using Inheritance_2;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Heks h = new Heks("Gwendolien", 200, 300, 2.5);
            Kobol k = new Kobol("Karel", 300, 50, 8.0);
            Barbaar b = new Barbaar("Guy", 500, 500, 1.5);           
            Console.WriteLine(h);
            Console.WriteLine(k);
            Console.WriteLine(b);
            List<Troep> troepen = new List<Troep>();
            troepen.Add(h);
            troepen.Add(b);
            troepen.Add(k);
            h.Verschijn();
            b.WordWild();
            foreach(Troep t in troepen)
            {
                t.Beweeg();
            }
            h.Verberg();
            k.SteelGoud();
            //2
            Troep tr = new Troep("xxx", 100, 50, 5.0);
            Console.WriteLine(tr);
        }
    }
}
