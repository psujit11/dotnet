// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace LINQ// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            //LINQ - Language INtegrated Query
            int [] numbers ={12,34,25,36,99,35,32,23,77,76,57,54,43,78,89,98,98,98};
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

            var result4 = from num in numbers 
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
        }
    }
}
