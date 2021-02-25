using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Kobol
    {
        public Kobol(string naam, int levenspunten, int aanvalSterkte, double snelheid)
        {
            Naam = naam;
            Levenspunten = levenspunten;
            AanvalSterkte = aanvalSterkte;
            Snelheid = snelheid;
            GoudVerzameld = 0;
        }
        public string Naam { get; set; }
        public int Levenspunten { get; set; }
        public int AanvalSterkte { get; set; }
        public double Snelheid { get; set; }
        public int GoudVerzameld { get; set; }
        public void Beweeg()
        {
            Console.WriteLine($"{this.GetType()} moving");
        }
        public void SteelGoud()
        {
            GoudVerzameld += 100;
            Console.WriteLine("ik word rijk");
        }
        public override string ToString()
        {
            return $"[kobol]{Naam},{Levenspunten},{AanvalSterkte},{Snelheid},{GoudVerzameld}";
        }
    }
}
