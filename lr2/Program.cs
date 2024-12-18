using System;

namespace lr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three real numbers (x, y, z):");

            Console.Write("Enter x: ");
            double x;
            try
            {
                x = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input for x. Please enter a valid number.");
                return;
            }

            Console.Write("Enter y: ");
            double y;
            try
            {
                y = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input for y. Please enter a valid number.");
                return;
            }

            Console.Write("Enter z: ");
            double z;
            try
            {
                z = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input for z. Please enter a valid number.");
                return;
            }

            double numerator = (2 * Math.Cos(Math.Pow(x, 2))) - (1 / Math.Sqrt(2)) + Math.Pow(Math.E, 2);
            double denominator = (2.0 / 3) + Math.Sin(Math.Pow(y, 2) - z);

            if (Math.Abs(denominator) < 1e-9) 
            {
                Console.WriteLine("Error: Division by zero.");
                return;
            }

            double s = numerator / denominator;

            Console.WriteLine($"Result (s): {s:F3}");
        }
    }
}
