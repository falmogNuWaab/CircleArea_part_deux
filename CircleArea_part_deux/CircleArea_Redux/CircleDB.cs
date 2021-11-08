using System;
using System.Collections.Generic;
using System.Text;

namespace CircleArea_Redux
{
    public class CircleDB
    {
        public List<Circle> CircleList { get; set; } = new List<Circle>();

        public void AddCircles(double radius)
        {
            CircleList.Add(new Circle(radius));
        }

        public string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string response = Console.ReadLine();

            return response;
        }

        public void PrintCircleList()
        {
            for(int i = 0; i < CircleList.Count; i++)
            {
                Console.WriteLine($"Circle {i + 1}: \n{CircleList[i]}");
            }
        }
        public bool KeepGoing()
        {
            Console.WriteLine("Would you like to add another circle?(y/n)");
            string response = Console.ReadLine();
            response = response.ToLower();
            if (response == "y")
            {
                return true;
            }
            else if (response == "n")
            {
                //Console.WriteLine("Goodbye");
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
