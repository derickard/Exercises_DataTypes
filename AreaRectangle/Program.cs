using System;
using System.Linq.Expressions;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = -1;
            double width = -1;

            do
            {
                Console.WriteLine("Enter length of rectangle");
                try
                {
                    length = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Input must be an number!", e);
                }
            } while (length < 0);

            do
            {
                Console.WriteLine("Enter width of rectangle");
                try
                {
                    width = double.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Input must be an number!", e);
                }
            } while (width < 0);


            Console.WriteLine($"Area of rectangle is {width * length}");
        }
    }
}
