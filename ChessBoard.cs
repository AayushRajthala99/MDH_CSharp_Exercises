using System;

public class ChessBoard
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-------CHESSBOARD-------");
        Console.WriteLine("Enter size: ");

        string inputString = "";
        inputString = Console.ReadLine();

        int size = 0;
        int.TryParse(inputString, out size);

        generateChessboard(size);
    }

    public static void generateChessboard(int count)
    {
        Console.WriteLine("\nCheckMate!");

        for (int row = 1; row <= count; row++)
        {
            char asciiChar = Convert.ToChar(64 + row);
            string position = asciiChar.ToString();
            for (int col = 1; col <= count; col++)
            {
                Console.Write(position + col + " ");
            }
            Console.WriteLine();
        }
    }
}