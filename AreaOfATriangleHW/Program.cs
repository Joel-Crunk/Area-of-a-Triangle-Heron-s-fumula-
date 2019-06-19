using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfATriangleHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first side of the triangle: ");
            int side1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the second side of the triangle: ");
            int side2 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the third side of the triangle: ");
            int side3 = Int32.Parse(Console.ReadLine());

            double halfPerimeter = (side1 + side2 + side3) / 2.0;
            //2.0 is to make the division work as a double 

            double val = halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3);
            double answer = Math.Sqrt(val);
           
            Console.WriteLine($"The area of this triangle is {answer}.");
            Console.ReadLine();
        }
    }
}
