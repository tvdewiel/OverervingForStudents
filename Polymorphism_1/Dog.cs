using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_1
{
    public class Dog
    {
        public Dog(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public void Bark()
        {
            Console.WriteLine("bark");
        }
        public void Eat()
        {
            Console.WriteLine("eating dog food");
        }
    }
}
