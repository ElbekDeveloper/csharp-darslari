using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArxitektorKalkulatori
{
    class Program
    {
        static double Rect(double width = 0, double length = 0)
        {
            return width * length;
        }

        static double Circle(double radius = 0)
        {
            return
                Math.PI * Math.Pow(radius, 2);
        }

        static double Triangle(double bottom = 0, double height = 0)
        {
            return
                (bottom * height) / 2;
        }
        
        static double CalculateTotalCost(double rectArea, 
            double circleArea, 
            double triangleArea, double Price)
        {
            return
                (rectArea + circleArea + triangleArea) * Price;
        }
        static void UserInput(out double width, out double length)
        {
            Console.WriteLine("Enter width and length of rect");
            width = Convert.ToDouble(Console.ReadLine());
            length = Convert.ToDouble(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            double width;
            double length;
            UserInput(out width, out length);
            Console.WriteLine(Rect(width, length));
        }
    }
}
