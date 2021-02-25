using Polymorphism;
using System;
using System.Collections.Generic;

namespace ConsoleAppBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ////1
            //Animal a = new Animal("Leo");
            //Console.WriteLine(a);
            //a.Eat();
            //Console.WriteLine("-------------------");
            //Dog d = new Dog("Santa");
            //Console.WriteLine(d);
            //d.Eat();
            //Console.WriteLine("-------------------");
            //Cat c = new Cat("Snowball");
            //Console.WriteLine(c);
            //c.Eat();
            //Console.WriteLine("-------------------");
            //Console.WriteLine("-------------------");

            ////2
            //Animal a = new Animal("Leo");
            //Console.WriteLine(a);
            //a.MakeNoise();
            //a.Eat();
            //Console.WriteLine("-------------------");
            //Dog d = new Dog("Santa");
            //Console.WriteLine(d);
            //d.MakeNoise();
            //d.Eat();
            //Console.WriteLine("-------------------");
            //Cat c = new Cat("Snowball");
            //Console.WriteLine(c);
            //c.MakeNoise();
            //c.Eat();
            //Console.WriteLine("-------------------");
            //Console.WriteLine("-------------------");


            //3
            Animal a = new Animal("Leo");
            Console.WriteLine(a);
            Console.WriteLine("-------------------");
            Dog d = new Dog("Santa");
            Console.WriteLine(d);
            Console.WriteLine("-------------------");
            Cat c = new Cat("Snowball");
            Console.WriteLine(c);
            Console.WriteLine("-------------------");
            List<Animal> animals = new List<Animal>();
            animals.Add(a);
            animals.Add(d);
            animals.Add(c);
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
                animal.MakeNoise();
                animal.Eat();
                Console.WriteLine("-------------------");
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("-------------------");
            //Animal a1 = (Animal)d;
            //Console.WriteLine(a1);
            //d.MakeNoise();// Calls the new method.
            //a1.MakeNoise();// Calls the old method.
            //a1.Eat();

        }
    }
}
