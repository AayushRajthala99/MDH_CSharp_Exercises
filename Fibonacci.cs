using System;

public class Fibonacci
{
    public static void Main(string[] args)
    {
        // 0 1 1 2 3 5 8 13 21 ....

        int range = 30;

        int previousValue = 0;
        int nextValue = 1;
        int sum = 0;

        Console.WriteLine(previousValue);
        Console.WriteLine(nextValue);

        for (int i = 0; i <= range; i++)
        {
            sum = previousValue + nextValue;
            Console.WriteLine(sum);
            previousValue = nextValue;
            nextValue = sum;
        }
    }
}