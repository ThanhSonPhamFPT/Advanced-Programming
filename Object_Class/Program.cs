using System;
using System.Globalization;
using System.Numerics;

namespace DemoClassObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // var birthday = new {Day = 20, Month = 1, Year = 2000};
           // Console.WriteLine(birthday.Day);
           // var day = new DateTime(2022, 5, 23);
           // Console.WriteLine(day.DayOfWeek);
           // var date2 = new DateTime(2022, 5, 25);
           // Console.WriteLine(date2.DayOfYear);
           //// string dateAsText = Console.ReadLine();
           ////  var day2 = DateTime.ParseExact(dateAsText,"yyyy-M-d", CultureInfo.InvariantCulture);
           //// Console.WriteLine(day2.DayOfWeek);
           // DateTime date = DateTime.Today;
           // DateTime date3 = DateTime.Now;
           // Console.WriteLine(date3);
           // Console.WriteLine(date);
           // Random rnd = new Random();
           // Console.WriteLine(rnd.Next(11));
           // //int n = int.Parse(Console.ReadLine());
           // //BigInteger f = 1;
           // //for( int i = 1; i <= n; i++)
           // //{
           // //    f *= i;
           // //}
           // //Console.WriteLine(f);
            //Dice dice1 = new Dice(6);
            //Console.WriteLine(dice1.Roll());
            //Dice dice2 = new Dice(2);
            //Console.WriteLine(dice2.Roll());
            Lab2();
        }
        static void Lab1()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Id = 3;
            bankAccount.Balance = 20;
            Console.WriteLine($"Account Id {bankAccount.Id}, balance {bankAccount.Balance}");
        }
        static void Lab2()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Id = 3;
            bankAccount.Deposit(15);
            bankAccount.Withdraw(10);
            Console.WriteLine(bankAccount);

        }
    }
}
