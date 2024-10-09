using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b;
        string[] line = Console.ReadLine().Split(" ");
        a = double.Parse(line[0]);
        b = double.Parse(line[1]);

        Console.WriteLine(a / b);
    }
}