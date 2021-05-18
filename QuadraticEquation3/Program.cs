using System;

public class QuadraticEquation
{
    public static Tuple<double, double> FindRoots(double a, double b, double c)
    {
        double d, x1, x2;
        d = b * b - 4 * a * c;
        if (d == 0)
        {
            Console.Write("Both roots are equal.\n");
            x1 = -b / (2.0 * a);
            x2 = x1;
            Console.Write("First  Root Root1= {0}\n", x1);
            Console.Write("Second Root Root2= {0}\n", x2);
            return new Tuple<double, double>(x1, x2);
        }
        else if (d > 0)
        {
            Console.Write("Both roots are real and diff-2\n");

            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);

            Console.Write("First  Root Root1= {0}\n", x1);
            Console.Write("Second Root root2= {0}\n", x2);
            return new Tuple<double, double>(x1, x2);

        }
        else
        {
            Console.Write("Root are imeainary;\nNo Solution. \n\n");
            return null;
        }

    }

    public static void Main(string[] args)
    {
        Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
        Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);
        Console.ReadLine();
    }
}