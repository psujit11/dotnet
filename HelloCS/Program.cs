// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using LearnCollection; 
using Access; 

// Note: actual namespace depends on the project name.

class Program
    {
        static void Main()
        {
           // Collection collections = new Collection();    
           // collections.LearnDictionary();

           Square square= new Square(23.45);
           Square square1= new Square(12);
           Square square2= new Square(0.99);
           
           var sqaureArea= square2.GetArea();

           Console.WriteLine($" The area of Sqaure is {sqaureArea}");
        }
    }


    
    
