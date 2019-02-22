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
            int s1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the second side of the triangle: ");
            int s2 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the third side of the triangle: ");
            int s3 = Int32.Parse(Console.ReadLine());

            double p = (s1 + s2 + s3) / 2.0;
            //2.0 is to make the division work as a double 

            double val = p * (p - s1) * (p - s2) * (p - s3);
           

            double answer = Math.Sqrt(val);
           

            Console.WriteLine($"The area of this triangle is {answer}.");

            Console.ReadLine();

        }
    }
}
