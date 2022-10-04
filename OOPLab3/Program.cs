using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab3
{
    class Rectangle
    {
        private double side1, side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public Rectangle() { }

        double AreaCalculator()
        {
            return side1 * side2;
        }
        double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
        public double Area { get { return this.AreaCalculator(); } }
        public double Perimeter { get { return this.PerimeterCalculator(); } }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle");
            string x = Console.ReadLine();
            double side1 = Int32.Parse(x);

            Console.WriteLine("enter the width of the rectangle");
            string y = Console.ReadLine();
            double side2 = Int32.Parse(y);

            Rectangle rect = new Rectangle(side1, side2);

            Console.WriteLine("area = {0}", rect.Area);
            Console.WriteLine("Perimeter = {0}", rect.Perimeter);

        }
    }
}
