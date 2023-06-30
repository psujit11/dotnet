using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System;

public abstract class Shape
{
    public  abstract double GetArea();

    public abstract double GetCircumference();

    // abstarct lekhya jati lai taala override garnai paraxa  yedi override hos pani nahos pani huney vaye virtual use garney

    public virtual void PrintResult()  
    {
        Console.WriteLine("Printing results for shape");
    }
}

interface IDiagonalComputable
{
    public double GetDiagonal();
}

    public class Rectangle : Shape, IDiagonalComputable
{
    public double Lenght{ get; set; }
    public double Breadth{ get; set; }

    public Rectangle (double lenght, double breadth)
    {
        Lenght = lenght;
        Breadth = breadth;
    }

    public override double GetArea() => Lenght * Breadth;

    public override double GetCircumference()  => 2 *(Lenght * Breadth);

    

    public override void PrintResult() 
    {
        Console.WriteLine($" Printing result of Shape [{Lenght}x{Breadth}]:");
        Console.WriteLine($"Area : {this.GetArea()}");
        Console.WriteLine($"Circumference : {this.GetCircumference()}");

    }

    public double GetDiagonal() => Math.Sqrt(Lenght * Lenght + Breadth * Breadth);
}

public class Square: Rectangle
{
   public  Square (double side) : base (side,side)
   { }
}

public class Circle: Shape
{
    public double Radius { get; set; }
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetCircumference() => 2* Math.PI * Radius;
   
}

/* summary class ko naming standard use garya xaina.
    class is inherited and interface is implemented.
 class a
 {}
  
class b:a
{}

class c:b
{}

.. yeta samma multi level .
c# dooes not support multilple inheritance
 multiple base class bata aauta inherited garna mildaina but behaviuor inherit garnu xa bhane we use Interface in C#

 interface IA
 {}

 interface IB
 {}

 class d: c, IA,IB 
 {}

 class e:IA,IB 
// multiple inheritance achieved by using  interface in c#.



