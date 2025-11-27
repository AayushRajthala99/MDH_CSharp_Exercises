using System;

public class ImplicitExplicitOperatorPart1
{
    public static void Main()
    {
        Zombie z1 = 100; // Implicit conversion from int to Zombie
        Console.WriteLine(z1);

        int hp = (int)z1; // Explicit conversion from Zombie to int
        Console.WriteLine($"Zombie HP: {hp}");
    }
}

public class Zombie
{
    public int Hp;
    public static int Count = 0;

    public Zombie(int hp)
    {
        this.Hp = hp;
        Count++;
    }

    public static implicit operator Zombie(int hitpoint) => new Zombie(hitpoint);
    public static explicit operator int(Zombie z) => z.Hp;

    public override string ToString()
    {
        return $"Zombie(HP={Hp}, Count = {Count})";
    }
}

