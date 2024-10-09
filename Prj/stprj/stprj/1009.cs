using System;

class Program
{
    static void Main(string[] args)
    {
        int test = int.Parse(Console.ReadLine());
        string[] lines = new string[test];
        for(int i = 0 ; i < test; i++)
        {
            lines[i] = Console.ReadLine();
        }
        for (int i = 0; i < test; i++)
        {
            string[] line = lines[i].Split();
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);

            long result = a % 10;
            for (int j = 1; j < b; j++)
            {
                result = (result * a) % 10;
            }

            if (result == 0)
            {
                result = 10;
            }

            Console.WriteLine(result);
        }
    }
}