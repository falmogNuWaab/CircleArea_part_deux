using System;

namespace CircleArea_Redux
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleDB circleDB = new CircleDB();
            Console.WriteLine("Welcome to the Circle Lab");
            bool keepGoing = true;

            while (keepGoing)
            {
                string radius = circleDB.GetUserInput("Please enter a radius, and we will calculate a circle: ");
                try
                {
                    double newRadius = double.Parse(radius);
                    circleDB.AddCircles(newRadius);
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not a valid input, please try again");
                    continue;
                }
                catch
                {
                    continue;
                }
                keepGoing = CircleDB.KeepGoing();
            }
            Console.WriteLine("Here are your circles: \n");
            circleDB.PrintCircleList();
            Console.WriteLine("\n\nGoodbye!");
            
        }

    }
}
