using System;
using System.Collections.Generic;
using System.Text;


namespace CircleArea_Redux
{
    class Circle
    {
        public double Radius { get; set; }
        public double Circumference => (Radius * 2) * Math.PI;
        public double Area => Radius * Radius * Math.PI;

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override string ToString()
        {
            string response = "Radius: " + Radius.ToString("0.00") + "\n";
            response += "Circumference:" +  Circumference.ToString("0.00") + "\n";
            response += "Area:" + Area.ToString("0.00");
            return response;
        }
    }
}
