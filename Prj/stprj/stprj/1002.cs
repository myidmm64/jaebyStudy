using System;

class Program
{
    static void Main(string[] args)
    {
        int t = 0;
        t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            string[] line = Console.ReadLine()!.Split(' ');
            int x1 = int.Parse(line[0]);
            int y1 = int.Parse(line[1]);
            int r1 = int.Parse(line[2]);
            int x2 = int.Parse(line[3]);
            int y2 = int.Parse(line[4]);
            int r2 = int.Parse(line[5]);

            var distSqrd = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            var sumRadSqrd = Math.Pow(r1 + r2, 2);
            var diffRadSqrd = Math.Pow(r1 - r2, 2);

            if (distSqrd == 0)
            {
                if (r1 == r2) Console.WriteLine(-1);
                else Console.WriteLine(0);
            }
            else if (distSqrd == sumRadSqrd || distSqrd == diffRadSqrd)
                Console.WriteLine(1);
            else if (distSqrd > diffRadSqrd && distSqrd < sumRadSqrd)
                Console.WriteLine(2);
            else Console.WriteLine(0);
        }
    }
}