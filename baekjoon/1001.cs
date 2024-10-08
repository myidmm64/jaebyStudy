using System;

class Program
{
    static void Main(string[] args)
    {
        int t = 0;
        string? tst = Console.ReadLine();
        t = int.Parse(tst);
        Console.WriteLine(t.ToString());
        for (int i = 0; i < t; i++)
        {
            Vector2 v1, v2;
            int r1, r2;
            string[] line = Console.ReadLine().Split(" ");
            v1.x = int.Parse(line[0]);
            v1.y = int.Parse(line[1]);
            r1 = int.Parse(line[2]);
            v2.x = int.Parse(line[3]);
            v2.y = int.Parse(line[4]);
            r2 = int.Parse(line[5]);

            Vector2 dir = new Vector2(v2.x - v1.x, v2.y - v1.y);
            int distance = (int)Math.Sqrt(dir.x * dir.x + dir.y * dir.y);
            Console.WriteLine(distance);
        }
    }
}

public struct Vector2
{
    public Vector2(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int x, y;
}