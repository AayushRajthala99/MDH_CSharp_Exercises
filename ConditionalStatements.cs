// Solution using existing exception classes

using System;

public class NegativeIntegerException : Exception
{
    public NegativeIntegerException(string message) : base(message) { }
}

public class ConditionalStatements
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter your age: ");
            string inputAge = Console.ReadLine();

            int parsedAge = int.Parse(inputAge);

            // int.TryParse(inputAge, out parsedAge);

            if (parsedAge < 0)
            {
                throw new NegativeIntegerException("Invalid age");
            }
            else if (parsedAge < 18)
            {
                Console.WriteLine("You are a minor");
            }
            else if (parsedAge >= 18 && parsedAge <= 65)
            {
                Console.WriteLine("You are a adult");
            }
            else if (parsedAge > 65)
            {
                Console.WriteLine("You are a senior citizen");
            }
        }
        catch (NegativeIntegerException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input");
        }
    }
}