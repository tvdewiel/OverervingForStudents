using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Barbaar
    {
        public Barbaar(string naam, int levenspunten, int aanvalSterkte, double snelheid)
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
        public void WordWild()
        {
            Console.WriteLine("Grrrrrrr");
        }
        public override string ToString()
        {
            return $"[barbaar]{Naam},{Levenspunten},{AanvalSterkte},{Snelheid}";
        }
    }
}
