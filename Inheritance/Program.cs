using System;
using System.Collections.Generic;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lab5v1();
        }
        static void Lab1()
        {
            Dog  dog = new Dog();
            dog.Eat();
            dog.Bark();
        }
        static void Lab2()
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
        static void Lab3()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }

        static void Lab4()
        {
            RandomList myList = new RandomList();
            myList.Add("My Name");
            myList.Add("Hello");
            myList.Add("Goodbye");
            myList.Add("Welcome");
            myList.Add("Do you know me?");
            Console.WriteLine($"Remove the element {myList.RemoveRandomElement()}");
            myList.ForEach(my => Console.WriteLine(my));
        }
        static void Lab5v1()
        {
            StackOfStrings myStack = new StackOfStrings();
            myStack.Push("Hello");
            myStack.Push("Goodbye");
            List<String> myList = new List<String>();
            myList.Add("My Name");
            myList.Add("Hello");
            myList.Add("Goodbye");
            myList.Add("Welcome");
            myList.Add("Do you know me?");
            myStack.AddRange(myList);
            while (!myStack.IsEmpty())
            {
                Console.WriteLine(myStack.Pop());
            }
        }
    }
}
