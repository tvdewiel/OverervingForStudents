using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_1
{
    public class Cat
    {
        public Cat(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public void Meow()
        {
            Console.WriteLine("miauw");
        }
        public void Eat()
        {
            Console.WriteLine("eating mice");
        }

    }
}
