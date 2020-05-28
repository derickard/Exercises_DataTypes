using System;

namespace GasMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter miles driven: ");
            double miles = double.Parse(Console.ReadLine());
            Console.Write("Enter gallons of gas consumed: ");
            double gas = double.Parse(Console.ReadLine());
            Console.WriteLine($"Gas mileage is {miles / gas} mpg");
        }
    }
}
