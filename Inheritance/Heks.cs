using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Heks
    {
        public Heks(string naam, int levenspunten, int aanvalSterkte, double snelheid)
        {
            Naam = naam;
            Levenspunten = levenspunten;
            AanvalSterkte = aanvalSterkte;
            Snelheid = snelheid;
        }
        public string Naam { get; set; }
        public int Levenspunten { get; set; }
        public int AanvalSterkte { get; set; }
        public double Snelheid { get; set; }
        public void Beweeg()
        {
            Console.WriteLine($"{this.GetType()} moving");
        }
        public void Verschijn()
        {
            Console.WriteLine("hier ben ik");
        }
        public void Verberg()
        {
            Console.WriteLine("je kan me niet zien");
        }
        public override string ToString()
        {
            return $"[heks]{Naam},{Levenspunten},{AanvalSterkte},{Snelheid}";
        }
    }
}
