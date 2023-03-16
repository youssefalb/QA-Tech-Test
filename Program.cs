using System;

namespace QaTechTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter coordinate x of dot A:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A:");
            double y1 = double.Parse(Console.ReadLine());
              
            Console.WriteLine("Enter coordinate x of dot B:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B:");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinate x of dot C:");
            double x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C:");
            double y3 = double.Parse(Console.ReadLine());

            double distanceAB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double distanceBC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double distanceAC = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            bool isEquilateral = (distanceAB == distanceBC) && (distanceBC == distanceAC);
            bool isIsosceles = (distanceAB == distanceBC) || (distanceBC == distanceAC) || (distanceAB == distanceAC);
            bool isRight = false;
            if (!isEquilateral)
            {
                isRight = (Math.Pow(distanceAB, 2) + Math.Pow(distanceBC, 2) == Math.Pow(distanceAC, 2)) ||
                       (Math.Pow(distanceBC, 2) + Math.Pow(distanceAC, 2) == Math.Pow(distanceAB, 2)) ||
                       (Math.Pow(distanceAB, 2) + Math.Pow(distanceAC, 2) == Math.Pow(distanceBC, 2));
            }

            Console.WriteLine($"Is the triangle equilateral? {isEquilateral}");
            Console.WriteLine($"Is the triangle isosceles? {isIsosceles}");
            Console.WriteLine($"Is the triangle right? {isRight}");

            double perimeter = distanceAB + distanceBC + distanceAC;
            Console.WriteLine($"The perimeter of the triangle is: {perimeter}");


            for (int i = 0; i <= perimeter; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                    Console.WriteLine();

                }
            }
            Console.WriteLine();
        


    }
    }
}
