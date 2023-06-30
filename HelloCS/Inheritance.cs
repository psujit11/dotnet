using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System;

public abstract class Shape
{
    public  abstract double GetArea();

    public abstract double GetCircumference();
}

public class Rectangle : Shape
{
    public double Lenght{ get; set; }
    public double Breadth{ get; set; }

    public override double GetArea() => Lenght * Breadth;

    public override double GetCircumference()  => 2 *(Lenght * Breadth);

}

public class Square: Rectangle
{
   public  Square (double side)
   {
    base.Lenght = side;
    base.Breadth = side;
   } 
   
}

public class Circle: Shape
{
    public double Radius { get; set; }
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetCircumference() => 2* Math.PI * Radius;
   
}