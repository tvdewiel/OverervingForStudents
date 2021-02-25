using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public virtual void MakeNoise()
        {
            Console.WriteLine("grrrr");
        }
        public virtual void Eat()
        {
            Console.WriteLine("eating");
        }
        public override string ToString()
        {
            return $"[Animal]{Name}";
        }
    }
}
