using System;

public class PrimeNumber
{
    public static void Main(string[] args)
    {
        static bool isPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }

            int halfIndex = number / 2;

            for (int i = 2; i <= halfIndex; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        int primecount = 0;
        int startnumber = 1;
        // Console.WriteLine("Enter a number to check prime: ");
        // string inputnumber = Console.ReadLine();

        // int parsedNumber = int.Parse(inputnumber);

        // if (isPrime(parsedNumber)) {
        //   Console.WriteLine(parsedNumber + " is a Prime!");
        // } else {
        //   Console.WriteLine(parsedNumber + " is not a Prime!");
        // }

        while (primecount != 100)
        {
            if (isPrime(startnumber))
            {
                Console.WriteLine(startnumber);
                primecount++;
            }
            startnumber++;
        }
    }
}