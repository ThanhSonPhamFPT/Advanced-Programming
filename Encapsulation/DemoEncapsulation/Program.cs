using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lab4();
        }
        static void Lab1()
        {
            try
            {
                var lines = int.Parse(Console.ReadLine());
                var persons = new List<Person>();
                for (int i = 0; i < lines; i++)
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                    persons.Add(person);
                }
                persons.OrderBy(p => p.FirstName)
                   .ThenBy(p => p.Age)
                   .ToList()
                   .ForEach(p => Console.WriteLine(p.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        static void Lab2()
        {

            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                // Console.WriteLine(cmdArgs[3]);
                try
                {
                    var person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //   Console.WriteLine(ex.StackTrace);
                }
            }
            var bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
        static void Lab4()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                // Console.WriteLine(cmdArgs[3]);
                try
                {
                    var person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //   Console.WriteLine(ex.StackTrace);
                }
            }
            Team team = new Team("SoftUni");
            foreach (var person in persons)
            {
                team.AddPlayer(person);
            }
            //foreach(var person in persons)
            //{
            //    team.FirstTeam.Add(person);
            //}
            Console.WriteLine($"First team has {team.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players");
        }
        
    }
}
