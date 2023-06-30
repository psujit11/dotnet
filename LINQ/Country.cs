using System;
using System.Linq;
using System.Collections.Generic;
public class Country
{
    public string Name { get; set;}
    public string Capital { get; set;}
    public string Continent{ get; set;} 
    public long Population{ get; set;}
    public DateTime IndependenceDay { get; set;}  

    public Country()
    {

    } 

    public Country (string name, string capital , string continent, long population ,DateTime i = default) 
    {
        Name = name;
        Capital = capital;
        Continent = continent;
        Population = population;
        IndependenceDay = i;    
    }

    /*  void LearnLinq()
    {
         //LINQ - Language INtegrated Query
    int [] numbers = {12,34,25,36,99,35,32,23,77,76,57,98,98};
            // Method syntax (lambda expression)
    var result1 =numbers.Where(num => num > 50).Select(num => num);
            // Query expression syntax
    var result2 = from num in numbers
                            where num > 50
                            select num;
            
            //Restrictions - where 

    var result3 = from num in numbers 
                            where num > 50 && num < 70 
                                select num;   

            // Projections - select
    var result4 = from num in numbers 
                            select num * num;

    var result5 = from num in numbers 
                            where num % 2==0
                            select num * num;
            // ordering- order by default ascenduing, orderby descending
    var ascending=from num in numbers   
                            orderby num
                             select num;

    var descending = from num in numbers
                                orderby num descending
                                select num;
            // partioning (take,skip is available only for  method syntax)
    var partition= numbers.Skip(5).Take(5);

    var result7= numbers.Any(num => num % 2==0);
    var result8 = numbers.All (num => num%2==0);
    var result9 = numbers.Contains(23);
    }
    */
    // this has been declared as astatic  to match with main so that it can be called wiothout creating any instance.

    public  void LearnLinqOnComplexCollection()
        {
        List<Country> countries = new List<Country>();

        Country c1 = new Country("Nepal","Kathmandu","Asia",264904503);
        Country c2 = new Country("India","Delhi","Asia",26490450333,DateTime.Parse("1947/11/1"));
        Country c3 = new Country("England","London","Europe",23311);
        Country c4 = new Country("Australia","Canberra","Australia",264000,DateTime.Parse("1997/11/1"));
        Country c5 = new Country("Bhutan","Thimpu","Asia",110101);
        Country c6 = new Country("China","Beijing","Asia",36490450333);

        countries.Add(c1);
        countries.Add(c2);
        countries.Add(c3);
        countries.Add(c4);
        countries.Add(c5);
        countries.Add(c6);


        // list all asian country names
        var asianCountry= from country in countries 
                            where country.Continent == "Asia"
                            select country.Name;

        // list all asain countries that were never invaded
        var sovereign= from country in countries 
                            where country.Continent == "Asia" && country.IndependenceDay == default(DateTime)
                            select country.Name;

           
        Console.WriteLine("Asoan countries :" + string.Join(",",asianCountry));
        Console.WriteLine("Sovereign Asian Countries :" + string.Join(",",sovereign));

        }    
}
    
