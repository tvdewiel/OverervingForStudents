using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
        public new void MakeNoise()
        {
            base.MakeNoise();
            Console.WriteLine("miauw");
        }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("eating mice");
        }
        public override string ToString()
        {
            return $"[Cat]{Name}";
        }
    }
}
