using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }
        public new void MakeNoise()
        {
            base.MakeNoise();
            Console.WriteLine("bark");
        }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("eating dog food");
        }
        public override string ToString()
        {
            return $"[Dog]{Name}";
        }
    }
}
