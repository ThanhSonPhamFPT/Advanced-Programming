using System;

namespace Abstraction
{
    public enum Season
    {
        Spring = 2,
        Summer = 4,
        Autumn = 1,
        Winter = 3
    }
    public enum Discount
    {
        None,
        SecondVisit = 10,
        VIP = 20
    }
    internal class Program
    {
        enum Day { Monday, Tuesday =10, Wednesday, Thursday=20, Friday, Saturday, Sunday };
        

        static void Main(string[] args)
        {
            // RhombusOfStars();
           // Console.WriteLine((int)Day.Wednesday);
            Lab4();
        }
        static void RhombusOfStars()
        {
            int size = int.Parse(Console.ReadLine());
            //Print the upper triangle
            for (int stCount = 1; stCount <= size; stCount++)
                PrintRow(size, stCount);
            //Print the lower triangle
            for (int stCount = size - 1; stCount >= 1; stCount--)
                PrintRow(size, stCount);

        }
        static void PrintRow(int figureSize, int starCount)
        {
            //Print the spaces before * symbol
            for (int i = 0; i < figureSize - starCount; i++)
                Console.Write(" ");
            //Print the * symbols in the row
            for (int col = 1; col < starCount; col++)
                Console.Write("* ");
            //Print the last * and go to the next line
            Console.WriteLine("*");
        }
        static void Lab1()
        {
            //Read coordinate of the rectangle
            string inputLine = Console.ReadLine();
            string[] rectCoordinatesAsText = inputLine.Split();
            
            //Create Rectangle rect
            Rectangle newRect = new Rectangle(int.Parse(rectCoordinatesAsText[0]),
                int.Parse(rectCoordinatesAsText[1]),
                int.Parse(rectCoordinatesAsText[2]),
                int.Parse(rectCoordinatesAsText[3]));
            // Read the number N of Points
            int N = int.Parse(Console.ReadLine());
            Point[] myPointArray = new Point[N];
            //Read and create N points
            for (int i = 0; i < N;i++)
            {
                inputLine = Console.ReadLine();
                string[] pointCoordinates = inputLine.Split();
                myPointArray[i] = new Point(int.Parse(pointCoordinates[0]),
                    int.Parse(pointCoordinates[1]));
            }
            //Call the method rect.Contains(point) for the N points and
            //print the result to the screen
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(newRect.Contains(myPointArray[i]));
            }
        }
        static void Lab3()
        {
            StudentManager myStudentManager = new StudentManager();
            myStudentManager.Run();
        }
        static void Lab4()
        {
            do
            {
                string command = Console.ReadLine();
                var cmdArgs = command.Split();
                if (cmdArgs[0] == "Exit")
                {
                    break;
                }
                Season season = (Season)Enum.Parse(typeof(Season),cmdArgs[2]);
                Discount discount;
                if (cmdArgs.Length > 3)
                {
                    discount = (Discount)Enum.Parse(typeof(Discount), cmdArgs[3]);
                    
                } else {
                    discount = Discount.None;
                }
                Console.WriteLine(PriceCalculator.CalculatePrice(decimal.Parse(cmdArgs[0]),int.Parse(cmdArgs[1])
                    , season, discount));
                
            } while (true) ;
        }
    }
}
