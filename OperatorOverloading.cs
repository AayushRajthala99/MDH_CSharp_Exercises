using System;

public class ImplicitExplicitOperator
{
    public static void Main()
    {
        Zombie z1 = new Zombie(100);
        Console.WriteLine(z1);

        Zombie z2 = new Zombie(150);
        Console.WriteLine(z2);

        Zombie z3 = z1 + z2; // Using overloaded + operator
        Console.WriteLine(z3);
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

    public static Zombie operator +(Zombie z1, Zombie z2)
    {
        return new Zombie(z1.Hp + z2.Hp);
    }
    public override string ToString()
    {
        return $"Zombie(HP={Hp}, Count = {Count})";
    }
}

