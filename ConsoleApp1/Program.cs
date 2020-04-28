using System;


class Program
{
    public static void summation(int num)
    {
        int i;
        int sum = 0;
        for (i = 0; i < num + 1; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine(sum);
    }
    static void Main(string[] args)
    {
        summation(4);
    }
}

