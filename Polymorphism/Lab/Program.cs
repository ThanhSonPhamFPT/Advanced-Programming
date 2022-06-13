using System;
using System.Collections.Generic;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lab3();
        }
        static void Lab1()
        {
            MathOperation mo = new MathOperation();
            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));

        }
        static void Lab2()
        {
            Animal cat = new Cat("Pesho", "Whiskas");
            Animal dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());

        }
        static void Lab3()
        {
            var shapes = new List<Shape>();

            shapes.Add(new Circle(3.5));
            shapes.Add(new Rectangle(3.5, 1.2));
            shapes.Add(new Rectangle(1.5, 1.5));
            shapes.Add(new Rectangle(3.4, 1.5));
            shapes.Add(new Circle(3.6));

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Draw());
            }

        }
    }
}
