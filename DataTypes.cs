using System;

public class DataTypes
{
    public static void Main(string[] args)
    {
        // Part 1 & 2 : Variable Declaration and Value Assignment
        uint age = 25;
        float height = 1.75f;
        bool isGamer = true;
        char initial = 'J';
        string firstName = "John";

        // Part 3 : Performing Operations
        age++;
        height += 0.5f;
        bool isNotGamer = !isGamer;
        string uppercaseFirstName = firstName.ToUpper();
        string greeting = "Good Afternoon, " + uppercaseFirstName;

        // Part 4: Printing Values
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Gamer?: " + isGamer);
        Console.WriteLine("Not Gamer?: " + isNotGamer);
        Console.WriteLine("Initial: " + initial);
        Console.WriteLine(greeting);
    }
}