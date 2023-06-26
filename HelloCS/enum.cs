using System;

namespace EnumsandMethods
{
    enum DayWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    internal class Demo
    {

        public DayWeek DayWeek { get; set; }
        void PrintGreetings()
        {

            if (DayWeek == DayWeek.Saturday)
            {
                Console.WriteLine("It's a good saturday");
            }
            else if (DayWeek == DayWeek.Sunday)
            {
                Console.WriteLine("It's a good sunday");
            }
            else
            {
                Console.WriteLine("Oh gosh, work day");
            }
        }

    }
}