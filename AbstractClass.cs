using System;

public class AbstractClass
{
    public static void Main(string[] args)
    {
        Geometry[] Shapes = { new Triangle(), new Square(), new Circle() };

        foreach (Geometry shape in Shapes)
        {
            Console.WriteLine(shape.GetType());
            shape.area();
            shape.volume();
            Console.WriteLine();
        }
    }
}

abstract class Geometry
{
    public abstract void area();
    public virtual void volume() => Console.WriteLine("Volume is the total space occupied by a 3D object.");
}

class Triangle : Geometry
{
    public override void area() => Console.WriteLine("Area of Triangle = 1/2 * base * height");
}

class Square : Geometry
{
    public override void area() => Console.WriteLine("Area of Square = side * side");
}

class Circle : Geometry
{
    public override void area() => Console.WriteLine("Area of Circle = π * radius * radius");

    public override void volume() => Console.WriteLine("Volume of Sphere = 4/3 * π * radius^3");
}