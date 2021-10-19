using System;
using System.Collections.Generic;
using System.Text;

namespace CircleArea_Redux
{
    class CircleDB
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
                Console.WriteLine(CircleList[i]);
            }
        }
    }
}
