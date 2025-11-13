using System;

public class LoopStairs
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-------Loop Stairs-------");
        Console.WriteLine("Enter steps: ");

        string inputString = "";
        inputString = Console.ReadLine();

        int steps = 0;
        int.TryParse(inputString, out steps);

        generateStairs(steps);
        generateReverseStairs(steps);
    }

    public static void generateStairs(int count)
    {
        Console.WriteLine("\nForward Stairs!");

        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine(new String('#', i));
        }
    }

    public static void generateReverseStairs(int count)
    {
        Console.WriteLine("\nReverse Stairs!");

        for (int i = 1; i <= count; i++)
        {
            string Gap = new String(' ', count - i);
            string displayString = new String('#', i);
            Console.WriteLine(Gap + displayString);
        }
    }
}