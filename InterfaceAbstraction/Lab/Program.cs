using System;

namespace InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lab2();

        }
        void test()
        {
            Document doc = new Document();
            doc.Print();
            IPrintable printable = new Document();
            printable.Print();
        }
        static void Lab1()
        {
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);

            circle.Draw();
            rect.Draw();

        }
        static void Lab2()
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());

        }
    }
}
