using System;

class Program
{
    static void Main(string[] args)
    {
        string? input = Console.ReadLine();
        if(input != null)
        {
            string[] datas = input.Split(" ");
            if (datas.Length == 2)
            {
                int a = int.Parse(datas[0]);
                int b = int.Parse(datas[1]);
                Console.WriteLine(a - b);
            }
        }
    }
}