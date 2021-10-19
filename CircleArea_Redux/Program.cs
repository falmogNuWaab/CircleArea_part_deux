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
                keepGoing = KeepGoing();
            }
            circleDB.PrintCircleList();

        }
        public static bool KeepGoing()
        {
            Console.WriteLine("Would you like to add another circle?(y/n)");
            string response = Console.ReadLine();
            response = response.ToLower();
            if(response == "y")
            {
                return true;
            } else if(response == "n")
            {
                Console.WriteLine("Goodbye");
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that");
                return KeepGoing();
            }
        }
    }
}
